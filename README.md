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

This will generate the **SharedLibrary.cs** file on the root.

**SharedLibrary.cs** contains all the protocol buffer code to populate, serialize, and retrieve our request and response message types

# Server
A Console App that serves our gRPC methods to clients.

# Client
A Console App that makes client requests to the Server using service.

# Architecture

[Image]