using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace InMemory.Caching.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController(IMemoryCache memoryCache) : ControllerBase
    {
        // POST api/values - Bir değeri belleğe kaydeder
        [HttpPost]
        public void Set(string name)
        {
            memoryCache.Set("name", name); // Bellekte "name" anahtarı ile değeri saklar
        }

        // GET api/values - Bellekten bir değer alır
        [HttpGet]
        public string Get()
        {
            // Bellekte "name" anahtarı ile bir değer var mı diye kontrol eder
            if (memoryCache.TryGetValue("name", out string? name))
            {
                return name ?? ""; // Değer varsa geri döner
            }
            // Bellekte "name" anahtarı ile bir değer yoksa boş string döner
            return string.Empty;
        }

        #region absolute ve sliding

        // POST api/values/setdate - Tarihi belleğe kaydeder
        [HttpPost("[action]")]
        public void SetDate()
        {
            // Bellekte "date" anahtarı ile şu anki zamanı saklar
            memoryCache.Set<DateTime>("date", DateTime.Now, options: new MemoryCacheEntryOptions()
            {
                // Kesin sona erme süresi 30 saniye olarak ayarlanır
                AbsoluteExpiration = DateTime.Now.AddSeconds(30),
                // Kayma sona erme süresi 5 saniye olarak ayarlanır
                SlidingExpiration = TimeSpan.FromSeconds(5)
            });
        }

        // GET api/values/getdate - Bellekteki tarihi alır
        [HttpGet("[action]")]
        public DateTime GetDate()
        {
            // Bellekte "date" anahtarı ile saklanan tarihi geri döner
            return memoryCache.Get<DateTime>("date");
        }

        #endregion
    }
}
