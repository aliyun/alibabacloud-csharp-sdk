// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Hitsdb20200615.Models;

namespace AlibabaCloud.SDK.Hitsdb20200615
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "hitsdb.aliyuncs.com"},
                {"cn-beijing", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou", "hitsdb.aliyuncs.com"},
                {"cn-shanghai", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen", "hitsdb.aliyuncs.com"},
                {"cn-hongkong", "hitsdb.aliyuncs.com"},
                {"ap-southeast-1", "hitsdb.aliyuncs.com"},
                {"us-west-1", "hitsdb.aliyuncs.com"},
                {"us-east-1", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-finance-1", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "hitsdb.aliyuncs.com"},
                {"ap-northeast-2-pop", "hitsdb.aliyuncs.com"},
                {"cn-beijing-finance-1", "hitsdb.aliyuncs.com"},
                {"cn-beijing-finance-pop", "hitsdb.aliyuncs.com"},
                {"cn-beijing-gov-1", "hitsdb.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "hitsdb.aliyuncs.com"},
                {"cn-chengdu", "hitsdb.aliyuncs.com"},
                {"cn-edge-1", "hitsdb.aliyuncs.com"},
                {"cn-fujian", "hitsdb.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-finance", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-test-306", "hitsdb.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "hitsdb.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "hitsdb.aliyuncs.com"},
                {"cn-qingdao-nebula", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-inner", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen-inner", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "hitsdb.aliyuncs.com"},
                {"cn-wuhan", "hitsdb.aliyuncs.com"},
                {"cn-wulanchabu", "hitsdb.aliyuncs.com"},
                {"cn-yushanfang", "hitsdb.aliyuncs.com"},
                {"cn-zhangbei", "hitsdb.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "hitsdb.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "hitsdb.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "hitsdb.aliyuncs.com"},
                {"eu-west-1-oxs", "hitsdb.aliyuncs.com"},
                {"me-east-1", "hitsdb.aliyuncs.com"},
                {"rus-west-1-pop", "hitsdb.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("hitsdb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2020-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2020-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetInstanceIpWhiteListResponse GetInstanceIpWhiteListWithOptions(GetInstanceIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceIpWhiteListResponse>(DoRPCRequest("GetInstanceIpWhiteList", "2020-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceIpWhiteListResponse> GetInstanceIpWhiteListWithOptionsAsync(GetInstanceIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceIpWhiteListResponse>(await DoRPCRequestAsync("GetInstanceIpWhiteList", "2020-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceIpWhiteListResponse GetInstanceIpWhiteList(GetInstanceIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceIpWhiteListWithOptions(request, runtime);
        }

        public async Task<GetInstanceIpWhiteListResponse> GetInstanceIpWhiteListAsync(GetInstanceIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceIpWhiteListWithOptionsAsync(request, runtime);
        }

        public GetLindormInstanceResponse GetLindormInstanceWithOptions(GetLindormInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLindormInstanceResponse>(DoRPCRequest("GetLindormInstance", "2020-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLindormInstanceResponse> GetLindormInstanceWithOptionsAsync(GetLindormInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLindormInstanceResponse>(await DoRPCRequestAsync("GetLindormInstance", "2020-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLindormInstanceResponse GetLindormInstance(GetLindormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLindormInstanceWithOptions(request, runtime);
        }

        public async Task<GetLindormInstanceResponse> GetLindormInstanceAsync(GetLindormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLindormInstanceWithOptionsAsync(request, runtime);
        }

        public GetLindormInstanceEngineListResponse GetLindormInstanceEngineListWithOptions(GetLindormInstanceEngineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLindormInstanceEngineListResponse>(DoRPCRequest("GetLindormInstanceEngineList", "2020-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLindormInstanceEngineListResponse> GetLindormInstanceEngineListWithOptionsAsync(GetLindormInstanceEngineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLindormInstanceEngineListResponse>(await DoRPCRequestAsync("GetLindormInstanceEngineList", "2020-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLindormInstanceEngineListResponse GetLindormInstanceEngineList(GetLindormInstanceEngineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLindormInstanceEngineListWithOptions(request, runtime);
        }

        public async Task<GetLindormInstanceEngineListResponse> GetLindormInstanceEngineListAsync(GetLindormInstanceEngineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLindormInstanceEngineListWithOptionsAsync(request, runtime);
        }

        public GetLindormInstanceListResponse GetLindormInstanceListWithOptions(GetLindormInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLindormInstanceListResponse>(DoRPCRequest("GetLindormInstanceList", "2020-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLindormInstanceListResponse> GetLindormInstanceListWithOptionsAsync(GetLindormInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLindormInstanceListResponse>(await DoRPCRequestAsync("GetLindormInstanceList", "2020-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLindormInstanceListResponse GetLindormInstanceList(GetLindormInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLindormInstanceListWithOptions(request, runtime);
        }

        public async Task<GetLindormInstanceListResponse> GetLindormInstanceListAsync(GetLindormInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLindormInstanceListWithOptionsAsync(request, runtime);
        }

        public UpdateInstanceIpWhiteListResponse UpdateInstanceIpWhiteListWithOptions(UpdateInstanceIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateInstanceIpWhiteListResponse>(DoRPCRequest("UpdateInstanceIpWhiteList", "2020-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateInstanceIpWhiteListResponse> UpdateInstanceIpWhiteListWithOptionsAsync(UpdateInstanceIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateInstanceIpWhiteListResponse>(await DoRPCRequestAsync("UpdateInstanceIpWhiteList", "2020-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateInstanceIpWhiteListResponse UpdateInstanceIpWhiteList(UpdateInstanceIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceIpWhiteListWithOptions(request, runtime);
        }

        public async Task<UpdateInstanceIpWhiteListResponse> UpdateInstanceIpWhiteListAsync(UpdateInstanceIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceIpWhiteListWithOptionsAsync(request, runtime);
        }

    }
}
