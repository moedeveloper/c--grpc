// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: messages.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Messages {
  public static partial class NodeService
  {
    static readonly string __ServiceName = "NodeService";

    static readonly grpc::Marshaller<global::Messages.GetAllRequest> __Marshaller_GetAllRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Messages.GetAllRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Messages.NodeResponse> __Marshaller_NodeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Messages.NodeResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Messages.GetNodeByIdRequest> __Marshaller_GetNodeByIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Messages.GetNodeByIdRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Messages.GetAllRequest, global::Messages.NodeResponse> __Method_GetAll = new grpc::Method<global::Messages.GetAllRequest, global::Messages.NodeResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAll",
        __Marshaller_GetAllRequest,
        __Marshaller_NodeResponse);

    static readonly grpc::Method<global::Messages.GetNodeByIdRequest, global::Messages.NodeResponse> __Method_GetNodeById = new grpc::Method<global::Messages.GetNodeByIdRequest, global::Messages.NodeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetNodeById",
        __Marshaller_GetNodeByIdRequest,
        __Marshaller_NodeResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Messages.MessagesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of NodeService</summary>
    public abstract partial class NodeServiceBase
    {
      /// <summary>
      /// repeated could be used instead of stream to get a collection of employee responses but repeated is not supported by rpc calls!
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task GetAll(global::Messages.GetAllRequest request, grpc::IServerStreamWriter<global::Messages.NodeResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Messages.NodeResponse> GetNodeById(global::Messages.GetNodeByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for NodeService</summary>
    public partial class NodeServiceClient : grpc::ClientBase<NodeServiceClient>
    {
      /// <summary>Creates a new client for NodeService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public NodeServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for NodeService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public NodeServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected NodeServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected NodeServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// repeated could be used instead of stream to get a collection of employee responses but repeated is not supported by rpc calls!
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Messages.NodeResponse> GetAll(global::Messages.GetAllRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// repeated could be used instead of stream to get a collection of employee responses but repeated is not supported by rpc calls!
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Messages.NodeResponse> GetAll(global::Messages.GetAllRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetAll, null, options, request);
      }
      public virtual global::Messages.NodeResponse GetNodeById(global::Messages.GetNodeByIdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetNodeById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Messages.NodeResponse GetNodeById(global::Messages.GetNodeByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetNodeById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Messages.NodeResponse> GetNodeByIdAsync(global::Messages.GetNodeByIdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetNodeByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Messages.NodeResponse> GetNodeByIdAsync(global::Messages.GetNodeByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetNodeById, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override NodeServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new NodeServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(NodeServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAll, serviceImpl.GetAll)
          .AddMethod(__Method_GetNodeById, serviceImpl.GetNodeById).Build();
    }

  }
}
#endregion
