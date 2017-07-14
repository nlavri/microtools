// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: RemoteService.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Platform.Grpc {
  /// <summary>
  ///  Interface exported by the server.
  /// </summary>
  public static class RemoteService
  {
    static readonly string __ServiceName = "Platform.Grpc.RemoteService";

    static readonly Marshaller<global::Platform.Grpc.RpcRequest> __Marshaller_RpcRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Platform.Grpc.RpcRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Platform.Grpc.RpcResponse> __Marshaller_RpcResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Platform.Grpc.RpcResponse.Parser.ParseFrom);

    static readonly Method<global::Platform.Grpc.RpcRequest, global::Platform.Grpc.RpcResponse> __Method_RemoteCall = new Method<global::Platform.Grpc.RpcRequest, global::Platform.Grpc.RpcResponse>(
        MethodType.Unary,
        __ServiceName,
        "RemoteCall",
        __Marshaller_RpcRequest,
        __Marshaller_RpcResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Platform.Grpc.RemoteServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RemoteService</summary>
    public abstract class RemoteServiceBase
    {
      /// <summary>
      ///  A simple RPC.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Platform.Grpc.RpcResponse> RemoteCall(global::Platform.Grpc.RpcRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RemoteService</summary>
    public class RemoteServiceClient : ClientBase<RemoteServiceClient>
    {
      /// <summary>Creates a new client for RemoteService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RemoteServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RemoteService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RemoteServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RemoteServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RemoteServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  A simple RPC.
      /// </summary>
      public virtual global::Platform.Grpc.RpcResponse RemoteCall(global::Platform.Grpc.RpcRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoteCall(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  A simple RPC.
      /// </summary>
      public virtual global::Platform.Grpc.RpcResponse RemoteCall(global::Platform.Grpc.RpcRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RemoteCall, null, options, request);
      }
      /// <summary>
      ///  A simple RPC.
      /// </summary>
      public virtual AsyncUnaryCall<global::Platform.Grpc.RpcResponse> RemoteCallAsync(global::Platform.Grpc.RpcRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoteCallAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  A simple RPC.
      /// </summary>
      public virtual AsyncUnaryCall<global::Platform.Grpc.RpcResponse> RemoteCallAsync(global::Platform.Grpc.RpcRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RemoteCall, null, options, request);
      }
      protected override RemoteServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RemoteServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(RemoteServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RemoteCall, serviceImpl.RemoteCall).Build();
    }

  }
}
#endregion