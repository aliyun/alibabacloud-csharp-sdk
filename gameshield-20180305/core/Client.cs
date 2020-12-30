// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Gameshield20180305.Models;

namespace AlibabaCloud.SDK.Gameshield20180305
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("gameshield", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CleanFlexAccFwdRulesResponse CleanFlexAccFwdRulesWithOptions(CleanFlexAccFwdRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CleanFlexAccFwdRulesResponse>(DoRPCRequest("CleanFlexAccFwdRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CleanFlexAccFwdRulesResponse> CleanFlexAccFwdRulesWithOptionsAsync(CleanFlexAccFwdRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CleanFlexAccFwdRulesResponse>(await DoRPCRequestAsync("CleanFlexAccFwdRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CleanFlexAccFwdRulesResponse CleanFlexAccFwdRules(CleanFlexAccFwdRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CleanFlexAccFwdRulesWithOptions(request, runtime);
        }

        public async Task<CleanFlexAccFwdRulesResponse> CleanFlexAccFwdRulesAsync(CleanFlexAccFwdRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CleanFlexAccFwdRulesWithOptionsAsync(request, runtime);
        }

        public CleanFlexFwdRulesResponse CleanFlexFwdRulesWithOptions(CleanFlexFwdRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CleanFlexFwdRulesResponse>(DoRPCRequest("CleanFlexFwdRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CleanFlexFwdRulesResponse> CleanFlexFwdRulesWithOptionsAsync(CleanFlexFwdRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CleanFlexFwdRulesResponse>(await DoRPCRequestAsync("CleanFlexFwdRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CleanFlexFwdRulesResponse CleanFlexFwdRules(CleanFlexFwdRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CleanFlexFwdRulesWithOptions(request, runtime);
        }

        public async Task<CleanFlexFwdRulesResponse> CleanFlexFwdRulesAsync(CleanFlexFwdRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CleanFlexFwdRulesWithOptionsAsync(request, runtime);
        }

        public ClearCcRouteRulesResponse ClearCcRouteRulesWithOptions(ClearCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearCcRouteRulesResponse>(DoRPCRequest("ClearCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ClearCcRouteRulesResponse> ClearCcRouteRulesWithOptionsAsync(ClearCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearCcRouteRulesResponse>(await DoRPCRequestAsync("ClearCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ClearCcRouteRulesResponse ClearCcRouteRules(ClearCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearCcRouteRulesWithOptions(request, runtime);
        }

        public async Task<ClearCcRouteRulesResponse> ClearCcRouteRulesAsync(ClearCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearCcRouteRulesWithOptionsAsync(request, runtime);
        }

        public CreateAppResponse CreateAppWithOptions(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAppResponse>(DoRPCRequest("CreateApp", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAppResponse> CreateAppWithOptionsAsync(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAppResponse>(await DoRPCRequestAsync("CreateApp", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAppResponse CreateApp(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppWithOptions(request, runtime);
        }

        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppWithOptionsAsync(request, runtime);
        }

        public CreateAppKeyResponse CreateAppKeyWithOptions(CreateAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAppKeyResponse>(DoRPCRequest("CreateAppKey", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAppKeyResponse> CreateAppKeyWithOptionsAsync(CreateAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAppKeyResponse>(await DoRPCRequestAsync("CreateAppKey", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAppKeyResponse CreateAppKey(CreateAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppKeyWithOptions(request, runtime);
        }

        public async Task<CreateAppKeyResponse> CreateAppKeyAsync(CreateAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppKeyWithOptionsAsync(request, runtime);
        }

        public CreateBizResponse CreateBizWithOptions(CreateBizRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBizResponse>(DoRPCRequest("CreateBiz", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBizResponse> CreateBizWithOptionsAsync(CreateBizRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBizResponse>(await DoRPCRequestAsync("CreateBiz", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBizResponse CreateBiz(CreateBizRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBizWithOptions(request, runtime);
        }

        public async Task<CreateBizResponse> CreateBizAsync(CreateBizRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBizWithOptionsAsync(request, runtime);
        }

        public CreateCcRouteRulesResponse CreateCcRouteRulesWithOptions(CreateCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCcRouteRulesResponse>(DoRPCRequest("CreateCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCcRouteRulesResponse> CreateCcRouteRulesWithOptionsAsync(CreateCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCcRouteRulesResponse>(await DoRPCRequestAsync("CreateCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCcRouteRulesResponse CreateCcRouteRules(CreateCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCcRouteRulesWithOptions(request, runtime);
        }

        public async Task<CreateCcRouteRulesResponse> CreateCcRouteRulesAsync(CreateCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCcRouteRulesWithOptionsAsync(request, runtime);
        }

        public CreateFlexAccFwdRuleResponse CreateFlexAccFwdRuleWithOptions(CreateFlexAccFwdRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlexAccFwdRuleResponse>(DoRPCRequest("CreateFlexAccFwdRule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlexAccFwdRuleResponse> CreateFlexAccFwdRuleWithOptionsAsync(CreateFlexAccFwdRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlexAccFwdRuleResponse>(await DoRPCRequestAsync("CreateFlexAccFwdRule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlexAccFwdRuleResponse CreateFlexAccFwdRule(CreateFlexAccFwdRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlexAccFwdRuleWithOptions(request, runtime);
        }

        public async Task<CreateFlexAccFwdRuleResponse> CreateFlexAccFwdRuleAsync(CreateFlexAccFwdRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlexAccFwdRuleWithOptionsAsync(request, runtime);
        }

        public CreateFlexAccFwdRuleListResponse CreateFlexAccFwdRuleListWithOptions(CreateFlexAccFwdRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlexAccFwdRuleListResponse>(DoRPCRequest("CreateFlexAccFwdRuleList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlexAccFwdRuleListResponse> CreateFlexAccFwdRuleListWithOptionsAsync(CreateFlexAccFwdRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlexAccFwdRuleListResponse>(await DoRPCRequestAsync("CreateFlexAccFwdRuleList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlexAccFwdRuleListResponse CreateFlexAccFwdRuleList(CreateFlexAccFwdRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlexAccFwdRuleListWithOptions(request, runtime);
        }

        public async Task<CreateFlexAccFwdRuleListResponse> CreateFlexAccFwdRuleListAsync(CreateFlexAccFwdRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlexAccFwdRuleListWithOptionsAsync(request, runtime);
        }

        public CreateFlexFwdRuleResponse CreateFlexFwdRuleWithOptions(CreateFlexFwdRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlexFwdRuleResponse>(DoRPCRequest("CreateFlexFwdRule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlexFwdRuleResponse> CreateFlexFwdRuleWithOptionsAsync(CreateFlexFwdRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlexFwdRuleResponse>(await DoRPCRequestAsync("CreateFlexFwdRule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlexFwdRuleResponse CreateFlexFwdRule(CreateFlexFwdRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlexFwdRuleWithOptions(request, runtime);
        }

        public async Task<CreateFlexFwdRuleResponse> CreateFlexFwdRuleAsync(CreateFlexFwdRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlexFwdRuleWithOptionsAsync(request, runtime);
        }

        public CreateGroupResponse CreateGroupWithOptions(CreateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupResponse>(DoRPCRequest("CreateGroup", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGroupResponse> CreateGroupWithOptionsAsync(CreateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupResponse>(await DoRPCRequestAsync("CreateGroup", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupWithOptions(request, runtime);
        }

        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupWithOptionsAsync(request, runtime);
        }

        public CreateLayer4RuleResponse CreateLayer4RuleWithOptions(CreateLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLayer4RuleResponse>(DoRPCRequest("CreateLayer4Rule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLayer4RuleResponse> CreateLayer4RuleWithOptionsAsync(CreateLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLayer4RuleResponse>(await DoRPCRequestAsync("CreateLayer4Rule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateLayer4RulesResponse CreateLayer4RulesWithOptions(CreateLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLayer4RulesResponse>(DoRPCRequest("CreateLayer4Rules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLayer4RulesResponse> CreateLayer4RulesWithOptionsAsync(CreateLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLayer4RulesResponse>(await DoRPCRequestAsync("CreateLayer4Rules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLayer4RulesResponse CreateLayer4Rules(CreateLayer4RulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLayer4RulesWithOptions(request, runtime);
        }

        public async Task<CreateLayer4RulesResponse> CreateLayer4RulesAsync(CreateLayer4RulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLayer4RulesWithOptionsAsync(request, runtime);
        }

        public DeleteAppResponse DeleteAppWithOptions(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAppResponse>(DoRPCRequest("DeleteApp", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAppResponse> DeleteAppWithOptionsAsync(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAppResponse>(await DoRPCRequestAsync("DeleteApp", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppWithOptions(request, runtime);
        }

        public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppWithOptionsAsync(request, runtime);
        }

        public DeleteAppKeyResponse DeleteAppKeyWithOptions(DeleteAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAppKeyResponse>(DoRPCRequest("DeleteAppKey", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAppKeyResponse> DeleteAppKeyWithOptionsAsync(DeleteAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAppKeyResponse>(await DoRPCRequestAsync("DeleteAppKey", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAppKeyResponse DeleteAppKey(DeleteAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppKeyWithOptions(request, runtime);
        }

        public async Task<DeleteAppKeyResponse> DeleteAppKeyAsync(DeleteAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppKeyWithOptionsAsync(request, runtime);
        }

        public DeleteBizResponse DeleteBizWithOptions(DeleteBizRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBizResponse>(DoRPCRequest("DeleteBiz", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBizResponse> DeleteBizWithOptionsAsync(DeleteBizRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBizResponse>(await DoRPCRequestAsync("DeleteBiz", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBizResponse DeleteBiz(DeleteBizRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBizWithOptions(request, runtime);
        }

        public async Task<DeleteBizResponse> DeleteBizAsync(DeleteBizRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBizWithOptionsAsync(request, runtime);
        }

        public DeleteCcRouteRulesResponse DeleteCcRouteRulesWithOptions(DeleteCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCcRouteRulesResponse>(DoRPCRequest("DeleteCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCcRouteRulesResponse> DeleteCcRouteRulesWithOptionsAsync(DeleteCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCcRouteRulesResponse>(await DoRPCRequestAsync("DeleteCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCcRouteRulesResponse DeleteCcRouteRules(DeleteCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCcRouteRulesWithOptions(request, runtime);
        }

        public async Task<DeleteCcRouteRulesResponse> DeleteCcRouteRulesAsync(DeleteCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCcRouteRulesWithOptionsAsync(request, runtime);
        }

        public DeleteFlexAccFwdRuleResponse DeleteFlexAccFwdRuleWithOptions(DeleteFlexAccFwdRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlexAccFwdRuleResponse>(DoRPCRequest("DeleteFlexAccFwdRule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlexAccFwdRuleResponse> DeleteFlexAccFwdRuleWithOptionsAsync(DeleteFlexAccFwdRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlexAccFwdRuleResponse>(await DoRPCRequestAsync("DeleteFlexAccFwdRule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlexAccFwdRuleResponse DeleteFlexAccFwdRule(DeleteFlexAccFwdRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlexAccFwdRuleWithOptions(request, runtime);
        }

        public async Task<DeleteFlexAccFwdRuleResponse> DeleteFlexAccFwdRuleAsync(DeleteFlexAccFwdRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlexAccFwdRuleWithOptionsAsync(request, runtime);
        }

        public DeleteFlexFwdRuleResponse DeleteFlexFwdRuleWithOptions(DeleteFlexFwdRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlexFwdRuleResponse>(DoRPCRequest("DeleteFlexFwdRule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlexFwdRuleResponse> DeleteFlexFwdRuleWithOptionsAsync(DeleteFlexFwdRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlexFwdRuleResponse>(await DoRPCRequestAsync("DeleteFlexFwdRule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlexFwdRuleResponse DeleteFlexFwdRule(DeleteFlexFwdRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlexFwdRuleWithOptions(request, runtime);
        }

        public async Task<DeleteFlexFwdRuleResponse> DeleteFlexFwdRuleAsync(DeleteFlexFwdRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlexFwdRuleWithOptionsAsync(request, runtime);
        }

        public DeleteGroupResponse DeleteGroupWithOptions(DeleteGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGroupResponse>(DoRPCRequest("DeleteGroup", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteGroupResponse> DeleteGroupWithOptionsAsync(DeleteGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGroupResponse>(await DoRPCRequestAsync("DeleteGroup", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGroupWithOptions(request, runtime);
        }

        public async Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupWithOptionsAsync(request, runtime);
        }

        public DeleteLayer4RuleResponse DeleteLayer4RuleWithOptions(DeleteLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLayer4RuleResponse>(DoRPCRequest("DeleteLayer4Rule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLayer4RuleResponse> DeleteLayer4RuleWithOptionsAsync(DeleteLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLayer4RuleResponse>(await DoRPCRequestAsync("DeleteLayer4Rule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeAccResSummaryResponse DescribeAccResSummaryWithOptions(DescribeAccResSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccResSummaryResponse>(DoRPCRequest("DescribeAccResSummary", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccResSummaryResponse> DescribeAccResSummaryWithOptionsAsync(DescribeAccResSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccResSummaryResponse>(await DoRPCRequestAsync("DescribeAccResSummary", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccResSummaryResponse DescribeAccResSummary(DescribeAccResSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccResSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeAccResSummaryResponse> DescribeAccResSummaryAsync(DescribeAccResSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccResSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeAllLocalIpsResponse DescribeAllLocalIpsWithOptions(DescribeAllLocalIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAllLocalIpsResponse>(DoRPCRequest("DescribeAllLocalIps", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAllLocalIpsResponse> DescribeAllLocalIpsWithOptionsAsync(DescribeAllLocalIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAllLocalIpsResponse>(await DoRPCRequestAsync("DescribeAllLocalIps", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAllLocalIpsResponse DescribeAllLocalIps(DescribeAllLocalIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAllLocalIpsWithOptions(request, runtime);
        }

        public async Task<DescribeAllLocalIpsResponse> DescribeAllLocalIpsAsync(DescribeAllLocalIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAllLocalIpsWithOptionsAsync(request, runtime);
        }

        public DescribeAppDailyDetailsResponse DescribeAppDailyDetailsWithOptions(DescribeAppDailyDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppDailyDetailsResponse>(DoRPCRequest("DescribeAppDailyDetails", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAppDailyDetailsResponse> DescribeAppDailyDetailsWithOptionsAsync(DescribeAppDailyDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppDailyDetailsResponse>(await DoRPCRequestAsync("DescribeAppDailyDetails", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAppDailyDetailsResponse DescribeAppDailyDetails(DescribeAppDailyDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppDailyDetailsWithOptions(request, runtime);
        }

        public async Task<DescribeAppDailyDetailsResponse> DescribeAppDailyDetailsAsync(DescribeAppDailyDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppDailyDetailsWithOptionsAsync(request, runtime);
        }

        public DescribeAppDailySdkVersionsResponse DescribeAppDailySdkVersionsWithOptions(DescribeAppDailySdkVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppDailySdkVersionsResponse>(DoRPCRequest("DescribeAppDailySdkVersions", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAppDailySdkVersionsResponse> DescribeAppDailySdkVersionsWithOptionsAsync(DescribeAppDailySdkVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppDailySdkVersionsResponse>(await DoRPCRequestAsync("DescribeAppDailySdkVersions", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAppDailySdkVersionsResponse DescribeAppDailySdkVersions(DescribeAppDailySdkVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppDailySdkVersionsWithOptions(request, runtime);
        }

        public async Task<DescribeAppDailySdkVersionsResponse> DescribeAppDailySdkVersionsAsync(DescribeAppDailySdkVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppDailySdkVersionsWithOptionsAsync(request, runtime);
        }

        public DescribeAppListResponse DescribeAppListWithOptions(DescribeAppListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppListResponse>(DoRPCRequest("DescribeAppList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAppListResponse> DescribeAppListWithOptionsAsync(DescribeAppListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppListResponse>(await DoRPCRequestAsync("DescribeAppList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAppListResponse DescribeAppList(DescribeAppListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppListWithOptions(request, runtime);
        }

        public async Task<DescribeAppListResponse> DescribeAppListAsync(DescribeAppListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppListWithOptionsAsync(request, runtime);
        }

        public DescribeAppSimpleListResponse DescribeAppSimpleListWithOptions(DescribeAppSimpleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppSimpleListResponse>(DoRPCRequest("DescribeAppSimpleList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAppSimpleListResponse> DescribeAppSimpleListWithOptionsAsync(DescribeAppSimpleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppSimpleListResponse>(await DoRPCRequestAsync("DescribeAppSimpleList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAppSimpleListResponse DescribeAppSimpleList(DescribeAppSimpleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppSimpleListWithOptions(request, runtime);
        }

        public async Task<DescribeAppSimpleListResponse> DescribeAppSimpleListAsync(DescribeAppSimpleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppSimpleListWithOptionsAsync(request, runtime);
        }

        public DescribeAsyncOperationResponse DescribeAsyncOperationWithOptions(DescribeAsyncOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAsyncOperationResponse>(DoRPCRequest("DescribeAsyncOperation", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAsyncOperationResponse> DescribeAsyncOperationWithOptionsAsync(DescribeAsyncOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAsyncOperationResponse>(await DoRPCRequestAsync("DescribeAsyncOperation", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAsyncOperationResponse DescribeAsyncOperation(DescribeAsyncOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAsyncOperationWithOptions(request, runtime);
        }

        public async Task<DescribeAsyncOperationResponse> DescribeAsyncOperationAsync(DescribeAsyncOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAsyncOperationWithOptionsAsync(request, runtime);
        }

        public DescribeAutomaticTraceabilitySlsLogResponse DescribeAutomaticTraceabilitySlsLogWithOptions(DescribeAutomaticTraceabilitySlsLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutomaticTraceabilitySlsLogResponse>(DoRPCRequest("DescribeAutomaticTraceabilitySlsLog", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAutomaticTraceabilitySlsLogResponse> DescribeAutomaticTraceabilitySlsLogWithOptionsAsync(DescribeAutomaticTraceabilitySlsLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutomaticTraceabilitySlsLogResponse>(await DoRPCRequestAsync("DescribeAutomaticTraceabilitySlsLog", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAutomaticTraceabilitySlsLogResponse DescribeAutomaticTraceabilitySlsLog(DescribeAutomaticTraceabilitySlsLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutomaticTraceabilitySlsLogWithOptions(request, runtime);
        }

        public async Task<DescribeAutomaticTraceabilitySlsLogResponse> DescribeAutomaticTraceabilitySlsLogAsync(DescribeAutomaticTraceabilitySlsLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutomaticTraceabilitySlsLogWithOptionsAsync(request, runtime);
        }

        public DescribeBgpResSummaryResponse DescribeBgpResSummaryWithOptions(DescribeBgpResSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBgpResSummaryResponse>(DoRPCRequest("DescribeBgpResSummary", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBgpResSummaryResponse> DescribeBgpResSummaryWithOptionsAsync(DescribeBgpResSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBgpResSummaryResponse>(await DoRPCRequestAsync("DescribeBgpResSummary", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBgpResSummaryResponse DescribeBgpResSummary(DescribeBgpResSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBgpResSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeBgpResSummaryResponse> DescribeBgpResSummaryAsync(DescribeBgpResSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBgpResSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeBizListResponse DescribeBizListWithOptions(DescribeBizListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBizListResponse>(DoRPCRequest("DescribeBizList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBizListResponse> DescribeBizListWithOptionsAsync(DescribeBizListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBizListResponse>(await DoRPCRequestAsync("DescribeBizList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBizListResponse DescribeBizList(DescribeBizListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBizListWithOptions(request, runtime);
        }

        public async Task<DescribeBizListResponse> DescribeBizListAsync(DescribeBizListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBizListWithOptionsAsync(request, runtime);
        }

        public DescribeBizSimpleListResponse DescribeBizSimpleListWithOptions(DescribeBizSimpleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBizSimpleListResponse>(DoRPCRequest("DescribeBizSimpleList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBizSimpleListResponse> DescribeBizSimpleListWithOptionsAsync(DescribeBizSimpleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBizSimpleListResponse>(await DoRPCRequestAsync("DescribeBizSimpleList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBizSimpleListResponse DescribeBizSimpleList(DescribeBizSimpleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBizSimpleListWithOptions(request, runtime);
        }

        public async Task<DescribeBizSimpleListResponse> DescribeBizSimpleListAsync(DescribeBizSimpleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBizSimpleListWithOptionsAsync(request, runtime);
        }

        public DescribeBpsFlowResponse DescribeBpsFlowWithOptions(DescribeBpsFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBpsFlowResponse>(DoRPCRequest("DescribeBpsFlow", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBpsFlowResponse> DescribeBpsFlowWithOptionsAsync(DescribeBpsFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBpsFlowResponse>(await DoRPCRequestAsync("DescribeBpsFlow", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBpsFlowResponse DescribeBpsFlow(DescribeBpsFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBpsFlowWithOptions(request, runtime);
        }

        public async Task<DescribeBpsFlowResponse> DescribeBpsFlowAsync(DescribeBpsFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBpsFlowWithOptionsAsync(request, runtime);
        }

        public DescribeCcBlackListResponse DescribeCcBlackListWithOptions(DescribeCcBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcBlackListResponse>(DoRPCRequest("DescribeCcBlackList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcBlackListResponse> DescribeCcBlackListWithOptionsAsync(DescribeCcBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcBlackListResponse>(await DoRPCRequestAsync("DescribeCcBlackList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcBlackListResponse DescribeCcBlackList(DescribeCcBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcBlackListWithOptions(request, runtime);
        }

        public async Task<DescribeCcBlackListResponse> DescribeCcBlackListAsync(DescribeCcBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcBlackListWithOptionsAsync(request, runtime);
        }

        public DescribeCcDevieIpListResponse DescribeCcDevieIpListWithOptions(DescribeCcDevieIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcDevieIpListResponse>(DoRPCRequest("DescribeCcDevieIpList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcDevieIpListResponse> DescribeCcDevieIpListWithOptionsAsync(DescribeCcDevieIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcDevieIpListResponse>(await DoRPCRequestAsync("DescribeCcDevieIpList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcDevieIpListResponse DescribeCcDevieIpList(DescribeCcDevieIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcDevieIpListWithOptions(request, runtime);
        }

        public async Task<DescribeCcDevieIpListResponse> DescribeCcDevieIpListAsync(DescribeCcDevieIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcDevieIpListWithOptionsAsync(request, runtime);
        }

        public DescribeCcFlowResponse DescribeCcFlowWithOptions(DescribeCcFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcFlowResponse>(DoRPCRequest("DescribeCcFlow", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcFlowResponse> DescribeCcFlowWithOptionsAsync(DescribeCcFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcFlowResponse>(await DoRPCRequestAsync("DescribeCcFlow", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcFlowResponse DescribeCcFlow(DescribeCcFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcFlowWithOptions(request, runtime);
        }

        public async Task<DescribeCcFlowResponse> DescribeCcFlowAsync(DescribeCcFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcFlowWithOptionsAsync(request, runtime);
        }

        public DescribeCcIDCBlockSwitchResponse DescribeCcIDCBlockSwitchWithOptions(DescribeCcIDCBlockSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcIDCBlockSwitchResponse>(DoRPCRequest("DescribeCcIDCBlockSwitch", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcIDCBlockSwitchResponse> DescribeCcIDCBlockSwitchWithOptionsAsync(DescribeCcIDCBlockSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcIDCBlockSwitchResponse>(await DoRPCRequestAsync("DescribeCcIDCBlockSwitch", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcIDCBlockSwitchResponse DescribeCcIDCBlockSwitch(DescribeCcIDCBlockSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcIDCBlockSwitchWithOptions(request, runtime);
        }

        public async Task<DescribeCcIDCBlockSwitchResponse> DescribeCcIDCBlockSwitchAsync(DescribeCcIDCBlockSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcIDCBlockSwitchWithOptionsAsync(request, runtime);
        }

        public DescribeCcMaxFwResponse DescribeCcMaxFwWithOptions(DescribeCcMaxFwRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcMaxFwResponse>(DoRPCRequest("DescribeCcMaxFw", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcMaxFwResponse> DescribeCcMaxFwWithOptionsAsync(DescribeCcMaxFwRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcMaxFwResponse>(await DoRPCRequestAsync("DescribeCcMaxFw", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcMaxFwResponse DescribeCcMaxFw(DescribeCcMaxFwRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcMaxFwWithOptions(request, runtime);
        }

        public async Task<DescribeCcMaxFwResponse> DescribeCcMaxFwAsync(DescribeCcMaxFwRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcMaxFwWithOptionsAsync(request, runtime);
        }

        public DescribeCcResSummaryResponse DescribeCcResSummaryWithOptions(DescribeCcResSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcResSummaryResponse>(DoRPCRequest("DescribeCcResSummary", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcResSummaryResponse> DescribeCcResSummaryWithOptionsAsync(DescribeCcResSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcResSummaryResponse>(await DoRPCRequestAsync("DescribeCcResSummary", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcResSummaryResponse DescribeCcResSummary(DescribeCcResSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcResSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeCcResSummaryResponse> DescribeCcResSummaryAsync(DescribeCcResSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcResSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeCcRouteRulesResponse DescribeCcRouteRulesWithOptions(DescribeCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcRouteRulesResponse>(DoRPCRequest("DescribeCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcRouteRulesResponse> DescribeCcRouteRulesWithOptionsAsync(DescribeCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcRouteRulesResponse>(await DoRPCRequestAsync("DescribeCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcRouteRulesResponse DescribeCcRouteRules(DescribeCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcRouteRulesWithOptions(request, runtime);
        }

        public async Task<DescribeCcRouteRulesResponse> DescribeCcRouteRulesAsync(DescribeCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcRouteRulesWithOptionsAsync(request, runtime);
        }

        public DescribeCcRouteSwitchResponse DescribeCcRouteSwitchWithOptions(DescribeCcRouteSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcRouteSwitchResponse>(DoRPCRequest("DescribeCcRouteSwitch", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcRouteSwitchResponse> DescribeCcRouteSwitchWithOptionsAsync(DescribeCcRouteSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcRouteSwitchResponse>(await DoRPCRequestAsync("DescribeCcRouteSwitch", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcRouteSwitchResponse DescribeCcRouteSwitch(DescribeCcRouteSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcRouteSwitchWithOptions(request, runtime);
        }

        public async Task<DescribeCcRouteSwitchResponse> DescribeCcRouteSwitchAsync(DescribeCcRouteSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcRouteSwitchWithOptionsAsync(request, runtime);
        }

        public DescribeCcSocketDetailResponse DescribeCcSocketDetailWithOptions(DescribeCcSocketDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcSocketDetailResponse>(DoRPCRequest("DescribeCcSocketDetail", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcSocketDetailResponse> DescribeCcSocketDetailWithOptionsAsync(DescribeCcSocketDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcSocketDetailResponse>(await DoRPCRequestAsync("DescribeCcSocketDetail", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcSocketDetailResponse DescribeCcSocketDetail(DescribeCcSocketDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcSocketDetailWithOptions(request, runtime);
        }

        public async Task<DescribeCcSocketDetailResponse> DescribeCcSocketDetailAsync(DescribeCcSocketDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcSocketDetailWithOptionsAsync(request, runtime);
        }

        public DescribeCcTotalFwResponse DescribeCcTotalFwWithOptions(DescribeCcTotalFwRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcTotalFwResponse>(DoRPCRequest("DescribeCcTotalFw", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcTotalFwResponse> DescribeCcTotalFwWithOptionsAsync(DescribeCcTotalFwRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcTotalFwResponse>(await DoRPCRequestAsync("DescribeCcTotalFw", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcTotalFwResponse DescribeCcTotalFw(DescribeCcTotalFwRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcTotalFwWithOptions(request, runtime);
        }

        public async Task<DescribeCcTotalFwResponse> DescribeCcTotalFwAsync(DescribeCcTotalFwRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcTotalFwWithOptionsAsync(request, runtime);
        }

        public DescribeCcTunnelResponse DescribeCcTunnelWithOptions(DescribeCcTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcTunnelResponse>(DoRPCRequest("DescribeCcTunnel", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcTunnelResponse> DescribeCcTunnelWithOptionsAsync(DescribeCcTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcTunnelResponse>(await DoRPCRequestAsync("DescribeCcTunnel", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcTunnelResponse DescribeCcTunnel(DescribeCcTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcTunnelWithOptions(request, runtime);
        }

        public async Task<DescribeCcTunnelResponse> DescribeCcTunnelAsync(DescribeCcTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcTunnelWithOptionsAsync(request, runtime);
        }

        public DescribeCcWhiteListResponse DescribeCcWhiteListWithOptions(DescribeCcWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcWhiteListResponse>(DoRPCRequest("DescribeCcWhiteList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcWhiteListResponse> DescribeCcWhiteListWithOptionsAsync(DescribeCcWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcWhiteListResponse>(await DoRPCRequestAsync("DescribeCcWhiteList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcWhiteListResponse DescribeCcWhiteList(DescribeCcWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcWhiteListWithOptions(request, runtime);
        }

        public async Task<DescribeCcWhiteListResponse> DescribeCcWhiteListAsync(DescribeCcWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcWhiteListWithOptionsAsync(request, runtime);
        }

        public DescribeCcZoneBlockConfigResponse DescribeCcZoneBlockConfigWithOptions(DescribeCcZoneBlockConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcZoneBlockConfigResponse>(DoRPCRequest("DescribeCcZoneBlockConfig", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcZoneBlockConfigResponse> DescribeCcZoneBlockConfigWithOptionsAsync(DescribeCcZoneBlockConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcZoneBlockConfigResponse>(await DoRPCRequestAsync("DescribeCcZoneBlockConfig", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcZoneBlockConfigResponse DescribeCcZoneBlockConfig(DescribeCcZoneBlockConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcZoneBlockConfigWithOptions(request, runtime);
        }

        public async Task<DescribeCcZoneBlockConfigResponse> DescribeCcZoneBlockConfigAsync(DescribeCcZoneBlockConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcZoneBlockConfigWithOptionsAsync(request, runtime);
        }

        public DescribeCcZonesResponse DescribeCcZonesWithOptions(DescribeCcZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcZonesResponse>(DoRPCRequest("DescribeCcZones", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcZonesResponse> DescribeCcZonesWithOptionsAsync(DescribeCcZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcZonesResponse>(await DoRPCRequestAsync("DescribeCcZones", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcZonesResponse DescribeCcZones(DescribeCcZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcZonesWithOptions(request, runtime);
        }

        public async Task<DescribeCcZonesResponse> DescribeCcZonesAsync(DescribeCcZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcZonesWithOptionsAsync(request, runtime);
        }

        public DescribeDailyDetailsResponse DescribeDailyDetailsWithOptions(DescribeDailyDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDailyDetailsResponse>(DoRPCRequest("DescribeDailyDetails", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDailyDetailsResponse> DescribeDailyDetailsWithOptionsAsync(DescribeDailyDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDailyDetailsResponse>(await DoRPCRequestAsync("DescribeDailyDetails", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDailyDetailsResponse DescribeDailyDetails(DescribeDailyDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDailyDetailsWithOptions(request, runtime);
        }

        public async Task<DescribeDailyDetailsResponse> DescribeDailyDetailsAsync(DescribeDailyDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDailyDetailsWithOptionsAsync(request, runtime);
        }

        public DescribeDownloadUrlsForAppKeyResponse DescribeDownloadUrlsForAppKeyWithOptions(DescribeDownloadUrlsForAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDownloadUrlsForAppKeyResponse>(DoRPCRequest("DescribeDownloadUrlsForAppKey", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDownloadUrlsForAppKeyResponse> DescribeDownloadUrlsForAppKeyWithOptionsAsync(DescribeDownloadUrlsForAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDownloadUrlsForAppKeyResponse>(await DoRPCRequestAsync("DescribeDownloadUrlsForAppKey", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDownloadUrlsForAppKeyResponse DescribeDownloadUrlsForAppKey(DescribeDownloadUrlsForAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDownloadUrlsForAppKeyWithOptions(request, runtime);
        }

        public async Task<DescribeDownloadUrlsForAppKeyResponse> DescribeDownloadUrlsForAppKeyAsync(DescribeDownloadUrlsForAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDownloadUrlsForAppKeyWithOptionsAsync(request, runtime);
        }

        public DescribeDownloadUrlsForSDKResponse DescribeDownloadUrlsForSDKWithOptions(DescribeDownloadUrlsForSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDownloadUrlsForSDKResponse>(DoRPCRequest("DescribeDownloadUrlsForSDK", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDownloadUrlsForSDKResponse> DescribeDownloadUrlsForSDKWithOptionsAsync(DescribeDownloadUrlsForSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDownloadUrlsForSDKResponse>(await DoRPCRequestAsync("DescribeDownloadUrlsForSDK", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDownloadUrlsForSDKResponse DescribeDownloadUrlsForSDK(DescribeDownloadUrlsForSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDownloadUrlsForSDKWithOptions(request, runtime);
        }

        public async Task<DescribeDownloadUrlsForSDKResponse> DescribeDownloadUrlsForSDKAsync(DescribeDownloadUrlsForSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDownloadUrlsForSDKWithOptionsAsync(request, runtime);
        }

        public DescribeFlexAccConfigResponse DescribeFlexAccConfigWithOptions(DescribeFlexAccConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexAccConfigResponse>(DoRPCRequest("DescribeFlexAccConfig", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlexAccConfigResponse> DescribeFlexAccConfigWithOptionsAsync(DescribeFlexAccConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexAccConfigResponse>(await DoRPCRequestAsync("DescribeFlexAccConfig", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlexAccConfigResponse DescribeFlexAccConfig(DescribeFlexAccConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlexAccConfigWithOptions(request, runtime);
        }

        public async Task<DescribeFlexAccConfigResponse> DescribeFlexAccConfigAsync(DescribeFlexAccConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlexAccConfigWithOptionsAsync(request, runtime);
        }

        public DescribeFlexAccFlowResponse DescribeFlexAccFlowWithOptions(DescribeFlexAccFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexAccFlowResponse>(DoRPCRequest("DescribeFlexAccFlow", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlexAccFlowResponse> DescribeFlexAccFlowWithOptionsAsync(DescribeFlexAccFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexAccFlowResponse>(await DoRPCRequestAsync("DescribeFlexAccFlow", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlexAccFlowResponse DescribeFlexAccFlow(DescribeFlexAccFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlexAccFlowWithOptions(request, runtime);
        }

        public async Task<DescribeFlexAccFlowResponse> DescribeFlexAccFlowAsync(DescribeFlexAccFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlexAccFlowWithOptionsAsync(request, runtime);
        }

        public DescribeFlexAccFwdRulesResponse DescribeFlexAccFwdRulesWithOptions(DescribeFlexAccFwdRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexAccFwdRulesResponse>(DoRPCRequest("DescribeFlexAccFwdRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlexAccFwdRulesResponse> DescribeFlexAccFwdRulesWithOptionsAsync(DescribeFlexAccFwdRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexAccFwdRulesResponse>(await DoRPCRequestAsync("DescribeFlexAccFwdRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlexAccFwdRulesResponse DescribeFlexAccFwdRules(DescribeFlexAccFwdRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlexAccFwdRulesWithOptions(request, runtime);
        }

        public async Task<DescribeFlexAccFwdRulesResponse> DescribeFlexAccFwdRulesAsync(DescribeFlexAccFwdRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlexAccFwdRulesWithOptionsAsync(request, runtime);
        }

        public DescribeFlexBackupGroupsResponse DescribeFlexBackupGroupsWithOptions(DescribeFlexBackupGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexBackupGroupsResponse>(DoRPCRequest("DescribeFlexBackupGroups", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlexBackupGroupsResponse> DescribeFlexBackupGroupsWithOptionsAsync(DescribeFlexBackupGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexBackupGroupsResponse>(await DoRPCRequestAsync("DescribeFlexBackupGroups", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlexBackupGroupsResponse DescribeFlexBackupGroups(DescribeFlexBackupGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlexBackupGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeFlexBackupGroupsResponse> DescribeFlexBackupGroupsAsync(DescribeFlexBackupGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlexBackupGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeFlexConfigResponse DescribeFlexConfigWithOptions(DescribeFlexConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexConfigResponse>(DoRPCRequest("DescribeFlexConfig", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlexConfigResponse> DescribeFlexConfigWithOptionsAsync(DescribeFlexConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexConfigResponse>(await DoRPCRequestAsync("DescribeFlexConfig", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlexConfigResponse DescribeFlexConfig(DescribeFlexConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlexConfigWithOptions(request, runtime);
        }

        public async Task<DescribeFlexConfigResponse> DescribeFlexConfigAsync(DescribeFlexConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlexConfigWithOptionsAsync(request, runtime);
        }

        public DescribeFlexFwdRulesResponse DescribeFlexFwdRulesWithOptions(DescribeFlexFwdRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexFwdRulesResponse>(DoRPCRequest("DescribeFlexFwdRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlexFwdRulesResponse> DescribeFlexFwdRulesWithOptionsAsync(DescribeFlexFwdRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexFwdRulesResponse>(await DoRPCRequestAsync("DescribeFlexFwdRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlexFwdRulesResponse DescribeFlexFwdRules(DescribeFlexFwdRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlexFwdRulesWithOptions(request, runtime);
        }

        public async Task<DescribeFlexFwdRulesResponse> DescribeFlexFwdRulesAsync(DescribeFlexFwdRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlexFwdRulesWithOptionsAsync(request, runtime);
        }

        public DescribeFlexSechedPolicyResponse DescribeFlexSechedPolicyWithOptions(DescribeFlexSechedPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexSechedPolicyResponse>(DoRPCRequest("DescribeFlexSechedPolicy", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlexSechedPolicyResponse> DescribeFlexSechedPolicyWithOptionsAsync(DescribeFlexSechedPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexSechedPolicyResponse>(await DoRPCRequestAsync("DescribeFlexSechedPolicy", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlexSechedPolicyResponse DescribeFlexSechedPolicy(DescribeFlexSechedPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlexSechedPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeFlexSechedPolicyResponse> DescribeFlexSechedPolicyAsync(DescribeFlexSechedPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlexSechedPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeFlowReportResponse DescribeFlowReportWithOptions(DescribeFlowReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowReportResponse>(DoRPCRequest("DescribeFlowReport", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowReportResponse> DescribeFlowReportWithOptionsAsync(DescribeFlowReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowReportResponse>(await DoRPCRequestAsync("DescribeFlowReport", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowReportResponse DescribeFlowReport(DescribeFlowReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowReportWithOptions(request, runtime);
        }

        public async Task<DescribeFlowReportResponse> DescribeFlowReportAsync(DescribeFlowReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowReportWithOptionsAsync(request, runtime);
        }

        public DescribeFullNodesResponse DescribeFullNodesWithOptions(DescribeFullNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFullNodesResponse>(DoRPCRequest("DescribeFullNodes", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFullNodesResponse> DescribeFullNodesWithOptionsAsync(DescribeFullNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFullNodesResponse>(await DoRPCRequestAsync("DescribeFullNodes", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFullNodesResponse DescribeFullNodes(DescribeFullNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFullNodesWithOptions(request, runtime);
        }

        public async Task<DescribeFullNodesResponse> DescribeFullNodesAsync(DescribeFullNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFullNodesWithOptionsAsync(request, runtime);
        }

        public DescribeFullNodesSummaryResponse DescribeFullNodesSummaryWithOptions(DescribeFullNodesSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFullNodesSummaryResponse>(DoRPCRequest("DescribeFullNodesSummary", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFullNodesSummaryResponse> DescribeFullNodesSummaryWithOptionsAsync(DescribeFullNodesSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFullNodesSummaryResponse>(await DoRPCRequestAsync("DescribeFullNodesSummary", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFullNodesSummaryResponse DescribeFullNodesSummary(DescribeFullNodesSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFullNodesSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeFullNodesSummaryResponse> DescribeFullNodesSummaryAsync(DescribeFullNodesSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFullNodesSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeGfResSummaryResponse DescribeGfResSummaryWithOptions(DescribeGfResSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGfResSummaryResponse>(DoRPCRequest("DescribeGfResSummary", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGfResSummaryResponse> DescribeGfResSummaryWithOptionsAsync(DescribeGfResSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGfResSummaryResponse>(await DoRPCRequestAsync("DescribeGfResSummary", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGfResSummaryResponse DescribeGfResSummary(DescribeGfResSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGfResSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeGfResSummaryResponse> DescribeGfResSummaryAsync(DescribeGfResSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGfResSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeGroupListResponse DescribeGroupListWithOptions(DescribeGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupListResponse>(DoRPCRequest("DescribeGroupList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupListResponse> DescribeGroupListWithOptionsAsync(DescribeGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupListResponse>(await DoRPCRequestAsync("DescribeGroupList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupListResponse DescribeGroupList(DescribeGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupListWithOptions(request, runtime);
        }

        public async Task<DescribeGroupListResponse> DescribeGroupListAsync(DescribeGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupListWithOptionsAsync(request, runtime);
        }

        public DescribeGroupSimpleListResponse DescribeGroupSimpleListWithOptions(DescribeGroupSimpleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupSimpleListResponse>(DoRPCRequest("DescribeGroupSimpleList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupSimpleListResponse> DescribeGroupSimpleListWithOptionsAsync(DescribeGroupSimpleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupSimpleListResponse>(await DoRPCRequestAsync("DescribeGroupSimpleList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupSimpleListResponse DescribeGroupSimpleList(DescribeGroupSimpleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupSimpleListWithOptions(request, runtime);
        }

        public async Task<DescribeGroupSimpleListResponse> DescribeGroupSimpleListAsync(DescribeGroupSimpleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupSimpleListWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceResponse DescribeInstanceWithOptions(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(DoRPCRequest("DescribeInstance", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await DoRPCRequestAsync("DescribeInstance", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeIpFlowReportResponse DescribeIpFlowReportWithOptions(DescribeIpFlowReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpFlowReportResponse>(DoRPCRequest("DescribeIpFlowReport", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpFlowReportResponse> DescribeIpFlowReportWithOptionsAsync(DescribeIpFlowReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpFlowReportResponse>(await DoRPCRequestAsync("DescribeIpFlowReport", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIpFlowReportResponse DescribeIpFlowReport(DescribeIpFlowReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpFlowReportWithOptions(request, runtime);
        }

        public async Task<DescribeIpFlowReportResponse> DescribeIpFlowReportAsync(DescribeIpFlowReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpFlowReportWithOptionsAsync(request, runtime);
        }

        public DescribeJianYuTestGetResponse DescribeJianYuTestGetWithOptions(DescribeJianYuTestGetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJianYuTestGetResponse>(DoRPCRequest("DescribeJianYuTestGet", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeJianYuTestGetResponse> DescribeJianYuTestGetWithOptionsAsync(DescribeJianYuTestGetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJianYuTestGetResponse>(await DoRPCRequestAsync("DescribeJianYuTestGet", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeJianYuTestGetResponse DescribeJianYuTestGet(DescribeJianYuTestGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJianYuTestGetWithOptions(request, runtime);
        }

        public async Task<DescribeJianYuTestGetResponse> DescribeJianYuTestGetAsync(DescribeJianYuTestGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJianYuTestGetWithOptionsAsync(request, runtime);
        }

        public DescribeJianYuTestListResponse DescribeJianYuTestListWithOptions(DescribeJianYuTestListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJianYuTestListResponse>(DoRPCRequest("DescribeJianYuTestList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeJianYuTestListResponse> DescribeJianYuTestListWithOptionsAsync(DescribeJianYuTestListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJianYuTestListResponse>(await DoRPCRequestAsync("DescribeJianYuTestList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeJianYuTestListResponse DescribeJianYuTestList(DescribeJianYuTestListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJianYuTestListWithOptions(request, runtime);
        }

        public async Task<DescribeJianYuTestListResponse> DescribeJianYuTestListAsync(DescribeJianYuTestListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJianYuTestListWithOptionsAsync(request, runtime);
        }

        public DescribeJianYuTestPaginationResponse DescribeJianYuTestPaginationWithOptions(DescribeJianYuTestPaginationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJianYuTestPaginationResponse>(DoRPCRequest("DescribeJianYuTestPagination", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeJianYuTestPaginationResponse> DescribeJianYuTestPaginationWithOptionsAsync(DescribeJianYuTestPaginationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJianYuTestPaginationResponse>(await DoRPCRequestAsync("DescribeJianYuTestPagination", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeJianYuTestPaginationResponse DescribeJianYuTestPagination(DescribeJianYuTestPaginationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJianYuTestPaginationWithOptions(request, runtime);
        }

        public async Task<DescribeJianYuTestPaginationResponse> DescribeJianYuTestPaginationAsync(DescribeJianYuTestPaginationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJianYuTestPaginationWithOptionsAsync(request, runtime);
        }

        public DescribeL4EventsSelectiveResponse DescribeL4EventsSelectiveWithOptions(DescribeL4EventsSelectiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeL4EventsSelectiveResponse>(DoRPCRequest("DescribeL4EventsSelective", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeL4EventsSelectiveResponse> DescribeL4EventsSelectiveWithOptionsAsync(DescribeL4EventsSelectiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeL4EventsSelectiveResponse>(await DoRPCRequestAsync("DescribeL4EventsSelective", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeL4EventsSelectiveResponse DescribeL4EventsSelective(DescribeL4EventsSelectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeL4EventsSelectiveWithOptions(request, runtime);
        }

        public async Task<DescribeL4EventsSelectiveResponse> DescribeL4EventsSelectiveAsync(DescribeL4EventsSelectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeL4EventsSelectiveWithOptionsAsync(request, runtime);
        }

        public DescribeLayer4RulesResponse DescribeLayer4RulesWithOptions(DescribeLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLayer4RulesResponse>(DoRPCRequest("DescribeLayer4Rules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLayer4RulesResponse> DescribeLayer4RulesWithOptionsAsync(DescribeLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLayer4RulesResponse>(await DoRPCRequestAsync("DescribeLayer4Rules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeMianLiuResSummaryResponse DescribeMianLiuResSummaryWithOptions(DescribeMianLiuResSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMianLiuResSummaryResponse>(DoRPCRequest("DescribeMianLiuResSummary", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMianLiuResSummaryResponse> DescribeMianLiuResSummaryWithOptionsAsync(DescribeMianLiuResSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMianLiuResSummaryResponse>(await DoRPCRequestAsync("DescribeMianLiuResSummary", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMianLiuResSummaryResponse DescribeMianLiuResSummary(DescribeMianLiuResSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMianLiuResSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeMianLiuResSummaryResponse> DescribeMianLiuResSummaryAsync(DescribeMianLiuResSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMianLiuResSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeNgSourceDiagnosisLogResponse DescribeNgSourceDiagnosisLogWithOptions(DescribeNgSourceDiagnosisLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNgSourceDiagnosisLogResponse>(DoRPCRequest("DescribeNgSourceDiagnosisLog", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNgSourceDiagnosisLogResponse> DescribeNgSourceDiagnosisLogWithOptionsAsync(DescribeNgSourceDiagnosisLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNgSourceDiagnosisLogResponse>(await DoRPCRequestAsync("DescribeNgSourceDiagnosisLog", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNgSourceDiagnosisLogResponse DescribeNgSourceDiagnosisLog(DescribeNgSourceDiagnosisLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNgSourceDiagnosisLogWithOptions(request, runtime);
        }

        public async Task<DescribeNgSourceDiagnosisLogResponse> DescribeNgSourceDiagnosisLogAsync(DescribeNgSourceDiagnosisLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNgSourceDiagnosisLogWithOptionsAsync(request, runtime);
        }

        public DescribeRemainQpsResponse DescribeRemainQpsWithOptions(DescribeRemainQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRemainQpsResponse>(DoRPCRequest("DescribeRemainQps", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRemainQpsResponse> DescribeRemainQpsWithOptionsAsync(DescribeRemainQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRemainQpsResponse>(await DoRPCRequestAsync("DescribeRemainQps", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRemainQpsResponse DescribeRemainQps(DescribeRemainQpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRemainQpsWithOptions(request, runtime);
        }

        public async Task<DescribeRemainQpsResponse> DescribeRemainQpsAsync(DescribeRemainQpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRemainQpsWithOptionsAsync(request, runtime);
        }

        public DescribeRequestStatisticByEsnBizIntervalResponse DescribeRequestStatisticByEsnBizIntervalWithOptions(DescribeRequestStatisticByEsnBizIntervalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticByEsnBizIntervalResponse>(DoRPCRequest("DescribeRequestStatisticByEsnBizInterval", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRequestStatisticByEsnBizIntervalResponse> DescribeRequestStatisticByEsnBizIntervalWithOptionsAsync(DescribeRequestStatisticByEsnBizIntervalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticByEsnBizIntervalResponse>(await DoRPCRequestAsync("DescribeRequestStatisticByEsnBizInterval", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRequestStatisticByEsnBizIntervalResponse DescribeRequestStatisticByEsnBizInterval(DescribeRequestStatisticByEsnBizIntervalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRequestStatisticByEsnBizIntervalWithOptions(request, runtime);
        }

        public async Task<DescribeRequestStatisticByEsnBizIntervalResponse> DescribeRequestStatisticByEsnBizIntervalAsync(DescribeRequestStatisticByEsnBizIntervalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRequestStatisticByEsnBizIntervalWithOptionsAsync(request, runtime);
        }

        public DescribeRequestStatisticCountByEsnBiz1DayResponse DescribeRequestStatisticCountByEsnBiz1DayWithOptions(DescribeRequestStatisticCountByEsnBiz1DayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticCountByEsnBiz1DayResponse>(DoRPCRequest("DescribeRequestStatisticCountByEsnBiz1Day", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRequestStatisticCountByEsnBiz1DayResponse> DescribeRequestStatisticCountByEsnBiz1DayWithOptionsAsync(DescribeRequestStatisticCountByEsnBiz1DayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticCountByEsnBiz1DayResponse>(await DoRPCRequestAsync("DescribeRequestStatisticCountByEsnBiz1Day", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRequestStatisticCountByEsnBiz1DayResponse DescribeRequestStatisticCountByEsnBiz1Day(DescribeRequestStatisticCountByEsnBiz1DayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRequestStatisticCountByEsnBiz1DayWithOptions(request, runtime);
        }

        public async Task<DescribeRequestStatisticCountByEsnBiz1DayResponse> DescribeRequestStatisticCountByEsnBiz1DayAsync(DescribeRequestStatisticCountByEsnBiz1DayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRequestStatisticCountByEsnBiz1DayWithOptionsAsync(request, runtime);
        }

        public DescribeRequestStatisticCountByEsnBiz1DayProvinceResponse DescribeRequestStatisticCountByEsnBiz1DayProvinceWithOptions(DescribeRequestStatisticCountByEsnBiz1DayProvinceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticCountByEsnBiz1DayProvinceResponse>(DoRPCRequest("DescribeRequestStatisticCountByEsnBiz1DayProvince", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRequestStatisticCountByEsnBiz1DayProvinceResponse> DescribeRequestStatisticCountByEsnBiz1DayProvinceWithOptionsAsync(DescribeRequestStatisticCountByEsnBiz1DayProvinceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticCountByEsnBiz1DayProvinceResponse>(await DoRPCRequestAsync("DescribeRequestStatisticCountByEsnBiz1DayProvince", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRequestStatisticCountByEsnBiz1DayProvinceResponse DescribeRequestStatisticCountByEsnBiz1DayProvince(DescribeRequestStatisticCountByEsnBiz1DayProvinceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRequestStatisticCountByEsnBiz1DayProvinceWithOptions(request, runtime);
        }

        public async Task<DescribeRequestStatisticCountByEsnBiz1DayProvinceResponse> DescribeRequestStatisticCountByEsnBiz1DayProvinceAsync(DescribeRequestStatisticCountByEsnBiz1DayProvinceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRequestStatisticCountByEsnBiz1DayProvinceWithOptionsAsync(request, runtime);
        }

        public DescribeRequestStatisticCountByEsnBiz1M30MResponse DescribeRequestStatisticCountByEsnBiz1M30MWithOptions(DescribeRequestStatisticCountByEsnBiz1M30MRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticCountByEsnBiz1M30MResponse>(DoRPCRequest("DescribeRequestStatisticCountByEsnBiz1M30M", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRequestStatisticCountByEsnBiz1M30MResponse> DescribeRequestStatisticCountByEsnBiz1M30MWithOptionsAsync(DescribeRequestStatisticCountByEsnBiz1M30MRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticCountByEsnBiz1M30MResponse>(await DoRPCRequestAsync("DescribeRequestStatisticCountByEsnBiz1M30M", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRequestStatisticCountByEsnBiz1M30MResponse DescribeRequestStatisticCountByEsnBiz1M30M(DescribeRequestStatisticCountByEsnBiz1M30MRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRequestStatisticCountByEsnBiz1M30MWithOptions(request, runtime);
        }

        public async Task<DescribeRequestStatisticCountByEsnBiz1M30MResponse> DescribeRequestStatisticCountByEsnBiz1M30MAsync(DescribeRequestStatisticCountByEsnBiz1M30MRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRequestStatisticCountByEsnBiz1M30MWithOptionsAsync(request, runtime);
        }

        public DescribeRequestStatisticCountByEsnBiz30MResponse DescribeRequestStatisticCountByEsnBiz30MWithOptions(DescribeRequestStatisticCountByEsnBiz30MRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticCountByEsnBiz30MResponse>(DoRPCRequest("DescribeRequestStatisticCountByEsnBiz30M", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRequestStatisticCountByEsnBiz30MResponse> DescribeRequestStatisticCountByEsnBiz30MWithOptionsAsync(DescribeRequestStatisticCountByEsnBiz30MRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticCountByEsnBiz30MResponse>(await DoRPCRequestAsync("DescribeRequestStatisticCountByEsnBiz30M", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRequestStatisticCountByEsnBiz30MResponse DescribeRequestStatisticCountByEsnBiz30M(DescribeRequestStatisticCountByEsnBiz30MRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRequestStatisticCountByEsnBiz30MWithOptions(request, runtime);
        }

        public async Task<DescribeRequestStatisticCountByEsnBiz30MResponse> DescribeRequestStatisticCountByEsnBiz30MAsync(DescribeRequestStatisticCountByEsnBiz30MRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRequestStatisticCountByEsnBiz30MWithOptionsAsync(request, runtime);
        }

        public DescribeRequestStatisticCountByEsnBizGroup30MResponse DescribeRequestStatisticCountByEsnBizGroup30MWithOptions(DescribeRequestStatisticCountByEsnBizGroup30MRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticCountByEsnBizGroup30MResponse>(DoRPCRequest("DescribeRequestStatisticCountByEsnBizGroup30M", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRequestStatisticCountByEsnBizGroup30MResponse> DescribeRequestStatisticCountByEsnBizGroup30MWithOptionsAsync(DescribeRequestStatisticCountByEsnBizGroup30MRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticCountByEsnBizGroup30MResponse>(await DoRPCRequestAsync("DescribeRequestStatisticCountByEsnBizGroup30M", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRequestStatisticCountByEsnBizGroup30MResponse DescribeRequestStatisticCountByEsnBizGroup30M(DescribeRequestStatisticCountByEsnBizGroup30MRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRequestStatisticCountByEsnBizGroup30MWithOptions(request, runtime);
        }

        public async Task<DescribeRequestStatisticCountByEsnBizGroup30MResponse> DescribeRequestStatisticCountByEsnBizGroup30MAsync(DescribeRequestStatisticCountByEsnBizGroup30MRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRequestStatisticCountByEsnBizGroup30MWithOptionsAsync(request, runtime);
        }

        public DescribeRequestStatisticLogResponse DescribeRequestStatisticLogWithOptions(DescribeRequestStatisticLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticLogResponse>(DoRPCRequest("DescribeRequestStatisticLog", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRequestStatisticLogResponse> DescribeRequestStatisticLogWithOptionsAsync(DescribeRequestStatisticLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestStatisticLogResponse>(await DoRPCRequestAsync("DescribeRequestStatisticLog", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRequestStatisticLogResponse DescribeRequestStatisticLog(DescribeRequestStatisticLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRequestStatisticLogWithOptions(request, runtime);
        }

        public async Task<DescribeRequestStatisticLogResponse> DescribeRequestStatisticLogAsync(DescribeRequestStatisticLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRequestStatisticLogWithOptionsAsync(request, runtime);
        }

        public DescribeSDKStatisticLogResponse DescribeSDKStatisticLogWithOptions(DescribeSDKStatisticLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSDKStatisticLogResponse>(DoRPCRequest("DescribeSDKStatisticLog", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSDKStatisticLogResponse> DescribeSDKStatisticLogWithOptionsAsync(DescribeSDKStatisticLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSDKStatisticLogResponse>(await DoRPCRequestAsync("DescribeSDKStatisticLog", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSDKStatisticLogResponse DescribeSDKStatisticLog(DescribeSDKStatisticLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSDKStatisticLogWithOptions(request, runtime);
        }

        public async Task<DescribeSDKStatisticLogResponse> DescribeSDKStatisticLogAsync(DescribeSDKStatisticLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSDKStatisticLogWithOptionsAsync(request, runtime);
        }

        public DescribeSDKStatisticResultByEsnBizISP1M30MResponse DescribeSDKStatisticResultByEsnBizISP1M30MWithOptions(DescribeSDKStatisticResultByEsnBizISP1M30MRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSDKStatisticResultByEsnBizISP1M30MResponse>(DoRPCRequest("DescribeSDKStatisticResultByEsnBizISP1M30M", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSDKStatisticResultByEsnBizISP1M30MResponse> DescribeSDKStatisticResultByEsnBizISP1M30MWithOptionsAsync(DescribeSDKStatisticResultByEsnBizISP1M30MRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSDKStatisticResultByEsnBizISP1M30MResponse>(await DoRPCRequestAsync("DescribeSDKStatisticResultByEsnBizISP1M30M", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSDKStatisticResultByEsnBizISP1M30MResponse DescribeSDKStatisticResultByEsnBizISP1M30M(DescribeSDKStatisticResultByEsnBizISP1M30MRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSDKStatisticResultByEsnBizISP1M30MWithOptions(request, runtime);
        }

        public async Task<DescribeSDKStatisticResultByEsnBizISP1M30MResponse> DescribeSDKStatisticResultByEsnBizISP1M30MAsync(DescribeSDKStatisticResultByEsnBizISP1M30MRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSDKStatisticResultByEsnBizISP1M30MWithOptionsAsync(request, runtime);
        }

        public DescribeSDKStatisticResultByEsnBizISPIntervalResponse DescribeSDKStatisticResultByEsnBizISPIntervalWithOptions(DescribeSDKStatisticResultByEsnBizISPIntervalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSDKStatisticResultByEsnBizISPIntervalResponse>(DoRPCRequest("DescribeSDKStatisticResultByEsnBizISPInterval", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSDKStatisticResultByEsnBizISPIntervalResponse> DescribeSDKStatisticResultByEsnBizISPIntervalWithOptionsAsync(DescribeSDKStatisticResultByEsnBizISPIntervalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSDKStatisticResultByEsnBizISPIntervalResponse>(await DoRPCRequestAsync("DescribeSDKStatisticResultByEsnBizISPInterval", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSDKStatisticResultByEsnBizISPIntervalResponse DescribeSDKStatisticResultByEsnBizISPInterval(DescribeSDKStatisticResultByEsnBizISPIntervalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSDKStatisticResultByEsnBizISPIntervalWithOptions(request, runtime);
        }

        public async Task<DescribeSDKStatisticResultByEsnBizISPIntervalResponse> DescribeSDKStatisticResultByEsnBizISPIntervalAsync(DescribeSDKStatisticResultByEsnBizISPIntervalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSDKStatisticResultByEsnBizISPIntervalWithOptionsAsync(request, runtime);
        }

        public DescribeSDKStatisticResultByEsnBizProvince1DayResponse DescribeSDKStatisticResultByEsnBizProvince1DayWithOptions(DescribeSDKStatisticResultByEsnBizProvince1DayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSDKStatisticResultByEsnBizProvince1DayResponse>(DoRPCRequest("DescribeSDKStatisticResultByEsnBizProvince1Day", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSDKStatisticResultByEsnBizProvince1DayResponse> DescribeSDKStatisticResultByEsnBizProvince1DayWithOptionsAsync(DescribeSDKStatisticResultByEsnBizProvince1DayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSDKStatisticResultByEsnBizProvince1DayResponse>(await DoRPCRequestAsync("DescribeSDKStatisticResultByEsnBizProvince1Day", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSDKStatisticResultByEsnBizProvince1DayResponse DescribeSDKStatisticResultByEsnBizProvince1Day(DescribeSDKStatisticResultByEsnBizProvince1DayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSDKStatisticResultByEsnBizProvince1DayWithOptions(request, runtime);
        }

        public async Task<DescribeSDKStatisticResultByEsnBizProvince1DayResponse> DescribeSDKStatisticResultByEsnBizProvince1DayAsync(DescribeSDKStatisticResultByEsnBizProvince1DayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSDKStatisticResultByEsnBizProvince1DayWithOptionsAsync(request, runtime);
        }

        public DescribeSDKStatisticResultByEsnBizProvince30MResponse DescribeSDKStatisticResultByEsnBizProvince30MWithOptions(DescribeSDKStatisticResultByEsnBizProvince30MRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSDKStatisticResultByEsnBizProvince30MResponse>(DoRPCRequest("DescribeSDKStatisticResultByEsnBizProvince30M", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSDKStatisticResultByEsnBizProvince30MResponse> DescribeSDKStatisticResultByEsnBizProvince30MWithOptionsAsync(DescribeSDKStatisticResultByEsnBizProvince30MRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSDKStatisticResultByEsnBizProvince30MResponse>(await DoRPCRequestAsync("DescribeSDKStatisticResultByEsnBizProvince30M", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSDKStatisticResultByEsnBizProvince30MResponse DescribeSDKStatisticResultByEsnBizProvince30M(DescribeSDKStatisticResultByEsnBizProvince30MRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSDKStatisticResultByEsnBizProvince30MWithOptions(request, runtime);
        }

        public async Task<DescribeSDKStatisticResultByEsnBizProvince30MResponse> DescribeSDKStatisticResultByEsnBizProvince30MAsync(DescribeSDKStatisticResultByEsnBizProvince30MRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSDKStatisticResultByEsnBizProvince30MWithOptionsAsync(request, runtime);
        }

        public DescribeSourceFailureTopIpResponse DescribeSourceFailureTopIpWithOptions(DescribeSourceFailureTopIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSourceFailureTopIpResponse>(DoRPCRequest("DescribeSourceFailureTopIp", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSourceFailureTopIpResponse> DescribeSourceFailureTopIpWithOptionsAsync(DescribeSourceFailureTopIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSourceFailureTopIpResponse>(await DoRPCRequestAsync("DescribeSourceFailureTopIp", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSourceFailureTopIpResponse DescribeSourceFailureTopIp(DescribeSourceFailureTopIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSourceFailureTopIpWithOptions(request, runtime);
        }

        public async Task<DescribeSourceFailureTopIpResponse> DescribeSourceFailureTopIpAsync(DescribeSourceFailureTopIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSourceFailureTopIpWithOptionsAsync(request, runtime);
        }

        public DescribeSourceFailureTrendGraphResponse DescribeSourceFailureTrendGraphWithOptions(DescribeSourceFailureTrendGraphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSourceFailureTrendGraphResponse>(DoRPCRequest("DescribeSourceFailureTrendGraph", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSourceFailureTrendGraphResponse> DescribeSourceFailureTrendGraphWithOptionsAsync(DescribeSourceFailureTrendGraphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSourceFailureTrendGraphResponse>(await DoRPCRequestAsync("DescribeSourceFailureTrendGraph", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSourceFailureTrendGraphResponse DescribeSourceFailureTrendGraph(DescribeSourceFailureTrendGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSourceFailureTrendGraphWithOptions(request, runtime);
        }

        public async Task<DescribeSourceFailureTrendGraphResponse> DescribeSourceFailureTrendGraphAsync(DescribeSourceFailureTrendGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSourceFailureTrendGraphWithOptionsAsync(request, runtime);
        }

        public DescribeUploadPreSignResponse DescribeUploadPreSignWithOptions(DescribeUploadPreSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUploadPreSignResponse>(DoRPCRequest("DescribeUploadPreSign", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUploadPreSignResponse> DescribeUploadPreSignWithOptionsAsync(DescribeUploadPreSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUploadPreSignResponse>(await DoRPCRequestAsync("DescribeUploadPreSign", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUploadPreSignResponse DescribeUploadPreSign(DescribeUploadPreSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUploadPreSignWithOptions(request, runtime);
        }

        public async Task<DescribeUploadPreSignResponse> DescribeUploadPreSignAsync(DescribeUploadPreSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUploadPreSignWithOptionsAsync(request, runtime);
        }

        public DescribeUserFlowInfoResponse DescribeUserFlowInfoWithOptions(DescribeUserFlowInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserFlowInfoResponse>(DoRPCRequest("DescribeUserFlowInfo", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserFlowInfoResponse> DescribeUserFlowInfoWithOptionsAsync(DescribeUserFlowInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserFlowInfoResponse>(await DoRPCRequestAsync("DescribeUserFlowInfo", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserFlowInfoResponse DescribeUserFlowInfo(DescribeUserFlowInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserFlowInfoWithOptions(request, runtime);
        }

        public async Task<DescribeUserFlowInfoResponse> DescribeUserFlowInfoAsync(DescribeUserFlowInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserFlowInfoWithOptionsAsync(request, runtime);
        }

        public DescribeUserFlowReportResponse DescribeUserFlowReportWithOptions(DescribeUserFlowReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserFlowReportResponse>(DoRPCRequest("DescribeUserFlowReport", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserFlowReportResponse> DescribeUserFlowReportWithOptionsAsync(DescribeUserFlowReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserFlowReportResponse>(await DoRPCRequestAsync("DescribeUserFlowReport", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserFlowReportResponse DescribeUserFlowReport(DescribeUserFlowReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserFlowReportWithOptions(request, runtime);
        }

        public async Task<DescribeUserFlowReportResponse> DescribeUserFlowReportAsync(DescribeUserFlowReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserFlowReportWithOptionsAsync(request, runtime);
        }

        public DescribeUserTotalFlowReportResponse DescribeUserTotalFlowReportWithOptions(DescribeUserTotalFlowReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserTotalFlowReportResponse>(DoRPCRequest("DescribeUserTotalFlowReport", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserTotalFlowReportResponse> DescribeUserTotalFlowReportWithOptionsAsync(DescribeUserTotalFlowReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserTotalFlowReportResponse>(await DoRPCRequestAsync("DescribeUserTotalFlowReport", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserTotalFlowReportResponse DescribeUserTotalFlowReport(DescribeUserTotalFlowReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserTotalFlowReportWithOptions(request, runtime);
        }

        public async Task<DescribeUserTotalFlowReportResponse> DescribeUserTotalFlowReportAsync(DescribeUserTotalFlowReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserTotalFlowReportWithOptionsAsync(request, runtime);
        }

        public DownloadAppKeyFileResponse DownloadAppKeyFileWithOptions(DownloadAppKeyFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadAppKeyFileResponse>(DoRPCRequest("DownloadAppKeyFile", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DownloadAppKeyFileResponse> DownloadAppKeyFileWithOptionsAsync(DownloadAppKeyFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadAppKeyFileResponse>(await DoRPCRequestAsync("DownloadAppKeyFile", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DownloadAppKeyFileResponse DownloadAppKeyFile(DownloadAppKeyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadAppKeyFileWithOptions(request, runtime);
        }

        public async Task<DownloadAppKeyFileResponse> DownloadAppKeyFileAsync(DownloadAppKeyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadAppKeyFileWithOptionsAsync(request, runtime);
        }

        public DownloadCcRouteRulesResponse DownloadCcRouteRulesWithOptions(DownloadCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadCcRouteRulesResponse>(DoRPCRequest("DownloadCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DownloadCcRouteRulesResponse> DownloadCcRouteRulesWithOptionsAsync(DownloadCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadCcRouteRulesResponse>(await DoRPCRequestAsync("DownloadCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DownloadCcRouteRulesResponse DownloadCcRouteRules(DownloadCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadCcRouteRulesWithOptions(request, runtime);
        }

        public async Task<DownloadCcRouteRulesResponse> DownloadCcRouteRulesAsync(DownloadCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadCcRouteRulesWithOptionsAsync(request, runtime);
        }

        public DownloadFlexAccRulesFileResponse DownloadFlexAccRulesFileWithOptions(DownloadFlexAccRulesFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadFlexAccRulesFileResponse>(DoRPCRequest("DownloadFlexAccRulesFile", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DownloadFlexAccRulesFileResponse> DownloadFlexAccRulesFileWithOptionsAsync(DownloadFlexAccRulesFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadFlexAccRulesFileResponse>(await DoRPCRequestAsync("DownloadFlexAccRulesFile", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DownloadFlexAccRulesFileResponse DownloadFlexAccRulesFile(DownloadFlexAccRulesFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadFlexAccRulesFileWithOptions(request, runtime);
        }

        public async Task<DownloadFlexAccRulesFileResponse> DownloadFlexAccRulesFileAsync(DownloadFlexAccRulesFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadFlexAccRulesFileWithOptionsAsync(request, runtime);
        }

        public DownloadLayer4RulesResponse DownloadLayer4RulesWithOptions(DownloadLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadLayer4RulesResponse>(DoRPCRequest("DownloadLayer4Rules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DownloadLayer4RulesResponse> DownloadLayer4RulesWithOptionsAsync(DownloadLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadLayer4RulesResponse>(await DoRPCRequestAsync("DownloadLayer4Rules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DownloadLayer4RulesResponse DownloadLayer4Rules(DownloadLayer4RulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadLayer4RulesWithOptions(request, runtime);
        }

        public async Task<DownloadLayer4RulesResponse> DownloadLayer4RulesAsync(DownloadLayer4RulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadLayer4RulesWithOptionsAsync(request, runtime);
        }

        public DownloadSdkFileResponse DownloadSdkFileWithOptions(DownloadSdkFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadSdkFileResponse>(DoRPCRequest("DownloadSdkFile", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DownloadSdkFileResponse> DownloadSdkFileWithOptionsAsync(DownloadSdkFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadSdkFileResponse>(await DoRPCRequestAsync("DownloadSdkFile", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DownloadSdkFileResponse DownloadSdkFile(DownloadSdkFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadSdkFileWithOptions(request, runtime);
        }

        public async Task<DownloadSdkFileResponse> DownloadSdkFileAsync(DownloadSdkFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadSdkFileWithOptionsAsync(request, runtime);
        }

        public DownloadUserTotalFlowReportResponse DownloadUserTotalFlowReportWithOptions(DownloadUserTotalFlowReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadUserTotalFlowReportResponse>(DoRPCRequest("DownloadUserTotalFlowReport", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DownloadUserTotalFlowReportResponse> DownloadUserTotalFlowReportWithOptionsAsync(DownloadUserTotalFlowReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadUserTotalFlowReportResponse>(await DoRPCRequestAsync("DownloadUserTotalFlowReport", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DownloadUserTotalFlowReportResponse DownloadUserTotalFlowReport(DownloadUserTotalFlowReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadUserTotalFlowReportWithOptions(request, runtime);
        }

        public async Task<DownloadUserTotalFlowReportResponse> DownloadUserTotalFlowReportAsync(DownloadUserTotalFlowReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadUserTotalFlowReportWithOptionsAsync(request, runtime);
        }

        public FlushLayer4RulesResponse FlushLayer4RulesWithOptions(FlushLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FlushLayer4RulesResponse>(DoRPCRequest("FlushLayer4Rules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FlushLayer4RulesResponse> FlushLayer4RulesWithOptionsAsync(FlushLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FlushLayer4RulesResponse>(await DoRPCRequestAsync("FlushLayer4Rules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FlushLayer4RulesResponse FlushLayer4Rules(FlushLayer4RulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FlushLayer4RulesWithOptions(request, runtime);
        }

        public async Task<FlushLayer4RulesResponse> FlushLayer4RulesAsync(FlushLayer4RulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FlushLayer4RulesWithOptionsAsync(request, runtime);
        }

        public ReallocNgResourceResponse ReallocNgResourceWithOptions(ReallocNgResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReallocNgResourceResponse>(DoRPCRequest("ReallocNgResource", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReallocNgResourceResponse> ReallocNgResourceWithOptionsAsync(ReallocNgResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReallocNgResourceResponse>(await DoRPCRequestAsync("ReallocNgResource", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReallocNgResourceResponse ReallocNgResource(ReallocNgResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReallocNgResourceWithOptions(request, runtime);
        }

        public async Task<ReallocNgResourceResponse> ReallocNgResourceAsync(ReallocNgResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReallocNgResourceWithOptionsAsync(request, runtime);
        }

        public ReplaceCcRouteRulesResponse ReplaceCcRouteRulesWithOptions(ReplaceCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceCcRouteRulesResponse>(DoRPCRequest("ReplaceCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReplaceCcRouteRulesResponse> ReplaceCcRouteRulesWithOptionsAsync(ReplaceCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceCcRouteRulesResponse>(await DoRPCRequestAsync("ReplaceCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReplaceCcRouteRulesResponse ReplaceCcRouteRules(ReplaceCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceCcRouteRulesWithOptions(request, runtime);
        }

        public async Task<ReplaceCcRouteRulesResponse> ReplaceCcRouteRulesAsync(ReplaceCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceCcRouteRulesWithOptionsAsync(request, runtime);
        }

        public SearchFlexFwdRulesResponse SearchFlexFwdRulesWithOptions(SearchFlexFwdRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchFlexFwdRulesResponse>(DoRPCRequest("SearchFlexFwdRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchFlexFwdRulesResponse> SearchFlexFwdRulesWithOptionsAsync(SearchFlexFwdRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchFlexFwdRulesResponse>(await DoRPCRequestAsync("SearchFlexFwdRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchFlexFwdRulesResponse SearchFlexFwdRules(SearchFlexFwdRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchFlexFwdRulesWithOptions(request, runtime);
        }

        public async Task<SearchFlexFwdRulesResponse> SearchFlexFwdRulesAsync(SearchFlexFwdRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchFlexFwdRulesWithOptionsAsync(request, runtime);
        }

        public UpdateAppResponse UpdateAppWithOptions(UpdateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppResponse>(DoRPCRequest("UpdateApp", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAppResponse> UpdateAppWithOptionsAsync(UpdateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppResponse>(await DoRPCRequestAsync("UpdateApp", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppWithOptions(request, runtime);
        }

        public async Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppWithOptionsAsync(request, runtime);
        }

        public UpdateCcBlackListResponse UpdateCcBlackListWithOptions(UpdateCcBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcBlackListResponse>(DoRPCRequest("UpdateCcBlackList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCcBlackListResponse> UpdateCcBlackListWithOptionsAsync(UpdateCcBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcBlackListResponse>(await DoRPCRequestAsync("UpdateCcBlackList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCcBlackListResponse UpdateCcBlackList(UpdateCcBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCcBlackListWithOptions(request, runtime);
        }

        public async Task<UpdateCcBlackListResponse> UpdateCcBlackListAsync(UpdateCcBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCcBlackListWithOptionsAsync(request, runtime);
        }

        public UpdateCcIDCBlockSwitchResponse UpdateCcIDCBlockSwitchWithOptions(UpdateCcIDCBlockSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcIDCBlockSwitchResponse>(DoRPCRequest("UpdateCcIDCBlockSwitch", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCcIDCBlockSwitchResponse> UpdateCcIDCBlockSwitchWithOptionsAsync(UpdateCcIDCBlockSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcIDCBlockSwitchResponse>(await DoRPCRequestAsync("UpdateCcIDCBlockSwitch", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCcIDCBlockSwitchResponse UpdateCcIDCBlockSwitch(UpdateCcIDCBlockSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCcIDCBlockSwitchWithOptions(request, runtime);
        }

        public async Task<UpdateCcIDCBlockSwitchResponse> UpdateCcIDCBlockSwitchAsync(UpdateCcIDCBlockSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCcIDCBlockSwitchWithOptionsAsync(request, runtime);
        }

        public UpdateCcRouteRulesResponse UpdateCcRouteRulesWithOptions(UpdateCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcRouteRulesResponse>(DoRPCRequest("UpdateCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCcRouteRulesResponse> UpdateCcRouteRulesWithOptionsAsync(UpdateCcRouteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcRouteRulesResponse>(await DoRPCRequestAsync("UpdateCcRouteRules", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCcRouteRulesResponse UpdateCcRouteRules(UpdateCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCcRouteRulesWithOptions(request, runtime);
        }

        public async Task<UpdateCcRouteRulesResponse> UpdateCcRouteRulesAsync(UpdateCcRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCcRouteRulesWithOptionsAsync(request, runtime);
        }

        public UpdateCcRouteSwitchResponse UpdateCcRouteSwitchWithOptions(UpdateCcRouteSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcRouteSwitchResponse>(DoRPCRequest("UpdateCcRouteSwitch", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCcRouteSwitchResponse> UpdateCcRouteSwitchWithOptionsAsync(UpdateCcRouteSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcRouteSwitchResponse>(await DoRPCRequestAsync("UpdateCcRouteSwitch", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCcRouteSwitchResponse UpdateCcRouteSwitch(UpdateCcRouteSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCcRouteSwitchWithOptions(request, runtime);
        }

        public async Task<UpdateCcRouteSwitchResponse> UpdateCcRouteSwitchAsync(UpdateCcRouteSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCcRouteSwitchWithOptionsAsync(request, runtime);
        }

        public UpdateCcTunnelGrayAndOnlyAllowResponse UpdateCcTunnelGrayAndOnlyAllowWithOptions(UpdateCcTunnelGrayAndOnlyAllowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcTunnelGrayAndOnlyAllowResponse>(DoRPCRequest("UpdateCcTunnelGrayAndOnlyAllow", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCcTunnelGrayAndOnlyAllowResponse> UpdateCcTunnelGrayAndOnlyAllowWithOptionsAsync(UpdateCcTunnelGrayAndOnlyAllowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcTunnelGrayAndOnlyAllowResponse>(await DoRPCRequestAsync("UpdateCcTunnelGrayAndOnlyAllow", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCcTunnelGrayAndOnlyAllowResponse UpdateCcTunnelGrayAndOnlyAllow(UpdateCcTunnelGrayAndOnlyAllowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCcTunnelGrayAndOnlyAllowWithOptions(request, runtime);
        }

        public async Task<UpdateCcTunnelGrayAndOnlyAllowResponse> UpdateCcTunnelGrayAndOnlyAllowAsync(UpdateCcTunnelGrayAndOnlyAllowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCcTunnelGrayAndOnlyAllowWithOptionsAsync(request, runtime);
        }

        public UpdateCcTunnelStatusResponse UpdateCcTunnelStatusWithOptions(UpdateCcTunnelStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcTunnelStatusResponse>(DoRPCRequest("UpdateCcTunnelStatus", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCcTunnelStatusResponse> UpdateCcTunnelStatusWithOptionsAsync(UpdateCcTunnelStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcTunnelStatusResponse>(await DoRPCRequestAsync("UpdateCcTunnelStatus", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCcTunnelStatusResponse UpdateCcTunnelStatus(UpdateCcTunnelStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCcTunnelStatusWithOptions(request, runtime);
        }

        public async Task<UpdateCcTunnelStatusResponse> UpdateCcTunnelStatusAsync(UpdateCcTunnelStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCcTunnelStatusWithOptionsAsync(request, runtime);
        }

        public UpdateCcUseResponse UpdateCcUseWithOptions(UpdateCcUseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcUseResponse>(DoRPCRequest("UpdateCcUse", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCcUseResponse> UpdateCcUseWithOptionsAsync(UpdateCcUseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcUseResponse>(await DoRPCRequestAsync("UpdateCcUse", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCcUseResponse UpdateCcUse(UpdateCcUseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCcUseWithOptions(request, runtime);
        }

        public async Task<UpdateCcUseResponse> UpdateCcUseAsync(UpdateCcUseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCcUseWithOptionsAsync(request, runtime);
        }

        public UpdateCcWhiteListResponse UpdateCcWhiteListWithOptions(UpdateCcWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcWhiteListResponse>(DoRPCRequest("UpdateCcWhiteList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCcWhiteListResponse> UpdateCcWhiteListWithOptionsAsync(UpdateCcWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcWhiteListResponse>(await DoRPCRequestAsync("UpdateCcWhiteList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCcWhiteListResponse UpdateCcWhiteList(UpdateCcWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCcWhiteListWithOptions(request, runtime);
        }

        public async Task<UpdateCcWhiteListResponse> UpdateCcWhiteListAsync(UpdateCcWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCcWhiteListWithOptionsAsync(request, runtime);
        }

        public UpdateCcZoneBlockConfigResponse UpdateCcZoneBlockConfigWithOptions(UpdateCcZoneBlockConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcZoneBlockConfigResponse>(DoRPCRequest("UpdateCcZoneBlockConfig", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCcZoneBlockConfigResponse> UpdateCcZoneBlockConfigWithOptionsAsync(UpdateCcZoneBlockConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcZoneBlockConfigResponse>(await DoRPCRequestAsync("UpdateCcZoneBlockConfig", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCcZoneBlockConfigResponse UpdateCcZoneBlockConfig(UpdateCcZoneBlockConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCcZoneBlockConfigWithOptions(request, runtime);
        }

        public async Task<UpdateCcZoneBlockConfigResponse> UpdateCcZoneBlockConfigAsync(UpdateCcZoneBlockConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCcZoneBlockConfigWithOptionsAsync(request, runtime);
        }

        public UpdateCcZoneBlockStatusResponse UpdateCcZoneBlockStatusWithOptions(UpdateCcZoneBlockStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcZoneBlockStatusResponse>(DoRPCRequest("UpdateCcZoneBlockStatus", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCcZoneBlockStatusResponse> UpdateCcZoneBlockStatusWithOptionsAsync(UpdateCcZoneBlockStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcZoneBlockStatusResponse>(await DoRPCRequestAsync("UpdateCcZoneBlockStatus", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCcZoneBlockStatusResponse UpdateCcZoneBlockStatus(UpdateCcZoneBlockStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCcZoneBlockStatusWithOptions(request, runtime);
        }

        public async Task<UpdateCcZoneBlockStatusResponse> UpdateCcZoneBlockStatusAsync(UpdateCcZoneBlockStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCcZoneBlockStatusWithOptionsAsync(request, runtime);
        }

        public UpdateFlexAccFwdRuleResponse UpdateFlexAccFwdRuleWithOptions(UpdateFlexAccFwdRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexAccFwdRuleResponse>(DoRPCRequest("UpdateFlexAccFwdRule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFlexAccFwdRuleResponse> UpdateFlexAccFwdRuleWithOptionsAsync(UpdateFlexAccFwdRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexAccFwdRuleResponse>(await DoRPCRequestAsync("UpdateFlexAccFwdRule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFlexAccFwdRuleResponse UpdateFlexAccFwdRule(UpdateFlexAccFwdRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlexAccFwdRuleWithOptions(request, runtime);
        }

        public async Task<UpdateFlexAccFwdRuleResponse> UpdateFlexAccFwdRuleAsync(UpdateFlexAccFwdRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlexAccFwdRuleWithOptionsAsync(request, runtime);
        }

        public UpdateFlexAccFwdRuleV2Response UpdateFlexAccFwdRuleV2WithOptions(UpdateFlexAccFwdRuleV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexAccFwdRuleV2Response>(DoRPCRequest("UpdateFlexAccFwdRuleV2", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFlexAccFwdRuleV2Response> UpdateFlexAccFwdRuleV2WithOptionsAsync(UpdateFlexAccFwdRuleV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexAccFwdRuleV2Response>(await DoRPCRequestAsync("UpdateFlexAccFwdRuleV2", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFlexAccFwdRuleV2Response UpdateFlexAccFwdRuleV2(UpdateFlexAccFwdRuleV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlexAccFwdRuleV2WithOptions(request, runtime);
        }

        public async Task<UpdateFlexAccFwdRuleV2Response> UpdateFlexAccFwdRuleV2Async(UpdateFlexAccFwdRuleV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlexAccFwdRuleV2WithOptionsAsync(request, runtime);
        }

        public UpdateFlexAccStatusResponse UpdateFlexAccStatusWithOptions(UpdateFlexAccStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexAccStatusResponse>(DoRPCRequest("UpdateFlexAccStatus", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFlexAccStatusResponse> UpdateFlexAccStatusWithOptionsAsync(UpdateFlexAccStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexAccStatusResponse>(await DoRPCRequestAsync("UpdateFlexAccStatus", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFlexAccStatusResponse UpdateFlexAccStatus(UpdateFlexAccStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlexAccStatusWithOptions(request, runtime);
        }

        public async Task<UpdateFlexAccStatusResponse> UpdateFlexAccStatusAsync(UpdateFlexAccStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlexAccStatusWithOptionsAsync(request, runtime);
        }

        public UpdateFlexAccTcpPortsResponse UpdateFlexAccTcpPortsWithOptions(UpdateFlexAccTcpPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexAccTcpPortsResponse>(DoRPCRequest("UpdateFlexAccTcpPorts", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFlexAccTcpPortsResponse> UpdateFlexAccTcpPortsWithOptionsAsync(UpdateFlexAccTcpPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexAccTcpPortsResponse>(await DoRPCRequestAsync("UpdateFlexAccTcpPorts", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFlexAccTcpPortsResponse UpdateFlexAccTcpPorts(UpdateFlexAccTcpPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlexAccTcpPortsWithOptions(request, runtime);
        }

        public async Task<UpdateFlexAccTcpPortsResponse> UpdateFlexAccTcpPortsAsync(UpdateFlexAccTcpPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlexAccTcpPortsWithOptionsAsync(request, runtime);
        }

        public UpdateFlexAccUdpPortsResponse UpdateFlexAccUdpPortsWithOptions(UpdateFlexAccUdpPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexAccUdpPortsResponse>(DoRPCRequest("UpdateFlexAccUdpPorts", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFlexAccUdpPortsResponse> UpdateFlexAccUdpPortsWithOptionsAsync(UpdateFlexAccUdpPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexAccUdpPortsResponse>(await DoRPCRequestAsync("UpdateFlexAccUdpPorts", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFlexAccUdpPortsResponse UpdateFlexAccUdpPorts(UpdateFlexAccUdpPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlexAccUdpPortsWithOptions(request, runtime);
        }

        public async Task<UpdateFlexAccUdpPortsResponse> UpdateFlexAccUdpPortsAsync(UpdateFlexAccUdpPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlexAccUdpPortsWithOptionsAsync(request, runtime);
        }

        public UpdateFlexBackupGroupsResponse UpdateFlexBackupGroupsWithOptions(UpdateFlexBackupGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexBackupGroupsResponse>(DoRPCRequest("UpdateFlexBackupGroups", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFlexBackupGroupsResponse> UpdateFlexBackupGroupsWithOptionsAsync(UpdateFlexBackupGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexBackupGroupsResponse>(await DoRPCRequestAsync("UpdateFlexBackupGroups", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFlexBackupGroupsResponse UpdateFlexBackupGroups(UpdateFlexBackupGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlexBackupGroupsWithOptions(request, runtime);
        }

        public async Task<UpdateFlexBackupGroupsResponse> UpdateFlexBackupGroupsAsync(UpdateFlexBackupGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlexBackupGroupsWithOptionsAsync(request, runtime);
        }

        public UpdateFlexFwdRuleResponse UpdateFlexFwdRuleWithOptions(UpdateFlexFwdRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexFwdRuleResponse>(DoRPCRequest("UpdateFlexFwdRule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFlexFwdRuleResponse> UpdateFlexFwdRuleWithOptionsAsync(UpdateFlexFwdRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexFwdRuleResponse>(await DoRPCRequestAsync("UpdateFlexFwdRule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFlexFwdRuleResponse UpdateFlexFwdRule(UpdateFlexFwdRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlexFwdRuleWithOptions(request, runtime);
        }

        public async Task<UpdateFlexFwdRuleResponse> UpdateFlexFwdRuleAsync(UpdateFlexFwdRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlexFwdRuleWithOptionsAsync(request, runtime);
        }

        public UpdateFlexInnerPolicyResponse UpdateFlexInnerPolicyWithOptions(UpdateFlexInnerPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexInnerPolicyResponse>(DoRPCRequest("UpdateFlexInnerPolicy", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFlexInnerPolicyResponse> UpdateFlexInnerPolicyWithOptionsAsync(UpdateFlexInnerPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexInnerPolicyResponse>(await DoRPCRequestAsync("UpdateFlexInnerPolicy", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFlexInnerPolicyResponse UpdateFlexInnerPolicy(UpdateFlexInnerPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlexInnerPolicyWithOptions(request, runtime);
        }

        public async Task<UpdateFlexInnerPolicyResponse> UpdateFlexInnerPolicyAsync(UpdateFlexInnerPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlexInnerPolicyWithOptionsAsync(request, runtime);
        }

        public UpdateFlexLinkTypeResponse UpdateFlexLinkTypeWithOptions(UpdateFlexLinkTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexLinkTypeResponse>(DoRPCRequest("UpdateFlexLinkType", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFlexLinkTypeResponse> UpdateFlexLinkTypeWithOptionsAsync(UpdateFlexLinkTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexLinkTypeResponse>(await DoRPCRequestAsync("UpdateFlexLinkType", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFlexLinkTypeResponse UpdateFlexLinkType(UpdateFlexLinkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlexLinkTypeWithOptions(request, runtime);
        }

        public async Task<UpdateFlexLinkTypeResponse> UpdateFlexLinkTypeAsync(UpdateFlexLinkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlexLinkTypeWithOptionsAsync(request, runtime);
        }

        public UpdateFlexPortsResponse UpdateFlexPortsWithOptions(UpdateFlexPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexPortsResponse>(DoRPCRequest("UpdateFlexPorts", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFlexPortsResponse> UpdateFlexPortsWithOptionsAsync(UpdateFlexPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexPortsResponse>(await DoRPCRequestAsync("UpdateFlexPorts", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFlexPortsResponse UpdateFlexPorts(UpdateFlexPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlexPortsWithOptions(request, runtime);
        }

        public async Task<UpdateFlexPortsResponse> UpdateFlexPortsAsync(UpdateFlexPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlexPortsWithOptionsAsync(request, runtime);
        }

        public UpdateFlexStatusResponse UpdateFlexStatusWithOptions(UpdateFlexStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexStatusResponse>(DoRPCRequest("UpdateFlexStatus", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFlexStatusResponse> UpdateFlexStatusWithOptionsAsync(UpdateFlexStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFlexStatusResponse>(await DoRPCRequestAsync("UpdateFlexStatus", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFlexStatusResponse UpdateFlexStatus(UpdateFlexStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlexStatusWithOptions(request, runtime);
        }

        public async Task<UpdateFlexStatusResponse> UpdateFlexStatusAsync(UpdateFlexStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlexStatusWithOptionsAsync(request, runtime);
        }

        public UpdateGroupResponse UpdateGroupWithOptions(UpdateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupResponse>(DoRPCRequest("UpdateGroup", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateGroupResponse> UpdateGroupWithOptionsAsync(UpdateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupResponse>(await DoRPCRequestAsync("UpdateGroup", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupWithOptions(request, runtime);
        }

        public async Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupWithOptionsAsync(request, runtime);
        }

        public UpdateGroupDnsStatusResponse UpdateGroupDnsStatusWithOptions(UpdateGroupDnsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupDnsStatusResponse>(DoRPCRequest("UpdateGroupDnsStatus", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateGroupDnsStatusResponse> UpdateGroupDnsStatusWithOptionsAsync(UpdateGroupDnsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupDnsStatusResponse>(await DoRPCRequestAsync("UpdateGroupDnsStatus", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateGroupDnsStatusResponse UpdateGroupDnsStatus(UpdateGroupDnsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupDnsStatusWithOptions(request, runtime);
        }

        public async Task<UpdateGroupDnsStatusResponse> UpdateGroupDnsStatusAsync(UpdateGroupDnsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupDnsStatusWithOptionsAsync(request, runtime);
        }

        public UpdateGroupNodesResponse UpdateGroupNodesWithOptions(UpdateGroupNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupNodesResponse>(DoRPCRequest("UpdateGroupNodes", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateGroupNodesResponse> UpdateGroupNodesWithOptionsAsync(UpdateGroupNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupNodesResponse>(await DoRPCRequestAsync("UpdateGroupNodes", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateGroupNodesResponse UpdateGroupNodes(UpdateGroupNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupNodesWithOptions(request, runtime);
        }

        public async Task<UpdateGroupNodesResponse> UpdateGroupNodesAsync(UpdateGroupNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupNodesWithOptionsAsync(request, runtime);
        }

        public UpdateGroupStatusResponse UpdateGroupStatusWithOptions(UpdateGroupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupStatusResponse>(DoRPCRequest("UpdateGroupStatus", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateGroupStatusResponse> UpdateGroupStatusWithOptionsAsync(UpdateGroupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupStatusResponse>(await DoRPCRequestAsync("UpdateGroupStatus", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateGroupStatusResponse UpdateGroupStatus(UpdateGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupStatusWithOptions(request, runtime);
        }

        public async Task<UpdateGroupStatusResponse> UpdateGroupStatusAsync(UpdateGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupStatusWithOptionsAsync(request, runtime);
        }

        public UpdateLayer4RuleResponse UpdateLayer4RuleWithOptions(UpdateLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLayer4RuleResponse>(DoRPCRequest("UpdateLayer4Rule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateLayer4RuleResponse> UpdateLayer4RuleWithOptionsAsync(UpdateLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLayer4RuleResponse>(await DoRPCRequestAsync("UpdateLayer4Rule", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateLayer4RuleResponse UpdateLayer4Rule(UpdateLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLayer4RuleWithOptions(request, runtime);
        }

        public async Task<UpdateLayer4RuleResponse> UpdateLayer4RuleAsync(UpdateLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLayer4RuleWithOptionsAsync(request, runtime);
        }

        public UploadCcRouteFileForParseResponse UploadCcRouteFileForParseWithOptions(UploadCcRouteFileForParseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadCcRouteFileForParseResponse>(DoRPCRequest("UploadCcRouteFileForParse", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadCcRouteFileForParseResponse> UploadCcRouteFileForParseWithOptionsAsync(UploadCcRouteFileForParseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadCcRouteFileForParseResponse>(await DoRPCRequestAsync("UploadCcRouteFileForParse", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadCcRouteFileForParseResponse UploadCcRouteFileForParse(UploadCcRouteFileForParseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadCcRouteFileForParseWithOptions(request, runtime);
        }

        public async Task<UploadCcRouteFileForParseResponse> UploadCcRouteFileForParseAsync(UploadCcRouteFileForParseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadCcRouteFileForParseWithOptionsAsync(request, runtime);
        }

        public UploadCcWhiteBlackListResponse UploadCcWhiteBlackListWithOptions(UploadCcWhiteBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadCcWhiteBlackListResponse>(DoRPCRequest("UploadCcWhiteBlackList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadCcWhiteBlackListResponse> UploadCcWhiteBlackListWithOptionsAsync(UploadCcWhiteBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadCcWhiteBlackListResponse>(await DoRPCRequestAsync("UploadCcWhiteBlackList", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadCcWhiteBlackListResponse UploadCcWhiteBlackList(UploadCcWhiteBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadCcWhiteBlackListWithOptions(request, runtime);
        }

        public async Task<UploadCcWhiteBlackListResponse> UploadCcWhiteBlackListAsync(UploadCcWhiteBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadCcWhiteBlackListWithOptionsAsync(request, runtime);
        }

        public UploadFlexAccRulesFileForParseResponse UploadFlexAccRulesFileForParseWithOptions(UploadFlexAccRulesFileForParseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadFlexAccRulesFileForParseResponse>(DoRPCRequest("UploadFlexAccRulesFileForParse", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadFlexAccRulesFileForParseResponse> UploadFlexAccRulesFileForParseWithOptionsAsync(UploadFlexAccRulesFileForParseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadFlexAccRulesFileForParseResponse>(await DoRPCRequestAsync("UploadFlexAccRulesFileForParse", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadFlexAccRulesFileForParseResponse UploadFlexAccRulesFileForParse(UploadFlexAccRulesFileForParseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadFlexAccRulesFileForParseWithOptions(request, runtime);
        }

        public async Task<UploadFlexAccRulesFileForParseResponse> UploadFlexAccRulesFileForParseAsync(UploadFlexAccRulesFileForParseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadFlexAccRulesFileForParseWithOptionsAsync(request, runtime);
        }

        public UploadFlexRulesFileForParseResponse UploadFlexRulesFileForParseWithOptions(UploadFlexRulesFileForParseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadFlexRulesFileForParseResponse>(DoRPCRequest("UploadFlexRulesFileForParse", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadFlexRulesFileForParseResponse> UploadFlexRulesFileForParseWithOptionsAsync(UploadFlexRulesFileForParseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadFlexRulesFileForParseResponse>(await DoRPCRequestAsync("UploadFlexRulesFileForParse", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadFlexRulesFileForParseResponse UploadFlexRulesFileForParse(UploadFlexRulesFileForParseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadFlexRulesFileForParseWithOptions(request, runtime);
        }

        public async Task<UploadFlexRulesFileForParseResponse> UploadFlexRulesFileForParseAsync(UploadFlexRulesFileForParseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadFlexRulesFileForParseWithOptionsAsync(request, runtime);
        }

        public UploadL4RulesFileForParseResponse UploadL4RulesFileForParseWithOptions(UploadL4RulesFileForParseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadL4RulesFileForParseResponse>(DoRPCRequest("UploadL4RulesFileForParse", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadL4RulesFileForParseResponse> UploadL4RulesFileForParseWithOptionsAsync(UploadL4RulesFileForParseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadL4RulesFileForParseResponse>(await DoRPCRequestAsync("UploadL4RulesFileForParse", "2018-03-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadL4RulesFileForParseResponse UploadL4RulesFileForParse(UploadL4RulesFileForParseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadL4RulesFileForParseWithOptions(request, runtime);
        }

        public async Task<UploadL4RulesFileForParseResponse> UploadL4RulesFileForParseAsync(UploadL4RulesFileForParseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadL4RulesFileForParseWithOptionsAsync(request, runtime);
        }

    }
}
