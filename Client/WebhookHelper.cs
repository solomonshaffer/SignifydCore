using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SignifydCore.Client.Model;

namespace SignifydCore.Client
{
    public class WebhookHelper
    {
        private readonly Settings _settings;

        public WebhookHelper(Settings settings)
        {
            _settings = settings;
        }

        public async Task<WebhooksResponse> CreateWebhooks(WebhooksRequest webhooksRequest)
        {
            using var httpClient = new HttpClient {BaseAddress = _settings.BaseAddress};
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Basic {_settings.Key}");

            using var content = new StringContent(JsonConvert.SerializeObject(webhooksRequest), Encoding.Default, "application/json");
            using var response = await httpClient.PostAsync("teams/webhooks", content);
            var responseData = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<WebhooksResponse>(responseData);
        }

        public async Task<WebhooksResponse> UpdateWebhooks(WebhooksRequest webhooksRequest)
        {
            using var httpClient = new HttpClient {BaseAddress = _settings.BaseAddress};
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Basic {_settings.Key}");

            using var content = new StringContent(JsonConvert.SerializeObject(webhooksRequest), Encoding.Default, "application/json");
            using var response = await httpClient.PutAsync("teams/webhooks", content);
            var responseData = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<WebhooksResponse>(responseData);
        }

        public async Task<WebhooksResponse> RetrieveWebbhooks()
        {
            using var httpClient = new HttpClient {BaseAddress = _settings.BaseAddress};
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Basic {_settings.Key}");

            using var response = await httpClient.GetAsync("teams/webhooks");
            var responseData = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<WebhooksResponse>(responseData);
        }

        public async Task<WebhooksResponse> UpdateWebhook(int id, string url)
        {
            using var httpClient = new HttpClient {BaseAddress = _settings.BaseAddress};
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Basic {_settings.Key}");

            using var content = new StringContent("{\"url\": \"" + url + "\"}", Encoding.Default, "application/json");
            using var response = await httpClient.PutAsync($"teams/webhooks/{id}", content);
            var responseData = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<WebhooksResponse>(responseData);
        }

        public async void DeleteWebhook(int id)
        {
            using var httpClient = new HttpClient {BaseAddress = _settings.BaseAddress};
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Basic {_settings.Key}");

            using var response = await httpClient.DeleteAsync($"teams/webhooks/{id}");
            var responseData = await response.Content.ReadAsStringAsync();
        }
    }
}