// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ResourceSharing20200110.Models;

namespace AlibabaCloud.SDK.ResourceSharing20200110
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("resourcesharing", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRequest("DescribeRegions", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRequestAsync("DescribeRegions", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public ListResourceSharesResponse ListResourceSharesWithOptions(ListResourceSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListResourceSharesResponse>(DoRequest("ListResourceShares", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListResourceSharesResponse> ListResourceSharesWithOptionsAsync(ListResourceSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListResourceSharesResponse>(await DoRequestAsync("ListResourceShares", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public ListResourceSharesResponse ListResourceShares(ListResourceSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceSharesWithOptions(request, runtime);
        }

        public async Task<ListResourceSharesResponse> ListResourceSharesAsync(ListResourceSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceSharesWithOptionsAsync(request, runtime);
        }

        public ListSharedResourcesResponse ListSharedResourcesWithOptions(ListSharedResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListSharedResourcesResponse>(DoRequest("ListSharedResources", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListSharedResourcesResponse> ListSharedResourcesWithOptionsAsync(ListSharedResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListSharedResourcesResponse>(await DoRequestAsync("ListSharedResources", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public ListSharedResourcesResponse ListSharedResources(ListSharedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSharedResourcesWithOptions(request, runtime);
        }

        public async Task<ListSharedResourcesResponse> ListSharedResourcesAsync(ListSharedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSharedResourcesWithOptionsAsync(request, runtime);
        }

        public ListSharedTargetsResponse ListSharedTargetsWithOptions(ListSharedTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListSharedTargetsResponse>(DoRequest("ListSharedTargets", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListSharedTargetsResponse> ListSharedTargetsWithOptionsAsync(ListSharedTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListSharedTargetsResponse>(await DoRequestAsync("ListSharedTargets", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public ListSharedTargetsResponse ListSharedTargets(ListSharedTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSharedTargetsWithOptions(request, runtime);
        }

        public async Task<ListSharedTargetsResponse> ListSharedTargetsAsync(ListSharedTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSharedTargetsWithOptionsAsync(request, runtime);
        }

        public AssociateResourceShareResponse AssociateResourceShareWithOptions(AssociateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AssociateResourceShareResponse>(DoRequest("AssociateResourceShare", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AssociateResourceShareResponse> AssociateResourceShareWithOptionsAsync(AssociateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AssociateResourceShareResponse>(await DoRequestAsync("AssociateResourceShare", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public AssociateResourceShareResponse AssociateResourceShare(AssociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateResourceShareWithOptions(request, runtime);
        }

        public async Task<AssociateResourceShareResponse> AssociateResourceShareAsync(AssociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateResourceShareWithOptionsAsync(request, runtime);
        }

        public UpdateResourceShareResponse UpdateResourceShareWithOptions(UpdateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateResourceShareResponse>(DoRequest("UpdateResourceShare", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateResourceShareResponse> UpdateResourceShareWithOptionsAsync(UpdateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateResourceShareResponse>(await DoRequestAsync("UpdateResourceShare", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public UpdateResourceShareResponse UpdateResourceShare(UpdateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateResourceShareWithOptions(request, runtime);
        }

        public async Task<UpdateResourceShareResponse> UpdateResourceShareAsync(UpdateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateResourceShareWithOptionsAsync(request, runtime);
        }

        public DeleteResourceShareResponse DeleteResourceShareWithOptions(DeleteResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteResourceShareResponse>(DoRequest("DeleteResourceShare", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteResourceShareResponse> DeleteResourceShareWithOptionsAsync(DeleteResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteResourceShareResponse>(await DoRequestAsync("DeleteResourceShare", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public DeleteResourceShareResponse DeleteResourceShare(DeleteResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteResourceShareWithOptions(request, runtime);
        }

        public async Task<DeleteResourceShareResponse> DeleteResourceShareAsync(DeleteResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteResourceShareWithOptionsAsync(request, runtime);
        }

        public DisassociateResourceShareResponse DisassociateResourceShareWithOptions(DisassociateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisassociateResourceShareResponse>(DoRequest("DisassociateResourceShare", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DisassociateResourceShareResponse> DisassociateResourceShareWithOptionsAsync(DisassociateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisassociateResourceShareResponse>(await DoRequestAsync("DisassociateResourceShare", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public DisassociateResourceShareResponse DisassociateResourceShare(DisassociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisassociateResourceShareWithOptions(request, runtime);
        }

        public async Task<DisassociateResourceShareResponse> DisassociateResourceShareAsync(DisassociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisassociateResourceShareWithOptionsAsync(request, runtime);
        }

        public ListResourceShareAssociationsResponse ListResourceShareAssociationsWithOptions(ListResourceShareAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListResourceShareAssociationsResponse>(DoRequest("ListResourceShareAssociations", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListResourceShareAssociationsResponse> ListResourceShareAssociationsWithOptionsAsync(ListResourceShareAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListResourceShareAssociationsResponse>(await DoRequestAsync("ListResourceShareAssociations", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public ListResourceShareAssociationsResponse ListResourceShareAssociations(ListResourceShareAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceShareAssociationsWithOptions(request, runtime);
        }

        public async Task<ListResourceShareAssociationsResponse> ListResourceShareAssociationsAsync(ListResourceShareAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceShareAssociationsWithOptionsAsync(request, runtime);
        }

        public CreateResourceShareResponse CreateResourceShareWithOptions(CreateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateResourceShareResponse>(DoRequest("CreateResourceShare", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateResourceShareResponse> CreateResourceShareWithOptionsAsync(CreateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateResourceShareResponse>(await DoRequestAsync("CreateResourceShare", "HTTPS", "POST", "2020-01-10", "AK", null, request.ToMap(), runtime));
        }

        public CreateResourceShareResponse CreateResourceShare(CreateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourceShareWithOptions(request, runtime);
        }

        public async Task<CreateResourceShareResponse> CreateResourceShareAsync(CreateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourceShareWithOptionsAsync(request, runtime);
        }

        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

    }
}
