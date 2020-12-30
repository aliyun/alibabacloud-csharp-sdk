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
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ddoscoo", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddLayer7CCRuleResponse AddLayer7CCRuleWithOptions(AddLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLayer7CCRuleResponse>(DoRPCRequest("AddLayer7CCRule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLayer7CCRuleResponse> AddLayer7CCRuleWithOptionsAsync(AddLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLayer7CCRuleResponse>(await DoRPCRequestAsync("AddLayer7CCRule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CloseDomainSlsConfigResponse CloseDomainSlsConfigWithOptions(CloseDomainSlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloseDomainSlsConfigResponse>(DoRPCRequest("CloseDomainSlsConfig", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CloseDomainSlsConfigResponse> CloseDomainSlsConfigWithOptionsAsync(CloseDomainSlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloseDomainSlsConfigResponse>(await DoRPCRequestAsync("CloseDomainSlsConfig", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigDomainAccessModeResponse ConfigDomainAccessModeWithOptions(ConfigDomainAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigDomainAccessModeResponse>(DoRPCRequest("ConfigDomainAccessMode", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigDomainAccessModeResponse> ConfigDomainAccessModeWithOptionsAsync(ConfigDomainAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigDomainAccessModeResponse>(await DoRPCRequestAsync("ConfigDomainAccessMode", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigHealthCheckResponse ConfigHealthCheckWithOptions(ConfigHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigHealthCheckResponse>(DoRPCRequest("ConfigHealthCheck", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigHealthCheckResponse> ConfigHealthCheckWithOptionsAsync(ConfigHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigHealthCheckResponse>(await DoRPCRequestAsync("ConfigHealthCheck", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigLayer4RuleResponse ConfigLayer4RuleWithOptions(ConfigLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer4RuleResponse>(DoRPCRequest("ConfigLayer4Rule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigLayer4RuleResponse> ConfigLayer4RuleWithOptionsAsync(ConfigLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer4RuleResponse>(await DoRPCRequestAsync("ConfigLayer4Rule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigLayer4RuleAttributeResponse ConfigLayer4RuleAttributeWithOptions(ConfigLayer4RuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer4RuleAttributeResponse>(DoRPCRequest("ConfigLayer4RuleAttribute", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigLayer4RuleAttributeResponse> ConfigLayer4RuleAttributeWithOptionsAsync(ConfigLayer4RuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer4RuleAttributeResponse>(await DoRPCRequestAsync("ConfigLayer4RuleAttribute", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigLayer7BlackWhiteListResponse ConfigLayer7BlackWhiteListWithOptions(ConfigLayer7BlackWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer7BlackWhiteListResponse>(DoRPCRequest("ConfigLayer7BlackWhiteList", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigLayer7BlackWhiteListResponse> ConfigLayer7BlackWhiteListWithOptionsAsync(ConfigLayer7BlackWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer7BlackWhiteListResponse>(await DoRPCRequestAsync("ConfigLayer7BlackWhiteList", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigLayer7CCRuleResponse ConfigLayer7CCRuleWithOptions(ConfigLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer7CCRuleResponse>(DoRPCRequest("ConfigLayer7CCRule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigLayer7CCRuleResponse> ConfigLayer7CCRuleWithOptionsAsync(ConfigLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer7CCRuleResponse>(await DoRPCRequestAsync("ConfigLayer7CCRule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigLayer7CCTemplateResponse ConfigLayer7CCTemplateWithOptions(ConfigLayer7CCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer7CCTemplateResponse>(DoRPCRequest("ConfigLayer7CCTemplate", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigLayer7CCTemplateResponse> ConfigLayer7CCTemplateWithOptionsAsync(ConfigLayer7CCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer7CCTemplateResponse>(await DoRPCRequestAsync("ConfigLayer7CCTemplate", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigLayer7CertResponse ConfigLayer7CertWithOptions(ConfigLayer7CertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer7CertResponse>(DoRPCRequest("ConfigLayer7Cert", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigLayer7CertResponse> ConfigLayer7CertWithOptionsAsync(ConfigLayer7CertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer7CertResponse>(await DoRPCRequestAsync("ConfigLayer7Cert", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigLayer7RuleResponse ConfigLayer7RuleWithOptions(ConfigLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer7RuleResponse>(DoRPCRequest("ConfigLayer7Rule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigLayer7RuleResponse> ConfigLayer7RuleWithOptionsAsync(ConfigLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigLayer7RuleResponse>(await DoRPCRequestAsync("ConfigLayer7Rule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateAsyncTaskResponse CreateAsyncTaskWithOptions(CreateAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAsyncTaskResponse>(DoRPCRequest("CreateAsyncTask", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAsyncTaskResponse> CreateAsyncTaskWithOptionsAsync(CreateAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAsyncTaskResponse>(await DoRPCRequestAsync("CreateAsyncTask", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateLayer4RuleResponse CreateLayer4RuleWithOptions(CreateLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLayer4RuleResponse>(DoRPCRequest("CreateLayer4Rule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLayer4RuleResponse> CreateLayer4RuleWithOptionsAsync(CreateLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLayer4RuleResponse>(await DoRPCRequestAsync("CreateLayer4Rule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateLayer7RuleResponse CreateLayer7RuleWithOptions(CreateLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLayer7RuleResponse>(DoRPCRequest("CreateLayer7Rule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLayer7RuleResponse> CreateLayer7RuleWithOptionsAsync(CreateLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLayer7RuleResponse>(await DoRPCRequestAsync("CreateLayer7Rule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteAsyncTaskResponse DeleteAsyncTaskWithOptions(DeleteAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAsyncTaskResponse>(DoRPCRequest("DeleteAsyncTask", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAsyncTaskResponse> DeleteAsyncTaskWithOptionsAsync(DeleteAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAsyncTaskResponse>(await DoRPCRequestAsync("DeleteAsyncTask", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteLayer4RuleResponse DeleteLayer4RuleWithOptions(DeleteLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLayer4RuleResponse>(DoRPCRequest("DeleteLayer4Rule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLayer4RuleResponse> DeleteLayer4RuleWithOptionsAsync(DeleteLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLayer4RuleResponse>(await DoRPCRequestAsync("DeleteLayer4Rule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteLayer7CCRuleResponse DeleteLayer7CCRuleWithOptions(DeleteLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLayer7CCRuleResponse>(DoRPCRequest("DeleteLayer7CCRule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLayer7CCRuleResponse> DeleteLayer7CCRuleWithOptionsAsync(DeleteLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLayer7CCRuleResponse>(await DoRPCRequestAsync("DeleteLayer7CCRule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteLayer7RuleResponse DeleteLayer7RuleWithOptions(DeleteLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLayer7RuleResponse>(DoRPCRequest("DeleteLayer7Rule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLayer7RuleResponse> DeleteLayer7RuleWithOptionsAsync(DeleteLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLayer7RuleResponse>(await DoRPCRequestAsync("DeleteLayer7Rule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeBackSourceCidrResponse DescribeBackSourceCidrWithOptions(DescribeBackSourceCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackSourceCidrResponse>(DoRPCRequest("DescribeBackSourceCidr", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackSourceCidrResponse> DescribeBackSourceCidrWithOptionsAsync(DescribeBackSourceCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackSourceCidrResponse>(await DoRPCRequestAsync("DescribeBackSourceCidr", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeBatchSlsDispatchStatusResponse DescribeBatchSlsDispatchStatusWithOptions(DescribeBatchSlsDispatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBatchSlsDispatchStatusResponse>(DoRPCRequest("DescribeBatchSlsDispatchStatus", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBatchSlsDispatchStatusResponse> DescribeBatchSlsDispatchStatusWithOptionsAsync(DescribeBatchSlsDispatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBatchSlsDispatchStatusResponse>(await DoRPCRequestAsync("DescribeBatchSlsDispatchStatus", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDDoSEventsResponse DescribeDDoSEventsWithOptions(DescribeDDoSEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDoSEventsResponse>(DoRPCRequest("DescribeDDoSEvents", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDDoSEventsResponse> DescribeDDoSEventsWithOptionsAsync(DescribeDDoSEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDoSEventsResponse>(await DoRPCRequestAsync("DescribeDDoSEvents", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDDoSTrafficResponse DescribeDDoSTrafficWithOptions(DescribeDDoSTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDoSTrafficResponse>(DoRPCRequest("DescribeDDoSTraffic", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDDoSTrafficResponse> DescribeDDoSTrafficWithOptionsAsync(DescribeDDoSTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDoSTrafficResponse>(await DoRPCRequestAsync("DescribeDDoSTraffic", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDefenseCountStatisticsResponse DescribeDefenseCountStatisticsWithOptions(DescribeDefenseCountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDefenseCountStatisticsResponse>(DoRPCRequest("DescribeDefenseCountStatistics", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDefenseCountStatisticsResponse> DescribeDefenseCountStatisticsWithOptionsAsync(DescribeDefenseCountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDefenseCountStatisticsResponse>(await DoRPCRequestAsync("DescribeDefenseCountStatistics", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDomainAccessModeResponse DescribeDomainAccessModeWithOptions(DescribeDomainAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainAccessModeResponse>(DoRPCRequest("DescribeDomainAccessMode", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainAccessModeResponse> DescribeDomainAccessModeWithOptionsAsync(DescribeDomainAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainAccessModeResponse>(await DoRPCRequestAsync("DescribeDomainAccessMode", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDomainAttackEventsResponse DescribeDomainAttackEventsWithOptions(DescribeDomainAttackEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainAttackEventsResponse>(DoRPCRequest("DescribeDomainAttackEvents", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainAttackEventsResponse> DescribeDomainAttackEventsWithOptionsAsync(DescribeDomainAttackEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainAttackEventsResponse>(await DoRPCRequestAsync("DescribeDomainAttackEvents", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDomainQpsResponse DescribeDomainQpsWithOptions(DescribeDomainQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainQpsResponse>(DoRPCRequest("DescribeDomainQps", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainQpsResponse> DescribeDomainQpsWithOptionsAsync(DescribeDomainQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainQpsResponse>(await DoRPCRequestAsync("DescribeDomainQps", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDomainQpsWithCacheResponse DescribeDomainQpsWithCacheWithOptions(DescribeDomainQpsWithCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainQpsWithCacheResponse>(DoRPCRequest("DescribeDomainQpsWithCache", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainQpsWithCacheResponse> DescribeDomainQpsWithCacheWithOptionsAsync(DescribeDomainQpsWithCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainQpsWithCacheResponse>(await DoRPCRequestAsync("DescribeDomainQpsWithCache", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDomainsResponse DescribeDomainsWithOptions(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainsResponse>(DoRPCRequest("DescribeDomains", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainsResponse> DescribeDomainsWithOptionsAsync(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainsResponse>(await DoRPCRequestAsync("DescribeDomains", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDomainSlsStatusResponse DescribeDomainSlsStatusWithOptions(DescribeDomainSlsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSlsStatusResponse>(DoRPCRequest("DescribeDomainSlsStatus", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainSlsStatusResponse> DescribeDomainSlsStatusWithOptionsAsync(DescribeDomainSlsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSlsStatusResponse>(await DoRPCRequestAsync("DescribeDomainSlsStatus", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeElasticBandwidthSpecResponse DescribeElasticBandwidthSpecWithOptions(DescribeElasticBandwidthSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeElasticBandwidthSpecResponse>(DoRPCRequest("DescribeElasticBandwidthSpec", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeElasticBandwidthSpecResponse> DescribeElasticBandwidthSpecWithOptionsAsync(DescribeElasticBandwidthSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeElasticBandwidthSpecResponse>(await DoRPCRequestAsync("DescribeElasticBandwidthSpec", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeHealthCheckListResponse DescribeHealthCheckListWithOptions(DescribeHealthCheckListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthCheckListResponse>(DoRPCRequest("DescribeHealthCheckList", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHealthCheckListResponse> DescribeHealthCheckListWithOptionsAsync(DescribeHealthCheckListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthCheckListResponse>(await DoRPCRequestAsync("DescribeHealthCheckList", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeHealthCheckStatusListResponse DescribeHealthCheckStatusListWithOptions(DescribeHealthCheckStatusListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthCheckStatusListResponse>(DoRPCRequest("DescribeHealthCheckStatusList", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHealthCheckStatusListResponse> DescribeHealthCheckStatusListWithOptionsAsync(DescribeHealthCheckStatusListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthCheckStatusListResponse>(await DoRPCRequestAsync("DescribeHealthCheckStatusList", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeInstanceDetailsResponse DescribeInstanceDetailsWithOptions(DescribeInstanceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceDetailsResponse>(DoRPCRequest("DescribeInstanceDetails", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceDetailsResponse> DescribeInstanceDetailsWithOptionsAsync(DescribeInstanceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceDetailsResponse>(await DoRPCRequestAsync("DescribeInstanceDetails", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(DoRPCRequest("DescribeInstances", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await DoRPCRequestAsync("DescribeInstances", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeInstanceSpecsResponse DescribeInstanceSpecsWithOptions(DescribeInstanceSpecsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSpecsResponse>(DoRPCRequest("DescribeInstanceSpecs", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceSpecsResponse> DescribeInstanceSpecsWithOptionsAsync(DescribeInstanceSpecsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSpecsResponse>(await DoRPCRequestAsync("DescribeInstanceSpecs", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeInstanceStatisticsResponse DescribeInstanceStatisticsWithOptions(DescribeInstanceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceStatisticsResponse>(DoRPCRequest("DescribeInstanceStatistics", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceStatisticsResponse> DescribeInstanceStatisticsWithOptionsAsync(DescribeInstanceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceStatisticsResponse>(await DoRPCRequestAsync("DescribeInstanceStatistics", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeIpTrafficResponse DescribeIpTrafficWithOptions(DescribeIpTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpTrafficResponse>(DoRPCRequest("DescribeIpTraffic", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpTrafficResponse> DescribeIpTrafficWithOptionsAsync(DescribeIpTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpTrafficResponse>(await DoRPCRequestAsync("DescribeIpTraffic", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeLayer4RuleAttributesResponse DescribeLayer4RuleAttributesWithOptions(DescribeLayer4RuleAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLayer4RuleAttributesResponse>(DoRPCRequest("DescribeLayer4RuleAttributes", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLayer4RuleAttributesResponse> DescribeLayer4RuleAttributesWithOptionsAsync(DescribeLayer4RuleAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLayer4RuleAttributesResponse>(await DoRPCRequestAsync("DescribeLayer4RuleAttributes", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeLayer4RulesResponse DescribeLayer4RulesWithOptions(DescribeLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLayer4RulesResponse>(DoRPCRequest("DescribeLayer4Rules", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLayer4RulesResponse> DescribeLayer4RulesWithOptionsAsync(DescribeLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLayer4RulesResponse>(await DoRPCRequestAsync("DescribeLayer4Rules", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeLayer7CCRulesResponse DescribeLayer7CCRulesWithOptions(DescribeLayer7CCRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLayer7CCRulesResponse>(DoRPCRequest("DescribeLayer7CCRules", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLayer7CCRulesResponse> DescribeLayer7CCRulesWithOptionsAsync(DescribeLayer7CCRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLayer7CCRulesResponse>(await DoRPCRequestAsync("DescribeLayer7CCRules", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeLogStoreExistStatusResponse DescribeLogStoreExistStatusWithOptions(DescribeLogStoreExistStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogStoreExistStatusResponse>(DoRPCRequest("DescribeLogStoreExistStatus", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLogStoreExistStatusResponse> DescribeLogStoreExistStatusWithOptionsAsync(DescribeLogStoreExistStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogStoreExistStatusResponse>(await DoRPCRequestAsync("DescribeLogStoreExistStatus", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeOpEntitiesResponse DescribeOpEntitiesWithOptions(DescribeOpEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOpEntitiesResponse>(DoRPCRequest("DescribeOpEntities", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeOpEntitiesResponse> DescribeOpEntitiesWithOptionsAsync(DescribeOpEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOpEntitiesResponse>(await DoRPCRequestAsync("DescribeOpEntities", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSimpleDomainsResponse DescribeSimpleDomainsWithOptions(DescribeSimpleDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSimpleDomainsResponse>(DoRPCRequest("DescribeSimpleDomains", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSimpleDomainsResponse> DescribeSimpleDomainsWithOptionsAsync(DescribeSimpleDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSimpleDomainsResponse>(await DoRPCRequestAsync("DescribeSimpleDomains", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSlsAuthStatusResponse DescribeSlsAuthStatusWithOptions(DescribeSlsAuthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlsAuthStatusResponse>(DoRPCRequest("DescribeSlsAuthStatus", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSlsAuthStatusResponse> DescribeSlsAuthStatusWithOptionsAsync(DescribeSlsAuthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlsAuthStatusResponse>(await DoRPCRequestAsync("DescribeSlsAuthStatus", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSlsEmptyCountResponse DescribeSlsEmptyCountWithOptions(DescribeSlsEmptyCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlsEmptyCountResponse>(DoRPCRequest("DescribeSlsEmptyCount", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSlsEmptyCountResponse> DescribeSlsEmptyCountWithOptionsAsync(DescribeSlsEmptyCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlsEmptyCountResponse>(await DoRPCRequestAsync("DescribeSlsEmptyCount", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSlsLogstoreInfoResponse DescribeSlsLogstoreInfoWithOptions(DescribeSlsLogstoreInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlsLogstoreInfoResponse>(DoRPCRequest("DescribeSlsLogstoreInfo", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSlsLogstoreInfoResponse> DescribeSlsLogstoreInfoWithOptionsAsync(DescribeSlsLogstoreInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlsLogstoreInfoResponse>(await DoRPCRequestAsync("DescribeSlsLogstoreInfo", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSlsOpenStatusResponse DescribeSlsOpenStatusWithOptions(DescribeSlsOpenStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlsOpenStatusResponse>(DoRPCRequest("DescribeSlsOpenStatus", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSlsOpenStatusResponse> DescribeSlsOpenStatusWithOptionsAsync(DescribeSlsOpenStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlsOpenStatusResponse>(await DoRPCRequestAsync("DescribeSlsOpenStatus", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribleCertListResponse DescribleCertListWithOptions(DescribleCertListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribleCertListResponse>(DoRPCRequest("DescribleCertList", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribleCertListResponse> DescribleCertListWithOptionsAsync(DescribleCertListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribleCertListResponse>(await DoRPCRequestAsync("DescribleCertList", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribleLayer7InstanceRelationsResponse DescribleLayer7InstanceRelationsWithOptions(DescribleLayer7InstanceRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribleLayer7InstanceRelationsResponse>(DoRPCRequest("DescribleLayer7InstanceRelations", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribleLayer7InstanceRelationsResponse> DescribleLayer7InstanceRelationsWithOptionsAsync(DescribleLayer7InstanceRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribleLayer7InstanceRelationsResponse>(await DoRPCRequestAsync("DescribleLayer7InstanceRelations", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DisableLayer7CCResponse DisableLayer7CCWithOptions(DisableLayer7CCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableLayer7CCResponse>(DoRPCRequest("DisableLayer7CC", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableLayer7CCResponse> DisableLayer7CCWithOptionsAsync(DisableLayer7CCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableLayer7CCResponse>(await DoRPCRequestAsync("DisableLayer7CC", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DisableLayer7CCRuleResponse DisableLayer7CCRuleWithOptions(DisableLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableLayer7CCRuleResponse>(DoRPCRequest("DisableLayer7CCRule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableLayer7CCRuleResponse> DisableLayer7CCRuleWithOptionsAsync(DisableLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableLayer7CCRuleResponse>(await DoRPCRequestAsync("DisableLayer7CCRule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public EmptySlsLogstoreResponse EmptySlsLogstoreWithOptions(EmptySlsLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EmptySlsLogstoreResponse>(DoRPCRequest("EmptySlsLogstore", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EmptySlsLogstoreResponse> EmptySlsLogstoreWithOptionsAsync(EmptySlsLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EmptySlsLogstoreResponse>(await DoRPCRequestAsync("EmptySlsLogstore", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public EnableLayer7CCResponse EnableLayer7CCWithOptions(EnableLayer7CCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableLayer7CCResponse>(DoRPCRequest("EnableLayer7CC", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableLayer7CCResponse> EnableLayer7CCWithOptionsAsync(EnableLayer7CCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableLayer7CCResponse>(await DoRPCRequestAsync("EnableLayer7CC", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public EnableLayer7CCRuleResponse EnableLayer7CCRuleWithOptions(EnableLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableLayer7CCRuleResponse>(DoRPCRequest("EnableLayer7CCRule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableLayer7CCRuleResponse> EnableLayer7CCRuleWithOptionsAsync(EnableLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableLayer7CCRuleResponse>(await DoRPCRequestAsync("EnableLayer7CCRule", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListAsyncTaskResponse ListAsyncTaskWithOptions(ListAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAsyncTaskResponse>(DoRPCRequest("ListAsyncTask", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAsyncTaskResponse> ListAsyncTaskWithOptionsAsync(ListAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAsyncTaskResponse>(await DoRPCRequestAsync("ListAsyncTask", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListLayer7CustomPortsResponse ListLayer7CustomPortsWithOptions(ListLayer7CustomPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLayer7CustomPortsResponse>(DoRPCRequest("ListLayer7CustomPorts", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListLayer7CustomPortsResponse> ListLayer7CustomPortsWithOptionsAsync(ListLayer7CustomPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLayer7CustomPortsResponse>(await DoRPCRequestAsync("ListLayer7CustomPorts", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(DoRPCRequest("ListTagKeys", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await DoRPCRequestAsync("ListTagKeys", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListValueAddedResponse ListValueAddedWithOptions(ListValueAddedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListValueAddedResponse>(DoRPCRequest("ListValueAdded", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListValueAddedResponse> ListValueAddedWithOptionsAsync(ListValueAddedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListValueAddedResponse>(await DoRPCRequestAsync("ListValueAdded", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyElasticBandWidthResponse ModifyElasticBandWidthWithOptions(ModifyElasticBandWidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyElasticBandWidthResponse>(DoRPCRequest("ModifyElasticBandWidth", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyElasticBandWidthResponse> ModifyElasticBandWidthWithOptionsAsync(ModifyElasticBandWidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyElasticBandWidthResponse>(await DoRPCRequestAsync("ModifyElasticBandWidth", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyFullLogTtlResponse ModifyFullLogTtlWithOptions(ModifyFullLogTtlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFullLogTtlResponse>(DoRPCRequest("ModifyFullLogTtl", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFullLogTtlResponse> ModifyFullLogTtlWithOptionsAsync(ModifyFullLogTtlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFullLogTtlResponse>(await DoRPCRequestAsync("ModifyFullLogTtl", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyInstanceRemarkResponse ModifyInstanceRemarkWithOptions(ModifyInstanceRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceRemarkResponse>(DoRPCRequest("ModifyInstanceRemark", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceRemarkResponse> ModifyInstanceRemarkWithOptionsAsync(ModifyInstanceRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceRemarkResponse>(await DoRPCRequestAsync("ModifyInstanceRemark", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public OpenDomainSlsConfigResponse OpenDomainSlsConfigWithOptions(OpenDomainSlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenDomainSlsConfigResponse>(DoRPCRequest("OpenDomainSlsConfig", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenDomainSlsConfigResponse> OpenDomainSlsConfigWithOptionsAsync(OpenDomainSlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenDomainSlsConfigResponse>(await DoRPCRequestAsync("OpenDomainSlsConfig", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ReleaseInstanceResponse ReleaseInstanceWithOptions(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(DoRPCRequest("ReleaseInstance", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseInstanceResponse> ReleaseInstanceWithOptionsAsync(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(await DoRPCRequestAsync("ReleaseInstance", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ReleaseValueAddedResponse ReleaseValueAddedWithOptions(ReleaseValueAddedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseValueAddedResponse>(DoRPCRequest("ReleaseValueAdded", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseValueAddedResponse> ReleaseValueAddedWithOptionsAsync(ReleaseValueAddedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseValueAddedResponse>(await DoRPCRequestAsync("ReleaseValueAdded", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2017-12-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

    }
}
