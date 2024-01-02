using Grpc.Core;

namespace Repro.Services;

public class StorageService : Storage.StorageBase
{
    public override Task<ReadResponse> Read(ReadRequest request, ServerCallContext context)
    {
        return base.Read(request, context);
    }

    public override Task<WriteResponse> Write(WriteRequest request, ServerCallContext context)
    {
        return base.Write(request, context);
    }
}