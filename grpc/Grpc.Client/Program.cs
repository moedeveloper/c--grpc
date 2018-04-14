using Grpc.Core;
using Messages;
using System;
using System.IO;
using System.Threading.Tasks;
using static Messages.NodeService;
using System.Collections.Generic;


namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //var option = int.Parse(args[0]);
            const int port = 9000;

            var cacert = File.ReadAllText(@"ca.crt");
            var cert = File.ReadAllText(@"client.crt");
            var key = File.ReadAllText(@"client.key");
            var keypair = new KeyCertificatePair(cert, key);
            SslCredentials creds = new SslCredentials(cacert, keypair);
            var channel = new Channel("DESKTOP-H7CAL1I", port, creds);
            var client = new NodeServiceClient(channel);

            //sendMetaDataAsync(client).Wait();
            getAllAsync(client).Wait();
            //GetNodeByIdAsync(client).Wait();
            Console.WriteLine("Press any key to exist");
            Console.ReadKey();
        }

        private static async Task sendMetaDataAsync(NodeServiceClient client)
        {
            Metadata md = new Metadata();
            md.Add("username", "moe");
            md.Add("password", "pass");

            try
            {
                await client.GetNodeByIdAsync(new GetNodeByIdRequest(), md);
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception " + ex);
            }
        }

        public static async Task GetNodeByIdAsync(NodeServiceClient client)
        {
            var res = await client.GetNodeByIdAsync(new GetNodeByIdRequest() {
                Id = 1
            });

            Console.WriteLine(res.Node);
        }

        private static async Task getAllAsync(NodeServiceClient client)
        {
            using (var call = client.GetAll(new Messages.GetAllRequest()))
            {
                var responseStream = call.ResponseStream;
                while (await responseStream.MoveNext())
                {
                    Console.WriteLine(responseStream.Current.Node);
                }
            }
        }
    }
}
