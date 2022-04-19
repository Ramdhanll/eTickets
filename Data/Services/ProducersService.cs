using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Base;
using eTickets.Data;
using eTickets.Models;

namespace eTickets.Services {
   public class ProducersService : EntityBaseRepository<Producer>, IProducersService
   {

      public ProducersService(AppDbContext context) : base(context)
      {
         
      }
   }
}