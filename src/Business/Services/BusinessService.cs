using Grpc.Core;

namespace Repro.Services;

public class BusinessService : Business.BusinessBase
{
    public override Task<SaveResponse> Save(SaveRequest request, ServerCallContext context)
    {
        return base.Save(request, context);
    }

    public override Task<LoadResponse> Load(LoadRequest request, ServerCallContext context)
    {
        return base.Load(request, context);
    }
}