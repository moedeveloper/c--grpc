using Grpc.Core;
using Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using static Messages.NodeService;

namespace Grpc.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            const int port = 9000;
            var cacert = File.ReadAllText(@"ca.crt");
            var cert = File.ReadAllText(@"server.crt");
            var key = File.ReadAllText(@"server.key");
            var keyPair = new KeyCertificatePair(cert, key);
            var sslCredentials = new SslServerCredentials(new List<KeyCertificatePair>()
            {
                keyPair
            }, cacert, false); // false do not need to force the client to authenticate if yes make it true

            Grpc.Core.Server server = new Grpc.Core.Server
            {
                Ports = { new ServerPort("0.0.0.0", port, sslCredentials) },
                Services = { BindService (new NodeService())}
                
            };
            server.Start();

            Console.WriteLine("Starting Server on port " + port);
            Console.WriteLine("Press any Key to stop");
            Console.ReadKey();
            server.ShutdownAsync().Wait();
        }
        public class NodeService: NodeServiceBase
        {
            public override async Task GetAll(GetAllRequest request, IServerStreamWriter<NodeResponse> responseStream, ServerCallContext context)
            {
                foreach(var e in Nodes.nodes)
                {
                    await responseStream.WriteAsync(new NodeResponse()
                    {
                        Node = e
                    });
                }
            }

            public override async Task<NodeResponse> GetNodeById(GetNodeByIdRequest request, ServerCallContext context)
            {
                Metadata md = context.RequestHeaders;

                foreach (var entry in md)
                {
                    Console.WriteLine(entry.Key + ": " + entry.Value);
                }

                foreach(var e in Nodes.nodes)
                {
                    if (request.Id == e.Id)
                    {
                        return new NodeResponse()
                        {
                            Node = e
                        };
                    }
                }
                throw new Exception("Node not found: " + request.Id);
            }           
        }
    }
}
