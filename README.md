# gRPC with .Net Core
Simple gRPC server/client implementation in .Net Core

## SharedLibrary
A Class Library project shared by both the Server and Client projects. Project hosts our protobuffer service definitions. 

### Generating the Protocol Buffer
Protobuffer generation is built into the Visual Studio build system when you use the following libraries:

And set your .proto file to leverage the generation tools like so:

[Image]

This will generate the **SharedLibrary.cs** file on the root.

**SharedLibrary.cs** contains all the protocol buffer code to populate, serialize, and retrieve our request and response message types

## Server
A Console App that serves our gRPC methods to clients.

## Client
A Console App that makes client requests to the Server using service.

## Architecture

[Image]