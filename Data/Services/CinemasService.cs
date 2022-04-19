using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Base;
using eTickets.Data;
using eTickets.Models;

namespace eTickets.Services
{
   public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
   {
      public CinemasService(AppDbContext context) : base(context)
      {
      }
   }
}