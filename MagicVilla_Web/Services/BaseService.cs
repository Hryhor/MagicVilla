using MagicVilla_Web.Models;
using MagicVilla_Web.Services.IServices;
using Newtonsoft.Json;
using System.Text;
using Villa_Utility;

namespace MagicVilla_Web.Services
{
    public class BaseService : IBaseService
    {
        public APIResponse responseModel { get; set; }
        public IHttpClientFactory httpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseModel = new APIResponse();
            this.httpClient = httpClient;
        }

        public async Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            try
            {
                var client = httpClient.CreateClient("MagicAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);

                if (apiRequest.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data),
                        Encoding.UTF8, "application/json");
                }

                switch(apiRequest.ApiType) {
                    case SD.ApiType.POST:
                        message.Method = HttpMethod.Post; 
                        break;

                    case SD.ApiType.PUT:
                        message.Method = HttpMethod.Put; 
                        break;

                    case SD.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;

                    case SD.ApiType.GET:
                        message.Method = HttpMethod.Get;
                        break;
                }

                HttpResponseMessage apiResponce = null;
                apiResponce = await client.SendAsync(message);
                var apiContent = await apiResponce.Content.ReadAsStringAsync();
                var APIResponce = JsonConvert.DeserializeObject<T>(apiContent);

                return APIResponce;

            } 
            catch (Exception ex)
            {
                var dto = new APIResponse
                {
                    ErrorMessages = new List<string> { ex.Message },
                    IsSuccess = false
                };

                var res = JsonConvert.SerializeObject(dto);
                var APIResponce = JsonConvert.DeserializeObject<T>(res);

                return APIResponce;
            }
        }
    }
}
