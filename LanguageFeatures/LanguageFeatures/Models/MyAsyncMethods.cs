using System.Threading.Tasks;
using System.Net.Http;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();

            var httpMessage = await client.GetAsync("http://apress.com");

            //We could do other things while we are waiting 
            //for the HTTP request to complete
            return httpMessage.Content.Headers.ContentLength;            
        }
    }
}