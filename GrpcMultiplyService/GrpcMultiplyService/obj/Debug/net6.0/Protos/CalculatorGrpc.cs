// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/calculator.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcMultiplyService.Services {
  public static partial class CalculatorService
  {
    static readonly string __ServiceName = "calculator.CalculatorService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMultiplyService.Services.TwoNumbers> __Marshaller_calculator_TwoNumbers = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMultiplyService.Services.TwoNumbers.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMultiplyService.Services.CalculationResult> __Marshaller_calculator_CalculationResult = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMultiplyService.Services.CalculationResult.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMultiplyService.Services.HistoryRequest> __Marshaller_calculator_HistoryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMultiplyService.Services.HistoryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMultiplyService.Services.HistoryEntry> __Marshaller_calculator_HistoryEntry = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMultiplyService.Services.HistoryEntry.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcMultiplyService.Services.TwoNumbers, global::GrpcMultiplyService.Services.CalculationResult> __Method_Add = new grpc::Method<global::GrpcMultiplyService.Services.TwoNumbers, global::GrpcMultiplyService.Services.CalculationResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Add",
        __Marshaller_calculator_TwoNumbers,
        __Marshaller_calculator_CalculationResult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcMultiplyService.Services.TwoNumbers, global::GrpcMultiplyService.Services.CalculationResult> __Method_Multiply = new grpc::Method<global::GrpcMultiplyService.Services.TwoNumbers, global::GrpcMultiplyService.Services.CalculationResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Multiply",
        __Marshaller_calculator_TwoNumbers,
        __Marshaller_calculator_CalculationResult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcMultiplyService.Services.HistoryRequest, global::GrpcMultiplyService.Services.HistoryEntry> __Method_GetHistory = new grpc::Method<global::GrpcMultiplyService.Services.HistoryRequest, global::GrpcMultiplyService.Services.HistoryEntry>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetHistory",
        __Marshaller_calculator_HistoryRequest,
        __Marshaller_calculator_HistoryEntry);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcMultiplyService.Services.CalculatorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CalculatorService</summary>
    [grpc::BindServiceMethod(typeof(CalculatorService), "BindService")]
    public abstract partial class CalculatorServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcMultiplyService.Services.CalculationResult> Add(global::GrpcMultiplyService.Services.TwoNumbers request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcMultiplyService.Services.CalculationResult> Multiply(global::GrpcMultiplyService.Services.TwoNumbers request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// New streaming RPC
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task GetHistory(global::GrpcMultiplyService.Services.HistoryRequest request, grpc::IServerStreamWriter<global::GrpcMultiplyService.Services.HistoryEntry> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CalculatorServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Add, serviceImpl.Add)
          .AddMethod(__Method_Multiply, serviceImpl.Multiply)
          .AddMethod(__Method_GetHistory, serviceImpl.GetHistory).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CalculatorServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Add, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcMultiplyService.Services.TwoNumbers, global::GrpcMultiplyService.Services.CalculationResult>(serviceImpl.Add));
      serviceBinder.AddMethod(__Method_Multiply, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcMultiplyService.Services.TwoNumbers, global::GrpcMultiplyService.Services.CalculationResult>(serviceImpl.Multiply));
      serviceBinder.AddMethod(__Method_GetHistory, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GrpcMultiplyService.Services.HistoryRequest, global::GrpcMultiplyService.Services.HistoryEntry>(serviceImpl.GetHistory));
    }

  }
}
#endregion
