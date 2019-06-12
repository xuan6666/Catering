using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;

namespace WebBaoXiuCustom
{
    //httpMethod请求方式  delete put post get
    //controllerName请求的控制器 api/BaoXiuApi
    //data 需要添加或修改的数据json字符串 {'Name':'张三','Age':19}
    public class HttpClientHelper
    {

        public static string Send(string httpMethod, string controllerName, string data)
        {
            HttpClient client = new HttpClient();
            Uri uri = new Uri("http://localhost:59440/");
            client.BaseAddress = uri;
            HttpResponseMessage responseMessage = null;
            switch (httpMethod)
            {
                case "get":
                    responseMessage = client.GetAsync(controllerName).Result;
                    break;
                case "post":
                    HttpContent content = new StringContent(data);
                    content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    responseMessage = client.PostAsync(controllerName, content).Result;
                    break;
                case "delete":
                    //controllerName= 'api/baoxiuapi/3'
                    responseMessage = client.DeleteAsync(controllerName).Result;
                    break;
                case "put":
                    HttpContent content1 = new StringContent(data);
                    content1.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    responseMessage = client.PutAsync(controllerName, content1).Result;
                    break;
                default:
                    break;


            }

            if (responseMessage.IsSuccessStatusCode)
            {
                string result = responseMessage.Content.ReadAsStringAsync().Result;
                return result;
            }
            else
            {
                string result = "操作失败";
                return result;
            }
        }
    }
}