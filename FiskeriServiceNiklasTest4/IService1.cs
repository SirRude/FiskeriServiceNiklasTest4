using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FiskeriServiceNiklasTest4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Opskrifte", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<Catch> GetAllCatchs();


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Catch/{id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Catch GetCatch(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Catch", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        void PostCatchs(Catch fangst);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Catch", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        void PutCatch(Catch fangst);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Catch/{id}", RequestFormat = WebMessageFormat.Json)]
        void DeleteCatch(string id);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
