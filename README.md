#### This repo is a simple representation of gRPC call

1. **Reference**: [Medium reference link](https://letienthanh0212.medium.com/what-is-grpc-and-how-to-implement-grpc-with-asp-net-core-3-x-affe83686123) used to develop the sample app:

   Great article, Thanks for that!!!
   
   Ride was smooth, untill not hit by the below issue: gRPC client app not able to connect to service, security issue
   
   `Grpc.Core.RpcException: 'Status(StatusCode="Internal", Detail="Error starting gRPC call. HttpRequestException: The SSL connection could not be established, see inner exception. AuthenticationException: The remote certificate is invalid according to the validation procedure.`


2. **Issue**:To resolve the secure connection error, Follow [Microsoft reference](https://docs.microsoft.com/en-us/aspnet/core/grpc/troubleshoot?view=aspnetcore-5.0#call-a-grpc-service-with-an-untrustedinvalid-certificate)
