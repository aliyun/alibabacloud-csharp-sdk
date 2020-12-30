// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Waf_openapi20190910.Models;

namespace AlibabaCloud.SDK.Waf_openapi20190910
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-beijing", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-chengdu", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-zhangjiakou", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-huhehaote", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-heyuan", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-wulanchabu", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-hongkong", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"eu-central-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"cn-shanghai-finance-1", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-north-2-gov-1", "wafopenapi.cn-hangzhou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("waf-openapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateCertificateResponse CreateCertificateWithOptions(CreateCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCertificateResponse>(DoRPCRequest("CreateCertificate", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCertificateResponse> CreateCertificateWithOptionsAsync(CreateCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCertificateResponse>(await DoRPCRequestAsync("CreateCertificate", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCertificateResponse CreateCertificate(CreateCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCertificateWithOptions(request, runtime);
        }

        public async Task<CreateCertificateResponse> CreateCertificateAsync(CreateCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCertificateWithOptionsAsync(request, runtime);
        }

        public CreateCertificateByCertificateIdResponse CreateCertificateByCertificateIdWithOptions(CreateCertificateByCertificateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCertificateByCertificateIdResponse>(DoRPCRequest("CreateCertificateByCertificateId", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCertificateByCertificateIdResponse> CreateCertificateByCertificateIdWithOptionsAsync(CreateCertificateByCertificateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCertificateByCertificateIdResponse>(await DoRPCRequestAsync("CreateCertificateByCertificateId", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCertificateByCertificateIdResponse CreateCertificateByCertificateId(CreateCertificateByCertificateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCertificateByCertificateIdWithOptions(request, runtime);
        }

        public async Task<CreateCertificateByCertificateIdResponse> CreateCertificateByCertificateIdAsync(CreateCertificateByCertificateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCertificateByCertificateIdWithOptionsAsync(request, runtime);
        }

        public CreateDomainResponse CreateDomainWithOptions(CreateDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDomainResponse>(DoRPCRequest("CreateDomain", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDomainResponse> CreateDomainWithOptionsAsync(CreateDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDomainResponse>(await DoRPCRequestAsync("CreateDomain", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDomainWithOptions(request, runtime);
        }

        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDomainWithOptionsAsync(request, runtime);
        }

        public CreateProtectionModuleRuleResponse CreateProtectionModuleRuleWithOptions(CreateProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProtectionModuleRuleResponse>(DoRPCRequest("CreateProtectionModuleRule", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProtectionModuleRuleResponse> CreateProtectionModuleRuleWithOptionsAsync(CreateProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProtectionModuleRuleResponse>(await DoRPCRequestAsync("CreateProtectionModuleRule", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateProtectionModuleRuleResponse CreateProtectionModuleRule(CreateProtectionModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProtectionModuleRuleWithOptions(request, runtime);
        }

        public async Task<CreateProtectionModuleRuleResponse> CreateProtectionModuleRuleAsync(CreateProtectionModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProtectionModuleRuleWithOptionsAsync(request, runtime);
        }

        public DeleteDomainResponse DeleteDomainWithOptions(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainResponse>(DoRPCRequest("DeleteDomain", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await DoRPCRequestAsync("DeleteDomain", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainWithOptions(request, runtime);
        }

        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainWithOptionsAsync(request, runtime);
        }

        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(DoRPCRequest("DeleteInstance", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoRPCRequestAsync("DeleteInstance", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteProtectionModuleRuleResponse DeleteProtectionModuleRuleWithOptions(DeleteProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProtectionModuleRuleResponse>(DoRPCRequest("DeleteProtectionModuleRule", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProtectionModuleRuleResponse> DeleteProtectionModuleRuleWithOptionsAsync(DeleteProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProtectionModuleRuleResponse>(await DoRPCRequestAsync("DeleteProtectionModuleRule", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteProtectionModuleRuleResponse DeleteProtectionModuleRule(DeleteProtectionModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProtectionModuleRuleWithOptions(request, runtime);
        }

        public async Task<DeleteProtectionModuleRuleResponse> DeleteProtectionModuleRuleAsync(DeleteProtectionModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProtectionModuleRuleWithOptionsAsync(request, runtime);
        }

        public DescribeCertificatesResponse DescribeCertificatesWithOptions(DescribeCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCertificatesResponse>(DoRPCRequest("DescribeCertificates", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCertificatesResponse> DescribeCertificatesWithOptionsAsync(DescribeCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCertificatesResponse>(await DoRPCRequestAsync("DescribeCertificates", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCertificatesResponse DescribeCertificates(DescribeCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertificatesWithOptions(request, runtime);
        }

        public async Task<DescribeCertificatesResponse> DescribeCertificatesAsync(DescribeCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertificatesWithOptionsAsync(request, runtime);
        }

        public DescribeCertMatchStatusResponse DescribeCertMatchStatusWithOptions(DescribeCertMatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCertMatchStatusResponse>(DoRPCRequest("DescribeCertMatchStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCertMatchStatusResponse> DescribeCertMatchStatusWithOptionsAsync(DescribeCertMatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCertMatchStatusResponse>(await DoRPCRequestAsync("DescribeCertMatchStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCertMatchStatusResponse DescribeCertMatchStatus(DescribeCertMatchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertMatchStatusWithOptions(request, runtime);
        }

        public async Task<DescribeCertMatchStatusResponse> DescribeCertMatchStatusAsync(DescribeCertMatchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertMatchStatusWithOptionsAsync(request, runtime);
        }

        public DescribeDomainResponse DescribeDomainWithOptions(DescribeDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainResponse>(DoRPCRequest("DescribeDomain", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainResponse> DescribeDomainWithOptionsAsync(DescribeDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainResponse>(await DoRPCRequestAsync("DescribeDomain", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainWithOptions(request, runtime);
        }

        public async Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainWithOptionsAsync(request, runtime);
        }

        public DescribeDomainAdvanceConfigsResponse DescribeDomainAdvanceConfigsWithOptions(DescribeDomainAdvanceConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainAdvanceConfigsResponse>(DoRPCRequest("DescribeDomainAdvanceConfigs", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainAdvanceConfigsResponse> DescribeDomainAdvanceConfigsWithOptionsAsync(DescribeDomainAdvanceConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainAdvanceConfigsResponse>(await DoRPCRequestAsync("DescribeDomainAdvanceConfigs", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainAdvanceConfigsResponse DescribeDomainAdvanceConfigs(DescribeDomainAdvanceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainAdvanceConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainAdvanceConfigsResponse> DescribeDomainAdvanceConfigsAsync(DescribeDomainAdvanceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainAdvanceConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeDomainBasicConfigsResponse DescribeDomainBasicConfigsWithOptions(DescribeDomainBasicConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainBasicConfigsResponse>(DoRPCRequest("DescribeDomainBasicConfigs", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainBasicConfigsResponse> DescribeDomainBasicConfigsWithOptionsAsync(DescribeDomainBasicConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainBasicConfigsResponse>(await DoRPCRequestAsync("DescribeDomainBasicConfigs", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainBasicConfigsResponse DescribeDomainBasicConfigs(DescribeDomainBasicConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainBasicConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainBasicConfigsResponse> DescribeDomainBasicConfigsAsync(DescribeDomainBasicConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainBasicConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeDomainNamesResponse DescribeDomainNamesWithOptions(DescribeDomainNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainNamesResponse>(DoRPCRequest("DescribeDomainNames", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainNamesResponse> DescribeDomainNamesWithOptionsAsync(DescribeDomainNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainNamesResponse>(await DoRPCRequestAsync("DescribeDomainNames", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainNamesResponse DescribeDomainNames(DescribeDomainNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainNamesWithOptions(request, runtime);
        }

        public async Task<DescribeDomainNamesResponse> DescribeDomainNamesAsync(DescribeDomainNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainNamesWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRuleGroupResponse DescribeDomainRuleGroupWithOptions(DescribeDomainRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRuleGroupResponse>(DoRPCRequest("DescribeDomainRuleGroup", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRuleGroupResponse> DescribeDomainRuleGroupWithOptionsAsync(DescribeDomainRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRuleGroupResponse>(await DoRPCRequestAsync("DescribeDomainRuleGroup", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainRuleGroupResponse DescribeDomainRuleGroup(DescribeDomainRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRuleGroupWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRuleGroupResponse> DescribeDomainRuleGroupAsync(DescribeDomainRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRuleGroupWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceInfoResponse DescribeInstanceInfoWithOptions(DescribeInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceInfoResponse>(DoRPCRequest("DescribeInstanceInfo", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceInfoResponse> DescribeInstanceInfoWithOptionsAsync(DescribeInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceInfoResponse>(await DoRPCRequestAsync("DescribeInstanceInfo", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceInfoResponse DescribeInstanceInfo(DescribeInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceInfoWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceInfoResponse> DescribeInstanceInfoAsync(DescribeInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceInfoWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceInfosResponse DescribeInstanceInfosWithOptions(DescribeInstanceInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceInfosResponse>(DoRPCRequest("DescribeInstanceInfos", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceInfosResponse> DescribeInstanceInfosWithOptionsAsync(DescribeInstanceInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceInfosResponse>(await DoRPCRequestAsync("DescribeInstanceInfos", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceInfosResponse DescribeInstanceInfos(DescribeInstanceInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceInfosWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceInfosResponse> DescribeInstanceInfosAsync(DescribeInstanceInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceInfosWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceSpecInfoResponse DescribeInstanceSpecInfoWithOptions(DescribeInstanceSpecInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSpecInfoResponse>(DoRPCRequest("DescribeInstanceSpecInfo", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceSpecInfoResponse> DescribeInstanceSpecInfoWithOptionsAsync(DescribeInstanceSpecInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSpecInfoResponse>(await DoRPCRequestAsync("DescribeInstanceSpecInfo", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceSpecInfoResponse DescribeInstanceSpecInfo(DescribeInstanceSpecInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSpecInfoWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceSpecInfoResponse> DescribeInstanceSpecInfoAsync(DescribeInstanceSpecInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSpecInfoWithOptionsAsync(request, runtime);
        }

        public DescribeProtectionModuleModeResponse DescribeProtectionModuleModeWithOptions(DescribeProtectionModuleModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProtectionModuleModeResponse>(DoRPCRequest("DescribeProtectionModuleMode", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeProtectionModuleModeResponse> DescribeProtectionModuleModeWithOptionsAsync(DescribeProtectionModuleModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProtectionModuleModeResponse>(await DoRPCRequestAsync("DescribeProtectionModuleMode", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeProtectionModuleModeResponse DescribeProtectionModuleMode(DescribeProtectionModuleModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProtectionModuleModeWithOptions(request, runtime);
        }

        public async Task<DescribeProtectionModuleModeResponse> DescribeProtectionModuleModeAsync(DescribeProtectionModuleModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProtectionModuleModeWithOptionsAsync(request, runtime);
        }

        public DescribeProtectionModuleRulesResponse DescribeProtectionModuleRulesWithOptions(DescribeProtectionModuleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProtectionModuleRulesResponse>(DoRPCRequest("DescribeProtectionModuleRules", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeProtectionModuleRulesResponse> DescribeProtectionModuleRulesWithOptionsAsync(DescribeProtectionModuleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProtectionModuleRulesResponse>(await DoRPCRequestAsync("DescribeProtectionModuleRules", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeProtectionModuleRulesResponse DescribeProtectionModuleRules(DescribeProtectionModuleRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProtectionModuleRulesWithOptions(request, runtime);
        }

        public async Task<DescribeProtectionModuleRulesResponse> DescribeProtectionModuleRulesAsync(DescribeProtectionModuleRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProtectionModuleRulesWithOptionsAsync(request, runtime);
        }

        public DescribeProtectionModuleStatusResponse DescribeProtectionModuleStatusWithOptions(DescribeProtectionModuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProtectionModuleStatusResponse>(DoRPCRequest("DescribeProtectionModuleStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeProtectionModuleStatusResponse> DescribeProtectionModuleStatusWithOptionsAsync(DescribeProtectionModuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProtectionModuleStatusResponse>(await DoRPCRequestAsync("DescribeProtectionModuleStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeProtectionModuleStatusResponse DescribeProtectionModuleStatus(DescribeProtectionModuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProtectionModuleStatusWithOptions(request, runtime);
        }

        public async Task<DescribeProtectionModuleStatusResponse> DescribeProtectionModuleStatusAsync(DescribeProtectionModuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProtectionModuleStatusWithOptionsAsync(request, runtime);
        }

        public DescribeWafSourceIpSegmentResponse DescribeWafSourceIpSegmentWithOptions(DescribeWafSourceIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWafSourceIpSegmentResponse>(DoRPCRequest("DescribeWafSourceIpSegment", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWafSourceIpSegmentResponse> DescribeWafSourceIpSegmentWithOptionsAsync(DescribeWafSourceIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWafSourceIpSegmentResponse>(await DoRPCRequestAsync("DescribeWafSourceIpSegment", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWafSourceIpSegmentResponse DescribeWafSourceIpSegment(DescribeWafSourceIpSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWafSourceIpSegmentWithOptions(request, runtime);
        }

        public async Task<DescribeWafSourceIpSegmentResponse> DescribeWafSourceIpSegmentAsync(DescribeWafSourceIpSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWafSourceIpSegmentWithOptionsAsync(request, runtime);
        }

        public ModifyDomainClusterTypeResponse ModifyDomainClusterTypeWithOptions(ModifyDomainClusterTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDomainClusterTypeResponse>(DoRPCRequest("ModifyDomainClusterType", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDomainClusterTypeResponse> ModifyDomainClusterTypeWithOptionsAsync(ModifyDomainClusterTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDomainClusterTypeResponse>(await DoRPCRequestAsync("ModifyDomainClusterType", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDomainClusterTypeResponse ModifyDomainClusterType(ModifyDomainClusterTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDomainClusterTypeWithOptions(request, runtime);
        }

        public async Task<ModifyDomainClusterTypeResponse> ModifyDomainClusterTypeAsync(ModifyDomainClusterTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDomainClusterTypeWithOptionsAsync(request, runtime);
        }

        public ModifyDomainIpv6StatusResponse ModifyDomainIpv6StatusWithOptions(ModifyDomainIpv6StatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDomainIpv6StatusResponse>(DoRPCRequest("ModifyDomainIpv6Status", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDomainIpv6StatusResponse> ModifyDomainIpv6StatusWithOptionsAsync(ModifyDomainIpv6StatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDomainIpv6StatusResponse>(await DoRPCRequestAsync("ModifyDomainIpv6Status", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDomainIpv6StatusResponse ModifyDomainIpv6Status(ModifyDomainIpv6StatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDomainIpv6StatusWithOptions(request, runtime);
        }

        public async Task<ModifyDomainIpv6StatusResponse> ModifyDomainIpv6StatusAsync(ModifyDomainIpv6StatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDomainIpv6StatusWithOptionsAsync(request, runtime);
        }

        public ModifyLogRetrievalStatusResponse ModifyLogRetrievalStatusWithOptions(ModifyLogRetrievalStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLogRetrievalStatusResponse>(DoRPCRequest("ModifyLogRetrievalStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLogRetrievalStatusResponse> ModifyLogRetrievalStatusWithOptionsAsync(ModifyLogRetrievalStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLogRetrievalStatusResponse>(await DoRPCRequestAsync("ModifyLogRetrievalStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLogRetrievalStatusResponse ModifyLogRetrievalStatus(ModifyLogRetrievalStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLogRetrievalStatusWithOptions(request, runtime);
        }

        public async Task<ModifyLogRetrievalStatusResponse> ModifyLogRetrievalStatusAsync(ModifyLogRetrievalStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLogRetrievalStatusWithOptionsAsync(request, runtime);
        }

        public ModifyLogServiceStatusResponse ModifyLogServiceStatusWithOptions(ModifyLogServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLogServiceStatusResponse>(DoRPCRequest("ModifyLogServiceStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLogServiceStatusResponse> ModifyLogServiceStatusWithOptionsAsync(ModifyLogServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLogServiceStatusResponse>(await DoRPCRequestAsync("ModifyLogServiceStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLogServiceStatusResponse ModifyLogServiceStatus(ModifyLogServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLogServiceStatusWithOptions(request, runtime);
        }

        public async Task<ModifyLogServiceStatusResponse> ModifyLogServiceStatusAsync(ModifyLogServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLogServiceStatusWithOptionsAsync(request, runtime);
        }

        public ModifyProtectionModuleModeResponse ModifyProtectionModuleModeWithOptions(ModifyProtectionModuleModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyProtectionModuleModeResponse>(DoRPCRequest("ModifyProtectionModuleMode", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyProtectionModuleModeResponse> ModifyProtectionModuleModeWithOptionsAsync(ModifyProtectionModuleModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyProtectionModuleModeResponse>(await DoRPCRequestAsync("ModifyProtectionModuleMode", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyProtectionModuleModeResponse ModifyProtectionModuleMode(ModifyProtectionModuleModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtectionModuleModeWithOptions(request, runtime);
        }

        public async Task<ModifyProtectionModuleModeResponse> ModifyProtectionModuleModeAsync(ModifyProtectionModuleModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtectionModuleModeWithOptionsAsync(request, runtime);
        }

        public ModifyProtectionModuleRuleResponse ModifyProtectionModuleRuleWithOptions(ModifyProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyProtectionModuleRuleResponse>(DoRPCRequest("ModifyProtectionModuleRule", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyProtectionModuleRuleResponse> ModifyProtectionModuleRuleWithOptionsAsync(ModifyProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyProtectionModuleRuleResponse>(await DoRPCRequestAsync("ModifyProtectionModuleRule", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyProtectionModuleRuleResponse ModifyProtectionModuleRule(ModifyProtectionModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtectionModuleRuleWithOptions(request, runtime);
        }

        public async Task<ModifyProtectionModuleRuleResponse> ModifyProtectionModuleRuleAsync(ModifyProtectionModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtectionModuleRuleWithOptionsAsync(request, runtime);
        }

        public ModifyProtectionModuleStatusResponse ModifyProtectionModuleStatusWithOptions(ModifyProtectionModuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyProtectionModuleStatusResponse>(DoRPCRequest("ModifyProtectionModuleStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyProtectionModuleStatusResponse> ModifyProtectionModuleStatusWithOptionsAsync(ModifyProtectionModuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyProtectionModuleStatusResponse>(await DoRPCRequestAsync("ModifyProtectionModuleStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyProtectionModuleStatusResponse ModifyProtectionModuleStatus(ModifyProtectionModuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtectionModuleStatusWithOptions(request, runtime);
        }

        public async Task<ModifyProtectionModuleStatusResponse> ModifyProtectionModuleStatusAsync(ModifyProtectionModuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtectionModuleStatusWithOptionsAsync(request, runtime);
        }

        public ModifyProtectionRuleCacheStatusResponse ModifyProtectionRuleCacheStatusWithOptions(ModifyProtectionRuleCacheStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyProtectionRuleCacheStatusResponse>(DoRPCRequest("ModifyProtectionRuleCacheStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyProtectionRuleCacheStatusResponse> ModifyProtectionRuleCacheStatusWithOptionsAsync(ModifyProtectionRuleCacheStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyProtectionRuleCacheStatusResponse>(await DoRPCRequestAsync("ModifyProtectionRuleCacheStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyProtectionRuleCacheStatusResponse ModifyProtectionRuleCacheStatus(ModifyProtectionRuleCacheStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtectionRuleCacheStatusWithOptions(request, runtime);
        }

        public async Task<ModifyProtectionRuleCacheStatusResponse> ModifyProtectionRuleCacheStatusAsync(ModifyProtectionRuleCacheStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtectionRuleCacheStatusWithOptionsAsync(request, runtime);
        }

        public ModifyProtectionRuleStatusResponse ModifyProtectionRuleStatusWithOptions(ModifyProtectionRuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyProtectionRuleStatusResponse>(DoRPCRequest("ModifyProtectionRuleStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyProtectionRuleStatusResponse> ModifyProtectionRuleStatusWithOptionsAsync(ModifyProtectionRuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyProtectionRuleStatusResponse>(await DoRPCRequestAsync("ModifyProtectionRuleStatus", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyProtectionRuleStatusResponse ModifyProtectionRuleStatus(ModifyProtectionRuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtectionRuleStatusWithOptions(request, runtime);
        }

        public async Task<ModifyProtectionRuleStatusResponse> ModifyProtectionRuleStatusAsync(ModifyProtectionRuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtectionRuleStatusWithOptionsAsync(request, runtime);
        }

        public SetDomainRuleGroupResponse SetDomainRuleGroupWithOptions(SetDomainRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainRuleGroupResponse>(DoRPCRequest("SetDomainRuleGroup", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDomainRuleGroupResponse> SetDomainRuleGroupWithOptionsAsync(SetDomainRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainRuleGroupResponse>(await DoRPCRequestAsync("SetDomainRuleGroup", "2019-09-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDomainRuleGroupResponse SetDomainRuleGroup(SetDomainRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainRuleGroupWithOptions(request, runtime);
        }

        public async Task<SetDomainRuleGroupResponse> SetDomainRuleGroupAsync(SetDomainRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainRuleGroupWithOptionsAsync(request, runtime);
        }

    }
}
