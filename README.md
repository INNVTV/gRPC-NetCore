# gRPC with .Net Core
Simple gRPC server/client implementation in .Net Core

# ServiceDefinition
A class library project shared by both the Server and Client projects. Project hosts our protobuffer service definitions and acts as a client library to access the hosted services. 

### Generating the Protocol Buffer
Protobuffer generation is built into the Visual Studio when you use the following libraries:

    Google.Protobuf
    Grpc
    Grpc.Tools

Set your .proto file properties to use the following **Build Action**:

![service-definition-1](https://github.com/INNVTV/gRPC-NetCore/blob/master/_docs/imgs/service-definition-1.png)

Once you add ths project to the Client/Server solutions you and include it as a project dependancy you will be able to use the service definition liek you would any C# class:


    var createAccountRequest = new ServiceDefinition.AccountServices.CreateAccountRequest {
       Id = 2,
        Name = "New Account 1",
        Active = true,
        Type = AccountType.Enterprise
    };


**ServiceDefinition** contains all the protocol buffer code to populate, serialize, and retrieve our request and response message types between clients and servers.

**Note:** In a real world scenario you will want to make **ServiceDefinition** available as a Nuget package or compiled DLL that is fully versioned and managed on it's own.

# Server
A Console App that serves our gRPC methods to clients.

# Client
A Console App that makes client requests to the Server using service.

# Architecture

![architecture](https://github.com/INNVTV/gRPC-NetCore/blob/master/_docs/imgs/architecture.png)