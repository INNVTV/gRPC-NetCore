using Grpc.Core;
using System;
using static ServiceDefinition.AccountServices.CreateAccountRequest.Types;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var createAccountRequest = new ServiceDefinition.AccountServices.CreateAccountRequest {
                Id = 2,
                Name = "New Account 1",
                Active = true,
                Type = AccountType.Enterprise
            };

            var accountClient = new ServiceDefinition.AccountServices.Account.AccountClient(channel);

            var createAccountResponse = accountClient.CreateAccount(createAccountRequest);

            if(createAccountResponse.IsSuccess)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Message: { createAccountResponse.Message }");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Message: { createAccountResponse.Message }");
                Console.ForegroundColor = ConsoleColor.White;
            }

            //Shut down the channel
            channel.ShutdownAsync().Wait();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
