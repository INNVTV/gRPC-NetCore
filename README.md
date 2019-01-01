# gRPC with .Net Core
Simple gRPC server/client implementation in .Net Core

## Greeter
A Class Library project shared by both the Server and Client projects. Project hosts our protobuffer service definitions. 

### Generating the Protocol Buffer

#### Using Subsystem for Linux run the following commands:

Update the packages list and install protobuf-compiler:

    sudo apt-get update
	sudo apt install protobuf-compiler

Navigate the commandline to the Greeter project directory (where greetings.proto is located) and run:

    protoc --proto_path=./ greetings.proto --csharp_out=./

This will generate the Greetings.cs file on the root.

**From the 'Greeter/' directory:**

    @rem Local nuget cache on Windows is located in %UserProfile%\.nuget\packages
    > %UserProfile%\.nuget\packages\Grpc.Tools.1.17.1\tools\windows_x86\protoc.exe -I../../protos --csharp_out Greeter --grpc_out Greeter ../../protos/greetings.proto --plugin=protoc-gen-grpc=%UserProfile%\.nuget\packages\packages\Grpc.Tools.1.17.1\tools\windows_x86\grpc_csharp_plugin.exe

**From the 'Greeter/' directory using GitBash:**

	$ C:/Users/{user}/.nuget/packages/grpc.tools/1.17.1/tools/windows_x86/protoc.exe -Iprotos --csharp_out Greeter --grpc_out Greeter protos/greetings.proto --plugin=protoc-gen-grpc=C:/Users/{user}/.nuget/packages/grpc.tools/1.17.1/tools/windows_x86/grpc_csharp_plugin.exe

**Running the above command generates/regenerates the following files:**

**Greeter/Greetings.cs** contains all the protocol buffer code to populate, serialize, and retrieve our request and response message types

**Greeter/GreetingsGrpc.cs** provides generated client and server classes, including:
 * An abstract class Greeter.GreeterBase to inherit from when defining Greeter service implementations
 * A class Greeter.GreeterClient that can be used to access remote Greeter instances

## Greeter.Server
A Console App that serves our gRPC methods to clients.

## Greeter.Client
A Console App that makes client requests to the Greeter service.