// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eais20190624.Models;

namespace AlibabaCloud.SDK.Eais20190624
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "eais.aliyuncs.com"},
                {"ap-northeast-2-pop", "eais.aliyuncs.com"},
                {"ap-south-1", "eais.aliyuncs.com"},
                {"ap-southeast-1", "eais.aliyuncs.com"},
                {"ap-southeast-2", "eais.aliyuncs.com"},
                {"ap-southeast-3", "eais.aliyuncs.com"},
                {"ap-southeast-5", "eais.aliyuncs.com"},
                {"cn-beijing-finance-1", "eais.aliyuncs.com"},
                {"cn-beijing-finance-pop", "eais.aliyuncs.com"},
                {"cn-beijing-gov-1", "eais.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "eais.aliyuncs.com"},
                {"cn-edge-1", "eais.aliyuncs.com"},
                {"cn-fujian", "eais.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "eais.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "eais.aliyuncs.com"},
                {"cn-hangzhou-finance", "eais.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "eais.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "eais.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "eais.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "eais.aliyuncs.com"},
                {"cn-hangzhou-test-306", "eais.aliyuncs.com"},
                {"cn-hongkong", "eais.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "eais.aliyuncs.com"},
                {"cn-huhehaote", "eais.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "eais.aliyuncs.com"},
                {"cn-north-2-gov-1", "eais.aliyuncs.com"},
                {"cn-qingdao", "eais.aliyuncs.com"},
                {"cn-qingdao-nebula", "eais.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "eais.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "eais.aliyuncs.com"},
                {"cn-shanghai-finance-1", "eais.aliyuncs.com"},
                {"cn-shanghai-inner", "eais.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "eais.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "eais.aliyuncs.com"},
                {"cn-shenzhen-inner", "eais.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "eais.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "eais.aliyuncs.com"},
                {"cn-wuhan", "eais.aliyuncs.com"},
                {"cn-wulanchabu", "eais.aliyuncs.com"},
                {"cn-yushanfang", "eais.aliyuncs.com"},
                {"cn-zhangbei", "eais.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "eais.aliyuncs.com"},
                {"cn-zhangjiakou", "eais.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "eais.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "eais.aliyuncs.com"},
                {"eu-central-1", "eais.aliyuncs.com"},
                {"eu-west-1", "eais.aliyuncs.com"},
                {"eu-west-1-oxs", "eais.aliyuncs.com"},
                {"me-east-1", "eais.aliyuncs.com"},
                {"rus-west-1-pop", "eais.aliyuncs.com"},
                {"us-east-1", "eais.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("eais", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AttachEaiResponse AttachEaiWithOptions(AttachEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachEaiResponse>(DoRPCRequest("AttachEai", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachEaiResponse> AttachEaiWithOptionsAsync(AttachEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachEaiResponse>(await DoRPCRequestAsync("AttachEai", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachEaiResponse AttachEai(AttachEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachEaiWithOptions(request, runtime);
        }

        public async Task<AttachEaiResponse> AttachEaiAsync(AttachEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachEaiWithOptionsAsync(request, runtime);
        }

        public CreateEaiResponse CreateEaiWithOptions(CreateEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEaiResponse>(DoRPCRequest("CreateEai", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEaiResponse> CreateEaiWithOptionsAsync(CreateEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEaiResponse>(await DoRPCRequestAsync("CreateEai", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEaiResponse CreateEai(CreateEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEaiWithOptions(request, runtime);
        }

        public async Task<CreateEaiResponse> CreateEaiAsync(CreateEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEaiWithOptionsAsync(request, runtime);
        }

        public CreateEaiAllResponse CreateEaiAllWithOptions(CreateEaiAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEaiAllResponse>(DoRPCRequest("CreateEaiAll", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEaiAllResponse> CreateEaiAllWithOptionsAsync(CreateEaiAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEaiAllResponse>(await DoRPCRequestAsync("CreateEaiAll", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEaiAllResponse CreateEaiAll(CreateEaiAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEaiAllWithOptions(request, runtime);
        }

        public async Task<CreateEaiAllResponse> CreateEaiAllAsync(CreateEaiAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEaiAllWithOptionsAsync(request, runtime);
        }

        public DeleteEaiResponse DeleteEaiWithOptions(DeleteEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEaiResponse>(DoRPCRequest("DeleteEai", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEaiResponse> DeleteEaiWithOptionsAsync(DeleteEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEaiResponse>(await DoRPCRequestAsync("DeleteEai", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEaiResponse DeleteEai(DeleteEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEaiWithOptions(request, runtime);
        }

        public async Task<DeleteEaiResponse> DeleteEaiAsync(DeleteEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEaiWithOptionsAsync(request, runtime);
        }

        public DeleteEaiAllResponse DeleteEaiAllWithOptions(DeleteEaiAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEaiAllResponse>(DoRPCRequest("DeleteEaiAll", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEaiAllResponse> DeleteEaiAllWithOptionsAsync(DeleteEaiAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEaiAllResponse>(await DoRPCRequestAsync("DeleteEaiAll", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEaiAllResponse DeleteEaiAll(DeleteEaiAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEaiAllWithOptions(request, runtime);
        }

        public async Task<DeleteEaiAllResponse> DeleteEaiAllAsync(DeleteEaiAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEaiAllWithOptionsAsync(request, runtime);
        }

        public DescribeEaisResponse DescribeEaisWithOptions(DescribeEaisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEaisResponse>(DoRPCRequest("DescribeEais", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEaisResponse> DescribeEaisWithOptionsAsync(DescribeEaisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEaisResponse>(await DoRPCRequestAsync("DescribeEais", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEaisResponse DescribeEais(DescribeEaisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEaisWithOptions(request, runtime);
        }

        public async Task<DescribeEaisResponse> DescribeEaisAsync(DescribeEaisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEaisWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        public DetachEaiResponse DetachEaiWithOptions(DetachEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachEaiResponse>(DoRPCRequest("DetachEai", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachEaiResponse> DetachEaiWithOptionsAsync(DetachEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachEaiResponse>(await DoRPCRequestAsync("DetachEai", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachEaiResponse DetachEai(DetachEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachEaiWithOptions(request, runtime);
        }

        public async Task<DetachEaiResponse> DetachEaiAsync(DetachEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachEaiWithOptionsAsync(request, runtime);
        }

        public GetPrivateIpResponse GetPrivateIpWithOptions(GetPrivateIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPrivateIpResponse>(DoRPCRequest("GetPrivateIp", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPrivateIpResponse> GetPrivateIpWithOptionsAsync(GetPrivateIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPrivateIpResponse>(await DoRPCRequestAsync("GetPrivateIp", "2019-06-24", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPrivateIpResponse GetPrivateIp(GetPrivateIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPrivateIpWithOptions(request, runtime);
        }

        public async Task<GetPrivateIpResponse> GetPrivateIpAsync(GetPrivateIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPrivateIpWithOptionsAsync(request, runtime);
        }

    }
}
