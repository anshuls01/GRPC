using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcPaymentService
{
    public class PaymentService : GrpcPaymentService.GrpcPaymentServiceBase
    { 

        private readonly ILogger<PaymentService> _logger;
        public PaymentService(ILogger<PaymentService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }

        public override Task<MakePaymentReply> MakePayment(MakePaymentRequest request, ServerCallContext context)
        {
            var TransactionId = Guid.NewGuid().ToString();
            _logger.LogInformation($"Make payment {TransactionId}");

            return Task.FromResult(new MakePaymentReply
            {
                OrderId = TransactionId
            });
        }

        public override async Task GetPaymentStatus(GetPaymentStatusRequest request, IServerStreamWriter<GetPaymentStatusResponse> responseStream, ServerCallContext context) {
            await responseStream.WriteAsync(new GetPaymentStatusResponse { Status = "created" });
            await Task.Delay(500);

            await responseStream.WriteAsync(new GetPaymentStatusResponse { Status = "Validated" });
            await Task.Delay(1000);

            await responseStream.WriteAsync(new GetPaymentStatusResponse { Status = "Accepted" });

        }

    }
}
