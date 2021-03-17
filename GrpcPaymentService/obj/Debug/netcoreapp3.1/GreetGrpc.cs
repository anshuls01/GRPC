// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcPaymentService {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class GrpcPaymentService
  {
    static readonly string __ServiceName = "Payment.GrpcPaymentService";

    static readonly grpc::Marshaller<global::GrpcPaymentService.HelloRequest> __Marshaller_Payment_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcPaymentService.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcPaymentService.HelloReply> __Marshaller_Payment_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcPaymentService.HelloReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcPaymentService.MakePaymentRequest> __Marshaller_Payment_MakePaymentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcPaymentService.MakePaymentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcPaymentService.MakePaymentReply> __Marshaller_Payment_MakePaymentReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcPaymentService.MakePaymentReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcPaymentService.GetPaymentStatusRequest> __Marshaller_Payment_GetPaymentStatusRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcPaymentService.GetPaymentStatusRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcPaymentService.GetPaymentStatusResponse> __Marshaller_Payment_GetPaymentStatusResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcPaymentService.GetPaymentStatusResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcPaymentService.HelloRequest, global::GrpcPaymentService.HelloReply> __Method_SayHello = new grpc::Method<global::GrpcPaymentService.HelloRequest, global::GrpcPaymentService.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_Payment_HelloRequest,
        __Marshaller_Payment_HelloReply);

    static readonly grpc::Method<global::GrpcPaymentService.MakePaymentRequest, global::GrpcPaymentService.MakePaymentReply> __Method_MakePayment = new grpc::Method<global::GrpcPaymentService.MakePaymentRequest, global::GrpcPaymentService.MakePaymentReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MakePayment",
        __Marshaller_Payment_MakePaymentRequest,
        __Marshaller_Payment_MakePaymentReply);

    static readonly grpc::Method<global::GrpcPaymentService.GetPaymentStatusRequest, global::GrpcPaymentService.GetPaymentStatusResponse> __Method_GetPaymentStatus = new grpc::Method<global::GrpcPaymentService.GetPaymentStatusRequest, global::GrpcPaymentService.GetPaymentStatusResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetPaymentStatus",
        __Marshaller_Payment_GetPaymentStatusRequest,
        __Marshaller_Payment_GetPaymentStatusResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcPaymentService.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GrpcPaymentService</summary>
    [grpc::BindServiceMethod(typeof(GrpcPaymentService), "BindService")]
    public abstract partial class GrpcPaymentServiceBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GrpcPaymentService.HelloReply> SayHello(global::GrpcPaymentService.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcPaymentService.MakePaymentReply> MakePayment(global::GrpcPaymentService.MakePaymentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetPaymentStatus(global::GrpcPaymentService.GetPaymentStatusRequest request, grpc::IServerStreamWriter<global::GrpcPaymentService.GetPaymentStatusResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GrpcPaymentServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello)
          .AddMethod(__Method_MakePayment, serviceImpl.MakePayment)
          .AddMethod(__Method_GetPaymentStatus, serviceImpl.GetPaymentStatus).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GrpcPaymentServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcPaymentService.HelloRequest, global::GrpcPaymentService.HelloReply>(serviceImpl.SayHello));
      serviceBinder.AddMethod(__Method_MakePayment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcPaymentService.MakePaymentRequest, global::GrpcPaymentService.MakePaymentReply>(serviceImpl.MakePayment));
      serviceBinder.AddMethod(__Method_GetPaymentStatus, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GrpcPaymentService.GetPaymentStatusRequest, global::GrpcPaymentService.GetPaymentStatusResponse>(serviceImpl.GetPaymentStatus));
    }

  }
}
#endregion
