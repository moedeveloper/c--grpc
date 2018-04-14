1. install protoc https://github.com/google/protobuf/releases
2. command to convert proto message into c# code:
protoc -I C:\demos\pb --csharp_out C:\demos\grpc\Messages C:\demos\pb\messages.proto --grpc_out C:\demos\grpc\Messages --plugin=protoc-gen-grpc=C:\demos\grpc\packages\Grpc.Tools.1.10.1\tools\windows_x86\grpc_csharp_plugin.exe

3. install openssl http://slproweb.com/products/Win32OpenSSL.html


protoc -I C:\code\pb\ --csharp_out C:\code\Grpc\Messages C:\code\pb\messages.proto --grpc_out C:\code\Grpc\Messages --plugin=protoc-gen-grpc=C:\code\Grpc.Tools.1.10.1\tools\windows_x86\grpc_csharp_plugin.exe

3. cert 
open ssl code is obtained from https://stackoverflow.com/a/37739265
