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

This will generate the **Greetings.cs** file on the root.

**Greetings.cs** contains all the protocol buffer code to populate, serialize, and retrieve our request and response message types

## Greeter.Server
A Console App that serves our gRPC methods to clients.

## Greeter.Client
A Console App that makes client requests to the Greeter service.