using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model1.Models;

namespace Model1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly MapDbContext db;

        public ValuesController(MapDbContext aa)
        {
            db = aa;
        }
    }
}
