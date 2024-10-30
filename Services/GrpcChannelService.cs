using Grpc.Net.Client;
using Grpc.Net.Client.Web;

namespace FF4FE.Tracker.Services
{
    /// <summary>
    /// Gets a grpc channel at localhost:8190, SNI's default grpc web listen port
    /// </summary>
    public static class GrpcChannelService
    {
        public static GrpcChannel? GetGrpcChannel() => GrpcChannel.ForAddress("http://localhost:8190", new GrpcChannelOptions { HttpHandler = new GrpcWebHandler(new HttpClientHandler()) });
    }
}
