using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CRUDwithJSON
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceProduct" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceProduct
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findall", ResponseFormat = WebMessageFormat.Json)]
        List<Productos> findAll();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "find/{id}", ResponseFormat = WebMessageFormat.Json)]
        Productos find(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool create(Productos product);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool edit(Productos product);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool delete(Productos product);
    }
}
