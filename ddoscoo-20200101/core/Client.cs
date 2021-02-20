// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ddoscoo20200101.Models;

namespace AlibabaCloud.SDK.Ddoscoo20200101
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

        public AddAutoCcBlacklistResponse AddAutoCcBlacklistWithOptions(AddAutoCcBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAutoCcBlacklistResponse>(DoRPCRequest("AddAutoCcBlacklist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddAutoCcBlacklistResponse> AddAutoCcBlacklistWithOptionsAsync(AddAutoCcBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAutoCcBlacklistResponse>(await DoRPCRequestAsync("AddAutoCcBlacklist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddAutoCcBlacklistResponse AddAutoCcBlacklist(AddAutoCcBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAutoCcBlacklistWithOptions(request, runtime);
        }

        public async Task<AddAutoCcBlacklistResponse> AddAutoCcBlacklistAsync(AddAutoCcBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAutoCcBlacklistWithOptionsAsync(request, runtime);
        }

        public AddAutoCcWhitelistResponse AddAutoCcWhitelistWithOptions(AddAutoCcWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAutoCcWhitelistResponse>(DoRPCRequest("AddAutoCcWhitelist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddAutoCcWhitelistResponse> AddAutoCcWhitelistWithOptionsAsync(AddAutoCcWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAutoCcWhitelistResponse>(await DoRPCRequestAsync("AddAutoCcWhitelist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddAutoCcWhitelistResponse AddAutoCcWhitelist(AddAutoCcWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAutoCcWhitelistWithOptions(request, runtime);
        }

        public async Task<AddAutoCcWhitelistResponse> AddAutoCcWhitelistAsync(AddAutoCcWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAutoCcWhitelistWithOptionsAsync(request, runtime);
        }

        public AssociateWebCertResponse AssociateWebCertWithOptions(AssociateWebCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateWebCertResponse>(DoRPCRequest("AssociateWebCert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateWebCertResponse> AssociateWebCertWithOptionsAsync(AssociateWebCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateWebCertResponse>(await DoRPCRequestAsync("AssociateWebCert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateWebCertResponse AssociateWebCert(AssociateWebCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateWebCertWithOptions(request, runtime);
        }

        public async Task<AssociateWebCertResponse> AssociateWebCertAsync(AssociateWebCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateWebCertWithOptionsAsync(request, runtime);
        }

        public AttachSceneDefenseObjectResponse AttachSceneDefenseObjectWithOptions(AttachSceneDefenseObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachSceneDefenseObjectResponse>(DoRPCRequest("AttachSceneDefenseObject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachSceneDefenseObjectResponse> AttachSceneDefenseObjectWithOptionsAsync(AttachSceneDefenseObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachSceneDefenseObjectResponse>(await DoRPCRequestAsync("AttachSceneDefenseObject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachSceneDefenseObjectResponse AttachSceneDefenseObject(AttachSceneDefenseObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachSceneDefenseObjectWithOptions(request, runtime);
        }

        public async Task<AttachSceneDefenseObjectResponse> AttachSceneDefenseObjectAsync(AttachSceneDefenseObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachSceneDefenseObjectWithOptionsAsync(request, runtime);
        }

        public ConfigL7RsPolicyResponse ConfigL7RsPolicyWithOptions(ConfigL7RsPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigL7RsPolicyResponse>(DoRPCRequest("ConfigL7RsPolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigL7RsPolicyResponse> ConfigL7RsPolicyWithOptionsAsync(ConfigL7RsPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigL7RsPolicyResponse>(await DoRPCRequestAsync("ConfigL7RsPolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigL7RsPolicyResponse ConfigL7RsPolicy(ConfigL7RsPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigL7RsPolicyWithOptions(request, runtime);
        }

        public async Task<ConfigL7RsPolicyResponse> ConfigL7RsPolicyAsync(ConfigL7RsPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigL7RsPolicyWithOptionsAsync(request, runtime);
        }

        public ConfigNetworkRegionBlockResponse ConfigNetworkRegionBlockWithOptions(ConfigNetworkRegionBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigNetworkRegionBlockResponse>(DoRPCRequest("ConfigNetworkRegionBlock", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigNetworkRegionBlockResponse> ConfigNetworkRegionBlockWithOptionsAsync(ConfigNetworkRegionBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigNetworkRegionBlockResponse>(await DoRPCRequestAsync("ConfigNetworkRegionBlock", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigNetworkRegionBlockResponse ConfigNetworkRegionBlock(ConfigNetworkRegionBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigNetworkRegionBlockWithOptions(request, runtime);
        }

        public async Task<ConfigNetworkRegionBlockResponse> ConfigNetworkRegionBlockAsync(ConfigNetworkRegionBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigNetworkRegionBlockWithOptionsAsync(request, runtime);
        }

        public ConfigNetworkRulesResponse ConfigNetworkRulesWithOptions(ConfigNetworkRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigNetworkRulesResponse>(DoRPCRequest("ConfigNetworkRules", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigNetworkRulesResponse> ConfigNetworkRulesWithOptionsAsync(ConfigNetworkRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigNetworkRulesResponse>(await DoRPCRequestAsync("ConfigNetworkRules", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigNetworkRulesResponse ConfigNetworkRules(ConfigNetworkRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigNetworkRulesWithOptions(request, runtime);
        }

        public async Task<ConfigNetworkRulesResponse> ConfigNetworkRulesAsync(ConfigNetworkRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigNetworkRulesWithOptionsAsync(request, runtime);
        }

        public ConfigWebCCTemplateResponse ConfigWebCCTemplateWithOptions(ConfigWebCCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigWebCCTemplateResponse>(DoRPCRequest("ConfigWebCCTemplate", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigWebCCTemplateResponse> ConfigWebCCTemplateWithOptionsAsync(ConfigWebCCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigWebCCTemplateResponse>(await DoRPCRequestAsync("ConfigWebCCTemplate", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigWebCCTemplateResponse ConfigWebCCTemplate(ConfigWebCCTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigWebCCTemplateWithOptions(request, runtime);
        }

        public async Task<ConfigWebCCTemplateResponse> ConfigWebCCTemplateAsync(ConfigWebCCTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigWebCCTemplateWithOptionsAsync(request, runtime);
        }

        public ConfigWebIpSetResponse ConfigWebIpSetWithOptions(ConfigWebIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigWebIpSetResponse>(DoRPCRequest("ConfigWebIpSet", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigWebIpSetResponse> ConfigWebIpSetWithOptionsAsync(ConfigWebIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigWebIpSetResponse>(await DoRPCRequestAsync("ConfigWebIpSet", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigWebIpSetResponse ConfigWebIpSet(ConfigWebIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigWebIpSetWithOptions(request, runtime);
        }

        public async Task<ConfigWebIpSetResponse> ConfigWebIpSetAsync(ConfigWebIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigWebIpSetWithOptionsAsync(request, runtime);
        }

        public CreateAsyncTaskResponse CreateAsyncTaskWithOptions(CreateAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAsyncTaskResponse>(DoRPCRequest("CreateAsyncTask", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAsyncTaskResponse> CreateAsyncTaskWithOptionsAsync(CreateAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAsyncTaskResponse>(await DoRPCRequestAsync("CreateAsyncTask", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateNetworkRulesResponse CreateNetworkRulesWithOptions(CreateNetworkRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNetworkRulesResponse>(DoRPCRequest("CreateNetworkRules", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateNetworkRulesResponse> CreateNetworkRulesWithOptionsAsync(CreateNetworkRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNetworkRulesResponse>(await DoRPCRequestAsync("CreateNetworkRules", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateNetworkRulesResponse CreateNetworkRules(CreateNetworkRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNetworkRulesWithOptions(request, runtime);
        }

        public async Task<CreateNetworkRulesResponse> CreateNetworkRulesAsync(CreateNetworkRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNetworkRulesWithOptionsAsync(request, runtime);
        }

        public CreateSceneDefensePolicyResponse CreateSceneDefensePolicyWithOptions(CreateSceneDefensePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSceneDefensePolicyResponse>(DoRPCRequest("CreateSceneDefensePolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSceneDefensePolicyResponse> CreateSceneDefensePolicyWithOptionsAsync(CreateSceneDefensePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSceneDefensePolicyResponse>(await DoRPCRequestAsync("CreateSceneDefensePolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSceneDefensePolicyResponse CreateSceneDefensePolicy(CreateSceneDefensePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSceneDefensePolicyWithOptions(request, runtime);
        }

        public async Task<CreateSceneDefensePolicyResponse> CreateSceneDefensePolicyAsync(CreateSceneDefensePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSceneDefensePolicyWithOptionsAsync(request, runtime);
        }

        public CreateSchedulerRuleResponse CreateSchedulerRuleWithOptions(CreateSchedulerRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSchedulerRuleResponse>(DoRPCRequest("CreateSchedulerRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSchedulerRuleResponse> CreateSchedulerRuleWithOptionsAsync(CreateSchedulerRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSchedulerRuleResponse>(await DoRPCRequestAsync("CreateSchedulerRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSchedulerRuleResponse CreateSchedulerRule(CreateSchedulerRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSchedulerRuleWithOptions(request, runtime);
        }

        public async Task<CreateSchedulerRuleResponse> CreateSchedulerRuleAsync(CreateSchedulerRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSchedulerRuleWithOptionsAsync(request, runtime);
        }

        public CreateTagResourcesResponse CreateTagResourcesWithOptions(CreateTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTagResourcesResponse>(DoRPCRequest("CreateTagResources", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTagResourcesResponse> CreateTagResourcesWithOptionsAsync(CreateTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTagResourcesResponse>(await DoRPCRequestAsync("CreateTagResources", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTagResourcesResponse CreateTagResources(CreateTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTagResourcesWithOptions(request, runtime);
        }

        public async Task<CreateTagResourcesResponse> CreateTagResourcesAsync(CreateTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTagResourcesWithOptionsAsync(request, runtime);
        }

        public CreateWebCCRuleResponse CreateWebCCRuleWithOptions(CreateWebCCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWebCCRuleResponse>(DoRPCRequest("CreateWebCCRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateWebCCRuleResponse> CreateWebCCRuleWithOptionsAsync(CreateWebCCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWebCCRuleResponse>(await DoRPCRequestAsync("CreateWebCCRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateWebCCRuleResponse CreateWebCCRule(CreateWebCCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWebCCRuleWithOptions(request, runtime);
        }

        public async Task<CreateWebCCRuleResponse> CreateWebCCRuleAsync(CreateWebCCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWebCCRuleWithOptionsAsync(request, runtime);
        }

        public CreateWebRuleResponse CreateWebRuleWithOptions(CreateWebRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWebRuleResponse>(DoRPCRequest("CreateWebRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateWebRuleResponse> CreateWebRuleWithOptionsAsync(CreateWebRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWebRuleResponse>(await DoRPCRequestAsync("CreateWebRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateWebRuleResponse CreateWebRule(CreateWebRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWebRuleWithOptions(request, runtime);
        }

        public async Task<CreateWebRuleResponse> CreateWebRuleAsync(CreateWebRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWebRuleWithOptionsAsync(request, runtime);
        }

        public DeleteAsyncTaskResponse DeleteAsyncTaskWithOptions(DeleteAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAsyncTaskResponse>(DoRPCRequest("DeleteAsyncTask", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAsyncTaskResponse> DeleteAsyncTaskWithOptionsAsync(DeleteAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAsyncTaskResponse>(await DoRPCRequestAsync("DeleteAsyncTask", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteAutoCcBlacklistResponse DeleteAutoCcBlacklistWithOptions(DeleteAutoCcBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAutoCcBlacklistResponse>(DoRPCRequest("DeleteAutoCcBlacklist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAutoCcBlacklistResponse> DeleteAutoCcBlacklistWithOptionsAsync(DeleteAutoCcBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAutoCcBlacklistResponse>(await DoRPCRequestAsync("DeleteAutoCcBlacklist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAutoCcBlacklistResponse DeleteAutoCcBlacklist(DeleteAutoCcBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutoCcBlacklistWithOptions(request, runtime);
        }

        public async Task<DeleteAutoCcBlacklistResponse> DeleteAutoCcBlacklistAsync(DeleteAutoCcBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutoCcBlacklistWithOptionsAsync(request, runtime);
        }

        public DeleteAutoCcWhitelistResponse DeleteAutoCcWhitelistWithOptions(DeleteAutoCcWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAutoCcWhitelistResponse>(DoRPCRequest("DeleteAutoCcWhitelist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAutoCcWhitelistResponse> DeleteAutoCcWhitelistWithOptionsAsync(DeleteAutoCcWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAutoCcWhitelistResponse>(await DoRPCRequestAsync("DeleteAutoCcWhitelist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAutoCcWhitelistResponse DeleteAutoCcWhitelist(DeleteAutoCcWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutoCcWhitelistWithOptions(request, runtime);
        }

        public async Task<DeleteAutoCcWhitelistResponse> DeleteAutoCcWhitelistAsync(DeleteAutoCcWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutoCcWhitelistWithOptionsAsync(request, runtime);
        }

        public DeleteNetworkRuleResponse DeleteNetworkRuleWithOptions(DeleteNetworkRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNetworkRuleResponse>(DoRPCRequest("DeleteNetworkRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNetworkRuleResponse> DeleteNetworkRuleWithOptionsAsync(DeleteNetworkRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNetworkRuleResponse>(await DoRPCRequestAsync("DeleteNetworkRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNetworkRuleResponse DeleteNetworkRule(DeleteNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNetworkRuleWithOptions(request, runtime);
        }

        public async Task<DeleteNetworkRuleResponse> DeleteNetworkRuleAsync(DeleteNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNetworkRuleWithOptionsAsync(request, runtime);
        }

        public DeleteSceneDefensePolicyResponse DeleteSceneDefensePolicyWithOptions(DeleteSceneDefensePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSceneDefensePolicyResponse>(DoRPCRequest("DeleteSceneDefensePolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSceneDefensePolicyResponse> DeleteSceneDefensePolicyWithOptionsAsync(DeleteSceneDefensePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSceneDefensePolicyResponse>(await DoRPCRequestAsync("DeleteSceneDefensePolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSceneDefensePolicyResponse DeleteSceneDefensePolicy(DeleteSceneDefensePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSceneDefensePolicyWithOptions(request, runtime);
        }

        public async Task<DeleteSceneDefensePolicyResponse> DeleteSceneDefensePolicyAsync(DeleteSceneDefensePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSceneDefensePolicyWithOptionsAsync(request, runtime);
        }

        public DeleteSchedulerRuleResponse DeleteSchedulerRuleWithOptions(DeleteSchedulerRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSchedulerRuleResponse>(DoRPCRequest("DeleteSchedulerRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSchedulerRuleResponse> DeleteSchedulerRuleWithOptionsAsync(DeleteSchedulerRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSchedulerRuleResponse>(await DoRPCRequestAsync("DeleteSchedulerRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSchedulerRuleResponse DeleteSchedulerRule(DeleteSchedulerRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSchedulerRuleWithOptions(request, runtime);
        }

        public async Task<DeleteSchedulerRuleResponse> DeleteSchedulerRuleAsync(DeleteSchedulerRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSchedulerRuleWithOptionsAsync(request, runtime);
        }

        public DeleteTagResourcesResponse DeleteTagResourcesWithOptions(DeleteTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTagResourcesResponse>(DoRPCRequest("DeleteTagResources", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTagResourcesResponse> DeleteTagResourcesWithOptionsAsync(DeleteTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTagResourcesResponse>(await DoRPCRequestAsync("DeleteTagResources", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTagResourcesResponse DeleteTagResources(DeleteTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTagResourcesWithOptions(request, runtime);
        }

        public async Task<DeleteTagResourcesResponse> DeleteTagResourcesAsync(DeleteTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTagResourcesWithOptionsAsync(request, runtime);
        }

        public DeleteWebCacheCustomRuleResponse DeleteWebCacheCustomRuleWithOptions(DeleteWebCacheCustomRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWebCacheCustomRuleResponse>(DoRPCRequest("DeleteWebCacheCustomRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteWebCacheCustomRuleResponse> DeleteWebCacheCustomRuleWithOptionsAsync(DeleteWebCacheCustomRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWebCacheCustomRuleResponse>(await DoRPCRequestAsync("DeleteWebCacheCustomRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteWebCacheCustomRuleResponse DeleteWebCacheCustomRule(DeleteWebCacheCustomRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWebCacheCustomRuleWithOptions(request, runtime);
        }

        public async Task<DeleteWebCacheCustomRuleResponse> DeleteWebCacheCustomRuleAsync(DeleteWebCacheCustomRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWebCacheCustomRuleWithOptionsAsync(request, runtime);
        }

        public DeleteWebCCRuleResponse DeleteWebCCRuleWithOptions(DeleteWebCCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWebCCRuleResponse>(DoRPCRequest("DeleteWebCCRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteWebCCRuleResponse> DeleteWebCCRuleWithOptionsAsync(DeleteWebCCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWebCCRuleResponse>(await DoRPCRequestAsync("DeleteWebCCRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteWebCCRuleResponse DeleteWebCCRule(DeleteWebCCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWebCCRuleWithOptions(request, runtime);
        }

        public async Task<DeleteWebCCRuleResponse> DeleteWebCCRuleAsync(DeleteWebCCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWebCCRuleWithOptionsAsync(request, runtime);
        }

        public DeleteWebPreciseAccessRuleResponse DeleteWebPreciseAccessRuleWithOptions(DeleteWebPreciseAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWebPreciseAccessRuleResponse>(DoRPCRequest("DeleteWebPreciseAccessRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteWebPreciseAccessRuleResponse> DeleteWebPreciseAccessRuleWithOptionsAsync(DeleteWebPreciseAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWebPreciseAccessRuleResponse>(await DoRPCRequestAsync("DeleteWebPreciseAccessRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteWebPreciseAccessRuleResponse DeleteWebPreciseAccessRule(DeleteWebPreciseAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWebPreciseAccessRuleWithOptions(request, runtime);
        }

        public async Task<DeleteWebPreciseAccessRuleResponse> DeleteWebPreciseAccessRuleAsync(DeleteWebPreciseAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWebPreciseAccessRuleWithOptionsAsync(request, runtime);
        }

        public DeleteWebRuleResponse DeleteWebRuleWithOptions(DeleteWebRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWebRuleResponse>(DoRPCRequest("DeleteWebRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteWebRuleResponse> DeleteWebRuleWithOptionsAsync(DeleteWebRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWebRuleResponse>(await DoRPCRequestAsync("DeleteWebRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteWebRuleResponse DeleteWebRule(DeleteWebRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWebRuleWithOptions(request, runtime);
        }

        public async Task<DeleteWebRuleResponse> DeleteWebRuleAsync(DeleteWebRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWebRuleWithOptionsAsync(request, runtime);
        }

        public DescribeAsyncTasksResponse DescribeAsyncTasksWithOptions(DescribeAsyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAsyncTasksResponse>(DoRPCRequest("DescribeAsyncTasks", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAsyncTasksResponse> DescribeAsyncTasksWithOptionsAsync(DescribeAsyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAsyncTasksResponse>(await DoRPCRequestAsync("DescribeAsyncTasks", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAsyncTasksResponse DescribeAsyncTasks(DescribeAsyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAsyncTasksWithOptions(request, runtime);
        }

        public async Task<DescribeAsyncTasksResponse> DescribeAsyncTasksAsync(DescribeAsyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAsyncTasksWithOptionsAsync(request, runtime);
        }

        public DescribeAutoCcBlacklistResponse DescribeAutoCcBlacklistWithOptions(DescribeAutoCcBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoCcBlacklistResponse>(DoRPCRequest("DescribeAutoCcBlacklist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAutoCcBlacklistResponse> DescribeAutoCcBlacklistWithOptionsAsync(DescribeAutoCcBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoCcBlacklistResponse>(await DoRPCRequestAsync("DescribeAutoCcBlacklist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAutoCcBlacklistResponse DescribeAutoCcBlacklist(DescribeAutoCcBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoCcBlacklistWithOptions(request, runtime);
        }

        public async Task<DescribeAutoCcBlacklistResponse> DescribeAutoCcBlacklistAsync(DescribeAutoCcBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoCcBlacklistWithOptionsAsync(request, runtime);
        }

        public DescribeAutoCcListCountResponse DescribeAutoCcListCountWithOptions(DescribeAutoCcListCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoCcListCountResponse>(DoRPCRequest("DescribeAutoCcListCount", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAutoCcListCountResponse> DescribeAutoCcListCountWithOptionsAsync(DescribeAutoCcListCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoCcListCountResponse>(await DoRPCRequestAsync("DescribeAutoCcListCount", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAutoCcListCountResponse DescribeAutoCcListCount(DescribeAutoCcListCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoCcListCountWithOptions(request, runtime);
        }

        public async Task<DescribeAutoCcListCountResponse> DescribeAutoCcListCountAsync(DescribeAutoCcListCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoCcListCountWithOptionsAsync(request, runtime);
        }

        public DescribeAutoCcWhitelistResponse DescribeAutoCcWhitelistWithOptions(DescribeAutoCcWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoCcWhitelistResponse>(DoRPCRequest("DescribeAutoCcWhitelist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAutoCcWhitelistResponse> DescribeAutoCcWhitelistWithOptionsAsync(DescribeAutoCcWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoCcWhitelistResponse>(await DoRPCRequestAsync("DescribeAutoCcWhitelist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAutoCcWhitelistResponse DescribeAutoCcWhitelist(DescribeAutoCcWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoCcWhitelistWithOptions(request, runtime);
        }

        public async Task<DescribeAutoCcWhitelistResponse> DescribeAutoCcWhitelistAsync(DescribeAutoCcWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoCcWhitelistWithOptionsAsync(request, runtime);
        }

        public DescribeBackSourceCidrResponse DescribeBackSourceCidrWithOptions(DescribeBackSourceCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackSourceCidrResponse>(DoRPCRequest("DescribeBackSourceCidr", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackSourceCidrResponse> DescribeBackSourceCidrWithOptionsAsync(DescribeBackSourceCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackSourceCidrResponse>(await DoRPCRequestAsync("DescribeBackSourceCidr", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeBlackholeStatusResponse DescribeBlackholeStatusWithOptions(DescribeBlackholeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBlackholeStatusResponse>(DoRPCRequest("DescribeBlackholeStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBlackholeStatusResponse> DescribeBlackholeStatusWithOptionsAsync(DescribeBlackholeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBlackholeStatusResponse>(await DoRPCRequestAsync("DescribeBlackholeStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBlackholeStatusResponse DescribeBlackholeStatus(DescribeBlackholeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBlackholeStatusWithOptions(request, runtime);
        }

        public async Task<DescribeBlackholeStatusResponse> DescribeBlackholeStatusAsync(DescribeBlackholeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBlackholeStatusWithOptionsAsync(request, runtime);
        }

        public DescribeBlockStatusResponse DescribeBlockStatusWithOptions(DescribeBlockStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBlockStatusResponse>(DoRPCRequest("DescribeBlockStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBlockStatusResponse> DescribeBlockStatusWithOptionsAsync(DescribeBlockStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBlockStatusResponse>(await DoRPCRequestAsync("DescribeBlockStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBlockStatusResponse DescribeBlockStatus(DescribeBlockStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBlockStatusWithOptions(request, runtime);
        }

        public async Task<DescribeBlockStatusResponse> DescribeBlockStatusAsync(DescribeBlockStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBlockStatusWithOptionsAsync(request, runtime);
        }

        public DescribeCertsResponse DescribeCertsWithOptions(DescribeCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCertsResponse>(DoRPCRequest("DescribeCerts", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCertsResponse> DescribeCertsWithOptionsAsync(DescribeCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCertsResponse>(await DoRPCRequestAsync("DescribeCerts", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCertsResponse DescribeCerts(DescribeCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertsWithOptions(request, runtime);
        }

        public async Task<DescribeCertsResponse> DescribeCertsAsync(DescribeCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertsWithOptionsAsync(request, runtime);
        }

        public DescribeCnameReusesResponse DescribeCnameReusesWithOptions(DescribeCnameReusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCnameReusesResponse>(DoRPCRequest("DescribeCnameReuses", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCnameReusesResponse> DescribeCnameReusesWithOptionsAsync(DescribeCnameReusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCnameReusesResponse>(await DoRPCRequestAsync("DescribeCnameReuses", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCnameReusesResponse DescribeCnameReuses(DescribeCnameReusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCnameReusesWithOptions(request, runtime);
        }

        public async Task<DescribeCnameReusesResponse> DescribeCnameReusesAsync(DescribeCnameReusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCnameReusesWithOptionsAsync(request, runtime);
        }

        public DescribeDDosAllEventListResponse DescribeDDosAllEventListWithOptions(DescribeDDosAllEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDosAllEventListResponse>(DoRPCRequest("DescribeDDosAllEventList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDDosAllEventListResponse> DescribeDDosAllEventListWithOptionsAsync(DescribeDDosAllEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDosAllEventListResponse>(await DoRPCRequestAsync("DescribeDDosAllEventList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDDosAllEventListResponse DescribeDDosAllEventList(DescribeDDosAllEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDDosAllEventListWithOptions(request, runtime);
        }

        public async Task<DescribeDDosAllEventListResponse> DescribeDDosAllEventListAsync(DescribeDDosAllEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDDosAllEventListWithOptionsAsync(request, runtime);
        }

        public DescribeDDosEventAreaResponse DescribeDDosEventAreaWithOptions(DescribeDDosEventAreaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDosEventAreaResponse>(DoRPCRequest("DescribeDDosEventArea", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDDosEventAreaResponse> DescribeDDosEventAreaWithOptionsAsync(DescribeDDosEventAreaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDosEventAreaResponse>(await DoRPCRequestAsync("DescribeDDosEventArea", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDDosEventAreaResponse DescribeDDosEventArea(DescribeDDosEventAreaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDDosEventAreaWithOptions(request, runtime);
        }

        public async Task<DescribeDDosEventAreaResponse> DescribeDDosEventAreaAsync(DescribeDDosEventAreaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDDosEventAreaWithOptionsAsync(request, runtime);
        }

        public DescribeDDosEventAttackTypeResponse DescribeDDosEventAttackTypeWithOptions(DescribeDDosEventAttackTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDosEventAttackTypeResponse>(DoRPCRequest("DescribeDDosEventAttackType", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDDosEventAttackTypeResponse> DescribeDDosEventAttackTypeWithOptionsAsync(DescribeDDosEventAttackTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDosEventAttackTypeResponse>(await DoRPCRequestAsync("DescribeDDosEventAttackType", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDDosEventAttackTypeResponse DescribeDDosEventAttackType(DescribeDDosEventAttackTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDDosEventAttackTypeWithOptions(request, runtime);
        }

        public async Task<DescribeDDosEventAttackTypeResponse> DescribeDDosEventAttackTypeAsync(DescribeDDosEventAttackTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDDosEventAttackTypeWithOptionsAsync(request, runtime);
        }

        public DescribeDDosEventIspResponse DescribeDDosEventIspWithOptions(DescribeDDosEventIspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDosEventIspResponse>(DoRPCRequest("DescribeDDosEventIsp", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDDosEventIspResponse> DescribeDDosEventIspWithOptionsAsync(DescribeDDosEventIspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDosEventIspResponse>(await DoRPCRequestAsync("DescribeDDosEventIsp", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDDosEventIspResponse DescribeDDosEventIsp(DescribeDDosEventIspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDDosEventIspWithOptions(request, runtime);
        }

        public async Task<DescribeDDosEventIspResponse> DescribeDDosEventIspAsync(DescribeDDosEventIspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDDosEventIspWithOptionsAsync(request, runtime);
        }

        public DescribeDDosEventMaxResponse DescribeDDosEventMaxWithOptions(DescribeDDosEventMaxRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDosEventMaxResponse>(DoRPCRequest("DescribeDDosEventMax", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDDosEventMaxResponse> DescribeDDosEventMaxWithOptionsAsync(DescribeDDosEventMaxRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDosEventMaxResponse>(await DoRPCRequestAsync("DescribeDDosEventMax", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDDosEventMaxResponse DescribeDDosEventMax(DescribeDDosEventMaxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDDosEventMaxWithOptions(request, runtime);
        }

        public async Task<DescribeDDosEventMaxResponse> DescribeDDosEventMaxAsync(DescribeDDosEventMaxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDDosEventMaxWithOptionsAsync(request, runtime);
        }

        public DescribeDDoSEventsResponse DescribeDDoSEventsWithOptions(DescribeDDoSEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDoSEventsResponse>(DoRPCRequest("DescribeDDoSEvents", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDDoSEventsResponse> DescribeDDoSEventsWithOptionsAsync(DescribeDDoSEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDoSEventsResponse>(await DoRPCRequestAsync("DescribeDDoSEvents", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDDosEventSrcIpResponse DescribeDDosEventSrcIpWithOptions(DescribeDDosEventSrcIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDosEventSrcIpResponse>(DoRPCRequest("DescribeDDosEventSrcIp", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDDosEventSrcIpResponse> DescribeDDosEventSrcIpWithOptionsAsync(DescribeDDosEventSrcIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDDosEventSrcIpResponse>(await DoRPCRequestAsync("DescribeDDosEventSrcIp", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDDosEventSrcIpResponse DescribeDDosEventSrcIp(DescribeDDosEventSrcIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDDosEventSrcIpWithOptions(request, runtime);
        }

        public async Task<DescribeDDosEventSrcIpResponse> DescribeDDosEventSrcIpAsync(DescribeDDosEventSrcIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDDosEventSrcIpWithOptionsAsync(request, runtime);
        }

        public DescribeDefenseCountStatisticsResponse DescribeDefenseCountStatisticsWithOptions(DescribeDefenseCountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDefenseCountStatisticsResponse>(DoRPCRequest("DescribeDefenseCountStatistics", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDefenseCountStatisticsResponse> DescribeDefenseCountStatisticsWithOptionsAsync(DescribeDefenseCountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDefenseCountStatisticsResponse>(await DoRPCRequestAsync("DescribeDefenseCountStatistics", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDefenseRecordsResponse DescribeDefenseRecordsWithOptions(DescribeDefenseRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDefenseRecordsResponse>(DoRPCRequest("DescribeDefenseRecords", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDefenseRecordsResponse> DescribeDefenseRecordsWithOptionsAsync(DescribeDefenseRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDefenseRecordsResponse>(await DoRPCRequestAsync("DescribeDefenseRecords", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDefenseRecordsResponse DescribeDefenseRecords(DescribeDefenseRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeDefenseRecordsResponse> DescribeDefenseRecordsAsync(DescribeDefenseRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeDomainAttackEventsResponse DescribeDomainAttackEventsWithOptions(DescribeDomainAttackEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainAttackEventsResponse>(DoRPCRequest("DescribeDomainAttackEvents", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainAttackEventsResponse> DescribeDomainAttackEventsWithOptionsAsync(DescribeDomainAttackEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainAttackEventsResponse>(await DoRPCRequestAsync("DescribeDomainAttackEvents", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDomainOverviewResponse DescribeDomainOverviewWithOptions(DescribeDomainOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainOverviewResponse>(DoRPCRequest("DescribeDomainOverview", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainOverviewResponse> DescribeDomainOverviewWithOptionsAsync(DescribeDomainOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainOverviewResponse>(await DoRPCRequestAsync("DescribeDomainOverview", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainOverviewResponse DescribeDomainOverview(DescribeDomainOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainOverviewWithOptions(request, runtime);
        }

        public async Task<DescribeDomainOverviewResponse> DescribeDomainOverviewAsync(DescribeDomainOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainOverviewWithOptionsAsync(request, runtime);
        }

        public DescribeDomainQPSListResponse DescribeDomainQPSListWithOptions(DescribeDomainQPSListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainQPSListResponse>(DoRPCRequest("DescribeDomainQPSList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainQPSListResponse> DescribeDomainQPSListWithOptionsAsync(DescribeDomainQPSListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainQPSListResponse>(await DoRPCRequestAsync("DescribeDomainQPSList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainQPSListResponse DescribeDomainQPSList(DescribeDomainQPSListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainQPSListWithOptions(request, runtime);
        }

        public async Task<DescribeDomainQPSListResponse> DescribeDomainQPSListAsync(DescribeDomainQPSListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainQPSListWithOptionsAsync(request, runtime);
        }

        public DescribeDomainQpsWithCacheResponse DescribeDomainQpsWithCacheWithOptions(DescribeDomainQpsWithCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainQpsWithCacheResponse>(DoRPCRequest("DescribeDomainQpsWithCache", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainQpsWithCacheResponse> DescribeDomainQpsWithCacheWithOptionsAsync(DescribeDomainQpsWithCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainQpsWithCacheResponse>(await DoRPCRequestAsync("DescribeDomainQpsWithCache", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeDomainsResponse>(DoRPCRequest("DescribeDomains", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainsResponse> DescribeDomainsWithOptionsAsync(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainsResponse>(await DoRPCRequestAsync("DescribeDomains", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDomainStatusCodeCountResponse DescribeDomainStatusCodeCountWithOptions(DescribeDomainStatusCodeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainStatusCodeCountResponse>(DoRPCRequest("DescribeDomainStatusCodeCount", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainStatusCodeCountResponse> DescribeDomainStatusCodeCountWithOptionsAsync(DescribeDomainStatusCodeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainStatusCodeCountResponse>(await DoRPCRequestAsync("DescribeDomainStatusCodeCount", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainStatusCodeCountResponse DescribeDomainStatusCodeCount(DescribeDomainStatusCodeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainStatusCodeCountWithOptions(request, runtime);
        }

        public async Task<DescribeDomainStatusCodeCountResponse> DescribeDomainStatusCodeCountAsync(DescribeDomainStatusCodeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainStatusCodeCountWithOptionsAsync(request, runtime);
        }

        public DescribeDomainStatusCodeListResponse DescribeDomainStatusCodeListWithOptions(DescribeDomainStatusCodeListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainStatusCodeListResponse>(DoRPCRequest("DescribeDomainStatusCodeList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainStatusCodeListResponse> DescribeDomainStatusCodeListWithOptionsAsync(DescribeDomainStatusCodeListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainStatusCodeListResponse>(await DoRPCRequestAsync("DescribeDomainStatusCodeList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainStatusCodeListResponse DescribeDomainStatusCodeList(DescribeDomainStatusCodeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainStatusCodeListWithOptions(request, runtime);
        }

        public async Task<DescribeDomainStatusCodeListResponse> DescribeDomainStatusCodeListAsync(DescribeDomainStatusCodeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainStatusCodeListWithOptionsAsync(request, runtime);
        }

        public DescribeDomainTopAttackListResponse DescribeDomainTopAttackListWithOptions(DescribeDomainTopAttackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainTopAttackListResponse>(DoRPCRequest("DescribeDomainTopAttackList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainTopAttackListResponse> DescribeDomainTopAttackListWithOptionsAsync(DescribeDomainTopAttackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainTopAttackListResponse>(await DoRPCRequestAsync("DescribeDomainTopAttackList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainTopAttackListResponse DescribeDomainTopAttackList(DescribeDomainTopAttackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainTopAttackListWithOptions(request, runtime);
        }

        public async Task<DescribeDomainTopAttackListResponse> DescribeDomainTopAttackListAsync(DescribeDomainTopAttackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainTopAttackListWithOptionsAsync(request, runtime);
        }

        public DescribeDomainViewSourceCountriesResponse DescribeDomainViewSourceCountriesWithOptions(DescribeDomainViewSourceCountriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainViewSourceCountriesResponse>(DoRPCRequest("DescribeDomainViewSourceCountries", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainViewSourceCountriesResponse> DescribeDomainViewSourceCountriesWithOptionsAsync(DescribeDomainViewSourceCountriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainViewSourceCountriesResponse>(await DoRPCRequestAsync("DescribeDomainViewSourceCountries", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainViewSourceCountriesResponse DescribeDomainViewSourceCountries(DescribeDomainViewSourceCountriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainViewSourceCountriesWithOptions(request, runtime);
        }

        public async Task<DescribeDomainViewSourceCountriesResponse> DescribeDomainViewSourceCountriesAsync(DescribeDomainViewSourceCountriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainViewSourceCountriesWithOptionsAsync(request, runtime);
        }

        public DescribeDomainViewSourceProvincesResponse DescribeDomainViewSourceProvincesWithOptions(DescribeDomainViewSourceProvincesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainViewSourceProvincesResponse>(DoRPCRequest("DescribeDomainViewSourceProvinces", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainViewSourceProvincesResponse> DescribeDomainViewSourceProvincesWithOptionsAsync(DescribeDomainViewSourceProvincesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainViewSourceProvincesResponse>(await DoRPCRequestAsync("DescribeDomainViewSourceProvinces", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainViewSourceProvincesResponse DescribeDomainViewSourceProvinces(DescribeDomainViewSourceProvincesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainViewSourceProvincesWithOptions(request, runtime);
        }

        public async Task<DescribeDomainViewSourceProvincesResponse> DescribeDomainViewSourceProvincesAsync(DescribeDomainViewSourceProvincesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainViewSourceProvincesWithOptionsAsync(request, runtime);
        }

        public DescribeDomainViewTopCostTimeResponse DescribeDomainViewTopCostTimeWithOptions(DescribeDomainViewTopCostTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainViewTopCostTimeResponse>(DoRPCRequest("DescribeDomainViewTopCostTime", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainViewTopCostTimeResponse> DescribeDomainViewTopCostTimeWithOptionsAsync(DescribeDomainViewTopCostTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainViewTopCostTimeResponse>(await DoRPCRequestAsync("DescribeDomainViewTopCostTime", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainViewTopCostTimeResponse DescribeDomainViewTopCostTime(DescribeDomainViewTopCostTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainViewTopCostTimeWithOptions(request, runtime);
        }

        public async Task<DescribeDomainViewTopCostTimeResponse> DescribeDomainViewTopCostTimeAsync(DescribeDomainViewTopCostTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainViewTopCostTimeWithOptionsAsync(request, runtime);
        }

        public DescribeDomainViewTopUrlResponse DescribeDomainViewTopUrlWithOptions(DescribeDomainViewTopUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainViewTopUrlResponse>(DoRPCRequest("DescribeDomainViewTopUrl", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainViewTopUrlResponse> DescribeDomainViewTopUrlWithOptionsAsync(DescribeDomainViewTopUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainViewTopUrlResponse>(await DoRPCRequestAsync("DescribeDomainViewTopUrl", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainViewTopUrlResponse DescribeDomainViewTopUrl(DescribeDomainViewTopUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainViewTopUrlWithOptions(request, runtime);
        }

        public async Task<DescribeDomainViewTopUrlResponse> DescribeDomainViewTopUrlAsync(DescribeDomainViewTopUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainViewTopUrlWithOptionsAsync(request, runtime);
        }

        public DescribeElasticBandwidthSpecResponse DescribeElasticBandwidthSpecWithOptions(DescribeElasticBandwidthSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeElasticBandwidthSpecResponse>(DoRPCRequest("DescribeElasticBandwidthSpec", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeElasticBandwidthSpecResponse> DescribeElasticBandwidthSpecWithOptionsAsync(DescribeElasticBandwidthSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeElasticBandwidthSpecResponse>(await DoRPCRequestAsync("DescribeElasticBandwidthSpec", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeHealthCheckListResponse>(DoRPCRequest("DescribeHealthCheckList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHealthCheckListResponse> DescribeHealthCheckListWithOptionsAsync(DescribeHealthCheckListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthCheckListResponse>(await DoRPCRequestAsync("DescribeHealthCheckList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeHealthCheckStatusResponse DescribeHealthCheckStatusWithOptions(DescribeHealthCheckStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthCheckStatusResponse>(DoRPCRequest("DescribeHealthCheckStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHealthCheckStatusResponse> DescribeHealthCheckStatusWithOptionsAsync(DescribeHealthCheckStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthCheckStatusResponse>(await DoRPCRequestAsync("DescribeHealthCheckStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHealthCheckStatusResponse DescribeHealthCheckStatus(DescribeHealthCheckStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHealthCheckStatusWithOptions(request, runtime);
        }

        public async Task<DescribeHealthCheckStatusResponse> DescribeHealthCheckStatusAsync(DescribeHealthCheckStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHealthCheckStatusWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceDetailsResponse DescribeInstanceDetailsWithOptions(DescribeInstanceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceDetailsResponse>(DoRPCRequest("DescribeInstanceDetails", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceDetailsResponse> DescribeInstanceDetailsWithOptionsAsync(DescribeInstanceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceDetailsResponse>(await DoRPCRequestAsync("DescribeInstanceDetails", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeInstanceIdsResponse DescribeInstanceIdsWithOptions(DescribeInstanceIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceIdsResponse>(DoRPCRequest("DescribeInstanceIds", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceIdsResponse> DescribeInstanceIdsWithOptionsAsync(DescribeInstanceIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceIdsResponse>(await DoRPCRequestAsync("DescribeInstanceIds", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceIdsResponse DescribeInstanceIds(DescribeInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceIdsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceIdsResponse> DescribeInstanceIdsAsync(DescribeInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceIdsWithOptionsAsync(request, runtime);
        }

        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(DoRPCRequest("DescribeInstances", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await DoRPCRequestAsync("DescribeInstances", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeInstanceSpecsResponse>(DoRPCRequest("DescribeInstanceSpecs", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceSpecsResponse> DescribeInstanceSpecsWithOptionsAsync(DescribeInstanceSpecsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSpecsResponse>(await DoRPCRequestAsync("DescribeInstanceSpecs", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeInstanceStatisticsResponse>(DoRPCRequest("DescribeInstanceStatistics", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceStatisticsResponse> DescribeInstanceStatisticsWithOptionsAsync(DescribeInstanceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceStatisticsResponse>(await DoRPCRequestAsync("DescribeInstanceStatistics", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeInstanceStatusResponse DescribeInstanceStatusWithOptions(DescribeInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceStatusResponse>(DoRPCRequest("DescribeInstanceStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceStatusResponse> DescribeInstanceStatusWithOptionsAsync(DescribeInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceStatusResponse>(await DoRPCRequestAsync("DescribeInstanceStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceStatusWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(DescribeInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceStatusWithOptionsAsync(request, runtime);
        }

        public DescribeL7RsPolicyResponse DescribeL7RsPolicyWithOptions(DescribeL7RsPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeL7RsPolicyResponse>(DoRPCRequest("DescribeL7RsPolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeL7RsPolicyResponse> DescribeL7RsPolicyWithOptionsAsync(DescribeL7RsPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeL7RsPolicyResponse>(await DoRPCRequestAsync("DescribeL7RsPolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeL7RsPolicyResponse DescribeL7RsPolicy(DescribeL7RsPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeL7RsPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeL7RsPolicyResponse> DescribeL7RsPolicyAsync(DescribeL7RsPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeL7RsPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeLogStoreExistStatusResponse DescribeLogStoreExistStatusWithOptions(DescribeLogStoreExistStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogStoreExistStatusResponse>(DoRPCRequest("DescribeLogStoreExistStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLogStoreExistStatusResponse> DescribeLogStoreExistStatusWithOptionsAsync(DescribeLogStoreExistStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogStoreExistStatusResponse>(await DoRPCRequestAsync("DescribeLogStoreExistStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeNetworkRegionBlockResponse DescribeNetworkRegionBlockWithOptions(DescribeNetworkRegionBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkRegionBlockResponse>(DoRPCRequest("DescribeNetworkRegionBlock", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNetworkRegionBlockResponse> DescribeNetworkRegionBlockWithOptionsAsync(DescribeNetworkRegionBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkRegionBlockResponse>(await DoRPCRequestAsync("DescribeNetworkRegionBlock", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNetworkRegionBlockResponse DescribeNetworkRegionBlock(DescribeNetworkRegionBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNetworkRegionBlockWithOptions(request, runtime);
        }

        public async Task<DescribeNetworkRegionBlockResponse> DescribeNetworkRegionBlockAsync(DescribeNetworkRegionBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNetworkRegionBlockWithOptionsAsync(request, runtime);
        }

        public DescribeNetworkRuleAttributesResponse DescribeNetworkRuleAttributesWithOptions(DescribeNetworkRuleAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkRuleAttributesResponse>(DoRPCRequest("DescribeNetworkRuleAttributes", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNetworkRuleAttributesResponse> DescribeNetworkRuleAttributesWithOptionsAsync(DescribeNetworkRuleAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkRuleAttributesResponse>(await DoRPCRequestAsync("DescribeNetworkRuleAttributes", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNetworkRuleAttributesResponse DescribeNetworkRuleAttributes(DescribeNetworkRuleAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNetworkRuleAttributesWithOptions(request, runtime);
        }

        public async Task<DescribeNetworkRuleAttributesResponse> DescribeNetworkRuleAttributesAsync(DescribeNetworkRuleAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNetworkRuleAttributesWithOptionsAsync(request, runtime);
        }

        public DescribeNetworkRulesResponse DescribeNetworkRulesWithOptions(DescribeNetworkRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkRulesResponse>(DoRPCRequest("DescribeNetworkRules", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNetworkRulesResponse> DescribeNetworkRulesWithOptionsAsync(DescribeNetworkRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkRulesResponse>(await DoRPCRequestAsync("DescribeNetworkRules", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNetworkRulesResponse DescribeNetworkRules(DescribeNetworkRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNetworkRulesWithOptions(request, runtime);
        }

        public async Task<DescribeNetworkRulesResponse> DescribeNetworkRulesAsync(DescribeNetworkRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNetworkRulesWithOptionsAsync(request, runtime);
        }

        public DescribeOpEntitiesResponse DescribeOpEntitiesWithOptions(DescribeOpEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOpEntitiesResponse>(DoRPCRequest("DescribeOpEntities", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeOpEntitiesResponse> DescribeOpEntitiesWithOptionsAsync(DescribeOpEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOpEntitiesResponse>(await DoRPCRequestAsync("DescribeOpEntities", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribePortAttackMaxFlowResponse DescribePortAttackMaxFlowWithOptions(DescribePortAttackMaxFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortAttackMaxFlowResponse>(DoRPCRequest("DescribePortAttackMaxFlow", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePortAttackMaxFlowResponse> DescribePortAttackMaxFlowWithOptionsAsync(DescribePortAttackMaxFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortAttackMaxFlowResponse>(await DoRPCRequestAsync("DescribePortAttackMaxFlow", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePortAttackMaxFlowResponse DescribePortAttackMaxFlow(DescribePortAttackMaxFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePortAttackMaxFlowWithOptions(request, runtime);
        }

        public async Task<DescribePortAttackMaxFlowResponse> DescribePortAttackMaxFlowAsync(DescribePortAttackMaxFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePortAttackMaxFlowWithOptionsAsync(request, runtime);
        }

        public DescribePortAutoCcStatusResponse DescribePortAutoCcStatusWithOptions(DescribePortAutoCcStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortAutoCcStatusResponse>(DoRPCRequest("DescribePortAutoCcStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePortAutoCcStatusResponse> DescribePortAutoCcStatusWithOptionsAsync(DescribePortAutoCcStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortAutoCcStatusResponse>(await DoRPCRequestAsync("DescribePortAutoCcStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePortAutoCcStatusResponse DescribePortAutoCcStatus(DescribePortAutoCcStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePortAutoCcStatusWithOptions(request, runtime);
        }

        public async Task<DescribePortAutoCcStatusResponse> DescribePortAutoCcStatusAsync(DescribePortAutoCcStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePortAutoCcStatusWithOptionsAsync(request, runtime);
        }

        public DescribePortConnsCountResponse DescribePortConnsCountWithOptions(DescribePortConnsCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortConnsCountResponse>(DoRPCRequest("DescribePortConnsCount", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePortConnsCountResponse> DescribePortConnsCountWithOptionsAsync(DescribePortConnsCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortConnsCountResponse>(await DoRPCRequestAsync("DescribePortConnsCount", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePortConnsCountResponse DescribePortConnsCount(DescribePortConnsCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePortConnsCountWithOptions(request, runtime);
        }

        public async Task<DescribePortConnsCountResponse> DescribePortConnsCountAsync(DescribePortConnsCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePortConnsCountWithOptionsAsync(request, runtime);
        }

        public DescribePortConnsListResponse DescribePortConnsListWithOptions(DescribePortConnsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortConnsListResponse>(DoRPCRequest("DescribePortConnsList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePortConnsListResponse> DescribePortConnsListWithOptionsAsync(DescribePortConnsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortConnsListResponse>(await DoRPCRequestAsync("DescribePortConnsList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePortConnsListResponse DescribePortConnsList(DescribePortConnsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePortConnsListWithOptions(request, runtime);
        }

        public async Task<DescribePortConnsListResponse> DescribePortConnsListAsync(DescribePortConnsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePortConnsListWithOptionsAsync(request, runtime);
        }

        public DescribePortFlowListResponse DescribePortFlowListWithOptions(DescribePortFlowListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortFlowListResponse>(DoRPCRequest("DescribePortFlowList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePortFlowListResponse> DescribePortFlowListWithOptionsAsync(DescribePortFlowListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortFlowListResponse>(await DoRPCRequestAsync("DescribePortFlowList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePortFlowListResponse DescribePortFlowList(DescribePortFlowListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePortFlowListWithOptions(request, runtime);
        }

        public async Task<DescribePortFlowListResponse> DescribePortFlowListAsync(DescribePortFlowListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePortFlowListWithOptionsAsync(request, runtime);
        }

        public DescribePortMaxConnsResponse DescribePortMaxConnsWithOptions(DescribePortMaxConnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortMaxConnsResponse>(DoRPCRequest("DescribePortMaxConns", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePortMaxConnsResponse> DescribePortMaxConnsWithOptionsAsync(DescribePortMaxConnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortMaxConnsResponse>(await DoRPCRequestAsync("DescribePortMaxConns", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePortMaxConnsResponse DescribePortMaxConns(DescribePortMaxConnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePortMaxConnsWithOptions(request, runtime);
        }

        public async Task<DescribePortMaxConnsResponse> DescribePortMaxConnsAsync(DescribePortMaxConnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePortMaxConnsWithOptionsAsync(request, runtime);
        }

        public DescribePortViewSourceCountriesResponse DescribePortViewSourceCountriesWithOptions(DescribePortViewSourceCountriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortViewSourceCountriesResponse>(DoRPCRequest("DescribePortViewSourceCountries", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePortViewSourceCountriesResponse> DescribePortViewSourceCountriesWithOptionsAsync(DescribePortViewSourceCountriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortViewSourceCountriesResponse>(await DoRPCRequestAsync("DescribePortViewSourceCountries", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePortViewSourceCountriesResponse DescribePortViewSourceCountries(DescribePortViewSourceCountriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePortViewSourceCountriesWithOptions(request, runtime);
        }

        public async Task<DescribePortViewSourceCountriesResponse> DescribePortViewSourceCountriesAsync(DescribePortViewSourceCountriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePortViewSourceCountriesWithOptionsAsync(request, runtime);
        }

        public DescribePortViewSourceIspsResponse DescribePortViewSourceIspsWithOptions(DescribePortViewSourceIspsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortViewSourceIspsResponse>(DoRPCRequest("DescribePortViewSourceIsps", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePortViewSourceIspsResponse> DescribePortViewSourceIspsWithOptionsAsync(DescribePortViewSourceIspsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortViewSourceIspsResponse>(await DoRPCRequestAsync("DescribePortViewSourceIsps", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePortViewSourceIspsResponse DescribePortViewSourceIsps(DescribePortViewSourceIspsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePortViewSourceIspsWithOptions(request, runtime);
        }

        public async Task<DescribePortViewSourceIspsResponse> DescribePortViewSourceIspsAsync(DescribePortViewSourceIspsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePortViewSourceIspsWithOptionsAsync(request, runtime);
        }

        public DescribePortViewSourceProvincesResponse DescribePortViewSourceProvincesWithOptions(DescribePortViewSourceProvincesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortViewSourceProvincesResponse>(DoRPCRequest("DescribePortViewSourceProvinces", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePortViewSourceProvincesResponse> DescribePortViewSourceProvincesWithOptionsAsync(DescribePortViewSourceProvincesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortViewSourceProvincesResponse>(await DoRPCRequestAsync("DescribePortViewSourceProvinces", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePortViewSourceProvincesResponse DescribePortViewSourceProvinces(DescribePortViewSourceProvincesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePortViewSourceProvincesWithOptions(request, runtime);
        }

        public async Task<DescribePortViewSourceProvincesResponse> DescribePortViewSourceProvincesAsync(DescribePortViewSourceProvincesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePortViewSourceProvincesWithOptionsAsync(request, runtime);
        }

        public DescribeSceneDefenseObjectsResponse DescribeSceneDefenseObjectsWithOptions(DescribeSceneDefenseObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSceneDefenseObjectsResponse>(DoRPCRequest("DescribeSceneDefenseObjects", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSceneDefenseObjectsResponse> DescribeSceneDefenseObjectsWithOptionsAsync(DescribeSceneDefenseObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSceneDefenseObjectsResponse>(await DoRPCRequestAsync("DescribeSceneDefenseObjects", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSceneDefenseObjectsResponse DescribeSceneDefenseObjects(DescribeSceneDefenseObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSceneDefenseObjectsWithOptions(request, runtime);
        }

        public async Task<DescribeSceneDefenseObjectsResponse> DescribeSceneDefenseObjectsAsync(DescribeSceneDefenseObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSceneDefenseObjectsWithOptionsAsync(request, runtime);
        }

        public DescribeSceneDefensePoliciesResponse DescribeSceneDefensePoliciesWithOptions(DescribeSceneDefensePoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSceneDefensePoliciesResponse>(DoRPCRequest("DescribeSceneDefensePolicies", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSceneDefensePoliciesResponse> DescribeSceneDefensePoliciesWithOptionsAsync(DescribeSceneDefensePoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSceneDefensePoliciesResponse>(await DoRPCRequestAsync("DescribeSceneDefensePolicies", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSceneDefensePoliciesResponse DescribeSceneDefensePolicies(DescribeSceneDefensePoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSceneDefensePoliciesWithOptions(request, runtime);
        }

        public async Task<DescribeSceneDefensePoliciesResponse> DescribeSceneDefensePoliciesAsync(DescribeSceneDefensePoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSceneDefensePoliciesWithOptionsAsync(request, runtime);
        }

        public DescribeSchedulerRulesResponse DescribeSchedulerRulesWithOptions(DescribeSchedulerRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSchedulerRulesResponse>(DoRPCRequest("DescribeSchedulerRules", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSchedulerRulesResponse> DescribeSchedulerRulesWithOptionsAsync(DescribeSchedulerRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSchedulerRulesResponse>(await DoRPCRequestAsync("DescribeSchedulerRules", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSchedulerRulesResponse DescribeSchedulerRules(DescribeSchedulerRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSchedulerRulesWithOptions(request, runtime);
        }

        public async Task<DescribeSchedulerRulesResponse> DescribeSchedulerRulesAsync(DescribeSchedulerRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSchedulerRulesWithOptionsAsync(request, runtime);
        }

        public DescribeSlsAuthStatusResponse DescribeSlsAuthStatusWithOptions(DescribeSlsAuthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlsAuthStatusResponse>(DoRPCRequest("DescribeSlsAuthStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSlsAuthStatusResponse> DescribeSlsAuthStatusWithOptionsAsync(DescribeSlsAuthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlsAuthStatusResponse>(await DoRPCRequestAsync("DescribeSlsAuthStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSlsLogstoreInfoResponse DescribeSlsLogstoreInfoWithOptions(DescribeSlsLogstoreInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlsLogstoreInfoResponse>(DoRPCRequest("DescribeSlsLogstoreInfo", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSlsLogstoreInfoResponse> DescribeSlsLogstoreInfoWithOptionsAsync(DescribeSlsLogstoreInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlsLogstoreInfoResponse>(await DoRPCRequestAsync("DescribeSlsLogstoreInfo", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeSlsOpenStatusResponse>(DoRPCRequest("DescribeSlsOpenStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSlsOpenStatusResponse> DescribeSlsOpenStatusWithOptionsAsync(DescribeSlsOpenStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlsOpenStatusResponse>(await DoRPCRequestAsync("DescribeSlsOpenStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeStsGrantStatusResponse DescribeStsGrantStatusWithOptions(DescribeStsGrantStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStsGrantStatusResponse>(DoRPCRequest("DescribeStsGrantStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStsGrantStatusResponse> DescribeStsGrantStatusWithOptionsAsync(DescribeStsGrantStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStsGrantStatusResponse>(await DoRPCRequestAsync("DescribeStsGrantStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStsGrantStatusResponse DescribeStsGrantStatus(DescribeStsGrantStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStsGrantStatusWithOptions(request, runtime);
        }

        public async Task<DescribeStsGrantStatusResponse> DescribeStsGrantStatusAsync(DescribeStsGrantStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStsGrantStatusWithOptionsAsync(request, runtime);
        }

        public DescribeTagKeysResponse DescribeTagKeysWithOptions(DescribeTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagKeysResponse>(DoRPCRequest("DescribeTagKeys", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTagKeysResponse> DescribeTagKeysWithOptionsAsync(DescribeTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagKeysResponse>(await DoRPCRequestAsync("DescribeTagKeys", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTagKeysResponse DescribeTagKeys(DescribeTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagKeysWithOptions(request, runtime);
        }

        public async Task<DescribeTagKeysResponse> DescribeTagKeysAsync(DescribeTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagKeysWithOptionsAsync(request, runtime);
        }

        public DescribeTagResourcesResponse DescribeTagResourcesWithOptions(DescribeTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagResourcesResponse>(DoRPCRequest("DescribeTagResources", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTagResourcesResponse> DescribeTagResourcesWithOptionsAsync(DescribeTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagResourcesResponse>(await DoRPCRequestAsync("DescribeTagResources", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTagResourcesResponse DescribeTagResources(DescribeTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagResourcesWithOptions(request, runtime);
        }

        public async Task<DescribeTagResourcesResponse> DescribeTagResourcesAsync(DescribeTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagResourcesWithOptionsAsync(request, runtime);
        }

        public DescribeUnBlackholeCountResponse DescribeUnBlackholeCountWithOptions(DescribeUnBlackholeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUnBlackholeCountResponse>(DoRPCRequest("DescribeUnBlackholeCount", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUnBlackholeCountResponse> DescribeUnBlackholeCountWithOptionsAsync(DescribeUnBlackholeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUnBlackholeCountResponse>(await DoRPCRequestAsync("DescribeUnBlackholeCount", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUnBlackholeCountResponse DescribeUnBlackholeCount(DescribeUnBlackholeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUnBlackholeCountWithOptions(request, runtime);
        }

        public async Task<DescribeUnBlackholeCountResponse> DescribeUnBlackholeCountAsync(DescribeUnBlackholeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUnBlackholeCountWithOptionsAsync(request, runtime);
        }

        public DescribeUnBlockCountResponse DescribeUnBlockCountWithOptions(DescribeUnBlockCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUnBlockCountResponse>(DoRPCRequest("DescribeUnBlockCount", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUnBlockCountResponse> DescribeUnBlockCountWithOptionsAsync(DescribeUnBlockCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUnBlockCountResponse>(await DoRPCRequestAsync("DescribeUnBlockCount", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUnBlockCountResponse DescribeUnBlockCount(DescribeUnBlockCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUnBlockCountWithOptions(request, runtime);
        }

        public async Task<DescribeUnBlockCountResponse> DescribeUnBlockCountAsync(DescribeUnBlockCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUnBlockCountWithOptionsAsync(request, runtime);
        }

        public DescribeWebAccessLogDispatchStatusResponse DescribeWebAccessLogDispatchStatusWithOptions(DescribeWebAccessLogDispatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebAccessLogDispatchStatusResponse>(DoRPCRequest("DescribeWebAccessLogDispatchStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebAccessLogDispatchStatusResponse> DescribeWebAccessLogDispatchStatusWithOptionsAsync(DescribeWebAccessLogDispatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebAccessLogDispatchStatusResponse>(await DoRPCRequestAsync("DescribeWebAccessLogDispatchStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebAccessLogDispatchStatusResponse DescribeWebAccessLogDispatchStatus(DescribeWebAccessLogDispatchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebAccessLogDispatchStatusWithOptions(request, runtime);
        }

        public async Task<DescribeWebAccessLogDispatchStatusResponse> DescribeWebAccessLogDispatchStatusAsync(DescribeWebAccessLogDispatchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebAccessLogDispatchStatusWithOptionsAsync(request, runtime);
        }

        public DescribeWebAccessLogEmptyCountResponse DescribeWebAccessLogEmptyCountWithOptions(DescribeWebAccessLogEmptyCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebAccessLogEmptyCountResponse>(DoRPCRequest("DescribeWebAccessLogEmptyCount", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebAccessLogEmptyCountResponse> DescribeWebAccessLogEmptyCountWithOptionsAsync(DescribeWebAccessLogEmptyCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebAccessLogEmptyCountResponse>(await DoRPCRequestAsync("DescribeWebAccessLogEmptyCount", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebAccessLogEmptyCountResponse DescribeWebAccessLogEmptyCount(DescribeWebAccessLogEmptyCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebAccessLogEmptyCountWithOptions(request, runtime);
        }

        public async Task<DescribeWebAccessLogEmptyCountResponse> DescribeWebAccessLogEmptyCountAsync(DescribeWebAccessLogEmptyCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebAccessLogEmptyCountWithOptionsAsync(request, runtime);
        }

        public DescribeWebAccessLogStatusResponse DescribeWebAccessLogStatusWithOptions(DescribeWebAccessLogStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebAccessLogStatusResponse>(DoRPCRequest("DescribeWebAccessLogStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebAccessLogStatusResponse> DescribeWebAccessLogStatusWithOptionsAsync(DescribeWebAccessLogStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebAccessLogStatusResponse>(await DoRPCRequestAsync("DescribeWebAccessLogStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebAccessLogStatusResponse DescribeWebAccessLogStatus(DescribeWebAccessLogStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebAccessLogStatusWithOptions(request, runtime);
        }

        public async Task<DescribeWebAccessLogStatusResponse> DescribeWebAccessLogStatusAsync(DescribeWebAccessLogStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebAccessLogStatusWithOptionsAsync(request, runtime);
        }

        public DescribeWebAccessModeResponse DescribeWebAccessModeWithOptions(DescribeWebAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebAccessModeResponse>(DoRPCRequest("DescribeWebAccessMode", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebAccessModeResponse> DescribeWebAccessModeWithOptionsAsync(DescribeWebAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebAccessModeResponse>(await DoRPCRequestAsync("DescribeWebAccessMode", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebAccessModeResponse DescribeWebAccessMode(DescribeWebAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebAccessModeWithOptions(request, runtime);
        }

        public async Task<DescribeWebAccessModeResponse> DescribeWebAccessModeAsync(DescribeWebAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebAccessModeWithOptionsAsync(request, runtime);
        }

        public DescribeWebAreaBlockConfigsResponse DescribeWebAreaBlockConfigsWithOptions(DescribeWebAreaBlockConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebAreaBlockConfigsResponse>(DoRPCRequest("DescribeWebAreaBlockConfigs", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebAreaBlockConfigsResponse> DescribeWebAreaBlockConfigsWithOptionsAsync(DescribeWebAreaBlockConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebAreaBlockConfigsResponse>(await DoRPCRequestAsync("DescribeWebAreaBlockConfigs", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebAreaBlockConfigsResponse DescribeWebAreaBlockConfigs(DescribeWebAreaBlockConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebAreaBlockConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeWebAreaBlockConfigsResponse> DescribeWebAreaBlockConfigsAsync(DescribeWebAreaBlockConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebAreaBlockConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeWebCacheConfigsResponse DescribeWebCacheConfigsWithOptions(DescribeWebCacheConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebCacheConfigsResponse>(DoRPCRequest("DescribeWebCacheConfigs", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebCacheConfigsResponse> DescribeWebCacheConfigsWithOptionsAsync(DescribeWebCacheConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebCacheConfigsResponse>(await DoRPCRequestAsync("DescribeWebCacheConfigs", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebCacheConfigsResponse DescribeWebCacheConfigs(DescribeWebCacheConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebCacheConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeWebCacheConfigsResponse> DescribeWebCacheConfigsAsync(DescribeWebCacheConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebCacheConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeWebCcProtectSwitchResponse DescribeWebCcProtectSwitchWithOptions(DescribeWebCcProtectSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebCcProtectSwitchResponse>(DoRPCRequest("DescribeWebCcProtectSwitch", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebCcProtectSwitchResponse> DescribeWebCcProtectSwitchWithOptionsAsync(DescribeWebCcProtectSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebCcProtectSwitchResponse>(await DoRPCRequestAsync("DescribeWebCcProtectSwitch", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebCcProtectSwitchResponse DescribeWebCcProtectSwitch(DescribeWebCcProtectSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebCcProtectSwitchWithOptions(request, runtime);
        }

        public async Task<DescribeWebCcProtectSwitchResponse> DescribeWebCcProtectSwitchAsync(DescribeWebCcProtectSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebCcProtectSwitchWithOptionsAsync(request, runtime);
        }

        public DescribeWebCCRulesResponse DescribeWebCCRulesWithOptions(DescribeWebCCRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebCCRulesResponse>(DoRPCRequest("DescribeWebCCRules", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebCCRulesResponse> DescribeWebCCRulesWithOptionsAsync(DescribeWebCCRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebCCRulesResponse>(await DoRPCRequestAsync("DescribeWebCCRules", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebCCRulesResponse DescribeWebCCRules(DescribeWebCCRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebCCRulesWithOptions(request, runtime);
        }

        public async Task<DescribeWebCCRulesResponse> DescribeWebCCRulesAsync(DescribeWebCCRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebCCRulesWithOptionsAsync(request, runtime);
        }

        public DescribeWebCustomPortsResponse DescribeWebCustomPortsWithOptions(DescribeWebCustomPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebCustomPortsResponse>(DoRPCRequest("DescribeWebCustomPorts", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebCustomPortsResponse> DescribeWebCustomPortsWithOptionsAsync(DescribeWebCustomPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebCustomPortsResponse>(await DoRPCRequestAsync("DescribeWebCustomPorts", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebCustomPortsResponse DescribeWebCustomPorts(DescribeWebCustomPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebCustomPortsWithOptions(request, runtime);
        }

        public async Task<DescribeWebCustomPortsResponse> DescribeWebCustomPortsAsync(DescribeWebCustomPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebCustomPortsWithOptionsAsync(request, runtime);
        }

        public DescribeWebInstanceRelationsResponse DescribeWebInstanceRelationsWithOptions(DescribeWebInstanceRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebInstanceRelationsResponse>(DoRPCRequest("DescribeWebInstanceRelations", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebInstanceRelationsResponse> DescribeWebInstanceRelationsWithOptionsAsync(DescribeWebInstanceRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebInstanceRelationsResponse>(await DoRPCRequestAsync("DescribeWebInstanceRelations", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebInstanceRelationsResponse DescribeWebInstanceRelations(DescribeWebInstanceRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebInstanceRelationsWithOptions(request, runtime);
        }

        public async Task<DescribeWebInstanceRelationsResponse> DescribeWebInstanceRelationsAsync(DescribeWebInstanceRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebInstanceRelationsWithOptionsAsync(request, runtime);
        }

        public DescribeWebPreciseAccessRuleResponse DescribeWebPreciseAccessRuleWithOptions(DescribeWebPreciseAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebPreciseAccessRuleResponse>(DoRPCRequest("DescribeWebPreciseAccessRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebPreciseAccessRuleResponse> DescribeWebPreciseAccessRuleWithOptionsAsync(DescribeWebPreciseAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebPreciseAccessRuleResponse>(await DoRPCRequestAsync("DescribeWebPreciseAccessRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebPreciseAccessRuleResponse DescribeWebPreciseAccessRule(DescribeWebPreciseAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebPreciseAccessRuleWithOptions(request, runtime);
        }

        public async Task<DescribeWebPreciseAccessRuleResponse> DescribeWebPreciseAccessRuleAsync(DescribeWebPreciseAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebPreciseAccessRuleWithOptionsAsync(request, runtime);
        }

        public DescribeWebRulesResponse DescribeWebRulesWithOptions(DescribeWebRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebRulesResponse>(DoRPCRequest("DescribeWebRules", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebRulesResponse> DescribeWebRulesWithOptionsAsync(DescribeWebRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebRulesResponse>(await DoRPCRequestAsync("DescribeWebRules", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebRulesResponse DescribeWebRules(DescribeWebRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebRulesWithOptions(request, runtime);
        }

        public async Task<DescribeWebRulesResponse> DescribeWebRulesAsync(DescribeWebRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebRulesWithOptionsAsync(request, runtime);
        }

        public DetachSceneDefenseObjectResponse DetachSceneDefenseObjectWithOptions(DetachSceneDefenseObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachSceneDefenseObjectResponse>(DoRPCRequest("DetachSceneDefenseObject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachSceneDefenseObjectResponse> DetachSceneDefenseObjectWithOptionsAsync(DetachSceneDefenseObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachSceneDefenseObjectResponse>(await DoRPCRequestAsync("DetachSceneDefenseObject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachSceneDefenseObjectResponse DetachSceneDefenseObject(DetachSceneDefenseObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachSceneDefenseObjectWithOptions(request, runtime);
        }

        public async Task<DetachSceneDefenseObjectResponse> DetachSceneDefenseObjectAsync(DetachSceneDefenseObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachSceneDefenseObjectWithOptionsAsync(request, runtime);
        }

        public DisableSceneDefensePolicyResponse DisableSceneDefensePolicyWithOptions(DisableSceneDefensePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableSceneDefensePolicyResponse>(DoRPCRequest("DisableSceneDefensePolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableSceneDefensePolicyResponse> DisableSceneDefensePolicyWithOptionsAsync(DisableSceneDefensePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableSceneDefensePolicyResponse>(await DoRPCRequestAsync("DisableSceneDefensePolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableSceneDefensePolicyResponse DisableSceneDefensePolicy(DisableSceneDefensePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSceneDefensePolicyWithOptions(request, runtime);
        }

        public async Task<DisableSceneDefensePolicyResponse> DisableSceneDefensePolicyAsync(DisableSceneDefensePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSceneDefensePolicyWithOptionsAsync(request, runtime);
        }

        public DisableWebAccessLogConfigResponse DisableWebAccessLogConfigWithOptions(DisableWebAccessLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableWebAccessLogConfigResponse>(DoRPCRequest("DisableWebAccessLogConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableWebAccessLogConfigResponse> DisableWebAccessLogConfigWithOptionsAsync(DisableWebAccessLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableWebAccessLogConfigResponse>(await DoRPCRequestAsync("DisableWebAccessLogConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableWebAccessLogConfigResponse DisableWebAccessLogConfig(DisableWebAccessLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableWebAccessLogConfigWithOptions(request, runtime);
        }

        public async Task<DisableWebAccessLogConfigResponse> DisableWebAccessLogConfigAsync(DisableWebAccessLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableWebAccessLogConfigWithOptionsAsync(request, runtime);
        }

        public DisableWebCCResponse DisableWebCCWithOptions(DisableWebCCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableWebCCResponse>(DoRPCRequest("DisableWebCC", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableWebCCResponse> DisableWebCCWithOptionsAsync(DisableWebCCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableWebCCResponse>(await DoRPCRequestAsync("DisableWebCC", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableWebCCResponse DisableWebCC(DisableWebCCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableWebCCWithOptions(request, runtime);
        }

        public async Task<DisableWebCCResponse> DisableWebCCAsync(DisableWebCCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableWebCCWithOptionsAsync(request, runtime);
        }

        public DisableWebCCRuleResponse DisableWebCCRuleWithOptions(DisableWebCCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableWebCCRuleResponse>(DoRPCRequest("DisableWebCCRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableWebCCRuleResponse> DisableWebCCRuleWithOptionsAsync(DisableWebCCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableWebCCRuleResponse>(await DoRPCRequestAsync("DisableWebCCRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableWebCCRuleResponse DisableWebCCRule(DisableWebCCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableWebCCRuleWithOptions(request, runtime);
        }

        public async Task<DisableWebCCRuleResponse> DisableWebCCRuleAsync(DisableWebCCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableWebCCRuleWithOptionsAsync(request, runtime);
        }

        public EmptyAutoCcBlacklistResponse EmptyAutoCcBlacklistWithOptions(EmptyAutoCcBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EmptyAutoCcBlacklistResponse>(DoRPCRequest("EmptyAutoCcBlacklist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EmptyAutoCcBlacklistResponse> EmptyAutoCcBlacklistWithOptionsAsync(EmptyAutoCcBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EmptyAutoCcBlacklistResponse>(await DoRPCRequestAsync("EmptyAutoCcBlacklist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EmptyAutoCcBlacklistResponse EmptyAutoCcBlacklist(EmptyAutoCcBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EmptyAutoCcBlacklistWithOptions(request, runtime);
        }

        public async Task<EmptyAutoCcBlacklistResponse> EmptyAutoCcBlacklistAsync(EmptyAutoCcBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EmptyAutoCcBlacklistWithOptionsAsync(request, runtime);
        }

        public EmptyAutoCcWhitelistResponse EmptyAutoCcWhitelistWithOptions(EmptyAutoCcWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EmptyAutoCcWhitelistResponse>(DoRPCRequest("EmptyAutoCcWhitelist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EmptyAutoCcWhitelistResponse> EmptyAutoCcWhitelistWithOptionsAsync(EmptyAutoCcWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EmptyAutoCcWhitelistResponse>(await DoRPCRequestAsync("EmptyAutoCcWhitelist", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EmptyAutoCcWhitelistResponse EmptyAutoCcWhitelist(EmptyAutoCcWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EmptyAutoCcWhitelistWithOptions(request, runtime);
        }

        public async Task<EmptyAutoCcWhitelistResponse> EmptyAutoCcWhitelistAsync(EmptyAutoCcWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EmptyAutoCcWhitelistWithOptionsAsync(request, runtime);
        }

        public EmptySlsLogstoreResponse EmptySlsLogstoreWithOptions(EmptySlsLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EmptySlsLogstoreResponse>(DoRPCRequest("EmptySlsLogstore", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EmptySlsLogstoreResponse> EmptySlsLogstoreWithOptionsAsync(EmptySlsLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EmptySlsLogstoreResponse>(await DoRPCRequestAsync("EmptySlsLogstore", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public EnableSceneDefensePolicyResponse EnableSceneDefensePolicyWithOptions(EnableSceneDefensePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSceneDefensePolicyResponse>(DoRPCRequest("EnableSceneDefensePolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableSceneDefensePolicyResponse> EnableSceneDefensePolicyWithOptionsAsync(EnableSceneDefensePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSceneDefensePolicyResponse>(await DoRPCRequestAsync("EnableSceneDefensePolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableSceneDefensePolicyResponse EnableSceneDefensePolicy(EnableSceneDefensePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSceneDefensePolicyWithOptions(request, runtime);
        }

        public async Task<EnableSceneDefensePolicyResponse> EnableSceneDefensePolicyAsync(EnableSceneDefensePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSceneDefensePolicyWithOptionsAsync(request, runtime);
        }

        public EnableWebAccessLogConfigResponse EnableWebAccessLogConfigWithOptions(EnableWebAccessLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableWebAccessLogConfigResponse>(DoRPCRequest("EnableWebAccessLogConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableWebAccessLogConfigResponse> EnableWebAccessLogConfigWithOptionsAsync(EnableWebAccessLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableWebAccessLogConfigResponse>(await DoRPCRequestAsync("EnableWebAccessLogConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableWebAccessLogConfigResponse EnableWebAccessLogConfig(EnableWebAccessLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableWebAccessLogConfigWithOptions(request, runtime);
        }

        public async Task<EnableWebAccessLogConfigResponse> EnableWebAccessLogConfigAsync(EnableWebAccessLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableWebAccessLogConfigWithOptionsAsync(request, runtime);
        }

        public EnableWebCCResponse EnableWebCCWithOptions(EnableWebCCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableWebCCResponse>(DoRPCRequest("EnableWebCC", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableWebCCResponse> EnableWebCCWithOptionsAsync(EnableWebCCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableWebCCResponse>(await DoRPCRequestAsync("EnableWebCC", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableWebCCResponse EnableWebCC(EnableWebCCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableWebCCWithOptions(request, runtime);
        }

        public async Task<EnableWebCCResponse> EnableWebCCAsync(EnableWebCCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableWebCCWithOptionsAsync(request, runtime);
        }

        public EnableWebCCRuleResponse EnableWebCCRuleWithOptions(EnableWebCCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableWebCCRuleResponse>(DoRPCRequest("EnableWebCCRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableWebCCRuleResponse> EnableWebCCRuleWithOptionsAsync(EnableWebCCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableWebCCRuleResponse>(await DoRPCRequestAsync("EnableWebCCRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableWebCCRuleResponse EnableWebCCRule(EnableWebCCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableWebCCRuleWithOptions(request, runtime);
        }

        public async Task<EnableWebCCRuleResponse> EnableWebCCRuleAsync(EnableWebCCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableWebCCRuleWithOptionsAsync(request, runtime);
        }

        public ModifyBlackholeStatusResponse ModifyBlackholeStatusWithOptions(ModifyBlackholeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBlackholeStatusResponse>(DoRPCRequest("ModifyBlackholeStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBlackholeStatusResponse> ModifyBlackholeStatusWithOptionsAsync(ModifyBlackholeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBlackholeStatusResponse>(await DoRPCRequestAsync("ModifyBlackholeStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBlackholeStatusResponse ModifyBlackholeStatus(ModifyBlackholeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBlackholeStatusWithOptions(request, runtime);
        }

        public async Task<ModifyBlackholeStatusResponse> ModifyBlackholeStatusAsync(ModifyBlackholeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBlackholeStatusWithOptionsAsync(request, runtime);
        }

        public ModifyBlockStatusResponse ModifyBlockStatusWithOptions(ModifyBlockStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBlockStatusResponse>(DoRPCRequest("ModifyBlockStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBlockStatusResponse> ModifyBlockStatusWithOptionsAsync(ModifyBlockStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBlockStatusResponse>(await DoRPCRequestAsync("ModifyBlockStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBlockStatusResponse ModifyBlockStatus(ModifyBlockStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBlockStatusWithOptions(request, runtime);
        }

        public async Task<ModifyBlockStatusResponse> ModifyBlockStatusAsync(ModifyBlockStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBlockStatusWithOptionsAsync(request, runtime);
        }

        public ModifyCnameReuseResponse ModifyCnameReuseWithOptions(ModifyCnameReuseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCnameReuseResponse>(DoRPCRequest("ModifyCnameReuse", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCnameReuseResponse> ModifyCnameReuseWithOptionsAsync(ModifyCnameReuseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCnameReuseResponse>(await DoRPCRequestAsync("ModifyCnameReuse", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCnameReuseResponse ModifyCnameReuse(ModifyCnameReuseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCnameReuseWithOptions(request, runtime);
        }

        public async Task<ModifyCnameReuseResponse> ModifyCnameReuseAsync(ModifyCnameReuseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCnameReuseWithOptionsAsync(request, runtime);
        }

        public ModifyElasticBandWidthResponse ModifyElasticBandWidthWithOptions(ModifyElasticBandWidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyElasticBandWidthResponse>(DoRPCRequest("ModifyElasticBandWidth", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyElasticBandWidthResponse> ModifyElasticBandWidthWithOptionsAsync(ModifyElasticBandWidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyElasticBandWidthResponse>(await DoRPCRequestAsync("ModifyElasticBandWidth", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<ModifyFullLogTtlResponse>(DoRPCRequest("ModifyFullLogTtl", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFullLogTtlResponse> ModifyFullLogTtlWithOptionsAsync(ModifyFullLogTtlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFullLogTtlResponse>(await DoRPCRequestAsync("ModifyFullLogTtl", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyHealthCheckConfigResponse ModifyHealthCheckConfigWithOptions(ModifyHealthCheckConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHealthCheckConfigResponse>(DoRPCRequest("ModifyHealthCheckConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHealthCheckConfigResponse> ModifyHealthCheckConfigWithOptionsAsync(ModifyHealthCheckConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHealthCheckConfigResponse>(await DoRPCRequestAsync("ModifyHealthCheckConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHealthCheckConfigResponse ModifyHealthCheckConfig(ModifyHealthCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHealthCheckConfigWithOptions(request, runtime);
        }

        public async Task<ModifyHealthCheckConfigResponse> ModifyHealthCheckConfigAsync(ModifyHealthCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHealthCheckConfigWithOptionsAsync(request, runtime);
        }

        public ModifyHttp2EnableResponse ModifyHttp2EnableWithOptions(ModifyHttp2EnableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHttp2EnableResponse>(DoRPCRequest("ModifyHttp2Enable", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHttp2EnableResponse> ModifyHttp2EnableWithOptionsAsync(ModifyHttp2EnableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHttp2EnableResponse>(await DoRPCRequestAsync("ModifyHttp2Enable", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHttp2EnableResponse ModifyHttp2Enable(ModifyHttp2EnableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHttp2EnableWithOptions(request, runtime);
        }

        public async Task<ModifyHttp2EnableResponse> ModifyHttp2EnableAsync(ModifyHttp2EnableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHttp2EnableWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceRemarkResponse ModifyInstanceRemarkWithOptions(ModifyInstanceRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceRemarkResponse>(DoRPCRequest("ModifyInstanceRemark", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceRemarkResponse> ModifyInstanceRemarkWithOptionsAsync(ModifyInstanceRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceRemarkResponse>(await DoRPCRequestAsync("ModifyInstanceRemark", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyNetworkRuleAttributeResponse ModifyNetworkRuleAttributeWithOptions(ModifyNetworkRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNetworkRuleAttributeResponse>(DoRPCRequest("ModifyNetworkRuleAttribute", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyNetworkRuleAttributeResponse> ModifyNetworkRuleAttributeWithOptionsAsync(ModifyNetworkRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNetworkRuleAttributeResponse>(await DoRPCRequestAsync("ModifyNetworkRuleAttribute", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyNetworkRuleAttributeResponse ModifyNetworkRuleAttribute(ModifyNetworkRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNetworkRuleAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyNetworkRuleAttributeResponse> ModifyNetworkRuleAttributeAsync(ModifyNetworkRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNetworkRuleAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyPortAutoCcStatusResponse ModifyPortAutoCcStatusWithOptions(ModifyPortAutoCcStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPortAutoCcStatusResponse>(DoRPCRequest("ModifyPortAutoCcStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPortAutoCcStatusResponse> ModifyPortAutoCcStatusWithOptionsAsync(ModifyPortAutoCcStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPortAutoCcStatusResponse>(await DoRPCRequestAsync("ModifyPortAutoCcStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPortAutoCcStatusResponse ModifyPortAutoCcStatus(ModifyPortAutoCcStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPortAutoCcStatusWithOptions(request, runtime);
        }

        public async Task<ModifyPortAutoCcStatusResponse> ModifyPortAutoCcStatusAsync(ModifyPortAutoCcStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPortAutoCcStatusWithOptionsAsync(request, runtime);
        }

        public ModifySceneDefensePolicyResponse ModifySceneDefensePolicyWithOptions(ModifySceneDefensePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySceneDefensePolicyResponse>(DoRPCRequest("ModifySceneDefensePolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySceneDefensePolicyResponse> ModifySceneDefensePolicyWithOptionsAsync(ModifySceneDefensePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySceneDefensePolicyResponse>(await DoRPCRequestAsync("ModifySceneDefensePolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySceneDefensePolicyResponse ModifySceneDefensePolicy(ModifySceneDefensePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySceneDefensePolicyWithOptions(request, runtime);
        }

        public async Task<ModifySceneDefensePolicyResponse> ModifySceneDefensePolicyAsync(ModifySceneDefensePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySceneDefensePolicyWithOptionsAsync(request, runtime);
        }

        public ModifySchedulerRuleResponse ModifySchedulerRuleWithOptions(ModifySchedulerRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySchedulerRuleResponse>(DoRPCRequest("ModifySchedulerRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySchedulerRuleResponse> ModifySchedulerRuleWithOptionsAsync(ModifySchedulerRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySchedulerRuleResponse>(await DoRPCRequestAsync("ModifySchedulerRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySchedulerRuleResponse ModifySchedulerRule(ModifySchedulerRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySchedulerRuleWithOptions(request, runtime);
        }

        public async Task<ModifySchedulerRuleResponse> ModifySchedulerRuleAsync(ModifySchedulerRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySchedulerRuleWithOptionsAsync(request, runtime);
        }

        public ModifyTlsConfigResponse ModifyTlsConfigWithOptions(ModifyTlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTlsConfigResponse>(DoRPCRequest("ModifyTlsConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyTlsConfigResponse> ModifyTlsConfigWithOptionsAsync(ModifyTlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTlsConfigResponse>(await DoRPCRequestAsync("ModifyTlsConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyTlsConfigResponse ModifyTlsConfig(ModifyTlsConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTlsConfigWithOptions(request, runtime);
        }

        public async Task<ModifyTlsConfigResponse> ModifyTlsConfigAsync(ModifyTlsConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTlsConfigWithOptionsAsync(request, runtime);
        }

        public ModifyWebAccessModeResponse ModifyWebAccessModeWithOptions(ModifyWebAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebAccessModeResponse>(DoRPCRequest("ModifyWebAccessMode", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebAccessModeResponse> ModifyWebAccessModeWithOptionsAsync(ModifyWebAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebAccessModeResponse>(await DoRPCRequestAsync("ModifyWebAccessMode", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebAccessModeResponse ModifyWebAccessMode(ModifyWebAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebAccessModeWithOptions(request, runtime);
        }

        public async Task<ModifyWebAccessModeResponse> ModifyWebAccessModeAsync(ModifyWebAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebAccessModeWithOptionsAsync(request, runtime);
        }

        public ModifyWebAIProtectModeResponse ModifyWebAIProtectModeWithOptions(ModifyWebAIProtectModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebAIProtectModeResponse>(DoRPCRequest("ModifyWebAIProtectMode", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebAIProtectModeResponse> ModifyWebAIProtectModeWithOptionsAsync(ModifyWebAIProtectModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebAIProtectModeResponse>(await DoRPCRequestAsync("ModifyWebAIProtectMode", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebAIProtectModeResponse ModifyWebAIProtectMode(ModifyWebAIProtectModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebAIProtectModeWithOptions(request, runtime);
        }

        public async Task<ModifyWebAIProtectModeResponse> ModifyWebAIProtectModeAsync(ModifyWebAIProtectModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebAIProtectModeWithOptionsAsync(request, runtime);
        }

        public ModifyWebAIProtectSwitchResponse ModifyWebAIProtectSwitchWithOptions(ModifyWebAIProtectSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebAIProtectSwitchResponse>(DoRPCRequest("ModifyWebAIProtectSwitch", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebAIProtectSwitchResponse> ModifyWebAIProtectSwitchWithOptionsAsync(ModifyWebAIProtectSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebAIProtectSwitchResponse>(await DoRPCRequestAsync("ModifyWebAIProtectSwitch", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebAIProtectSwitchResponse ModifyWebAIProtectSwitch(ModifyWebAIProtectSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebAIProtectSwitchWithOptions(request, runtime);
        }

        public async Task<ModifyWebAIProtectSwitchResponse> ModifyWebAIProtectSwitchAsync(ModifyWebAIProtectSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebAIProtectSwitchWithOptionsAsync(request, runtime);
        }

        public ModifyWebAreaBlockResponse ModifyWebAreaBlockWithOptions(ModifyWebAreaBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebAreaBlockResponse>(DoRPCRequest("ModifyWebAreaBlock", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebAreaBlockResponse> ModifyWebAreaBlockWithOptionsAsync(ModifyWebAreaBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebAreaBlockResponse>(await DoRPCRequestAsync("ModifyWebAreaBlock", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebAreaBlockResponse ModifyWebAreaBlock(ModifyWebAreaBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebAreaBlockWithOptions(request, runtime);
        }

        public async Task<ModifyWebAreaBlockResponse> ModifyWebAreaBlockAsync(ModifyWebAreaBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebAreaBlockWithOptionsAsync(request, runtime);
        }

        public ModifyWebAreaBlockSwitchResponse ModifyWebAreaBlockSwitchWithOptions(ModifyWebAreaBlockSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebAreaBlockSwitchResponse>(DoRPCRequest("ModifyWebAreaBlockSwitch", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebAreaBlockSwitchResponse> ModifyWebAreaBlockSwitchWithOptionsAsync(ModifyWebAreaBlockSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebAreaBlockSwitchResponse>(await DoRPCRequestAsync("ModifyWebAreaBlockSwitch", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebAreaBlockSwitchResponse ModifyWebAreaBlockSwitch(ModifyWebAreaBlockSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebAreaBlockSwitchWithOptions(request, runtime);
        }

        public async Task<ModifyWebAreaBlockSwitchResponse> ModifyWebAreaBlockSwitchAsync(ModifyWebAreaBlockSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebAreaBlockSwitchWithOptionsAsync(request, runtime);
        }

        public ModifyWebCacheCustomRuleResponse ModifyWebCacheCustomRuleWithOptions(ModifyWebCacheCustomRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebCacheCustomRuleResponse>(DoRPCRequest("ModifyWebCacheCustomRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebCacheCustomRuleResponse> ModifyWebCacheCustomRuleWithOptionsAsync(ModifyWebCacheCustomRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebCacheCustomRuleResponse>(await DoRPCRequestAsync("ModifyWebCacheCustomRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebCacheCustomRuleResponse ModifyWebCacheCustomRule(ModifyWebCacheCustomRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebCacheCustomRuleWithOptions(request, runtime);
        }

        public async Task<ModifyWebCacheCustomRuleResponse> ModifyWebCacheCustomRuleAsync(ModifyWebCacheCustomRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebCacheCustomRuleWithOptionsAsync(request, runtime);
        }

        public ModifyWebCacheModeResponse ModifyWebCacheModeWithOptions(ModifyWebCacheModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebCacheModeResponse>(DoRPCRequest("ModifyWebCacheMode", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebCacheModeResponse> ModifyWebCacheModeWithOptionsAsync(ModifyWebCacheModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebCacheModeResponse>(await DoRPCRequestAsync("ModifyWebCacheMode", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebCacheModeResponse ModifyWebCacheMode(ModifyWebCacheModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebCacheModeWithOptions(request, runtime);
        }

        public async Task<ModifyWebCacheModeResponse> ModifyWebCacheModeAsync(ModifyWebCacheModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebCacheModeWithOptionsAsync(request, runtime);
        }

        public ModifyWebCacheSwitchResponse ModifyWebCacheSwitchWithOptions(ModifyWebCacheSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebCacheSwitchResponse>(DoRPCRequest("ModifyWebCacheSwitch", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebCacheSwitchResponse> ModifyWebCacheSwitchWithOptionsAsync(ModifyWebCacheSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebCacheSwitchResponse>(await DoRPCRequestAsync("ModifyWebCacheSwitch", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebCacheSwitchResponse ModifyWebCacheSwitch(ModifyWebCacheSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebCacheSwitchWithOptions(request, runtime);
        }

        public async Task<ModifyWebCacheSwitchResponse> ModifyWebCacheSwitchAsync(ModifyWebCacheSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebCacheSwitchWithOptionsAsync(request, runtime);
        }

        public ModifyWebCCRuleResponse ModifyWebCCRuleWithOptions(ModifyWebCCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebCCRuleResponse>(DoRPCRequest("ModifyWebCCRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebCCRuleResponse> ModifyWebCCRuleWithOptionsAsync(ModifyWebCCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebCCRuleResponse>(await DoRPCRequestAsync("ModifyWebCCRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebCCRuleResponse ModifyWebCCRule(ModifyWebCCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebCCRuleWithOptions(request, runtime);
        }

        public async Task<ModifyWebCCRuleResponse> ModifyWebCCRuleAsync(ModifyWebCCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebCCRuleWithOptionsAsync(request, runtime);
        }

        public ModifyWebIpSetSwitchResponse ModifyWebIpSetSwitchWithOptions(ModifyWebIpSetSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebIpSetSwitchResponse>(DoRPCRequest("ModifyWebIpSetSwitch", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebIpSetSwitchResponse> ModifyWebIpSetSwitchWithOptionsAsync(ModifyWebIpSetSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebIpSetSwitchResponse>(await DoRPCRequestAsync("ModifyWebIpSetSwitch", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebIpSetSwitchResponse ModifyWebIpSetSwitch(ModifyWebIpSetSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebIpSetSwitchWithOptions(request, runtime);
        }

        public async Task<ModifyWebIpSetSwitchResponse> ModifyWebIpSetSwitchAsync(ModifyWebIpSetSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebIpSetSwitchWithOptionsAsync(request, runtime);
        }

        public ModifyWebPreciseAccessRuleResponse ModifyWebPreciseAccessRuleWithOptions(ModifyWebPreciseAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebPreciseAccessRuleResponse>(DoRPCRequest("ModifyWebPreciseAccessRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebPreciseAccessRuleResponse> ModifyWebPreciseAccessRuleWithOptionsAsync(ModifyWebPreciseAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebPreciseAccessRuleResponse>(await DoRPCRequestAsync("ModifyWebPreciseAccessRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebPreciseAccessRuleResponse ModifyWebPreciseAccessRule(ModifyWebPreciseAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebPreciseAccessRuleWithOptions(request, runtime);
        }

        public async Task<ModifyWebPreciseAccessRuleResponse> ModifyWebPreciseAccessRuleAsync(ModifyWebPreciseAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebPreciseAccessRuleWithOptionsAsync(request, runtime);
        }

        public ModifyWebPreciseAccessSwitchResponse ModifyWebPreciseAccessSwitchWithOptions(ModifyWebPreciseAccessSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebPreciseAccessSwitchResponse>(DoRPCRequest("ModifyWebPreciseAccessSwitch", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebPreciseAccessSwitchResponse> ModifyWebPreciseAccessSwitchWithOptionsAsync(ModifyWebPreciseAccessSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebPreciseAccessSwitchResponse>(await DoRPCRequestAsync("ModifyWebPreciseAccessSwitch", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebPreciseAccessSwitchResponse ModifyWebPreciseAccessSwitch(ModifyWebPreciseAccessSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebPreciseAccessSwitchWithOptions(request, runtime);
        }

        public async Task<ModifyWebPreciseAccessSwitchResponse> ModifyWebPreciseAccessSwitchAsync(ModifyWebPreciseAccessSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebPreciseAccessSwitchWithOptionsAsync(request, runtime);
        }

        public ModifyWebRuleResponse ModifyWebRuleWithOptions(ModifyWebRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebRuleResponse>(DoRPCRequest("ModifyWebRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebRuleResponse> ModifyWebRuleWithOptionsAsync(ModifyWebRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebRuleResponse>(await DoRPCRequestAsync("ModifyWebRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebRuleResponse ModifyWebRule(ModifyWebRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebRuleWithOptions(request, runtime);
        }

        public async Task<ModifyWebRuleResponse> ModifyWebRuleAsync(ModifyWebRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebRuleWithOptionsAsync(request, runtime);
        }

        public ReleaseInstanceResponse ReleaseInstanceWithOptions(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(DoRPCRequest("ReleaseInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseInstanceResponse> ReleaseInstanceWithOptionsAsync(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(await DoRPCRequestAsync("ReleaseInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SwitchSchedulerRuleResponse SwitchSchedulerRuleWithOptions(SwitchSchedulerRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchSchedulerRuleResponse>(DoRPCRequest("SwitchSchedulerRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SwitchSchedulerRuleResponse> SwitchSchedulerRuleWithOptionsAsync(SwitchSchedulerRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchSchedulerRuleResponse>(await DoRPCRequestAsync("SwitchSchedulerRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SwitchSchedulerRuleResponse SwitchSchedulerRule(SwitchSchedulerRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchSchedulerRuleWithOptions(request, runtime);
        }

        public async Task<SwitchSchedulerRuleResponse> SwitchSchedulerRuleAsync(SwitchSchedulerRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchSchedulerRuleWithOptionsAsync(request, runtime);
        }

    }
}
