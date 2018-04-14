using System;
using System.Collections.Generic;
using System.Text;
using Messages;


namespace Grpc.Server
{
    public static class Nodes
    {
        public static List<Node> nodes = new List<Messages.Node>()
        {
            new Messages.Node
            {
                Id = 1,
                Label = "Node1"
            },
            new Messages.Node
            {
                Id = 2,
                Label = "Node12"

            },
            new Messages.Node
            {
                Id = 3,
                Label = "Node2"
            },
        };
    }
}
