using System;

namespace Server
{
    class Program
    {
        const int Port = 50051;

        static void Main(string[] args)
        {
            var server = new Grpc.Core.Server
            {
                Services = {
                    ServiceDefinition.AccountServices.Account.BindService(new ServiceDefinitionImplementation())
                },
                Ports = { new Grpc.Core.ServerPort("localhost", Port, Grpc.Core.ServerCredentials.Insecure) }
            };

            server.Start();

            Console.WriteLine($"Account service listening on port { Port }");
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
