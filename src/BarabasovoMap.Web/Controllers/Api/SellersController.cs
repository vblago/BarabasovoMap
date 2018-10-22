using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BarabasovoMap.Database.Models;
using BarabasovoMap.Database;
using Microsoft.EntityFrameworkCore;

namespace BarabasovoMap.Web.Controllers.Api
{
    [Route("api/[controller]")]
    public class SellersController : Controller
    {
        private BarabasovoDbContext context { get; }

        public SellersController(BarabasovoDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ICollection<Seller>> Get()
        {
            return await this.context.Sellers
                .Where(seller => seller.FirstName == "Bob")
                .OrderBy(seller => seller.LastName)
                .ToListAsync();
        }
    }
}
