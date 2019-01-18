using Grpc.Core;
using ServiceDefinition.AccountServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ServiceDefinitionImplementation : ServiceDefinition.AccountServices.Account.AccountBase
    {
        public override Task<CreateAccountResponse> CreateAccount(CreateAccountRequest request, ServerCallContext context)
        {
            Console.WriteLine("CreateAccount method has been called by the client!");

            return Task.FromResult(new CreateAccountResponse { IsSuccess = true, Message = $"The account '{ request.Name }' has been created!" });
        }
    }
}
