using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SignifydCore.Client.Model;

namespace SignifydCore.Client
{
    public class EventHelper
    {
        private readonly Settings _settings;

        public EventHelper(Settings settings)
        {
            _settings = settings;
        }

        public async Task<SendFulfillmentResponse> SendFulfillment(int orderId, SendFulfillmentRequest sendFulfillmentRequest)
        {
            using var httpClient = new HttpClient {BaseAddress = _settings.BaseAddress};

            using var content = new StringContent(JsonConvert.SerializeObject(sendFulfillmentRequest), Encoding.Default, "application/json");
            using var response = await httpClient.PostAsync($"fulfillments/{orderId}", content);
            var responseData = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<SendFulfillmentResponse>(responseData);
        }

        public async Task<SendTransactionResponse> SendTransaction(SendTransactionRequest sendTransactionRequest)
        {
            using var httpClient = new HttpClient {BaseAddress = _settings.BaseAddress};
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Basic {_settings.Key}");

            using var content = new StringContent(JsonConvert.SerializeObject(sendTransactionRequest), Encoding.Default, "application/json");
            using var response = await httpClient.PostAsync("transactions", content);
            var responseData = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<SendTransactionResponse>(responseData);
        }

        public async Task<int> SubmitGuarantee(int caseId)
        {
            using var httpClient = new HttpClient {BaseAddress = _settings.BaseAddress};
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Basic {_settings.Key}");

            using var content = new StringContent("{\"caseId\": " + caseId + "\"}", Encoding.Default, "application/json");
            using var response = await httpClient.PostAsync("async/guarantees", content);

            return caseId;
        }

        public async Task<CancelGuaranteeResponse> CancelGuarantee(int caseId)
        {
            using var httpClient = new HttpClient {BaseAddress = _settings.BaseAddress};
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Basic {_settings.Key}");

            using var content = new StringContent("{\"guaranteeDisposition\": \"CANCELED\"}", Encoding.Default, "application/json");
            using var response = await httpClient.PutAsync($"cases/{caseId}/guarantee", content);
            var responseData = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CancelGuaranteeResponse>(responseData);
        }
    }
}