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

        /**
          * This topic provides an example on how to enable the `cr-5772ba41209e007b****` rule in the `ca-a4e5626622af0079****` account group.
          *
          * @param request ActiveAggregateConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ActiveAggregateConfigRulesResponse
         */
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

        /**
          * This topic provides an example on how to enable the `cr-5772ba41209e007b****` rule in the `ca-a4e5626622af0079****` account group.
          *
          * @param request ActiveAggregateConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ActiveAggregateConfigRulesResponse
         */
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

        /**
          * This topic provides an example on how to enable the `cr-5772ba41209e007b****` rule in the `ca-a4e5626622af0079****` account group.
          *
          * @param request ActiveAggregateConfigRulesRequest
          * @return ActiveAggregateConfigRulesResponse
         */
        public ActiveAggregateConfigRulesResponse ActiveAggregateConfigRules(ActiveAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveAggregateConfigRulesWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to enable the `cr-5772ba41209e007b****` rule in the `ca-a4e5626622af0079****` account group.
          *
          * @param request ActiveAggregateConfigRulesRequest
          * @return ActiveAggregateConfigRulesResponse
         */
        public async Task<ActiveAggregateConfigRulesResponse> ActiveAggregateConfigRulesAsync(ActiveAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveAggregateConfigRulesWithOptionsAsync(request, runtime);
        }

        public ActiveConfigRulesResponse ActiveConfigRulesWithOptions(ActiveConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ActiveConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveConfigRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ActiveConfigRulesResponse> ActiveConfigRulesWithOptionsAsync(ActiveConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ActiveConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveConfigRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ActiveConfigRulesResponse ActiveConfigRules(ActiveConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveConfigRulesWithOptions(request, runtime);
        }

        public async Task<ActiveConfigRulesResponse> ActiveConfigRulesAsync(ActiveConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveConfigRulesWithOptionsAsync(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to add the `cr-6cc4626622af00e7****` rule in the `ca-75b4626622af00c3****` account group to the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request AttachAggregateConfigRuleToCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AttachAggregateConfigRuleToCompliancePackResponse
         */
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

        /**
          * The sample request in this topic shows you how to add the `cr-6cc4626622af00e7****` rule in the `ca-75b4626622af00c3****` account group to the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request AttachAggregateConfigRuleToCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AttachAggregateConfigRuleToCompliancePackResponse
         */
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

        /**
          * The sample request in this topic shows you how to add the `cr-6cc4626622af00e7****` rule in the `ca-75b4626622af00c3****` account group to the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request AttachAggregateConfigRuleToCompliancePackRequest
          * @return AttachAggregateConfigRuleToCompliancePackResponse
         */
        public AttachAggregateConfigRuleToCompliancePackResponse AttachAggregateConfigRuleToCompliancePack(AttachAggregateConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachAggregateConfigRuleToCompliancePackWithOptions(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to add the `cr-6cc4626622af00e7****` rule in the `ca-75b4626622af00c3****` account group to the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request AttachAggregateConfigRuleToCompliancePackRequest
          * @return AttachAggregateConfigRuleToCompliancePackResponse
         */
        public async Task<AttachAggregateConfigRuleToCompliancePackResponse> AttachAggregateConfigRuleToCompliancePackAsync(AttachAggregateConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachAggregateConfigRuleToCompliancePackWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to add the `cr-6cc4626622af00e7****` rule to the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request AttachConfigRuleToCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AttachConfigRuleToCompliancePackResponse
         */
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

        /**
          * This topic provides an example on how to add the `cr-6cc4626622af00e7****` rule to the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request AttachConfigRuleToCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AttachConfigRuleToCompliancePackResponse
         */
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

        /**
          * This topic provides an example on how to add the `cr-6cc4626622af00e7****` rule to the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request AttachConfigRuleToCompliancePackRequest
          * @return AttachConfigRuleToCompliancePackResponse
         */
        public AttachConfigRuleToCompliancePackResponse AttachConfigRuleToCompliancePack(AttachConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachConfigRuleToCompliancePackWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to add the `cr-6cc4626622af00e7****` rule to the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request AttachConfigRuleToCompliancePackRequest
          * @return AttachConfigRuleToCompliancePackResponse
         */
        public async Task<AttachConfigRuleToCompliancePackResponse> AttachConfigRuleToCompliancePackAsync(AttachConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachConfigRuleToCompliancePackWithOptionsAsync(request, runtime);
        }

        public CopyCompliancePacksResponse CopyCompliancePacksWithOptions(CopyCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesAggregatorIds))
            {
                query["DesAggregatorIds"] = request.DesAggregatorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcAggregatorId))
            {
                query["SrcAggregatorId"] = request.SrcAggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcCompliancePackIds))
            {
                query["SrcCompliancePackIds"] = request.SrcCompliancePackIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyCompliancePacks",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyCompliancePacksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CopyCompliancePacksResponse> CopyCompliancePacksWithOptionsAsync(CopyCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesAggregatorIds))
            {
                query["DesAggregatorIds"] = request.DesAggregatorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcAggregatorId))
            {
                query["SrcAggregatorId"] = request.SrcAggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcCompliancePackIds))
            {
                query["SrcCompliancePackIds"] = request.SrcCompliancePackIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyCompliancePacks",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyCompliancePacksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CopyCompliancePacksResponse CopyCompliancePacks(CopyCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyCompliancePacksWithOptions(request, runtime);
        }

        public async Task<CopyCompliancePacksResponse> CopyCompliancePacksAsync(CopyCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyCompliancePacksWithOptionsAsync(request, runtime);
        }

        public CopyConfigRulesResponse CopyConfigRulesWithOptions(CopyConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesAggregatorIds))
            {
                query["DesAggregatorIds"] = request.DesAggregatorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcAggregatorId))
            {
                query["SrcAggregatorId"] = request.SrcAggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcConfigRuleIds))
            {
                query["SrcConfigRuleIds"] = request.SrcConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyConfigRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CopyConfigRulesResponse> CopyConfigRulesWithOptionsAsync(CopyConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesAggregatorIds))
            {
                query["DesAggregatorIds"] = request.DesAggregatorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcAggregatorId))
            {
                query["SrcAggregatorId"] = request.SrcAggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcConfigRuleIds))
            {
                query["SrcConfigRuleIds"] = request.SrcConfigRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyConfigRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CopyConfigRulesResponse CopyConfigRules(CopyConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyConfigRulesWithOptions(request, runtime);
        }

        public async Task<CopyConfigRulesResponse> CopyConfigRulesAsync(CopyConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyConfigRulesWithOptionsAsync(request, runtime);
        }

        public CreateAdvancedSearchFileResponse CreateAdvancedSearchFileWithOptions(CreateAdvancedSearchFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdvancedSearchFile",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdvancedSearchFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAdvancedSearchFileResponse> CreateAdvancedSearchFileWithOptionsAsync(CreateAdvancedSearchFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdvancedSearchFile",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdvancedSearchFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAdvancedSearchFileResponse CreateAdvancedSearchFile(CreateAdvancedSearchFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAdvancedSearchFileWithOptions(request, runtime);
        }

        public async Task<CreateAdvancedSearchFileResponse> CreateAdvancedSearchFileAsync(CreateAdvancedSearchFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAdvancedSearchFileWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to create a downloadable resource file for an account group whose ID is `ca-edd3626622af00b3****`. The resource file includes all the ECS instances in the account group.
          *
          * @param request CreateAggregateAdvancedSearchFileRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAggregateAdvancedSearchFileResponse
         */
        public CreateAggregateAdvancedSearchFileResponse CreateAggregateAdvancedSearchFileWithOptions(CreateAggregateAdvancedSearchFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggregateAdvancedSearchFile",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggregateAdvancedSearchFileResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create a downloadable resource file for an account group whose ID is `ca-edd3626622af00b3****`. The resource file includes all the ECS instances in the account group.
          *
          * @param request CreateAggregateAdvancedSearchFileRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAggregateAdvancedSearchFileResponse
         */
        public async Task<CreateAggregateAdvancedSearchFileResponse> CreateAggregateAdvancedSearchFileWithOptionsAsync(CreateAggregateAdvancedSearchFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggregateAdvancedSearchFile",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggregateAdvancedSearchFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create a downloadable resource file for an account group whose ID is `ca-edd3626622af00b3****`. The resource file includes all the ECS instances in the account group.
          *
          * @param request CreateAggregateAdvancedSearchFileRequest
          * @return CreateAggregateAdvancedSearchFileResponse
         */
        public CreateAggregateAdvancedSearchFileResponse CreateAggregateAdvancedSearchFile(CreateAggregateAdvancedSearchFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAggregateAdvancedSearchFileWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to create a downloadable resource file for an account group whose ID is `ca-edd3626622af00b3****`. The resource file includes all the ECS instances in the account group.
          *
          * @param request CreateAggregateAdvancedSearchFileRequest
          * @return CreateAggregateAdvancedSearchFileResponse
         */
        public async Task<CreateAggregateAdvancedSearchFileResponse> CreateAggregateAdvancedSearchFileAsync(CreateAggregateAdvancedSearchFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAggregateAdvancedSearchFileWithOptionsAsync(request, runtime);
        }

        /**
          * You can use your management account to create up to five compliance packages for each account group.
          * This topic provides an example on how to create a compliance package named ClassifiedProtectionPreCheck for the `ca-f632626622af0079****` account group. The compliance package contains the `eip-bandwidth-limit` managed rule.
          *
          * @param tmpReq CreateAggregateCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAggregateCompliancePackResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultEnable))
            {
                body["DefaultEnable"] = request.DefaultEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
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

        /**
          * You can use your management account to create up to five compliance packages for each account group.
          * This topic provides an example on how to create a compliance package named ClassifiedProtectionPreCheck for the `ca-f632626622af0079****` account group. The compliance package contains the `eip-bandwidth-limit` managed rule.
          *
          * @param tmpReq CreateAggregateCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAggregateCompliancePackResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultEnable))
            {
                body["DefaultEnable"] = request.DefaultEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
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

        /**
          * You can use your management account to create up to five compliance packages for each account group.
          * This topic provides an example on how to create a compliance package named ClassifiedProtectionPreCheck for the `ca-f632626622af0079****` account group. The compliance package contains the `eip-bandwidth-limit` managed rule.
          *
          * @param request CreateAggregateCompliancePackRequest
          * @return CreateAggregateCompliancePackResponse
         */
        public CreateAggregateCompliancePackResponse CreateAggregateCompliancePack(CreateAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAggregateCompliancePackWithOptions(request, runtime);
        }

        /**
          * You can use your management account to create up to five compliance packages for each account group.
          * This topic provides an example on how to create a compliance package named ClassifiedProtectionPreCheck for the `ca-f632626622af0079****` account group. The compliance package contains the `eip-bandwidth-limit` managed rule.
          *
          * @param request CreateAggregateCompliancePackRequest
          * @return CreateAggregateCompliancePackResponse
         */
        public async Task<CreateAggregateCompliancePackResponse> CreateAggregateCompliancePackAsync(CreateAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAggregateCompliancePackWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, a delivery channel is created for an account group. The ID of the account group is `ca-a4e5626622af0079****`. The type of the delivery channel is `OSS` and the Alibaba Cloud Resource Name (ARN) of the delivery destination is `acs:oss:cn-shanghai:100931896542****:new-bucket`. The result indicates that the delivery channel is created. The ID of the delivery channel is `cdc-8e45ff4e06a3a8****`.
          *
          * @param request CreateAggregateConfigDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAggregateConfigDeliveryChannelResponse
         */
        public CreateAggregateConfigDeliveryChannelResponse CreateAggregateConfigDeliveryChannelWithOptions(CreateAggregateConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationItemChangeNotification))
            {
                query["ConfigurationItemChangeNotification"] = request.ConfigurationItemChangeNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationSnapshot))
            {
                query["ConfigurationSnapshot"] = request.ConfigurationSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelCondition))
            {
                query["DeliveryChannelCondition"] = request.DeliveryChannelCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelName))
            {
                query["DeliveryChannelName"] = request.DeliveryChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelTargetArn))
            {
                query["DeliveryChannelTargetArn"] = request.DeliveryChannelTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelType))
            {
                query["DeliveryChannelType"] = request.DeliveryChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverySnapshotTime))
            {
                query["DeliverySnapshotTime"] = request.DeliverySnapshotTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonCompliantNotification))
            {
                query["NonCompliantNotification"] = request.NonCompliantNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversizedDataOSSTargetArn))
            {
                query["OversizedDataOSSTargetArn"] = request.OversizedDataOSSTargetArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggregateConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggregateConfigDeliveryChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
          * In this example, a delivery channel is created for an account group. The ID of the account group is `ca-a4e5626622af0079****`. The type of the delivery channel is `OSS` and the Alibaba Cloud Resource Name (ARN) of the delivery destination is `acs:oss:cn-shanghai:100931896542****:new-bucket`. The result indicates that the delivery channel is created. The ID of the delivery channel is `cdc-8e45ff4e06a3a8****`.
          *
          * @param request CreateAggregateConfigDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAggregateConfigDeliveryChannelResponse
         */
        public async Task<CreateAggregateConfigDeliveryChannelResponse> CreateAggregateConfigDeliveryChannelWithOptionsAsync(CreateAggregateConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationItemChangeNotification))
            {
                query["ConfigurationItemChangeNotification"] = request.ConfigurationItemChangeNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationSnapshot))
            {
                query["ConfigurationSnapshot"] = request.ConfigurationSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelCondition))
            {
                query["DeliveryChannelCondition"] = request.DeliveryChannelCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelName))
            {
                query["DeliveryChannelName"] = request.DeliveryChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelTargetArn))
            {
                query["DeliveryChannelTargetArn"] = request.DeliveryChannelTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelType))
            {
                query["DeliveryChannelType"] = request.DeliveryChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverySnapshotTime))
            {
                query["DeliverySnapshotTime"] = request.DeliverySnapshotTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonCompliantNotification))
            {
                query["NonCompliantNotification"] = request.NonCompliantNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversizedDataOSSTargetArn))
            {
                query["OversizedDataOSSTargetArn"] = request.OversizedDataOSSTargetArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggregateConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggregateConfigDeliveryChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * In this example, a delivery channel is created for an account group. The ID of the account group is `ca-a4e5626622af0079****`. The type of the delivery channel is `OSS` and the Alibaba Cloud Resource Name (ARN) of the delivery destination is `acs:oss:cn-shanghai:100931896542****:new-bucket`. The result indicates that the delivery channel is created. The ID of the delivery channel is `cdc-8e45ff4e06a3a8****`.
          *
          * @param request CreateAggregateConfigDeliveryChannelRequest
          * @return CreateAggregateConfigDeliveryChannelResponse
         */
        public CreateAggregateConfigDeliveryChannelResponse CreateAggregateConfigDeliveryChannel(CreateAggregateConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAggregateConfigDeliveryChannelWithOptions(request, runtime);
        }

        /**
          * In this example, a delivery channel is created for an account group. The ID of the account group is `ca-a4e5626622af0079****`. The type of the delivery channel is `OSS` and the Alibaba Cloud Resource Name (ARN) of the delivery destination is `acs:oss:cn-shanghai:100931896542****:new-bucket`. The result indicates that the delivery channel is created. The ID of the delivery channel is `cdc-8e45ff4e06a3a8****`.
          *
          * @param request CreateAggregateConfigDeliveryChannelRequest
          * @return CreateAggregateConfigDeliveryChannelResponse
         */
        public async Task<CreateAggregateConfigDeliveryChannelResponse> CreateAggregateConfigDeliveryChannelAsync(CreateAggregateConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAggregateConfigDeliveryChannelWithOptionsAsync(request, runtime);
        }

        /**
          * ### Limits
          * You can create up to 200 rules for each management account.
          * ### Usage notes
          * This topic provides an example on how to create a rule based on the required-tags managed rule in the `ca-a4e5626622af0079****` account group. The returned result shows that the rule is created and its ID is `cr-4e3d626622af0080****`.
          *
          * @param tmpReq CreateAggregateConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAggregateConfigRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeAccountIdsScope))
            {
                body["ExcludeAccountIdsScope"] = request.ExcludeAccountIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeFolderIdsScope))
            {
                body["ExcludeFolderIdsScope"] = request.ExcludeFolderIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderIdsScope))
            {
                body["FolderIdsScope"] = request.FolderIdsScope;
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

        /**
          * ### Limits
          * You can create up to 200 rules for each management account.
          * ### Usage notes
          * This topic provides an example on how to create a rule based on the required-tags managed rule in the `ca-a4e5626622af0079****` account group. The returned result shows that the rule is created and its ID is `cr-4e3d626622af0080****`.
          *
          * @param tmpReq CreateAggregateConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAggregateConfigRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeAccountIdsScope))
            {
                body["ExcludeAccountIdsScope"] = request.ExcludeAccountIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeFolderIdsScope))
            {
                body["ExcludeFolderIdsScope"] = request.ExcludeFolderIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderIdsScope))
            {
                body["FolderIdsScope"] = request.FolderIdsScope;
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

        /**
          * ### Limits
          * You can create up to 200 rules for each management account.
          * ### Usage notes
          * This topic provides an example on how to create a rule based on the required-tags managed rule in the `ca-a4e5626622af0079****` account group. The returned result shows that the rule is created and its ID is `cr-4e3d626622af0080****`.
          *
          * @param request CreateAggregateConfigRuleRequest
          * @return CreateAggregateConfigRuleResponse
         */
        public CreateAggregateConfigRuleResponse CreateAggregateConfigRule(CreateAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAggregateConfigRuleWithOptions(request, runtime);
        }

        /**
          * ### Limits
          * You can create up to 200 rules for each management account.
          * ### Usage notes
          * This topic provides an example on how to create a rule based on the required-tags managed rule in the `ca-a4e5626622af0079****` account group. The returned result shows that the rule is created and its ID is `cr-4e3d626622af0080****`.
          *
          * @param request CreateAggregateConfigRuleRequest
          * @return CreateAggregateConfigRuleResponse
         */
        public async Task<CreateAggregateConfigRuleResponse> CreateAggregateConfigRuleAsync(CreateAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAggregateConfigRuleWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to create a remediation template for the rule whose ID is `cr-6b7c626622af00b4****` in the account group whose ID is `ca-6b4a626622af0012****`. The returned result shows that a remediation template is created and the ID of the remediation template is `crr-909ba2d4716700eb****`.
          *
          * @param request CreateAggregateRemediationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAggregateRemediationResponse
         */
        public CreateAggregateRemediationResponse CreateAggregateRemediationWithOptions(CreateAggregateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                body["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationTemplateId))
            {
                body["RemediationTemplateId"] = request.RemediationTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationType))
            {
                body["RemediationType"] = request.RemediationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggregateRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggregateRemediationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create a remediation template for the rule whose ID is `cr-6b7c626622af00b4****` in the account group whose ID is `ca-6b4a626622af0012****`. The returned result shows that a remediation template is created and the ID of the remediation template is `crr-909ba2d4716700eb****`.
          *
          * @param request CreateAggregateRemediationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAggregateRemediationResponse
         */
        public async Task<CreateAggregateRemediationResponse> CreateAggregateRemediationWithOptionsAsync(CreateAggregateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                body["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationTemplateId))
            {
                body["RemediationTemplateId"] = request.RemediationTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationType))
            {
                body["RemediationType"] = request.RemediationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggregateRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggregateRemediationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create a remediation template for the rule whose ID is `cr-6b7c626622af00b4****` in the account group whose ID is `ca-6b4a626622af0012****`. The returned result shows that a remediation template is created and the ID of the remediation template is `crr-909ba2d4716700eb****`.
          *
          * @param request CreateAggregateRemediationRequest
          * @return CreateAggregateRemediationResponse
         */
        public CreateAggregateRemediationResponse CreateAggregateRemediation(CreateAggregateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAggregateRemediationWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to create a remediation template for the rule whose ID is `cr-6b7c626622af00b4****` in the account group whose ID is `ca-6b4a626622af0012****`. The returned result shows that a remediation template is created and the ID of the remediation template is `crr-909ba2d4716700eb****`.
          *
          * @param request CreateAggregateRemediationRequest
          * @return CreateAggregateRemediationResponse
         */
        public async Task<CreateAggregateRemediationResponse> CreateAggregateRemediationAsync(CreateAggregateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAggregateRemediationWithOptionsAsync(request, runtime);
        }

        /**
          * Each management account can create a maximum of five account groups. Each account group can contain a maximum of 200 member accounts.
          * Cloud Config supports the following types of account groups:
          * *   Global account group: The global account group contains all the member accounts that are added to the resource directory. A management account can create only one global account group.
          * *   Custom account group: If you create a custom account group, you must manually add all or specific member accounts from the resource directory to the custom account group.
          * This topic provides an example on how to create an account group of the `CUSTOM` type. The custom account group is named `Test_Group`, and its description is `Test account group`. The custom account group contains the following two member accounts:
          * *   Member account ID: `171322098523****`. Member account name: `Alice`.
          * *   Member account ID: `100532098349****`. Member account name: `Tom`.
          *
          * @param tmpReq CreateAggregatorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAggregatorResponse
         */
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

        /**
          * Each management account can create a maximum of five account groups. Each account group can contain a maximum of 200 member accounts.
          * Cloud Config supports the following types of account groups:
          * *   Global account group: The global account group contains all the member accounts that are added to the resource directory. A management account can create only one global account group.
          * *   Custom account group: If you create a custom account group, you must manually add all or specific member accounts from the resource directory to the custom account group.
          * This topic provides an example on how to create an account group of the `CUSTOM` type. The custom account group is named `Test_Group`, and its description is `Test account group`. The custom account group contains the following two member accounts:
          * *   Member account ID: `171322098523****`. Member account name: `Alice`.
          * *   Member account ID: `100532098349****`. Member account name: `Tom`.
          *
          * @param tmpReq CreateAggregatorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAggregatorResponse
         */
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

        /**
          * Each management account can create a maximum of five account groups. Each account group can contain a maximum of 200 member accounts.
          * Cloud Config supports the following types of account groups:
          * *   Global account group: The global account group contains all the member accounts that are added to the resource directory. A management account can create only one global account group.
          * *   Custom account group: If you create a custom account group, you must manually add all or specific member accounts from the resource directory to the custom account group.
          * This topic provides an example on how to create an account group of the `CUSTOM` type. The custom account group is named `Test_Group`, and its description is `Test account group`. The custom account group contains the following two member accounts:
          * *   Member account ID: `171322098523****`. Member account name: `Alice`.
          * *   Member account ID: `100532098349****`. Member account name: `Tom`.
          *
          * @param request CreateAggregatorRequest
          * @return CreateAggregatorResponse
         */
        public CreateAggregatorResponse CreateAggregator(CreateAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAggregatorWithOptions(request, runtime);
        }

        /**
          * Each management account can create a maximum of five account groups. Each account group can contain a maximum of 200 member accounts.
          * Cloud Config supports the following types of account groups:
          * *   Global account group: The global account group contains all the member accounts that are added to the resource directory. A management account can create only one global account group.
          * *   Custom account group: If you create a custom account group, you must manually add all or specific member accounts from the resource directory to the custom account group.
          * This topic provides an example on how to create an account group of the `CUSTOM` type. The custom account group is named `Test_Group`, and its description is `Test account group`. The custom account group contains the following two member accounts:
          * *   Member account ID: `171322098523****`. Member account name: `Alice`.
          * *   Member account ID: `100532098349****`. Member account name: `Tom`.
          *
          * @param request CreateAggregatorRequest
          * @return CreateAggregatorResponse
         */
        public async Task<CreateAggregatorResponse> CreateAggregatorAsync(CreateAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAggregatorWithOptionsAsync(request, runtime);
        }

        /**
          * Each ordinary account can create up to five compliance packages.
          * This topic provides an example on how to create a compliance package named ClassifiedProtectionPreCheck. The compliance package contains a managed rule named `eip-bandwidth-limit`.
          *
          * @param tmpReq CreateCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateCompliancePackResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultEnable))
            {
                body["DefaultEnable"] = request.DefaultEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
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

        /**
          * Each ordinary account can create up to five compliance packages.
          * This topic provides an example on how to create a compliance package named ClassifiedProtectionPreCheck. The compliance package contains a managed rule named `eip-bandwidth-limit`.
          *
          * @param tmpReq CreateCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateCompliancePackResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultEnable))
            {
                body["DefaultEnable"] = request.DefaultEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
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

        /**
          * Each ordinary account can create up to five compliance packages.
          * This topic provides an example on how to create a compliance package named ClassifiedProtectionPreCheck. The compliance package contains a managed rule named `eip-bandwidth-limit`.
          *
          * @param request CreateCompliancePackRequest
          * @return CreateCompliancePackResponse
         */
        public CreateCompliancePackResponse CreateCompliancePack(CreateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCompliancePackWithOptions(request, runtime);
        }

        /**
          * Each ordinary account can create up to five compliance packages.
          * This topic provides an example on how to create a compliance package named ClassifiedProtectionPreCheck. The compliance package contains a managed rule named `eip-bandwidth-limit`.
          *
          * @param request CreateCompliancePackRequest
          * @return CreateCompliancePackResponse
         */
        public async Task<CreateCompliancePackResponse> CreateCompliancePackAsync(CreateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCompliancePackWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, a delivery channel is created. The type of the delivery channel is `OSS` and the Alibaba Cloud Resource Name (ARN) of the delivery destination is `acs:oss:cn-shanghai:100931896542****:new-bucket`. The result indicates that the delivery channel is created, and the ID of the delivery channel is `cdc-8e45ff4e06a3a8****`.
          *
          * @param request CreateConfigDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateConfigDeliveryChannelResponse
         */
        public CreateConfigDeliveryChannelResponse CreateConfigDeliveryChannelWithOptions(CreateConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationItemChangeNotification))
            {
                query["ConfigurationItemChangeNotification"] = request.ConfigurationItemChangeNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationSnapshot))
            {
                query["ConfigurationSnapshot"] = request.ConfigurationSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelCondition))
            {
                query["DeliveryChannelCondition"] = request.DeliveryChannelCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelName))
            {
                query["DeliveryChannelName"] = request.DeliveryChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelTargetArn))
            {
                query["DeliveryChannelTargetArn"] = request.DeliveryChannelTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelType))
            {
                query["DeliveryChannelType"] = request.DeliveryChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverySnapshotTime))
            {
                query["DeliverySnapshotTime"] = request.DeliverySnapshotTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonCompliantNotification))
            {
                query["NonCompliantNotification"] = request.NonCompliantNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversizedDataOSSTargetArn))
            {
                query["OversizedDataOSSTargetArn"] = request.OversizedDataOSSTargetArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigDeliveryChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
          * In this example, a delivery channel is created. The type of the delivery channel is `OSS` and the Alibaba Cloud Resource Name (ARN) of the delivery destination is `acs:oss:cn-shanghai:100931896542****:new-bucket`. The result indicates that the delivery channel is created, and the ID of the delivery channel is `cdc-8e45ff4e06a3a8****`.
          *
          * @param request CreateConfigDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateConfigDeliveryChannelResponse
         */
        public async Task<CreateConfigDeliveryChannelResponse> CreateConfigDeliveryChannelWithOptionsAsync(CreateConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationItemChangeNotification))
            {
                query["ConfigurationItemChangeNotification"] = request.ConfigurationItemChangeNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationSnapshot))
            {
                query["ConfigurationSnapshot"] = request.ConfigurationSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelCondition))
            {
                query["DeliveryChannelCondition"] = request.DeliveryChannelCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelName))
            {
                query["DeliveryChannelName"] = request.DeliveryChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelTargetArn))
            {
                query["DeliveryChannelTargetArn"] = request.DeliveryChannelTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelType))
            {
                query["DeliveryChannelType"] = request.DeliveryChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverySnapshotTime))
            {
                query["DeliverySnapshotTime"] = request.DeliverySnapshotTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonCompliantNotification))
            {
                query["NonCompliantNotification"] = request.NonCompliantNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversizedDataOSSTargetArn))
            {
                query["OversizedDataOSSTargetArn"] = request.OversizedDataOSSTargetArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigDeliveryChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * In this example, a delivery channel is created. The type of the delivery channel is `OSS` and the Alibaba Cloud Resource Name (ARN) of the delivery destination is `acs:oss:cn-shanghai:100931896542****:new-bucket`. The result indicates that the delivery channel is created, and the ID of the delivery channel is `cdc-8e45ff4e06a3a8****`.
          *
          * @param request CreateConfigDeliveryChannelRequest
          * @return CreateConfigDeliveryChannelResponse
         */
        public CreateConfigDeliveryChannelResponse CreateConfigDeliveryChannel(CreateConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConfigDeliveryChannelWithOptions(request, runtime);
        }

        /**
          * In this example, a delivery channel is created. The type of the delivery channel is `OSS` and the Alibaba Cloud Resource Name (ARN) of the delivery destination is `acs:oss:cn-shanghai:100931896542****:new-bucket`. The result indicates that the delivery channel is created, and the ID of the delivery channel is `cdc-8e45ff4e06a3a8****`.
          *
          * @param request CreateConfigDeliveryChannelRequest
          * @return CreateConfigDeliveryChannelResponse
         */
        public async Task<CreateConfigDeliveryChannelResponse> CreateConfigDeliveryChannelAsync(CreateConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConfigDeliveryChannelWithOptionsAsync(request, runtime);
        }

        /**
          * ### Limits
          * You can use an ordinary account to create up to 200 rules.
          * ### Usage notes
          * This topic provides an example on how to create a managed rule named required-tags. The returned result indicates that the rule is created and the ID of the rule is `cr-5772ba41209e007b****`.
          *
          * @param tmpReq CreateConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateConfigRuleResponse
         */
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

        /**
          * ### Limits
          * You can use an ordinary account to create up to 200 rules.
          * ### Usage notes
          * This topic provides an example on how to create a managed rule named required-tags. The returned result indicates that the rule is created and the ID of the rule is `cr-5772ba41209e007b****`.
          *
          * @param tmpReq CreateConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateConfigRuleResponse
         */
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

        /**
          * ### Limits
          * You can use an ordinary account to create up to 200 rules.
          * ### Usage notes
          * This topic provides an example on how to create a managed rule named required-tags. The returned result indicates that the rule is created and the ID of the rule is `cr-5772ba41209e007b****`.
          *
          * @param request CreateConfigRuleRequest
          * @return CreateConfigRuleResponse
         */
        public CreateConfigRuleResponse CreateConfigRule(CreateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConfigRuleWithOptions(request, runtime);
        }

        /**
          * ### Limits
          * You can use an ordinary account to create up to 200 rules.
          * ### Usage notes
          * This topic provides an example on how to create a managed rule named required-tags. The returned result indicates that the rule is created and the ID of the rule is `cr-5772ba41209e007b****`.
          *
          * @param request CreateConfigRuleRequest
          * @return CreateConfigRuleResponse
         */
        public async Task<CreateConfigRuleResponse> CreateConfigRuleAsync(CreateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConfigRuleWithOptionsAsync(request, runtime);
        }

        /**
          * @deprecated : CreateDeliveryChannel is deprecated, please use Config::2020-09-07::CreateConfigDeliveryChannel,Config::2020-09-07::CreateAggregateConfigDeliveryChannel instead.
          * In this example, a delivery channel is created. The type of the delivery channel is `OSS`, the Alibaba Cloud Resource Name (ARN) of the delivery destination is `acs:oss:cn-shanghai:100931896542****:new-bucket`, and the ARN of the role that is assigned to the delivery channel is `acs:ram::100931896542****:role/aliyunserviceroleforconfig`. The returned result shows that the delivery channel is created, and the ID of the delivery channel is `cdc-8e45ff4e06a3a8****`.
          *
          * @param request CreateDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateDeliveryChannelResponse
         */
        // Deprecated
        public CreateDeliveryChannelResponse CreateDeliveryChannelWithOptions(CreateDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationItemChangeNotification))
            {
                body["ConfigurationItemChangeNotification"] = request.ConfigurationItemChangeNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationSnapshot))
            {
                body["ConfigurationSnapshot"] = request.ConfigurationSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelAssumeRoleArn))
            {
                body["DeliveryChannelAssumeRoleArn"] = request.DeliveryChannelAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelCondition))
            {
                body["DeliveryChannelCondition"] = request.DeliveryChannelCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelName))
            {
                body["DeliveryChannelName"] = request.DeliveryChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelTargetArn))
            {
                body["DeliveryChannelTargetArn"] = request.DeliveryChannelTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelType))
            {
                body["DeliveryChannelType"] = request.DeliveryChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonCompliantNotification))
            {
                body["NonCompliantNotification"] = request.NonCompliantNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversizedDataOSSTargetArn))
            {
                body["OversizedDataOSSTargetArn"] = request.OversizedDataOSSTargetArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliveryChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
          * @deprecated : CreateDeliveryChannel is deprecated, please use Config::2020-09-07::CreateConfigDeliveryChannel,Config::2020-09-07::CreateAggregateConfigDeliveryChannel instead.
          * In this example, a delivery channel is created. The type of the delivery channel is `OSS`, the Alibaba Cloud Resource Name (ARN) of the delivery destination is `acs:oss:cn-shanghai:100931896542****:new-bucket`, and the ARN of the role that is assigned to the delivery channel is `acs:ram::100931896542****:role/aliyunserviceroleforconfig`. The returned result shows that the delivery channel is created, and the ID of the delivery channel is `cdc-8e45ff4e06a3a8****`.
          *
          * @param request CreateDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateDeliveryChannelResponse
         */
        // Deprecated
        public async Task<CreateDeliveryChannelResponse> CreateDeliveryChannelWithOptionsAsync(CreateDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationItemChangeNotification))
            {
                body["ConfigurationItemChangeNotification"] = request.ConfigurationItemChangeNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationSnapshot))
            {
                body["ConfigurationSnapshot"] = request.ConfigurationSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelAssumeRoleArn))
            {
                body["DeliveryChannelAssumeRoleArn"] = request.DeliveryChannelAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelCondition))
            {
                body["DeliveryChannelCondition"] = request.DeliveryChannelCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelName))
            {
                body["DeliveryChannelName"] = request.DeliveryChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelTargetArn))
            {
                body["DeliveryChannelTargetArn"] = request.DeliveryChannelTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelType))
            {
                body["DeliveryChannelType"] = request.DeliveryChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonCompliantNotification))
            {
                body["NonCompliantNotification"] = request.NonCompliantNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversizedDataOSSTargetArn))
            {
                body["OversizedDataOSSTargetArn"] = request.OversizedDataOSSTargetArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliveryChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * @deprecated : CreateDeliveryChannel is deprecated, please use Config::2020-09-07::CreateConfigDeliveryChannel,Config::2020-09-07::CreateAggregateConfigDeliveryChannel instead.
          * In this example, a delivery channel is created. The type of the delivery channel is `OSS`, the Alibaba Cloud Resource Name (ARN) of the delivery destination is `acs:oss:cn-shanghai:100931896542****:new-bucket`, and the ARN of the role that is assigned to the delivery channel is `acs:ram::100931896542****:role/aliyunserviceroleforconfig`. The returned result shows that the delivery channel is created, and the ID of the delivery channel is `cdc-8e45ff4e06a3a8****`.
          *
          * @param request CreateDeliveryChannelRequest
          * @return CreateDeliveryChannelResponse
         */
        // Deprecated
        public CreateDeliveryChannelResponse CreateDeliveryChannel(CreateDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeliveryChannelWithOptions(request, runtime);
        }

        /**
          * @deprecated : CreateDeliveryChannel is deprecated, please use Config::2020-09-07::CreateConfigDeliveryChannel,Config::2020-09-07::CreateAggregateConfigDeliveryChannel instead.
          * In this example, a delivery channel is created. The type of the delivery channel is `OSS`, the Alibaba Cloud Resource Name (ARN) of the delivery destination is `acs:oss:cn-shanghai:100931896542****:new-bucket`, and the ARN of the role that is assigned to the delivery channel is `acs:ram::100931896542****:role/aliyunserviceroleforconfig`. The returned result shows that the delivery channel is created, and the ID of the delivery channel is `cdc-8e45ff4e06a3a8****`.
          *
          * @param request CreateDeliveryChannelRequest
          * @return CreateDeliveryChannelResponse
         */
        // Deprecated
        public async Task<CreateDeliveryChannelResponse> CreateDeliveryChannelAsync(CreateDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeliveryChannelWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to create a remediation template for the rule `cr-8a973ac2e2be00a2****`. The returned result shows that a remediation template is created and the ID of the remediation template is `crr-909ba2d4716700eb****`.
          *
          * @param request CreateRemediationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRemediationResponse
         */
        public CreateRemediationResponse CreateRemediationWithOptions(CreateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                body["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationTemplateId))
            {
                body["RemediationTemplateId"] = request.RemediationTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationType))
            {
                body["RemediationType"] = request.RemediationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRemediationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create a remediation template for the rule `cr-8a973ac2e2be00a2****`. The returned result shows that a remediation template is created and the ID of the remediation template is `crr-909ba2d4716700eb****`.
          *
          * @param request CreateRemediationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRemediationResponse
         */
        public async Task<CreateRemediationResponse> CreateRemediationWithOptionsAsync(CreateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                body["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                body["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationTemplateId))
            {
                body["RemediationTemplateId"] = request.RemediationTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationType))
            {
                body["RemediationType"] = request.RemediationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRemediationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create a remediation template for the rule `cr-8a973ac2e2be00a2****`. The returned result shows that a remediation template is created and the ID of the remediation template is `crr-909ba2d4716700eb****`.
          *
          * @param request CreateRemediationRequest
          * @return CreateRemediationResponse
         */
        public CreateRemediationResponse CreateRemediation(CreateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRemediationWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to create a remediation template for the rule `cr-8a973ac2e2be00a2****`. The returned result shows that a remediation template is created and the ID of the remediation template is `crr-909ba2d4716700eb****`.
          *
          * @param request CreateRemediationRequest
          * @return CreateRemediationResponse
         */
        public async Task<CreateRemediationResponse> CreateRemediationAsync(CreateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRemediationWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to disable the `cr-5772ba41209e007b****` rule in the `ca-04b3fd170e340007****` account group.
          *
          * @param request DeactiveAggregateConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeactiveAggregateConfigRulesResponse
         */
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

        /**
          * This topic provides an example on how to disable the `cr-5772ba41209e007b****` rule in the `ca-04b3fd170e340007****` account group.
          *
          * @param request DeactiveAggregateConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeactiveAggregateConfigRulesResponse
         */
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

        /**
          * This topic provides an example on how to disable the `cr-5772ba41209e007b****` rule in the `ca-04b3fd170e340007****` account group.
          *
          * @param request DeactiveAggregateConfigRulesRequest
          * @return DeactiveAggregateConfigRulesResponse
         */
        public DeactiveAggregateConfigRulesResponse DeactiveAggregateConfigRules(DeactiveAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactiveAggregateConfigRulesWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to disable the `cr-5772ba41209e007b****` rule in the `ca-04b3fd170e340007****` account group.
          *
          * @param request DeactiveAggregateConfigRulesRequest
          * @return DeactiveAggregateConfigRulesResponse
         */
        public async Task<DeactiveAggregateConfigRulesResponse> DeactiveAggregateConfigRulesAsync(DeactiveAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactiveAggregateConfigRulesWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the `cr-19a56457e0d90058****` rule is used.
          *
          * @param request DeactiveConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeactiveConfigRulesResponse
         */
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

        /**
          * In this example, the `cr-19a56457e0d90058****` rule is used.
          *
          * @param request DeactiveConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeactiveConfigRulesResponse
         */
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

        /**
          * In this example, the `cr-19a56457e0d90058****` rule is used.
          *
          * @param request DeactiveConfigRulesRequest
          * @return DeactiveConfigRulesResponse
         */
        public DeactiveConfigRulesResponse DeactiveConfigRules(DeactiveConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactiveConfigRulesWithOptions(request, runtime);
        }

        /**
          * In this example, the `cr-19a56457e0d90058****` rule is used.
          *
          * @param request DeactiveConfigRulesRequest
          * @return DeactiveConfigRulesResponse
         */
        public async Task<DeactiveConfigRulesResponse> DeactiveConfigRulesAsync(DeactiveConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactiveConfigRulesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the `cp-541e626622af0087****` compliance package from the `ca-04b3fd170e340007****` account group.
          *
          * @param request DeleteAggregateCompliancePacksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAggregateCompliancePacksResponse
         */
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

        /**
          * This topic provides an example on how to delete the `cp-541e626622af0087****` compliance package from the `ca-04b3fd170e340007****` account group.
          *
          * @param request DeleteAggregateCompliancePacksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAggregateCompliancePacksResponse
         */
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

        /**
          * This topic provides an example on how to delete the `cp-541e626622af0087****` compliance package from the `ca-04b3fd170e340007****` account group.
          *
          * @param request DeleteAggregateCompliancePacksRequest
          * @return DeleteAggregateCompliancePacksResponse
         */
        public DeleteAggregateCompliancePacksResponse DeleteAggregateCompliancePacks(DeleteAggregateCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAggregateCompliancePacksWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the `cp-541e626622af0087****` compliance package from the `ca-04b3fd170e340007****` account group.
          *
          * @param request DeleteAggregateCompliancePacksRequest
          * @return DeleteAggregateCompliancePacksResponse
         */
        public async Task<DeleteAggregateCompliancePacksResponse> DeleteAggregateCompliancePacksAsync(DeleteAggregateCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAggregateCompliancePacksWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the `cdc-38c3013b46c9002c****` delivery channel from the `ca-23c6626622af0041****` account group. The returned result shows that the `cdc-38c3013b46c9002c****` delivery channel is deleted.
          *
          * @param request DeleteAggregateConfigDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAggregateConfigDeliveryChannelResponse
         */
        public DeleteAggregateConfigDeliveryChannelResponse DeleteAggregateConfigDeliveryChannelWithOptions(DeleteAggregateConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                query["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAggregateConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAggregateConfigDeliveryChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to delete the `cdc-38c3013b46c9002c****` delivery channel from the `ca-23c6626622af0041****` account group. The returned result shows that the `cdc-38c3013b46c9002c****` delivery channel is deleted.
          *
          * @param request DeleteAggregateConfigDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAggregateConfigDeliveryChannelResponse
         */
        public async Task<DeleteAggregateConfigDeliveryChannelResponse> DeleteAggregateConfigDeliveryChannelWithOptionsAsync(DeleteAggregateConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                query["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAggregateConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAggregateConfigDeliveryChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to delete the `cdc-38c3013b46c9002c****` delivery channel from the `ca-23c6626622af0041****` account group. The returned result shows that the `cdc-38c3013b46c9002c****` delivery channel is deleted.
          *
          * @param request DeleteAggregateConfigDeliveryChannelRequest
          * @return DeleteAggregateConfigDeliveryChannelResponse
         */
        public DeleteAggregateConfigDeliveryChannelResponse DeleteAggregateConfigDeliveryChannel(DeleteAggregateConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAggregateConfigDeliveryChannelWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the `cdc-38c3013b46c9002c****` delivery channel from the `ca-23c6626622af0041****` account group. The returned result shows that the `cdc-38c3013b46c9002c****` delivery channel is deleted.
          *
          * @param request DeleteAggregateConfigDeliveryChannelRequest
          * @return DeleteAggregateConfigDeliveryChannelResponse
         */
        public async Task<DeleteAggregateConfigDeliveryChannelResponse> DeleteAggregateConfigDeliveryChannelAsync(DeleteAggregateConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAggregateConfigDeliveryChannelWithOptionsAsync(request, runtime);
        }

        /**
          * ### Background information
          * You can delete a rule in the Cloud Config console. After you delete the rule, the configurations of the rule are deleted.
          * ### Usage notes
          * This topic provides an example on how to delete the `cr-4e3d626622af0080****` rule from the `ca-a4e5626622af0079****` account group.
          *
          * @param request DeleteAggregateConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAggregateConfigRulesResponse
         */
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

        /**
          * ### Background information
          * You can delete a rule in the Cloud Config console. After you delete the rule, the configurations of the rule are deleted.
          * ### Usage notes
          * This topic provides an example on how to delete the `cr-4e3d626622af0080****` rule from the `ca-a4e5626622af0079****` account group.
          *
          * @param request DeleteAggregateConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAggregateConfigRulesResponse
         */
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

        /**
          * ### Background information
          * You can delete a rule in the Cloud Config console. After you delete the rule, the configurations of the rule are deleted.
          * ### Usage notes
          * This topic provides an example on how to delete the `cr-4e3d626622af0080****` rule from the `ca-a4e5626622af0079****` account group.
          *
          * @param request DeleteAggregateConfigRulesRequest
          * @return DeleteAggregateConfigRulesResponse
         */
        public DeleteAggregateConfigRulesResponse DeleteAggregateConfigRules(DeleteAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAggregateConfigRulesWithOptions(request, runtime);
        }

        /**
          * ### Background information
          * You can delete a rule in the Cloud Config console. After you delete the rule, the configurations of the rule are deleted.
          * ### Usage notes
          * This topic provides an example on how to delete the `cr-4e3d626622af0080****` rule from the `ca-a4e5626622af0079****` account group.
          *
          * @param request DeleteAggregateConfigRulesRequest
          * @return DeleteAggregateConfigRulesResponse
         */
        public async Task<DeleteAggregateConfigRulesResponse> DeleteAggregateConfigRulesAsync(DeleteAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAggregateConfigRulesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the remediation template whose ID is `crr-909ba2d4716700eb****` from the account group whose ID is `ca-6b4a626622af0012****`. The returned result shows that the remediation template whose ID is `crr-909ba2d4716700eb****` is deleted.
          *
          * @param request DeleteAggregateRemediationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAggregateRemediationsResponse
         */
        public DeleteAggregateRemediationsResponse DeleteAggregateRemediationsWithOptions(DeleteAggregateRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationIds))
            {
                body["RemediationIds"] = request.RemediationIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAggregateRemediations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAggregateRemediationsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to delete the remediation template whose ID is `crr-909ba2d4716700eb****` from the account group whose ID is `ca-6b4a626622af0012****`. The returned result shows that the remediation template whose ID is `crr-909ba2d4716700eb****` is deleted.
          *
          * @param request DeleteAggregateRemediationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAggregateRemediationsResponse
         */
        public async Task<DeleteAggregateRemediationsResponse> DeleteAggregateRemediationsWithOptionsAsync(DeleteAggregateRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationIds))
            {
                body["RemediationIds"] = request.RemediationIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAggregateRemediations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAggregateRemediationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to delete the remediation template whose ID is `crr-909ba2d4716700eb****` from the account group whose ID is `ca-6b4a626622af0012****`. The returned result shows that the remediation template whose ID is `crr-909ba2d4716700eb****` is deleted.
          *
          * @param request DeleteAggregateRemediationsRequest
          * @return DeleteAggregateRemediationsResponse
         */
        public DeleteAggregateRemediationsResponse DeleteAggregateRemediations(DeleteAggregateRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAggregateRemediationsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the remediation template whose ID is `crr-909ba2d4716700eb****` from the account group whose ID is `ca-6b4a626622af0012****`. The returned result shows that the remediation template whose ID is `crr-909ba2d4716700eb****` is deleted.
          *
          * @param request DeleteAggregateRemediationsRequest
          * @return DeleteAggregateRemediationsResponse
         */
        public async Task<DeleteAggregateRemediationsResponse> DeleteAggregateRemediationsAsync(DeleteAggregateRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAggregateRemediationsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the account group whose ID is `ca-9190626622af00a9****`.
          *
          * @param request DeleteAggregatorsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAggregatorsResponse
         */
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

        /**
          * This topic provides an example on how to delete the account group whose ID is `ca-9190626622af00a9****`.
          *
          * @param request DeleteAggregatorsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAggregatorsResponse
         */
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

        /**
          * This topic provides an example on how to delete the account group whose ID is `ca-9190626622af00a9****`.
          *
          * @param request DeleteAggregatorsRequest
          * @return DeleteAggregatorsResponse
         */
        public DeleteAggregatorsResponse DeleteAggregators(DeleteAggregatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAggregatorsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the account group whose ID is `ca-9190626622af00a9****`.
          *
          * @param request DeleteAggregatorsRequest
          * @return DeleteAggregatorsResponse
         */
        public async Task<DeleteAggregatorsResponse> DeleteAggregatorsAsync(DeleteAggregatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAggregatorsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the `cp-541e626622af0087****` compliance package.
          *
          * @param request DeleteCompliancePacksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteCompliancePacksResponse
         */
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

        /**
          * This topic provides an example on how to delete the `cp-541e626622af0087****` compliance package.
          *
          * @param request DeleteCompliancePacksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteCompliancePacksResponse
         */
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

        /**
          * This topic provides an example on how to delete the `cp-541e626622af0087****` compliance package.
          *
          * @param request DeleteCompliancePacksRequest
          * @return DeleteCompliancePacksResponse
         */
        public DeleteCompliancePacksResponse DeleteCompliancePacks(DeleteCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCompliancePacksWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the `cp-541e626622af0087****` compliance package.
          *
          * @param request DeleteCompliancePacksRequest
          * @return DeleteCompliancePacksResponse
         */
        public async Task<DeleteCompliancePacksResponse> DeleteCompliancePacksAsync(DeleteCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCompliancePacksWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the `cdc-38c3013b46c9002c****` delivery channel. The returned result shows that the `cdc-38c3013b46c9002c****` delivery channel is deleted.
          *
          * @param request DeleteConfigDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteConfigDeliveryChannelResponse
         */
        public DeleteConfigDeliveryChannelResponse DeleteConfigDeliveryChannelWithOptions(DeleteConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                query["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigDeliveryChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to delete the `cdc-38c3013b46c9002c****` delivery channel. The returned result shows that the `cdc-38c3013b46c9002c****` delivery channel is deleted.
          *
          * @param request DeleteConfigDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteConfigDeliveryChannelResponse
         */
        public async Task<DeleteConfigDeliveryChannelResponse> DeleteConfigDeliveryChannelWithOptionsAsync(DeleteConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                query["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigDeliveryChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to delete the `cdc-38c3013b46c9002c****` delivery channel. The returned result shows that the `cdc-38c3013b46c9002c****` delivery channel is deleted.
          *
          * @param request DeleteConfigDeliveryChannelRequest
          * @return DeleteConfigDeliveryChannelResponse
         */
        public DeleteConfigDeliveryChannelResponse DeleteConfigDeliveryChannel(DeleteConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConfigDeliveryChannelWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the `cdc-38c3013b46c9002c****` delivery channel. The returned result shows that the `cdc-38c3013b46c9002c****` delivery channel is deleted.
          *
          * @param request DeleteConfigDeliveryChannelRequest
          * @return DeleteConfigDeliveryChannelResponse
         */
        public async Task<DeleteConfigDeliveryChannelResponse> DeleteConfigDeliveryChannelAsync(DeleteConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConfigDeliveryChannelWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the rule whose ID is cr-9908626622af0035\\*\\*\\*\\* is deleted.
          *
          * @param request DeleteConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteConfigRulesResponse
         */
        public DeleteConfigRulesResponse DeleteConfigRulesWithOptions(DeleteConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * In this example, the rule whose ID is cr-9908626622af0035\\*\\*\\*\\* is deleted.
          *
          * @param request DeleteConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteConfigRulesResponse
         */
        public async Task<DeleteConfigRulesResponse> DeleteConfigRulesWithOptionsAsync(DeleteConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * In this example, the rule whose ID is cr-9908626622af0035\\*\\*\\*\\* is deleted.
          *
          * @param request DeleteConfigRulesRequest
          * @return DeleteConfigRulesResponse
         */
        public DeleteConfigRulesResponse DeleteConfigRules(DeleteConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConfigRulesWithOptions(request, runtime);
        }

        /**
          * In this example, the rule whose ID is cr-9908626622af0035\\*\\*\\*\\* is deleted.
          *
          * @param request DeleteConfigRulesRequest
          * @return DeleteConfigRulesResponse
         */
        public async Task<DeleteConfigRulesResponse> DeleteConfigRulesAsync(DeleteConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConfigRulesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the remediation template `crr-909ba2d4716700eb****`. The returned result shows that the remediation template whose ID is `crr-909ba2d4716700eb****` is deleted.
          *
          * @param request DeleteRemediationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteRemediationsResponse
         */
        public DeleteRemediationsResponse DeleteRemediationsWithOptions(DeleteRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationIds))
            {
                body["RemediationIds"] = request.RemediationIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRemediations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRemediationsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to delete the remediation template `crr-909ba2d4716700eb****`. The returned result shows that the remediation template whose ID is `crr-909ba2d4716700eb****` is deleted.
          *
          * @param request DeleteRemediationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteRemediationsResponse
         */
        public async Task<DeleteRemediationsResponse> DeleteRemediationsWithOptionsAsync(DeleteRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationIds))
            {
                body["RemediationIds"] = request.RemediationIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRemediations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRemediationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to delete the remediation template `crr-909ba2d4716700eb****`. The returned result shows that the remediation template whose ID is `crr-909ba2d4716700eb****` is deleted.
          *
          * @param request DeleteRemediationsRequest
          * @return DeleteRemediationsResponse
         */
        public DeleteRemediationsResponse DeleteRemediations(DeleteRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRemediationsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to delete the remediation template `crr-909ba2d4716700eb****`. The returned result shows that the remediation template whose ID is `crr-909ba2d4716700eb****` is deleted.
          *
          * @param request DeleteRemediationsRequest
          * @return DeleteRemediationsResponse
         */
        public async Task<DeleteRemediationsResponse> DeleteRemediationsAsync(DeleteRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRemediationsWithOptionsAsync(request, runtime);
        }

        public DescribeRemediationResponse DescribeRemediationWithOptions(DescribeRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRemediationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRemediationResponse> DescribeRemediationWithOptionsAsync(DescribeRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRemediationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRemediationResponse DescribeRemediation(DescribeRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRemediationWithOptions(request, runtime);
        }

        public async Task<DescribeRemediationResponse> DescribeRemediationAsync(DescribeRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRemediationWithOptionsAsync(request, runtime);
        }

        /**
          * ### Prerequisites
          * One or more rules are added to a compliance package.
          * ### Usage notes
          * The sample request in this topic shows you how to remove the `cr-6cc4626622af00e7****` rule in the `ca-75b4626622af00c3****` account group from the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request DetachAggregateConfigRuleToCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DetachAggregateConfigRuleToCompliancePackResponse
         */
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

        /**
          * ### Prerequisites
          * One or more rules are added to a compliance package.
          * ### Usage notes
          * The sample request in this topic shows you how to remove the `cr-6cc4626622af00e7****` rule in the `ca-75b4626622af00c3****` account group from the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request DetachAggregateConfigRuleToCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DetachAggregateConfigRuleToCompliancePackResponse
         */
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

        /**
          * ### Prerequisites
          * One or more rules are added to a compliance package.
          * ### Usage notes
          * The sample request in this topic shows you how to remove the `cr-6cc4626622af00e7****` rule in the `ca-75b4626622af00c3****` account group from the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request DetachAggregateConfigRuleToCompliancePackRequest
          * @return DetachAggregateConfigRuleToCompliancePackResponse
         */
        public DetachAggregateConfigRuleToCompliancePackResponse DetachAggregateConfigRuleToCompliancePack(DetachAggregateConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachAggregateConfigRuleToCompliancePackWithOptions(request, runtime);
        }

        /**
          * ### Prerequisites
          * One or more rules are added to a compliance package.
          * ### Usage notes
          * The sample request in this topic shows you how to remove the `cr-6cc4626622af00e7****` rule in the `ca-75b4626622af00c3****` account group from the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request DetachAggregateConfigRuleToCompliancePackRequest
          * @return DetachAggregateConfigRuleToCompliancePackResponse
         */
        public async Task<DetachAggregateConfigRuleToCompliancePackResponse> DetachAggregateConfigRuleToCompliancePackAsync(DetachAggregateConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachAggregateConfigRuleToCompliancePackWithOptionsAsync(request, runtime);
        }

        /**
          * ### Prerequisites
          * One or more rules are added to a compliance package.
          * ### Usage notes
          * This topic provides an example on how to remove the `cr-6cc4626622af00e7****` rule from the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request DetachConfigRuleToCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DetachConfigRuleToCompliancePackResponse
         */
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

        /**
          * ### Prerequisites
          * One or more rules are added to a compliance package.
          * ### Usage notes
          * This topic provides an example on how to remove the `cr-6cc4626622af00e7****` rule from the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request DetachConfigRuleToCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DetachConfigRuleToCompliancePackResponse
         */
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

        /**
          * ### Prerequisites
          * One or more rules are added to a compliance package.
          * ### Usage notes
          * This topic provides an example on how to remove the `cr-6cc4626622af00e7****` rule from the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request DetachConfigRuleToCompliancePackRequest
          * @return DetachConfigRuleToCompliancePackResponse
         */
        public DetachConfigRuleToCompliancePackResponse DetachConfigRuleToCompliancePack(DetachConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachConfigRuleToCompliancePackWithOptions(request, runtime);
        }

        /**
          * ### Prerequisites
          * One or more rules are added to a compliance package.
          * ### Usage notes
          * This topic provides an example on how to remove the `cr-6cc4626622af00e7****` rule from the `cp-5bb1626622af00bd****` compliance package.
          *
          * @param request DetachConfigRuleToCompliancePackRequest
          * @return DetachConfigRuleToCompliancePackResponse
         */
        public async Task<DetachConfigRuleToCompliancePackResponse> DetachConfigRuleToCompliancePackAsync(DetachConfigRuleToCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachConfigRuleToCompliancePackWithOptionsAsync(request, runtime);
        }

        public EvaluatePreConfigRulesResponse EvaluatePreConfigRulesWithOptions(EvaluatePreConfigRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EvaluatePreConfigRulesShrinkRequest request = new EvaluatePreConfigRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceEvaluateItems))
            {
                request.ResourceEvaluateItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceEvaluateItems, "ResourceEvaluateItems", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableManagedRules))
            {
                body["EnableManagedRules"] = request.EnableManagedRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceEvaluateItemsShrink))
            {
                body["ResourceEvaluateItems"] = request.ResourceEvaluateItemsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EvaluatePreConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvaluatePreConfigRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EvaluatePreConfigRulesResponse> EvaluatePreConfigRulesWithOptionsAsync(EvaluatePreConfigRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EvaluatePreConfigRulesShrinkRequest request = new EvaluatePreConfigRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceEvaluateItems))
            {
                request.ResourceEvaluateItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceEvaluateItems, "ResourceEvaluateItems", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableManagedRules))
            {
                body["EnableManagedRules"] = request.EnableManagedRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceEvaluateItemsShrink))
            {
                body["ResourceEvaluateItems"] = request.ResourceEvaluateItemsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EvaluatePreConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvaluatePreConfigRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EvaluatePreConfigRulesResponse EvaluatePreConfigRules(EvaluatePreConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EvaluatePreConfigRulesWithOptions(request, runtime);
        }

        public async Task<EvaluatePreConfigRulesResponse> EvaluatePreConfigRulesAsync(EvaluatePreConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EvaluatePreConfigRulesWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetAggregateConfigRulesReport operation. For more information, see [GetAggregateCompliancePackReport](~~262699~~).
          * This topic provides an example on how to generate a compliance evaluation report based on the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****` account group.
          *
          * @param request GenerateAggregateCompliancePackReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateAggregateCompliancePackReportResponse
         */
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

        /**
          * > You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetAggregateConfigRulesReport operation. For more information, see [GetAggregateCompliancePackReport](~~262699~~).
          * This topic provides an example on how to generate a compliance evaluation report based on the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****` account group.
          *
          * @param request GenerateAggregateCompliancePackReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateAggregateCompliancePackReportResponse
         */
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

        /**
          * > You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetAggregateConfigRulesReport operation. For more information, see [GetAggregateCompliancePackReport](~~262699~~).
          * This topic provides an example on how to generate a compliance evaluation report based on the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****` account group.
          *
          * @param request GenerateAggregateCompliancePackReportRequest
          * @return GenerateAggregateCompliancePackReportResponse
         */
        public GenerateAggregateCompliancePackReportResponse GenerateAggregateCompliancePackReport(GenerateAggregateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAggregateCompliancePackReportWithOptions(request, runtime);
        }

        /**
          * > You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetAggregateConfigRulesReport operation. For more information, see [GetAggregateCompliancePackReport](~~262699~~).
          * This topic provides an example on how to generate a compliance evaluation report based on the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****` account group.
          *
          * @param request GenerateAggregateCompliancePackReportRequest
          * @return GenerateAggregateCompliancePackReportResponse
         */
        public async Task<GenerateAggregateCompliancePackReportResponse> GenerateAggregateCompliancePackReportAsync(GenerateAggregateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAggregateCompliancePackReportWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetAggregateConfigRulesReport operation. For more information, see [GetAggregateConfigRulesReport](~~262706~~).
          * The topic provides an example on how to generate a compliance evaluation report based on all rules in the `ca-f632626622af0079****` account group.
          *
          * @param request GenerateAggregateConfigRulesReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateAggregateConfigRulesReportResponse
         */
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

        /**
          * > You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetAggregateConfigRulesReport operation. For more information, see [GetAggregateConfigRulesReport](~~262706~~).
          * The topic provides an example on how to generate a compliance evaluation report based on all rules in the `ca-f632626622af0079****` account group.
          *
          * @param request GenerateAggregateConfigRulesReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateAggregateConfigRulesReportResponse
         */
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

        /**
          * > You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetAggregateConfigRulesReport operation. For more information, see [GetAggregateConfigRulesReport](~~262706~~).
          * The topic provides an example on how to generate a compliance evaluation report based on all rules in the `ca-f632626622af0079****` account group.
          *
          * @param request GenerateAggregateConfigRulesReportRequest
          * @return GenerateAggregateConfigRulesReportResponse
         */
        public GenerateAggregateConfigRulesReportResponse GenerateAggregateConfigRulesReport(GenerateAggregateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAggregateConfigRulesReportWithOptions(request, runtime);
        }

        /**
          * > You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetAggregateConfigRulesReport operation. For more information, see [GetAggregateConfigRulesReport](~~262706~~).
          * The topic provides an example on how to generate a compliance evaluation report based on all rules in the `ca-f632626622af0079****` account group.
          *
          * @param request GenerateAggregateConfigRulesReportRequest
          * @return GenerateAggregateConfigRulesReportResponse
         */
        public async Task<GenerateAggregateConfigRulesReportResponse> GenerateAggregateConfigRulesReportAsync(GenerateAggregateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAggregateConfigRulesReportWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example to show how to generate a downloadable inventory for global resources in the account group ca-a91d626622af0035\\*\\*\\*\\*.
          *
          * @param request GenerateAggregateResourceInventoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateAggregateResourceInventoryResponse
         */
        public GenerateAggregateResourceInventoryResponse GenerateAggregateResourceInventoryWithOptions(GenerateAggregateResourceInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAggregateResourceInventory",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateAggregateResourceInventoryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to generate a downloadable inventory for global resources in the account group ca-a91d626622af0035\\*\\*\\*\\*.
          *
          * @param request GenerateAggregateResourceInventoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateAggregateResourceInventoryResponse
         */
        public async Task<GenerateAggregateResourceInventoryResponse> GenerateAggregateResourceInventoryWithOptionsAsync(GenerateAggregateResourceInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAggregateResourceInventory",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateAggregateResourceInventoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to generate a downloadable inventory for global resources in the account group ca-a91d626622af0035\\*\\*\\*\\*.
          *
          * @param request GenerateAggregateResourceInventoryRequest
          * @return GenerateAggregateResourceInventoryResponse
         */
        public GenerateAggregateResourceInventoryResponse GenerateAggregateResourceInventory(GenerateAggregateResourceInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAggregateResourceInventoryWithOptions(request, runtime);
        }

        /**
          * This topic provides an example to show how to generate a downloadable inventory for global resources in the account group ca-a91d626622af0035\\*\\*\\*\\*.
          *
          * @param request GenerateAggregateResourceInventoryRequest
          * @return GenerateAggregateResourceInventoryResponse
         */
        public async Task<GenerateAggregateResourceInventoryResponse> GenerateAggregateResourceInventoryAsync(GenerateAggregateResourceInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAggregateResourceInventoryWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetCompliancePackReport operation. For more information, see [GetCompliancePackReport](~~263347~~).
          * This topic provides an example on how to generate a compliance evaluation report based on the `cp-a8a8626622af0082****` compliance package.
          *
          * @param request GenerateCompliancePackReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateCompliancePackReportResponse
         */
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

        /**
          * > You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetCompliancePackReport operation. For more information, see [GetCompliancePackReport](~~263347~~).
          * This topic provides an example on how to generate a compliance evaluation report based on the `cp-a8a8626622af0082****` compliance package.
          *
          * @param request GenerateCompliancePackReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateCompliancePackReportResponse
         */
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

        /**
          * > You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetCompliancePackReport operation. For more information, see [GetCompliancePackReport](~~263347~~).
          * This topic provides an example on how to generate a compliance evaluation report based on the `cp-a8a8626622af0082****` compliance package.
          *
          * @param request GenerateCompliancePackReportRequest
          * @return GenerateCompliancePackReportResponse
         */
        public GenerateCompliancePackReportResponse GenerateCompliancePackReport(GenerateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateCompliancePackReportWithOptions(request, runtime);
        }

        /**
          * > You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetCompliancePackReport operation. For more information, see [GetCompliancePackReport](~~263347~~).
          * This topic provides an example on how to generate a compliance evaluation report based on the `cp-a8a8626622af0082****` compliance package.
          *
          * @param request GenerateCompliancePackReportRequest
          * @return GenerateCompliancePackReportResponse
         */
        public async Task<GenerateCompliancePackReportResponse> GenerateCompliancePackReportAsync(GenerateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateCompliancePackReportWithOptionsAsync(request, runtime);
        }

        /**
          * >  You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetConfigRulesReport operation. For more information, see [GetConfigRulesReport](~~263608~~).
          * This topic provides an example of how to generate a compliance evaluation report based on all existing rules.
          *
          * @param request GenerateConfigRulesReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateConfigRulesReportResponse
         */
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

        /**
          * >  You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetConfigRulesReport operation. For more information, see [GetConfigRulesReport](~~263608~~).
          * This topic provides an example of how to generate a compliance evaluation report based on all existing rules.
          *
          * @param request GenerateConfigRulesReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateConfigRulesReportResponse
         */
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

        /**
          * >  You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetConfigRulesReport operation. For more information, see [GetConfigRulesReport](~~263608~~).
          * This topic provides an example of how to generate a compliance evaluation report based on all existing rules.
          *
          * @param request GenerateConfigRulesReportRequest
          * @return GenerateConfigRulesReportResponse
         */
        public GenerateConfigRulesReportResponse GenerateConfigRulesReport(GenerateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateConfigRulesReportWithOptions(request, runtime);
        }

        /**
          * >  You can call this operation to generate the latest compliance evaluation report. To download the report, call the GetConfigRulesReport operation. For more information, see [GetConfigRulesReport](~~263608~~).
          * This topic provides an example of how to generate a compliance evaluation report based on all existing rules.
          *
          * @param request GenerateConfigRulesReportRequest
          * @return GenerateConfigRulesReportResponse
         */
        public async Task<GenerateConfigRulesReportResponse> GenerateConfigRulesReportAsync(GenerateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateConfigRulesReportWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to generate a resource inventory for global resources of the current account.
          *
          * @param request GenerateResourceInventoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateResourceInventoryResponse
         */
        public GenerateResourceInventoryResponse GenerateResourceInventoryWithOptions(GenerateResourceInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateResourceInventory",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateResourceInventoryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to generate a resource inventory for global resources of the current account.
          *
          * @param request GenerateResourceInventoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateResourceInventoryResponse
         */
        public async Task<GenerateResourceInventoryResponse> GenerateResourceInventoryWithOptionsAsync(GenerateResourceInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateResourceInventory",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateResourceInventoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to generate a resource inventory for global resources of the current account.
          *
          * @param request GenerateResourceInventoryRequest
          * @return GenerateResourceInventoryResponse
         */
        public GenerateResourceInventoryResponse GenerateResourceInventory(GenerateResourceInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateResourceInventoryWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to generate a resource inventory for global resources of the current account.
          *
          * @param request GenerateResourceInventoryRequest
          * @return GenerateResourceInventoryResponse
         */
        public async Task<GenerateResourceInventoryResponse> GenerateResourceInventoryAsync(GenerateResourceInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateResourceInventoryWithOptionsAsync(request, runtime);
        }

        public GetAdvancedSearchFileResponse GetAdvancedSearchFileWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdvancedSearchFile",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdvancedSearchFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAdvancedSearchFileResponse> GetAdvancedSearchFileWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdvancedSearchFile",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdvancedSearchFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAdvancedSearchFileResponse GetAdvancedSearchFile()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAdvancedSearchFileWithOptions(runtime);
        }

        public async Task<GetAdvancedSearchFileResponse> GetAdvancedSearchFileAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAdvancedSearchFileWithOptionsAsync(runtime);
        }

        /**
          * This topic provides an example on how to query the compliance evaluation results of member accounts for which the `cp-541e626622af0087****` compliance package takes effect in the `ca-04b3fd170e340007****` account group. The returned result shows that two member accounts are monitored by the compliance package and they are both evaluated as compliant.
          *
          * @param request GetAggregateAccountComplianceByPackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateAccountComplianceByPackResponse
         */
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

        /**
          * This topic provides an example on how to query the compliance evaluation results of member accounts for which the `cp-541e626622af0087****` compliance package takes effect in the `ca-04b3fd170e340007****` account group. The returned result shows that two member accounts are monitored by the compliance package and they are both evaluated as compliant.
          *
          * @param request GetAggregateAccountComplianceByPackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateAccountComplianceByPackResponse
         */
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

        /**
          * This topic provides an example on how to query the compliance evaluation results of member accounts for which the `cp-541e626622af0087****` compliance package takes effect in the `ca-04b3fd170e340007****` account group. The returned result shows that two member accounts are monitored by the compliance package and they are both evaluated as compliant.
          *
          * @param request GetAggregateAccountComplianceByPackRequest
          * @return GetAggregateAccountComplianceByPackResponse
         */
        public GetAggregateAccountComplianceByPackResponse GetAggregateAccountComplianceByPack(GetAggregateAccountComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateAccountComplianceByPackWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance evaluation results of member accounts for which the `cp-541e626622af0087****` compliance package takes effect in the `ca-04b3fd170e340007****` account group. The returned result shows that two member accounts are monitored by the compliance package and they are both evaluated as compliant.
          *
          * @param request GetAggregateAccountComplianceByPackRequest
          * @return GetAggregateAccountComplianceByPackResponse
         */
        public async Task<GetAggregateAccountComplianceByPackResponse> GetAggregateAccountComplianceByPackAsync(GetAggregateAccountComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateAccountComplianceByPackWithOptionsAsync(request, runtime);
        }

        public GetAggregateAdvancedSearchFileResponse GetAggregateAdvancedSearchFileWithOptions(GetAggregateAdvancedSearchFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateAdvancedSearchFile",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateAdvancedSearchFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateAdvancedSearchFileResponse> GetAggregateAdvancedSearchFileWithOptionsAsync(GetAggregateAdvancedSearchFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateAdvancedSearchFile",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateAdvancedSearchFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateAdvancedSearchFileResponse GetAggregateAdvancedSearchFile(GetAggregateAdvancedSearchFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateAdvancedSearchFileWithOptions(request, runtime);
        }

        public async Task<GetAggregateAdvancedSearchFileResponse> GetAggregateAdvancedSearchFileAsync(GetAggregateAdvancedSearchFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateAdvancedSearchFileWithOptionsAsync(request, runtime);
        }

        /**
          * The topic provides an example on how to query the details of a compliance package whose ID is `cp-fdc8626622af00f9****` in an account group whose ID is `ca-f632626622af0079****`.
          *
          * @param request GetAggregateCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateCompliancePackResponse
         */
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

        /**
          * The topic provides an example on how to query the details of a compliance package whose ID is `cp-fdc8626622af00f9****` in an account group whose ID is `ca-f632626622af0079****`.
          *
          * @param request GetAggregateCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateCompliancePackResponse
         */
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

        /**
          * The topic provides an example on how to query the details of a compliance package whose ID is `cp-fdc8626622af00f9****` in an account group whose ID is `ca-f632626622af0079****`.
          *
          * @param request GetAggregateCompliancePackRequest
          * @return GetAggregateCompliancePackResponse
         */
        public GetAggregateCompliancePackResponse GetAggregateCompliancePack(GetAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateCompliancePackWithOptions(request, runtime);
        }

        /**
          * The topic provides an example on how to query the details of a compliance package whose ID is `cp-fdc8626622af00f9****` in an account group whose ID is `ca-f632626622af0079****`.
          *
          * @param request GetAggregateCompliancePackRequest
          * @return GetAggregateCompliancePackResponse
         */
        public async Task<GetAggregateCompliancePackResponse> GetAggregateCompliancePackAsync(GetAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateCompliancePackWithOptionsAsync(request, runtime);
        }

        /**
          * > Before you call this operation, you must call the GenerateAggregateCompliancePackReport operation to generate the latest compliance evaluation report based on a compliance package. For more information, see [GenerateAggregateCompliancePackReport](~~262687~~).
          * This topic provides an example on how to query the compliance evaluation report that is generated based on the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****` account group.
          *
          * @param request GetAggregateCompliancePackReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateCompliancePackReportResponse
         */
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

        /**
          * > Before you call this operation, you must call the GenerateAggregateCompliancePackReport operation to generate the latest compliance evaluation report based on a compliance package. For more information, see [GenerateAggregateCompliancePackReport](~~262687~~).
          * This topic provides an example on how to query the compliance evaluation report that is generated based on the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****` account group.
          *
          * @param request GetAggregateCompliancePackReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateCompliancePackReportResponse
         */
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

        /**
          * > Before you call this operation, you must call the GenerateAggregateCompliancePackReport operation to generate the latest compliance evaluation report based on a compliance package. For more information, see [GenerateAggregateCompliancePackReport](~~262687~~).
          * This topic provides an example on how to query the compliance evaluation report that is generated based on the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****` account group.
          *
          * @param request GetAggregateCompliancePackReportRequest
          * @return GetAggregateCompliancePackReportResponse
         */
        public GetAggregateCompliancePackReportResponse GetAggregateCompliancePackReport(GetAggregateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateCompliancePackReportWithOptions(request, runtime);
        }

        /**
          * > Before you call this operation, you must call the GenerateAggregateCompliancePackReport operation to generate the latest compliance evaluation report based on a compliance package. For more information, see [GenerateAggregateCompliancePackReport](~~262687~~).
          * This topic provides an example on how to query the compliance evaluation report that is generated based on the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****` account group.
          *
          * @param request GetAggregateCompliancePackReportRequest
          * @return GetAggregateCompliancePackReportResponse
         */
        public async Task<GetAggregateCompliancePackReportResponse> GetAggregateCompliancePackReportAsync(GetAggregateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateCompliancePackReportWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance statistics of resources and rules in the account group ca-a91d626622af0035\\*\\*\\*\\*.
          *
          * @param request GetAggregateComplianceSummaryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateComplianceSummaryResponse
         */
        public GetAggregateComplianceSummaryResponse GetAggregateComplianceSummaryWithOptions(GetAggregateComplianceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateComplianceSummary",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateComplianceSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the compliance statistics of resources and rules in the account group ca-a91d626622af0035\\*\\*\\*\\*.
          *
          * @param request GetAggregateComplianceSummaryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateComplianceSummaryResponse
         */
        public async Task<GetAggregateComplianceSummaryResponse> GetAggregateComplianceSummaryWithOptionsAsync(GetAggregateComplianceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateComplianceSummary",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateComplianceSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the compliance statistics of resources and rules in the account group ca-a91d626622af0035\\*\\*\\*\\*.
          *
          * @param request GetAggregateComplianceSummaryRequest
          * @return GetAggregateComplianceSummaryResponse
         */
        public GetAggregateComplianceSummaryResponse GetAggregateComplianceSummary(GetAggregateComplianceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateComplianceSummaryWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance statistics of resources and rules in the account group ca-a91d626622af0035\\*\\*\\*\\*.
          *
          * @param request GetAggregateComplianceSummaryRequest
          * @return GetAggregateComplianceSummaryResponse
         */
        public async Task<GetAggregateComplianceSummaryResponse> GetAggregateComplianceSummaryAsync(GetAggregateComplianceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateComplianceSummaryWithOptionsAsync(request, runtime);
        }

        public GetAggregateConfigDeliveryChannelResponse GetAggregateConfigDeliveryChannelWithOptions(GetAggregateConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                query["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateConfigDeliveryChannelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAggregateConfigDeliveryChannelResponse> GetAggregateConfigDeliveryChannelWithOptionsAsync(GetAggregateConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                query["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateConfigDeliveryChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAggregateConfigDeliveryChannelResponse GetAggregateConfigDeliveryChannel(GetAggregateConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateConfigDeliveryChannelWithOptions(request, runtime);
        }

        public async Task<GetAggregateConfigDeliveryChannelResponse> GetAggregateConfigDeliveryChannelAsync(GetAggregateConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateConfigDeliveryChannelWithOptionsAsync(request, runtime);
        }

        /**
          * This example shows how to query the details of the `cr-7f7d626622af0041****` rule in the `ca-7f00626622af0041****` account group.
          *
          * @param request GetAggregateConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateConfigRuleResponse
         */
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

        /**
          * This example shows how to query the details of the `cr-7f7d626622af0041****` rule in the `ca-7f00626622af0041****` account group.
          *
          * @param request GetAggregateConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateConfigRuleResponse
         */
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

        /**
          * This example shows how to query the details of the `cr-7f7d626622af0041****` rule in the `ca-7f00626622af0041****` account group.
          *
          * @param request GetAggregateConfigRuleRequest
          * @return GetAggregateConfigRuleResponse
         */
        public GetAggregateConfigRuleResponse GetAggregateConfigRule(GetAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateConfigRuleWithOptions(request, runtime);
        }

        /**
          * This example shows how to query the details of the `cr-7f7d626622af0041****` rule in the `ca-7f00626622af0041****` account group.
          *
          * @param request GetAggregateConfigRuleRequest
          * @return GetAggregateConfigRuleResponse
         */
        public async Task<GetAggregateConfigRuleResponse> GetAggregateConfigRuleAsync(GetAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateConfigRuleWithOptionsAsync(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to query the compliance evaluation results based on rules in the `cp-541e626622af0087****` compliance package that is created for the `ca-04b3fd170e340007****` account group. The return result shows a total of `one` rule. `No resources` are evaluated as non-compliant based on the rule.
          *
          * @param request GetAggregateConfigRuleComplianceByPackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateConfigRuleComplianceByPackResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the compliance evaluation results based on rules in the `cp-541e626622af0087****` compliance package that is created for the `ca-04b3fd170e340007****` account group. The return result shows a total of `one` rule. `No resources` are evaluated as non-compliant based on the rule.
          *
          * @param request GetAggregateConfigRuleComplianceByPackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateConfigRuleComplianceByPackResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the compliance evaluation results based on rules in the `cp-541e626622af0087****` compliance package that is created for the `ca-04b3fd170e340007****` account group. The return result shows a total of `one` rule. `No resources` are evaluated as non-compliant based on the rule.
          *
          * @param request GetAggregateConfigRuleComplianceByPackRequest
          * @return GetAggregateConfigRuleComplianceByPackResponse
         */
        public GetAggregateConfigRuleComplianceByPackResponse GetAggregateConfigRuleComplianceByPack(GetAggregateConfigRuleComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateConfigRuleComplianceByPackWithOptions(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to query the compliance evaluation results based on rules in the `cp-541e626622af0087****` compliance package that is created for the `ca-04b3fd170e340007****` account group. The return result shows a total of `one` rule. `No resources` are evaluated as non-compliant based on the rule.
          *
          * @param request GetAggregateConfigRuleComplianceByPackRequest
          * @return GetAggregateConfigRuleComplianceByPackResponse
         */
        public async Task<GetAggregateConfigRuleComplianceByPackResponse> GetAggregateConfigRuleComplianceByPackAsync(GetAggregateConfigRuleComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateConfigRuleComplianceByPackWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the summary of compliance evaluation results by rule risk level in the `ca-3a58626622af0005****` account group. The returned result shows four rules that are specified with the high risk level. One of the rules detects non-compliant resources, and the resources evaluated by the remaining three are compliant.
          *
          * @param request GetAggregateConfigRuleSummaryByRiskLevelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateConfigRuleSummaryByRiskLevelResponse
         */
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

        /**
          * This topic provides an example on how to query the summary of compliance evaluation results by rule risk level in the `ca-3a58626622af0005****` account group. The returned result shows four rules that are specified with the high risk level. One of the rules detects non-compliant resources, and the resources evaluated by the remaining three are compliant.
          *
          * @param request GetAggregateConfigRuleSummaryByRiskLevelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateConfigRuleSummaryByRiskLevelResponse
         */
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

        /**
          * This topic provides an example on how to query the summary of compliance evaluation results by rule risk level in the `ca-3a58626622af0005****` account group. The returned result shows four rules that are specified with the high risk level. One of the rules detects non-compliant resources, and the resources evaluated by the remaining three are compliant.
          *
          * @param request GetAggregateConfigRuleSummaryByRiskLevelRequest
          * @return GetAggregateConfigRuleSummaryByRiskLevelResponse
         */
        public GetAggregateConfigRuleSummaryByRiskLevelResponse GetAggregateConfigRuleSummaryByRiskLevel(GetAggregateConfigRuleSummaryByRiskLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateConfigRuleSummaryByRiskLevelWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the summary of compliance evaluation results by rule risk level in the `ca-3a58626622af0005****` account group. The returned result shows four rules that are specified with the high risk level. One of the rules detects non-compliant resources, and the resources evaluated by the remaining three are compliant.
          *
          * @param request GetAggregateConfigRuleSummaryByRiskLevelRequest
          * @return GetAggregateConfigRuleSummaryByRiskLevelResponse
         */
        public async Task<GetAggregateConfigRuleSummaryByRiskLevelResponse> GetAggregateConfigRuleSummaryByRiskLevelAsync(GetAggregateConfigRuleSummaryByRiskLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateConfigRuleSummaryByRiskLevelWithOptionsAsync(request, runtime);
        }

        /**
          * > Before you call this operation, you must call the GenerateAggregateConfigRulesReport operation to generate the latest compliance evaluation report based on all rules in an account group. For more information, see [GenerateAggregateConfigRulesReport](~~262701~~).
          * This topic provides an example on how to query the compliance evaluation report that is generated based on all rules in the `ca-f632626622af0079****` account group.
          *
          * @param request GetAggregateConfigRulesReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateConfigRulesReportResponse
         */
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

        /**
          * > Before you call this operation, you must call the GenerateAggregateConfigRulesReport operation to generate the latest compliance evaluation report based on all rules in an account group. For more information, see [GenerateAggregateConfigRulesReport](~~262701~~).
          * This topic provides an example on how to query the compliance evaluation report that is generated based on all rules in the `ca-f632626622af0079****` account group.
          *
          * @param request GetAggregateConfigRulesReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateConfigRulesReportResponse
         */
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

        /**
          * > Before you call this operation, you must call the GenerateAggregateConfigRulesReport operation to generate the latest compliance evaluation report based on all rules in an account group. For more information, see [GenerateAggregateConfigRulesReport](~~262701~~).
          * This topic provides an example on how to query the compliance evaluation report that is generated based on all rules in the `ca-f632626622af0079****` account group.
          *
          * @param request GetAggregateConfigRulesReportRequest
          * @return GetAggregateConfigRulesReportResponse
         */
        public GetAggregateConfigRulesReportResponse GetAggregateConfigRulesReport(GetAggregateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateConfigRulesReportWithOptions(request, runtime);
        }

        /**
          * > Before you call this operation, you must call the GenerateAggregateConfigRulesReport operation to generate the latest compliance evaluation report based on all rules in an account group. For more information, see [GenerateAggregateConfigRulesReport](~~262701~~).
          * This topic provides an example on how to query the compliance evaluation report that is generated based on all rules in the `ca-f632626622af0079****` account group.
          *
          * @param request GetAggregateConfigRulesReportRequest
          * @return GetAggregateConfigRulesReportResponse
         */
        public async Task<GetAggregateConfigRulesReportResponse> GetAggregateConfigRulesReportAsync(GetAggregateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateConfigRulesReportWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the `new-bucket` resource in the `ca-5885626622af0008****` account group.
          *
          * @param request GetAggregateDiscoveredResourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateDiscoveredResourceResponse
         */
        public GetAggregateDiscoveredResourceResponse GetAggregateDiscoveredResourceWithOptions(GetAggregateDiscoveredResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateDiscoveredResource",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateDiscoveredResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the `new-bucket` resource in the `ca-5885626622af0008****` account group.
          *
          * @param request GetAggregateDiscoveredResourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateDiscoveredResourceResponse
         */
        public async Task<GetAggregateDiscoveredResourceResponse> GetAggregateDiscoveredResourceWithOptionsAsync(GetAggregateDiscoveredResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateDiscoveredResource",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateDiscoveredResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the `new-bucket` resource in the `ca-5885626622af0008****` account group.
          *
          * @param request GetAggregateDiscoveredResourceRequest
          * @return GetAggregateDiscoveredResourceResponse
         */
        public GetAggregateDiscoveredResourceResponse GetAggregateDiscoveredResource(GetAggregateDiscoveredResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateDiscoveredResourceWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the `new-bucket` resource in the `ca-5885626622af0008****` account group.
          *
          * @param request GetAggregateDiscoveredResourceRequest
          * @return GetAggregateDiscoveredResourceResponse
         */
        public async Task<GetAggregateDiscoveredResourceResponse> GetAggregateDiscoveredResourceAsync(GetAggregateDiscoveredResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateDiscoveredResourceWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance evaluation results based on the `cr-d369626622af008e****` rule in the `ca-a4e5626622af0079****` account group. The returned result shows that a total of 10 resources are evaluated by the rule and five of them are evaluated as compliant.
          *
          * @param request GetAggregateResourceComplianceByConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceComplianceByConfigRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        /**
          * This topic provides an example on how to query the compliance evaluation results based on the `cr-d369626622af008e****` rule in the `ca-a4e5626622af0079****` account group. The returned result shows that a total of 10 resources are evaluated by the rule and five of them are evaluated as compliant.
          *
          * @param request GetAggregateResourceComplianceByConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceComplianceByConfigRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        /**
          * This topic provides an example on how to query the compliance evaluation results based on the `cr-d369626622af008e****` rule in the `ca-a4e5626622af0079****` account group. The returned result shows that a total of 10 resources are evaluated by the rule and five of them are evaluated as compliant.
          *
          * @param request GetAggregateResourceComplianceByConfigRuleRequest
          * @return GetAggregateResourceComplianceByConfigRuleResponse
         */
        public GetAggregateResourceComplianceByConfigRuleResponse GetAggregateResourceComplianceByConfigRule(GetAggregateResourceComplianceByConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceComplianceByConfigRuleWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance evaluation results based on the `cr-d369626622af008e****` rule in the `ca-a4e5626622af0079****` account group. The returned result shows that a total of 10 resources are evaluated by the rule and five of them are evaluated as compliant.
          *
          * @param request GetAggregateResourceComplianceByConfigRuleRequest
          * @return GetAggregateResourceComplianceByConfigRuleResponse
         */
        public async Task<GetAggregateResourceComplianceByConfigRuleResponse> GetAggregateResourceComplianceByConfigRuleAsync(GetAggregateResourceComplianceByConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceComplianceByConfigRuleWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance evaluation results of resources monitored based on the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****`account group. The returned result shows that the total number of monitored resources is `10` and the number of non-compliant resources is `7`.
          *
          * @param request GetAggregateResourceComplianceByPackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceComplianceByPackResponse
         */
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

        /**
          * This topic provides an example on how to query the compliance evaluation results of resources monitored based on the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****`account group. The returned result shows that the total number of monitored resources is `10` and the number of non-compliant resources is `7`.
          *
          * @param request GetAggregateResourceComplianceByPackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceComplianceByPackResponse
         */
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

        /**
          * This topic provides an example on how to query the compliance evaluation results of resources monitored based on the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****`account group. The returned result shows that the total number of monitored resources is `10` and the number of non-compliant resources is `7`.
          *
          * @param request GetAggregateResourceComplianceByPackRequest
          * @return GetAggregateResourceComplianceByPackResponse
         */
        public GetAggregateResourceComplianceByPackResponse GetAggregateResourceComplianceByPack(GetAggregateResourceComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceComplianceByPackWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance evaluation results of resources monitored based on the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****`account group. The returned result shows that the total number of monitored resources is `10` and the number of non-compliant resources is `7`.
          *
          * @param request GetAggregateResourceComplianceByPackRequest
          * @return GetAggregateResourceComplianceByPackResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the compliance timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region within the `100931896542****` member account of the `ca-5885626622af0008****` account group. The new-bucket resource is an Object Storage Service (OSS) bucket. The return result shows the following two timestamps on the compliance timeline: `1625200295276` and `1625200228510`. The first timestamp indicates 12:31:35 on July 2, 2021 (UTC+8), and the second timestamp indicates 12:30:28 on July 2, 2021 (UTC+8).
          *
          * @param request GetAggregateResourceComplianceTimelineRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceComplianceTimelineResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the compliance timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region within the `100931896542****` member account of the `ca-5885626622af0008****` account group. The new-bucket resource is an Object Storage Service (OSS) bucket. The return result shows the following two timestamps on the compliance timeline: `1625200295276` and `1625200228510`. The first timestamp indicates 12:31:35 on July 2, 2021 (UTC+8), and the second timestamp indicates 12:30:28 on July 2, 2021 (UTC+8).
          *
          * @param request GetAggregateResourceComplianceTimelineRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceComplianceTimelineResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the compliance timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region within the `100931896542****` member account of the `ca-5885626622af0008****` account group. The new-bucket resource is an Object Storage Service (OSS) bucket. The return result shows the following two timestamps on the compliance timeline: `1625200295276` and `1625200228510`. The first timestamp indicates 12:31:35 on July 2, 2021 (UTC+8), and the second timestamp indicates 12:30:28 on July 2, 2021 (UTC+8).
          *
          * @param request GetAggregateResourceComplianceTimelineRequest
          * @return GetAggregateResourceComplianceTimelineResponse
         */
        public GetAggregateResourceComplianceTimelineResponse GetAggregateResourceComplianceTimeline(GetAggregateResourceComplianceTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceComplianceTimelineWithOptions(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to query the compliance timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region within the `100931896542****` member account of the `ca-5885626622af0008****` account group. The new-bucket resource is an Object Storage Service (OSS) bucket. The return result shows the following two timestamps on the compliance timeline: `1625200295276` and `1625200228510`. The first timestamp indicates 12:31:35 on July 2, 2021 (UTC+8), and the second timestamp indicates 12:30:28 on July 2, 2021 (UTC+8).
          *
          * @param request GetAggregateResourceComplianceTimelineRequest
          * @return GetAggregateResourceComplianceTimelineResponse
         */
        public async Task<GetAggregateResourceComplianceTimelineResponse> GetAggregateResourceComplianceTimelineAsync(GetAggregateResourceComplianceTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceComplianceTimelineWithOptionsAsync(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to query the configuration timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region within the `100931896542****` member account of the `ca-5885626622af0008****` account group. The new-bucket resource is an Object Storage Service (OSS) bucket. The return result shows that the timestamp when the resource configuration changes is `1624961112000`. The timestamp indicates 18:05:12 on June 29, 2021 (UTC+8).
          *
          * @param request GetAggregateResourceConfigurationTimelineRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceConfigurationTimelineResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the configuration timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region within the `100931896542****` member account of the `ca-5885626622af0008****` account group. The new-bucket resource is an Object Storage Service (OSS) bucket. The return result shows that the timestamp when the resource configuration changes is `1624961112000`. The timestamp indicates 18:05:12 on June 29, 2021 (UTC+8).
          *
          * @param request GetAggregateResourceConfigurationTimelineRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceConfigurationTimelineResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the configuration timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region within the `100931896542****` member account of the `ca-5885626622af0008****` account group. The new-bucket resource is an Object Storage Service (OSS) bucket. The return result shows that the timestamp when the resource configuration changes is `1624961112000`. The timestamp indicates 18:05:12 on June 29, 2021 (UTC+8).
          *
          * @param request GetAggregateResourceConfigurationTimelineRequest
          * @return GetAggregateResourceConfigurationTimelineResponse
         */
        public GetAggregateResourceConfigurationTimelineResponse GetAggregateResourceConfigurationTimeline(GetAggregateResourceConfigurationTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceConfigurationTimelineWithOptions(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to query the configuration timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region within the `100931896542****` member account of the `ca-5885626622af0008****` account group. The new-bucket resource is an Object Storage Service (OSS) bucket. The return result shows that the timestamp when the resource configuration changes is `1624961112000`. The timestamp indicates 18:05:12 on June 29, 2021 (UTC+8).
          *
          * @param request GetAggregateResourceConfigurationTimelineRequest
          * @return GetAggregateResourceConfigurationTimelineResponse
         */
        public async Task<GetAggregateResourceConfigurationTimelineResponse> GetAggregateResourceConfigurationTimelineAsync(GetAggregateResourceConfigurationTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceConfigurationTimelineWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the statistics on the resources in an account group named `ca-a260626622af0005****` by region. The returned result shows that a total of `10` resources exist in the `cn-hangzhou` region.
          *
          * @param request GetAggregateResourceCountsGroupByRegionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceCountsGroupByRegionResponse
         */
        public GetAggregateResourceCountsGroupByRegionResponse GetAggregateResourceCountsGroupByRegionWithOptions(GetAggregateResourceCountsGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "GetAggregateResourceCountsGroupByRegion",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceCountsGroupByRegionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the statistics on the resources in an account group named `ca-a260626622af0005****` by region. The returned result shows that a total of `10` resources exist in the `cn-hangzhou` region.
          *
          * @param request GetAggregateResourceCountsGroupByRegionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceCountsGroupByRegionResponse
         */
        public async Task<GetAggregateResourceCountsGroupByRegionResponse> GetAggregateResourceCountsGroupByRegionWithOptionsAsync(GetAggregateResourceCountsGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "GetAggregateResourceCountsGroupByRegion",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceCountsGroupByRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the statistics on the resources in an account group named `ca-a260626622af0005****` by region. The returned result shows that a total of `10` resources exist in the `cn-hangzhou` region.
          *
          * @param request GetAggregateResourceCountsGroupByRegionRequest
          * @return GetAggregateResourceCountsGroupByRegionResponse
         */
        public GetAggregateResourceCountsGroupByRegionResponse GetAggregateResourceCountsGroupByRegion(GetAggregateResourceCountsGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceCountsGroupByRegionWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the statistics on the resources in an account group named `ca-a260626622af0005****` by region. The returned result shows that a total of `10` resources exist in the `cn-hangzhou` region.
          *
          * @param request GetAggregateResourceCountsGroupByRegionRequest
          * @return GetAggregateResourceCountsGroupByRegionResponse
         */
        public async Task<GetAggregateResourceCountsGroupByRegionResponse> GetAggregateResourceCountsGroupByRegionAsync(GetAggregateResourceCountsGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceCountsGroupByRegionWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the statistics on the resources in an account group whose ID is `ca-a260626622af0005****` by resource type. The returned result shows that the account group has a total of `seven` resources of the `ACS::RAM::Role` resource type.
          *
          * @param request GetAggregateResourceCountsGroupByResourceTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceCountsGroupByResourceTypeResponse
         */
        public GetAggregateResourceCountsGroupByResourceTypeResponse GetAggregateResourceCountsGroupByResourceTypeWithOptions(GetAggregateResourceCountsGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceCountsGroupByResourceTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the statistics on the resources in an account group whose ID is `ca-a260626622af0005****` by resource type. The returned result shows that the account group has a total of `seven` resources of the `ACS::RAM::Role` resource type.
          *
          * @param request GetAggregateResourceCountsGroupByResourceTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceCountsGroupByResourceTypeResponse
         */
        public async Task<GetAggregateResourceCountsGroupByResourceTypeResponse> GetAggregateResourceCountsGroupByResourceTypeWithOptionsAsync(GetAggregateResourceCountsGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceCountsGroupByResourceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the statistics on the resources in an account group whose ID is `ca-a260626622af0005****` by resource type. The returned result shows that the account group has a total of `seven` resources of the `ACS::RAM::Role` resource type.
          *
          * @param request GetAggregateResourceCountsGroupByResourceTypeRequest
          * @return GetAggregateResourceCountsGroupByResourceTypeResponse
         */
        public GetAggregateResourceCountsGroupByResourceTypeResponse GetAggregateResourceCountsGroupByResourceType(GetAggregateResourceCountsGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceCountsGroupByResourceTypeWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the statistics on the resources in an account group whose ID is `ca-a260626622af0005****` by resource type. The returned result shows that the account group has a total of `seven` resources of the `ACS::RAM::Role` resource type.
          *
          * @param request GetAggregateResourceCountsGroupByResourceTypeRequest
          * @return GetAggregateResourceCountsGroupByResourceTypeResponse
         */
        public async Task<GetAggregateResourceCountsGroupByResourceTypeResponse> GetAggregateResourceCountsGroupByResourceTypeAsync(GetAggregateResourceCountsGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceCountsGroupByResourceTypeWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the most recently generated resource inventory of an account group whose ID is ca-a91d626622af0035\\*\\*\\*\\*.
          *
          * @param request GetAggregateResourceInventoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceInventoryResponse
         */
        public GetAggregateResourceInventoryResponse GetAggregateResourceInventoryWithOptions(GetAggregateResourceInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceInventory",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceInventoryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the most recently generated resource inventory of an account group whose ID is ca-a91d626622af0035\\*\\*\\*\\*.
          *
          * @param request GetAggregateResourceInventoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregateResourceInventoryResponse
         */
        public async Task<GetAggregateResourceInventoryResponse> GetAggregateResourceInventoryWithOptionsAsync(GetAggregateResourceInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggregateResourceInventory",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggregateResourceInventoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the most recently generated resource inventory of an account group whose ID is ca-a91d626622af0035\\*\\*\\*\\*.
          *
          * @param request GetAggregateResourceInventoryRequest
          * @return GetAggregateResourceInventoryResponse
         */
        public GetAggregateResourceInventoryResponse GetAggregateResourceInventory(GetAggregateResourceInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceInventoryWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the most recently generated resource inventory of an account group whose ID is ca-a91d626622af0035\\*\\*\\*\\*.
          *
          * @param request GetAggregateResourceInventoryRequest
          * @return GetAggregateResourceInventoryResponse
         */
        public async Task<GetAggregateResourceInventoryResponse> GetAggregateResourceInventoryAsync(GetAggregateResourceInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceInventoryWithOptionsAsync(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to query the details of the `ca-88ea626622af0055****` account group. The return result shows that the account group is named `Test_Group`, its description is `Test account group`, and it is of the `CUSTOM` type. The account group is in the `1` state, which indicates that it is created.
          *
          * @param request GetAggregatorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregatorResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the details of the `ca-88ea626622af0055****` account group. The return result shows that the account group is named `Test_Group`, its description is `Test account group`, and it is of the `CUSTOM` type. The account group is in the `1` state, which indicates that it is created.
          *
          * @param request GetAggregatorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAggregatorResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the details of the `ca-88ea626622af0055****` account group. The return result shows that the account group is named `Test_Group`, its description is `Test account group`, and it is of the `CUSTOM` type. The account group is in the `1` state, which indicates that it is created.
          *
          * @param request GetAggregatorRequest
          * @return GetAggregatorResponse
         */
        public GetAggregatorResponse GetAggregator(GetAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregatorWithOptions(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to query the details of the `ca-88ea626622af0055****` account group. The return result shows that the account group is named `Test_Group`, its description is `Test account group`, and it is of the `CUSTOM` type. The account group is in the `1` state, which indicates that it is created.
          *
          * @param request GetAggregatorRequest
          * @return GetAggregatorResponse
         */
        public async Task<GetAggregatorResponse> GetAggregatorAsync(GetAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregatorWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the details of a compliance package whose ID is `cp-fdc8626622af00f9****`. The returned result shows that the name of the compliance package is `ClassifiedProtectionPreCheck`, the compliance package is in the `ACTIVE` state, and the risk level of the rules in the compliance package is `1`, which indicates high risk level.
          *
          * @param request GetCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetCompliancePackResponse
         */
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

        /**
          * This topic provides an example on how to query the details of a compliance package whose ID is `cp-fdc8626622af00f9****`. The returned result shows that the name of the compliance package is `ClassifiedProtectionPreCheck`, the compliance package is in the `ACTIVE` state, and the risk level of the rules in the compliance package is `1`, which indicates high risk level.
          *
          * @param request GetCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetCompliancePackResponse
         */
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

        /**
          * This topic provides an example on how to query the details of a compliance package whose ID is `cp-fdc8626622af00f9****`. The returned result shows that the name of the compliance package is `ClassifiedProtectionPreCheck`, the compliance package is in the `ACTIVE` state, and the risk level of the rules in the compliance package is `1`, which indicates high risk level.
          *
          * @param request GetCompliancePackRequest
          * @return GetCompliancePackResponse
         */
        public GetCompliancePackResponse GetCompliancePack(GetCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCompliancePackWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the details of a compliance package whose ID is `cp-fdc8626622af00f9****`. The returned result shows that the name of the compliance package is `ClassifiedProtectionPreCheck`, the compliance package is in the `ACTIVE` state, and the risk level of the rules in the compliance package is `1`, which indicates high risk level.
          *
          * @param request GetCompliancePackRequest
          * @return GetCompliancePackResponse
         */
        public async Task<GetCompliancePackResponse> GetCompliancePackAsync(GetCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCompliancePackWithOptionsAsync(request, runtime);
        }

        /**
          * > Before you call this operation, you must call the GenerateCompliancePackReport operation to generate the latest compliance evaluation report based on a compliance package. For more information, see [GenerateCompliancePackReport](~~263525~~).
          * This topic provides an example on how to query the compliance evaluation report that is generated based on the `cp-fdc8626622af00f9****` compliance package.
          *
          * @param request GetCompliancePackReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetCompliancePackReportResponse
         */
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

        /**
          * > Before you call this operation, you must call the GenerateCompliancePackReport operation to generate the latest compliance evaluation report based on a compliance package. For more information, see [GenerateCompliancePackReport](~~263525~~).
          * This topic provides an example on how to query the compliance evaluation report that is generated based on the `cp-fdc8626622af00f9****` compliance package.
          *
          * @param request GetCompliancePackReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetCompliancePackReportResponse
         */
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

        /**
          * > Before you call this operation, you must call the GenerateCompliancePackReport operation to generate the latest compliance evaluation report based on a compliance package. For more information, see [GenerateCompliancePackReport](~~263525~~).
          * This topic provides an example on how to query the compliance evaluation report that is generated based on the `cp-fdc8626622af00f9****` compliance package.
          *
          * @param request GetCompliancePackReportRequest
          * @return GetCompliancePackReportResponse
         */
        public GetCompliancePackReportResponse GetCompliancePackReport(GetCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCompliancePackReportWithOptions(request, runtime);
        }

        /**
          * > Before you call this operation, you must call the GenerateCompliancePackReport operation to generate the latest compliance evaluation report based on a compliance package. For more information, see [GenerateCompliancePackReport](~~263525~~).
          * This topic provides an example on how to query the compliance evaluation report that is generated based on the `cp-fdc8626622af00f9****` compliance package.
          *
          * @param request GetCompliancePackReportRequest
          * @return GetCompliancePackReportResponse
         */
        public async Task<GetCompliancePackReportResponse> GetCompliancePackReportAsync(GetCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCompliancePackReportWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance statistics of resources and rules in the current account group.
          *
          * @param request GetComplianceSummaryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetComplianceSummaryResponse
         */
        public GetComplianceSummaryResponse GetComplianceSummaryWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComplianceSummary",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComplianceSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the compliance statistics of resources and rules in the current account group.
          *
          * @param request GetComplianceSummaryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetComplianceSummaryResponse
         */
        public async Task<GetComplianceSummaryResponse> GetComplianceSummaryWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComplianceSummary",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComplianceSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the compliance statistics of resources and rules in the current account group.
          *
          * @return GetComplianceSummaryResponse
         */
        public GetComplianceSummaryResponse GetComplianceSummary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetComplianceSummaryWithOptions(runtime);
        }

        /**
          * This topic provides an example on how to query the compliance statistics of resources and rules in the current account group.
          *
          * @return GetComplianceSummaryResponse
         */
        public async Task<GetComplianceSummaryResponse> GetComplianceSummaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetComplianceSummaryWithOptionsAsync(runtime);
        }

        public GetConfigDeliveryChannelResponse GetConfigDeliveryChannelWithOptions(GetConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                query["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigDeliveryChannelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetConfigDeliveryChannelResponse> GetConfigDeliveryChannelWithOptionsAsync(GetConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                query["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigDeliveryChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetConfigDeliveryChannelResponse GetConfigDeliveryChannel(GetConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigDeliveryChannelWithOptions(request, runtime);
        }

        public async Task<GetConfigDeliveryChannelResponse> GetConfigDeliveryChannelAsync(GetConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigDeliveryChannelWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the details of the `cr-7f7d626622af0041****` rule.
          *
          * @param request GetConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetConfigRuleResponse
         */
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

        /**
          * This topic provides an example on how to query the details of the `cr-7f7d626622af0041****` rule.
          *
          * @param request GetConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetConfigRuleResponse
         */
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

        /**
          * This topic provides an example on how to query the details of the `cr-7f7d626622af0041****` rule.
          *
          * @param request GetConfigRuleRequest
          * @return GetConfigRuleResponse
         */
        public GetConfigRuleResponse GetConfigRule(GetConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigRuleWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the details of the `cr-7f7d626622af0041****` rule.
          *
          * @param request GetConfigRuleRequest
          * @return GetConfigRuleResponse
         */
        public async Task<GetConfigRuleResponse> GetConfigRuleAsync(GetConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigRuleWithOptionsAsync(request, runtime);
        }

        /**
          * In this topic, the `cp-541e626622af0087****` compliance package is used as an example. The return result shows a total of one rule against which specific resources are evaluated as compliant.
          *
          * @param request GetConfigRuleComplianceByPackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetConfigRuleComplianceByPackResponse
         */
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

        /**
          * In this topic, the `cp-541e626622af0087****` compliance package is used as an example. The return result shows a total of one rule against which specific resources are evaluated as compliant.
          *
          * @param request GetConfigRuleComplianceByPackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetConfigRuleComplianceByPackResponse
         */
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

        /**
          * In this topic, the `cp-541e626622af0087****` compliance package is used as an example. The return result shows a total of one rule against which specific resources are evaluated as compliant.
          *
          * @param request GetConfigRuleComplianceByPackRequest
          * @return GetConfigRuleComplianceByPackResponse
         */
        public GetConfigRuleComplianceByPackResponse GetConfigRuleComplianceByPack(GetConfigRuleComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigRuleComplianceByPackWithOptions(request, runtime);
        }

        /**
          * In this topic, the `cp-541e626622af0087****` compliance package is used as an example. The return result shows a total of one rule against which specific resources are evaluated as compliant.
          *
          * @param request GetConfigRuleComplianceByPackRequest
          * @return GetConfigRuleComplianceByPackResponse
         */
        public async Task<GetConfigRuleComplianceByPackResponse> GetConfigRuleComplianceByPackAsync(GetConfigRuleComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigRuleComplianceByPackWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example of how to query the summary of compliance evaluation results by rule risk level. The return result shows four rules that are specified with the high risk level. One of them detects non-compliant resources, and the resources evaluated by the remaining three are all compliant.
          *
          * @param request GetConfigRuleSummaryByRiskLevelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetConfigRuleSummaryByRiskLevelResponse
         */
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

        /**
          * This topic provides an example of how to query the summary of compliance evaluation results by rule risk level. The return result shows four rules that are specified with the high risk level. One of them detects non-compliant resources, and the resources evaluated by the remaining three are all compliant.
          *
          * @param request GetConfigRuleSummaryByRiskLevelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetConfigRuleSummaryByRiskLevelResponse
         */
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

        /**
          * This topic provides an example of how to query the summary of compliance evaluation results by rule risk level. The return result shows four rules that are specified with the high risk level. One of them detects non-compliant resources, and the resources evaluated by the remaining three are all compliant.
          *
          * @return GetConfigRuleSummaryByRiskLevelResponse
         */
        public GetConfigRuleSummaryByRiskLevelResponse GetConfigRuleSummaryByRiskLevel()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigRuleSummaryByRiskLevelWithOptions(runtime);
        }

        /**
          * This topic provides an example of how to query the summary of compliance evaluation results by rule risk level. The return result shows four rules that are specified with the high risk level. One of them detects non-compliant resources, and the resources evaluated by the remaining three are all compliant.
          *
          * @return GetConfigRuleSummaryByRiskLevelResponse
         */
        public async Task<GetConfigRuleSummaryByRiskLevelResponse> GetConfigRuleSummaryByRiskLevelAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigRuleSummaryByRiskLevelWithOptionsAsync(runtime);
        }

        /**
          * >  Before you call this operation, you must call the GenerateConfigRulesReport operation to generate the latest compliance evaluation report based on all existing rules. For more information, see [GenerateConfigRulesReport](~~263601~~).
          * This topic provides an example of how to query the compliance evaluation report that is generated based on all existing rules.
          *
          * @param request GetConfigRulesReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetConfigRulesReportResponse
         */
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

        /**
          * >  Before you call this operation, you must call the GenerateConfigRulesReport operation to generate the latest compliance evaluation report based on all existing rules. For more information, see [GenerateConfigRulesReport](~~263601~~).
          * This topic provides an example of how to query the compliance evaluation report that is generated based on all existing rules.
          *
          * @param request GetConfigRulesReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetConfigRulesReportResponse
         */
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

        /**
          * >  Before you call this operation, you must call the GenerateConfigRulesReport operation to generate the latest compliance evaluation report based on all existing rules. For more information, see [GenerateConfigRulesReport](~~263601~~).
          * This topic provides an example of how to query the compliance evaluation report that is generated based on all existing rules.
          *
          * @param request GetConfigRulesReportRequest
          * @return GetConfigRulesReportResponse
         */
        public GetConfigRulesReportResponse GetConfigRulesReport(GetConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigRulesReportWithOptions(request, runtime);
        }

        /**
          * >  Before you call this operation, you must call the GenerateConfigRulesReport operation to generate the latest compliance evaluation report based on all existing rules. For more information, see [GenerateConfigRulesReport](~~263601~~).
          * This topic provides an example of how to query the compliance evaluation report that is generated based on all existing rules.
          *
          * @param request GetConfigRulesReportRequest
          * @return GetConfigRulesReportResponse
         */
        public async Task<GetConfigRulesReportResponse> GetConfigRulesReportAsync(GetConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigRulesReportWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the activation status and resource monitoring scope of Cloud Config for the current account.
          *
          * @param request GetConfigurationRecorderRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetConfigurationRecorderResponse
         */
        public GetConfigurationRecorderResponse GetConfigurationRecorderWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigurationRecorder",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigurationRecorderResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the activation status and resource monitoring scope of Cloud Config for the current account.
          *
          * @param request GetConfigurationRecorderRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetConfigurationRecorderResponse
         */
        public async Task<GetConfigurationRecorderResponse> GetConfigurationRecorderWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigurationRecorder",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigurationRecorderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the activation status and resource monitoring scope of Cloud Config for the current account.
          *
          * @return GetConfigurationRecorderResponse
         */
        public GetConfigurationRecorderResponse GetConfigurationRecorder()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigurationRecorderWithOptions(runtime);
        }

        /**
          * This topic provides an example on how to query the activation status and resource monitoring scope of Cloud Config for the current account.
          *
          * @return GetConfigurationRecorderResponse
         */
        public async Task<GetConfigurationRecorderResponse> GetConfigurationRecorderAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigurationRecorderWithOptionsAsync(runtime);
        }

        /**
          * The sample request in this topic shows you how to query the details of the `new-bucket` resource.
          *
          * @param request GetDiscoveredResourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDiscoveredResourceResponse
         */
        public GetDiscoveredResourceResponse GetDiscoveredResourceWithOptions(GetDiscoveredResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiscoveredResource",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiscoveredResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The sample request in this topic shows you how to query the details of the `new-bucket` resource.
          *
          * @param request GetDiscoveredResourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDiscoveredResourceResponse
         */
        public async Task<GetDiscoveredResourceResponse> GetDiscoveredResourceWithOptionsAsync(GetDiscoveredResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiscoveredResource",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiscoveredResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The sample request in this topic shows you how to query the details of the `new-bucket` resource.
          *
          * @param request GetDiscoveredResourceRequest
          * @return GetDiscoveredResourceResponse
         */
        public GetDiscoveredResourceResponse GetDiscoveredResource(GetDiscoveredResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiscoveredResourceWithOptions(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to query the details of the `new-bucket` resource.
          *
          * @param request GetDiscoveredResourceRequest
          * @return GetDiscoveredResourceResponse
         */
        public async Task<GetDiscoveredResourceResponse> GetDiscoveredResourceAsync(GetDiscoveredResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiscoveredResourceWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example to demonstrate how to query the statistics on resources by region. The returned result shows that a total of 10 resources exist in the `cn-hangzhou` region.
          *
          * @param request GetDiscoveredResourceCountsGroupByRegionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDiscoveredResourceCountsGroupByRegionResponse
         */
        public GetDiscoveredResourceCountsGroupByRegionResponse GetDiscoveredResourceCountsGroupByRegionWithOptions(GetDiscoveredResourceCountsGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetDiscoveredResourceCountsGroupByRegion",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsGroupByRegionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example to demonstrate how to query the statistics on resources by region. The returned result shows that a total of 10 resources exist in the `cn-hangzhou` region.
          *
          * @param request GetDiscoveredResourceCountsGroupByRegionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDiscoveredResourceCountsGroupByRegionResponse
         */
        public async Task<GetDiscoveredResourceCountsGroupByRegionResponse> GetDiscoveredResourceCountsGroupByRegionWithOptionsAsync(GetDiscoveredResourceCountsGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetDiscoveredResourceCountsGroupByRegion",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsGroupByRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example to demonstrate how to query the statistics on resources by region. The returned result shows that a total of 10 resources exist in the `cn-hangzhou` region.
          *
          * @param request GetDiscoveredResourceCountsGroupByRegionRequest
          * @return GetDiscoveredResourceCountsGroupByRegionResponse
         */
        public GetDiscoveredResourceCountsGroupByRegionResponse GetDiscoveredResourceCountsGroupByRegion(GetDiscoveredResourceCountsGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiscoveredResourceCountsGroupByRegionWithOptions(request, runtime);
        }

        /**
          * This topic provides an example to demonstrate how to query the statistics on resources by region. The returned result shows that a total of 10 resources exist in the `cn-hangzhou` region.
          *
          * @param request GetDiscoveredResourceCountsGroupByRegionRequest
          * @return GetDiscoveredResourceCountsGroupByRegionResponse
         */
        public async Task<GetDiscoveredResourceCountsGroupByRegionResponse> GetDiscoveredResourceCountsGroupByRegionAsync(GetDiscoveredResourceCountsGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiscoveredResourceCountsGroupByRegionWithOptionsAsync(request, runtime);
        }

        /**
          * This topic describes how to query the statistics on resources by resource type. The returned result shows that a total of 10 resources of the `ACS::ECS::Instance` resource type exist.
          *
          * @param request GetDiscoveredResourceCountsGroupByResourceTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDiscoveredResourceCountsGroupByResourceTypeResponse
         */
        public GetDiscoveredResourceCountsGroupByResourceTypeResponse GetDiscoveredResourceCountsGroupByResourceTypeWithOptions(GetDiscoveredResourceCountsGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsGroupByResourceTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic describes how to query the statistics on resources by resource type. The returned result shows that a total of 10 resources of the `ACS::ECS::Instance` resource type exist.
          *
          * @param request GetDiscoveredResourceCountsGroupByResourceTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDiscoveredResourceCountsGroupByResourceTypeResponse
         */
        public async Task<GetDiscoveredResourceCountsGroupByResourceTypeResponse> GetDiscoveredResourceCountsGroupByResourceTypeWithOptionsAsync(GetDiscoveredResourceCountsGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsGroupByResourceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic describes how to query the statistics on resources by resource type. The returned result shows that a total of 10 resources of the `ACS::ECS::Instance` resource type exist.
          *
          * @param request GetDiscoveredResourceCountsGroupByResourceTypeRequest
          * @return GetDiscoveredResourceCountsGroupByResourceTypeResponse
         */
        public GetDiscoveredResourceCountsGroupByResourceTypeResponse GetDiscoveredResourceCountsGroupByResourceType(GetDiscoveredResourceCountsGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiscoveredResourceCountsGroupByResourceTypeWithOptions(request, runtime);
        }

        /**
          * This topic describes how to query the statistics on resources by resource type. The returned result shows that a total of 10 resources of the `ACS::ECS::Instance` resource type exist.
          *
          * @param request GetDiscoveredResourceCountsGroupByResourceTypeRequest
          * @return GetDiscoveredResourceCountsGroupByResourceTypeResponse
         */
        public async Task<GetDiscoveredResourceCountsGroupByResourceTypeResponse> GetDiscoveredResourceCountsGroupByResourceTypeAsync(GetDiscoveredResourceCountsGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiscoveredResourceCountsGroupByResourceTypeWithOptionsAsync(request, runtime);
        }

        public GetIntegratedServiceStatusResponse GetIntegratedServiceStatusWithOptions(GetIntegratedServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntegratedServiceStatus",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntegratedServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetIntegratedServiceStatusResponse> GetIntegratedServiceStatusWithOptionsAsync(GetIntegratedServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntegratedServiceStatus",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntegratedServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetIntegratedServiceStatusResponse GetIntegratedServiceStatus(GetIntegratedServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIntegratedServiceStatusWithOptions(request, runtime);
        }

        public async Task<GetIntegratedServiceStatusResponse> GetIntegratedServiceStatusAsync(GetIntegratedServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIntegratedServiceStatusWithOptionsAsync(request, runtime);
        }

        /**
          * In this topic, the `cdn-domain-https-enabled` managed rule is used as an example.
          *
          * @param request GetManagedRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetManagedRuleResponse
         */
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

        /**
          * In this topic, the `cdn-domain-https-enabled` managed rule is used as an example.
          *
          * @param request GetManagedRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetManagedRuleResponse
         */
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

        /**
          * In this topic, the `cdn-domain-https-enabled` managed rule is used as an example.
          *
          * @param request GetManagedRuleRequest
          * @return GetManagedRuleResponse
         */
        public GetManagedRuleResponse GetManagedRule(GetManagedRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetManagedRuleWithOptions(request, runtime);
        }

        /**
          * In this topic, the `cdn-domain-https-enabled` managed rule is used as an example.
          *
          * @param request GetManagedRuleRequest
          * @return GetManagedRuleResponse
         */
        public async Task<GetManagedRuleResponse> GetManagedRuleAsync(GetManagedRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetManagedRuleWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the details of the automatic remediation template ACS-ALB-BulkyEnableDeletionProtection.
          *
          * @param request GetRemediationTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetRemediationTemplateResponse
         */
        public GetRemediationTemplateResponse GetRemediationTemplateWithOptions(GetRemediationTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIdentifier))
            {
                query["TemplateIdentifier"] = request.TemplateIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRemediationTemplate",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRemediationTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the details of the automatic remediation template ACS-ALB-BulkyEnableDeletionProtection.
          *
          * @param request GetRemediationTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetRemediationTemplateResponse
         */
        public async Task<GetRemediationTemplateResponse> GetRemediationTemplateWithOptionsAsync(GetRemediationTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIdentifier))
            {
                query["TemplateIdentifier"] = request.TemplateIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRemediationTemplate",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRemediationTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the details of the automatic remediation template ACS-ALB-BulkyEnableDeletionProtection.
          *
          * @param request GetRemediationTemplateRequest
          * @return GetRemediationTemplateResponse
         */
        public GetRemediationTemplateResponse GetRemediationTemplate(GetRemediationTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRemediationTemplateWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the details of the automatic remediation template ACS-ALB-BulkyEnableDeletionProtection.
          *
          * @param request GetRemediationTemplateRequest
          * @return GetRemediationTemplateResponse
         */
        public async Task<GetRemediationTemplateResponse> GetRemediationTemplateAsync(GetRemediationTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRemediationTemplateWithOptionsAsync(request, runtime);
        }

        /**
          * In this topic, the `cr-d369626622af008e****` rule is used as an example. The return result shows that a total of 10 resources are evaluated by the rule and `five` of them are evaluated as compliant.
          *
          * @param request GetResourceComplianceByConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceComplianceByConfigRuleResponse
         */
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

        /**
          * In this topic, the `cr-d369626622af008e****` rule is used as an example. The return result shows that a total of 10 resources are evaluated by the rule and `five` of them are evaluated as compliant.
          *
          * @param request GetResourceComplianceByConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceComplianceByConfigRuleResponse
         */
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

        /**
          * In this topic, the `cr-d369626622af008e****` rule is used as an example. The return result shows that a total of 10 resources are evaluated by the rule and `five` of them are evaluated as compliant.
          *
          * @param request GetResourceComplianceByConfigRuleRequest
          * @return GetResourceComplianceByConfigRuleResponse
         */
        public GetResourceComplianceByConfigRuleResponse GetResourceComplianceByConfigRule(GetResourceComplianceByConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceComplianceByConfigRuleWithOptions(request, runtime);
        }

        /**
          * In this topic, the `cr-d369626622af008e****` rule is used as an example. The return result shows that a total of 10 resources are evaluated by the rule and `five` of them are evaluated as compliant.
          *
          * @param request GetResourceComplianceByConfigRuleRequest
          * @return GetResourceComplianceByConfigRuleResponse
         */
        public async Task<GetResourceComplianceByConfigRuleResponse> GetResourceComplianceByConfigRuleAsync(GetResourceComplianceByConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceComplianceByConfigRuleWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance evaluation results of resources monitored by using the `cp-541e626622af0087****` compliance package. The returned result shows a total of 10 resources and seven of them are evaluated as non-compliant.
          *
          * @param request GetResourceComplianceByPackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceComplianceByPackResponse
         */
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

        /**
          * This topic provides an example on how to query the compliance evaluation results of resources monitored by using the `cp-541e626622af0087****` compliance package. The returned result shows a total of 10 resources and seven of them are evaluated as non-compliant.
          *
          * @param request GetResourceComplianceByPackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceComplianceByPackResponse
         */
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

        /**
          * This topic provides an example on how to query the compliance evaluation results of resources monitored by using the `cp-541e626622af0087****` compliance package. The returned result shows a total of 10 resources and seven of them are evaluated as non-compliant.
          *
          * @param request GetResourceComplianceByPackRequest
          * @return GetResourceComplianceByPackResponse
         */
        public GetResourceComplianceByPackResponse GetResourceComplianceByPack(GetResourceComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceComplianceByPackWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance evaluation results of resources monitored by using the `cp-541e626622af0087****` compliance package. The returned result shows a total of 10 resources and seven of them are evaluated as non-compliant.
          *
          * @param request GetResourceComplianceByPackRequest
          * @return GetResourceComplianceByPackResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the compliance timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region. The resource is an Object Storage Service (OSS) bucket. The return result shows the following two timestamps on the compliance timeline: `1625200295276` and `1625200228510`. The first timestamp indicates 12:31:35 on July 2, 2021 (UTC+8) and the second timestamp indicates 12:30:28 on July 2, 2021 (UTC+8).
          *
          * @param request GetResourceComplianceTimelineRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceComplianceTimelineResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the compliance timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region. The resource is an Object Storage Service (OSS) bucket. The return result shows the following two timestamps on the compliance timeline: `1625200295276` and `1625200228510`. The first timestamp indicates 12:31:35 on July 2, 2021 (UTC+8) and the second timestamp indicates 12:30:28 on July 2, 2021 (UTC+8).
          *
          * @param request GetResourceComplianceTimelineRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceComplianceTimelineResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the compliance timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region. The resource is an Object Storage Service (OSS) bucket. The return result shows the following two timestamps on the compliance timeline: `1625200295276` and `1625200228510`. The first timestamp indicates 12:31:35 on July 2, 2021 (UTC+8) and the second timestamp indicates 12:30:28 on July 2, 2021 (UTC+8).
          *
          * @param request GetResourceComplianceTimelineRequest
          * @return GetResourceComplianceTimelineResponse
         */
        public GetResourceComplianceTimelineResponse GetResourceComplianceTimeline(GetResourceComplianceTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceComplianceTimelineWithOptions(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to query the compliance timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region. The resource is an Object Storage Service (OSS) bucket. The return result shows the following two timestamps on the compliance timeline: `1625200295276` and `1625200228510`. The first timestamp indicates 12:31:35 on July 2, 2021 (UTC+8) and the second timestamp indicates 12:30:28 on July 2, 2021 (UTC+8).
          *
          * @param request GetResourceComplianceTimelineRequest
          * @return GetResourceComplianceTimelineResponse
         */
        public async Task<GetResourceComplianceTimelineResponse> GetResourceComplianceTimelineAsync(GetResourceComplianceTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceComplianceTimelineWithOptionsAsync(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to query the configuration timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region. The new-bucket resource is an Object Storage Service (OSS) bucket. The return result shows that the timestamp when the resource configuration changes is `1624961112000`. The timestamp indicates 18:05:12 on June 29, 2021 (UTC+8).
          *
          * @param request GetResourceConfigurationTimelineRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceConfigurationTimelineResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the configuration timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region. The new-bucket resource is an Object Storage Service (OSS) bucket. The return result shows that the timestamp when the resource configuration changes is `1624961112000`. The timestamp indicates 18:05:12 on June 29, 2021 (UTC+8).
          *
          * @param request GetResourceConfigurationTimelineRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceConfigurationTimelineResponse
         */
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

        /**
          * The sample request in this topic shows you how to query the configuration timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region. The new-bucket resource is an Object Storage Service (OSS) bucket. The return result shows that the timestamp when the resource configuration changes is `1624961112000`. The timestamp indicates 18:05:12 on June 29, 2021 (UTC+8).
          *
          * @param request GetResourceConfigurationTimelineRequest
          * @return GetResourceConfigurationTimelineResponse
         */
        public GetResourceConfigurationTimelineResponse GetResourceConfigurationTimeline(GetResourceConfigurationTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceConfigurationTimelineWithOptions(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to query the configuration timeline of the `new-bucket` resource that resides in the `cn-hangzhou` region. The new-bucket resource is an Object Storage Service (OSS) bucket. The return result shows that the timestamp when the resource configuration changes is `1624961112000`. The timestamp indicates 18:05:12 on June 29, 2021 (UTC+8).
          *
          * @param request GetResourceConfigurationTimelineRequest
          * @return GetResourceConfigurationTimelineResponse
         */
        public async Task<GetResourceConfigurationTimelineResponse> GetResourceConfigurationTimelineAsync(GetResourceConfigurationTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceConfigurationTimelineWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the most recently generated resource inventory of the current Alibaba Cloud account.
          *
          * @param request GetResourceInventoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceInventoryResponse
         */
        public GetResourceInventoryResponse GetResourceInventoryWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceInventory",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceInventoryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the most recently generated resource inventory of the current Alibaba Cloud account.
          *
          * @param request GetResourceInventoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceInventoryResponse
         */
        public async Task<GetResourceInventoryResponse> GetResourceInventoryWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceInventory",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceInventoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the most recently generated resource inventory of the current Alibaba Cloud account.
          *
          * @return GetResourceInventoryResponse
         */
        public GetResourceInventoryResponse GetResourceInventory()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceInventoryWithOptions(runtime);
        }

        /**
          * This topic provides an example on how to query the most recently generated resource inventory of the current Alibaba Cloud account.
          *
          * @return GetResourceInventoryResponse
         */
        public async Task<GetResourceInventoryResponse> GetResourceInventoryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceInventoryWithOptionsAsync(runtime);
        }

        /**
          * This topic provides an example to show how to query the resource relationships that are supported by the ACS::ECS::Instance resource type.
          *
          * @param request GetSupportedResourceRelationConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetSupportedResourceRelationConfigResponse
         */
        public GetSupportedResourceRelationConfigResponse GetSupportedResourceRelationConfigWithOptions(GetSupportedResourceRelationConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetSupportedResourceRelationConfig",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSupportedResourceRelationConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query the resource relationships that are supported by the ACS::ECS::Instance resource type.
          *
          * @param request GetSupportedResourceRelationConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetSupportedResourceRelationConfigResponse
         */
        public async Task<GetSupportedResourceRelationConfigResponse> GetSupportedResourceRelationConfigWithOptionsAsync(GetSupportedResourceRelationConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetSupportedResourceRelationConfig",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSupportedResourceRelationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query the resource relationships that are supported by the ACS::ECS::Instance resource type.
          *
          * @param request GetSupportedResourceRelationConfigRequest
          * @return GetSupportedResourceRelationConfigResponse
         */
        public GetSupportedResourceRelationConfigResponse GetSupportedResourceRelationConfig(GetSupportedResourceRelationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSupportedResourceRelationConfigWithOptions(request, runtime);
        }

        /**
          * This topic provides an example to show how to query the resource relationships that are supported by the ACS::ECS::Instance resource type.
          *
          * @param request GetSupportedResourceRelationConfigRequest
          * @return GetSupportedResourceRelationConfigResponse
         */
        public async Task<GetSupportedResourceRelationConfigResponse> GetSupportedResourceRelationConfigAsync(GetSupportedResourceRelationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSupportedResourceRelationConfigWithOptionsAsync(request, runtime);
        }

        /**
          * After you ignore a resource that is evaluated as incompliant by using a rule, the resource is still evaluated by using the rule, but the compliance result is Ignored.
          * This example shows how to ignore the `lb-hp3a3b4ztyfm2plgm****` incompliant resource that is evaluated by using the `cr-7e72626622af0051***` rule in the `120886317861****` member account of the `ca-5b6c626622af008f****` account group. The ID of the region where the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.
          *
          * @param tmpReq IgnoreAggregateEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return IgnoreAggregateEvaluationResultsResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreDate))
            {
                body["IgnoreDate"] = request.IgnoreDate;
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

        /**
          * After you ignore a resource that is evaluated as incompliant by using a rule, the resource is still evaluated by using the rule, but the compliance result is Ignored.
          * This example shows how to ignore the `lb-hp3a3b4ztyfm2plgm****` incompliant resource that is evaluated by using the `cr-7e72626622af0051***` rule in the `120886317861****` member account of the `ca-5b6c626622af008f****` account group. The ID of the region where the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.
          *
          * @param tmpReq IgnoreAggregateEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return IgnoreAggregateEvaluationResultsResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreDate))
            {
                body["IgnoreDate"] = request.IgnoreDate;
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

        /**
          * After you ignore a resource that is evaluated as incompliant by using a rule, the resource is still evaluated by using the rule, but the compliance result is Ignored.
          * This example shows how to ignore the `lb-hp3a3b4ztyfm2plgm****` incompliant resource that is evaluated by using the `cr-7e72626622af0051***` rule in the `120886317861****` member account of the `ca-5b6c626622af008f****` account group. The ID of the region where the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.
          *
          * @param request IgnoreAggregateEvaluationResultsRequest
          * @return IgnoreAggregateEvaluationResultsResponse
         */
        public IgnoreAggregateEvaluationResultsResponse IgnoreAggregateEvaluationResults(IgnoreAggregateEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IgnoreAggregateEvaluationResultsWithOptions(request, runtime);
        }

        /**
          * After you ignore a resource that is evaluated as incompliant by using a rule, the resource is still evaluated by using the rule, but the compliance result is Ignored.
          * This example shows how to ignore the `lb-hp3a3b4ztyfm2plgm****` incompliant resource that is evaluated by using the `cr-7e72626622af0051***` rule in the `120886317861****` member account of the `ca-5b6c626622af008f****` account group. The ID of the region where the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.
          *
          * @param request IgnoreAggregateEvaluationResultsRequest
          * @return IgnoreAggregateEvaluationResultsResponse
         */
        public async Task<IgnoreAggregateEvaluationResultsResponse> IgnoreAggregateEvaluationResultsAsync(IgnoreAggregateEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IgnoreAggregateEvaluationResultsWithOptionsAsync(request, runtime);
        }

        /**
          * After you ignore a resource that is evaluated as incompliant by using a rule, the resource is still evaluated by using the rule, but the compliance result is Ignored.
          * This example shows how to ignore the `lb-hp3a3b4ztyfm2plgm****` resource that is evaluated as incompliant by using the `cr-7e72626622af0051****` rule in the `100931896542****` account. The ID of the region in which the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.
          *
          * @param tmpReq IgnoreEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return IgnoreEvaluationResultsResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreDate))
            {
                body["IgnoreDate"] = request.IgnoreDate;
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

        /**
          * After you ignore a resource that is evaluated as incompliant by using a rule, the resource is still evaluated by using the rule, but the compliance result is Ignored.
          * This example shows how to ignore the `lb-hp3a3b4ztyfm2plgm****` resource that is evaluated as incompliant by using the `cr-7e72626622af0051****` rule in the `100931896542****` account. The ID of the region in which the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.
          *
          * @param tmpReq IgnoreEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return IgnoreEvaluationResultsResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreDate))
            {
                body["IgnoreDate"] = request.IgnoreDate;
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

        /**
          * After you ignore a resource that is evaluated as incompliant by using a rule, the resource is still evaluated by using the rule, but the compliance result is Ignored.
          * This example shows how to ignore the `lb-hp3a3b4ztyfm2plgm****` resource that is evaluated as incompliant by using the `cr-7e72626622af0051****` rule in the `100931896542****` account. The ID of the region in which the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.
          *
          * @param request IgnoreEvaluationResultsRequest
          * @return IgnoreEvaluationResultsResponse
         */
        public IgnoreEvaluationResultsResponse IgnoreEvaluationResults(IgnoreEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IgnoreEvaluationResultsWithOptions(request, runtime);
        }

        /**
          * After you ignore a resource that is evaluated as incompliant by using a rule, the resource is still evaluated by using the rule, but the compliance result is Ignored.
          * This example shows how to ignore the `lb-hp3a3b4ztyfm2plgm****` resource that is evaluated as incompliant by using the `cr-7e72626622af0051****` rule in the `100931896542****` account. The ID of the region in which the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.
          *
          * @param request IgnoreEvaluationResultsRequest
          * @return IgnoreEvaluationResultsResponse
         */
        public async Task<IgnoreEvaluationResultsResponse> IgnoreEvaluationResultsAsync(IgnoreEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IgnoreEvaluationResultsWithOptionsAsync(request, runtime);
        }

        /**
          * In this topic, the `ca-f632626622af0079****` account group is used as an example. The return result shows one compliance package whose ID is `cp-fdc8626622af00f9****`.
          *
          * @param request ListAggregateCompliancePacksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateCompliancePacksResponse
         */
        public ListAggregateCompliancePacksResponse ListAggregateCompliancePacksWithOptions(ListAggregateCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateCompliancePacksResponse>(CallApi(params_, req, runtime));
        }

        /**
          * In this topic, the `ca-f632626622af0079****` account group is used as an example. The return result shows one compliance package whose ID is `cp-fdc8626622af00f9****`.
          *
          * @param request ListAggregateCompliancePacksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateCompliancePacksResponse
         */
        public async Task<ListAggregateCompliancePacksResponse> ListAggregateCompliancePacksWithOptionsAsync(ListAggregateCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateCompliancePacksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * In this topic, the `ca-f632626622af0079****` account group is used as an example. The return result shows one compliance package whose ID is `cp-fdc8626622af00f9****`.
          *
          * @param request ListAggregateCompliancePacksRequest
          * @return ListAggregateCompliancePacksResponse
         */
        public ListAggregateCompliancePacksResponse ListAggregateCompliancePacks(ListAggregateCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateCompliancePacksWithOptions(request, runtime);
        }

        /**
          * In this topic, the `ca-f632626622af0079****` account group is used as an example. The return result shows one compliance package whose ID is `cp-fdc8626622af00f9****`.
          *
          * @param request ListAggregateCompliancePacksRequest
          * @return ListAggregateCompliancePacksResponse
         */
        public async Task<ListAggregateCompliancePacksResponse> ListAggregateCompliancePacksAsync(ListAggregateCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateCompliancePacksWithOptionsAsync(request, runtime);
        }

        public ListAggregateConfigDeliveryChannelsResponse ListAggregateConfigDeliveryChannelsWithOptions(ListAggregateConfigDeliveryChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelIds))
            {
                query["DeliveryChannelIds"] = request.DeliveryChannelIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateConfigDeliveryChannels",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateConfigDeliveryChannelsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAggregateConfigDeliveryChannelsResponse> ListAggregateConfigDeliveryChannelsWithOptionsAsync(ListAggregateConfigDeliveryChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelIds))
            {
                query["DeliveryChannelIds"] = request.DeliveryChannelIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateConfigDeliveryChannels",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateConfigDeliveryChannelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAggregateConfigDeliveryChannelsResponse ListAggregateConfigDeliveryChannels(ListAggregateConfigDeliveryChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateConfigDeliveryChannelsWithOptions(request, runtime);
        }

        public async Task<ListAggregateConfigDeliveryChannelsResponse> ListAggregateConfigDeliveryChannelsAsync(ListAggregateConfigDeliveryChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateConfigDeliveryChannelsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance evaluation results of resources based on the `cr-888f626622af00ae****` rule in the `ca-d1e3326622af00cb****` account group. The returned result indicates that the `Bucket-test` resource is evaluated as `NON_COMPLIANT` by using the rule. The resource is an Object Storage Service (OSS) bucket.
          *
          * @param request ListAggregateConfigRuleEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateConfigRuleEvaluationResultsResponse
         */
        public ListAggregateConfigRuleEvaluationResultsResponse ListAggregateConfigRuleEvaluationResultsWithOptions(ListAggregateConfigRuleEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplianceType))
            {
                query["ComplianceType"] = request.ComplianceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                query["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                query["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateConfigRuleEvaluationResultsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the compliance evaluation results of resources based on the `cr-888f626622af00ae****` rule in the `ca-d1e3326622af00cb****` account group. The returned result indicates that the `Bucket-test` resource is evaluated as `NON_COMPLIANT` by using the rule. The resource is an Object Storage Service (OSS) bucket.
          *
          * @param request ListAggregateConfigRuleEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateConfigRuleEvaluationResultsResponse
         */
        public async Task<ListAggregateConfigRuleEvaluationResultsResponse> ListAggregateConfigRuleEvaluationResultsWithOptionsAsync(ListAggregateConfigRuleEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplianceType))
            {
                query["ComplianceType"] = request.ComplianceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                query["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                query["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateConfigRuleEvaluationResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the compliance evaluation results of resources based on the `cr-888f626622af00ae****` rule in the `ca-d1e3326622af00cb****` account group. The returned result indicates that the `Bucket-test` resource is evaluated as `NON_COMPLIANT` by using the rule. The resource is an Object Storage Service (OSS) bucket.
          *
          * @param request ListAggregateConfigRuleEvaluationResultsRequest
          * @return ListAggregateConfigRuleEvaluationResultsResponse
         */
        public ListAggregateConfigRuleEvaluationResultsResponse ListAggregateConfigRuleEvaluationResults(ListAggregateConfigRuleEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateConfigRuleEvaluationResultsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance evaluation results of resources based on the `cr-888f626622af00ae****` rule in the `ca-d1e3326622af00cb****` account group. The returned result indicates that the `Bucket-test` resource is evaluated as `NON_COMPLIANT` by using the rule. The resource is an Object Storage Service (OSS) bucket.
          *
          * @param request ListAggregateConfigRuleEvaluationResultsRequest
          * @return ListAggregateConfigRuleEvaluationResultsResponse
         */
        public async Task<ListAggregateConfigRuleEvaluationResultsResponse> ListAggregateConfigRuleEvaluationResultsAsync(ListAggregateConfigRuleEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateConfigRuleEvaluationResultsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the statistics of compliance evaluation results of an account group whose ID is ca-edd3626622af00b3\\*\\*\\*\\*.
          *
          * @param request ListAggregateConfigRuleEvaluationStatisticsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateConfigRuleEvaluationStatisticsResponse
         */
        public ListAggregateConfigRuleEvaluationStatisticsResponse ListAggregateConfigRuleEvaluationStatisticsWithOptions(ListAggregateConfigRuleEvaluationStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateConfigRuleEvaluationStatistics",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateConfigRuleEvaluationStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the statistics of compliance evaluation results of an account group whose ID is ca-edd3626622af00b3\\*\\*\\*\\*.
          *
          * @param request ListAggregateConfigRuleEvaluationStatisticsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateConfigRuleEvaluationStatisticsResponse
         */
        public async Task<ListAggregateConfigRuleEvaluationStatisticsResponse> ListAggregateConfigRuleEvaluationStatisticsWithOptionsAsync(ListAggregateConfigRuleEvaluationStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateConfigRuleEvaluationStatistics",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateConfigRuleEvaluationStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the statistics of compliance evaluation results of an account group whose ID is ca-edd3626622af00b3\\*\\*\\*\\*.
          *
          * @param request ListAggregateConfigRuleEvaluationStatisticsRequest
          * @return ListAggregateConfigRuleEvaluationStatisticsResponse
         */
        public ListAggregateConfigRuleEvaluationStatisticsResponse ListAggregateConfigRuleEvaluationStatistics(ListAggregateConfigRuleEvaluationStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateConfigRuleEvaluationStatisticsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the statistics of compliance evaluation results of an account group whose ID is ca-edd3626622af00b3\\*\\*\\*\\*.
          *
          * @param request ListAggregateConfigRuleEvaluationStatisticsRequest
          * @return ListAggregateConfigRuleEvaluationStatisticsResponse
         */
        public async Task<ListAggregateConfigRuleEvaluationStatisticsResponse> ListAggregateConfigRuleEvaluationStatisticsAsync(ListAggregateConfigRuleEvaluationStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateConfigRuleEvaluationStatisticsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the rules in an account group whose ID is `ca-f632626622af0079****`. The returned result shows a total of one rule and two evaluated resources. The resources are both evaluated as `COMPLIANT`.
          *
          * @param request ListAggregateConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateConfigRulesResponse
         */
        public ListAggregateConfigRulesResponse ListAggregateConfigRulesWithOptions(ListAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleName))
            {
                query["ConfigRuleName"] = request.ConfigRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleState))
            {
                query["ConfigRuleState"] = request.ConfigRuleState;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
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
                Action = "ListAggregateConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateConfigRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the rules in an account group whose ID is `ca-f632626622af0079****`. The returned result shows a total of one rule and two evaluated resources. The resources are both evaluated as `COMPLIANT`.
          *
          * @param request ListAggregateConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateConfigRulesResponse
         */
        public async Task<ListAggregateConfigRulesResponse> ListAggregateConfigRulesWithOptionsAsync(ListAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleName))
            {
                query["ConfigRuleName"] = request.ConfigRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleState))
            {
                query["ConfigRuleState"] = request.ConfigRuleState;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
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
                Action = "ListAggregateConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateConfigRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the rules in an account group whose ID is `ca-f632626622af0079****`. The returned result shows a total of one rule and two evaluated resources. The resources are both evaluated as `COMPLIANT`.
          *
          * @param request ListAggregateConfigRulesRequest
          * @return ListAggregateConfigRulesResponse
         */
        public ListAggregateConfigRulesResponse ListAggregateConfigRules(ListAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateConfigRulesWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the rules in an account group whose ID is `ca-f632626622af0079****`. The returned result shows a total of one rule and two evaluated resources. The resources are both evaluated as `COMPLIANT`.
          *
          * @param request ListAggregateConfigRulesRequest
          * @return ListAggregateConfigRulesResponse
         */
        public async Task<ListAggregateConfigRulesResponse> ListAggregateConfigRulesAsync(ListAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateConfigRulesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query a list of resources in the `ca-c560626622af0005****` account group. The returned result shows that eight resources exist in the account group.
          *
          * @param request ListAggregateDiscoveredResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateDiscoveredResourcesResponse
         */
        public ListAggregateDiscoveredResourcesResponse ListAggregateDiscoveredResourcesWithOptions(ListAggregateDiscoveredResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDeleted))
            {
                query["ResourceDeleted"] = request.ResourceDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateDiscoveredResources",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateDiscoveredResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query a list of resources in the `ca-c560626622af0005****` account group. The returned result shows that eight resources exist in the account group.
          *
          * @param request ListAggregateDiscoveredResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateDiscoveredResourcesResponse
         */
        public async Task<ListAggregateDiscoveredResourcesResponse> ListAggregateDiscoveredResourcesWithOptionsAsync(ListAggregateDiscoveredResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDeleted))
            {
                query["ResourceDeleted"] = request.ResourceDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateDiscoveredResources",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateDiscoveredResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query a list of resources in the `ca-c560626622af0005****` account group. The returned result shows that eight resources exist in the account group.
          *
          * @param request ListAggregateDiscoveredResourcesRequest
          * @return ListAggregateDiscoveredResourcesResponse
         */
        public ListAggregateDiscoveredResourcesResponse ListAggregateDiscoveredResources(ListAggregateDiscoveredResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateDiscoveredResourcesWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query a list of resources in the `ca-c560626622af0005****` account group. The returned result shows that eight resources exist in the account group.
          *
          * @param request ListAggregateDiscoveredResourcesRequest
          * @return ListAggregateDiscoveredResourcesResponse
         */
        public async Task<ListAggregateDiscoveredResourcesResponse> ListAggregateDiscoveredResourcesAsync(ListAggregateDiscoveredResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateDiscoveredResourcesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the remediation records of the `cr-d04a626622af00af****` rule in the `ca-edd3626622af00b3****` account group.
          *
          * @param request ListAggregateRemediationExecutionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateRemediationExecutionsResponse
         */
        public ListAggregateRemediationExecutionsResponse ListAggregateRemediationExecutionsWithOptions(ListAggregateRemediationExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionStatus))
            {
                query["ExecutionStatus"] = request.ExecutionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateRemediationExecutions",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateRemediationExecutionsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the remediation records of the `cr-d04a626622af00af****` rule in the `ca-edd3626622af00b3****` account group.
          *
          * @param request ListAggregateRemediationExecutionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateRemediationExecutionsResponse
         */
        public async Task<ListAggregateRemediationExecutionsResponse> ListAggregateRemediationExecutionsWithOptionsAsync(ListAggregateRemediationExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionStatus))
            {
                query["ExecutionStatus"] = request.ExecutionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateRemediationExecutions",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateRemediationExecutionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the remediation records of the `cr-d04a626622af00af****` rule in the `ca-edd3626622af00b3****` account group.
          *
          * @param request ListAggregateRemediationExecutionsRequest
          * @return ListAggregateRemediationExecutionsResponse
         */
        public ListAggregateRemediationExecutionsResponse ListAggregateRemediationExecutions(ListAggregateRemediationExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateRemediationExecutionsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the remediation records of the `cr-d04a626622af00af****` rule in the `ca-edd3626622af00b3****` account group.
          *
          * @param request ListAggregateRemediationExecutionsRequest
          * @return ListAggregateRemediationExecutionsResponse
         */
        public async Task<ListAggregateRemediationExecutionsResponse> ListAggregateRemediationExecutionsAsync(ListAggregateRemediationExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateRemediationExecutionsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the remediation templates of the rule whose ID is `cr-6b7c626622af00b4****` in the account group whose ID is `ca-6b4a626622af0012****`.
          *
          * @param request ListAggregateRemediationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateRemediationsResponse
         */
        public ListAggregateRemediationsResponse ListAggregateRemediationsWithOptions(ListAggregateRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAggregateRemediations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateRemediationsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the remediation templates of the rule whose ID is `cr-6b7c626622af00b4****` in the account group whose ID is `ca-6b4a626622af0012****`.
          *
          * @param request ListAggregateRemediationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateRemediationsResponse
         */
        public async Task<ListAggregateRemediationsResponse> ListAggregateRemediationsWithOptionsAsync(ListAggregateRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAggregateRemediations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateRemediationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the remediation templates of the rule whose ID is `cr-6b7c626622af00b4****` in the account group whose ID is `ca-6b4a626622af0012****`.
          *
          * @param request ListAggregateRemediationsRequest
          * @return ListAggregateRemediationsResponse
         */
        public ListAggregateRemediationsResponse ListAggregateRemediations(ListAggregateRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateRemediationsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the remediation templates of the rule whose ID is `cr-6b7c626622af00b4****` in the account group whose ID is `ca-6b4a626622af0012****`.
          *
          * @param request ListAggregateRemediationsRequest
          * @return ListAggregateRemediationsResponse
         */
        public async Task<ListAggregateRemediationsResponse> ListAggregateRemediationsAsync(ListAggregateRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateRemediationsWithOptionsAsync(request, runtime);
        }

        /**
          * This example shows how to query the compliance evaluation result of the `23642660635396****` resource in the `ca-7f00626622af0041****` account group. The resource is a RAM user. The returned result indicates that the resource is evaluated as `NON_COMPLIANT` by using the `cr-7f7d626622af0041****` rule.
          *
          * @param request ListAggregateResourceEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateResourceEvaluationResultsResponse
         */
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

        /**
          * This example shows how to query the compliance evaluation result of the `23642660635396****` resource in the `ca-7f00626622af0041****` account group. The resource is a RAM user. The returned result indicates that the resource is evaluated as `NON_COMPLIANT` by using the `cr-7f7d626622af0041****` rule.
          *
          * @param request ListAggregateResourceEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateResourceEvaluationResultsResponse
         */
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

        /**
          * This example shows how to query the compliance evaluation result of the `23642660635396****` resource in the `ca-7f00626622af0041****` account group. The resource is a RAM user. The returned result indicates that the resource is evaluated as `NON_COMPLIANT` by using the `cr-7f7d626622af0041****` rule.
          *
          * @param request ListAggregateResourceEvaluationResultsRequest
          * @return ListAggregateResourceEvaluationResultsResponse
         */
        public ListAggregateResourceEvaluationResultsResponse ListAggregateResourceEvaluationResults(ListAggregateResourceEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateResourceEvaluationResultsWithOptions(request, runtime);
        }

        /**
          * This example shows how to query the compliance evaluation result of the `23642660635396****` resource in the `ca-7f00626622af0041****` account group. The resource is a RAM user. The returned result indicates that the resource is evaluated as `NON_COMPLIANT` by using the `cr-7f7d626622af0041****` rule.
          *
          * @param request ListAggregateResourceEvaluationResultsRequest
          * @return ListAggregateResourceEvaluationResultsResponse
         */
        public async Task<ListAggregateResourceEvaluationResultsResponse> ListAggregateResourceEvaluationResultsAsync(ListAggregateResourceEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateResourceEvaluationResultsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the disks that are associated with an Elastic Compute Service (ECS) instance in an account group.
          *
          * @param request ListAggregateResourceRelationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateResourceRelationsResponse
         */
        public ListAggregateResourceRelationsResponse ListAggregateResourceRelationsWithOptions(ListAggregateResourceRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["RelationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetResourceId))
            {
                query["TargetResourceId"] = request.TargetResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetResourceType))
            {
                query["TargetResourceType"] = request.TargetResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateResourceRelations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateResourceRelationsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the disks that are associated with an Elastic Compute Service (ECS) instance in an account group.
          *
          * @param request ListAggregateResourceRelationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregateResourceRelationsResponse
         */
        public async Task<ListAggregateResourceRelationsResponse> ListAggregateResourceRelationsWithOptionsAsync(ListAggregateResourceRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["RelationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetResourceId))
            {
                query["TargetResourceId"] = request.TargetResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetResourceType))
            {
                query["TargetResourceType"] = request.TargetResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateResourceRelations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateResourceRelationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the disks that are associated with an Elastic Compute Service (ECS) instance in an account group.
          *
          * @param request ListAggregateResourceRelationsRequest
          * @return ListAggregateResourceRelationsResponse
         */
        public ListAggregateResourceRelationsResponse ListAggregateResourceRelations(ListAggregateResourceRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateResourceRelationsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the disks that are associated with an Elastic Compute Service (ECS) instance in an account group.
          *
          * @param request ListAggregateResourceRelationsRequest
          * @return ListAggregateResourceRelationsResponse
         */
        public async Task<ListAggregateResourceRelationsResponse> ListAggregateResourceRelationsAsync(ListAggregateResourceRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateResourceRelationsWithOptionsAsync(request, runtime);
        }

        public ListAggregateResourcesByAdvancedSearchResponse ListAggregateResourcesByAdvancedSearchWithOptions(ListAggregateResourcesByAdvancedSearchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateResourcesByAdvancedSearch",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateResourcesByAdvancedSearchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAggregateResourcesByAdvancedSearchResponse> ListAggregateResourcesByAdvancedSearchWithOptionsAsync(ListAggregateResourcesByAdvancedSearchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggregateResourcesByAdvancedSearch",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregateResourcesByAdvancedSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAggregateResourcesByAdvancedSearchResponse ListAggregateResourcesByAdvancedSearch(ListAggregateResourcesByAdvancedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateResourcesByAdvancedSearchWithOptions(request, runtime);
        }

        public async Task<ListAggregateResourcesByAdvancedSearchResponse> ListAggregateResourcesByAdvancedSearchAsync(ListAggregateResourcesByAdvancedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateResourcesByAdvancedSearchWithOptionsAsync(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to query account groups. A maximum of 10 entries can be returned for the request. As shown in the responses, the account group returned is named as `Test_Group`, its description is `Test account group`, and it is of the `CUSTOM` type, which indicates a custom account group. The account group contains two member accounts.
          *
          * @param request ListAggregatorsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregatorsResponse
         */
        public ListAggregatorsResponse ListAggregatorsWithOptions(ListAggregatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregatorsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The sample request in this topic shows you how to query account groups. A maximum of 10 entries can be returned for the request. As shown in the responses, the account group returned is named as `Test_Group`, its description is `Test account group`, and it is of the `CUSTOM` type, which indicates a custom account group. The account group contains two member accounts.
          *
          * @param request ListAggregatorsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAggregatorsResponse
         */
        public async Task<ListAggregatorsResponse> ListAggregatorsWithOptionsAsync(ListAggregatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggregatorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The sample request in this topic shows you how to query account groups. A maximum of 10 entries can be returned for the request. As shown in the responses, the account group returned is named as `Test_Group`, its description is `Test account group`, and it is of the `CUSTOM` type, which indicates a custom account group. The account group contains two member accounts.
          *
          * @param request ListAggregatorsRequest
          * @return ListAggregatorsResponse
         */
        public ListAggregatorsResponse ListAggregators(ListAggregatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregatorsWithOptions(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to query account groups. A maximum of 10 entries can be returned for the request. As shown in the responses, the account group returned is named as `Test_Group`, its description is `Test account group`, and it is of the `CUSTOM` type, which indicates a custom account group. The account group contains two member accounts.
          *
          * @param request ListAggregatorsRequest
          * @return ListAggregatorsResponse
         */
        public async Task<ListAggregatorsResponse> ListAggregatorsAsync(ListAggregatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregatorsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the details of a compliance package template whose ID is `ct-d254ff4e06a300cf****`. The returned result indicates that the template name is `BestPracticesForNetwork`, the template ID is `ct-d254ff4e06a300cf****`, and the ID of the managed rule of the template is `slb-servercertificate-expired-check`.
          *
          * @param request ListCompliancePackTemplatesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListCompliancePackTemplatesResponse
         */
        public ListCompliancePackTemplatesResponse ListCompliancePackTemplatesWithOptions(ListCompliancePackTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackTemplateId))
            {
                query["CompliancePackTemplateId"] = request.CompliancePackTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCompliancePackTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the details of a compliance package template whose ID is `ct-d254ff4e06a300cf****`. The returned result indicates that the template name is `BestPracticesForNetwork`, the template ID is `ct-d254ff4e06a300cf****`, and the ID of the managed rule of the template is `slb-servercertificate-expired-check`.
          *
          * @param request ListCompliancePackTemplatesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListCompliancePackTemplatesResponse
         */
        public async Task<ListCompliancePackTemplatesResponse> ListCompliancePackTemplatesWithOptionsAsync(ListCompliancePackTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompliancePackTemplateId))
            {
                query["CompliancePackTemplateId"] = request.CompliancePackTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCompliancePackTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the details of a compliance package template whose ID is `ct-d254ff4e06a300cf****`. The returned result indicates that the template name is `BestPracticesForNetwork`, the template ID is `ct-d254ff4e06a300cf****`, and the ID of the managed rule of the template is `slb-servercertificate-expired-check`.
          *
          * @param request ListCompliancePackTemplatesRequest
          * @return ListCompliancePackTemplatesResponse
         */
        public ListCompliancePackTemplatesResponse ListCompliancePackTemplates(ListCompliancePackTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCompliancePackTemplatesWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the details of a compliance package template whose ID is `ct-d254ff4e06a300cf****`. The returned result indicates that the template name is `BestPracticesForNetwork`, the template ID is `ct-d254ff4e06a300cf****`, and the ID of the managed rule of the template is `slb-servercertificate-expired-check`.
          *
          * @param request ListCompliancePackTemplatesRequest
          * @return ListCompliancePackTemplatesResponse
         */
        public async Task<ListCompliancePackTemplatesResponse> ListCompliancePackTemplatesAsync(ListCompliancePackTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCompliancePackTemplatesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example of how to query compliance packages. The return result shows the details of the `cp-fdc8626622af00f9****` compliance package.
          *
          * @param request ListCompliancePacksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListCompliancePacksResponse
         */
        public ListCompliancePacksResponse ListCompliancePacksWithOptions(ListCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCompliancePacksResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example of how to query compliance packages. The return result shows the details of the `cp-fdc8626622af00f9****` compliance package.
          *
          * @param request ListCompliancePacksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListCompliancePacksResponse
         */
        public async Task<ListCompliancePacksResponse> ListCompliancePacksWithOptionsAsync(ListCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCompliancePacksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example of how to query compliance packages. The return result shows the details of the `cp-fdc8626622af00f9****` compliance package.
          *
          * @param request ListCompliancePacksRequest
          * @return ListCompliancePacksResponse
         */
        public ListCompliancePacksResponse ListCompliancePacks(ListCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCompliancePacksWithOptions(request, runtime);
        }

        /**
          * This topic provides an example of how to query compliance packages. The return result shows the details of the `cp-fdc8626622af00f9****` compliance package.
          *
          * @param request ListCompliancePacksRequest
          * @return ListCompliancePacksResponse
         */
        public async Task<ListCompliancePacksResponse> ListCompliancePacksAsync(ListCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCompliancePacksWithOptionsAsync(request, runtime);
        }

        public ListConfigDeliveryChannelsResponse ListConfigDeliveryChannelsWithOptions(ListConfigDeliveryChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelIds))
            {
                query["DeliveryChannelIds"] = request.DeliveryChannelIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigDeliveryChannels",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigDeliveryChannelsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListConfigDeliveryChannelsResponse> ListConfigDeliveryChannelsWithOptionsAsync(ListConfigDeliveryChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelIds))
            {
                query["DeliveryChannelIds"] = request.DeliveryChannelIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigDeliveryChannels",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigDeliveryChannelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListConfigDeliveryChannelsResponse ListConfigDeliveryChannels(ListConfigDeliveryChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConfigDeliveryChannelsWithOptions(request, runtime);
        }

        public async Task<ListConfigDeliveryChannelsResponse> ListConfigDeliveryChannelsAsync(ListConfigDeliveryChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConfigDeliveryChannelsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance evaluation result of resources based on a rule whose ID is `cr-cac56457e0d900d3****`. The returned result indicates that the `i-hp3e4kvhzqn2s11t****` resource is evaluated as `NON_COMPLIANT` by using the rule. The resource is an Elastic Compute Service (ECS) instance.
          *
          * @param request ListConfigRuleEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListConfigRuleEvaluationResultsResponse
         */
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

        /**
          * This topic provides an example on how to query the compliance evaluation result of resources based on a rule whose ID is `cr-cac56457e0d900d3****`. The returned result indicates that the `i-hp3e4kvhzqn2s11t****` resource is evaluated as `NON_COMPLIANT` by using the rule. The resource is an Elastic Compute Service (ECS) instance.
          *
          * @param request ListConfigRuleEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListConfigRuleEvaluationResultsResponse
         */
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

        /**
          * This topic provides an example on how to query the compliance evaluation result of resources based on a rule whose ID is `cr-cac56457e0d900d3****`. The returned result indicates that the `i-hp3e4kvhzqn2s11t****` resource is evaluated as `NON_COMPLIANT` by using the rule. The resource is an Elastic Compute Service (ECS) instance.
          *
          * @param request ListConfigRuleEvaluationResultsRequest
          * @return ListConfigRuleEvaluationResultsResponse
         */
        public ListConfigRuleEvaluationResultsResponse ListConfigRuleEvaluationResults(ListConfigRuleEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConfigRuleEvaluationResultsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the compliance evaluation result of resources based on a rule whose ID is `cr-cac56457e0d900d3****`. The returned result indicates that the `i-hp3e4kvhzqn2s11t****` resource is evaluated as `NON_COMPLIANT` by using the rule. The resource is an Elastic Compute Service (ECS) instance.
          *
          * @param request ListConfigRuleEvaluationResultsRequest
          * @return ListConfigRuleEvaluationResultsResponse
         */
        public async Task<ListConfigRuleEvaluationResultsResponse> ListConfigRuleEvaluationResultsAsync(ListConfigRuleEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConfigRuleEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public ListConfigRuleEvaluationStatisticsResponse ListConfigRuleEvaluationStatisticsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigRuleEvaluationStatistics",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigRuleEvaluationStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListConfigRuleEvaluationStatisticsResponse> ListConfigRuleEvaluationStatisticsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigRuleEvaluationStatistics",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigRuleEvaluationStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListConfigRuleEvaluationStatisticsResponse ListConfigRuleEvaluationStatistics()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConfigRuleEvaluationStatisticsWithOptions(runtime);
        }

        public async Task<ListConfigRuleEvaluationStatisticsResponse> ListConfigRuleEvaluationStatisticsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConfigRuleEvaluationStatisticsWithOptionsAsync(runtime);
        }

        /**
          * This topic provides an example on how to query the rules of the current account. The response shows that the current account has a total of one rule and three evaluated resources. The resources are evaluated as compliant.
          *
          * @param request ListConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListConfigRulesResponse
         */
        public ListConfigRulesResponse ListConfigRulesWithOptions(ListConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplianceType))
            {
                query["ComplianceType"] = request.ComplianceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleName))
            {
                query["ConfigRuleName"] = request.ConfigRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleState))
            {
                query["ConfigRuleState"] = request.ConfigRuleState;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
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
                Action = "ListConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the rules of the current account. The response shows that the current account has a total of one rule and three evaluated resources. The resources are evaluated as compliant.
          *
          * @param request ListConfigRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListConfigRulesResponse
         */
        public async Task<ListConfigRulesResponse> ListConfigRulesWithOptionsAsync(ListConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplianceType))
            {
                query["ComplianceType"] = request.ComplianceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleName))
            {
                query["ConfigRuleName"] = request.ConfigRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleState))
            {
                query["ConfigRuleState"] = request.ConfigRuleState;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
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
                Action = "ListConfigRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the rules of the current account. The response shows that the current account has a total of one rule and three evaluated resources. The resources are evaluated as compliant.
          *
          * @param request ListConfigRulesRequest
          * @return ListConfigRulesResponse
         */
        public ListConfigRulesResponse ListConfigRules(ListConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConfigRulesWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the rules of the current account. The response shows that the current account has a total of one rule and three evaluated resources. The resources are evaluated as compliant.
          *
          * @param request ListConfigRulesRequest
          * @return ListConfigRulesResponse
         */
        public async Task<ListConfigRulesResponse> ListConfigRulesAsync(ListConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConfigRulesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to call the ListDiscoveredResources operation to query the resources in the current Alibaba Cloud account. The returned result indicates that a total of eight resources exist in the account.
          *
          * @param request ListDiscoveredResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDiscoveredResourcesResponse
         */
        public ListDiscoveredResourcesResponse ListDiscoveredResourcesWithOptions(ListDiscoveredResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDeleted))
            {
                query["ResourceDeleted"] = request.ResourceDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDiscoveredResources",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDiscoveredResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to call the ListDiscoveredResources operation to query the resources in the current Alibaba Cloud account. The returned result indicates that a total of eight resources exist in the account.
          *
          * @param request ListDiscoveredResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDiscoveredResourcesResponse
         */
        public async Task<ListDiscoveredResourcesResponse> ListDiscoveredResourcesWithOptionsAsync(ListDiscoveredResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDeleted))
            {
                query["ResourceDeleted"] = request.ResourceDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDiscoveredResources",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDiscoveredResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to call the ListDiscoveredResources operation to query the resources in the current Alibaba Cloud account. The returned result indicates that a total of eight resources exist in the account.
          *
          * @param request ListDiscoveredResourcesRequest
          * @return ListDiscoveredResourcesResponse
         */
        public ListDiscoveredResourcesResponse ListDiscoveredResources(ListDiscoveredResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDiscoveredResourcesWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to call the ListDiscoveredResources operation to query the resources in the current Alibaba Cloud account. The returned result indicates that a total of eight resources exist in the account.
          *
          * @param request ListDiscoveredResourcesRequest
          * @return ListDiscoveredResourcesResponse
         */
        public async Task<ListDiscoveredResourcesResponse> ListDiscoveredResourcesAsync(ListDiscoveredResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDiscoveredResourcesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the cloud services that can be integrated by the current Alibaba Cloud account.
          *
          * @param request ListIntegratedServiceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListIntegratedServiceResponse
         */
        public ListIntegratedServiceResponse ListIntegratedServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegratedService",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegratedServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the cloud services that can be integrated by the current Alibaba Cloud account.
          *
          * @param request ListIntegratedServiceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListIntegratedServiceResponse
         */
        public async Task<ListIntegratedServiceResponse> ListIntegratedServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegratedService",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegratedServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the cloud services that can be integrated by the current Alibaba Cloud account.
          *
          * @return ListIntegratedServiceResponse
         */
        public ListIntegratedServiceResponse ListIntegratedService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIntegratedServiceWithOptions(runtime);
        }

        /**
          * This topic provides an example on how to query the cloud services that can be integrated by the current Alibaba Cloud account.
          *
          * @return ListIntegratedServiceResponse
         */
        public async Task<ListIntegratedServiceResponse> ListIntegratedServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIntegratedServiceWithOptionsAsync(runtime);
        }

        /**
          * This topic describes how to query the managed rules of Alibaba Cloud CDN by using the `CDN` keyword. The returned result shows that only one managed rule exists. You can view the rule details in the result.
          *
          * @param request ListManagedRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListManagedRulesResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
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

        /**
          * This topic describes how to query the managed rules of Alibaba Cloud CDN by using the `CDN` keyword. The returned result shows that only one managed rule exists. You can view the rule details in the result.
          *
          * @param request ListManagedRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListManagedRulesResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
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

        /**
          * This topic describes how to query the managed rules of Alibaba Cloud CDN by using the `CDN` keyword. The returned result shows that only one managed rule exists. You can view the rule details in the result.
          *
          * @param request ListManagedRulesRequest
          * @return ListManagedRulesResponse
         */
        public ListManagedRulesResponse ListManagedRules(ListManagedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListManagedRulesWithOptions(request, runtime);
        }

        /**
          * This topic describes how to query the managed rules of Alibaba Cloud CDN by using the `CDN` keyword. The returned result shows that only one managed rule exists. You can view the rule details in the result.
          *
          * @param request ListManagedRulesRequest
          * @return ListManagedRulesResponse
         */
        public async Task<ListManagedRulesResponse> ListManagedRulesAsync(ListManagedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListManagedRulesWithOptionsAsync(request, runtime);
        }

        public ListPreManagedRulesResponse ListPreManagedRulesWithOptions(ListPreManagedRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPreManagedRulesShrinkRequest request = new ListPreManagedRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypes))
            {
                request.ResourceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypes, "ResourceTypes", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypesShrink))
            {
                body["ResourceTypes"] = request.ResourceTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPreManagedRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPreManagedRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPreManagedRulesResponse> ListPreManagedRulesWithOptionsAsync(ListPreManagedRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPreManagedRulesShrinkRequest request = new ListPreManagedRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypes))
            {
                request.ResourceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypes, "ResourceTypes", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypesShrink))
            {
                body["ResourceTypes"] = request.ResourceTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPreManagedRules",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPreManagedRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPreManagedRulesResponse ListPreManagedRules(ListPreManagedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPreManagedRulesWithOptions(request, runtime);
        }

        public async Task<ListPreManagedRulesResponse> ListPreManagedRulesAsync(ListPreManagedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPreManagedRulesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the remediation records of the rule cr-5392626622af0000\\*\\*\\*\\*.
          *
          * @param request ListRemediationExecutionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRemediationExecutionsResponse
         */
        public ListRemediationExecutionsResponse ListRemediationExecutionsWithOptions(ListRemediationExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                query["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionStatus))
            {
                query["ExecutionStatus"] = request.ExecutionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRemediationExecutions",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRemediationExecutionsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the remediation records of the rule cr-5392626622af0000\\*\\*\\*\\*.
          *
          * @param request ListRemediationExecutionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRemediationExecutionsResponse
         */
        public async Task<ListRemediationExecutionsResponse> ListRemediationExecutionsWithOptionsAsync(ListRemediationExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleId))
            {
                query["ConfigRuleId"] = request.ConfigRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionStatus))
            {
                query["ExecutionStatus"] = request.ExecutionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRemediationExecutions",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRemediationExecutionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the remediation records of the rule cr-5392626622af0000\\*\\*\\*\\*.
          *
          * @param request ListRemediationExecutionsRequest
          * @return ListRemediationExecutionsResponse
         */
        public ListRemediationExecutionsResponse ListRemediationExecutions(ListRemediationExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRemediationExecutionsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the remediation records of the rule cr-5392626622af0000\\*\\*\\*\\*.
          *
          * @param request ListRemediationExecutionsRequest
          * @return ListRemediationExecutionsResponse
         */
        public async Task<ListRemediationExecutionsResponse> ListRemediationExecutionsAsync(ListRemediationExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRemediationExecutionsWithOptionsAsync(request, runtime);
        }

        /**
          * In this topic, the `oss-bucket-public-write-prohibited` managed rule is used as an example. The return result shows the details of the remediation template of the `OOS` type for the managed rule. OOS represents Operation Orchestration Service.
          *
          * @param request ListRemediationTemplatesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRemediationTemplatesResponse
         */
        public ListRemediationTemplatesResponse ListRemediationTemplatesWithOptions(ListRemediationTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagedRuleIdentifier))
            {
                query["ManagedRuleIdentifier"] = request.ManagedRuleIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationType))
            {
                query["RemediationType"] = request.RemediationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRemediationTemplates",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRemediationTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * In this topic, the `oss-bucket-public-write-prohibited` managed rule is used as an example. The return result shows the details of the remediation template of the `OOS` type for the managed rule. OOS represents Operation Orchestration Service.
          *
          * @param request ListRemediationTemplatesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRemediationTemplatesResponse
         */
        public async Task<ListRemediationTemplatesResponse> ListRemediationTemplatesWithOptionsAsync(ListRemediationTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagedRuleIdentifier))
            {
                query["ManagedRuleIdentifier"] = request.ManagedRuleIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationType))
            {
                query["RemediationType"] = request.RemediationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRemediationTemplates",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRemediationTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * In this topic, the `oss-bucket-public-write-prohibited` managed rule is used as an example. The return result shows the details of the remediation template of the `OOS` type for the managed rule. OOS represents Operation Orchestration Service.
          *
          * @param request ListRemediationTemplatesRequest
          * @return ListRemediationTemplatesResponse
         */
        public ListRemediationTemplatesResponse ListRemediationTemplates(ListRemediationTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRemediationTemplatesWithOptions(request, runtime);
        }

        /**
          * In this topic, the `oss-bucket-public-write-prohibited` managed rule is used as an example. The return result shows the details of the remediation template of the `OOS` type for the managed rule. OOS represents Operation Orchestration Service.
          *
          * @param request ListRemediationTemplatesRequest
          * @return ListRemediationTemplatesResponse
         */
        public async Task<ListRemediationTemplatesResponse> ListRemediationTemplatesAsync(ListRemediationTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRemediationTemplatesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the remediation templates for the rule whose ID is `cr-6b7c626622af00b4****`.
          *
          * @param request ListRemediationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRemediationsResponse
         */
        public ListRemediationsResponse ListRemediationsWithOptions(ListRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRemediations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRemediationsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the remediation templates for the rule whose ID is `cr-6b7c626622af00b4****`.
          *
          * @param request ListRemediationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRemediationsResponse
         */
        public async Task<ListRemediationsResponse> ListRemediationsWithOptionsAsync(ListRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigRuleIds))
            {
                query["ConfigRuleIds"] = request.ConfigRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRemediations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRemediationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the remediation templates for the rule whose ID is `cr-6b7c626622af00b4****`.
          *
          * @param request ListRemediationsRequest
          * @return ListRemediationsResponse
         */
        public ListRemediationsResponse ListRemediations(ListRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRemediationsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the remediation templates for the rule whose ID is `cr-6b7c626622af00b4****`.
          *
          * @param request ListRemediationsRequest
          * @return ListRemediationsResponse
         */
        public async Task<ListRemediationsResponse> ListRemediationsAsync(ListRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRemediationsWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the compliance evaluation result of the `23642660635396****` resource is queried and the resource is a RAM user. The returned result indicates that the resource is evaluated as `NON_COMPLIANT` by using the `cr-7f7d626622af0041****` rule.
          *
          * @param request ListResourceEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceEvaluationResultsResponse
         */
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

        /**
          * In this example, the compliance evaluation result of the `23642660635396****` resource is queried and the resource is a RAM user. The returned result indicates that the resource is evaluated as `NON_COMPLIANT` by using the `cr-7f7d626622af0041****` rule.
          *
          * @param request ListResourceEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceEvaluationResultsResponse
         */
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

        /**
          * In this example, the compliance evaluation result of the `23642660635396****` resource is queried and the resource is a RAM user. The returned result indicates that the resource is evaluated as `NON_COMPLIANT` by using the `cr-7f7d626622af0041****` rule.
          *
          * @param request ListResourceEvaluationResultsRequest
          * @return ListResourceEvaluationResultsResponse
         */
        public ListResourceEvaluationResultsResponse ListResourceEvaluationResults(ListResourceEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceEvaluationResultsWithOptions(request, runtime);
        }

        /**
          * In this example, the compliance evaluation result of the `23642660635396****` resource is queried and the resource is a RAM user. The returned result indicates that the resource is evaluated as `NON_COMPLIANT` by using the `cr-7f7d626622af0041****` rule.
          *
          * @param request ListResourceEvaluationResultsRequest
          * @return ListResourceEvaluationResultsResponse
         */
        public async Task<ListResourceEvaluationResultsResponse> ListResourceEvaluationResultsAsync(ListResourceEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceEvaluationResultsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the disks that are associated with an Elastic Compute Service (ECS) instance within the current Alibaba Cloud account.
          *
          * @param request ListResourceRelationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceRelationsResponse
         */
        public ListResourceRelationsResponse ListResourceRelationsWithOptions(ListResourceRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["RelationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetResourceId))
            {
                query["TargetResourceId"] = request.TargetResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetResourceType))
            {
                query["TargetResourceType"] = request.TargetResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceRelations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceRelationsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the disks that are associated with an Elastic Compute Service (ECS) instance within the current Alibaba Cloud account.
          *
          * @param request ListResourceRelationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceRelationsResponse
         */
        public async Task<ListResourceRelationsResponse> ListResourceRelationsWithOptionsAsync(ListResourceRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["RelationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetResourceId))
            {
                query["TargetResourceId"] = request.TargetResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetResourceType))
            {
                query["TargetResourceType"] = request.TargetResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceRelations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceRelationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the disks that are associated with an Elastic Compute Service (ECS) instance within the current Alibaba Cloud account.
          *
          * @param request ListResourceRelationsRequest
          * @return ListResourceRelationsResponse
         */
        public ListResourceRelationsResponse ListResourceRelations(ListResourceRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceRelationsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the disks that are associated with an Elastic Compute Service (ECS) instance within the current Alibaba Cloud account.
          *
          * @param request ListResourceRelationsRequest
          * @return ListResourceRelationsResponse
         */
        public async Task<ListResourceRelationsResponse> ListResourceRelationsAsync(ListResourceRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceRelationsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query all resources with the business tag key and the online tag value in the current Alibaba Cloud account.
          *
          * @param request ListResourcesByAdvancedSearchRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourcesByAdvancedSearchResponse
         */
        public ListResourcesByAdvancedSearchResponse ListResourcesByAdvancedSearchWithOptions(ListResourcesByAdvancedSearchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourcesByAdvancedSearch",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesByAdvancedSearchResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query all resources with the business tag key and the online tag value in the current Alibaba Cloud account.
          *
          * @param request ListResourcesByAdvancedSearchRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourcesByAdvancedSearchResponse
         */
        public async Task<ListResourcesByAdvancedSearchResponse> ListResourcesByAdvancedSearchWithOptionsAsync(ListResourcesByAdvancedSearchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourcesByAdvancedSearch",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesByAdvancedSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query all resources with the business tag key and the online tag value in the current Alibaba Cloud account.
          *
          * @param request ListResourcesByAdvancedSearchRequest
          * @return ListResourcesByAdvancedSearchResponse
         */
        public ListResourcesByAdvancedSearchResponse ListResourcesByAdvancedSearch(ListResourcesByAdvancedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourcesByAdvancedSearchWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query all resources with the business tag key and the online tag value in the current Alibaba Cloud account.
          *
          * @param request ListResourcesByAdvancedSearchRequest
          * @return ListResourcesByAdvancedSearchResponse
         */
        public async Task<ListResourcesByAdvancedSearchResponse> ListResourcesByAdvancedSearchAsync(ListResourcesByAdvancedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourcesByAdvancedSearchWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the cloud services and resource types that are supported by Cloud Config.
          *
          * @param request ListSupportedProductsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListSupportedProductsResponse
         */
        public ListSupportedProductsResponse ListSupportedProductsWithOptions(ListSupportedProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSupportedProducts",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSupportedProductsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the cloud services and resource types that are supported by Cloud Config.
          *
          * @param request ListSupportedProductsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListSupportedProductsResponse
         */
        public async Task<ListSupportedProductsResponse> ListSupportedProductsWithOptionsAsync(ListSupportedProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSupportedProducts",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSupportedProductsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the cloud services and resource types that are supported by Cloud Config.
          *
          * @param request ListSupportedProductsRequest
          * @return ListSupportedProductsResponse
         */
        public ListSupportedProductsResponse ListSupportedProducts(ListSupportedProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSupportedProductsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the cloud services and resource types that are supported by Cloud Config.
          *
          * @param request ListSupportedProductsRequest
          * @return ListSupportedProductsResponse
         */
        public async Task<ListSupportedProductsResponse> ListSupportedProductsAsync(ListSupportedProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSupportedProductsWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                body["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                body["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
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

        public PutEvaluationsResponse PutEvaluationsWithOptions(PutEvaluationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteMode))
            {
                body["DeleteMode"] = request.DeleteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Evaluations))
            {
                body["Evaluations"] = request.Evaluations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultToken))
            {
                body["ResultToken"] = request.ResultToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEvaluations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEvaluationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutEvaluationsResponse> PutEvaluationsWithOptionsAsync(PutEvaluationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteMode))
            {
                body["DeleteMode"] = request.DeleteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Evaluations))
            {
                body["Evaluations"] = request.Evaluations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultToken))
            {
                body["ResultToken"] = request.ResultToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEvaluations",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEvaluationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutEvaluationsResponse PutEvaluations(PutEvaluationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEvaluationsWithOptions(request, runtime);
        }

        public async Task<PutEvaluationsResponse> PutEvaluationsAsync(PutEvaluationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEvaluationsWithOptionsAsync(request, runtime);
        }

        /**
          * ### Prerequisites
          * One or more non-compliant resources that are evaluated based on a rule are ignored.
          * ### Usage notes
          * The sample request in this topic shows you how to re-evaluate the `lb-hp3a3b4ztyfm2plgm****` non-compliant resource that is evaluated by the `cr-7e72626622af0051***` rule in the `120886317861****` member account of the `ca-5b6c626622af008f****` account group. The ID of the region in which the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.
          *
          * @param tmpReq RevertAggregateEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RevertAggregateEvaluationResultsResponse
         */
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

        /**
          * ### Prerequisites
          * One or more non-compliant resources that are evaluated based on a rule are ignored.
          * ### Usage notes
          * The sample request in this topic shows you how to re-evaluate the `lb-hp3a3b4ztyfm2plgm****` non-compliant resource that is evaluated by the `cr-7e72626622af0051***` rule in the `120886317861****` member account of the `ca-5b6c626622af008f****` account group. The ID of the region in which the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.
          *
          * @param tmpReq RevertAggregateEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RevertAggregateEvaluationResultsResponse
         */
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

        /**
          * ### Prerequisites
          * One or more non-compliant resources that are evaluated based on a rule are ignored.
          * ### Usage notes
          * The sample request in this topic shows you how to re-evaluate the `lb-hp3a3b4ztyfm2plgm****` non-compliant resource that is evaluated by the `cr-7e72626622af0051***` rule in the `120886317861****` member account of the `ca-5b6c626622af008f****` account group. The ID of the region in which the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.
          *
          * @param request RevertAggregateEvaluationResultsRequest
          * @return RevertAggregateEvaluationResultsResponse
         */
        public RevertAggregateEvaluationResultsResponse RevertAggregateEvaluationResults(RevertAggregateEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevertAggregateEvaluationResultsWithOptions(request, runtime);
        }

        /**
          * ### Prerequisites
          * One or more non-compliant resources that are evaluated based on a rule are ignored.
          * ### Usage notes
          * The sample request in this topic shows you how to re-evaluate the `lb-hp3a3b4ztyfm2plgm****` non-compliant resource that is evaluated by the `cr-7e72626622af0051***` rule in the `120886317861****` member account of the `ca-5b6c626622af008f****` account group. The ID of the region in which the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.
          *
          * @param request RevertAggregateEvaluationResultsRequest
          * @return RevertAggregateEvaluationResultsResponse
         */
        public async Task<RevertAggregateEvaluationResultsResponse> RevertAggregateEvaluationResultsAsync(RevertAggregateEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevertAggregateEvaluationResultsWithOptionsAsync(request, runtime);
        }

        /**
          * ### Prerequisites
          * One or more non-compliant resources that are evaluated by a rule are ignored.
          * ### Usage notes
          * The sample request in this topic shows you how to re-evaluate the `lb-hp3a3b4ztyfm2plgm****` non-compliant resource that is evaluated by the `cr-7e72626622af0051****` rule. The ID of the region in which the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.``
          *
          * @param tmpReq RevertEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RevertEvaluationResultsResponse
         */
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

        /**
          * ### Prerequisites
          * One or more non-compliant resources that are evaluated by a rule are ignored.
          * ### Usage notes
          * The sample request in this topic shows you how to re-evaluate the `lb-hp3a3b4ztyfm2plgm****` non-compliant resource that is evaluated by the `cr-7e72626622af0051****` rule. The ID of the region in which the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.``
          *
          * @param tmpReq RevertEvaluationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RevertEvaluationResultsResponse
         */
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

        /**
          * ### Prerequisites
          * One or more non-compliant resources that are evaluated by a rule are ignored.
          * ### Usage notes
          * The sample request in this topic shows you how to re-evaluate the `lb-hp3a3b4ztyfm2plgm****` non-compliant resource that is evaluated by the `cr-7e72626622af0051****` rule. The ID of the region in which the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.``
          *
          * @param request RevertEvaluationResultsRequest
          * @return RevertEvaluationResultsResponse
         */
        public RevertEvaluationResultsResponse RevertEvaluationResults(RevertEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevertEvaluationResultsWithOptions(request, runtime);
        }

        /**
          * ### Prerequisites
          * One or more non-compliant resources that are evaluated by a rule are ignored.
          * ### Usage notes
          * The sample request in this topic shows you how to re-evaluate the `lb-hp3a3b4ztyfm2plgm****` non-compliant resource that is evaluated by the `cr-7e72626622af0051****` rule. The ID of the region in which the resource resides is `cn-beijing`, and the type of the resource is `ACS::SLB::LoadBalancer`.``
          *
          * @param request RevertEvaluationResultsRequest
          * @return RevertEvaluationResultsResponse
         */
        public async Task<RevertEvaluationResultsResponse> RevertEvaluationResultsAsync(RevertEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevertEvaluationResultsWithOptionsAsync(request, runtime);
        }

        /**
          * > After you call this operation, the compliance evaluation is performed only once. To query the compliance evaluation results returned by the rule, call the ListAggregateConfigRuleEvaluationResults operation. For more information, see [ListAggregateConfigRuleEvaluationResults](~~265979~~).
          * The sample request in this topic shows how to use the `cr-c169626622af009f****` rule in the `ca-3a58626622af0005****` account group to evaluate resources.
          *
          * @param request StartAggregateConfigRuleEvaluationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartAggregateConfigRuleEvaluationResponse
         */
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

        /**
          * > After you call this operation, the compliance evaluation is performed only once. To query the compliance evaluation results returned by the rule, call the ListAggregateConfigRuleEvaluationResults operation. For more information, see [ListAggregateConfigRuleEvaluationResults](~~265979~~).
          * The sample request in this topic shows how to use the `cr-c169626622af009f****` rule in the `ca-3a58626622af0005****` account group to evaluate resources.
          *
          * @param request StartAggregateConfigRuleEvaluationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartAggregateConfigRuleEvaluationResponse
         */
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

        /**
          * > After you call this operation, the compliance evaluation is performed only once. To query the compliance evaluation results returned by the rule, call the ListAggregateConfigRuleEvaluationResults operation. For more information, see [ListAggregateConfigRuleEvaluationResults](~~265979~~).
          * The sample request in this topic shows how to use the `cr-c169626622af009f****` rule in the `ca-3a58626622af0005****` account group to evaluate resources.
          *
          * @param request StartAggregateConfigRuleEvaluationRequest
          * @return StartAggregateConfigRuleEvaluationResponse
         */
        public StartAggregateConfigRuleEvaluationResponse StartAggregateConfigRuleEvaluation(StartAggregateConfigRuleEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartAggregateConfigRuleEvaluationWithOptions(request, runtime);
        }

        /**
          * > After you call this operation, the compliance evaluation is performed only once. To query the compliance evaluation results returned by the rule, call the ListAggregateConfigRuleEvaluationResults operation. For more information, see [ListAggregateConfigRuleEvaluationResults](~~265979~~).
          * The sample request in this topic shows how to use the `cr-c169626622af009f****` rule in the `ca-3a58626622af0005****` account group to evaluate resources.
          *
          * @param request StartAggregateConfigRuleEvaluationRequest
          * @return StartAggregateConfigRuleEvaluationResponse
         */
        public async Task<StartAggregateConfigRuleEvaluationResponse> StartAggregateConfigRuleEvaluationAsync(StartAggregateConfigRuleEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartAggregateConfigRuleEvaluationWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to manually perform a remediation operation by using the rule whose ID is `cr-6b7c626622af00b4****` in the account group whose ID is `ca-6b4a626622af0012****`. The return result shows that the manual execution is successful.
          *
          * @param request StartAggregateRemediationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartAggregateRemediationResponse
         */
        public StartAggregateRemediationResponse StartAggregateRemediationWithOptions(StartAggregateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAggregateRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAggregateRemediationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to manually perform a remediation operation by using the rule whose ID is `cr-6b7c626622af00b4****` in the account group whose ID is `ca-6b4a626622af0012****`. The return result shows that the manual execution is successful.
          *
          * @param request StartAggregateRemediationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartAggregateRemediationResponse
         */
        public async Task<StartAggregateRemediationResponse> StartAggregateRemediationWithOptionsAsync(StartAggregateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAccountId))
            {
                query["ResourceAccountId"] = request.ResourceAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAggregateRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAggregateRemediationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to manually perform a remediation operation by using the rule whose ID is `cr-6b7c626622af00b4****` in the account group whose ID is `ca-6b4a626622af0012****`. The return result shows that the manual execution is successful.
          *
          * @param request StartAggregateRemediationRequest
          * @return StartAggregateRemediationResponse
         */
        public StartAggregateRemediationResponse StartAggregateRemediation(StartAggregateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartAggregateRemediationWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to manually perform a remediation operation by using the rule whose ID is `cr-6b7c626622af00b4****` in the account group whose ID is `ca-6b4a626622af0012****`. The return result shows that the manual execution is successful.
          *
          * @param request StartAggregateRemediationRequest
          * @return StartAggregateRemediationResponse
         */
        public async Task<StartAggregateRemediationResponse> StartAggregateRemediationAsync(StartAggregateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartAggregateRemediationWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the cr-9920626622af0035\\*\\*\\*\\* rule is used to re-evaluate the compliance of resources.
          *
          * @param request StartConfigRuleEvaluationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartConfigRuleEvaluationResponse
         */
        public StartConfigRuleEvaluationResponse StartConfigRuleEvaluationWithOptions(StartConfigRuleEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "StartConfigRuleEvaluation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartConfigRuleEvaluationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * In this example, the cr-9920626622af0035\\*\\*\\*\\* rule is used to re-evaluate the compliance of resources.
          *
          * @param request StartConfigRuleEvaluationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartConfigRuleEvaluationResponse
         */
        public async Task<StartConfigRuleEvaluationResponse> StartConfigRuleEvaluationWithOptionsAsync(StartConfigRuleEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "StartConfigRuleEvaluation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartConfigRuleEvaluationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * In this example, the cr-9920626622af0035\\*\\*\\*\\* rule is used to re-evaluate the compliance of resources.
          *
          * @param request StartConfigRuleEvaluationRequest
          * @return StartConfigRuleEvaluationResponse
         */
        public StartConfigRuleEvaluationResponse StartConfigRuleEvaluation(StartConfigRuleEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartConfigRuleEvaluationWithOptions(request, runtime);
        }

        /**
          * In this example, the cr-9920626622af0035\\*\\*\\*\\* rule is used to re-evaluate the compliance of resources.
          *
          * @param request StartConfigRuleEvaluationRequest
          * @return StartConfigRuleEvaluationResponse
         */
        public async Task<StartConfigRuleEvaluationResponse> StartConfigRuleEvaluationAsync(StartConfigRuleEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartConfigRuleEvaluationWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to enable Cloud Config to monitor the resources of your Alibaba Cloud account.
          *
          * @param request StartConfigurationRecorderRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartConfigurationRecorderResponse
         */
        public StartConfigurationRecorderResponse StartConfigurationRecorderWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartConfigurationRecorder",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartConfigurationRecorderResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to enable Cloud Config to monitor the resources of your Alibaba Cloud account.
          *
          * @param request StartConfigurationRecorderRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartConfigurationRecorderResponse
         */
        public async Task<StartConfigurationRecorderResponse> StartConfigurationRecorderWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartConfigurationRecorder",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartConfigurationRecorderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to enable Cloud Config to monitor the resources of your Alibaba Cloud account.
          *
          * @return StartConfigurationRecorderResponse
         */
        public StartConfigurationRecorderResponse StartConfigurationRecorder()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartConfigurationRecorderWithOptions(runtime);
        }

        /**
          * This topic provides an example on how to enable Cloud Config to monitor the resources of your Alibaba Cloud account.
          *
          * @return StartConfigurationRecorderResponse
         */
        public async Task<StartConfigurationRecorderResponse> StartConfigurationRecorderAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartConfigurationRecorderWithOptionsAsync(runtime);
        }

        /**
          * This topic provides an example on how to perform a remediation operation by using the rule whose ID is `cr-8a973ac2e2be00a2****`. The returned result shows that the manual execution is successful.
          *
          * @param request StartRemediationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartRemediationResponse
         */
        public StartRemediationResponse StartRemediationWithOptions(StartRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StartRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRemediationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to perform a remediation operation by using the rule whose ID is `cr-8a973ac2e2be00a2****`. The returned result shows that the manual execution is successful.
          *
          * @param request StartRemediationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartRemediationResponse
         */
        public async Task<StartRemediationResponse> StartRemediationWithOptionsAsync(StartRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StartRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRemediationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to perform a remediation operation by using the rule whose ID is `cr-8a973ac2e2be00a2****`. The returned result shows that the manual execution is successful.
          *
          * @param request StartRemediationRequest
          * @return StartRemediationResponse
         */
        public StartRemediationResponse StartRemediation(StartRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRemediationWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to perform a remediation operation by using the rule whose ID is `cr-8a973ac2e2be00a2****`. The returned result shows that the manual execution is successful.
          *
          * @param request StartRemediationRequest
          * @return StartRemediationResponse
         */
        public async Task<StartRemediationResponse> StartRemediationAsync(StartRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRemediationWithOptionsAsync(request, runtime);
        }

        public StopConfigurationRecorderResponse StopConfigurationRecorderWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopConfigurationRecorder",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopConfigurationRecorderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopConfigurationRecorderResponse> StopConfigurationRecorderWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopConfigurationRecorder",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopConfigurationRecorderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopConfigurationRecorderResponse StopConfigurationRecorder()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopConfigurationRecorderWithOptions(runtime);
        }

        public async Task<StopConfigurationRecorderResponse> StopConfigurationRecorderAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopConfigurationRecorderWithOptionsAsync(runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TagResourcesShrinkRequest request = new TagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                body["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TagResourcesShrinkRequest request = new TagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                body["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                body["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                body["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
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

        /**
          * This topic provides an example on how to change the value of a parameter for a managed rule whose ID is `eip-bandwidth-limit` to `20`. The managed rule is included in the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****` account group.
          *
          * @param tmpReq UpdateAggregateCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAggregateCompliancePackResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
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

        /**
          * This topic provides an example on how to change the value of a parameter for a managed rule whose ID is `eip-bandwidth-limit` to `20`. The managed rule is included in the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****` account group.
          *
          * @param tmpReq UpdateAggregateCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAggregateCompliancePackResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
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

        /**
          * This topic provides an example on how to change the value of a parameter for a managed rule whose ID is `eip-bandwidth-limit` to `20`. The managed rule is included in the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****` account group.
          *
          * @param request UpdateAggregateCompliancePackRequest
          * @return UpdateAggregateCompliancePackResponse
         */
        public UpdateAggregateCompliancePackResponse UpdateAggregateCompliancePack(UpdateAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAggregateCompliancePackWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to change the value of a parameter for a managed rule whose ID is `eip-bandwidth-limit` to `20`. The managed rule is included in the `cp-fdc8626622af00f9****` compliance package in the `ca-f632626622af0079****` account group.
          *
          * @param request UpdateAggregateCompliancePackRequest
          * @return UpdateAggregateCompliancePackResponse
         */
        public async Task<UpdateAggregateCompliancePackResponse> UpdateAggregateCompliancePackAsync(UpdateAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAggregateCompliancePackWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to disable a delivery channel in an account group. The ID of the account group is `ca-a4e5626622af0079****`, and the ID of the delivery channel is `cdc-8e45ff4e06a3a8****`. The Status parameter is set to `0`. After the delivery channel is disabled, Cloud Config retains the most recent delivery configuration and stops resource data delivery.
          *
          * @param request UpdateAggregateConfigDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAggregateConfigDeliveryChannelResponse
         */
        public UpdateAggregateConfigDeliveryChannelResponse UpdateAggregateConfigDeliveryChannelWithOptions(UpdateAggregateConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationItemChangeNotification))
            {
                query["ConfigurationItemChangeNotification"] = request.ConfigurationItemChangeNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationSnapshot))
            {
                query["ConfigurationSnapshot"] = request.ConfigurationSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelCondition))
            {
                query["DeliveryChannelCondition"] = request.DeliveryChannelCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                query["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelName))
            {
                query["DeliveryChannelName"] = request.DeliveryChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelTargetArn))
            {
                query["DeliveryChannelTargetArn"] = request.DeliveryChannelTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverySnapshotTime))
            {
                query["DeliverySnapshotTime"] = request.DeliverySnapshotTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonCompliantNotification))
            {
                query["NonCompliantNotification"] = request.NonCompliantNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversizedDataOSSTargetArn))
            {
                query["OversizedDataOSSTargetArn"] = request.OversizedDataOSSTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAggregateConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggregateConfigDeliveryChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to disable a delivery channel in an account group. The ID of the account group is `ca-a4e5626622af0079****`, and the ID of the delivery channel is `cdc-8e45ff4e06a3a8****`. The Status parameter is set to `0`. After the delivery channel is disabled, Cloud Config retains the most recent delivery configuration and stops resource data delivery.
          *
          * @param request UpdateAggregateConfigDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAggregateConfigDeliveryChannelResponse
         */
        public async Task<UpdateAggregateConfigDeliveryChannelResponse> UpdateAggregateConfigDeliveryChannelWithOptionsAsync(UpdateAggregateConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                query["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationItemChangeNotification))
            {
                query["ConfigurationItemChangeNotification"] = request.ConfigurationItemChangeNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationSnapshot))
            {
                query["ConfigurationSnapshot"] = request.ConfigurationSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelCondition))
            {
                query["DeliveryChannelCondition"] = request.DeliveryChannelCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                query["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelName))
            {
                query["DeliveryChannelName"] = request.DeliveryChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelTargetArn))
            {
                query["DeliveryChannelTargetArn"] = request.DeliveryChannelTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverySnapshotTime))
            {
                query["DeliverySnapshotTime"] = request.DeliverySnapshotTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonCompliantNotification))
            {
                query["NonCompliantNotification"] = request.NonCompliantNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversizedDataOSSTargetArn))
            {
                query["OversizedDataOSSTargetArn"] = request.OversizedDataOSSTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAggregateConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggregateConfigDeliveryChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to disable a delivery channel in an account group. The ID of the account group is `ca-a4e5626622af0079****`, and the ID of the delivery channel is `cdc-8e45ff4e06a3a8****`. The Status parameter is set to `0`. After the delivery channel is disabled, Cloud Config retains the most recent delivery configuration and stops resource data delivery.
          *
          * @param request UpdateAggregateConfigDeliveryChannelRequest
          * @return UpdateAggregateConfigDeliveryChannelResponse
         */
        public UpdateAggregateConfigDeliveryChannelResponse UpdateAggregateConfigDeliveryChannel(UpdateAggregateConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAggregateConfigDeliveryChannelWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to disable a delivery channel in an account group. The ID of the account group is `ca-a4e5626622af0079****`, and the ID of the delivery channel is `cdc-8e45ff4e06a3a8****`. The Status parameter is set to `0`. After the delivery channel is disabled, Cloud Config retains the most recent delivery configuration and stops resource data delivery.
          *
          * @param request UpdateAggregateConfigDeliveryChannelRequest
          * @return UpdateAggregateConfigDeliveryChannelResponse
         */
        public async Task<UpdateAggregateConfigDeliveryChannelResponse> UpdateAggregateConfigDeliveryChannelAsync(UpdateAggregateConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAggregateConfigDeliveryChannelWithOptionsAsync(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to change the risk level specified for the `cr-4e3d626622af0080****` managed rule to `3`, which indicates low risk level, in the `ca-a4e5626622af0079****` account group.
          *
          * @param tmpReq UpdateAggregateConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAggregateConfigRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeAccountIdsScope))
            {
                body["ExcludeAccountIdsScope"] = request.ExcludeAccountIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeFolderIdsScope))
            {
                body["ExcludeFolderIdsScope"] = request.ExcludeFolderIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderIdsScope))
            {
                body["FolderIdsScope"] = request.FolderIdsScope;
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

        /**
          * The sample request in this topic shows you how to change the risk level specified for the `cr-4e3d626622af0080****` managed rule to `3`, which indicates low risk level, in the `ca-a4e5626622af0079****` account group.
          *
          * @param tmpReq UpdateAggregateConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAggregateConfigRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeAccountIdsScope))
            {
                body["ExcludeAccountIdsScope"] = request.ExcludeAccountIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeFolderIdsScope))
            {
                body["ExcludeFolderIdsScope"] = request.ExcludeFolderIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderIdsScope))
            {
                body["FolderIdsScope"] = request.FolderIdsScope;
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

        /**
          * The sample request in this topic shows you how to change the risk level specified for the `cr-4e3d626622af0080****` managed rule to `3`, which indicates low risk level, in the `ca-a4e5626622af0079****` account group.
          *
          * @param request UpdateAggregateConfigRuleRequest
          * @return UpdateAggregateConfigRuleResponse
         */
        public UpdateAggregateConfigRuleResponse UpdateAggregateConfigRule(UpdateAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAggregateConfigRuleWithOptions(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to change the risk level specified for the `cr-4e3d626622af0080****` managed rule to `3`, which indicates low risk level, in the `ca-a4e5626622af0079****` account group.
          *
          * @param request UpdateAggregateConfigRuleRequest
          * @return UpdateAggregateConfigRuleResponse
         */
        public async Task<UpdateAggregateConfigRuleResponse> UpdateAggregateConfigRuleAsync(UpdateAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAggregateConfigRuleWithOptionsAsync(request, runtime);
        }

        /**
          * This topic describes how to change the execution mode of the `crr-909ba2d4716700eb****` remediation setting for a rule in the `ca-6b4a626622af0012****` account group to `AUTO_EXECUTION`, which specifies automatic remediation. This topic also provides a sample request.
          *
          * @param request UpdateAggregateRemediationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAggregateRemediationResponse
         */
        public UpdateAggregateRemediationResponse UpdateAggregateRemediationWithOptions(UpdateAggregateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                body["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationId))
            {
                body["RemediationId"] = request.RemediationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationTemplateId))
            {
                body["RemediationTemplateId"] = request.RemediationTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationType))
            {
                body["RemediationType"] = request.RemediationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAggregateRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggregateRemediationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic describes how to change the execution mode of the `crr-909ba2d4716700eb****` remediation setting for a rule in the `ca-6b4a626622af0012****` account group to `AUTO_EXECUTION`, which specifies automatic remediation. This topic also provides a sample request.
          *
          * @param request UpdateAggregateRemediationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAggregateRemediationResponse
         */
        public async Task<UpdateAggregateRemediationResponse> UpdateAggregateRemediationWithOptionsAsync(UpdateAggregateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregatorId))
            {
                body["AggregatorId"] = request.AggregatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                body["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationId))
            {
                body["RemediationId"] = request.RemediationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationTemplateId))
            {
                body["RemediationTemplateId"] = request.RemediationTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationType))
            {
                body["RemediationType"] = request.RemediationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAggregateRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggregateRemediationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic describes how to change the execution mode of the `crr-909ba2d4716700eb****` remediation setting for a rule in the `ca-6b4a626622af0012****` account group to `AUTO_EXECUTION`, which specifies automatic remediation. This topic also provides a sample request.
          *
          * @param request UpdateAggregateRemediationRequest
          * @return UpdateAggregateRemediationResponse
         */
        public UpdateAggregateRemediationResponse UpdateAggregateRemediation(UpdateAggregateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAggregateRemediationWithOptions(request, runtime);
        }

        /**
          * This topic describes how to change the execution mode of the `crr-909ba2d4716700eb****` remediation setting for a rule in the `ca-6b4a626622af0012****` account group to `AUTO_EXECUTION`, which specifies automatic remediation. This topic also provides a sample request.
          *
          * @param request UpdateAggregateRemediationRequest
          * @return UpdateAggregateRemediationResponse
         */
        public async Task<UpdateAggregateRemediationResponse> UpdateAggregateRemediationAsync(UpdateAggregateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAggregateRemediationWithOptionsAsync(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to add a member account to the account group whose ID is `ca-dacf86d8314e00eb****`. The member account ID is `173808452267****` and the member account name is `Tony`. The member account belongs to `ResourceDirectory`.
          *
          * @param tmpReq UpdateAggregatorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAggregatorResponse
         */
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

        /**
          * The sample request in this topic shows you how to add a member account to the account group whose ID is `ca-dacf86d8314e00eb****`. The member account ID is `173808452267****` and the member account name is `Tony`. The member account belongs to `ResourceDirectory`.
          *
          * @param tmpReq UpdateAggregatorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAggregatorResponse
         */
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

        /**
          * The sample request in this topic shows you how to add a member account to the account group whose ID is `ca-dacf86d8314e00eb****`. The member account ID is `173808452267****` and the member account name is `Tony`. The member account belongs to `ResourceDirectory`.
          *
          * @param request UpdateAggregatorRequest
          * @return UpdateAggregatorResponse
         */
        public UpdateAggregatorResponse UpdateAggregator(UpdateAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAggregatorWithOptions(request, runtime);
        }

        /**
          * The sample request in this topic shows you how to add a member account to the account group whose ID is `ca-dacf86d8314e00eb****`. The member account ID is `173808452267****` and the member account name is `Tony`. The member account belongs to `ResourceDirectory`.
          *
          * @param request UpdateAggregatorRequest
          * @return UpdateAggregatorResponse
         */
        public async Task<UpdateAggregatorResponse> UpdateAggregatorAsync(UpdateAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAggregatorWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to change the value of a parameter for a managed rule whose ID is `eip-bandwidth-limit` to `20`. The managed rule is included in the `cp-a8a8626622af0082****` compliance package.
          *
          * @param tmpReq UpdateCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateCompliancePackResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
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

        /**
          * This topic provides an example on how to change the value of a parameter for a managed rule whose ID is `eip-bandwidth-limit` to `20`. The managed rule is included in the `cp-a8a8626622af0082****` compliance package.
          *
          * @param tmpReq UpdateCompliancePackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateCompliancePackResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeResourceIdsScope))
            {
                body["ExcludeResourceIdsScope"] = request.ExcludeResourceIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsScope))
            {
                body["RegionIdsScope"] = request.RegionIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdsScope))
            {
                body["ResourceGroupIdsScope"] = request.ResourceGroupIdsScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
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

        /**
          * This topic provides an example on how to change the value of a parameter for a managed rule whose ID is `eip-bandwidth-limit` to `20`. The managed rule is included in the `cp-a8a8626622af0082****` compliance package.
          *
          * @param request UpdateCompliancePackRequest
          * @return UpdateCompliancePackResponse
         */
        public UpdateCompliancePackResponse UpdateCompliancePack(UpdateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCompliancePackWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to change the value of a parameter for a managed rule whose ID is `eip-bandwidth-limit` to `20`. The managed rule is included in the `cp-a8a8626622af0082****` compliance package.
          *
          * @param request UpdateCompliancePackRequest
          * @return UpdateCompliancePackResponse
         */
        public async Task<UpdateCompliancePackResponse> UpdateCompliancePackAsync(UpdateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCompliancePackWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, a delivery channel is disabled. The ID of the delivery channel is `cdc-8e45ff4e06a3a8****```. The Status parameter is set to 0. After the delivery channel is disabled, Cloud Config retains the most recent delivery configuration and stops the delivery of resource data.
          *
          * @param request UpdateConfigDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateConfigDeliveryChannelResponse
         */
        public UpdateConfigDeliveryChannelResponse UpdateConfigDeliveryChannelWithOptions(UpdateConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationItemChangeNotification))
            {
                query["ConfigurationItemChangeNotification"] = request.ConfigurationItemChangeNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationSnapshot))
            {
                query["ConfigurationSnapshot"] = request.ConfigurationSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelCondition))
            {
                query["DeliveryChannelCondition"] = request.DeliveryChannelCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                query["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelName))
            {
                query["DeliveryChannelName"] = request.DeliveryChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelTargetArn))
            {
                query["DeliveryChannelTargetArn"] = request.DeliveryChannelTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverySnapshotTime))
            {
                query["DeliverySnapshotTime"] = request.DeliverySnapshotTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonCompliantNotification))
            {
                query["NonCompliantNotification"] = request.NonCompliantNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversizedDataOSSTargetArn))
            {
                query["OversizedDataOSSTargetArn"] = request.OversizedDataOSSTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigDeliveryChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
          * In this example, a delivery channel is disabled. The ID of the delivery channel is `cdc-8e45ff4e06a3a8****```. The Status parameter is set to 0. After the delivery channel is disabled, Cloud Config retains the most recent delivery configuration and stops the delivery of resource data.
          *
          * @param request UpdateConfigDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateConfigDeliveryChannelResponse
         */
        public async Task<UpdateConfigDeliveryChannelResponse> UpdateConfigDeliveryChannelWithOptionsAsync(UpdateConfigDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationItemChangeNotification))
            {
                query["ConfigurationItemChangeNotification"] = request.ConfigurationItemChangeNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationSnapshot))
            {
                query["ConfigurationSnapshot"] = request.ConfigurationSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelCondition))
            {
                query["DeliveryChannelCondition"] = request.DeliveryChannelCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                query["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelName))
            {
                query["DeliveryChannelName"] = request.DeliveryChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelTargetArn))
            {
                query["DeliveryChannelTargetArn"] = request.DeliveryChannelTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverySnapshotTime))
            {
                query["DeliverySnapshotTime"] = request.DeliverySnapshotTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonCompliantNotification))
            {
                query["NonCompliantNotification"] = request.NonCompliantNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversizedDataOSSTargetArn))
            {
                query["OversizedDataOSSTargetArn"] = request.OversizedDataOSSTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigDeliveryChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * In this example, a delivery channel is disabled. The ID of the delivery channel is `cdc-8e45ff4e06a3a8****```. The Status parameter is set to 0. After the delivery channel is disabled, Cloud Config retains the most recent delivery configuration and stops the delivery of resource data.
          *
          * @param request UpdateConfigDeliveryChannelRequest
          * @return UpdateConfigDeliveryChannelResponse
         */
        public UpdateConfigDeliveryChannelResponse UpdateConfigDeliveryChannel(UpdateConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConfigDeliveryChannelWithOptions(request, runtime);
        }

        /**
          * In this example, a delivery channel is disabled. The ID of the delivery channel is `cdc-8e45ff4e06a3a8****```. The Status parameter is set to 0. After the delivery channel is disabled, Cloud Config retains the most recent delivery configuration and stops the delivery of resource data.
          *
          * @param request UpdateConfigDeliveryChannelRequest
          * @return UpdateConfigDeliveryChannelResponse
         */
        public async Task<UpdateConfigDeliveryChannelResponse> UpdateConfigDeliveryChannelAsync(UpdateConfigDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConfigDeliveryChannelWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to change the risk level of a managed rule whose ID is `cr-a260626622af0005****` to `3` (low risk level).
          *
          * @param tmpReq UpdateConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateConfigRuleResponse
         */
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

        /**
          * This topic provides an example on how to change the risk level of a managed rule whose ID is `cr-a260626622af0005****` to `3` (low risk level).
          *
          * @param tmpReq UpdateConfigRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateConfigRuleResponse
         */
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

        /**
          * This topic provides an example on how to change the risk level of a managed rule whose ID is `cr-a260626622af0005****` to `3` (low risk level).
          *
          * @param request UpdateConfigRuleRequest
          * @return UpdateConfigRuleResponse
         */
        public UpdateConfigRuleResponse UpdateConfigRule(UpdateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConfigRuleWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to change the risk level of a managed rule whose ID is `cr-a260626622af0005****` to `3` (low risk level).
          *
          * @param request UpdateConfigRuleRequest
          * @return UpdateConfigRuleResponse
         */
        public async Task<UpdateConfigRuleResponse> UpdateConfigRuleAsync(UpdateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConfigRuleWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to change the resource monitoring scope of the current account to ACS::ECS::Instance.
          *
          * @param request UpdateConfigurationRecorderRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateConfigurationRecorderResponse
         */
        public UpdateConfigurationRecorderResponse UpdateConfigurationRecorderWithOptions(UpdateConfigurationRecorderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                body["ResourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigurationRecorder",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigurationRecorderResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to change the resource monitoring scope of the current account to ACS::ECS::Instance.
          *
          * @param request UpdateConfigurationRecorderRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateConfigurationRecorderResponse
         */
        public async Task<UpdateConfigurationRecorderResponse> UpdateConfigurationRecorderWithOptionsAsync(UpdateConfigurationRecorderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                body["ResourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigurationRecorder",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigurationRecorderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to change the resource monitoring scope of the current account to ACS::ECS::Instance.
          *
          * @param request UpdateConfigurationRecorderRequest
          * @return UpdateConfigurationRecorderResponse
         */
        public UpdateConfigurationRecorderResponse UpdateConfigurationRecorder(UpdateConfigurationRecorderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConfigurationRecorderWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to change the resource monitoring scope of the current account to ACS::ECS::Instance.
          *
          * @param request UpdateConfigurationRecorderRequest
          * @return UpdateConfigurationRecorderResponse
         */
        public async Task<UpdateConfigurationRecorderResponse> UpdateConfigurationRecorderAsync(UpdateConfigurationRecorderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConfigurationRecorderWithOptionsAsync(request, runtime);
        }

        /**
          * @deprecated : UpdateDeliveryChannel is deprecated, please use Config::2020-09-07::UpdateConfigDeliveryChannel,Config::2020-09-07::UpdateAggregateConfigDeliveryChannel instead.
          * This topic provides an example on how to change the status of the delivery channel whose ID is `cdc-8e45ff4e06a3a8****` to 0, which indicates that the delivery channel is disabled. After the delivery channel is disabled, Cloud Config retains the last delivery configuration and stops resource data delivery.
          *
          * @param request UpdateDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateDeliveryChannelResponse
         */
        // Deprecated
        public UpdateDeliveryChannelResponse UpdateDeliveryChannelWithOptions(UpdateDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationItemChangeNotification))
            {
                body["ConfigurationItemChangeNotification"] = request.ConfigurationItemChangeNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationSnapshot))
            {
                body["ConfigurationSnapshot"] = request.ConfigurationSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelAssumeRoleArn))
            {
                body["DeliveryChannelAssumeRoleArn"] = request.DeliveryChannelAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelCondition))
            {
                body["DeliveryChannelCondition"] = request.DeliveryChannelCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                body["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelName))
            {
                body["DeliveryChannelName"] = request.DeliveryChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelTargetArn))
            {
                body["DeliveryChannelTargetArn"] = request.DeliveryChannelTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonCompliantNotification))
            {
                body["NonCompliantNotification"] = request.NonCompliantNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversizedDataOSSTargetArn))
            {
                body["OversizedDataOSSTargetArn"] = request.OversizedDataOSSTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeliveryChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
          * @deprecated : UpdateDeliveryChannel is deprecated, please use Config::2020-09-07::UpdateConfigDeliveryChannel,Config::2020-09-07::UpdateAggregateConfigDeliveryChannel instead.
          * This topic provides an example on how to change the status of the delivery channel whose ID is `cdc-8e45ff4e06a3a8****` to 0, which indicates that the delivery channel is disabled. After the delivery channel is disabled, Cloud Config retains the last delivery configuration and stops resource data delivery.
          *
          * @param request UpdateDeliveryChannelRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateDeliveryChannelResponse
         */
        // Deprecated
        public async Task<UpdateDeliveryChannelResponse> UpdateDeliveryChannelWithOptionsAsync(UpdateDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationItemChangeNotification))
            {
                body["ConfigurationItemChangeNotification"] = request.ConfigurationItemChangeNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationSnapshot))
            {
                body["ConfigurationSnapshot"] = request.ConfigurationSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelAssumeRoleArn))
            {
                body["DeliveryChannelAssumeRoleArn"] = request.DeliveryChannelAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelCondition))
            {
                body["DeliveryChannelCondition"] = request.DeliveryChannelCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelId))
            {
                body["DeliveryChannelId"] = request.DeliveryChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelName))
            {
                body["DeliveryChannelName"] = request.DeliveryChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryChannelTargetArn))
            {
                body["DeliveryChannelTargetArn"] = request.DeliveryChannelTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonCompliantNotification))
            {
                body["NonCompliantNotification"] = request.NonCompliantNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversizedDataOSSTargetArn))
            {
                body["OversizedDataOSSTargetArn"] = request.OversizedDataOSSTargetArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeliveryChannel",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeliveryChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * @deprecated : UpdateDeliveryChannel is deprecated, please use Config::2020-09-07::UpdateConfigDeliveryChannel,Config::2020-09-07::UpdateAggregateConfigDeliveryChannel instead.
          * This topic provides an example on how to change the status of the delivery channel whose ID is `cdc-8e45ff4e06a3a8****` to 0, which indicates that the delivery channel is disabled. After the delivery channel is disabled, Cloud Config retains the last delivery configuration and stops resource data delivery.
          *
          * @param request UpdateDeliveryChannelRequest
          * @return UpdateDeliveryChannelResponse
         */
        // Deprecated
        public UpdateDeliveryChannelResponse UpdateDeliveryChannel(UpdateDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDeliveryChannelWithOptions(request, runtime);
        }

        /**
          * @deprecated : UpdateDeliveryChannel is deprecated, please use Config::2020-09-07::UpdateConfigDeliveryChannel,Config::2020-09-07::UpdateAggregateConfigDeliveryChannel instead.
          * This topic provides an example on how to change the status of the delivery channel whose ID is `cdc-8e45ff4e06a3a8****` to 0, which indicates that the delivery channel is disabled. After the delivery channel is disabled, Cloud Config retains the last delivery configuration and stops resource data delivery.
          *
          * @param request UpdateDeliveryChannelRequest
          * @return UpdateDeliveryChannelResponse
         */
        // Deprecated
        public async Task<UpdateDeliveryChannelResponse> UpdateDeliveryChannelAsync(UpdateDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDeliveryChannelWithOptionsAsync(request, runtime);
        }

        public UpdateIntegratedServiceStatusResponse UpdateIntegratedServiceStatusWithOptions(UpdateIntegratedServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratedTypes))
            {
                body["IntegratedTypes"] = request.IntegratedTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIntegratedServiceStatus",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIntegratedServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateIntegratedServiceStatusResponse> UpdateIntegratedServiceStatusWithOptionsAsync(UpdateIntegratedServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratedTypes))
            {
                body["IntegratedTypes"] = request.IntegratedTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIntegratedServiceStatus",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIntegratedServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateIntegratedServiceStatusResponse UpdateIntegratedServiceStatus(UpdateIntegratedServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIntegratedServiceStatusWithOptions(request, runtime);
        }

        public async Task<UpdateIntegratedServiceStatusResponse> UpdateIntegratedServiceStatusAsync(UpdateIntegratedServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIntegratedServiceStatusWithOptionsAsync(request, runtime);
        }

        /**
          * This topic describes how to change the execution mode of the `crr-909ba2d4716700eb****` remediation setting to `AUTO_EXECUTION`, which specifies automatic remediation. This topic also provides a sample request.
          *
          * @param request UpdateRemediationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateRemediationResponse
         */
        public UpdateRemediationResponse UpdateRemediationWithOptions(UpdateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                body["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationId))
            {
                body["RemediationId"] = request.RemediationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationTemplateId))
            {
                body["RemediationTemplateId"] = request.RemediationTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationType))
            {
                body["RemediationType"] = request.RemediationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRemediationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic describes how to change the execution mode of the `crr-909ba2d4716700eb****` remediation setting to `AUTO_EXECUTION`, which specifies automatic remediation. This topic also provides a sample request.
          *
          * @param request UpdateRemediationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateRemediationResponse
         */
        public async Task<UpdateRemediationResponse> UpdateRemediationWithOptionsAsync(UpdateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                body["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationId))
            {
                body["RemediationId"] = request.RemediationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationTemplateId))
            {
                body["RemediationTemplateId"] = request.RemediationTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemediationType))
            {
                body["RemediationType"] = request.RemediationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRemediation",
                Version = "2020-09-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRemediationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic describes how to change the execution mode of the `crr-909ba2d4716700eb****` remediation setting to `AUTO_EXECUTION`, which specifies automatic remediation. This topic also provides a sample request.
          *
          * @param request UpdateRemediationRequest
          * @return UpdateRemediationResponse
         */
        public UpdateRemediationResponse UpdateRemediation(UpdateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRemediationWithOptions(request, runtime);
        }

        /**
          * This topic describes how to change the execution mode of the `crr-909ba2d4716700eb****` remediation setting to `AUTO_EXECUTION`, which specifies automatic remediation. This topic also provides a sample request.
          *
          * @param request UpdateRemediationRequest
          * @return UpdateRemediationResponse
         */
        public async Task<UpdateRemediationResponse> UpdateRemediationAsync(UpdateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRemediationWithOptionsAsync(request, runtime);
        }

    }
}
