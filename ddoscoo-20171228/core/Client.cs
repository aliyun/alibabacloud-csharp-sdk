// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ddoscoo20171228.Models;

namespace AlibabaCloud.SDK.Ddoscoo20171228
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ddoscoo", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public ModifyFullLogTtlResponse ModifyFullLogTtlWithOptions(ModifyFullLogTtlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyFullLogTtlResponse>(DoRequest("ModifyFullLogTtl", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyFullLogTtlResponse> ModifyFullLogTtlWithOptionsAsync(ModifyFullLogTtlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyFullLogTtlResponse>(await DoRequestAsync("ModifyFullLogTtl", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ModifyFullLogTtlResponse ModifyFullLogTtl(ModifyFullLogTtlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFullLogTtlWithOptions(request, runtime);
        }

        public async Task<ModifyFullLogTtlResponse> ModifyFullLogTtlAsync(ModifyFullLogTtlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFullLogTtlWithOptionsAsync(request, runtime);
        }

        public ReleaseValueAddedResponse ReleaseValueAddedWithOptions(ReleaseValueAddedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseValueAddedResponse>(DoRequest("ReleaseValueAdded", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReleaseValueAddedResponse> ReleaseValueAddedWithOptionsAsync(ReleaseValueAddedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseValueAddedResponse>(await DoRequestAsync("ReleaseValueAdded", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ReleaseValueAddedResponse ReleaseValueAdded(ReleaseValueAddedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseValueAddedWithOptions(request, runtime);
        }

        public async Task<ReleaseValueAddedResponse> ReleaseValueAddedAsync(ReleaseValueAddedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseValueAddedWithOptionsAsync(request, runtime);
        }

        public ListValueAddedResponse ListValueAddedWithOptions(ListValueAddedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListValueAddedResponse>(DoRequest("ListValueAdded", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListValueAddedResponse> ListValueAddedWithOptionsAsync(ListValueAddedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListValueAddedResponse>(await DoRequestAsync("ListValueAdded", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ListValueAddedResponse ListValueAdded(ListValueAddedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListValueAddedWithOptions(request, runtime);
        }

        public async Task<ListValueAddedResponse> ListValueAddedAsync(ListValueAddedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListValueAddedWithOptionsAsync(request, runtime);
        }

        public ListLayer7CustomPortsResponse ListLayer7CustomPortsWithOptions(ListLayer7CustomPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListLayer7CustomPortsResponse>(DoRequest("ListLayer7CustomPorts", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListLayer7CustomPortsResponse> ListLayer7CustomPortsWithOptionsAsync(ListLayer7CustomPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListLayer7CustomPortsResponse>(await DoRequestAsync("ListLayer7CustomPorts", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ListLayer7CustomPortsResponse ListLayer7CustomPorts(ListLayer7CustomPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLayer7CustomPortsWithOptions(request, runtime);
        }

        public async Task<ListLayer7CustomPortsResponse> ListLayer7CustomPortsAsync(ListLayer7CustomPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLayer7CustomPortsWithOptionsAsync(request, runtime);
        }

        public DescribeSimpleDomainsResponse DescribeSimpleDomainsWithOptions(DescribeSimpleDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSimpleDomainsResponse>(DoRequest("DescribeSimpleDomains", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeSimpleDomainsResponse> DescribeSimpleDomainsWithOptionsAsync(DescribeSimpleDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSimpleDomainsResponse>(await DoRequestAsync("DescribeSimpleDomains", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeSimpleDomainsResponse DescribeSimpleDomains(DescribeSimpleDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSimpleDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeSimpleDomainsResponse> DescribeSimpleDomainsAsync(DescribeSimpleDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSimpleDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeDefenseCountStatisticsResponse DescribeDefenseCountStatisticsWithOptions(DescribeDefenseCountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDefenseCountStatisticsResponse>(DoRequest("DescribeDefenseCountStatistics", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDefenseCountStatisticsResponse> DescribeDefenseCountStatisticsWithOptionsAsync(DescribeDefenseCountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDefenseCountStatisticsResponse>(await DoRequestAsync("DescribeDefenseCountStatistics", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDefenseCountStatisticsResponse DescribeDefenseCountStatistics(DescribeDefenseCountStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseCountStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeDefenseCountStatisticsResponse> DescribeDefenseCountStatisticsAsync(DescribeDefenseCountStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseCountStatisticsWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UntagResourcesResponse>(DoRequest("UntagResources", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRequestAsync("UntagResources", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TagResourcesResponse>(DoRequest("TagResources", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TagResourcesResponse>(await DoRequestAsync("TagResources", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRequest("ListTagResources", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRequestAsync("ListTagResources", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagKeysResponse>(DoRequest("ListTagKeys", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagKeysResponse>(await DoRequestAsync("ListTagKeys", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        public DescribeDomainQpsWithCacheResponse DescribeDomainQpsWithCacheWithOptions(DescribeDomainQpsWithCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDomainQpsWithCacheResponse>(DoRequest("DescribeDomainQpsWithCache", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDomainQpsWithCacheResponse> DescribeDomainQpsWithCacheWithOptionsAsync(DescribeDomainQpsWithCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDomainQpsWithCacheResponse>(await DoRequestAsync("DescribeDomainQpsWithCache", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDomainQpsWithCacheResponse DescribeDomainQpsWithCache(DescribeDomainQpsWithCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainQpsWithCacheWithOptions(request, runtime);
        }

        public async Task<DescribeDomainQpsWithCacheResponse> DescribeDomainQpsWithCacheAsync(DescribeDomainQpsWithCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainQpsWithCacheWithOptionsAsync(request, runtime);
        }

        public DescribeLogStoreExistStatusResponse DescribeLogStoreExistStatusWithOptions(DescribeLogStoreExistStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLogStoreExistStatusResponse>(DoRequest("DescribeLogStoreExistStatus", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLogStoreExistStatusResponse> DescribeLogStoreExistStatusWithOptionsAsync(DescribeLogStoreExistStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLogStoreExistStatusResponse>(await DoRequestAsync("DescribeLogStoreExistStatus", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeLogStoreExistStatusResponse DescribeLogStoreExistStatus(DescribeLogStoreExistStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogStoreExistStatusWithOptions(request, runtime);
        }

        public async Task<DescribeLogStoreExistStatusResponse> DescribeLogStoreExistStatusAsync(DescribeLogStoreExistStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogStoreExistStatusWithOptionsAsync(request, runtime);
        }

        public DescribeBatchSlsDispatchStatusResponse DescribeBatchSlsDispatchStatusWithOptions(DescribeBatchSlsDispatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBatchSlsDispatchStatusResponse>(DoRequest("DescribeBatchSlsDispatchStatus", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeBatchSlsDispatchStatusResponse> DescribeBatchSlsDispatchStatusWithOptionsAsync(DescribeBatchSlsDispatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBatchSlsDispatchStatusResponse>(await DoRequestAsync("DescribeBatchSlsDispatchStatus", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeBatchSlsDispatchStatusResponse DescribeBatchSlsDispatchStatus(DescribeBatchSlsDispatchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBatchSlsDispatchStatusWithOptions(request, runtime);
        }

        public async Task<DescribeBatchSlsDispatchStatusResponse> DescribeBatchSlsDispatchStatusAsync(DescribeBatchSlsDispatchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBatchSlsDispatchStatusWithOptionsAsync(request, runtime);
        }

        public DescribeSlsEmptyCountResponse DescribeSlsEmptyCountWithOptions(DescribeSlsEmptyCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSlsEmptyCountResponse>(DoRequest("DescribeSlsEmptyCount", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeSlsEmptyCountResponse> DescribeSlsEmptyCountWithOptionsAsync(DescribeSlsEmptyCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSlsEmptyCountResponse>(await DoRequestAsync("DescribeSlsEmptyCount", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeSlsEmptyCountResponse DescribeSlsEmptyCount(DescribeSlsEmptyCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlsEmptyCountWithOptions(request, runtime);
        }

        public async Task<DescribeSlsEmptyCountResponse> DescribeSlsEmptyCountAsync(DescribeSlsEmptyCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlsEmptyCountWithOptionsAsync(request, runtime);
        }

        public EmptySlsLogstoreResponse EmptySlsLogstoreWithOptions(EmptySlsLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EmptySlsLogstoreResponse>(DoRequest("EmptySlsLogstore", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EmptySlsLogstoreResponse> EmptySlsLogstoreWithOptionsAsync(EmptySlsLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EmptySlsLogstoreResponse>(await DoRequestAsync("EmptySlsLogstore", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public EmptySlsLogstoreResponse EmptySlsLogstore(EmptySlsLogstoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EmptySlsLogstoreWithOptions(request, runtime);
        }

        public async Task<EmptySlsLogstoreResponse> EmptySlsLogstoreAsync(EmptySlsLogstoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EmptySlsLogstoreWithOptionsAsync(request, runtime);
        }

        public CloseDomainSlsConfigResponse CloseDomainSlsConfigWithOptions(CloseDomainSlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CloseDomainSlsConfigResponse>(DoRequest("CloseDomainSlsConfig", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CloseDomainSlsConfigResponse> CloseDomainSlsConfigWithOptionsAsync(CloseDomainSlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CloseDomainSlsConfigResponse>(await DoRequestAsync("CloseDomainSlsConfig", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public CloseDomainSlsConfigResponse CloseDomainSlsConfig(CloseDomainSlsConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseDomainSlsConfigWithOptions(request, runtime);
        }

        public async Task<CloseDomainSlsConfigResponse> CloseDomainSlsConfigAsync(CloseDomainSlsConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseDomainSlsConfigWithOptionsAsync(request, runtime);
        }

        public OpenDomainSlsConfigResponse OpenDomainSlsConfigWithOptions(OpenDomainSlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<OpenDomainSlsConfigResponse>(DoRequest("OpenDomainSlsConfig", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<OpenDomainSlsConfigResponse> OpenDomainSlsConfigWithOptionsAsync(OpenDomainSlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<OpenDomainSlsConfigResponse>(await DoRequestAsync("OpenDomainSlsConfig", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public OpenDomainSlsConfigResponse OpenDomainSlsConfig(OpenDomainSlsConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenDomainSlsConfigWithOptions(request, runtime);
        }

        public async Task<OpenDomainSlsConfigResponse> OpenDomainSlsConfigAsync(OpenDomainSlsConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenDomainSlsConfigWithOptionsAsync(request, runtime);
        }

        public DescribeSlsLogstoreInfoResponse DescribeSlsLogstoreInfoWithOptions(DescribeSlsLogstoreInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSlsLogstoreInfoResponse>(DoRequest("DescribeSlsLogstoreInfo", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeSlsLogstoreInfoResponse> DescribeSlsLogstoreInfoWithOptionsAsync(DescribeSlsLogstoreInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSlsLogstoreInfoResponse>(await DoRequestAsync("DescribeSlsLogstoreInfo", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeSlsLogstoreInfoResponse DescribeSlsLogstoreInfo(DescribeSlsLogstoreInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlsLogstoreInfoWithOptions(request, runtime);
        }

        public async Task<DescribeSlsLogstoreInfoResponse> DescribeSlsLogstoreInfoAsync(DescribeSlsLogstoreInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlsLogstoreInfoWithOptionsAsync(request, runtime);
        }

        public DescribeSlsAuthStatusResponse DescribeSlsAuthStatusWithOptions(DescribeSlsAuthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSlsAuthStatusResponse>(DoRequest("DescribeSlsAuthStatus", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeSlsAuthStatusResponse> DescribeSlsAuthStatusWithOptionsAsync(DescribeSlsAuthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSlsAuthStatusResponse>(await DoRequestAsync("DescribeSlsAuthStatus", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeSlsAuthStatusResponse DescribeSlsAuthStatus(DescribeSlsAuthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlsAuthStatusWithOptions(request, runtime);
        }

        public async Task<DescribeSlsAuthStatusResponse> DescribeSlsAuthStatusAsync(DescribeSlsAuthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlsAuthStatusWithOptionsAsync(request, runtime);
        }

        public DescribeSlsOpenStatusResponse DescribeSlsOpenStatusWithOptions(DescribeSlsOpenStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSlsOpenStatusResponse>(DoRequest("DescribeSlsOpenStatus", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeSlsOpenStatusResponse> DescribeSlsOpenStatusWithOptionsAsync(DescribeSlsOpenStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSlsOpenStatusResponse>(await DoRequestAsync("DescribeSlsOpenStatus", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeSlsOpenStatusResponse DescribeSlsOpenStatus(DescribeSlsOpenStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlsOpenStatusWithOptions(request, runtime);
        }

        public async Task<DescribeSlsOpenStatusResponse> DescribeSlsOpenStatusAsync(DescribeSlsOpenStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlsOpenStatusWithOptionsAsync(request, runtime);
        }

        public DescribeDomainSlsStatusResponse DescribeDomainSlsStatusWithOptions(DescribeDomainSlsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDomainSlsStatusResponse>(DoRequest("DescribeDomainSlsStatus", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDomainSlsStatusResponse> DescribeDomainSlsStatusWithOptionsAsync(DescribeDomainSlsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDomainSlsStatusResponse>(await DoRequestAsync("DescribeDomainSlsStatus", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDomainSlsStatusResponse DescribeDomainSlsStatus(DescribeDomainSlsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainSlsStatusWithOptions(request, runtime);
        }

        public async Task<DescribeDomainSlsStatusResponse> DescribeDomainSlsStatusAsync(DescribeDomainSlsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainSlsStatusWithOptionsAsync(request, runtime);
        }

        public ConfigDomainAccessModeResponse ConfigDomainAccessModeWithOptions(ConfigDomainAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigDomainAccessModeResponse>(DoRequest("ConfigDomainAccessMode", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ConfigDomainAccessModeResponse> ConfigDomainAccessModeWithOptionsAsync(ConfigDomainAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigDomainAccessModeResponse>(await DoRequestAsync("ConfigDomainAccessMode", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ConfigDomainAccessModeResponse ConfigDomainAccessMode(ConfigDomainAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigDomainAccessModeWithOptions(request, runtime);
        }

        public async Task<ConfigDomainAccessModeResponse> ConfigDomainAccessModeAsync(ConfigDomainAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigDomainAccessModeWithOptionsAsync(request, runtime);
        }

        public DescribeDomainAccessModeResponse DescribeDomainAccessModeWithOptions(DescribeDomainAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDomainAccessModeResponse>(DoRequest("DescribeDomainAccessMode", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDomainAccessModeResponse> DescribeDomainAccessModeWithOptionsAsync(DescribeDomainAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDomainAccessModeResponse>(await DoRequestAsync("DescribeDomainAccessMode", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDomainAccessModeResponse DescribeDomainAccessMode(DescribeDomainAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainAccessModeWithOptions(request, runtime);
        }

        public async Task<DescribeDomainAccessModeResponse> DescribeDomainAccessModeAsync(DescribeDomainAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainAccessModeWithOptionsAsync(request, runtime);
        }

        public DeleteAsyncTaskResponse DeleteAsyncTaskWithOptions(DeleteAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteAsyncTaskResponse>(DoRequest("DeleteAsyncTask", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteAsyncTaskResponse> DeleteAsyncTaskWithOptionsAsync(DeleteAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteAsyncTaskResponse>(await DoRequestAsync("DeleteAsyncTask", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DeleteAsyncTaskResponse DeleteAsyncTask(DeleteAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAsyncTaskWithOptions(request, runtime);
        }

        public async Task<DeleteAsyncTaskResponse> DeleteAsyncTaskAsync(DeleteAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAsyncTaskWithOptionsAsync(request, runtime);
        }

        public CreateAsyncTaskResponse CreateAsyncTaskWithOptions(CreateAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateAsyncTaskResponse>(DoRequest("CreateAsyncTask", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateAsyncTaskResponse> CreateAsyncTaskWithOptionsAsync(CreateAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateAsyncTaskResponse>(await DoRequestAsync("CreateAsyncTask", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public CreateAsyncTaskResponse CreateAsyncTask(CreateAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAsyncTaskWithOptions(request, runtime);
        }

        public async Task<CreateAsyncTaskResponse> CreateAsyncTaskAsync(CreateAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAsyncTaskWithOptionsAsync(request, runtime);
        }

        public ListAsyncTaskResponse ListAsyncTaskWithOptions(ListAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAsyncTaskResponse>(DoRequest("ListAsyncTask", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListAsyncTaskResponse> ListAsyncTaskWithOptionsAsync(ListAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAsyncTaskResponse>(await DoRequestAsync("ListAsyncTask", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ListAsyncTaskResponse ListAsyncTask(ListAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAsyncTaskWithOptions(request, runtime);
        }

        public async Task<ListAsyncTaskResponse> ListAsyncTaskAsync(ListAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAsyncTaskWithOptionsAsync(request, runtime);
        }

        public EnableLayer7CCRuleResponse EnableLayer7CCRuleWithOptions(EnableLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableLayer7CCRuleResponse>(DoRequest("EnableLayer7CCRule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EnableLayer7CCRuleResponse> EnableLayer7CCRuleWithOptionsAsync(EnableLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableLayer7CCRuleResponse>(await DoRequestAsync("EnableLayer7CCRule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public EnableLayer7CCRuleResponse EnableLayer7CCRule(EnableLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableLayer7CCRuleWithOptions(request, runtime);
        }

        public async Task<EnableLayer7CCRuleResponse> EnableLayer7CCRuleAsync(EnableLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableLayer7CCRuleWithOptionsAsync(request, runtime);
        }

        public EnableLayer7CCResponse EnableLayer7CCWithOptions(EnableLayer7CCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableLayer7CCResponse>(DoRequest("EnableLayer7CC", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EnableLayer7CCResponse> EnableLayer7CCWithOptionsAsync(EnableLayer7CCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableLayer7CCResponse>(await DoRequestAsync("EnableLayer7CC", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public EnableLayer7CCResponse EnableLayer7CC(EnableLayer7CCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableLayer7CCWithOptions(request, runtime);
        }

        public async Task<EnableLayer7CCResponse> EnableLayer7CCAsync(EnableLayer7CCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableLayer7CCWithOptionsAsync(request, runtime);
        }

        public DisableLayer7CCRuleResponse DisableLayer7CCRuleWithOptions(DisableLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableLayer7CCRuleResponse>(DoRequest("DisableLayer7CCRule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DisableLayer7CCRuleResponse> DisableLayer7CCRuleWithOptionsAsync(DisableLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableLayer7CCRuleResponse>(await DoRequestAsync("DisableLayer7CCRule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DisableLayer7CCRuleResponse DisableLayer7CCRule(DisableLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableLayer7CCRuleWithOptions(request, runtime);
        }

        public async Task<DisableLayer7CCRuleResponse> DisableLayer7CCRuleAsync(DisableLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableLayer7CCRuleWithOptionsAsync(request, runtime);
        }

        public DisableLayer7CCResponse DisableLayer7CCWithOptions(DisableLayer7CCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableLayer7CCResponse>(DoRequest("DisableLayer7CC", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DisableLayer7CCResponse> DisableLayer7CCWithOptionsAsync(DisableLayer7CCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableLayer7CCResponse>(await DoRequestAsync("DisableLayer7CC", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DisableLayer7CCResponse DisableLayer7CC(DisableLayer7CCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableLayer7CCWithOptions(request, runtime);
        }

        public async Task<DisableLayer7CCResponse> DisableLayer7CCAsync(DisableLayer7CCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableLayer7CCWithOptionsAsync(request, runtime);
        }

        public DescribleLayer7InstanceRelationsResponse DescribleLayer7InstanceRelationsWithOptions(DescribleLayer7InstanceRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribleLayer7InstanceRelationsResponse>(DoRequest("DescribleLayer7InstanceRelations", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribleLayer7InstanceRelationsResponse> DescribleLayer7InstanceRelationsWithOptionsAsync(DescribleLayer7InstanceRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribleLayer7InstanceRelationsResponse>(await DoRequestAsync("DescribleLayer7InstanceRelations", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribleLayer7InstanceRelationsResponse DescribleLayer7InstanceRelations(DescribleLayer7InstanceRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribleLayer7InstanceRelationsWithOptions(request, runtime);
        }

        public async Task<DescribleLayer7InstanceRelationsResponse> DescribleLayer7InstanceRelationsAsync(DescribleLayer7InstanceRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribleLayer7InstanceRelationsWithOptionsAsync(request, runtime);
        }

        public DescribleCertListResponse DescribleCertListWithOptions(DescribleCertListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribleCertListResponse>(DoRequest("DescribleCertList", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribleCertListResponse> DescribleCertListWithOptionsAsync(DescribleCertListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribleCertListResponse>(await DoRequestAsync("DescribleCertList", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribleCertListResponse DescribleCertList(DescribleCertListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribleCertListWithOptions(request, runtime);
        }

        public async Task<DescribleCertListResponse> DescribleCertListAsync(DescribleCertListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribleCertListWithOptionsAsync(request, runtime);
        }

        public DescribeLayer7CCRulesResponse DescribeLayer7CCRulesWithOptions(DescribeLayer7CCRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLayer7CCRulesResponse>(DoRequest("DescribeLayer7CCRules", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLayer7CCRulesResponse> DescribeLayer7CCRulesWithOptionsAsync(DescribeLayer7CCRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLayer7CCRulesResponse>(await DoRequestAsync("DescribeLayer7CCRules", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeLayer7CCRulesResponse DescribeLayer7CCRules(DescribeLayer7CCRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLayer7CCRulesWithOptions(request, runtime);
        }

        public async Task<DescribeLayer7CCRulesResponse> DescribeLayer7CCRulesAsync(DescribeLayer7CCRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLayer7CCRulesWithOptionsAsync(request, runtime);
        }

        public DescribeDomainsResponse DescribeDomainsWithOptions(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDomainsResponse>(DoRequest("DescribeDomains", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDomainsResponse> DescribeDomainsWithOptionsAsync(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDomainsResponse>(await DoRequestAsync("DescribeDomains", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeDomainQpsResponse DescribeDomainQpsWithOptions(DescribeDomainQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDomainQpsResponse>(DoRequest("DescribeDomainQps", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDomainQpsResponse> DescribeDomainQpsWithOptionsAsync(DescribeDomainQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDomainQpsResponse>(await DoRequestAsync("DescribeDomainQps", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDomainQpsResponse DescribeDomainQps(DescribeDomainQpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainQpsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainQpsResponse> DescribeDomainQpsAsync(DescribeDomainQpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainQpsWithOptionsAsync(request, runtime);
        }

        public DescribeDomainAttackEventsResponse DescribeDomainAttackEventsWithOptions(DescribeDomainAttackEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDomainAttackEventsResponse>(DoRequest("DescribeDomainAttackEvents", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDomainAttackEventsResponse> DescribeDomainAttackEventsWithOptionsAsync(DescribeDomainAttackEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDomainAttackEventsResponse>(await DoRequestAsync("DescribeDomainAttackEvents", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDomainAttackEventsResponse DescribeDomainAttackEvents(DescribeDomainAttackEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainAttackEventsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainAttackEventsResponse> DescribeDomainAttackEventsAsync(DescribeDomainAttackEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainAttackEventsWithOptionsAsync(request, runtime);
        }

        public DescribeBackSourceCidrResponse DescribeBackSourceCidrWithOptions(DescribeBackSourceCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBackSourceCidrResponse>(DoRequest("DescribeBackSourceCidr", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeBackSourceCidrResponse> DescribeBackSourceCidrWithOptionsAsync(DescribeBackSourceCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBackSourceCidrResponse>(await DoRequestAsync("DescribeBackSourceCidr", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeBackSourceCidrResponse DescribeBackSourceCidr(DescribeBackSourceCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackSourceCidrWithOptions(request, runtime);
        }

        public async Task<DescribeBackSourceCidrResponse> DescribeBackSourceCidrAsync(DescribeBackSourceCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackSourceCidrWithOptionsAsync(request, runtime);
        }

        public DeleteLayer7RuleResponse DeleteLayer7RuleWithOptions(DeleteLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLayer7RuleResponse>(DoRequest("DeleteLayer7Rule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLayer7RuleResponse> DeleteLayer7RuleWithOptionsAsync(DeleteLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLayer7RuleResponse>(await DoRequestAsync("DeleteLayer7Rule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DeleteLayer7RuleResponse DeleteLayer7Rule(DeleteLayer7RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLayer7RuleWithOptions(request, runtime);
        }

        public async Task<DeleteLayer7RuleResponse> DeleteLayer7RuleAsync(DeleteLayer7RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLayer7RuleWithOptionsAsync(request, runtime);
        }

        public DeleteLayer7CCRuleResponse DeleteLayer7CCRuleWithOptions(DeleteLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLayer7CCRuleResponse>(DoRequest("DeleteLayer7CCRule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLayer7CCRuleResponse> DeleteLayer7CCRuleWithOptionsAsync(DeleteLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLayer7CCRuleResponse>(await DoRequestAsync("DeleteLayer7CCRule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DeleteLayer7CCRuleResponse DeleteLayer7CCRule(DeleteLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLayer7CCRuleWithOptions(request, runtime);
        }

        public async Task<DeleteLayer7CCRuleResponse> DeleteLayer7CCRuleAsync(DeleteLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLayer7CCRuleWithOptionsAsync(request, runtime);
        }

        public CreateLayer7RuleResponse CreateLayer7RuleWithOptions(CreateLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateLayer7RuleResponse>(DoRequest("CreateLayer7Rule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateLayer7RuleResponse> CreateLayer7RuleWithOptionsAsync(CreateLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateLayer7RuleResponse>(await DoRequestAsync("CreateLayer7Rule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public CreateLayer7RuleResponse CreateLayer7Rule(CreateLayer7RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLayer7RuleWithOptions(request, runtime);
        }

        public async Task<CreateLayer7RuleResponse> CreateLayer7RuleAsync(CreateLayer7RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLayer7RuleWithOptionsAsync(request, runtime);
        }

        public ConfigLayer7RuleResponse ConfigLayer7RuleWithOptions(ConfigLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer7RuleResponse>(DoRequest("ConfigLayer7Rule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ConfigLayer7RuleResponse> ConfigLayer7RuleWithOptionsAsync(ConfigLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer7RuleResponse>(await DoRequestAsync("ConfigLayer7Rule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ConfigLayer7RuleResponse ConfigLayer7Rule(ConfigLayer7RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer7RuleWithOptions(request, runtime);
        }

        public async Task<ConfigLayer7RuleResponse> ConfigLayer7RuleAsync(ConfigLayer7RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer7RuleWithOptionsAsync(request, runtime);
        }

        public ConfigLayer7CertResponse ConfigLayer7CertWithOptions(ConfigLayer7CertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer7CertResponse>(DoRequest("ConfigLayer7Cert", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ConfigLayer7CertResponse> ConfigLayer7CertWithOptionsAsync(ConfigLayer7CertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer7CertResponse>(await DoRequestAsync("ConfigLayer7Cert", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ConfigLayer7CertResponse ConfigLayer7Cert(ConfigLayer7CertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer7CertWithOptions(request, runtime);
        }

        public async Task<ConfigLayer7CertResponse> ConfigLayer7CertAsync(ConfigLayer7CertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer7CertWithOptionsAsync(request, runtime);
        }

        public ConfigLayer7CCTemplateResponse ConfigLayer7CCTemplateWithOptions(ConfigLayer7CCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer7CCTemplateResponse>(DoRequest("ConfigLayer7CCTemplate", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ConfigLayer7CCTemplateResponse> ConfigLayer7CCTemplateWithOptionsAsync(ConfigLayer7CCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer7CCTemplateResponse>(await DoRequestAsync("ConfigLayer7CCTemplate", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ConfigLayer7CCTemplateResponse ConfigLayer7CCTemplate(ConfigLayer7CCTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer7CCTemplateWithOptions(request, runtime);
        }

        public async Task<ConfigLayer7CCTemplateResponse> ConfigLayer7CCTemplateAsync(ConfigLayer7CCTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer7CCTemplateWithOptionsAsync(request, runtime);
        }

        public ConfigLayer7CCRuleResponse ConfigLayer7CCRuleWithOptions(ConfigLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer7CCRuleResponse>(DoRequest("ConfigLayer7CCRule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ConfigLayer7CCRuleResponse> ConfigLayer7CCRuleWithOptionsAsync(ConfigLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer7CCRuleResponse>(await DoRequestAsync("ConfigLayer7CCRule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ConfigLayer7CCRuleResponse ConfigLayer7CCRule(ConfigLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer7CCRuleWithOptions(request, runtime);
        }

        public async Task<ConfigLayer7CCRuleResponse> ConfigLayer7CCRuleAsync(ConfigLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer7CCRuleWithOptionsAsync(request, runtime);
        }

        public ConfigLayer7BlackWhiteListResponse ConfigLayer7BlackWhiteListWithOptions(ConfigLayer7BlackWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer7BlackWhiteListResponse>(DoRequest("ConfigLayer7BlackWhiteList", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ConfigLayer7BlackWhiteListResponse> ConfigLayer7BlackWhiteListWithOptionsAsync(ConfigLayer7BlackWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer7BlackWhiteListResponse>(await DoRequestAsync("ConfigLayer7BlackWhiteList", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ConfigLayer7BlackWhiteListResponse ConfigLayer7BlackWhiteList(ConfigLayer7BlackWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer7BlackWhiteListWithOptions(request, runtime);
        }

        public async Task<ConfigLayer7BlackWhiteListResponse> ConfigLayer7BlackWhiteListAsync(ConfigLayer7BlackWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer7BlackWhiteListWithOptionsAsync(request, runtime);
        }

        public AddLayer7CCRuleResponse AddLayer7CCRuleWithOptions(AddLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLayer7CCRuleResponse>(DoRequest("AddLayer7CCRule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLayer7CCRuleResponse> AddLayer7CCRuleWithOptionsAsync(AddLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLayer7CCRuleResponse>(await DoRequestAsync("AddLayer7CCRule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public AddLayer7CCRuleResponse AddLayer7CCRule(AddLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLayer7CCRuleWithOptions(request, runtime);
        }

        public async Task<AddLayer7CCRuleResponse> AddLayer7CCRuleAsync(AddLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLayer7CCRuleWithOptionsAsync(request, runtime);
        }

        public ReleaseInstanceResponse ReleaseInstanceWithOptions(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseInstanceResponse>(DoRequest("ReleaseInstance", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReleaseInstanceResponse> ReleaseInstanceWithOptionsAsync(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseInstanceResponse>(await DoRequestAsync("ReleaseInstance", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ReleaseInstanceResponse ReleaseInstance(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstanceWithOptions(request, runtime);
        }

        public async Task<ReleaseInstanceResponse> ReleaseInstanceAsync(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstanceWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceRemarkResponse ModifyInstanceRemarkWithOptions(ModifyInstanceRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyInstanceRemarkResponse>(DoRequest("ModifyInstanceRemark", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyInstanceRemarkResponse> ModifyInstanceRemarkWithOptionsAsync(ModifyInstanceRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyInstanceRemarkResponse>(await DoRequestAsync("ModifyInstanceRemark", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ModifyInstanceRemarkResponse ModifyInstanceRemark(ModifyInstanceRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceRemarkWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceRemarkResponse> ModifyInstanceRemarkAsync(ModifyInstanceRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceRemarkWithOptionsAsync(request, runtime);
        }

        public ModifyElasticBandWidthResponse ModifyElasticBandWidthWithOptions(ModifyElasticBandWidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyElasticBandWidthResponse>(DoRequest("ModifyElasticBandWidth", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyElasticBandWidthResponse> ModifyElasticBandWidthWithOptionsAsync(ModifyElasticBandWidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyElasticBandWidthResponse>(await DoRequestAsync("ModifyElasticBandWidth", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ModifyElasticBandWidthResponse ModifyElasticBandWidth(ModifyElasticBandWidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyElasticBandWidthWithOptions(request, runtime);
        }

        public async Task<ModifyElasticBandWidthResponse> ModifyElasticBandWidthAsync(ModifyElasticBandWidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyElasticBandWidthWithOptionsAsync(request, runtime);
        }

        public DescribeOpEntitiesResponse DescribeOpEntitiesWithOptions(DescribeOpEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOpEntitiesResponse>(DoRequest("DescribeOpEntities", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeOpEntitiesResponse> DescribeOpEntitiesWithOptionsAsync(DescribeOpEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOpEntitiesResponse>(await DoRequestAsync("DescribeOpEntities", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeOpEntitiesResponse DescribeOpEntities(DescribeOpEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOpEntitiesWithOptions(request, runtime);
        }

        public async Task<DescribeOpEntitiesResponse> DescribeOpEntitiesAsync(DescribeOpEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOpEntitiesWithOptionsAsync(request, runtime);
        }

        public DescribeLayer4RulesResponse DescribeLayer4RulesWithOptions(DescribeLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLayer4RulesResponse>(DoRequest("DescribeLayer4Rules", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLayer4RulesResponse> DescribeLayer4RulesWithOptionsAsync(DescribeLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLayer4RulesResponse>(await DoRequestAsync("DescribeLayer4Rules", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeLayer4RulesResponse DescribeLayer4Rules(DescribeLayer4RulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLayer4RulesWithOptions(request, runtime);
        }

        public async Task<DescribeLayer4RulesResponse> DescribeLayer4RulesAsync(DescribeLayer4RulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLayer4RulesWithOptionsAsync(request, runtime);
        }

        public DescribeLayer4RuleAttributesResponse DescribeLayer4RuleAttributesWithOptions(DescribeLayer4RuleAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLayer4RuleAttributesResponse>(DoRequest("DescribeLayer4RuleAttributes", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLayer4RuleAttributesResponse> DescribeLayer4RuleAttributesWithOptionsAsync(DescribeLayer4RuleAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLayer4RuleAttributesResponse>(await DoRequestAsync("DescribeLayer4RuleAttributes", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeLayer4RuleAttributesResponse DescribeLayer4RuleAttributes(DescribeLayer4RuleAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLayer4RuleAttributesWithOptions(request, runtime);
        }

        public async Task<DescribeLayer4RuleAttributesResponse> DescribeLayer4RuleAttributesAsync(DescribeLayer4RuleAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLayer4RuleAttributesWithOptionsAsync(request, runtime);
        }

        public DescribeIpTrafficResponse DescribeIpTrafficWithOptions(DescribeIpTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeIpTrafficResponse>(DoRequest("DescribeIpTraffic", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeIpTrafficResponse> DescribeIpTrafficWithOptionsAsync(DescribeIpTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeIpTrafficResponse>(await DoRequestAsync("DescribeIpTraffic", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeIpTrafficResponse DescribeIpTraffic(DescribeIpTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpTrafficWithOptions(request, runtime);
        }

        public async Task<DescribeIpTrafficResponse> DescribeIpTrafficAsync(DescribeIpTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpTrafficWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceStatisticsResponse DescribeInstanceStatisticsWithOptions(DescribeInstanceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceStatisticsResponse>(DoRequest("DescribeInstanceStatistics", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstanceStatisticsResponse> DescribeInstanceStatisticsWithOptionsAsync(DescribeInstanceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceStatisticsResponse>(await DoRequestAsync("DescribeInstanceStatistics", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInstanceStatisticsResponse DescribeInstanceStatistics(DescribeInstanceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceStatisticsResponse> DescribeInstanceStatisticsAsync(DescribeInstanceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceSpecsResponse DescribeInstanceSpecsWithOptions(DescribeInstanceSpecsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceSpecsResponse>(DoRequest("DescribeInstanceSpecs", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstanceSpecsResponse> DescribeInstanceSpecsWithOptionsAsync(DescribeInstanceSpecsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceSpecsResponse>(await DoRequestAsync("DescribeInstanceSpecs", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInstanceSpecsResponse DescribeInstanceSpecs(DescribeInstanceSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSpecsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceSpecsResponse> DescribeInstanceSpecsAsync(DescribeInstanceSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSpecsWithOptionsAsync(request, runtime);
        }

        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstancesResponse>(DoRequest("DescribeInstances", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstancesResponse>(await DoRequestAsync("DescribeInstances", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceDetailsResponse DescribeInstanceDetailsWithOptions(DescribeInstanceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceDetailsResponse>(DoRequest("DescribeInstanceDetails", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstanceDetailsResponse> DescribeInstanceDetailsWithOptionsAsync(DescribeInstanceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceDetailsResponse>(await DoRequestAsync("DescribeInstanceDetails", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInstanceDetailsResponse DescribeInstanceDetails(DescribeInstanceDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceDetailsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceDetailsResponse> DescribeInstanceDetailsAsync(DescribeInstanceDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceDetailsWithOptionsAsync(request, runtime);
        }

        public DescribeHealthCheckStatusListResponse DescribeHealthCheckStatusListWithOptions(DescribeHealthCheckStatusListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeHealthCheckStatusListResponse>(DoRequest("DescribeHealthCheckStatusList", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeHealthCheckStatusListResponse> DescribeHealthCheckStatusListWithOptionsAsync(DescribeHealthCheckStatusListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeHealthCheckStatusListResponse>(await DoRequestAsync("DescribeHealthCheckStatusList", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeHealthCheckStatusListResponse DescribeHealthCheckStatusList(DescribeHealthCheckStatusListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHealthCheckStatusListWithOptions(request, runtime);
        }

        public async Task<DescribeHealthCheckStatusListResponse> DescribeHealthCheckStatusListAsync(DescribeHealthCheckStatusListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHealthCheckStatusListWithOptionsAsync(request, runtime);
        }

        public DescribeHealthCheckListResponse DescribeHealthCheckListWithOptions(DescribeHealthCheckListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeHealthCheckListResponse>(DoRequest("DescribeHealthCheckList", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeHealthCheckListResponse> DescribeHealthCheckListWithOptionsAsync(DescribeHealthCheckListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeHealthCheckListResponse>(await DoRequestAsync("DescribeHealthCheckList", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeHealthCheckListResponse DescribeHealthCheckList(DescribeHealthCheckListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHealthCheckListWithOptions(request, runtime);
        }

        public async Task<DescribeHealthCheckListResponse> DescribeHealthCheckListAsync(DescribeHealthCheckListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHealthCheckListWithOptionsAsync(request, runtime);
        }

        public DescribeElasticBandwidthSpecResponse DescribeElasticBandwidthSpecWithOptions(DescribeElasticBandwidthSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeElasticBandwidthSpecResponse>(DoRequest("DescribeElasticBandwidthSpec", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeElasticBandwidthSpecResponse> DescribeElasticBandwidthSpecWithOptionsAsync(DescribeElasticBandwidthSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeElasticBandwidthSpecResponse>(await DoRequestAsync("DescribeElasticBandwidthSpec", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeElasticBandwidthSpecResponse DescribeElasticBandwidthSpec(DescribeElasticBandwidthSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeElasticBandwidthSpecWithOptions(request, runtime);
        }

        public async Task<DescribeElasticBandwidthSpecResponse> DescribeElasticBandwidthSpecAsync(DescribeElasticBandwidthSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeElasticBandwidthSpecWithOptionsAsync(request, runtime);
        }

        public DescribeDDoSTrafficResponse DescribeDDoSTrafficWithOptions(DescribeDDoSTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDDoSTrafficResponse>(DoRequest("DescribeDDoSTraffic", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDDoSTrafficResponse> DescribeDDoSTrafficWithOptionsAsync(DescribeDDoSTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDDoSTrafficResponse>(await DoRequestAsync("DescribeDDoSTraffic", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDDoSTrafficResponse DescribeDDoSTraffic(DescribeDDoSTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDDoSTrafficWithOptions(request, runtime);
        }

        public async Task<DescribeDDoSTrafficResponse> DescribeDDoSTrafficAsync(DescribeDDoSTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDDoSTrafficWithOptionsAsync(request, runtime);
        }

        public DescribeDDoSEventsResponse DescribeDDoSEventsWithOptions(DescribeDDoSEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDDoSEventsResponse>(DoRequest("DescribeDDoSEvents", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDDoSEventsResponse> DescribeDDoSEventsWithOptionsAsync(DescribeDDoSEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDDoSEventsResponse>(await DoRequestAsync("DescribeDDoSEvents", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDDoSEventsResponse DescribeDDoSEvents(DescribeDDoSEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDDoSEventsWithOptions(request, runtime);
        }

        public async Task<DescribeDDoSEventsResponse> DescribeDDoSEventsAsync(DescribeDDoSEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDDoSEventsWithOptionsAsync(request, runtime);
        }

        public DeleteLayer4RuleResponse DeleteLayer4RuleWithOptions(DeleteLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLayer4RuleResponse>(DoRequest("DeleteLayer4Rule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLayer4RuleResponse> DeleteLayer4RuleWithOptionsAsync(DeleteLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLayer4RuleResponse>(await DoRequestAsync("DeleteLayer4Rule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public DeleteLayer4RuleResponse DeleteLayer4Rule(DeleteLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLayer4RuleWithOptions(request, runtime);
        }

        public async Task<DeleteLayer4RuleResponse> DeleteLayer4RuleAsync(DeleteLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLayer4RuleWithOptionsAsync(request, runtime);
        }

        public CreateLayer4RuleResponse CreateLayer4RuleWithOptions(CreateLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateLayer4RuleResponse>(DoRequest("CreateLayer4Rule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateLayer4RuleResponse> CreateLayer4RuleWithOptionsAsync(CreateLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateLayer4RuleResponse>(await DoRequestAsync("CreateLayer4Rule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public CreateLayer4RuleResponse CreateLayer4Rule(CreateLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLayer4RuleWithOptions(request, runtime);
        }

        public async Task<CreateLayer4RuleResponse> CreateLayer4RuleAsync(CreateLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLayer4RuleWithOptionsAsync(request, runtime);
        }

        public ConfigLayer4RuleAttributeResponse ConfigLayer4RuleAttributeWithOptions(ConfigLayer4RuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer4RuleAttributeResponse>(DoRequest("ConfigLayer4RuleAttribute", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ConfigLayer4RuleAttributeResponse> ConfigLayer4RuleAttributeWithOptionsAsync(ConfigLayer4RuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer4RuleAttributeResponse>(await DoRequestAsync("ConfigLayer4RuleAttribute", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ConfigLayer4RuleAttributeResponse ConfigLayer4RuleAttribute(ConfigLayer4RuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer4RuleAttributeWithOptions(request, runtime);
        }

        public async Task<ConfigLayer4RuleAttributeResponse> ConfigLayer4RuleAttributeAsync(ConfigLayer4RuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer4RuleAttributeWithOptionsAsync(request, runtime);
        }

        public ConfigLayer4RuleResponse ConfigLayer4RuleWithOptions(ConfigLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer4RuleResponse>(DoRequest("ConfigLayer4Rule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ConfigLayer4RuleResponse> ConfigLayer4RuleWithOptionsAsync(ConfigLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigLayer4RuleResponse>(await DoRequestAsync("ConfigLayer4Rule", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ConfigLayer4RuleResponse ConfigLayer4Rule(ConfigLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer4RuleWithOptions(request, runtime);
        }

        public async Task<ConfigLayer4RuleResponse> ConfigLayer4RuleAsync(ConfigLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer4RuleWithOptionsAsync(request, runtime);
        }

        public ConfigHealthCheckResponse ConfigHealthCheckWithOptions(ConfigHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigHealthCheckResponse>(DoRequest("ConfigHealthCheck", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ConfigHealthCheckResponse> ConfigHealthCheckWithOptionsAsync(ConfigHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigHealthCheckResponse>(await DoRequestAsync("ConfigHealthCheck", "HTTPS", "POST", "2017-12-28", "AK", null, request.ToMap(), runtime));
        }

        public ConfigHealthCheckResponse ConfigHealthCheck(ConfigHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigHealthCheckWithOptions(request, runtime);
        }

        public async Task<ConfigHealthCheckResponse> ConfigHealthCheckAsync(ConfigHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigHealthCheckWithOptionsAsync(request, runtime);
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
