// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Config20200907.Models;

namespace AlibabaCloud.SDK.Config20200907
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-shanghai", "config.cn-shanghai.aliyuncs.com"},
                {"ap-southeast-1", "config.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("config", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ActiveAggregateConfigRulesResponse ActiveAggregateConfigRulesWithOptions(ActiveAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActiveAggregateConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveAggregateConfigRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ActiveAggregateConfigRulesResponse> ActiveAggregateConfigRulesWithOptionsAsync(ActiveAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActiveAggregateConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveAggregateConfigRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ActiveAggregateConfigRulesResponse ActiveAggregateConfigRules(ActiveAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveAggregateConfigRulesWithOptions(request, runtime);
        }

        public async Task<ActiveAggregateConfigRulesResponse> ActiveAggregateConfigRulesAsync(ActiveAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveAggregateConfigRulesWithOptionsAsync(request, runtime);
        }

        public AttachAggregateConfigRuleToCompliancePackResponse AttachAggregateConfigRuleToCompliancePackWithOptions(AttachAggregateConfigRuleToCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                query["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachAggregateConfigRuleToCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachAggregateConfigRuleToCompliancePackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AttachAggregateConfigRuleToCompliancePackResponse> AttachAggregateConfigRuleToCompliancePackWithOptionsAsync(AttachAggregateConfigRuleToCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                query["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachAggregateConfigRuleToCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachAggregateConfigRuleToCompliancePackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AttachAggregateConfigRuleToCompliancePackResponse AttachAggregateConfigRuleToCompliancePack(AttachAggregateConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachAggregateConfigRuleToCompliancePackWithOptions(request, runtime);
        }

        public async Task<AttachAggregateConfigRuleToCompliancePackResponse> AttachAggregateConfigRuleToCompliancePackAsync(AttachAggregateConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachAggregateConfigRuleToCompliancePackWithOptionsAsync(request, runtime);
        }

        public AttachConfigRuleToCompliancePackResponse AttachConfigRuleToCompliancePackWithOptions(AttachConfigRuleToCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                query["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachConfigRuleToCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachConfigRuleToCompliancePackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AttachConfigRuleToCompliancePackResponse> AttachConfigRuleToCompliancePackWithOptionsAsync(AttachConfigRuleToCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                query["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachConfigRuleToCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachConfigRuleToCompliancePackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AttachConfigRuleToCompliancePackResponse AttachConfigRuleToCompliancePack(AttachConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachConfigRuleToCompliancePackWithOptions(request, runtime);
        }

        public async Task<AttachConfigRuleToCompliancePackResponse> AttachConfigRuleToCompliancePackAsync(AttachConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachConfigRuleToCompliancePackWithOptionsAsync(request, runtime);
        }

        public CreateAggregateCompliancePackResponse CreateAggregateCompliancePackWithOptions(CreateAggregateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAggregateCompliancePackShrinkRequest request = new CreateAggregateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackName))
            {
                body["CompliancePackName"] = request.CompliancePackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackTemplateId))
            {
                body["CompliancePackTemplateId"] = request.CompliancePackTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRulesShrink))
            {
                body["ConfigRules"] = request.ConfigRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggregateCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggregateCompliancePackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAggregateCompliancePackResponse> CreateAggregateCompliancePackWithOptionsAsync(CreateAggregateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAggregateCompliancePackShrinkRequest request = new CreateAggregateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackName))
            {
                body["CompliancePackName"] = request.CompliancePackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackTemplateId))
            {
                body["CompliancePackTemplateId"] = request.CompliancePackTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRulesShrink))
            {
                body["ConfigRules"] = request.ConfigRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggregateCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggregateCompliancePackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAggregateCompliancePackResponse CreateAggregateCompliancePack(CreateAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAggregateCompliancePackWithOptions(request, runtime);
        }

        public async Task<CreateAggregateCompliancePackResponse> CreateAggregateCompliancePackAsync(CreateAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAggregateCompliancePackWithOptionsAsync(request, runtime);
        }

        public CreateAggregateConfigRuleResponse CreateAggregateConfigRuleWithOptions(CreateAggregateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAggregateConfigRuleShrinkRequest request = new CreateAggregateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleName))
            {
                body["ConfigRuleName"] = request.ConfigRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleTriggerTypes))
            {
                body["ConfigRuleTriggerTypes"] = request.ConfigRuleTriggerTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParametersShrink))
            {
                body["InputParameters"] = request.InputParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumExecutionFrequency))
            {
                body["MaximumExecutionFrequency"] = request.MaximumExecutionFrequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypesScopeShrink))
            {
                body["ResourceTypesScope"] = request.ResourceTypesScopeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIdentifier))
            {
                body["SourceIdentifier"] = request.SourceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOwner))
            {
                body["SourceOwner"] = request.SourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyLogicScope))
            {
                body["TagKeyLogicScope"] = request.TagKeyLogicScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyScope))
            {
                body["TagKeyScope"] = request.TagKeyScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValueScope))
            {
                body["TagValueScope"] = request.TagValueScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggregateConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggregateConfigRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAggregateConfigRuleResponse> CreateAggregateConfigRuleWithOptionsAsync(CreateAggregateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAggregateConfigRuleShrinkRequest request = new CreateAggregateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleName))
            {
                body["ConfigRuleName"] = request.ConfigRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleTriggerTypes))
            {
                body["ConfigRuleTriggerTypes"] = request.ConfigRuleTriggerTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParametersShrink))
            {
                body["InputParameters"] = request.InputParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumExecutionFrequency))
            {
                body["MaximumExecutionFrequency"] = request.MaximumExecutionFrequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypesScopeShrink))
            {
                body["ResourceTypesScope"] = request.ResourceTypesScopeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIdentifier))
            {
                body["SourceIdentifier"] = request.SourceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOwner))
            {
                body["SourceOwner"] = request.SourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyLogicScope))
            {
                body["TagKeyLogicScope"] = request.TagKeyLogicScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyScope))
            {
                body["TagKeyScope"] = request.TagKeyScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValueScope))
            {
                body["TagValueScope"] = request.TagValueScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggregateConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggregateConfigRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAggregateConfigRuleResponse CreateAggregateConfigRule(CreateAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAggregateConfigRuleWithOptions(request, runtime);
        }

        public async Task<CreateAggregateConfigRuleResponse> CreateAggregateConfigRuleAsync(CreateAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAggregateConfigRuleWithOptionsAsync(request, runtime);
        }

        public CreateAggregatorResponse CreateAggregatorWithOptions(CreateAggregatorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAggregatorShrinkRequest request = new CreateAggregatorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AggregatorAccounts))
            {
                request.AggregatorAccountsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AggregatorAccounts, "AggregatorAccounts", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorAccountsShrink))
            {
                body["AggregatorAccounts"] = request.AggregatorAccountsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorName))
            {
                body["AggregatorName"] = request.AggregatorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorType))
            {
                body["AggregatorType"] = request.AggregatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggregator",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggregatorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAggregatorResponse> CreateAggregatorWithOptionsAsync(CreateAggregatorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAggregatorShrinkRequest request = new CreateAggregatorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AggregatorAccounts))
            {
                request.AggregatorAccountsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AggregatorAccounts, "AggregatorAccounts", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorAccountsShrink))
            {
                body["AggregatorAccounts"] = request.AggregatorAccountsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorName))
            {
                body["AggregatorName"] = request.AggregatorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorType))
            {
                body["AggregatorType"] = request.AggregatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggregator",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggregatorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAggregatorResponse CreateAggregator(CreateAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAggregatorWithOptions(request, runtime);
        }

        public async Task<CreateAggregatorResponse> CreateAggregatorAsync(CreateAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAggregatorWithOptionsAsync(request, runtime);
        }

        public CreateCompliancePackResponse CreateCompliancePackWithOptions(CreateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCompliancePackShrinkRequest request = new CreateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackName))
            {
                body["CompliancePackName"] = request.CompliancePackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackTemplateId))
            {
                body["CompliancePackTemplateId"] = request.CompliancePackTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRulesShrink))
            {
                body["ConfigRules"] = request.ConfigRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCompliancePackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCompliancePackResponse> CreateCompliancePackWithOptionsAsync(CreateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCompliancePackShrinkRequest request = new CreateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackName))
            {
                body["CompliancePackName"] = request.CompliancePackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackTemplateId))
            {
                body["CompliancePackTemplateId"] = request.CompliancePackTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRulesShrink))
            {
                body["ConfigRules"] = request.ConfigRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCompliancePackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCompliancePackResponse CreateCompliancePack(CreateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCompliancePackWithOptions(request, runtime);
        }

        public async Task<CreateCompliancePackResponse> CreateCompliancePackAsync(CreateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCompliancePackWithOptionsAsync(request, runtime);
        }

        public CreateConfigRuleResponse CreateConfigRuleWithOptions(CreateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateConfigRuleShrinkRequest request = new CreateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleName))
            {
                body["ConfigRuleName"] = request.ConfigRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleTriggerTypes))
            {
                body["ConfigRuleTriggerTypes"] = request.ConfigRuleTriggerTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParametersShrink))
            {
                body["InputParameters"] = request.InputParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumExecutionFrequency))
            {
                body["MaximumExecutionFrequency"] = request.MaximumExecutionFrequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypesScopeShrink))
            {
                body["ResourceTypesScope"] = request.ResourceTypesScopeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIdentifier))
            {
                body["SourceIdentifier"] = request.SourceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOwner))
            {
                body["SourceOwner"] = request.SourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyLogicScope))
            {
                body["TagKeyLogicScope"] = request.TagKeyLogicScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyScope))
            {
                body["TagKeyScope"] = request.TagKeyScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValueScope))
            {
                body["TagValueScope"] = request.TagValueScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateConfigRuleResponse> CreateConfigRuleWithOptionsAsync(CreateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateConfigRuleShrinkRequest request = new CreateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleName))
            {
                body["ConfigRuleName"] = request.ConfigRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleTriggerTypes))
            {
                body["ConfigRuleTriggerTypes"] = request.ConfigRuleTriggerTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParametersShrink))
            {
                body["InputParameters"] = request.InputParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumExecutionFrequency))
            {
                body["MaximumExecutionFrequency"] = request.MaximumExecutionFrequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypesScopeShrink))
            {
                body["ResourceTypesScope"] = request.ResourceTypesScopeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIdentifier))
            {
                body["SourceIdentifier"] = request.SourceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOwner))
            {
                body["SourceOwner"] = request.SourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyLogicScope))
            {
                body["TagKeyLogicScope"] = request.TagKeyLogicScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyScope))
            {
                body["TagKeyScope"] = request.TagKeyScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValueScope))
            {
                body["TagValueScope"] = request.TagValueScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateConfigRuleResponse CreateConfigRule(CreateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConfigRuleWithOptions(request, runtime);
        }

        public async Task<CreateConfigRuleResponse> CreateConfigRuleAsync(CreateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConfigRuleWithOptionsAsync(request, runtime);
        }

        public DeactiveAggregateConfigRulesResponse DeactiveAggregateConfigRulesWithOptions(DeactiveAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeactiveAggregateConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeactiveAggregateConfigRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeactiveAggregateConfigRulesResponse> DeactiveAggregateConfigRulesWithOptionsAsync(DeactiveAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeactiveAggregateConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeactiveAggregateConfigRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeactiveAggregateConfigRulesResponse DeactiveAggregateConfigRules(DeactiveAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactiveAggregateConfigRulesWithOptions(request, runtime);
        }

        public async Task<DeactiveAggregateConfigRulesResponse> DeactiveAggregateConfigRulesAsync(DeactiveAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactiveAggregateConfigRulesWithOptionsAsync(request, runtime);
        }

        public DeactiveConfigRulesResponse DeactiveConfigRulesWithOptions(DeactiveConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeactiveConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeactiveConfigRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeactiveConfigRulesResponse> DeactiveConfigRulesWithOptionsAsync(DeactiveConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeactiveConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeactiveConfigRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeactiveConfigRulesResponse DeactiveConfigRules(DeactiveConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactiveConfigRulesWithOptions(request, runtime);
        }

        public async Task<DeactiveConfigRulesResponse> DeactiveConfigRulesAsync(DeactiveConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactiveConfigRulesWithOptionsAsync(request, runtime);
        }

        public DeleteAggregateCompliancePacksResponse DeleteAggregateCompliancePacksWithOptions(DeleteAggregateCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackIds))
            {
                body["CompliancePackIds"] = request.CompliancePackIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteRule))
            {
                body["DeleteRule"] = request.DeleteRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAggregateCompliancePacks",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAggregateCompliancePacksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAggregateCompliancePacksResponse> DeleteAggregateCompliancePacksWithOptionsAsync(DeleteAggregateCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackIds))
            {
                body["CompliancePackIds"] = request.CompliancePackIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteRule))
            {
                body["DeleteRule"] = request.DeleteRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAggregateCompliancePacks",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAggregateCompliancePacksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteAggregateCompliancePacksResponse DeleteAggregateCompliancePacks(DeleteAggregateCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAggregateCompliancePacksWithOptions(request, runtime);
        }

        public async Task<DeleteAggregateCompliancePacksResponse> DeleteAggregateCompliancePacksAsync(DeleteAggregateCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAggregateCompliancePacksWithOptionsAsync(request, runtime);
        }

        public DeleteAggregateConfigRulesResponse DeleteAggregateConfigRulesWithOptions(DeleteAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAggregateConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAggregateConfigRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAggregateConfigRulesResponse> DeleteAggregateConfigRulesWithOptionsAsync(DeleteAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAggregateConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAggregateConfigRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteAggregateConfigRulesResponse DeleteAggregateConfigRules(DeleteAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAggregateConfigRulesWithOptions(request, runtime);
        }

        public async Task<DeleteAggregateConfigRulesResponse> DeleteAggregateConfigRulesAsync(DeleteAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAggregateConfigRulesWithOptionsAsync(request, runtime);
        }

        public DeleteAggregatorsResponse DeleteAggregatorsWithOptions(DeleteAggregatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorIds))
            {
                body["AggregatorIds"] = request.AggregatorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAggregators",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAggregatorsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAggregatorsResponse> DeleteAggregatorsWithOptionsAsync(DeleteAggregatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorIds))
            {
                body["AggregatorIds"] = request.AggregatorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAggregators",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAggregatorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteAggregatorsResponse DeleteAggregators(DeleteAggregatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAggregatorsWithOptions(request, runtime);
        }

        public async Task<DeleteAggregatorsResponse> DeleteAggregatorsAsync(DeleteAggregatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAggregatorsWithOptionsAsync(request, runtime);
        }

        public DeleteCompliancePacksResponse DeleteCompliancePacksWithOptions(DeleteCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackIds))
            {
                body["CompliancePackIds"] = request.CompliancePackIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteRule))
            {
                body["DeleteRule"] = request.DeleteRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCompliancePacks",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCompliancePacksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCompliancePacksResponse> DeleteCompliancePacksWithOptionsAsync(DeleteCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackIds))
            {
                body["CompliancePackIds"] = request.CompliancePackIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteRule))
            {
                body["DeleteRule"] = request.DeleteRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCompliancePacks",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCompliancePacksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCompliancePacksResponse DeleteCompliancePacks(DeleteCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCompliancePacksWithOptions(request, runtime);
        }

        public async Task<DeleteCompliancePacksResponse> DeleteCompliancePacksAsync(DeleteCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCompliancePacksWithOptionsAsync(request, runtime);
        }

        public DetachAggregateConfigRuleToCompliancePackResponse DetachAggregateConfigRuleToCompliancePackWithOptions(DetachAggregateConfigRuleToCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                query["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachAggregateConfigRuleToCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachAggregateConfigRuleToCompliancePackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetachAggregateConfigRuleToCompliancePackResponse> DetachAggregateConfigRuleToCompliancePackWithOptionsAsync(DetachAggregateConfigRuleToCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                query["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachAggregateConfigRuleToCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachAggregateConfigRuleToCompliancePackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetachAggregateConfigRuleToCompliancePackResponse DetachAggregateConfigRuleToCompliancePack(DetachAggregateConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachAggregateConfigRuleToCompliancePackWithOptions(request, runtime);
        }

        public async Task<DetachAggregateConfigRuleToCompliancePackResponse> DetachAggregateConfigRuleToCompliancePackAsync(DetachAggregateConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachAggregateConfigRuleToCompliancePackWithOptionsAsync(request, runtime);
        }

        public DetachConfigRuleToCompliancePackResponse DetachConfigRuleToCompliancePackWithOptions(DetachConfigRuleToCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                query["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachConfigRuleToCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachConfigRuleToCompliancePackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetachConfigRuleToCompliancePackResponse> DetachConfigRuleToCompliancePackWithOptionsAsync(DetachConfigRuleToCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                query["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachConfigRuleToCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachConfigRuleToCompliancePackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetachConfigRuleToCompliancePackResponse DetachConfigRuleToCompliancePack(DetachConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachConfigRuleToCompliancePackWithOptions(request, runtime);
        }

        public async Task<DetachConfigRuleToCompliancePackResponse> DetachConfigRuleToCompliancePackAsync(DetachConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachConfigRuleToCompliancePackWithOptionsAsync(request, runtime);
        }

        public GenerateAggregateCompliancePackReportResponse GenerateAggregateCompliancePackReportWithOptions(GenerateAggregateCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                body["CompliancePackId"] = request.CompliancePackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAggregateCompliancePackReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateAggregateCompliancePackReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateAggregateCompliancePackReportResponse> GenerateAggregateCompliancePackReportWithOptionsAsync(GenerateAggregateCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                body["CompliancePackId"] = request.CompliancePackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAggregateCompliancePackReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateAggregateCompliancePackReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateAggregateCompliancePackReportResponse GenerateAggregateCompliancePackReport(GenerateAggregateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAggregateCompliancePackReportWithOptions(request, runtime);
        }

        public async Task<GenerateAggregateCompliancePackReportResponse> GenerateAggregateCompliancePackReportAsync(GenerateAggregateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAggregateCompliancePackReportWithOptionsAsync(request, runtime);
        }

        public GenerateAggregateConfigRulesReportResponse GenerateAggregateConfigRulesReportWithOptions(GenerateAggregateConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                body["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAggregateConfigRulesReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateAggregateConfigRulesReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateAggregateConfigRulesReportResponse> GenerateAggregateConfigRulesReportWithOptionsAsync(GenerateAggregateConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                body["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAggregateConfigRulesReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateAggregateConfigRulesReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateAggregateConfigRulesReportResponse GenerateAggregateConfigRulesReport(GenerateAggregateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAggregateConfigRulesReportWithOptions(request, runtime);
        }

        public async Task<GenerateAggregateConfigRulesReportResponse> GenerateAggregateConfigRulesReportAsync(GenerateAggregateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAggregateConfigRulesReportWithOptionsAsync(request, runtime);
        }

        public GenerateCompliancePackReportResponse GenerateCompliancePackReportWithOptions(GenerateCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                body["CompliancePackId"] = request.CompliancePackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCompliancePackReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCompliancePackReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateCompliancePackReportResponse> GenerateCompliancePackReportWithOptionsAsync(GenerateCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                body["CompliancePackId"] = request.CompliancePackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCompliancePackReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCompliancePackReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateCompliancePackReportResponse GenerateCompliancePackReport(GenerateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateCompliancePackReportWithOptions(request, runtime);
        }

        public async Task<GenerateCompliancePackReportResponse> GenerateCompliancePackReportAsync(GenerateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateCompliancePackReportWithOptionsAsync(request, runtime);
        }

        public GenerateConfigRulesReportResponse GenerateConfigRulesReportWithOptions(GenerateConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                body["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateConfigRulesReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateConfigRulesReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateConfigRulesReportResponse> GenerateConfigRulesReportWithOptionsAsync(GenerateConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                body["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateConfigRulesReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateConfigRulesReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateConfigRulesReportResponse GenerateConfigRulesReport(GenerateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateConfigRulesReportWithOptions(request, runtime);
        }

        public async Task<GenerateConfigRulesReportResponse> GenerateConfigRulesReportAsync(GenerateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateConfigRulesReportWithOptionsAsync(request, runtime);
        }

        public GetAggregateAccountComplianceByPackResponse GetAggregateAccountComplianceByPackWithOptions(GetAggregateAccountComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateAccountComplianceByPack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateAccountComplianceByPackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateAccountComplianceByPackResponse> GetAggregateAccountComplianceByPackWithOptionsAsync(GetAggregateAccountComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateAccountComplianceByPack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateAccountComplianceByPackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateAccountComplianceByPackResponse GetAggregateAccountComplianceByPack(GetAggregateAccountComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateAccountComplianceByPackWithOptions(request, runtime);
        }

        public async Task<GetAggregateAccountComplianceByPackResponse> GetAggregateAccountComplianceByPackAsync(GetAggregateAccountComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateAccountComplianceByPackWithOptionsAsync(request, runtime);
        }

        public GetAggregateCompliancePackResponse GetAggregateCompliancePackWithOptions(GetAggregateCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateCompliancePackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateCompliancePackResponse> GetAggregateCompliancePackWithOptionsAsync(GetAggregateCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateCompliancePackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateCompliancePackResponse GetAggregateCompliancePack(GetAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateCompliancePackWithOptions(request, runtime);
        }

        public async Task<GetAggregateCompliancePackResponse> GetAggregateCompliancePackAsync(GetAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateCompliancePackWithOptionsAsync(request, runtime);
        }

        public GetAggregateCompliancePackReportResponse GetAggregateCompliancePackReportWithOptions(GetAggregateCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateCompliancePackReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateCompliancePackReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateCompliancePackReportResponse> GetAggregateCompliancePackReportWithOptionsAsync(GetAggregateCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateCompliancePackReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateCompliancePackReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateCompliancePackReportResponse GetAggregateCompliancePackReport(GetAggregateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateCompliancePackReportWithOptions(request, runtime);
        }

        public async Task<GetAggregateCompliancePackReportResponse> GetAggregateCompliancePackReportAsync(GetAggregateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateCompliancePackReportWithOptionsAsync(request, runtime);
        }

        public GetAggregateConfigRuleResponse GetAggregateConfigRuleWithOptions(GetAggregateConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                query["ConfigRuleId"] = request.ConfigRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateConfigRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateConfigRuleResponse> GetAggregateConfigRuleWithOptionsAsync(GetAggregateConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                query["ConfigRuleId"] = request.ConfigRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateConfigRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateConfigRuleResponse GetAggregateConfigRule(GetAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateConfigRuleWithOptions(request, runtime);
        }

        public async Task<GetAggregateConfigRuleResponse> GetAggregateConfigRuleAsync(GetAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateConfigRuleWithOptionsAsync(request, runtime);
        }

        public GetAggregateConfigRuleComplianceByPackResponse GetAggregateConfigRuleComplianceByPackWithOptions(GetAggregateConfigRuleComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateConfigRuleComplianceByPack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateConfigRuleComplianceByPackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateConfigRuleComplianceByPackResponse> GetAggregateConfigRuleComplianceByPackWithOptionsAsync(GetAggregateConfigRuleComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateConfigRuleComplianceByPack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateConfigRuleComplianceByPackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateConfigRuleComplianceByPackResponse GetAggregateConfigRuleComplianceByPack(GetAggregateConfigRuleComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateConfigRuleComplianceByPackWithOptions(request, runtime);
        }

        public async Task<GetAggregateConfigRuleComplianceByPackResponse> GetAggregateConfigRuleComplianceByPackAsync(GetAggregateConfigRuleComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateConfigRuleComplianceByPackWithOptionsAsync(request, runtime);
        }

        public GetAggregateConfigRuleSummaryByRiskLevelResponse GetAggregateConfigRuleSummaryByRiskLevelWithOptions(GetAggregateConfigRuleSummaryByRiskLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateConfigRuleSummaryByRiskLevel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateConfigRuleSummaryByRiskLevelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateConfigRuleSummaryByRiskLevelResponse> GetAggregateConfigRuleSummaryByRiskLevelWithOptionsAsync(GetAggregateConfigRuleSummaryByRiskLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateConfigRuleSummaryByRiskLevel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateConfigRuleSummaryByRiskLevelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateConfigRuleSummaryByRiskLevelResponse GetAggregateConfigRuleSummaryByRiskLevel(GetAggregateConfigRuleSummaryByRiskLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateConfigRuleSummaryByRiskLevelWithOptions(request, runtime);
        }

        public async Task<GetAggregateConfigRuleSummaryByRiskLevelResponse> GetAggregateConfigRuleSummaryByRiskLevelAsync(GetAggregateConfigRuleSummaryByRiskLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateConfigRuleSummaryByRiskLevelWithOptionsAsync(request, runtime);
        }

        public GetAggregateConfigRulesReportResponse GetAggregateConfigRulesReportWithOptions(GetAggregateConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateConfigRulesReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateConfigRulesReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateConfigRulesReportResponse> GetAggregateConfigRulesReportWithOptionsAsync(GetAggregateConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateConfigRulesReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateConfigRulesReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateConfigRulesReportResponse GetAggregateConfigRulesReport(GetAggregateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateConfigRulesReportWithOptions(request, runtime);
        }

        public async Task<GetAggregateConfigRulesReportResponse> GetAggregateConfigRulesReportAsync(GetAggregateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateConfigRulesReportWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceComplianceByConfigRuleResponse GetAggregateResourceComplianceByConfigRuleWithOptions(GetAggregateResourceComplianceByConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplianceType))
            {
                query["ComplianceType"] = request.ComplianceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                query["ConfigRuleId"] = request.ConfigRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceComplianceByConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceByConfigRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateResourceComplianceByConfigRuleResponse> GetAggregateResourceComplianceByConfigRuleWithOptionsAsync(GetAggregateResourceComplianceByConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplianceType))
            {
                query["ComplianceType"] = request.ComplianceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                query["ConfigRuleId"] = request.ConfigRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceComplianceByConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceByConfigRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateResourceComplianceByConfigRuleResponse GetAggregateResourceComplianceByConfigRule(GetAggregateResourceComplianceByConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceComplianceByConfigRuleWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceComplianceByConfigRuleResponse> GetAggregateResourceComplianceByConfigRuleAsync(GetAggregateResourceComplianceByConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceComplianceByConfigRuleWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceComplianceByPackResponse GetAggregateResourceComplianceByPackWithOptions(GetAggregateResourceComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceComplianceByPack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceByPackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateResourceComplianceByPackResponse> GetAggregateResourceComplianceByPackWithOptionsAsync(GetAggregateResourceComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceComplianceByPack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceByPackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateResourceComplianceByPackResponse GetAggregateResourceComplianceByPack(GetAggregateResourceComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceComplianceByPackWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceComplianceByPackResponse> GetAggregateResourceComplianceByPackAsync(GetAggregateResourceComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceComplianceByPackWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceComplianceGroupByRegionResponse GetAggregateResourceComplianceGroupByRegionWithOptions(GetAggregateResourceComplianceGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceComplianceGroupByRegion",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceGroupByRegionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateResourceComplianceGroupByRegionResponse> GetAggregateResourceComplianceGroupByRegionWithOptionsAsync(GetAggregateResourceComplianceGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceComplianceGroupByRegion",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceGroupByRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateResourceComplianceGroupByRegionResponse GetAggregateResourceComplianceGroupByRegion(GetAggregateResourceComplianceGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceComplianceGroupByRegionWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceComplianceGroupByRegionResponse> GetAggregateResourceComplianceGroupByRegionAsync(GetAggregateResourceComplianceGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceComplianceGroupByRegionWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceComplianceGroupByResourceTypeResponse GetAggregateResourceComplianceGroupByResourceTypeWithOptions(GetAggregateResourceComplianceGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceComplianceGroupByResourceType",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceGroupByResourceTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateResourceComplianceGroupByResourceTypeResponse> GetAggregateResourceComplianceGroupByResourceTypeWithOptionsAsync(GetAggregateResourceComplianceGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceComplianceGroupByResourceType",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceGroupByResourceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateResourceComplianceGroupByResourceTypeResponse GetAggregateResourceComplianceGroupByResourceType(GetAggregateResourceComplianceGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceComplianceGroupByResourceTypeWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceComplianceGroupByResourceTypeResponse> GetAggregateResourceComplianceGroupByResourceTypeAsync(GetAggregateResourceComplianceGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceComplianceGroupByResourceTypeWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceComplianceTimelineResponse GetAggregateResourceComplianceTimelineWithOptions(GetAggregateResourceComplianceTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceComplianceTimeline",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceTimelineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateResourceComplianceTimelineResponse> GetAggregateResourceComplianceTimelineWithOptionsAsync(GetAggregateResourceComplianceTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceComplianceTimeline",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceTimelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateResourceComplianceTimelineResponse GetAggregateResourceComplianceTimeline(GetAggregateResourceComplianceTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceComplianceTimelineWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceComplianceTimelineResponse> GetAggregateResourceComplianceTimelineAsync(GetAggregateResourceComplianceTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceComplianceTimelineWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceConfigurationTimelineResponse GetAggregateResourceConfigurationTimelineWithOptions(GetAggregateResourceConfigurationTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceConfigurationTimeline",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceConfigurationTimelineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateResourceConfigurationTimelineResponse> GetAggregateResourceConfigurationTimelineWithOptionsAsync(GetAggregateResourceConfigurationTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceConfigurationTimeline",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceConfigurationTimelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateResourceConfigurationTimelineResponse GetAggregateResourceConfigurationTimeline(GetAggregateResourceConfigurationTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceConfigurationTimelineWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceConfigurationTimelineResponse> GetAggregateResourceConfigurationTimelineAsync(GetAggregateResourceConfigurationTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceConfigurationTimelineWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceCountsGroupByRegionResponse GetAggregateResourceCountsGroupByRegionWithOptions(GetAggregateResourceCountsGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceCountsGroupByRegion",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceCountsGroupByRegionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateResourceCountsGroupByRegionResponse> GetAggregateResourceCountsGroupByRegionWithOptionsAsync(GetAggregateResourceCountsGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceCountsGroupByRegion",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceCountsGroupByRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateResourceCountsGroupByRegionResponse GetAggregateResourceCountsGroupByRegion(GetAggregateResourceCountsGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceCountsGroupByRegionWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceCountsGroupByRegionResponse> GetAggregateResourceCountsGroupByRegionAsync(GetAggregateResourceCountsGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceCountsGroupByRegionWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceCountsGroupByResourceTypeResponse GetAggregateResourceCountsGroupByResourceTypeWithOptions(GetAggregateResourceCountsGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceCountsGroupByResourceType",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceCountsGroupByResourceTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateResourceCountsGroupByResourceTypeResponse> GetAggregateResourceCountsGroupByResourceTypeWithOptionsAsync(GetAggregateResourceCountsGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceCountsGroupByResourceType",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceCountsGroupByResourceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateResourceCountsGroupByResourceTypeResponse GetAggregateResourceCountsGroupByResourceType(GetAggregateResourceCountsGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceCountsGroupByResourceTypeWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceCountsGroupByResourceTypeResponse> GetAggregateResourceCountsGroupByResourceTypeAsync(GetAggregateResourceCountsGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceCountsGroupByResourceTypeWithOptionsAsync(request, runtime);
        }

        public GetAggregatorResponse GetAggregatorWithOptions(GetAggregatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregator",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregatorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregatorResponse> GetAggregatorWithOptionsAsync(GetAggregatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregator",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregatorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregatorResponse GetAggregator(GetAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregatorWithOptions(request, runtime);
        }

        public async Task<GetAggregatorResponse> GetAggregatorAsync(GetAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregatorWithOptionsAsync(request, runtime);
        }

        public GetCompliancePackResponse GetCompliancePackWithOptions(GetCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCompliancePackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCompliancePackResponse> GetCompliancePackWithOptionsAsync(GetCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCompliancePackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCompliancePackResponse GetCompliancePack(GetCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCompliancePackWithOptions(request, runtime);
        }

        public async Task<GetCompliancePackResponse> GetCompliancePackAsync(GetCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCompliancePackWithOptionsAsync(request, runtime);
        }

        public GetCompliancePackReportResponse GetCompliancePackReportWithOptions(GetCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCompliancePackReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCompliancePackReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCompliancePackReportResponse> GetCompliancePackReportWithOptionsAsync(GetCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCompliancePackReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCompliancePackReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCompliancePackReportResponse GetCompliancePackReport(GetCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCompliancePackReportWithOptions(request, runtime);
        }

        public async Task<GetCompliancePackReportResponse> GetCompliancePackReportAsync(GetCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCompliancePackReportWithOptionsAsync(request, runtime);
        }

        public GetConfigRuleResponse GetConfigRuleWithOptions(GetConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                query["ConfigRuleId"] = request.ConfigRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetConfigRuleResponse> GetConfigRuleWithOptionsAsync(GetConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                query["ConfigRuleId"] = request.ConfigRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetConfigRuleResponse GetConfigRule(GetConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigRuleWithOptions(request, runtime);
        }

        public async Task<GetConfigRuleResponse> GetConfigRuleAsync(GetConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigRuleWithOptionsAsync(request, runtime);
        }

        public GetConfigRuleComplianceByPackResponse GetConfigRuleComplianceByPackWithOptions(GetConfigRuleComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigRuleComplianceByPack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigRuleComplianceByPackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetConfigRuleComplianceByPackResponse> GetConfigRuleComplianceByPackWithOptionsAsync(GetConfigRuleComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigRuleComplianceByPack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigRuleComplianceByPackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetConfigRuleComplianceByPackResponse GetConfigRuleComplianceByPack(GetConfigRuleComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigRuleComplianceByPackWithOptions(request, runtime);
        }

        public async Task<GetConfigRuleComplianceByPackResponse> GetConfigRuleComplianceByPackAsync(GetConfigRuleComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigRuleComplianceByPackWithOptionsAsync(request, runtime);
        }

        public GetConfigRuleSummaryByRiskLevelResponse GetConfigRuleSummaryByRiskLevelWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigRuleSummaryByRiskLevel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigRuleSummaryByRiskLevelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetConfigRuleSummaryByRiskLevelResponse> GetConfigRuleSummaryByRiskLevelWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigRuleSummaryByRiskLevel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigRuleSummaryByRiskLevelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetConfigRuleSummaryByRiskLevelResponse GetConfigRuleSummaryByRiskLevel()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigRuleSummaryByRiskLevelWithOptions(runtime);
        }

        public async Task<GetConfigRuleSummaryByRiskLevelResponse> GetConfigRuleSummaryByRiskLevelAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigRuleSummaryByRiskLevelWithOptionsAsync(runtime);
        }

        public GetConfigRulesReportResponse GetConfigRulesReportWithOptions(GetConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigRulesReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigRulesReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetConfigRulesReportResponse> GetConfigRulesReportWithOptionsAsync(GetConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigRulesReport",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigRulesReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetConfigRulesReportResponse GetConfigRulesReport(GetConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigRulesReportWithOptions(request, runtime);
        }

        public async Task<GetConfigRulesReportResponse> GetConfigRulesReportAsync(GetConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigRulesReportWithOptionsAsync(request, runtime);
        }

        public GetDiscoveredResourceCountsGroupByRegionResponse GetDiscoveredResourceCountsGroupByRegionWithOptions(GetDiscoveredResourceCountsGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiscoveredResourceCountsGroupByRegion",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsGroupByRegionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDiscoveredResourceCountsGroupByRegionResponse> GetDiscoveredResourceCountsGroupByRegionWithOptionsAsync(GetDiscoveredResourceCountsGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiscoveredResourceCountsGroupByRegion",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsGroupByRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDiscoveredResourceCountsGroupByRegionResponse GetDiscoveredResourceCountsGroupByRegion(GetDiscoveredResourceCountsGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiscoveredResourceCountsGroupByRegionWithOptions(request, runtime);
        }

        public async Task<GetDiscoveredResourceCountsGroupByRegionResponse> GetDiscoveredResourceCountsGroupByRegionAsync(GetDiscoveredResourceCountsGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiscoveredResourceCountsGroupByRegionWithOptionsAsync(request, runtime);
        }

        public GetDiscoveredResourceCountsGroupByResourceTypeResponse GetDiscoveredResourceCountsGroupByResourceTypeWithOptions(GetDiscoveredResourceCountsGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiscoveredResourceCountsGroupByResourceType",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsGroupByResourceTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDiscoveredResourceCountsGroupByResourceTypeResponse> GetDiscoveredResourceCountsGroupByResourceTypeWithOptionsAsync(GetDiscoveredResourceCountsGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiscoveredResourceCountsGroupByResourceType",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsGroupByResourceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDiscoveredResourceCountsGroupByResourceTypeResponse GetDiscoveredResourceCountsGroupByResourceType(GetDiscoveredResourceCountsGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiscoveredResourceCountsGroupByResourceTypeWithOptions(request, runtime);
        }

        public async Task<GetDiscoveredResourceCountsGroupByResourceTypeResponse> GetDiscoveredResourceCountsGroupByResourceTypeAsync(GetDiscoveredResourceCountsGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiscoveredResourceCountsGroupByResourceTypeWithOptionsAsync(request, runtime);
        }

        public GetManagedRuleResponse GetManagedRuleWithOptions(GetManagedRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetManagedRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetManagedRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetManagedRuleResponse> GetManagedRuleWithOptionsAsync(GetManagedRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetManagedRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetManagedRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetManagedRuleResponse GetManagedRule(GetManagedRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetManagedRuleWithOptions(request, runtime);
        }

        public async Task<GetManagedRuleResponse> GetManagedRuleAsync(GetManagedRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetManagedRuleWithOptionsAsync(request, runtime);
        }

        public GetResourceComplianceByConfigRuleResponse GetResourceComplianceByConfigRuleWithOptions(GetResourceComplianceByConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceComplianceByConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceComplianceByConfigRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetResourceComplianceByConfigRuleResponse> GetResourceComplianceByConfigRuleWithOptionsAsync(GetResourceComplianceByConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceComplianceByConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceComplianceByConfigRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetResourceComplianceByConfigRuleResponse GetResourceComplianceByConfigRule(GetResourceComplianceByConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceComplianceByConfigRuleWithOptions(request, runtime);
        }

        public async Task<GetResourceComplianceByConfigRuleResponse> GetResourceComplianceByConfigRuleAsync(GetResourceComplianceByConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceComplianceByConfigRuleWithOptionsAsync(request, runtime);
        }

        public GetResourceComplianceByPackResponse GetResourceComplianceByPackWithOptions(GetResourceComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceComplianceByPack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceComplianceByPackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetResourceComplianceByPackResponse> GetResourceComplianceByPackWithOptionsAsync(GetResourceComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceComplianceByPack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceComplianceByPackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetResourceComplianceByPackResponse GetResourceComplianceByPack(GetResourceComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceComplianceByPackWithOptions(request, runtime);
        }

        public async Task<GetResourceComplianceByPackResponse> GetResourceComplianceByPackAsync(GetResourceComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceComplianceByPackWithOptionsAsync(request, runtime);
        }

        public GetResourceComplianceGroupByRegionResponse GetResourceComplianceGroupByRegionWithOptions(GetResourceComplianceGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceComplianceGroupByRegion",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceComplianceGroupByRegionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetResourceComplianceGroupByRegionResponse> GetResourceComplianceGroupByRegionWithOptionsAsync(GetResourceComplianceGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceComplianceGroupByRegion",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceComplianceGroupByRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetResourceComplianceGroupByRegionResponse GetResourceComplianceGroupByRegion(GetResourceComplianceGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceComplianceGroupByRegionWithOptions(request, runtime);
        }

        public async Task<GetResourceComplianceGroupByRegionResponse> GetResourceComplianceGroupByRegionAsync(GetResourceComplianceGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceComplianceGroupByRegionWithOptionsAsync(request, runtime);
        }

        public GetResourceComplianceGroupByResourceTypeResponse GetResourceComplianceGroupByResourceTypeWithOptions(GetResourceComplianceGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceComplianceGroupByResourceType",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceComplianceGroupByResourceTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetResourceComplianceGroupByResourceTypeResponse> GetResourceComplianceGroupByResourceTypeWithOptionsAsync(GetResourceComplianceGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceComplianceGroupByResourceType",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceComplianceGroupByResourceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetResourceComplianceGroupByResourceTypeResponse GetResourceComplianceGroupByResourceType(GetResourceComplianceGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceComplianceGroupByResourceTypeWithOptions(request, runtime);
        }

        public async Task<GetResourceComplianceGroupByResourceTypeResponse> GetResourceComplianceGroupByResourceTypeAsync(GetResourceComplianceGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceComplianceGroupByResourceTypeWithOptionsAsync(request, runtime);
        }

        public GetResourceComplianceTimelineResponse GetResourceComplianceTimelineWithOptions(GetResourceComplianceTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceComplianceTimeline",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceComplianceTimelineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetResourceComplianceTimelineResponse> GetResourceComplianceTimelineWithOptionsAsync(GetResourceComplianceTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceComplianceTimeline",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceComplianceTimelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetResourceComplianceTimelineResponse GetResourceComplianceTimeline(GetResourceComplianceTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceComplianceTimelineWithOptions(request, runtime);
        }

        public async Task<GetResourceComplianceTimelineResponse> GetResourceComplianceTimelineAsync(GetResourceComplianceTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceComplianceTimelineWithOptionsAsync(request, runtime);
        }

        public GetResourceConfigurationTimelineResponse GetResourceConfigurationTimelineWithOptions(GetResourceConfigurationTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceConfigurationTimeline",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceConfigurationTimelineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetResourceConfigurationTimelineResponse> GetResourceConfigurationTimelineWithOptionsAsync(GetResourceConfigurationTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceConfigurationTimeline",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceConfigurationTimelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetResourceConfigurationTimelineResponse GetResourceConfigurationTimeline(GetResourceConfigurationTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceConfigurationTimelineWithOptions(request, runtime);
        }

        public async Task<GetResourceConfigurationTimelineResponse> GetResourceConfigurationTimelineAsync(GetResourceConfigurationTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceConfigurationTimelineWithOptionsAsync(request, runtime);
        }

        public IgnoreAggregateEvaluationResultsResponse IgnoreAggregateEvaluationResultsWithOptions(IgnoreAggregateEvaluationResultsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IgnoreAggregateEvaluationResultsShrinkRequest request = new IgnoreAggregateEvaluationResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Resources))
            {
                request.ResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Resources, "Resources", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcesShrink))
            {
                body["Resources"] = request.ResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IgnoreAggregateEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IgnoreAggregateEvaluationResultsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IgnoreAggregateEvaluationResultsResponse> IgnoreAggregateEvaluationResultsWithOptionsAsync(IgnoreAggregateEvaluationResultsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IgnoreAggregateEvaluationResultsShrinkRequest request = new IgnoreAggregateEvaluationResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Resources))
            {
                request.ResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Resources, "Resources", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcesShrink))
            {
                body["Resources"] = request.ResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IgnoreAggregateEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IgnoreAggregateEvaluationResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IgnoreAggregateEvaluationResultsResponse IgnoreAggregateEvaluationResults(IgnoreAggregateEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IgnoreAggregateEvaluationResultsWithOptions(request, runtime);
        }

        public async Task<IgnoreAggregateEvaluationResultsResponse> IgnoreAggregateEvaluationResultsAsync(IgnoreAggregateEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IgnoreAggregateEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public IgnoreEvaluationResultsResponse IgnoreEvaluationResultsWithOptions(IgnoreEvaluationResultsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IgnoreEvaluationResultsShrinkRequest request = new IgnoreEvaluationResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Resources))
            {
                request.ResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Resources, "Resources", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcesShrink))
            {
                body["Resources"] = request.ResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IgnoreEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IgnoreEvaluationResultsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IgnoreEvaluationResultsResponse> IgnoreEvaluationResultsWithOptionsAsync(IgnoreEvaluationResultsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IgnoreEvaluationResultsShrinkRequest request = new IgnoreEvaluationResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Resources))
            {
                request.ResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Resources, "Resources", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcesShrink))
            {
                body["Resources"] = request.ResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IgnoreEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IgnoreEvaluationResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IgnoreEvaluationResultsResponse IgnoreEvaluationResults(IgnoreEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IgnoreEvaluationResultsWithOptions(request, runtime);
        }

        public async Task<IgnoreEvaluationResultsResponse> IgnoreEvaluationResultsAsync(IgnoreEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IgnoreEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public ListAggregateCompliancePacksResponse ListAggregateCompliancePacksWithOptions(ListAggregateCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateCompliancePacks",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateCompliancePacksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAggregateCompliancePacksResponse> ListAggregateCompliancePacksWithOptionsAsync(ListAggregateCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateCompliancePacks",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateCompliancePacksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAggregateCompliancePacksResponse ListAggregateCompliancePacks(ListAggregateCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateCompliancePacksWithOptions(request, runtime);
        }

        public async Task<ListAggregateCompliancePacksResponse> ListAggregateCompliancePacksAsync(ListAggregateCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateCompliancePacksWithOptionsAsync(request, runtime);
        }

        public ListAggregateConfigRuleEvaluationResultsResponse ListAggregateConfigRuleEvaluationResultsWithOptions(ListAggregateConfigRuleEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateConfigRuleEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateConfigRuleEvaluationResultsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAggregateConfigRuleEvaluationResultsResponse> ListAggregateConfigRuleEvaluationResultsWithOptionsAsync(ListAggregateConfigRuleEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateConfigRuleEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateConfigRuleEvaluationResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAggregateConfigRuleEvaluationResultsResponse ListAggregateConfigRuleEvaluationResults(ListAggregateConfigRuleEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateConfigRuleEvaluationResultsWithOptions(request, runtime);
        }

        public async Task<ListAggregateConfigRuleEvaluationResultsResponse> ListAggregateConfigRuleEvaluationResultsAsync(ListAggregateConfigRuleEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateConfigRuleEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public ListAggregateConfigRulesResponse ListAggregateConfigRulesWithOptions(ListAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateConfigRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAggregateConfigRulesResponse> ListAggregateConfigRulesWithOptionsAsync(ListAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateConfigRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAggregateConfigRulesResponse ListAggregateConfigRules(ListAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateConfigRulesWithOptions(request, runtime);
        }

        public async Task<ListAggregateConfigRulesResponse> ListAggregateConfigRulesAsync(ListAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateConfigRulesWithOptionsAsync(request, runtime);
        }

        public ListAggregateResourceEvaluationResultsResponse ListAggregateResourceEvaluationResultsWithOptions(ListAggregateResourceEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplianceType))
            {
                query["ComplianceType"] = request.ComplianceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateResourceEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateResourceEvaluationResultsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAggregateResourceEvaluationResultsResponse> ListAggregateResourceEvaluationResultsWithOptionsAsync(ListAggregateResourceEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplianceType))
            {
                query["ComplianceType"] = request.ComplianceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateResourceEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateResourceEvaluationResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAggregateResourceEvaluationResultsResponse ListAggregateResourceEvaluationResults(ListAggregateResourceEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateResourceEvaluationResultsWithOptions(request, runtime);
        }

        public async Task<ListAggregateResourceEvaluationResultsResponse> ListAggregateResourceEvaluationResultsAsync(ListAggregateResourceEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateResourceEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public ListAggregatorsResponse ListAggregatorsWithOptions(ListAggregatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregators",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregatorsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAggregatorsResponse> ListAggregatorsWithOptionsAsync(ListAggregatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregators",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregatorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAggregatorsResponse ListAggregators(ListAggregatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregatorsWithOptions(request, runtime);
        }

        public async Task<ListAggregatorsResponse> ListAggregatorsAsync(ListAggregatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregatorsWithOptionsAsync(request, runtime);
        }

        public ListCompliancePackTemplatesResponse ListCompliancePackTemplatesWithOptions(ListCompliancePackTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCompliancePackTemplates",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCompliancePackTemplatesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCompliancePackTemplatesResponse> ListCompliancePackTemplatesWithOptionsAsync(ListCompliancePackTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCompliancePackTemplates",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCompliancePackTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCompliancePackTemplatesResponse ListCompliancePackTemplates(ListCompliancePackTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCompliancePackTemplatesWithOptions(request, runtime);
        }

        public async Task<ListCompliancePackTemplatesResponse> ListCompliancePackTemplatesAsync(ListCompliancePackTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCompliancePackTemplatesWithOptionsAsync(request, runtime);
        }

        public ListCompliancePacksResponse ListCompliancePacksWithOptions(ListCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCompliancePacks",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCompliancePacksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCompliancePacksResponse> ListCompliancePacksWithOptionsAsync(ListCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCompliancePacks",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCompliancePacksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCompliancePacksResponse ListCompliancePacks(ListCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCompliancePacksWithOptions(request, runtime);
        }

        public async Task<ListCompliancePacksResponse> ListCompliancePacksAsync(ListCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCompliancePacksWithOptionsAsync(request, runtime);
        }

        public ListConfigRuleEvaluationResultsResponse ListConfigRuleEvaluationResultsWithOptions(ListConfigRuleEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigRuleEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigRuleEvaluationResultsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListConfigRuleEvaluationResultsResponse> ListConfigRuleEvaluationResultsWithOptionsAsync(ListConfigRuleEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigRuleEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigRuleEvaluationResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListConfigRuleEvaluationResultsResponse ListConfigRuleEvaluationResults(ListConfigRuleEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConfigRuleEvaluationResultsWithOptions(request, runtime);
        }

        public async Task<ListConfigRuleEvaluationResultsResponse> ListConfigRuleEvaluationResultsAsync(ListConfigRuleEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConfigRuleEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public ListManagedRulesResponse ListManagedRulesWithOptions(ListManagedRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListManagedRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListManagedRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListManagedRulesResponse> ListManagedRulesWithOptionsAsync(ListManagedRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListManagedRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListManagedRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListManagedRulesResponse ListManagedRules(ListManagedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListManagedRulesWithOptions(request, runtime);
        }

        public async Task<ListManagedRulesResponse> ListManagedRulesAsync(ListManagedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListManagedRulesWithOptionsAsync(request, runtime);
        }

        public ListResourceEvaluationResultsResponse ListResourceEvaluationResultsWithOptions(ListResourceEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplianceType))
            {
                query["ComplianceType"] = request.ComplianceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceEvaluationResultsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListResourceEvaluationResultsResponse> ListResourceEvaluationResultsWithOptionsAsync(ListResourceEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplianceType))
            {
                query["ComplianceType"] = request.ComplianceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceEvaluationResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListResourceEvaluationResultsResponse ListResourceEvaluationResults(ListResourceEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceEvaluationResultsWithOptions(request, runtime);
        }

        public async Task<ListResourceEvaluationResultsResponse> ListResourceEvaluationResultsAsync(ListResourceEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public RevertAggregateEvaluationResultsResponse RevertAggregateEvaluationResultsWithOptions(RevertAggregateEvaluationResultsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RevertAggregateEvaluationResultsShrinkRequest request = new RevertAggregateEvaluationResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Resources))
            {
                request.ResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Resources, "Resources", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcesShrink))
            {
                body["Resources"] = request.ResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevertAggregateEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertAggregateEvaluationResultsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RevertAggregateEvaluationResultsResponse> RevertAggregateEvaluationResultsWithOptionsAsync(RevertAggregateEvaluationResultsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RevertAggregateEvaluationResultsShrinkRequest request = new RevertAggregateEvaluationResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Resources))
            {
                request.ResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Resources, "Resources", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcesShrink))
            {
                body["Resources"] = request.ResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevertAggregateEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertAggregateEvaluationResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RevertAggregateEvaluationResultsResponse RevertAggregateEvaluationResults(RevertAggregateEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevertAggregateEvaluationResultsWithOptions(request, runtime);
        }

        public async Task<RevertAggregateEvaluationResultsResponse> RevertAggregateEvaluationResultsAsync(RevertAggregateEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevertAggregateEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public RevertEvaluationResultsResponse RevertEvaluationResultsWithOptions(RevertEvaluationResultsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RevertEvaluationResultsShrinkRequest request = new RevertEvaluationResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Resources))
            {
                request.ResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Resources, "Resources", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcesShrink))
            {
                body["Resources"] = request.ResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevertEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertEvaluationResultsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RevertEvaluationResultsResponse> RevertEvaluationResultsWithOptionsAsync(RevertEvaluationResultsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RevertEvaluationResultsShrinkRequest request = new RevertEvaluationResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Resources))
            {
                request.ResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Resources, "Resources", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcesShrink))
            {
                body["Resources"] = request.ResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevertEvaluationResults",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertEvaluationResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RevertEvaluationResultsResponse RevertEvaluationResults(RevertEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevertEvaluationResultsWithOptions(request, runtime);
        }

        public async Task<RevertEvaluationResultsResponse> RevertEvaluationResultsAsync(RevertEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevertEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public StartAggregateConfigRuleEvaluationResponse StartAggregateConfigRuleEvaluationWithOptions(StartAggregateConfigRuleEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                query["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                query["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevertEvaluation))
            {
                query["RevertEvaluation"] = request.RevertEvaluation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAggregateConfigRuleEvaluation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAggregateConfigRuleEvaluationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartAggregateConfigRuleEvaluationResponse> StartAggregateConfigRuleEvaluationWithOptionsAsync(StartAggregateConfigRuleEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                query["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                query["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevertEvaluation))
            {
                query["RevertEvaluation"] = request.RevertEvaluation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAggregateConfigRuleEvaluation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAggregateConfigRuleEvaluationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartAggregateConfigRuleEvaluationResponse StartAggregateConfigRuleEvaluation(StartAggregateConfigRuleEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartAggregateConfigRuleEvaluationWithOptions(request, runtime);
        }

        public async Task<StartAggregateConfigRuleEvaluationResponse> StartAggregateConfigRuleEvaluationAsync(StartAggregateConfigRuleEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartAggregateConfigRuleEvaluationWithOptionsAsync(request, runtime);
        }

        public UpdateAggregateCompliancePackResponse UpdateAggregateCompliancePackWithOptions(UpdateAggregateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAggregateCompliancePackShrinkRequest request = new UpdateAggregateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                body["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackName))
            {
                body["CompliancePackName"] = request.CompliancePackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRulesShrink))
            {
                body["ConfigRules"] = request.ConfigRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAggregateCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggregateCompliancePackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAggregateCompliancePackResponse> UpdateAggregateCompliancePackWithOptionsAsync(UpdateAggregateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAggregateCompliancePackShrinkRequest request = new UpdateAggregateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                body["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackName))
            {
                body["CompliancePackName"] = request.CompliancePackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRulesShrink))
            {
                body["ConfigRules"] = request.ConfigRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAggregateCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggregateCompliancePackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAggregateCompliancePackResponse UpdateAggregateCompliancePack(UpdateAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAggregateCompliancePackWithOptions(request, runtime);
        }

        public async Task<UpdateAggregateCompliancePackResponse> UpdateAggregateCompliancePackAsync(UpdateAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAggregateCompliancePackWithOptionsAsync(request, runtime);
        }

        public UpdateAggregateConfigRuleResponse UpdateAggregateConfigRuleWithOptions(UpdateAggregateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAggregateConfigRuleShrinkRequest request = new UpdateAggregateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleName))
            {
                body["ConfigRuleName"] = request.ConfigRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleTriggerTypes))
            {
                body["ConfigRuleTriggerTypes"] = request.ConfigRuleTriggerTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParametersShrink))
            {
                body["InputParameters"] = request.InputParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumExecutionFrequency))
            {
                body["MaximumExecutionFrequency"] = request.MaximumExecutionFrequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypesScopeShrink))
            {
                body["ResourceTypesScope"] = request.ResourceTypesScopeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyLogicScope))
            {
                body["TagKeyLogicScope"] = request.TagKeyLogicScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyScope))
            {
                body["TagKeyScope"] = request.TagKeyScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValueScope))
            {
                body["TagValueScope"] = request.TagValueScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAggregateConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggregateConfigRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAggregateConfigRuleResponse> UpdateAggregateConfigRuleWithOptionsAsync(UpdateAggregateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAggregateConfigRuleShrinkRequest request = new UpdateAggregateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleName))
            {
                body["ConfigRuleName"] = request.ConfigRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleTriggerTypes))
            {
                body["ConfigRuleTriggerTypes"] = request.ConfigRuleTriggerTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParametersShrink))
            {
                body["InputParameters"] = request.InputParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumExecutionFrequency))
            {
                body["MaximumExecutionFrequency"] = request.MaximumExecutionFrequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypesScopeShrink))
            {
                body["ResourceTypesScope"] = request.ResourceTypesScopeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyLogicScope))
            {
                body["TagKeyLogicScope"] = request.TagKeyLogicScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyScope))
            {
                body["TagKeyScope"] = request.TagKeyScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValueScope))
            {
                body["TagValueScope"] = request.TagValueScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAggregateConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggregateConfigRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAggregateConfigRuleResponse UpdateAggregateConfigRule(UpdateAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAggregateConfigRuleWithOptions(request, runtime);
        }

        public async Task<UpdateAggregateConfigRuleResponse> UpdateAggregateConfigRuleAsync(UpdateAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAggregateConfigRuleWithOptionsAsync(request, runtime);
        }

        public UpdateAggregatorResponse UpdateAggregatorWithOptions(UpdateAggregatorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAggregatorShrinkRequest request = new UpdateAggregatorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AggregatorAccounts))
            {
                request.AggregatorAccountsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AggregatorAccounts, "AggregatorAccounts", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorAccountsShrink))
            {
                body["AggregatorAccounts"] = request.AggregatorAccountsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorName))
            {
                body["AggregatorName"] = request.AggregatorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAggregator",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggregatorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAggregatorResponse> UpdateAggregatorWithOptionsAsync(UpdateAggregatorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAggregatorShrinkRequest request = new UpdateAggregatorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AggregatorAccounts))
            {
                request.AggregatorAccountsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AggregatorAccounts, "AggregatorAccounts", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorAccountsShrink))
            {
                body["AggregatorAccounts"] = request.AggregatorAccountsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorName))
            {
                body["AggregatorName"] = request.AggregatorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAggregator",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggregatorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAggregatorResponse UpdateAggregator(UpdateAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAggregatorWithOptions(request, runtime);
        }

        public async Task<UpdateAggregatorResponse> UpdateAggregatorAsync(UpdateAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAggregatorWithOptionsAsync(request, runtime);
        }

        public UpdateCompliancePackResponse UpdateCompliancePackWithOptions(UpdateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCompliancePackShrinkRequest request = new UpdateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                body["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackName))
            {
                body["CompliancePackName"] = request.CompliancePackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRulesShrink))
            {
                body["ConfigRules"] = request.ConfigRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCompliancePackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateCompliancePackResponse> UpdateCompliancePackWithOptionsAsync(UpdateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCompliancePackShrinkRequest request = new UpdateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackId))
            {
                body["CompliancePackId"] = request.CompliancePackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackName))
            {
                body["CompliancePackName"] = request.CompliancePackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRulesShrink))
            {
                body["ConfigRules"] = request.ConfigRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCompliancePack",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCompliancePackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateCompliancePackResponse UpdateCompliancePack(UpdateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCompliancePackWithOptions(request, runtime);
        }

        public async Task<UpdateCompliancePackResponse> UpdateCompliancePackAsync(UpdateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCompliancePackWithOptionsAsync(request, runtime);
        }

        public UpdateConfigRuleResponse UpdateConfigRuleWithOptions(UpdateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateConfigRuleShrinkRequest request = new UpdateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleName))
            {
                body["ConfigRuleName"] = request.ConfigRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleTriggerTypes))
            {
                body["ConfigRuleTriggerTypes"] = request.ConfigRuleTriggerTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParametersShrink))
            {
                body["InputParameters"] = request.InputParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumExecutionFrequency))
            {
                body["MaximumExecutionFrequency"] = request.MaximumExecutionFrequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypesScopeShrink))
            {
                body["ResourceTypesScope"] = request.ResourceTypesScopeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyLogicScope))
            {
                body["TagKeyLogicScope"] = request.TagKeyLogicScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyScope))
            {
                body["TagKeyScope"] = request.TagKeyScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValueScope))
            {
                body["TagValueScope"] = request.TagValueScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateConfigRuleResponse> UpdateConfigRuleWithOptionsAsync(UpdateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateConfigRuleShrinkRequest request = new UpdateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleName))
            {
                body["ConfigRuleName"] = request.ConfigRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleTriggerTypes))
            {
                body["ConfigRuleTriggerTypes"] = request.ConfigRuleTriggerTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParametersShrink))
            {
                body["InputParameters"] = request.InputParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumExecutionFrequency))
            {
                body["MaximumExecutionFrequency"] = request.MaximumExecutionFrequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypesScopeShrink))
            {
                body["ResourceTypesScope"] = request.ResourceTypesScopeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyLogicScope))
            {
                body["TagKeyLogicScope"] = request.TagKeyLogicScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyScope))
            {
                body["TagKeyScope"] = request.TagKeyScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValueScope))
            {
                body["TagValueScope"] = request.TagValueScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigRule",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateConfigRuleResponse UpdateConfigRule(UpdateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConfigRuleWithOptions(request, runtime);
        }

        public async Task<UpdateConfigRuleResponse> UpdateConfigRuleAsync(UpdateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConfigRuleWithOptionsAsync(request, runtime);
        }

    }
}
