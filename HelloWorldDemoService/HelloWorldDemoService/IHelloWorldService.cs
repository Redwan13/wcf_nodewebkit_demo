using System.ServiceModel;
using System.ServiceModel.Web;

namespace HelloWorldDemoService
{
    [ServiceContract]
    public interface IHelloWorldService
    {
        [WebGet(UriTemplate = "/helloworld",ResponseFormat = WebMessageFormat.Json)]
        string SayHelloWorld();
    }
}