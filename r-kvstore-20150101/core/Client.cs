// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.R_kvstore20150101.Models;

namespace AlibabaCloud.SDK.R_kvstore20150101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "r-kvstore.aliyuncs.com"},
                {"cn-beijing", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou", "r-kvstore.aliyuncs.com"},
                {"cn-shanghai", "r-kvstore.aliyuncs.com"},
                {"cn-shenzhen", "r-kvstore.aliyuncs.com"},
                {"cn-heyuan", "r-kvstore.aliyuncs.com"},
                {"ap-southeast-1", "r-kvstore.aliyuncs.com"},
                {"us-west-1", "r-kvstore.aliyuncs.com"},
                {"us-east-1", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-finance", "r-kvstore.aliyuncs.com"},
                {"cn-shanghai-finance-1", "r-kvstore.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "r-kvstore.aliyuncs.com"},
                {"cn-north-2-gov-1", "r-kvstore.aliyuncs.com"},
                {"ap-northeast-2-pop", "r-kvstore.aliyuncs.com"},
                {"cn-beijing-finance-1", "r-kvstore.aliyuncs.com"},
                {"cn-beijing-finance-pop", "r-kvstore.aliyuncs.com"},
                {"cn-beijing-gov-1", "r-kvstore.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "r-kvstore.aliyuncs.com"},
                {"cn-edge-1", "r-kvstore.aliyuncs.com"},
                {"cn-fujian", "r-kvstore.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-test-306", "r-kvstore.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "r-kvstore.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "r-kvstore.aliyuncs.com"},
                {"cn-qingdao-nebula", "r-kvstore.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "r-kvstore.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "r-kvstore.aliyuncs.com"},
                {"cn-shanghai-inner", "r-kvstore.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "r-kvstore.aliyuncs.com"},
                {"cn-shenzhen-inner", "r-kvstore.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "r-kvstore.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "r-kvstore.aliyuncs.com"},
                {"cn-wuhan", "r-kvstore.aliyuncs.com"},
                {"cn-wulanchabu", "r-kvstore.aliyuncs.com"},
                {"cn-yushanfang", "r-kvstore.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "r-kvstore.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "r-kvstore.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "r-kvstore.aliyuncs.com"},
                {"eu-west-1-oxs", "r-kvstore.aliyuncs.com"},
                {"rus-west-1-pop", "r-kvstore.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("r-kvstore", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateCacheAnalysisTaskResponse CreateCacheAnalysisTaskWithOptions(CreateCacheAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCacheAnalysisTaskResponse>(DoRPCRequest("CreateCacheAnalysisTask", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCacheAnalysisTaskResponse> CreateCacheAnalysisTaskWithOptionsAsync(CreateCacheAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCacheAnalysisTaskResponse>(await DoRPCRequestAsync("CreateCacheAnalysisTask", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCacheAnalysisTaskResponse CreateCacheAnalysisTask(CreateCacheAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCacheAnalysisTaskWithOptions(request, runtime);
        }

        public async Task<CreateCacheAnalysisTaskResponse> CreateCacheAnalysisTaskAsync(CreateCacheAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCacheAnalysisTaskWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedClusterInstanceListResponse DescribeDedicatedClusterInstanceListWithOptions(DescribeDedicatedClusterInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedClusterInstanceListResponse>(DoRPCRequest("DescribeDedicatedClusterInstanceList", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedClusterInstanceListResponse> DescribeDedicatedClusterInstanceListWithOptionsAsync(DescribeDedicatedClusterInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedClusterInstanceListResponse>(await DoRPCRequestAsync("DescribeDedicatedClusterInstanceList", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedClusterInstanceListResponse DescribeDedicatedClusterInstanceList(DescribeDedicatedClusterInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedClusterInstanceListWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedClusterInstanceListResponse> DescribeDedicatedClusterInstanceListAsync(DescribeDedicatedClusterInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedClusterInstanceListWithOptionsAsync(request, runtime);
        }

        public DescribeRoleZoneInfoResponse DescribeRoleZoneInfoWithOptions(DescribeRoleZoneInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRoleZoneInfoResponse>(DoRPCRequest("DescribeRoleZoneInfo", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRoleZoneInfoResponse> DescribeRoleZoneInfoWithOptionsAsync(DescribeRoleZoneInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRoleZoneInfoResponse>(await DoRPCRequestAsync("DescribeRoleZoneInfo", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRoleZoneInfoResponse DescribeRoleZoneInfo(DescribeRoleZoneInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRoleZoneInfoWithOptions(request, runtime);
        }

        public async Task<DescribeRoleZoneInfoResponse> DescribeRoleZoneInfoAsync(DescribeRoleZoneInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRoleZoneInfoWithOptionsAsync(request, runtime);
        }

    }
}
