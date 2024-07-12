using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace Distributed.Caching.Controllers
{
    // API Controller'ı ve route tanımlaması
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController(IDistributedCache distributedCache) : ControllerBase
    {
        // POST api/values - Verileri dağıtık önbelleğe (distributed cache) kaydeder
        [HttpPost]
        public async Task<IActionResult> Set(string name, string surname)
        {
            // "name" anahtarı ile string verisini dağıtık önbelleğe kaydeder
            await distributedCache.SetStringAsync("name", name, options: new DistributedCacheEntryOptions
            {
                // Kesin sona erme süresi 30 saniye olarak ayarlanır
                AbsoluteExpiration = DateTime.Now.AddSeconds(30),
                // Kayma sona erme süresi 5 saniye olarak ayarlanır
                SlidingExpiration = TimeSpan.FromSeconds(5)
            });

            // "surname" anahtarı ile byte verisini dağıtık önbelleğe kaydeder
            await distributedCache.SetAsync("surname", Encoding.UTF8.GetBytes(surname), options: new DistributedCacheEntryOptions
            {
                // Kesin sona erme süresi 30 saniye olarak ayarlanır
                AbsoluteExpiration = DateTime.Now.AddSeconds(30),
                // Kayma sona erme süresi 5 saniye olarak ayarlanır
                SlidingExpiration = TimeSpan.FromSeconds(5)
            });

            // HTTP 200 OK yanıtı döner
            return Ok();
        }

        // GET api/values - Dağıtık önbellekten (distributed cache) verileri alır
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // "name" anahtarı ile string verisini dağıtık önbellekten alır
            var name = await distributedCache.GetStringAsync("name");

            // "surname" anahtarı ile byte verisini dağıtık önbellekten alır
            var surnameByte = await distributedCache.GetAsync("surname");

            // Byte verisini UTF-8 string'e dönüştürür
            var surname = surnameByte is null ? string.Empty : Encoding.UTF8.GetString(surnameByte);

            // Alınan verileri JSON formatında HTTP 200 OK yanıtı ile döner
            return Ok(new { name, surname });
        }
    }
}