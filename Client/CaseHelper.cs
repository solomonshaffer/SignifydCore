using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SignifydCore.Client.Model;

namespace SignifydCore.Client
{
    public class CaseHelper
    {
        private readonly Settings _settings;

        public CaseHelper(Settings settings)
        {
            _settings = settings;
        }

        public async Task<CreateCaseResponse> CreateCaseAsync(CreateCaseRequest createCaseRequest)
        {
            using var httpClient = new HttpClient {BaseAddress = _settings.BaseAddress};
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Basic {_settings.Key}");

            using var content = new StringContent(JsonConvert.SerializeObject(createCaseRequest), Encoding.Default, "application/json");
            using var response = await httpClient.PostAsync("cases", content);
            var responseData = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CreateCaseResponse>(responseData);
        }

        public async Task<GetCaseResponse> GetCaseAsync(int caseId)
        {
            using var httpClient = new HttpClient {BaseAddress = _settings.BaseAddress};
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Basic {_settings.Key}");

            using var response = await httpClient.GetAsync($"cases/{caseId}");
            var responseData = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<GetCaseResponse>(responseData);
        }
    }
}