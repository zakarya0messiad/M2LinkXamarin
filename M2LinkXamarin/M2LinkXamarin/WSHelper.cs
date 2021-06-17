using M2LinkXamarin.WebServiceClients;
using System.ServiceModel;
namespace M2LinkXamarin
{
    class WSHelper
    {
        public static WSLoginClient WSLoginClient = new WSLoginClient(
            new BasicHttpBinding(),
            new EndpointAddress(AppConstants.WSServer + "/WebServices/WSLogin.svc")
        );
        public static WSUserClient WSUserClient = new WSUserClient(
            new BasicHttpBinding(),
            new EndpointAddress(AppConstants.WSServer + "/WebServices/WSUser.svc")
        );

        public static WSMessageClient WSMessageClient = new WSMessageClient(
            new BasicHttpBinding(),
            new EndpointAddress(AppConstants.WSServer + "/WebServices/WSMessage.svc")
        );
    }
}
