using Grpc.Net.Client;
using System;
using Grpc.Core;
using GrpcPaymentService;
using System.Threading.Tasks;
using System.Net.Http;

namespace GRPCClientAppCore
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var httpHandler = new HttpClientHandler();
            // Return `true` to allow certificates that are untrusted/invalid
            httpHandler.ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions { HttpHandler=httpHandler});
            var paymentClient = new  GrpcPaymentService.GrpcPaymentService.GrpcPaymentServiceClient(channel);

            Console.WriteLine("Welcome to the gRPC client");
           
            var reply = await paymentClient.MakePaymentAsync(new MakePaymentRequest
            {
                ProductId = "P0001",
                Quantity = 1,
                Address = "Viet Nam"
            });
            Console.WriteLine($"Made payment: {reply.OrderId}");

            using var statusReplies = paymentClient.GetPaymentStatus(new GetPaymentStatusRequest() { OrderId = reply.OrderId });
            while (await statusReplies.ResponseStream.MoveNext())
            {
                var statusReply = statusReplies.ResponseStream.Current.Status;
                Console.WriteLine($"Payment status: {statusReply}");
            }
        }
    }
}
