using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;


namespace CRUDwithJSON_CLIENT.Models
{
    public class ProductServiceClient
    {
        private string BASE_URL = "http://localhost:26351/ServiceProduct.svc/";
        public List<Product> findAll()
        {
            try
            {
                var webcliente = new WebClient();
                var json = webcliente.DownloadString(BASE_URL + "findall");
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<Product>>(json);
            }
            catch
            {
                return null;

            }
        }


        public Product find(string id)
        {
            try
            {
                var webcliente = new WebClient();
                string url = string.Format(BASE_URL + "find/{0}", id);
                var json = webcliente.DownloadString(url);
                var js = new JavaScriptSerializer();
                return js.Deserialize<Product>(json);
            }
            catch
            {
                return null;

            }
        }

        public bool create(Product product)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Product));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, product);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webCliente = new WebClient();
                webCliente.Headers["Content-type"] = "application/json";
                webCliente.Encoding = Encoding.UTF8;
                webCliente.UploadString(BASE_URL + "create", "POST", data);

                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool edit(Product product)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Product));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, product);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webCliente = new WebClient();
                webCliente.Headers["Content-type"] = "application/json";
                webCliente.Encoding = Encoding.UTF8;
                webCliente.UploadString(BASE_URL + "edit", "PUT", data);

                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool delete(Product product)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Product));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, product);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webCliente = new WebClient();
                webCliente.Headers["Content-type"] = "application/json";
                webCliente.Encoding = Encoding.UTF8;
                webCliente.UploadString(BASE_URL + "delete", "DELETE", data);

                return true;
            }
            catch
            {
                return false;

            }
        }


    }
}