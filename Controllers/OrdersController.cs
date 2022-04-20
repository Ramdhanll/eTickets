using System.Threading.Tasks;
using eTickets.Cart;
using eTickets.Services;
using eTickets.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
   public class OrdersController : Controller
   {
      private readonly IMoviesService _moviesService;
      private readonly ShoppingCart _shoppingCart;
      private readonly IOrdersService _orderService;


      public OrdersController(IMoviesService moviesService, ShoppingCart shoppingCart, IOrdersService orderService)
      {
         _moviesService = moviesService;
         _shoppingCart = shoppingCart;
         _orderService = orderService;
      }

      public async Task<IActionResult> Index()
      {
         string userId = "";
         var orders = await _orderService.GetOrdersByUserIdAsync(userId);

         return View(orders);
      }

      public IActionResult ShoppingCart()
      {
         var items = _shoppingCart.GetShoppingCartItems();
         _shoppingCart.ShoppingCartItems = items;

         var response = new ShoppingCartVM()
         {
            ShoppingCart = _shoppingCart,
            ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
         };

         return View(response);
      }

      public async Task<RedirectToActionResult> AddItemToShoppingCart(int id)
      {
         var item = await _moviesService.GetMovieByIdAsync(id);

         if (item != null)
         {
            _shoppingCart.AddItemToCart(item);
         }

         return RedirectToAction(nameof(ShoppingCart));
      }

      public async Task<RedirectToActionResult> RemoveItemFromShoppingCart(int id)
      {
         var item = await _moviesService.GetMovieByIdAsync(id);

         if (item != null)
         {
            _shoppingCart.RemoveItemFromCart(item);
         }

         return RedirectToAction(nameof(ShoppingCart));
      }

      public async Task<IActionResult> CompletedOrder()
      {
         var items = _shoppingCart.GetShoppingCartItems();
         string userId = "";
         string userEmailAddress = "";

         await _orderService.StoreOrderAsync(items, userId, userEmailAddress);
         await _shoppingCart.ClearShoppingCartAsync();

         return View("OrderCompleted");
      }

   }
}