// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cas20180713.Models;

namespace AlibabaCloud.SDK.Cas20180713
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "cas.aliyuncs.com"},
                {"ap-northeast-2-pop", "cas.aliyuncs.com"},
                {"ap-southeast-1", "cas.aliyuncs.com"},
                {"ap-southeast-3", "cas.aliyuncs.com"},
                {"ap-southeast-5", "cas.aliyuncs.com"},
                {"cn-beijing", "cas.aliyuncs.com"},
                {"cn-beijing-finance-1", "cas.aliyuncs.com"},
                {"cn-beijing-finance-pop", "cas.aliyuncs.com"},
                {"cn-beijing-gov-1", "cas.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "cas.aliyuncs.com"},
                {"cn-chengdu", "cas.aliyuncs.com"},
                {"cn-edge-1", "cas.aliyuncs.com"},
                {"cn-fujian", "cas.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "cas.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "cas.aliyuncs.com"},
                {"cn-hangzhou-finance", "cas.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "cas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "cas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "cas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "cas.aliyuncs.com"},
                {"cn-hangzhou-test-306", "cas.aliyuncs.com"},
                {"cn-hongkong", "cas.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "cas.aliyuncs.com"},
                {"cn-huhehaote", "cas.aliyuncs.com"},
                {"cn-north-2-gov-1", "cas.aliyuncs.com"},
                {"cn-qingdao", "cas.aliyuncs.com"},
                {"cn-qingdao-nebula", "cas.aliyuncs.com"},
                {"cn-shanghai", "cas.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "cas.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "cas.aliyuncs.com"},
                {"cn-shanghai-finance-1", "cas.aliyuncs.com"},
                {"cn-shanghai-inner", "cas.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "cas.aliyuncs.com"},
                {"cn-shenzhen", "cas.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "cas.aliyuncs.com"},
                {"cn-shenzhen-inner", "cas.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "cas.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "cas.aliyuncs.com"},
                {"cn-wuhan", "cas.aliyuncs.com"},
                {"cn-yushanfang", "cas.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "cas.aliyuncs.com"},
                {"cn-zhangjiakou", "cas.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "cas.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "cas.aliyuncs.com"},
                {"eu-west-1", "cas.aliyuncs.com"},
                {"eu-west-1-oxs", "cas.aliyuncs.com"},
                {"rus-west-1-pop", "cas.aliyuncs.com"},
                {"us-east-1", "cas.aliyuncs.com"},
                {"us-west-1", "cas.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("cas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateDVOrderAuditResponse CreateDVOrderAuditWithOptions(CreateDVOrderAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDVOrderAuditResponse>(DoRPCRequest("CreateDVOrderAudit", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDVOrderAuditResponse> CreateDVOrderAuditWithOptionsAsync(CreateDVOrderAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDVOrderAuditResponse>(await DoRPCRequestAsync("CreateDVOrderAudit", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDVOrderAuditResponse CreateDVOrderAudit(CreateDVOrderAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDVOrderAuditWithOptions(request, runtime);
        }

        public async Task<CreateDVOrderAuditResponse> CreateDVOrderAuditAsync(CreateDVOrderAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDVOrderAuditWithOptionsAsync(request, runtime);
        }

        public CreateUserCertificateResponse CreateUserCertificateWithOptions(CreateUserCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserCertificateResponse>(DoRPCRequest("CreateUserCertificate", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUserCertificateResponse> CreateUserCertificateWithOptionsAsync(CreateUserCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserCertificateResponse>(await DoRPCRequestAsync("CreateUserCertificate", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUserCertificateResponse CreateUserCertificate(CreateUserCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserCertificateWithOptions(request, runtime);
        }

        public async Task<CreateUserCertificateResponse> CreateUserCertificateAsync(CreateUserCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserCertificateWithOptionsAsync(request, runtime);
        }

        public DeleteUserCertificateResponse DeleteUserCertificateWithOptions(DeleteUserCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserCertificateResponse>(DoRPCRequest("DeleteUserCertificate", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserCertificateResponse> DeleteUserCertificateWithOptionsAsync(DeleteUserCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserCertificateResponse>(await DoRPCRequestAsync("DeleteUserCertificate", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUserCertificateResponse DeleteUserCertificate(DeleteUserCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserCertificateWithOptions(request, runtime);
        }

        public async Task<DeleteUserCertificateResponse> DeleteUserCertificateAsync(DeleteUserCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserCertificateWithOptionsAsync(request, runtime);
        }

        public DescribeDVOrderResultResponse DescribeDVOrderResultWithOptions(DescribeDVOrderResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDVOrderResultResponse>(DoRPCRequest("DescribeDVOrderResult", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDVOrderResultResponse> DescribeDVOrderResultWithOptionsAsync(DescribeDVOrderResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDVOrderResultResponse>(await DoRPCRequestAsync("DescribeDVOrderResult", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDVOrderResultResponse DescribeDVOrderResult(DescribeDVOrderResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDVOrderResultWithOptions(request, runtime);
        }

        public async Task<DescribeDVOrderResultResponse> DescribeDVOrderResultAsync(DescribeDVOrderResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDVOrderResultWithOptionsAsync(request, runtime);
        }

        public DescribeOrderInstanceListResponse DescribeOrderInstanceListWithOptions(DescribeOrderInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOrderInstanceListResponse>(DoRPCRequest("DescribeOrderInstanceList", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeOrderInstanceListResponse> DescribeOrderInstanceListWithOptionsAsync(DescribeOrderInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOrderInstanceListResponse>(await DoRPCRequestAsync("DescribeOrderInstanceList", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeOrderInstanceListResponse DescribeOrderInstanceList(DescribeOrderInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOrderInstanceListWithOptions(request, runtime);
        }

        public async Task<DescribeOrderInstanceListResponse> DescribeOrderInstanceListAsync(DescribeOrderInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOrderInstanceListWithOptionsAsync(request, runtime);
        }

        public DescribeUserCertificateDetailResponse DescribeUserCertificateDetailWithOptions(DescribeUserCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserCertificateDetailResponse>(DoRPCRequest("DescribeUserCertificateDetail", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserCertificateDetailResponse> DescribeUserCertificateDetailWithOptionsAsync(DescribeUserCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserCertificateDetailResponse>(await DoRPCRequestAsync("DescribeUserCertificateDetail", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserCertificateDetailResponse DescribeUserCertificateDetail(DescribeUserCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserCertificateDetailWithOptions(request, runtime);
        }

        public async Task<DescribeUserCertificateDetailResponse> DescribeUserCertificateDetailAsync(DescribeUserCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserCertificateDetailWithOptionsAsync(request, runtime);
        }

        public DescribeUserCertificateListResponse DescribeUserCertificateListWithOptions(DescribeUserCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserCertificateListResponse>(DoRPCRequest("DescribeUserCertificateList", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserCertificateListResponse> DescribeUserCertificateListWithOptionsAsync(DescribeUserCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserCertificateListResponse>(await DoRPCRequestAsync("DescribeUserCertificateList", "2018-07-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserCertificateListResponse DescribeUserCertificateList(DescribeUserCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserCertificateListWithOptions(request, runtime);
        }

        public async Task<DescribeUserCertificateListResponse> DescribeUserCertificateListAsync(DescribeUserCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserCertificateListWithOptionsAsync(request, runtime);
        }

    }
}
