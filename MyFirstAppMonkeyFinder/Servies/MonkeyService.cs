using MyFirstAppMonkeyFinder.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAppMonkeyFinder.Servies
{
    public class MonkeyService
    {
        public async Task<List<MonkeyModel>> GetMonkeyData()
        {
            try
            {
                List<MonkeyModel> monkey = new List<MonkeyModel>();
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://montemagno.com/monkeys.json");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var monkyData = JsonConvert.DeserializeObject<List<MonkeyModel>>(result);
                    return monkyData;
                }
            }
            catch (Exception ex)
            {

            }
            return null;

        }
    }
}
