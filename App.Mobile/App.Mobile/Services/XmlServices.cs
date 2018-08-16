using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.Content.Res;
using System.Diagnostics;

namespace App.Mobile.Droid.Services
{
    public class XmlServices
    {
        private string PATHSERVER { get; set; }
        HttpClient client;

        public XmlServices()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            PATHSERVER = "10.1.92.207:83";
        }

        public async Task<bool> XmlWrite(string documentType, int id)
        {
            string url = "http://" + PATHSERVER + "/tshirt/Xml/XmlWrite";
            string _documentType = "?documentType=" + documentType;
            string _id = "&id=" + id;
            string uri = string.Concat(url, _documentType, _id);

            try
            {
                HttpResponseMessage response = null;

                response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }
            return false;
        }
    }
}
