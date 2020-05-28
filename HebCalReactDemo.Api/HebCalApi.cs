using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace HebCalReactDemo.Api
{
    public static class HebCalApi
    {
        public static HebCalConversionResult ConvertToHebrew(DateTime date)
        {
            var client = new HttpClient();
            var json = client.GetStringAsync(
                $"https://www.hebcal.com/converter/?cfg=json&gy={date.Year}&gm={date.Month}&gd={date.Day}&g2h=1").Result;
            return JsonConvert.DeserializeObject<HebCalConversionResult>(json);
        }

        public static ShabbosTimesResult GetUpcomingShabbosTimes(string zip)
        {
            var client = new HttpClient();
            string url = $"https://www.hebcal.com/shabbat/?cfg=json&zip=${zip}";
            string json = client.GetStringAsync(url).Result;
            var result = JsonConvert.DeserializeObject<ShabbosTimesResult>(json);
            return result;
        }

    }
}
