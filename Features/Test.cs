using FeTracker.Sni.Models;
using sni;
using static sni.DeviceMemory;

namespace Tracker.Features;

public static class DeviceMemoryClientExtensions
{
    extension(DeviceMemoryClient client)
    {
        public async Task<Response<SingleReadMemoryResponse>> ReadByMemoryAddressAsync(MemoryAddress address, string uri)
        {
            var readMemoryRequest = new SingleReadMemoryRequest
            {
                Request = new ReadMemoryRequest
                {
                    RequestAddress = address.Address,
                    RequestAddressSpace = AddressSpace.FxPakPro,
                    RequestMemoryMapping = MemoryMapping.Unknown,
                    Size = address.Size
                },
                Uri = uri,
            };

            for (var i = 0; i <= 10; i++)
            {
                try
                {
                    var sniResponse = await client.SingleReadAsync(readMemoryRequest);
                    return Response<SingleReadMemoryResponse>.SetSuccess(sniResponse);
                }
                catch (Exception ex)
                {
                    if (i == 10)
                        return Response<SingleReadMemoryResponse>.SetError(ex.Message);

                    Thread.Sleep(20);
                }
            }

            return Response<SingleReadMemoryResponse>.SetError("Unknown issue reading from SNI");
        }
    }
}

public class Response<T>
{
    public T? Data { get; private set; }
    public string ErrorMessage { get; private set; } = string.Empty;
    public bool Success { get; private set; } = false;


    /// <summary>
    /// Basic constructor for the Response object.
    /// </summary>
    /// <param name="responseObject"></param>
    /// <param name="errorMessage"></param>
    /// <param name="success"></param>
    /// <param name="errorStatusCode">Should be not null when using this constructor for an error</param>
    public Response(T? responseObject, string errorMessage = "", bool success = false)
    {
        Data = responseObject;
        ErrorMessage = errorMessage;
        Success = success;
    }

    public Response() { }

    public static Response<T> SetSuccess(T responseObject)
    {
        return new Response<T>
        {
            Data = responseObject,
            Success = true,
            ErrorMessage = string.Empty
        };
    }

    public static Response<T> SetError(string errorMessage)
    {
        return new Response<T>
        {
            ErrorMessage = errorMessage,
            Success = false,
            Data = default
        };
    }
}