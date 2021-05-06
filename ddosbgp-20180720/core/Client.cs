// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ddosbgp20180720.Models;

namespace AlibabaCloud.SDK.Ddosbgp20180720
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "ddosbgp.aliyuncs.com"},
                {"cn-beijing", "ddosbgp.aliyuncs.com"},
                {"cn-zhangjiakou", "ddosbgp.aliyuncs.com"},
                {"cn-huhehaote", "ddosbgp.aliyuncs.com"},
                {"cn-hangzhou", "ddosbgp.aliyuncs.com"},
                {"cn-shanghai", "ddosbgp.aliyuncs.com"},
                {"cn-shenzhen", "ddosbgp.aliyuncs.com"},
                {"ap-northeast-1", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"cn-chengdu", "ddosbgp.aliyuncs.com"},
                {"eu-central-1", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "ddosbgp.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "ddosbgp.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ddosbgp.aliyuncs.com"},
                {"cn-north-2-gov-1", "ddosbgp.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ddosbgp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public DescribeOnDemandInstanceStatusResponse DescribeOnDemandInstanceStatusWithOptions(DescribeOnDemandInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOnDemandInstanceStatusResponse>(DoRequest("DescribeOnDemandInstanceStatus", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeOnDemandInstanceStatusResponse> DescribeOnDemandInstanceStatusWithOptionsAsync(DescribeOnDemandInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOnDemandInstanceStatusResponse>(await DoRequestAsync("DescribeOnDemandInstanceStatus", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeOnDemandInstanceStatusResponse DescribeOnDemandInstanceStatus(DescribeOnDemandInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOnDemandInstanceStatusWithOptions(request, runtime);
        }

        public async Task<DescribeOnDemandInstanceStatusResponse> DescribeOnDemandInstanceStatusAsync(DescribeOnDemandInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOnDemandInstanceStatusWithOptionsAsync(request, runtime);
        }

        public SetInstanceModeOnDemandResponse SetInstanceModeOnDemandWithOptions(SetInstanceModeOnDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetInstanceModeOnDemandResponse>(DoRequest("SetInstanceModeOnDemand", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetInstanceModeOnDemandResponse> SetInstanceModeOnDemandWithOptionsAsync(SetInstanceModeOnDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetInstanceModeOnDemandResponse>(await DoRequestAsync("SetInstanceModeOnDemand", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public SetInstanceModeOnDemandResponse SetInstanceModeOnDemand(SetInstanceModeOnDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetInstanceModeOnDemandWithOptions(request, runtime);
        }

        public async Task<SetInstanceModeOnDemandResponse> SetInstanceModeOnDemandAsync(SetInstanceModeOnDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetInstanceModeOnDemandWithOptionsAsync(request, runtime);
        }

        public QuerySchedruleOnDemandResponse QuerySchedruleOnDemandWithOptions(QuerySchedruleOnDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySchedruleOnDemandResponse>(DoRequest("QuerySchedruleOnDemand", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySchedruleOnDemandResponse> QuerySchedruleOnDemandWithOptionsAsync(QuerySchedruleOnDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySchedruleOnDemandResponse>(await DoRequestAsync("QuerySchedruleOnDemand", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySchedruleOnDemandResponse QuerySchedruleOnDemand(QuerySchedruleOnDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySchedruleOnDemandWithOptions(request, runtime);
        }

        public async Task<QuerySchedruleOnDemandResponse> QuerySchedruleOnDemandAsync(QuerySchedruleOnDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySchedruleOnDemandWithOptionsAsync(request, runtime);
        }

        public DeleteSchedruleOnDemandResponse DeleteSchedruleOnDemandWithOptions(DeleteSchedruleOnDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSchedruleOnDemandResponse>(DoRequest("DeleteSchedruleOnDemand", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteSchedruleOnDemandResponse> DeleteSchedruleOnDemandWithOptionsAsync(DeleteSchedruleOnDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSchedruleOnDemandResponse>(await DoRequestAsync("DeleteSchedruleOnDemand", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteSchedruleOnDemandResponse DeleteSchedruleOnDemand(DeleteSchedruleOnDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSchedruleOnDemandWithOptions(request, runtime);
        }

        public async Task<DeleteSchedruleOnDemandResponse> DeleteSchedruleOnDemandAsync(DeleteSchedruleOnDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSchedruleOnDemandWithOptionsAsync(request, runtime);
        }

        public ConfigSchedruleOnDemandResponse ConfigSchedruleOnDemandWithOptions(ConfigSchedruleOnDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigSchedruleOnDemandResponse>(DoRequest("ConfigSchedruleOnDemand", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ConfigSchedruleOnDemandResponse> ConfigSchedruleOnDemandWithOptionsAsync(ConfigSchedruleOnDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfigSchedruleOnDemandResponse>(await DoRequestAsync("ConfigSchedruleOnDemand", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public ConfigSchedruleOnDemandResponse ConfigSchedruleOnDemand(ConfigSchedruleOnDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigSchedruleOnDemandWithOptions(request, runtime);
        }

        public async Task<ConfigSchedruleOnDemandResponse> ConfigSchedruleOnDemandAsync(ConfigSchedruleOnDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigSchedruleOnDemandWithOptionsAsync(request, runtime);
        }

        public CreateSchedruleOnDemandResponse CreateSchedruleOnDemandWithOptions(CreateSchedruleOnDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSchedruleOnDemandResponse>(DoRequest("CreateSchedruleOnDemand", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateSchedruleOnDemandResponse> CreateSchedruleOnDemandWithOptionsAsync(CreateSchedruleOnDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSchedruleOnDemandResponse>(await DoRequestAsync("CreateSchedruleOnDemand", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateSchedruleOnDemandResponse CreateSchedruleOnDemand(CreateSchedruleOnDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSchedruleOnDemandWithOptions(request, runtime);
        }

        public async Task<CreateSchedruleOnDemandResponse> CreateSchedruleOnDemandAsync(CreateSchedruleOnDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSchedruleOnDemandWithOptionsAsync(request, runtime);
        }

        public GetSlsOpenStatusResponse GetSlsOpenStatusWithOptions(GetSlsOpenStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSlsOpenStatusResponse>(DoRequest("GetSlsOpenStatus", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetSlsOpenStatusResponse> GetSlsOpenStatusWithOptionsAsync(GetSlsOpenStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSlsOpenStatusResponse>(await DoRequestAsync("GetSlsOpenStatus", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public GetSlsOpenStatusResponse GetSlsOpenStatus(GetSlsOpenStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSlsOpenStatusWithOptions(request, runtime);
        }

        public async Task<GetSlsOpenStatusResponse> GetSlsOpenStatusAsync(GetSlsOpenStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSlsOpenStatusWithOptionsAsync(request, runtime);
        }

        public CheckAccessLogAuthResponse CheckAccessLogAuthWithOptions(CheckAccessLogAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckAccessLogAuthResponse>(DoRequest("CheckAccessLogAuth", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CheckAccessLogAuthResponse> CheckAccessLogAuthWithOptionsAsync(CheckAccessLogAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckAccessLogAuthResponse>(await DoRequestAsync("CheckAccessLogAuth", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public CheckAccessLogAuthResponse CheckAccessLogAuth(CheckAccessLogAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckAccessLogAuthWithOptions(request, runtime);
        }

        public async Task<CheckAccessLogAuthResponse> CheckAccessLogAuthAsync(CheckAccessLogAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckAccessLogAuthWithOptionsAsync(request, runtime);
        }

        public ListOpenedAccessLogInstancesResponse ListOpenedAccessLogInstancesWithOptions(ListOpenedAccessLogInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOpenedAccessLogInstancesResponse>(DoRequest("ListOpenedAccessLogInstances", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListOpenedAccessLogInstancesResponse> ListOpenedAccessLogInstancesWithOptionsAsync(ListOpenedAccessLogInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOpenedAccessLogInstancesResponse>(await DoRequestAsync("ListOpenedAccessLogInstances", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public ListOpenedAccessLogInstancesResponse ListOpenedAccessLogInstances(ListOpenedAccessLogInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOpenedAccessLogInstancesWithOptions(request, runtime);
        }

        public async Task<ListOpenedAccessLogInstancesResponse> ListOpenedAccessLogInstancesAsync(ListOpenedAccessLogInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOpenedAccessLogInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeOnDemandDdosEventResponse DescribeOnDemandDdosEventWithOptions(DescribeOnDemandDdosEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOnDemandDdosEventResponse>(DoRequest("DescribeOnDemandDdosEvent", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeOnDemandDdosEventResponse> DescribeOnDemandDdosEventWithOptionsAsync(DescribeOnDemandDdosEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOnDemandDdosEventResponse>(await DoRequestAsync("DescribeOnDemandDdosEvent", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeOnDemandDdosEventResponse DescribeOnDemandDdosEvent(DescribeOnDemandDdosEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOnDemandDdosEventWithOptions(request, runtime);
        }

        public async Task<DescribeOnDemandDdosEventResponse> DescribeOnDemandDdosEventAsync(DescribeOnDemandDdosEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOnDemandDdosEventWithOptionsAsync(request, runtime);
        }

        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagKeysResponse>(DoRequest("ListTagKeys", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagKeysResponse>(await DoRequestAsync("ListTagKeys", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
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

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRequest("ListTagResources", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRequestAsync("ListTagResources", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
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

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UntagResourcesResponse>(DoRequest("UntagResources", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRequestAsync("UntagResources", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
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
            return TeaModel.ToObject<TagResourcesResponse>(DoRequest("TagResources", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TagResourcesResponse>(await DoRequestAsync("TagResources", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
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

        public DescribeExcpetionCountResponse DescribeExcpetionCountWithOptions(DescribeExcpetionCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeExcpetionCountResponse>(DoRequest("DescribeExcpetionCount", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeExcpetionCountResponse> DescribeExcpetionCountWithOptionsAsync(DescribeExcpetionCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeExcpetionCountResponse>(await DoRequestAsync("DescribeExcpetionCount", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeExcpetionCountResponse DescribeExcpetionCount(DescribeExcpetionCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExcpetionCountWithOptions(request, runtime);
        }

        public async Task<DescribeExcpetionCountResponse> DescribeExcpetionCountAsync(DescribeExcpetionCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExcpetionCountWithOptionsAsync(request, runtime);
        }

        public DescribePackIpListResponse DescribePackIpListWithOptions(DescribePackIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePackIpListResponse>(DoRequest("DescribePackIpList", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribePackIpListResponse> DescribePackIpListWithOptionsAsync(DescribePackIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePackIpListResponse>(await DoRequestAsync("DescribePackIpList", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribePackIpListResponse DescribePackIpList(DescribePackIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePackIpListWithOptions(request, runtime);
        }

        public async Task<DescribePackIpListResponse> DescribePackIpListAsync(DescribePackIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePackIpListWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRequest("DescribeRegions", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRequestAsync("DescribeRegions", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
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

        public ModifyRemarkResponse ModifyRemarkWithOptions(ModifyRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyRemarkResponse>(DoRequest("ModifyRemark", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyRemarkResponse> ModifyRemarkWithOptionsAsync(ModifyRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyRemarkResponse>(await DoRequestAsync("ModifyRemark", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public ModifyRemarkResponse ModifyRemark(ModifyRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRemarkWithOptions(request, runtime);
        }

        public async Task<ModifyRemarkResponse> ModifyRemarkAsync(ModifyRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRemarkWithOptionsAsync(request, runtime);
        }

        public DescribeTrafficResponse DescribeTrafficWithOptions(DescribeTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeTrafficResponse>(DoRequest("DescribeTraffic", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeTrafficResponse> DescribeTrafficWithOptionsAsync(DescribeTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeTrafficResponse>(await DoRequestAsync("DescribeTraffic", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeTrafficResponse DescribeTraffic(DescribeTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrafficWithOptions(request, runtime);
        }

        public async Task<DescribeTrafficResponse> DescribeTrafficAsync(DescribeTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrafficWithOptionsAsync(request, runtime);
        }

        public DescribeResourcePackUsageResponse DescribeResourcePackUsageWithOptions(DescribeResourcePackUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeResourcePackUsageResponse>(DoRequest("DescribeResourcePackUsage", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeResourcePackUsageResponse> DescribeResourcePackUsageWithOptionsAsync(DescribeResourcePackUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeResourcePackUsageResponse>(await DoRequestAsync("DescribeResourcePackUsage", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeResourcePackUsageResponse DescribeResourcePackUsage(DescribeResourcePackUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourcePackUsageWithOptions(request, runtime);
        }

        public async Task<DescribeResourcePackUsageResponse> DescribeResourcePackUsageAsync(DescribeResourcePackUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourcePackUsageWithOptionsAsync(request, runtime);
        }

        public DescribeResourcePackStatisticsResponse DescribeResourcePackStatisticsWithOptions(DescribeResourcePackStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeResourcePackStatisticsResponse>(DoRequest("DescribeResourcePackStatistics", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeResourcePackStatisticsResponse> DescribeResourcePackStatisticsWithOptionsAsync(DescribeResourcePackStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeResourcePackStatisticsResponse>(await DoRequestAsync("DescribeResourcePackStatistics", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeResourcePackStatisticsResponse DescribeResourcePackStatistics(DescribeResourcePackStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourcePackStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeResourcePackStatisticsResponse> DescribeResourcePackStatisticsAsync(DescribeResourcePackStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourcePackStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeResourcePackInstancesResponse DescribeResourcePackInstancesWithOptions(DescribeResourcePackInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeResourcePackInstancesResponse>(DoRequest("DescribeResourcePackInstances", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeResourcePackInstancesResponse> DescribeResourcePackInstancesWithOptionsAsync(DescribeResourcePackInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeResourcePackInstancesResponse>(await DoRequestAsync("DescribeResourcePackInstances", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeResourcePackInstancesResponse DescribeResourcePackInstances(DescribeResourcePackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourcePackInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeResourcePackInstancesResponse> DescribeResourcePackInstancesAsync(DescribeResourcePackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourcePackInstancesWithOptionsAsync(request, runtime);
        }

        public DescribePackPaidTrafficResponse DescribePackPaidTrafficWithOptions(DescribePackPaidTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePackPaidTrafficResponse>(DoRequest("DescribePackPaidTraffic", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribePackPaidTrafficResponse> DescribePackPaidTrafficWithOptionsAsync(DescribePackPaidTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePackPaidTrafficResponse>(await DoRequestAsync("DescribePackPaidTraffic", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribePackPaidTrafficResponse DescribePackPaidTraffic(DescribePackPaidTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePackPaidTrafficWithOptions(request, runtime);
        }

        public async Task<DescribePackPaidTrafficResponse> DescribePackPaidTrafficAsync(DescribePackPaidTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePackPaidTrafficWithOptionsAsync(request, runtime);
        }

        public DescribeOpEntitiesResponse DescribeOpEntitiesWithOptions(DescribeOpEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOpEntitiesResponse>(DoRequest("DescribeOpEntities", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeOpEntitiesResponse> DescribeOpEntitiesWithOptionsAsync(DescribeOpEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOpEntitiesResponse>(await DoRequestAsync("DescribeOpEntities", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
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

        public DescribeInstanceSpecsResponse DescribeInstanceSpecsWithOptions(DescribeInstanceSpecsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceSpecsResponse>(DoRequest("DescribeInstanceSpecs", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstanceSpecsResponse> DescribeInstanceSpecsWithOptionsAsync(DescribeInstanceSpecsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceSpecsResponse>(await DoRequestAsync("DescribeInstanceSpecs", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
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

        public DescribeInstanceListResponse DescribeInstanceListWithOptions(DescribeInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceListResponse>(DoRequest("DescribeInstanceList", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstanceListResponse> DescribeInstanceListWithOptionsAsync(DescribeInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceListResponse>(await DoRequestAsync("DescribeInstanceList", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInstanceListResponse DescribeInstanceList(DescribeInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceListWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceListResponse> DescribeInstanceListAsync(DescribeInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceListWithOptionsAsync(request, runtime);
        }

        public DescribeDdosEventResponse DescribeDdosEventWithOptions(DescribeDdosEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDdosEventResponse>(DoRequest("DescribeDdosEvent", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDdosEventResponse> DescribeDdosEventWithOptionsAsync(DescribeDdosEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDdosEventResponse>(await DoRequestAsync("DescribeDdosEvent", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDdosEventResponse DescribeDdosEvent(DescribeDdosEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosEventWithOptions(request, runtime);
        }

        public async Task<DescribeDdosEventResponse> DescribeDdosEventAsync(DescribeDdosEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosEventWithOptionsAsync(request, runtime);
        }

        public DeleteIpResponse DeleteIpWithOptions(DeleteIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteIpResponse>(DoRequest("DeleteIp", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteIpResponse> DeleteIpWithOptionsAsync(DeleteIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteIpResponse>(await DoRequestAsync("DeleteIp", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteIpResponse DeleteIp(DeleteIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpWithOptions(request, runtime);
        }

        public async Task<DeleteIpResponse> DeleteIpAsync(DeleteIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpWithOptionsAsync(request, runtime);
        }

        public DeleteBlackholeResponse DeleteBlackholeWithOptions(DeleteBlackholeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteBlackholeResponse>(DoRequest("DeleteBlackhole", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteBlackholeResponse> DeleteBlackholeWithOptionsAsync(DeleteBlackholeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteBlackholeResponse>(await DoRequestAsync("DeleteBlackhole", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteBlackholeResponse DeleteBlackhole(DeleteBlackholeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBlackholeWithOptions(request, runtime);
        }

        public async Task<DeleteBlackholeResponse> DeleteBlackholeAsync(DeleteBlackholeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBlackholeWithOptionsAsync(request, runtime);
        }

        public CheckGrantResponse CheckGrantWithOptions(CheckGrantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckGrantResponse>(DoRequest("CheckGrant", "HTTPS", "GET", "2018-07-20", "AK", request.ToMap(), null, runtime));
        }

        public async Task<CheckGrantResponse> CheckGrantWithOptionsAsync(CheckGrantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckGrantResponse>(await DoRequestAsync("CheckGrant", "HTTPS", "GET", "2018-07-20", "AK", request.ToMap(), null, runtime));
        }

        public CheckGrantResponse CheckGrant(CheckGrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckGrantWithOptions(request, runtime);
        }

        public async Task<CheckGrantResponse> CheckGrantAsync(CheckGrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckGrantWithOptionsAsync(request, runtime);
        }

        public AddIpResponse AddIpWithOptions(AddIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddIpResponse>(DoRequest("AddIp", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddIpResponse> AddIpWithOptionsAsync(AddIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddIpResponse>(await DoRequestAsync("AddIp", "HTTPS", "POST", "2018-07-20", "AK", null, request.ToMap(), runtime));
        }

        public AddIpResponse AddIp(AddIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddIpWithOptions(request, runtime);
        }

        public async Task<AddIpResponse> AddIpAsync(AddIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddIpWithOptionsAsync(request, runtime);
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
