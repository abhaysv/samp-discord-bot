﻿using System.Net.Http;

namespace main.Core
{
    /**
     * Responsible for handling HTTP(s) calls.
     */
    public interface IHttpClient
    {
        /**
         * Returns the content of a given [url] response.
         */
        string GetContent(string url);
    }
    
    public class HttpClient : IHttpClient
    {
        public string GetContent(string url)
        {
            using (var handler = new HttpClientHandler())
            {
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback = 
                    (httpRequestMessage, cert, cetChain, policyErrors) => true;

                using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient(handler))
                {
                    using (HttpResponseMessage response = client.GetAsync(url).Result)
                    {
                        using (HttpContent content = response.Content)
                        {
                            return content.ReadAsStringAsync().Result;
                        }
                    }
                }
            }
        }
    }
}
