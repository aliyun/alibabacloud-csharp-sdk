// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Waf_openapi20180117.Models;

namespace AlibabaCloud.SDK.Waf_openapi20180117
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

        public CreateAclRuleResponse CreateAclRuleWithOptions(CreateAclRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAclRuleResponse>(DoRPCRequest("CreateAclRule", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAclRuleResponse> CreateAclRuleWithOptionsAsync(CreateAclRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAclRuleResponse>(await DoRPCRequestAsync("CreateAclRule", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAclRuleResponse CreateAclRule(CreateAclRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAclRuleWithOptions(request, runtime);
        }

        public async Task<CreateAclRuleResponse> CreateAclRuleAsync(CreateAclRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAclRuleWithOptionsAsync(request, runtime);
        }

        public CreateCertAndKeyResponse CreateCertAndKeyWithOptions(CreateCertAndKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCertAndKeyResponse>(DoRPCRequest("CreateCertAndKey", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCertAndKeyResponse> CreateCertAndKeyWithOptionsAsync(CreateCertAndKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCertAndKeyResponse>(await DoRPCRequestAsync("CreateCertAndKey", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCertAndKeyResponse CreateCertAndKey(CreateCertAndKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCertAndKeyWithOptions(request, runtime);
        }

        public async Task<CreateCertAndKeyResponse> CreateCertAndKeyAsync(CreateCertAndKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCertAndKeyWithOptionsAsync(request, runtime);
        }

        public CreateDomainConfigResponse CreateDomainConfigWithOptions(CreateDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDomainConfigResponse>(DoRPCRequest("CreateDomainConfig", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDomainConfigResponse> CreateDomainConfigWithOptionsAsync(CreateDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDomainConfigResponse>(await DoRPCRequestAsync("CreateDomainConfig", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDomainConfigResponse CreateDomainConfig(CreateDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDomainConfigWithOptions(request, runtime);
        }

        public async Task<CreateDomainConfigResponse> CreateDomainConfigAsync(CreateDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDomainConfigWithOptionsAsync(request, runtime);
        }

        public CreateProtectionModuleRuleResponse CreateProtectionModuleRuleWithOptions(CreateProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProtectionModuleRuleResponse>(DoRPCRequest("CreateProtectionModuleRule", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProtectionModuleRuleResponse> CreateProtectionModuleRuleWithOptionsAsync(CreateProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProtectionModuleRuleResponse>(await DoRPCRequestAsync("CreateProtectionModuleRule", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteAclRuleResponse DeleteAclRuleWithOptions(DeleteAclRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAclRuleResponse>(DoRPCRequest("DeleteAclRule", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAclRuleResponse> DeleteAclRuleWithOptionsAsync(DeleteAclRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAclRuleResponse>(await DoRPCRequestAsync("DeleteAclRule", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAclRuleResponse DeleteAclRule(DeleteAclRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAclRuleWithOptions(request, runtime);
        }

        public async Task<DeleteAclRuleResponse> DeleteAclRuleAsync(DeleteAclRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAclRuleWithOptionsAsync(request, runtime);
        }

        public DeleteDomainConfigResponse DeleteDomainConfigWithOptions(DeleteDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainConfigResponse>(DoRPCRequest("DeleteDomainConfig", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDomainConfigResponse> DeleteDomainConfigWithOptionsAsync(DeleteDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainConfigResponse>(await DoRPCRequestAsync("DeleteDomainConfig", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDomainConfigResponse DeleteDomainConfig(DeleteDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainConfigWithOptions(request, runtime);
        }

        public async Task<DeleteDomainConfigResponse> DeleteDomainConfigAsync(DeleteDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainConfigWithOptionsAsync(request, runtime);
        }

        public DescribeAclRulesResponse DescribeAclRulesWithOptions(DescribeAclRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAclRulesResponse>(DoRPCRequest("DescribeAclRules", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAclRulesResponse> DescribeAclRulesWithOptionsAsync(DescribeAclRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAclRulesResponse>(await DoRPCRequestAsync("DescribeAclRules", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAclRulesResponse DescribeAclRules(DescribeAclRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAclRulesWithOptions(request, runtime);
        }

        public async Task<DescribeAclRulesResponse> DescribeAclRulesAsync(DescribeAclRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAclRulesWithOptionsAsync(request, runtime);
        }

        public DescribeAsyncTaskStatusResponse DescribeAsyncTaskStatusWithOptions(DescribeAsyncTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAsyncTaskStatusResponse>(DoRPCRequest("DescribeAsyncTaskStatus", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAsyncTaskStatusResponse> DescribeAsyncTaskStatusWithOptionsAsync(DescribeAsyncTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAsyncTaskStatusResponse>(await DoRPCRequestAsync("DescribeAsyncTaskStatus", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAsyncTaskStatusResponse DescribeAsyncTaskStatus(DescribeAsyncTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAsyncTaskStatusWithOptions(request, runtime);
        }

        public async Task<DescribeAsyncTaskStatusResponse> DescribeAsyncTaskStatusAsync(DescribeAsyncTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAsyncTaskStatusWithOptionsAsync(request, runtime);
        }

        public DescribeDomainConfigResponse DescribeDomainConfigWithOptions(DescribeDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainConfigResponse>(DoRPCRequest("DescribeDomainConfig", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainConfigResponse> DescribeDomainConfigWithOptionsAsync(DescribeDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainConfigResponse>(await DoRPCRequestAsync("DescribeDomainConfig", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainConfigResponse DescribeDomainConfig(DescribeDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainConfigWithOptions(request, runtime);
        }

        public async Task<DescribeDomainConfigResponse> DescribeDomainConfigAsync(DescribeDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDomainConfigStatusResponse DescribeDomainConfigStatusWithOptions(DescribeDomainConfigStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainConfigStatusResponse>(DoRPCRequest("DescribeDomainConfigStatus", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainConfigStatusResponse> DescribeDomainConfigStatusWithOptionsAsync(DescribeDomainConfigStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainConfigStatusResponse>(await DoRPCRequestAsync("DescribeDomainConfigStatus", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainConfigStatusResponse DescribeDomainConfigStatus(DescribeDomainConfigStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainConfigStatusWithOptions(request, runtime);
        }

        public async Task<DescribeDomainConfigStatusResponse> DescribeDomainConfigStatusAsync(DescribeDomainConfigStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainConfigStatusWithOptionsAsync(request, runtime);
        }

        public DescribeDomainNamesResponse DescribeDomainNamesWithOptions(DescribeDomainNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainNamesResponse>(DoRPCRequest("DescribeDomainNames", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainNamesResponse> DescribeDomainNamesWithOptionsAsync(DescribeDomainNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainNamesResponse>(await DoRPCRequestAsync("DescribeDomainNames", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribePayInfoResponse DescribePayInfoWithOptions(DescribePayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePayInfoResponse>(DoRPCRequest("DescribePayInfo", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePayInfoResponse> DescribePayInfoWithOptionsAsync(DescribePayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePayInfoResponse>(await DoRPCRequestAsync("DescribePayInfo", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePayInfoResponse DescribePayInfo(DescribePayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePayInfoWithOptions(request, runtime);
        }

        public async Task<DescribePayInfoResponse> DescribePayInfoAsync(DescribePayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePayInfoWithOptionsAsync(request, runtime);
        }

        public DescribeProtectionModuleRulesResponse DescribeProtectionModuleRulesWithOptions(DescribeProtectionModuleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProtectionModuleRulesResponse>(DoRPCRequest("DescribeProtectionModuleRules", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeProtectionModuleRulesResponse> DescribeProtectionModuleRulesWithOptionsAsync(DescribeProtectionModuleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProtectionModuleRulesResponse>(await DoRPCRequestAsync("DescribeProtectionModuleRules", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeWafSourceIpSegmentResponse DescribeWafSourceIpSegmentWithOptions(DescribeWafSourceIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWafSourceIpSegmentResponse>(DoRPCRequest("DescribeWafSourceIpSegment", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWafSourceIpSegmentResponse> DescribeWafSourceIpSegmentWithOptionsAsync(DescribeWafSourceIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWafSourceIpSegmentResponse>(await DoRPCRequestAsync("DescribeWafSourceIpSegment", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyAclRuleResponse ModifyAclRuleWithOptions(ModifyAclRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAclRuleResponse>(DoRPCRequest("ModifyAclRule", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAclRuleResponse> ModifyAclRuleWithOptionsAsync(ModifyAclRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAclRuleResponse>(await DoRPCRequestAsync("ModifyAclRule", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAclRuleResponse ModifyAclRule(ModifyAclRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAclRuleWithOptions(request, runtime);
        }

        public async Task<ModifyAclRuleResponse> ModifyAclRuleAsync(ModifyAclRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAclRuleWithOptionsAsync(request, runtime);
        }

        public ModifyDomainConfigResponse ModifyDomainConfigWithOptions(ModifyDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDomainConfigResponse>(DoRPCRequest("ModifyDomainConfig", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDomainConfigResponse> ModifyDomainConfigWithOptionsAsync(ModifyDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDomainConfigResponse>(await DoRPCRequestAsync("ModifyDomainConfig", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDomainConfigResponse ModifyDomainConfig(ModifyDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDomainConfigWithOptions(request, runtime);
        }

        public async Task<ModifyDomainConfigResponse> ModifyDomainConfigAsync(ModifyDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDomainConfigWithOptionsAsync(request, runtime);
        }

        public ModifyProtectionRuleCacheStatusResponse ModifyProtectionRuleCacheStatusWithOptions(ModifyProtectionRuleCacheStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyProtectionRuleCacheStatusResponse>(DoRPCRequest("ModifyProtectionRuleCacheStatus", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyProtectionRuleCacheStatusResponse> ModifyProtectionRuleCacheStatusWithOptionsAsync(ModifyProtectionRuleCacheStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyProtectionRuleCacheStatusResponse>(await DoRPCRequestAsync("ModifyProtectionRuleCacheStatus", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<ModifyProtectionRuleStatusResponse>(DoRPCRequest("ModifyProtectionRuleStatus", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyProtectionRuleStatusResponse> ModifyProtectionRuleStatusWithOptionsAsync(ModifyProtectionRuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyProtectionRuleStatusResponse>(await DoRPCRequestAsync("ModifyProtectionRuleStatus", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyWafSwitchResponse ModifyWafSwitchWithOptions(ModifyWafSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWafSwitchResponse>(DoRPCRequest("ModifyWafSwitch", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWafSwitchResponse> ModifyWafSwitchWithOptionsAsync(ModifyWafSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWafSwitchResponse>(await DoRPCRequestAsync("ModifyWafSwitch", "2018-01-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWafSwitchResponse ModifyWafSwitch(ModifyWafSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWafSwitchWithOptions(request, runtime);
        }

        public async Task<ModifyWafSwitchResponse> ModifyWafSwitchAsync(ModifyWafSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWafSwitchWithOptionsAsync(request, runtime);
        }

    }
}
