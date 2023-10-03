using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Launcher.Web
{
    internal class WebClient
    {

        public WebClient() 
        { 

        }


        // Source: https://zetcode.com/csharp/httpclient/
        // Asynchronous HTTPClient: too complicated, I will rather use outdated HttpWebRequest
        //static async Task<string> CheckStatus(string url)
        //{
        //    try
        //    {
        //        using var client = new HttpClient();
        //        client.Timeout = TimeSpan.FromMinutes(1);
        //        var result = await client.GetAsync(url);
        //        string statusCode = result.StatusCode.ToString(); 
        //        Trace.WriteLine("Status Code is: " + statusCode);
        //        return statusCode;
        //    }
        //    catch (WebException ex)
        //    {
        //        Trace.WriteLine("Caught exception in WebClient, returning: " + ex.Message);
        //        return ex.Message;
        //    }
        //}


        //static async Task<string> GetHTML(string url)
        //{
        //    using var client = new HttpClient();
        //    var content = await client.GetStringAsync(url);
        //    Trace.WriteLine("HTML obtained (content) is: " + content);
        //    return content;
        //}


        //private static string GetHTML(string url)
        //{
        //    var request = WebRequest.CreateHttp(url);
        //    request.Method = "GET";
        //    using (var response = (HttpWebResponse)request.GetResponse())
        //    {
        //        using (var responseStream = response.GetResponseStream())
        //        {
        //            using (var myStreamReader = new StreamReader(responseStream, Encoding.UTF8))
        //            {
        //                var responseJSON = myStreamReader.ReadToEnd();
        //                data = JsonConvert.DeserializeObject<TData>(responseJSON);
        //            }
        //        }
        //    }
        //}


        public bool CheckURL(string url)
        {
            Trace.WriteLine("vchk: Line 31");
            HttpStatusCode httpstatus;
            try
            {
                Trace.WriteLine("Checking URL: " + url);
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ReadWriteTimeout = 1000;
                httpWebRequest.Timeout = 1000;
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                httpstatus = httpWebResponse.StatusCode;
                Trace.WriteLine("httpstatus: " + httpstatus);
                httpWebResponse.Close();
            }
            catch (WebException ex)
            {
                // If Status is not ProtocolError or Response is null, then set httpstatus to NotFound, else set it to some StatusCode value
                httpstatus = ((ex.Status != WebExceptionStatus.ProtocolError || ex.Response == null) ? HttpStatusCode.NotFound : (ex.Response as HttpWebResponse).StatusCode);
                Trace.WriteLine("Exception caught in CheckURL: " + ex.Message);
            }
            Trace.WriteLine("CheckURL: " + httpstatus.ToString());
            return httpstatus == HttpStatusCode.OK;
        }

    }
}