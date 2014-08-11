using System.ServiceModel;
using System.ServiceModel.Web;

namespace HelloWorldDemoService
{
    [ServiceContract]
    public interface IHelloWorldService
    {
        [OperationContract]
        [WebGet (UriTemplate = "/helloworld", ResponseFormat = WebMessageFormat.Json)]
        string SayHelloWorld ();
    }
}