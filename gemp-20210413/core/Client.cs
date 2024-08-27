// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.GEMP20210413.Models;

namespace AlibabaCloud.SDK.GEMP20210413
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("gemp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 添加故障协同组
         *
         * @param request AddProblemServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddProblemServiceGroupResponse
         */
        public AddProblemServiceGroupResponse AddProblemServiceGroupWithOptions(AddProblemServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddProblemServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/addServiceGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddProblemServiceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加故障协同组
         *
         * @param request AddProblemServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddProblemServiceGroupResponse
         */
        public async Task<AddProblemServiceGroupResponse> AddProblemServiceGroupWithOptionsAsync(AddProblemServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddProblemServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/addServiceGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddProblemServiceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加故障协同组
         *
         * @param request AddProblemServiceGroupRequest
         * @return AddProblemServiceGroupResponse
         */
        public AddProblemServiceGroupResponse AddProblemServiceGroup(AddProblemServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddProblemServiceGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加故障协同组
         *
         * @param request AddProblemServiceGroupRequest
         * @return AddProblemServiceGroupResponse
         */
        public async Task<AddProblemServiceGroupResponse> AddProblemServiceGroupAsync(AddProblemServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddProblemServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 计费展示
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BillingStatisticsResponse
         */
        public BillingStatisticsResponse BillingStatisticsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BillingStatistics",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/charging/details",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BillingStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 计费展示
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BillingStatisticsResponse
         */
        public async Task<BillingStatisticsResponse> BillingStatisticsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BillingStatistics",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/charging/details",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BillingStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 计费展示
         *
         * @return BillingStatisticsResponse
         */
        public BillingStatisticsResponse BillingStatistics()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BillingStatisticsWithOptions(headers, runtime);
        }

        /**
         * @summary 计费展示
         *
         * @return BillingStatisticsResponse
         */
        public async Task<BillingStatisticsResponse> BillingStatisticsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BillingStatisticsWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 故障取消
         *
         * @param request CancelProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelProblemResponse
         */
        public CancelProblemResponse CancelProblemWithOptions(CancelProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelReason))
            {
                body["cancelReason"] = request.CancelReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelReasonDescription))
            {
                body["cancelReasonDescription"] = request.CancelReasonDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelProblemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 故障取消
         *
         * @param request CancelProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelProblemResponse
         */
        public async Task<CancelProblemResponse> CancelProblemWithOptionsAsync(CancelProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelReason))
            {
                body["cancelReason"] = request.CancelReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelReasonDescription))
            {
                body["cancelReasonDescription"] = request.CancelReasonDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelProblemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 故障取消
         *
         * @param request CancelProblemRequest
         * @return CancelProblemResponse
         */
        public CancelProblemResponse CancelProblem(CancelProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelProblemWithOptions(request, headers, runtime);
        }

        /**
         * @summary 故障取消
         *
         * @param request CancelProblemRequest
         * @return CancelProblemResponse
         */
        public async Task<CancelProblemResponse> CancelProblemAsync(CancelProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelProblemWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 校验webhook地址
         *
         * @param request CheckWebhookRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckWebhookResponse
         */
        public CheckWebhookResponse CheckWebhookWithOptions(CheckWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Webhook))
            {
                body["webhook"] = request.Webhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["webhookType"] = request.WebhookType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckWebhook",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/check/webhook",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckWebhookResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 校验webhook地址
         *
         * @param request CheckWebhookRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckWebhookResponse
         */
        public async Task<CheckWebhookResponse> CheckWebhookWithOptionsAsync(CheckWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Webhook))
            {
                body["webhook"] = request.Webhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["webhookType"] = request.WebhookType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckWebhook",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/check/webhook",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 校验webhook地址
         *
         * @param request CheckWebhookRequest
         * @return CheckWebhookResponse
         */
        public CheckWebhookResponse CheckWebhook(CheckWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckWebhookWithOptions(request, headers, runtime);
        }

        /**
         * @summary 校验webhook地址
         *
         * @param request CheckWebhookRequest
         * @return CheckWebhookResponse
         */
        public async Task<CheckWebhookResponse> CheckWebhookAsync(CheckWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckWebhookWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 确认集成配置
         *
         * @param request ConfirmIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmIntegrationConfigResponse
         */
        public ConfirmIntegrationConfigResponse ConfirmIntegrationConfigWithOptions(ConfirmIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/confirm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmIntegrationConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 确认集成配置
         *
         * @param request ConfirmIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmIntegrationConfigResponse
         */
        public async Task<ConfirmIntegrationConfigResponse> ConfirmIntegrationConfigWithOptionsAsync(ConfirmIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/confirm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmIntegrationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 确认集成配置
         *
         * @param request ConfirmIntegrationConfigRequest
         * @return ConfirmIntegrationConfigResponse
         */
        public ConfirmIntegrationConfigResponse ConfirmIntegrationConfig(ConfirmIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConfirmIntegrationConfigWithOptions(request, headers, runtime);
        }

        /**
         * @summary 确认集成配置
         *
         * @param request ConfirmIntegrationConfigRequest
         * @return ConfirmIntegrationConfigResponse
         */
        public async Task<ConfirmIntegrationConfigResponse> ConfirmIntegrationConfigAsync(ConfirmIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConfirmIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建升级计划
         *
         * @param request CreateEscalationPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEscalationPlanResponse
         */
        public CreateEscalationPlanResponse CreateEscalationPlanWithOptions(CreateEscalationPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanDescription))
            {
                body["escalationPlanDescription"] = request.EscalationPlanDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanName))
            {
                body["escalationPlanName"] = request.EscalationPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanRules))
            {
                body["escalationPlanRules"] = request.EscalationPlanRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanScopeObjects))
            {
                body["escalationPlanScopeObjects"] = request.EscalationPlanScopeObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGlobal))
            {
                body["isGlobal"] = request.IsGlobal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEscalationPlan",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEscalationPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建升级计划
         *
         * @param request CreateEscalationPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEscalationPlanResponse
         */
        public async Task<CreateEscalationPlanResponse> CreateEscalationPlanWithOptionsAsync(CreateEscalationPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanDescription))
            {
                body["escalationPlanDescription"] = request.EscalationPlanDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanName))
            {
                body["escalationPlanName"] = request.EscalationPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanRules))
            {
                body["escalationPlanRules"] = request.EscalationPlanRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanScopeObjects))
            {
                body["escalationPlanScopeObjects"] = request.EscalationPlanScopeObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGlobal))
            {
                body["isGlobal"] = request.IsGlobal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEscalationPlan",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEscalationPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建升级计划
         *
         * @param request CreateEscalationPlanRequest
         * @return CreateEscalationPlanResponse
         */
        public CreateEscalationPlanResponse CreateEscalationPlan(CreateEscalationPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEscalationPlanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建升级计划
         *
         * @param request CreateEscalationPlanRequest
         * @return CreateEscalationPlanResponse
         */
        public async Task<CreateEscalationPlanResponse> CreateEscalationPlanAsync(CreateEscalationPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEscalationPlanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 手动创建事件
         *
         * @param request CreateIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIncidentResponse
         */
        public CreateIncidentResponse CreateIncidentWithOptions(CreateIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignUserId))
            {
                body["assignUserId"] = request.AssignUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channels))
            {
                body["channels"] = request.Channels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentDescription))
            {
                body["incidentDescription"] = request.IncidentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentTitle))
            {
                body["incidentTitle"] = request.IncidentTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/manualSave",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIncidentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 手动创建事件
         *
         * @param request CreateIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIncidentResponse
         */
        public async Task<CreateIncidentResponse> CreateIncidentWithOptionsAsync(CreateIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignUserId))
            {
                body["assignUserId"] = request.AssignUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channels))
            {
                body["channels"] = request.Channels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentDescription))
            {
                body["incidentDescription"] = request.IncidentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentTitle))
            {
                body["incidentTitle"] = request.IncidentTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/manualSave",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIncidentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 手动创建事件
         *
         * @param request CreateIncidentRequest
         * @return CreateIncidentResponse
         */
        public CreateIncidentResponse CreateIncident(CreateIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIncidentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 手动创建事件
         *
         * @param request CreateIncidentRequest
         * @return CreateIncidentResponse
         */
        public async Task<CreateIncidentResponse> CreateIncidentAsync(CreateIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIncidentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 新增事件小计
         *
         * @param request CreateIncidentSubtotalRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIncidentSubtotalResponse
         */
        public CreateIncidentSubtotalResponse CreateIncidentSubtotalWithOptions(CreateIncidentSubtotalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIncidentSubtotal",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/save/subtotal",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIncidentSubtotalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 新增事件小计
         *
         * @param request CreateIncidentSubtotalRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIncidentSubtotalResponse
         */
        public async Task<CreateIncidentSubtotalResponse> CreateIncidentSubtotalWithOptionsAsync(CreateIncidentSubtotalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIncidentSubtotal",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/save/subtotal",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIncidentSubtotalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 新增事件小计
         *
         * @param request CreateIncidentSubtotalRequest
         * @return CreateIncidentSubtotalResponse
         */
        public CreateIncidentSubtotalResponse CreateIncidentSubtotal(CreateIncidentSubtotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIncidentSubtotalWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增事件小计
         *
         * @param request CreateIncidentSubtotalRequest
         * @return CreateIncidentSubtotalResponse
         */
        public async Task<CreateIncidentSubtotalResponse> CreateIncidentSubtotalAsync(CreateIncidentSubtotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIncidentSubtotalWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建集成配置
         *
         * @param request CreateIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIntegrationConfigResponse
         */
        public CreateIntegrationConfigResponse CreateIntegrationConfigWithOptions(CreateIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceId))
            {
                body["monitorSourceId"] = request.MonitorSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntegrationConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建集成配置
         *
         * @param request CreateIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIntegrationConfigResponse
         */
        public async Task<CreateIntegrationConfigResponse> CreateIntegrationConfigWithOptionsAsync(CreateIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceId))
            {
                body["monitorSourceId"] = request.MonitorSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntegrationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建集成配置
         *
         * @param request CreateIntegrationConfigRequest
         * @return CreateIntegrationConfigResponse
         */
        public CreateIntegrationConfigResponse CreateIntegrationConfig(CreateIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIntegrationConfigWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建集成配置
         *
         * @param request CreateIntegrationConfigRequest
         * @return CreateIntegrationConfigResponse
         */
        public async Task<CreateIntegrationConfigResponse> CreateIntegrationConfigAsync(CreateIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 故障升级
         *
         * @param request CreateProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProblemResponse
         */
        public CreateProblemResponse CreateProblemWithOptions(CreateProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AffectServiceIds))
            {
                body["affectServiceIds"] = request.AffectServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoverTime))
            {
                body["discoverTime"] = request.DiscoverTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainHandlerId))
            {
                body["mainHandlerId"] = request.MainHandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreliminaryReason))
            {
                body["preliminaryReason"] = request.PreliminaryReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevel))
            {
                body["problemLevel"] = request.ProblemLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemName))
            {
                body["problemName"] = request.ProblemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemStatus))
            {
                body["problemStatus"] = request.ProblemStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressSummary))
            {
                body["progressSummary"] = request.ProgressSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressSummaryRichTextId))
            {
                body["progressSummaryRichTextId"] = request.ProgressSummaryRichTextId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryTime))
            {
                body["recoveryTime"] = request.RecoveryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProblemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 故障升级
         *
         * @param request CreateProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProblemResponse
         */
        public async Task<CreateProblemResponse> CreateProblemWithOptionsAsync(CreateProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AffectServiceIds))
            {
                body["affectServiceIds"] = request.AffectServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoverTime))
            {
                body["discoverTime"] = request.DiscoverTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainHandlerId))
            {
                body["mainHandlerId"] = request.MainHandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreliminaryReason))
            {
                body["preliminaryReason"] = request.PreliminaryReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevel))
            {
                body["problemLevel"] = request.ProblemLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemName))
            {
                body["problemName"] = request.ProblemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemStatus))
            {
                body["problemStatus"] = request.ProblemStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressSummary))
            {
                body["progressSummary"] = request.ProgressSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressSummaryRichTextId))
            {
                body["progressSummaryRichTextId"] = request.ProgressSummaryRichTextId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryTime))
            {
                body["recoveryTime"] = request.RecoveryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProblemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 故障升级
         *
         * @param request CreateProblemRequest
         * @return CreateProblemResponse
         */
        public CreateProblemResponse CreateProblem(CreateProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProblemWithOptions(request, headers, runtime);
        }

        /**
         * @summary 故障升级
         *
         * @param request CreateProblemRequest
         * @return CreateProblemResponse
         */
        public async Task<CreateProblemResponse> CreateProblemAsync(CreateProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProblemWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建影响服务
         *
         * @param request CreateProblemEffectionServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProblemEffectionServiceResponse
         */
        public CreateProblemEffectionServiceResponse CreateProblemEffectionServiceWithOptions(CreateProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureUrl))
            {
                body["pictureUrl"] = request.PictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProblemEffectionService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/effectionService/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProblemEffectionServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建影响服务
         *
         * @param request CreateProblemEffectionServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProblemEffectionServiceResponse
         */
        public async Task<CreateProblemEffectionServiceResponse> CreateProblemEffectionServiceWithOptionsAsync(CreateProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureUrl))
            {
                body["pictureUrl"] = request.PictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProblemEffectionService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/effectionService/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProblemEffectionServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建影响服务
         *
         * @param request CreateProblemEffectionServiceRequest
         * @return CreateProblemEffectionServiceResponse
         */
        public CreateProblemEffectionServiceResponse CreateProblemEffectionService(CreateProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProblemEffectionServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建影响服务
         *
         * @param request CreateProblemEffectionServiceRequest
         * @return CreateProblemEffectionServiceResponse
         */
        public async Task<CreateProblemEffectionServiceResponse> CreateProblemEffectionServiceAsync(CreateProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProblemEffectionServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 改进措施新增
         *
         * @param request CreateProblemMeasureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProblemMeasureResponse
         */
        public CreateProblemMeasureResponse CreateProblemMeasureWithOptions(CreateProblemMeasureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStandard))
            {
                body["checkStandard"] = request.CheckStandard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUserId))
            {
                body["checkUserId"] = request.CheckUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectorId))
            {
                body["directorId"] = request.DirectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanFinishTime))
            {
                body["planFinishTime"] = request.PlanFinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StalkerId))
            {
                body["stalkerId"] = request.StalkerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProblemMeasure",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/improvement/measure/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProblemMeasureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 改进措施新增
         *
         * @param request CreateProblemMeasureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProblemMeasureResponse
         */
        public async Task<CreateProblemMeasureResponse> CreateProblemMeasureWithOptionsAsync(CreateProblemMeasureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStandard))
            {
                body["checkStandard"] = request.CheckStandard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUserId))
            {
                body["checkUserId"] = request.CheckUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectorId))
            {
                body["directorId"] = request.DirectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanFinishTime))
            {
                body["planFinishTime"] = request.PlanFinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StalkerId))
            {
                body["stalkerId"] = request.StalkerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProblemMeasure",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/improvement/measure/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProblemMeasureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 改进措施新增
         *
         * @param request CreateProblemMeasureRequest
         * @return CreateProblemMeasureResponse
         */
        public CreateProblemMeasureResponse CreateProblemMeasure(CreateProblemMeasureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProblemMeasureWithOptions(request, headers, runtime);
        }

        /**
         * @summary 改进措施新增
         *
         * @param request CreateProblemMeasureRequest
         * @return CreateProblemMeasureResponse
         */
        public async Task<CreateProblemMeasureResponse> CreateProblemMeasureAsync(CreateProblemMeasureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProblemMeasureWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 故障新增备注小计
         *
         * @param request CreateProblemSubtotalRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProblemSubtotalResponse
         */
        public CreateProblemSubtotalResponse CreateProblemSubtotalWithOptions(CreateProblemSubtotalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProblemSubtotal",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/save/subtotal",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProblemSubtotalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 故障新增备注小计
         *
         * @param request CreateProblemSubtotalRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProblemSubtotalResponse
         */
        public async Task<CreateProblemSubtotalResponse> CreateProblemSubtotalWithOptionsAsync(CreateProblemSubtotalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProblemSubtotal",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/save/subtotal",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProblemSubtotalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 故障新增备注小计
         *
         * @param request CreateProblemSubtotalRequest
         * @return CreateProblemSubtotalResponse
         */
        public CreateProblemSubtotalResponse CreateProblemSubtotal(CreateProblemSubtotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProblemSubtotalWithOptions(request, headers, runtime);
        }

        /**
         * @summary 故障新增备注小计
         *
         * @param request CreateProblemSubtotalRequest
         * @return CreateProblemSubtotalResponse
         */
        public async Task<CreateProblemSubtotalResponse> CreateProblemSubtotalAsync(CreateProblemSubtotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProblemSubtotalWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建故障时间线节点
         *
         * @param request CreateProblemTimelineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProblemTimelineResponse
         */
        public CreateProblemTimelineResponse CreateProblemTimelineWithOptions(CreateProblemTimelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyNode))
            {
                body["keyNode"] = request.KeyNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                body["time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProblemTimeline",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/timeline/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProblemTimelineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建故障时间线节点
         *
         * @param request CreateProblemTimelineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProblemTimelineResponse
         */
        public async Task<CreateProblemTimelineResponse> CreateProblemTimelineWithOptionsAsync(CreateProblemTimelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyNode))
            {
                body["keyNode"] = request.KeyNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                body["time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProblemTimeline",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/timeline/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProblemTimelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建故障时间线节点
         *
         * @param request CreateProblemTimelineRequest
         * @return CreateProblemTimelineResponse
         */
        public CreateProblemTimelineResponse CreateProblemTimeline(CreateProblemTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProblemTimelineWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建故障时间线节点
         *
         * @param request CreateProblemTimelineRequest
         * @return CreateProblemTimelineResponse
         */
        public async Task<CreateProblemTimelineResponse> CreateProblemTimelineAsync(CreateProblemTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProblemTimelineWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量创建故障时间线节点
         *
         * @param request CreateProblemTimelinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProblemTimelinesResponse
         */
        public CreateProblemTimelinesResponse CreateProblemTimelinesWithOptions(CreateProblemTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimelineNodes))
            {
                body["timelineNodes"] = request.TimelineNodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProblemTimelines",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/timeline/batchCreate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProblemTimelinesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量创建故障时间线节点
         *
         * @param request CreateProblemTimelinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProblemTimelinesResponse
         */
        public async Task<CreateProblemTimelinesResponse> CreateProblemTimelinesWithOptionsAsync(CreateProblemTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimelineNodes))
            {
                body["timelineNodes"] = request.TimelineNodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProblemTimelines",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/timeline/batchCreate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProblemTimelinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量创建故障时间线节点
         *
         * @param request CreateProblemTimelinesRequest
         * @return CreateProblemTimelinesResponse
         */
        public CreateProblemTimelinesResponse CreateProblemTimelines(CreateProblemTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProblemTimelinesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量创建故障时间线节点
         *
         * @param request CreateProblemTimelinesRequest
         * @return CreateProblemTimelinesResponse
         */
        public async Task<CreateProblemTimelinesResponse> CreateProblemTimelinesAsync(CreateProblemTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProblemTimelinesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建富文本
         *
         * @param request CreateRichTextRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRichTextResponse
         */
        public CreateRichTextResponse CreateRichTextWithOptions(CreateRichTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichText))
            {
                body["richText"] = request.RichText;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRichText",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/rich/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRichTextResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建富文本
         *
         * @param request CreateRichTextRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRichTextResponse
         */
        public async Task<CreateRichTextResponse> CreateRichTextWithOptionsAsync(CreateRichTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichText))
            {
                body["richText"] = request.RichText;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRichText",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/rich/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRichTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建富文本
         *
         * @param request CreateRichTextRequest
         * @return CreateRichTextResponse
         */
        public CreateRichTextResponse CreateRichText(CreateRichTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRichTextWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建富文本
         *
         * @param request CreateRichTextRequest
         * @return CreateRichTextResponse
         */
        public async Task<CreateRichTextResponse> CreateRichTextAsync(CreateRichTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRichTextWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建流转规则
         *
         * @param request CreateRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRouteRuleResponse
         */
        public CreateRouteRuleResponse CreateRouteRuleWithOptions(CreateRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectId))
            {
                body["assignObjectId"] = request.AssignObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectType))
            {
                body["assignObjectType"] = request.AssignObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildRuleRelation))
            {
                body["childRuleRelation"] = request.ChildRuleRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConvergenceFields))
            {
                body["convergenceFields"] = request.ConvergenceFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConvergenceType))
            {
                body["convergenceType"] = request.ConvergenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverageProblemLevels))
            {
                body["coverageProblemLevels"] = request.CoverageProblemLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effection))
            {
                body["effection"] = request.Effection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStatus))
            {
                body["enableStatus"] = request.EnableStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchCount))
            {
                body["matchCount"] = request.MatchCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyChannels))
            {
                body["notifyChannels"] = request.NotifyChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemEffectionServices))
            {
                body["problemEffectionServices"] = request.ProblemEffectionServices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevelGroup))
            {
                body["problemLevelGroup"] = request.ProblemLevelGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteChildRules))
            {
                body["routeChildRules"] = request.RouteChildRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["routeType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindow))
            {
                body["timeWindow"] = request.TimeWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindowUnit))
            {
                body["timeWindowUnit"] = request.TimeWindowUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRouteRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建流转规则
         *
         * @param request CreateRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRouteRuleResponse
         */
        public async Task<CreateRouteRuleResponse> CreateRouteRuleWithOptionsAsync(CreateRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectId))
            {
                body["assignObjectId"] = request.AssignObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectType))
            {
                body["assignObjectType"] = request.AssignObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildRuleRelation))
            {
                body["childRuleRelation"] = request.ChildRuleRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConvergenceFields))
            {
                body["convergenceFields"] = request.ConvergenceFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConvergenceType))
            {
                body["convergenceType"] = request.ConvergenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverageProblemLevels))
            {
                body["coverageProblemLevels"] = request.CoverageProblemLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effection))
            {
                body["effection"] = request.Effection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStatus))
            {
                body["enableStatus"] = request.EnableStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchCount))
            {
                body["matchCount"] = request.MatchCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyChannels))
            {
                body["notifyChannels"] = request.NotifyChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemEffectionServices))
            {
                body["problemEffectionServices"] = request.ProblemEffectionServices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevelGroup))
            {
                body["problemLevelGroup"] = request.ProblemLevelGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteChildRules))
            {
                body["routeChildRules"] = request.RouteChildRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["routeType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindow))
            {
                body["timeWindow"] = request.TimeWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindowUnit))
            {
                body["timeWindowUnit"] = request.TimeWindowUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRouteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建流转规则
         *
         * @param request CreateRouteRuleRequest
         * @return CreateRouteRuleResponse
         */
        public CreateRouteRuleResponse CreateRouteRule(CreateRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRouteRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建流转规则
         *
         * @param request CreateRouteRuleRequest
         * @return CreateRouteRuleResponse
         */
        public async Task<CreateRouteRuleResponse> CreateRouteRuleAsync(CreateRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRouteRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建服务
         *
         * @param request CreateServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceResponse
         */
        public CreateServiceResponse CreateServiceWithOptions(CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                body["serviceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIdList))
            {
                body["serviceGroupIdList"] = request.ServiceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建服务
         *
         * @param request CreateServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceResponse
         */
        public async Task<CreateServiceResponse> CreateServiceWithOptionsAsync(CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                body["serviceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIdList))
            {
                body["serviceGroupIdList"] = request.ServiceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建服务
         *
         * @param request CreateServiceRequest
         * @return CreateServiceResponse
         */
        public CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建服务
         *
         * @param request CreateServiceRequest
         * @return CreateServiceResponse
         */
        public async Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建服务组
         *
         * @param request CreateServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceGroupResponse
         */
        public CreateServiceGroupResponse CreateServiceGroupWithOptions(CreateServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWebhook))
            {
                body["enableWebhook"] = request.EnableWebhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceTemplates))
            {
                body["monitorSourceTemplates"] = request.MonitorSourceTemplates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupDescription))
            {
                body["serviceGroupDescription"] = request.ServiceGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupName))
            {
                body["serviceGroupName"] = request.ServiceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookLink))
            {
                body["webhookLink"] = request.WebhookLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["webhookType"] = request.WebhookType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/insert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建服务组
         *
         * @param request CreateServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceGroupResponse
         */
        public async Task<CreateServiceGroupResponse> CreateServiceGroupWithOptionsAsync(CreateServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWebhook))
            {
                body["enableWebhook"] = request.EnableWebhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceTemplates))
            {
                body["monitorSourceTemplates"] = request.MonitorSourceTemplates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupDescription))
            {
                body["serviceGroupDescription"] = request.ServiceGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupName))
            {
                body["serviceGroupName"] = request.ServiceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookLink))
            {
                body["webhookLink"] = request.WebhookLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["webhookType"] = request.WebhookType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/insert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建服务组
         *
         * @param request CreateServiceGroupRequest
         * @return CreateServiceGroupResponse
         */
        public CreateServiceGroupResponse CreateServiceGroup(CreateServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建服务组
         *
         * @param request CreateServiceGroupRequest
         * @return CreateServiceGroupResponse
         */
        public async Task<CreateServiceGroupResponse> CreateServiceGroupAsync(CreateServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 新增服务组排班
         *
         * @param request CreateServiceGroupSchedulingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceGroupSchedulingResponse
         */
        public CreateServiceGroupSchedulingResponse CreateServiceGroupSchedulingWithOptions(CreateServiceGroupSchedulingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastScheduling))
            {
                body["fastScheduling"] = request.FastScheduling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FineScheduling))
            {
                body["fineScheduling"] = request.FineScheduling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulingWay))
            {
                body["schedulingWay"] = request.SchedulingWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceGroupScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceGroupSchedulingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 新增服务组排班
         *
         * @param request CreateServiceGroupSchedulingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceGroupSchedulingResponse
         */
        public async Task<CreateServiceGroupSchedulingResponse> CreateServiceGroupSchedulingWithOptionsAsync(CreateServiceGroupSchedulingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastScheduling))
            {
                body["fastScheduling"] = request.FastScheduling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FineScheduling))
            {
                body["fineScheduling"] = request.FineScheduling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulingWay))
            {
                body["schedulingWay"] = request.SchedulingWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceGroupScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceGroupSchedulingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 新增服务组排班
         *
         * @param request CreateServiceGroupSchedulingRequest
         * @return CreateServiceGroupSchedulingResponse
         */
        public CreateServiceGroupSchedulingResponse CreateServiceGroupScheduling(CreateServiceGroupSchedulingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceGroupSchedulingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增服务组排班
         *
         * @param request CreateServiceGroupSchedulingRequest
         * @return CreateServiceGroupSchedulingResponse
         */
        public async Task<CreateServiceGroupSchedulingResponse> CreateServiceGroupSchedulingAsync(CreateServiceGroupSchedulingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceGroupSchedulingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建通知订阅
         *
         * @param request CreateSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSubscriptionResponse
         */
        public CreateSubscriptionResponse CreateSubscriptionWithOptions(CreateSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredType))
            {
                body["expiredType"] = request.ExpiredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectList))
            {
                body["notifyObjectList"] = request.NotifyObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectType))
            {
                body["notifyObjectType"] = request.NotifyObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStrategyList))
            {
                body["notifyStrategyList"] = request.NotifyStrategyList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeObjectList))
            {
                body["scopeObjectList"] = request.ScopeObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionTitle))
            {
                body["subscriptionTitle"] = request.SubscriptionTitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubscription",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建通知订阅
         *
         * @param request CreateSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSubscriptionResponse
         */
        public async Task<CreateSubscriptionResponse> CreateSubscriptionWithOptionsAsync(CreateSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredType))
            {
                body["expiredType"] = request.ExpiredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectList))
            {
                body["notifyObjectList"] = request.NotifyObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectType))
            {
                body["notifyObjectType"] = request.NotifyObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStrategyList))
            {
                body["notifyStrategyList"] = request.NotifyStrategyList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeObjectList))
            {
                body["scopeObjectList"] = request.ScopeObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionTitle))
            {
                body["subscriptionTitle"] = request.SubscriptionTitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubscription",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建通知订阅
         *
         * @param request CreateSubscriptionRequest
         * @return CreateSubscriptionResponse
         */
        public CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSubscriptionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建通知订阅
         *
         * @param request CreateSubscriptionRequest
         * @return CreateSubscriptionResponse
         */
        public async Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSubscriptionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 云钉协同创建移动应用
         *
         * @param request CreateTenantApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTenantApplicationResponse
         */
        public CreateTenantApplicationResponse CreateTenantApplicationWithOptions(CreateTenantApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantApplication",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/mobileApp/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantApplicationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 云钉协同创建移动应用
         *
         * @param request CreateTenantApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTenantApplicationResponse
         */
        public async Task<CreateTenantApplicationResponse> CreateTenantApplicationWithOptionsAsync(CreateTenantApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantApplication",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/mobileApp/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 云钉协同创建移动应用
         *
         * @param request CreateTenantApplicationRequest
         * @return CreateTenantApplicationResponse
         */
        public CreateTenantApplicationResponse CreateTenantApplication(CreateTenantApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTenantApplicationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 云钉协同创建移动应用
         *
         * @param request CreateTenantApplicationRequest
         * @return CreateTenantApplicationResponse
         */
        public async Task<CreateTenantApplicationResponse> CreateTenantApplicationAsync(CreateTenantApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTenantApplicationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建用户
         *
         * @param request CreateUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserResponse
         */
        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamId))
            {
                body["ramId"] = request.RamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIdList))
            {
                body["roleIdList"] = request.RoleIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建用户
         *
         * @param request CreateUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserResponse
         */
        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamId))
            {
                body["ramId"] = request.RamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIdList))
            {
                body["roleIdList"] = request.RoleIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建用户
         *
         * @param request CreateUserRequest
         * @return CreateUserResponse
         */
        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建用户
         *
         * @param request CreateUserRequest
         * @return CreateUserResponse
         */
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除升级计划
         *
         * @param request DeleteEscalationPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEscalationPlanResponse
         */
        public DeleteEscalationPlanResponse DeleteEscalationPlanWithOptions(DeleteEscalationPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEscalationPlan",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEscalationPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除升级计划
         *
         * @param request DeleteEscalationPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEscalationPlanResponse
         */
        public async Task<DeleteEscalationPlanResponse> DeleteEscalationPlanWithOptionsAsync(DeleteEscalationPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEscalationPlan",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEscalationPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除升级计划
         *
         * @param request DeleteEscalationPlanRequest
         * @return DeleteEscalationPlanResponse
         */
        public DeleteEscalationPlanResponse DeleteEscalationPlan(DeleteEscalationPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEscalationPlanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除升级计划
         *
         * @param request DeleteEscalationPlanRequest
         * @return DeleteEscalationPlanResponse
         */
        public async Task<DeleteEscalationPlanResponse> DeleteEscalationPlanAsync(DeleteEscalationPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEscalationPlanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 事件删除
         *
         * @param request DeleteIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIncidentResponse
         */
        public DeleteIncidentResponse DeleteIncidentWithOptions(DeleteIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIncidentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 事件删除
         *
         * @param request DeleteIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIncidentResponse
         */
        public async Task<DeleteIncidentResponse> DeleteIncidentWithOptionsAsync(DeleteIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIncidentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 事件删除
         *
         * @param request DeleteIncidentRequest
         * @return DeleteIncidentResponse
         */
        public DeleteIncidentResponse DeleteIncident(DeleteIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIncidentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 事件删除
         *
         * @param request DeleteIncidentRequest
         * @return DeleteIncidentResponse
         */
        public async Task<DeleteIncidentResponse> DeleteIncidentAsync(DeleteIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIncidentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除集成配置
         *
         * @param request DeleteIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIntegrationConfigResponse
         */
        public DeleteIntegrationConfigResponse DeleteIntegrationConfigWithOptions(DeleteIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIntegrationConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除集成配置
         *
         * @param request DeleteIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIntegrationConfigResponse
         */
        public async Task<DeleteIntegrationConfigResponse> DeleteIntegrationConfigWithOptionsAsync(DeleteIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIntegrationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除集成配置
         *
         * @param request DeleteIntegrationConfigRequest
         * @return DeleteIntegrationConfigResponse
         */
        public DeleteIntegrationConfigResponse DeleteIntegrationConfig(DeleteIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIntegrationConfigWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除集成配置
         *
         * @param request DeleteIntegrationConfigRequest
         * @return DeleteIntegrationConfigResponse
         */
        public async Task<DeleteIntegrationConfigResponse> DeleteIntegrationConfigAsync(DeleteIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 故障刪除
         *
         * @param request DeleteProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProblemResponse
         */
        public DeleteProblemResponse DeleteProblemWithOptions(DeleteProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProblemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 故障刪除
         *
         * @param request DeleteProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProblemResponse
         */
        public async Task<DeleteProblemResponse> DeleteProblemWithOptionsAsync(DeleteProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProblemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 故障刪除
         *
         * @param request DeleteProblemRequest
         * @return DeleteProblemResponse
         */
        public DeleteProblemResponse DeleteProblem(DeleteProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProblemWithOptions(request, headers, runtime);
        }

        /**
         * @summary 故障刪除
         *
         * @param request DeleteProblemRequest
         * @return DeleteProblemResponse
         */
        public async Task<DeleteProblemResponse> DeleteProblemAsync(DeleteProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProblemWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除故障影响服务
         *
         * @param request DeleteProblemEffectionServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProblemEffectionServiceResponse
         */
        public DeleteProblemEffectionServiceResponse DeleteProblemEffectionServiceWithOptions(DeleteProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectionServiceId))
            {
                body["effectionServiceId"] = request.EffectionServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProblemEffectionService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/effectionService/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProblemEffectionServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除故障影响服务
         *
         * @param request DeleteProblemEffectionServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProblemEffectionServiceResponse
         */
        public async Task<DeleteProblemEffectionServiceResponse> DeleteProblemEffectionServiceWithOptionsAsync(DeleteProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectionServiceId))
            {
                body["effectionServiceId"] = request.EffectionServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProblemEffectionService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/effectionService/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProblemEffectionServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除故障影响服务
         *
         * @param request DeleteProblemEffectionServiceRequest
         * @return DeleteProblemEffectionServiceResponse
         */
        public DeleteProblemEffectionServiceResponse DeleteProblemEffectionService(DeleteProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProblemEffectionServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除故障影响服务
         *
         * @param request DeleteProblemEffectionServiceRequest
         * @return DeleteProblemEffectionServiceResponse
         */
        public async Task<DeleteProblemEffectionServiceResponse> DeleteProblemEffectionServiceAsync(DeleteProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProblemEffectionServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 改进措施删除
         *
         * @param request DeleteProblemMeasureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProblemMeasureResponse
         */
        public DeleteProblemMeasureResponse DeleteProblemMeasureWithOptions(DeleteProblemMeasureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeasureId))
            {
                body["measureId"] = request.MeasureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProblemMeasure",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/improvement/measure/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProblemMeasureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 改进措施删除
         *
         * @param request DeleteProblemMeasureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProblemMeasureResponse
         */
        public async Task<DeleteProblemMeasureResponse> DeleteProblemMeasureWithOptionsAsync(DeleteProblemMeasureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeasureId))
            {
                body["measureId"] = request.MeasureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProblemMeasure",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/improvement/measure/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProblemMeasureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 改进措施删除
         *
         * @param request DeleteProblemMeasureRequest
         * @return DeleteProblemMeasureResponse
         */
        public DeleteProblemMeasureResponse DeleteProblemMeasure(DeleteProblemMeasureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProblemMeasureWithOptions(request, headers, runtime);
        }

        /**
         * @summary 改进措施删除
         *
         * @param request DeleteProblemMeasureRequest
         * @return DeleteProblemMeasureResponse
         */
        public async Task<DeleteProblemMeasureResponse> DeleteProblemMeasureAsync(DeleteProblemMeasureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProblemMeasureWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除影响服务
         *
         * @param request DeleteProblemTimelineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProblemTimelineResponse
         */
        public DeleteProblemTimelineResponse DeleteProblemTimelineWithOptions(DeleteProblemTimelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemTimelineId))
            {
                body["problemTimelineId"] = request.ProblemTimelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProblemTimeline",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/timeline/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProblemTimelineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除影响服务
         *
         * @param request DeleteProblemTimelineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProblemTimelineResponse
         */
        public async Task<DeleteProblemTimelineResponse> DeleteProblemTimelineWithOptionsAsync(DeleteProblemTimelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemTimelineId))
            {
                body["problemTimelineId"] = request.ProblemTimelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProblemTimeline",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/timeline/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProblemTimelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除影响服务
         *
         * @param request DeleteProblemTimelineRequest
         * @return DeleteProblemTimelineResponse
         */
        public DeleteProblemTimelineResponse DeleteProblemTimeline(DeleteProblemTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProblemTimelineWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除影响服务
         *
         * @param request DeleteProblemTimelineRequest
         * @return DeleteProblemTimelineResponse
         */
        public async Task<DeleteProblemTimelineResponse> DeleteProblemTimelineAsync(DeleteProblemTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProblemTimelineWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除流转规则
         *
         * @param request DeleteRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRouteRuleResponse
         */
        public DeleteRouteRuleResponse DeleteRouteRuleWithOptions(DeleteRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRouteRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除流转规则
         *
         * @param request DeleteRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRouteRuleResponse
         */
        public async Task<DeleteRouteRuleResponse> DeleteRouteRuleWithOptionsAsync(DeleteRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRouteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除流转规则
         *
         * @param request DeleteRouteRuleRequest
         * @return DeleteRouteRuleResponse
         */
        public DeleteRouteRuleResponse DeleteRouteRule(DeleteRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRouteRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除流转规则
         *
         * @param request DeleteRouteRuleRequest
         * @return DeleteRouteRuleResponse
         */
        public async Task<DeleteRouteRuleResponse> DeleteRouteRuleAsync(DeleteRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRouteRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除服务
         *
         * @param request DeleteServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceResponse
         */
        public DeleteServiceResponse DeleteServiceWithOptions(DeleteServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除服务
         *
         * @param request DeleteServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceResponse
         */
        public async Task<DeleteServiceResponse> DeleteServiceWithOptionsAsync(DeleteServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除服务
         *
         * @param request DeleteServiceRequest
         * @return DeleteServiceResponse
         */
        public DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除服务
         *
         * @param request DeleteServiceRequest
         * @return DeleteServiceResponse
         */
        public async Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除服务组
         *
         * @param request DeleteServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceGroupResponse
         */
        public DeleteServiceGroupResponse DeleteServiceGroupWithOptions(DeleteServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除服务组
         *
         * @param request DeleteServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceGroupResponse
         */
        public async Task<DeleteServiceGroupResponse> DeleteServiceGroupWithOptionsAsync(DeleteServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除服务组
         *
         * @param request DeleteServiceGroupRequest
         * @return DeleteServiceGroupResponse
         */
        public DeleteServiceGroupResponse DeleteServiceGroup(DeleteServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除服务组
         *
         * @param request DeleteServiceGroupRequest
         * @return DeleteServiceGroupResponse
         */
        public async Task<DeleteServiceGroupResponse> DeleteServiceGroupAsync(DeleteServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除排班
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceGroupSchedulingResponse
         */
        public DeleteServiceGroupSchedulingResponse DeleteServiceGroupSchedulingWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceGroupScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceGroupSchedulingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除排班
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceGroupSchedulingResponse
         */
        public async Task<DeleteServiceGroupSchedulingResponse> DeleteServiceGroupSchedulingWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceGroupScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceGroupSchedulingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除排班
         *
         * @return DeleteServiceGroupSchedulingResponse
         */
        public DeleteServiceGroupSchedulingResponse DeleteServiceGroupScheduling()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceGroupSchedulingWithOptions(headers, runtime);
        }

        /**
         * @summary 删除排班
         *
         * @return DeleteServiceGroupSchedulingResponse
         */
        public async Task<DeleteServiceGroupSchedulingResponse> DeleteServiceGroupSchedulingAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceGroupSchedulingWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 删除服务组成员
         *
         * @param request DeleteServiceGroupUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceGroupUserResponse
         */
        public DeleteServiceGroupUserResponse DeleteServiceGroupUserWithOptions(DeleteServiceGroupUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUserId))
            {
                body["newUserId"] = request.NewUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldUserId))
            {
                body["oldUserId"] = request.OldUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveUser))
            {
                body["removeUser"] = request.RemoveUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceGroupUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/deleteServiceGroupUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceGroupUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除服务组成员
         *
         * @param request DeleteServiceGroupUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceGroupUserResponse
         */
        public async Task<DeleteServiceGroupUserResponse> DeleteServiceGroupUserWithOptionsAsync(DeleteServiceGroupUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUserId))
            {
                body["newUserId"] = request.NewUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldUserId))
            {
                body["oldUserId"] = request.OldUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveUser))
            {
                body["removeUser"] = request.RemoveUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceGroupUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/deleteServiceGroupUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceGroupUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除服务组成员
         *
         * @param request DeleteServiceGroupUserRequest
         * @return DeleteServiceGroupUserResponse
         */
        public DeleteServiceGroupUserResponse DeleteServiceGroupUser(DeleteServiceGroupUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceGroupUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除服务组成员
         *
         * @param request DeleteServiceGroupUserRequest
         * @return DeleteServiceGroupUserResponse
         */
        public async Task<DeleteServiceGroupUserResponse> DeleteServiceGroupUserAsync(DeleteServiceGroupUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceGroupUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除通知订阅
         *
         * @param request DeleteSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSubscriptionResponse
         */
        public DeleteSubscriptionResponse DeleteSubscriptionWithOptions(DeleteSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubscription",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除通知订阅
         *
         * @param request DeleteSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSubscriptionResponse
         */
        public async Task<DeleteSubscriptionResponse> DeleteSubscriptionWithOptionsAsync(DeleteSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubscription",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除通知订阅
         *
         * @param request DeleteSubscriptionRequest
         * @return DeleteSubscriptionResponse
         */
        public DeleteSubscriptionResponse DeleteSubscription(DeleteSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSubscriptionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除通知订阅
         *
         * @param request DeleteSubscriptionRequest
         * @return DeleteSubscriptionResponse
         */
        public async Task<DeleteSubscriptionResponse> DeleteSubscriptionAsync(DeleteSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSubscriptionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除用户
         *
         * @param request DeleteUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除用户
         *
         * @param request DeleteUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除用户
         *
         * @param request DeleteUserRequest
         * @return DeleteUserResponse
         */
        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除用户
         *
         * @param request DeleteUserRequest
         * @return DeleteUserResponse
         */
        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 转交事件
         *
         * @param request DeliverIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeliverIncidentResponse
         */
        public DeliverIncidentResponse DeliverIncidentWithOptions(DeliverIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignUserId))
            {
                body["assignUserId"] = request.AssignUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeliverIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/deliver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeliverIncidentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 转交事件
         *
         * @param request DeliverIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeliverIncidentResponse
         */
        public async Task<DeliverIncidentResponse> DeliverIncidentWithOptionsAsync(DeliverIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignUserId))
            {
                body["assignUserId"] = request.AssignUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeliverIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/deliver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeliverIncidentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 转交事件
         *
         * @param request DeliverIncidentRequest
         * @return DeliverIncidentResponse
         */
        public DeliverIncidentResponse DeliverIncident(DeliverIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeliverIncidentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 转交事件
         *
         * @param request DeliverIncidentRequest
         * @return DeliverIncidentResponse
         */
        public async Task<DeliverIncidentResponse> DeliverIncidentAsync(DeliverIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeliverIncidentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 禁用升级计划
         *
         * @param request DisableEscalationPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableEscalationPlanResponse
         */
        public DisableEscalationPlanResponse DisableEscalationPlanWithOptions(DisableEscalationPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableEscalationPlan",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/disable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableEscalationPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 禁用升级计划
         *
         * @param request DisableEscalationPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableEscalationPlanResponse
         */
        public async Task<DisableEscalationPlanResponse> DisableEscalationPlanWithOptionsAsync(DisableEscalationPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableEscalationPlan",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/disable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableEscalationPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 禁用升级计划
         *
         * @param request DisableEscalationPlanRequest
         * @return DisableEscalationPlanResponse
         */
        public DisableEscalationPlanResponse DisableEscalationPlan(DisableEscalationPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableEscalationPlanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 禁用升级计划
         *
         * @param request DisableEscalationPlanRequest
         * @return DisableEscalationPlanResponse
         */
        public async Task<DisableEscalationPlanResponse> DisableEscalationPlanAsync(DisableEscalationPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableEscalationPlanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 禁用集成配置
         *
         * @param request DisableIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableIntegrationConfigResponse
         */
        public DisableIntegrationConfigResponse DisableIntegrationConfigWithOptions(DisableIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/disable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableIntegrationConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 禁用集成配置
         *
         * @param request DisableIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableIntegrationConfigResponse
         */
        public async Task<DisableIntegrationConfigResponse> DisableIntegrationConfigWithOptionsAsync(DisableIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/disable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableIntegrationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 禁用集成配置
         *
         * @param request DisableIntegrationConfigRequest
         * @return DisableIntegrationConfigResponse
         */
        public DisableIntegrationConfigResponse DisableIntegrationConfig(DisableIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableIntegrationConfigWithOptions(request, headers, runtime);
        }

        /**
         * @summary 禁用集成配置
         *
         * @param request DisableIntegrationConfigRequest
         * @return DisableIntegrationConfigResponse
         */
        public async Task<DisableIntegrationConfigResponse> DisableIntegrationConfigAsync(DisableIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 禁用规则
         *
         * @param request DisableRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableRouteRuleResponse
         */
        public DisableRouteRuleResponse DisableRouteRuleWithOptions(DisableRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/disable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableRouteRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 禁用规则
         *
         * @param request DisableRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableRouteRuleResponse
         */
        public async Task<DisableRouteRuleResponse> DisableRouteRuleWithOptionsAsync(DisableRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/disable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableRouteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 禁用规则
         *
         * @param request DisableRouteRuleRequest
         * @return DisableRouteRuleResponse
         */
        public DisableRouteRuleResponse DisableRouteRule(DisableRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableRouteRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 禁用规则
         *
         * @param request DisableRouteRuleRequest
         * @return DisableRouteRuleResponse
         */
        public async Task<DisableRouteRuleResponse> DisableRouteRuleAsync(DisableRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableRouteRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 禁用服务组的webhook
         *
         * @param request DisableServiceGroupWebhookRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableServiceGroupWebhookResponse
         */
        public DisableServiceGroupWebhookResponse DisableServiceGroupWebhookWithOptions(DisableServiceGroupWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableServiceGroupWebhook",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/disableWebhook",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableServiceGroupWebhookResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 禁用服务组的webhook
         *
         * @param request DisableServiceGroupWebhookRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableServiceGroupWebhookResponse
         */
        public async Task<DisableServiceGroupWebhookResponse> DisableServiceGroupWebhookWithOptionsAsync(DisableServiceGroupWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableServiceGroupWebhook",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/disableWebhook",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableServiceGroupWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 禁用服务组的webhook
         *
         * @param request DisableServiceGroupWebhookRequest
         * @return DisableServiceGroupWebhookResponse
         */
        public DisableServiceGroupWebhookResponse DisableServiceGroupWebhook(DisableServiceGroupWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableServiceGroupWebhookWithOptions(request, headers, runtime);
        }

        /**
         * @summary 禁用服务组的webhook
         *
         * @param request DisableServiceGroupWebhookRequest
         * @return DisableServiceGroupWebhookResponse
         */
        public async Task<DisableServiceGroupWebhookResponse> DisableServiceGroupWebhookAsync(DisableServiceGroupWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableServiceGroupWebhookWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 禁用集成配置
         *
         * @param request DisableSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableSubscriptionResponse
         */
        public DisableSubscriptionResponse DisableSubscriptionWithOptions(DisableSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSubscription",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/doDisable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 禁用集成配置
         *
         * @param request DisableSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableSubscriptionResponse
         */
        public async Task<DisableSubscriptionResponse> DisableSubscriptionWithOptionsAsync(DisableSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSubscription",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/doDisable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 禁用集成配置
         *
         * @param request DisableSubscriptionRequest
         * @return DisableSubscriptionResponse
         */
        public DisableSubscriptionResponse DisableSubscription(DisableSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableSubscriptionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 禁用集成配置
         *
         * @param request DisableSubscriptionRequest
         * @return DisableSubscriptionResponse
         */
        public async Task<DisableSubscriptionResponse> DisableSubscriptionAsync(DisableSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableSubscriptionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 启用升级计划
         *
         * @param request EnableEscalationPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableEscalationPlanResponse
         */
        public EnableEscalationPlanResponse EnableEscalationPlanWithOptions(EnableEscalationPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableEscalationPlan",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableEscalationPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启用升级计划
         *
         * @param request EnableEscalationPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableEscalationPlanResponse
         */
        public async Task<EnableEscalationPlanResponse> EnableEscalationPlanWithOptionsAsync(EnableEscalationPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableEscalationPlan",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableEscalationPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启用升级计划
         *
         * @param request EnableEscalationPlanRequest
         * @return EnableEscalationPlanResponse
         */
        public EnableEscalationPlanResponse EnableEscalationPlan(EnableEscalationPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableEscalationPlanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 启用升级计划
         *
         * @param request EnableEscalationPlanRequest
         * @return EnableEscalationPlanResponse
         */
        public async Task<EnableEscalationPlanResponse> EnableEscalationPlanAsync(EnableEscalationPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableEscalationPlanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 启用集成配置
         *
         * @param request EnableIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableIntegrationConfigResponse
         */
        public EnableIntegrationConfigResponse EnableIntegrationConfigWithOptions(EnableIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableIntegrationConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启用集成配置
         *
         * @param request EnableIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableIntegrationConfigResponse
         */
        public async Task<EnableIntegrationConfigResponse> EnableIntegrationConfigWithOptionsAsync(EnableIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableIntegrationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启用集成配置
         *
         * @param request EnableIntegrationConfigRequest
         * @return EnableIntegrationConfigResponse
         */
        public EnableIntegrationConfigResponse EnableIntegrationConfig(EnableIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableIntegrationConfigWithOptions(request, headers, runtime);
        }

        /**
         * @summary 启用集成配置
         *
         * @param request EnableIntegrationConfigRequest
         * @return EnableIntegrationConfigResponse
         */
        public async Task<EnableIntegrationConfigResponse> EnableIntegrationConfigAsync(EnableIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 启用规则
         *
         * @param request EnableRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableRouteRuleResponse
         */
        public EnableRouteRuleResponse EnableRouteRuleWithOptions(EnableRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableRouteRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启用规则
         *
         * @param request EnableRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableRouteRuleResponse
         */
        public async Task<EnableRouteRuleResponse> EnableRouteRuleWithOptionsAsync(EnableRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableRouteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启用规则
         *
         * @param request EnableRouteRuleRequest
         * @return EnableRouteRuleResponse
         */
        public EnableRouteRuleResponse EnableRouteRule(EnableRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableRouteRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 启用规则
         *
         * @param request EnableRouteRuleRequest
         * @return EnableRouteRuleResponse
         */
        public async Task<EnableRouteRuleResponse> EnableRouteRuleAsync(EnableRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableRouteRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 启用服务组的webhook
         *
         * @param request EnableServiceGroupWebhookRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableServiceGroupWebhookResponse
         */
        public EnableServiceGroupWebhookResponse EnableServiceGroupWebhookWithOptions(EnableServiceGroupWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableServiceGroupWebhook",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/enableWebhook",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableServiceGroupWebhookResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启用服务组的webhook
         *
         * @param request EnableServiceGroupWebhookRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableServiceGroupWebhookResponse
         */
        public async Task<EnableServiceGroupWebhookResponse> EnableServiceGroupWebhookWithOptionsAsync(EnableServiceGroupWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableServiceGroupWebhook",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/enableWebhook",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableServiceGroupWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启用服务组的webhook
         *
         * @param request EnableServiceGroupWebhookRequest
         * @return EnableServiceGroupWebhookResponse
         */
        public EnableServiceGroupWebhookResponse EnableServiceGroupWebhook(EnableServiceGroupWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableServiceGroupWebhookWithOptions(request, headers, runtime);
        }

        /**
         * @summary 启用服务组的webhook
         *
         * @param request EnableServiceGroupWebhookRequest
         * @return EnableServiceGroupWebhookResponse
         */
        public async Task<EnableServiceGroupWebhookResponse> EnableServiceGroupWebhookAsync(EnableServiceGroupWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableServiceGroupWebhookWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 启用通知订阅
         *
         * @param request EnableSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableSubscriptionResponse
         */
        public EnableSubscriptionResponse EnableSubscriptionWithOptions(EnableSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSubscription",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启用通知订阅
         *
         * @param request EnableSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableSubscriptionResponse
         */
        public async Task<EnableSubscriptionResponse> EnableSubscriptionWithOptionsAsync(EnableSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSubscription",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启用通知订阅
         *
         * @param request EnableSubscriptionRequest
         * @return EnableSubscriptionResponse
         */
        public EnableSubscriptionResponse EnableSubscription(EnableSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableSubscriptionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 启用通知订阅
         *
         * @param request EnableSubscriptionRequest
         * @return EnableSubscriptionResponse
         */
        public async Task<EnableSubscriptionResponse> EnableSubscriptionAsync(EnableSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableSubscriptionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 完结事件
         *
         * @param request FinishIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FinishIncidentResponse
         */
        public FinishIncidentResponse FinishIncidentWithOptions(FinishIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishReason))
            {
                body["incidentFinishReason"] = request.IncidentFinishReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishReasonDescription))
            {
                body["incidentFinishReasonDescription"] = request.IncidentFinishReasonDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishSolution))
            {
                body["incidentFinishSolution"] = request.IncidentFinishSolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishSolutionDescription))
            {
                body["incidentFinishSolutionDescription"] = request.IncidentFinishSolutionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentIds))
            {
                body["incidentIds"] = request.IncidentIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/finish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishIncidentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 完结事件
         *
         * @param request FinishIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FinishIncidentResponse
         */
        public async Task<FinishIncidentResponse> FinishIncidentWithOptionsAsync(FinishIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishReason))
            {
                body["incidentFinishReason"] = request.IncidentFinishReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishReasonDescription))
            {
                body["incidentFinishReasonDescription"] = request.IncidentFinishReasonDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishSolution))
            {
                body["incidentFinishSolution"] = request.IncidentFinishSolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishSolutionDescription))
            {
                body["incidentFinishSolutionDescription"] = request.IncidentFinishSolutionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentIds))
            {
                body["incidentIds"] = request.IncidentIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/finish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishIncidentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 完结事件
         *
         * @param request FinishIncidentRequest
         * @return FinishIncidentResponse
         */
        public FinishIncidentResponse FinishIncident(FinishIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FinishIncidentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 完结事件
         *
         * @param request FinishIncidentRequest
         * @return FinishIncidentResponse
         */
        public async Task<FinishIncidentResponse> FinishIncidentAsync(FinishIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FinishIncidentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 故障完结
         *
         * @param request FinishProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FinishProblemResponse
         */
        public FinishProblemResponse FinishProblemWithOptions(FinishProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/finish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishProblemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 故障完结
         *
         * @param request FinishProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FinishProblemResponse
         */
        public async Task<FinishProblemResponse> FinishProblemWithOptionsAsync(FinishProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/finish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishProblemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 故障完结
         *
         * @param request FinishProblemRequest
         * @return FinishProblemResponse
         */
        public FinishProblemResponse FinishProblem(FinishProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FinishProblemWithOptions(request, headers, runtime);
        }

        /**
         * @summary 故障完结
         *
         * @param request FinishProblemRequest
         * @return FinishProblemResponse
         */
        public async Task<FinishProblemResponse> FinishProblemAsync(FinishProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FinishProblemWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 图片连接获取
         *
         * @param request GeneratePictureLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GeneratePictureLinkResponse
         */
        public GeneratePictureLinkResponse GeneratePictureLinkWithOptions(GeneratePictureLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GeneratePictureLink",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/rich/oss/getPictureLink",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GeneratePictureLinkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片连接获取
         *
         * @param request GeneratePictureLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GeneratePictureLinkResponse
         */
        public async Task<GeneratePictureLinkResponse> GeneratePictureLinkWithOptionsAsync(GeneratePictureLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GeneratePictureLink",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/rich/oss/getPictureLink",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GeneratePictureLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片连接获取
         *
         * @param request GeneratePictureLinkRequest
         * @return GeneratePictureLinkResponse
         */
        public GeneratePictureLinkResponse GeneratePictureLink(GeneratePictureLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GeneratePictureLinkWithOptions(request, headers, runtime);
        }

        /**
         * @summary 图片连接获取
         *
         * @param request GeneratePictureLinkRequest
         * @return GeneratePictureLinkResponse
         */
        public async Task<GeneratePictureLinkResponse> GeneratePictureLinkAsync(GeneratePictureLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GeneratePictureLinkWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 图片批量上传
         *
         * @param request GeneratePictureUploadSignRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GeneratePictureUploadSignResponse
         */
        public GeneratePictureUploadSignResponse GeneratePictureUploadSignWithOptions(GeneratePictureUploadSignRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GeneratePictureUploadSign",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/rich/oss/generatePostPolicy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GeneratePictureUploadSignResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片批量上传
         *
         * @param request GeneratePictureUploadSignRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GeneratePictureUploadSignResponse
         */
        public async Task<GeneratePictureUploadSignResponse> GeneratePictureUploadSignWithOptionsAsync(GeneratePictureUploadSignRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GeneratePictureUploadSign",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/rich/oss/generatePostPolicy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GeneratePictureUploadSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片批量上传
         *
         * @param request GeneratePictureUploadSignRequest
         * @return GeneratePictureUploadSignResponse
         */
        public GeneratePictureUploadSignResponse GeneratePictureUploadSign(GeneratePictureUploadSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GeneratePictureUploadSignWithOptions(request, headers, runtime);
        }

        /**
         * @summary 图片批量上传
         *
         * @param request GeneratePictureUploadSignRequest
         * @return GeneratePictureUploadSignResponse
         */
        public async Task<GeneratePictureUploadSignResponse> GeneratePictureUploadSignAsync(GeneratePictureUploadSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GeneratePictureUploadSignWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取图片下载url
         *
         * @param request GenerateProblemPictureLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateProblemPictureLinkResponse
         */
        public GenerateProblemPictureLinkResponse GenerateProblemPictureLinkWithOptions(GenerateProblemPictureLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateProblemPictureLink",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/oss/getPresignedLink",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateProblemPictureLinkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取图片下载url
         *
         * @param request GenerateProblemPictureLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateProblemPictureLinkResponse
         */
        public async Task<GenerateProblemPictureLinkResponse> GenerateProblemPictureLinkWithOptionsAsync(GenerateProblemPictureLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateProblemPictureLink",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/oss/getPresignedLink",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateProblemPictureLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取图片下载url
         *
         * @param request GenerateProblemPictureLinkRequest
         * @return GenerateProblemPictureLinkResponse
         */
        public GenerateProblemPictureLinkResponse GenerateProblemPictureLink(GenerateProblemPictureLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateProblemPictureLinkWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取图片下载url
         *
         * @param request GenerateProblemPictureLinkRequest
         * @return GenerateProblemPictureLinkResponse
         */
        public async Task<GenerateProblemPictureLinkResponse> GenerateProblemPictureLinkAsync(GenerateProblemPictureLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateProblemPictureLinkWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 图片上传验签
         *
         * @param request GenerateProblemPictureUploadSignRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateProblemPictureUploadSignResponse
         */
        public GenerateProblemPictureUploadSignResponse GenerateProblemPictureUploadSignWithOptions(GenerateProblemPictureUploadSignRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateProblemPictureUploadSign",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/oss/generatePostPolicy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateProblemPictureUploadSignResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片上传验签
         *
         * @param request GenerateProblemPictureUploadSignRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateProblemPictureUploadSignResponse
         */
        public async Task<GenerateProblemPictureUploadSignResponse> GenerateProblemPictureUploadSignWithOptionsAsync(GenerateProblemPictureUploadSignRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateProblemPictureUploadSign",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/oss/generatePostPolicy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateProblemPictureUploadSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片上传验签
         *
         * @param request GenerateProblemPictureUploadSignRequest
         * @return GenerateProblemPictureUploadSignResponse
         */
        public GenerateProblemPictureUploadSignResponse GenerateProblemPictureUploadSign(GenerateProblemPictureUploadSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateProblemPictureUploadSignWithOptions(request, headers, runtime);
        }

        /**
         * @summary 图片上传验签
         *
         * @param request GenerateProblemPictureUploadSignRequest
         * @return GenerateProblemPictureUploadSignResponse
         */
        public async Task<GenerateProblemPictureUploadSignResponse> GenerateProblemPictureUploadSignAsync(GenerateProblemPictureUploadSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateProblemPictureUploadSignWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 升级计划详情
         *
         * @param request GetEscalationPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEscalationPlanResponse
         */
        public GetEscalationPlanResponse GetEscalationPlanWithOptions(GetEscalationPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEscalationPlan",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEscalationPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 升级计划详情
         *
         * @param request GetEscalationPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEscalationPlanResponse
         */
        public async Task<GetEscalationPlanResponse> GetEscalationPlanWithOptionsAsync(GetEscalationPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEscalationPlan",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEscalationPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 升级计划详情
         *
         * @param request GetEscalationPlanRequest
         * @return GetEscalationPlanResponse
         */
        public GetEscalationPlanResponse GetEscalationPlan(GetEscalationPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEscalationPlanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 升级计划详情
         *
         * @param request GetEscalationPlanRequest
         * @return GetEscalationPlanResponse
         */
        public async Task<GetEscalationPlanResponse> GetEscalationPlanAsync(GetEscalationPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEscalationPlanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询最近一次告警
         *
         * @param request GetEventRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEventResponse
         */
        public GetEventResponse GetEventWithOptions(GetEventRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceId))
            {
                body["monitorSourceId"] = request.MonitorSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvent",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/events/getLastTimeEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询最近一次告警
         *
         * @param request GetEventRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEventResponse
         */
        public async Task<GetEventResponse> GetEventWithOptionsAsync(GetEventRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceId))
            {
                body["monitorSourceId"] = request.MonitorSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvent",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/events/getLastTimeEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询最近一次告警
         *
         * @param request GetEventRequest
         * @return GetEventResponse
         */
        public GetEventResponse GetEvent(GetEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEventWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询最近一次告警
         *
         * @param request GetEventRequest
         * @return GetEventResponse
         */
        public async Task<GetEventResponse> GetEventAsync(GetEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEventWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询首页引导信息
         *
         * @param request GetHomePageGuidanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHomePageGuidanceResponse
         */
        public GetHomePageGuidanceResponse GetHomePageGuidanceWithOptions(GetHomePageGuidanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHomePageGuidance",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/guidance/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHomePageGuidanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询首页引导信息
         *
         * @param request GetHomePageGuidanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHomePageGuidanceResponse
         */
        public async Task<GetHomePageGuidanceResponse> GetHomePageGuidanceWithOptionsAsync(GetHomePageGuidanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHomePageGuidance",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/guidance/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHomePageGuidanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询首页引导信息
         *
         * @param request GetHomePageGuidanceRequest
         * @return GetHomePageGuidanceResponse
         */
        public GetHomePageGuidanceResponse GetHomePageGuidance(GetHomePageGuidanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHomePageGuidanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询首页引导信息
         *
         * @param request GetHomePageGuidanceRequest
         * @return GetHomePageGuidanceResponse
         */
        public async Task<GetHomePageGuidanceResponse> GetHomePageGuidanceAsync(GetHomePageGuidanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHomePageGuidanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 事件详情
         *
         * @param request GetIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIncidentResponse
         */
        public GetIncidentResponse GetIncidentWithOptions(GetIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIncidentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 事件详情
         *
         * @param request GetIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIncidentResponse
         */
        public async Task<GetIncidentResponse> GetIncidentWithOptionsAsync(GetIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIncidentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 事件详情
         *
         * @param request GetIncidentRequest
         * @return GetIncidentResponse
         */
        public GetIncidentResponse GetIncident(GetIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIncidentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 事件详情
         *
         * @param request GetIncidentRequest
         * @return GetIncidentResponse
         */
        public async Task<GetIncidentResponse> GetIncidentAsync(GetIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIncidentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据事件ID批量查询事件详情
         *
         * @param request GetIncidentListByIdListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIncidentListByIdListResponse
         */
        public GetIncidentListByIdListResponse GetIncidentListByIdListWithOptions(GetIncidentListByIdListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentIdList))
            {
                body["incidentIdList"] = request.IncidentIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIncidentListByIdList",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/getIncidentListByIdList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIncidentListByIdListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据事件ID批量查询事件详情
         *
         * @param request GetIncidentListByIdListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIncidentListByIdListResponse
         */
        public async Task<GetIncidentListByIdListResponse> GetIncidentListByIdListWithOptionsAsync(GetIncidentListByIdListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentIdList))
            {
                body["incidentIdList"] = request.IncidentIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIncidentListByIdList",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/getIncidentListByIdList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIncidentListByIdListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据事件ID批量查询事件详情
         *
         * @param request GetIncidentListByIdListRequest
         * @return GetIncidentListByIdListResponse
         */
        public GetIncidentListByIdListResponse GetIncidentListByIdList(GetIncidentListByIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIncidentListByIdListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据事件ID批量查询事件详情
         *
         * @param request GetIncidentListByIdListRequest
         * @return GetIncidentListByIdListResponse
         */
        public async Task<GetIncidentListByIdListResponse> GetIncidentListByIdListAsync(GetIncidentListByIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIncidentListByIdListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 事件统计
         *
         * @param request GetIncidentStatisticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIncidentStatisticsResponse
         */
        public GetIncidentStatisticsResponse GetIncidentStatisticsWithOptions(GetIncidentStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIncidentStatistics",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/count",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIncidentStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 事件统计
         *
         * @param request GetIncidentStatisticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIncidentStatisticsResponse
         */
        public async Task<GetIncidentStatisticsResponse> GetIncidentStatisticsWithOptionsAsync(GetIncidentStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIncidentStatistics",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/count",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIncidentStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 事件统计
         *
         * @param request GetIncidentStatisticsRequest
         * @return GetIncidentStatisticsResponse
         */
        public GetIncidentStatisticsResponse GetIncidentStatistics(GetIncidentStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIncidentStatisticsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 事件统计
         *
         * @param request GetIncidentStatisticsRequest
         * @return GetIncidentStatisticsResponse
         */
        public async Task<GetIncidentStatisticsResponse> GetIncidentStatisticsAsync(GetIncidentStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIncidentStatisticsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询事件对应的小计数量
         *
         * @param request GetIncidentSubtotalCountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIncidentSubtotalCountResponse
         */
        public GetIncidentSubtotalCountResponse GetIncidentSubtotalCountWithOptions(GetIncidentSubtotalCountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentIds))
            {
                body["incidentIds"] = request.IncidentIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIncidentSubtotalCount",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/subtotal/count",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIncidentSubtotalCountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询事件对应的小计数量
         *
         * @param request GetIncidentSubtotalCountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIncidentSubtotalCountResponse
         */
        public async Task<GetIncidentSubtotalCountResponse> GetIncidentSubtotalCountWithOptionsAsync(GetIncidentSubtotalCountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentIds))
            {
                body["incidentIds"] = request.IncidentIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIncidentSubtotalCount",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/subtotal/count",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIncidentSubtotalCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询事件对应的小计数量
         *
         * @param request GetIncidentSubtotalCountRequest
         * @return GetIncidentSubtotalCountResponse
         */
        public GetIncidentSubtotalCountResponse GetIncidentSubtotalCount(GetIncidentSubtotalCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIncidentSubtotalCountWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询事件对应的小计数量
         *
         * @param request GetIncidentSubtotalCountRequest
         * @return GetIncidentSubtotalCountResponse
         */
        public async Task<GetIncidentSubtotalCountResponse> GetIncidentSubtotalCountAsync(GetIncidentSubtotalCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIncidentSubtotalCountWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取集成配置详情
         *
         * @param request GetIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIntegrationConfigResponse
         */
        public GetIntegrationConfigResponse GetIntegrationConfigWithOptions(GetIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntegrationConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取集成配置详情
         *
         * @param request GetIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIntegrationConfigResponse
         */
        public async Task<GetIntegrationConfigResponse> GetIntegrationConfigWithOptionsAsync(GetIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntegrationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取集成配置详情
         *
         * @param request GetIntegrationConfigRequest
         * @return GetIntegrationConfigResponse
         */
        public GetIntegrationConfigResponse GetIntegrationConfig(GetIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIntegrationConfigWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取集成配置详情
         *
         * @param request GetIntegrationConfigRequest
         * @return GetIntegrationConfigResponse
         */
        public async Task<GetIntegrationConfigResponse> GetIntegrationConfigAsync(GetIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询故障详情
         *
         * @param request GetProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProblemResponse
         */
        public GetProblemResponse GetProblemWithOptions(GetProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProblemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询故障详情
         *
         * @param request GetProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProblemResponse
         */
        public async Task<GetProblemResponse> GetProblemWithOptionsAsync(GetProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProblemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询故障详情
         *
         * @param request GetProblemRequest
         * @return GetProblemResponse
         */
        public GetProblemResponse GetProblem(GetProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProblemWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询故障详情
         *
         * @param request GetProblemRequest
         * @return GetProblemResponse
         */
        public async Task<GetProblemResponse> GetProblemAsync(GetProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProblemWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询故障影响服务
         *
         * @param request GetProblemEffectionServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProblemEffectionServiceResponse
         */
        public GetProblemEffectionServiceResponse GetProblemEffectionServiceWithOptions(GetProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectionServiceId))
            {
                body["effectionServiceId"] = request.EffectionServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProblemEffectionService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/effectionService/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProblemEffectionServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询故障影响服务
         *
         * @param request GetProblemEffectionServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProblemEffectionServiceResponse
         */
        public async Task<GetProblemEffectionServiceResponse> GetProblemEffectionServiceWithOptionsAsync(GetProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectionServiceId))
            {
                body["effectionServiceId"] = request.EffectionServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProblemEffectionService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/effectionService/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProblemEffectionServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询故障影响服务
         *
         * @param request GetProblemEffectionServiceRequest
         * @return GetProblemEffectionServiceResponse
         */
        public GetProblemEffectionServiceResponse GetProblemEffectionService(GetProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProblemEffectionServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询故障影响服务
         *
         * @param request GetProblemEffectionServiceRequest
         * @return GetProblemEffectionServiceResponse
         */
        public async Task<GetProblemEffectionServiceResponse> GetProblemEffectionServiceAsync(GetProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProblemEffectionServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 改进分析详情
         *
         * @param request GetProblemImprovementRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProblemImprovementResponse
         */
        public GetProblemImprovementResponse GetProblemImprovementWithOptions(GetProblemImprovementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProblemImprovement",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/improvement/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProblemImprovementResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 改进分析详情
         *
         * @param request GetProblemImprovementRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProblemImprovementResponse
         */
        public async Task<GetProblemImprovementResponse> GetProblemImprovementWithOptionsAsync(GetProblemImprovementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProblemImprovement",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/improvement/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProblemImprovementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 改进分析详情
         *
         * @param request GetProblemImprovementRequest
         * @return GetProblemImprovementResponse
         */
        public GetProblemImprovementResponse GetProblemImprovement(GetProblemImprovementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProblemImprovementWithOptions(request, headers, runtime);
        }

        /**
         * @summary 改进分析详情
         *
         * @param request GetProblemImprovementRequest
         * @return GetProblemImprovementResponse
         */
        public async Task<GetProblemImprovementResponse> GetProblemImprovementAsync(GetProblemImprovementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProblemImprovementWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通告预览
         *
         * @param request GetProblemPreviewRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProblemPreviewResponse
         */
        public GetProblemPreviewResponse GetProblemPreviewWithOptions(GetProblemPreviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectServiceIds))
            {
                body["effectServiceIds"] = request.EffectServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevel))
            {
                body["problemLevel"] = request.ProblemLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProblemPreview",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/preview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProblemPreviewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 通告预览
         *
         * @param request GetProblemPreviewRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProblemPreviewResponse
         */
        public async Task<GetProblemPreviewResponse> GetProblemPreviewWithOptionsAsync(GetProblemPreviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectServiceIds))
            {
                body["effectServiceIds"] = request.EffectServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevel))
            {
                body["problemLevel"] = request.ProblemLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProblemPreview",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/preview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProblemPreviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 通告预览
         *
         * @param request GetProblemPreviewRequest
         * @return GetProblemPreviewResponse
         */
        public GetProblemPreviewResponse GetProblemPreview(GetProblemPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProblemPreviewWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通告预览
         *
         * @param request GetProblemPreviewRequest
         * @return GetProblemPreviewResponse
         */
        public async Task<GetProblemPreviewResponse> GetProblemPreviewAsync(GetProblemPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProblemPreviewWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 概览数据统计
         *
         * @param request GetResourceStatisticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceStatisticsResponse
         */
        public GetResourceStatisticsResponse GetResourceStatisticsWithOptions(GetResourceStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceStatistics",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/config/resource/count",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 概览数据统计
         *
         * @param request GetResourceStatisticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceStatisticsResponse
         */
        public async Task<GetResourceStatisticsResponse> GetResourceStatisticsWithOptionsAsync(GetResourceStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceStatistics",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/config/resource/count",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 概览数据统计
         *
         * @param request GetResourceStatisticsRequest
         * @return GetResourceStatisticsResponse
         */
        public GetResourceStatisticsResponse GetResourceStatistics(GetResourceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceStatisticsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 概览数据统计
         *
         * @param request GetResourceStatisticsRequest
         * @return GetResourceStatisticsResponse
         */
        public async Task<GetResourceStatisticsResponse> GetResourceStatisticsAsync(GetResourceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceStatisticsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询富文本
         *
         * @param request GetRichTextRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRichTextResponse
         */
        public GetRichTextResponse GetRichTextWithOptions(GetRichTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichTextId))
            {
                body["richTextId"] = request.RichTextId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRichText",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/rich/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRichTextResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询富文本
         *
         * @param request GetRichTextRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRichTextResponse
         */
        public async Task<GetRichTextResponse> GetRichTextWithOptionsAsync(GetRichTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichTextId))
            {
                body["richTextId"] = request.RichTextId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRichText",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/rich/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRichTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询富文本
         *
         * @param request GetRichTextRequest
         * @return GetRichTextResponse
         */
        public GetRichTextResponse GetRichText(GetRichTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRichTextWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询富文本
         *
         * @param request GetRichTextRequest
         * @return GetRichTextResponse
         */
        public async Task<GetRichTextResponse> GetRichTextAsync(GetRichTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRichTextWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询流转规则详情
         *
         * @param request GetRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRouteRuleResponse
         */
        public GetRouteRuleResponse GetRouteRuleWithOptions(GetRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRouteRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询流转规则详情
         *
         * @param request GetRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRouteRuleResponse
         */
        public async Task<GetRouteRuleResponse> GetRouteRuleWithOptionsAsync(GetRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRouteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询流转规则详情
         *
         * @param request GetRouteRuleRequest
         * @return GetRouteRuleResponse
         */
        public GetRouteRuleResponse GetRouteRule(GetRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRouteRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询流转规则详情
         *
         * @param request GetRouteRuleRequest
         * @return GetRouteRuleResponse
         */
        public async Task<GetRouteRuleResponse> GetRouteRuleAsync(GetRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRouteRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 服务详情
         *
         * @param request GetServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceResponse
         */
        public GetServiceResponse GetServiceWithOptions(GetServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 服务详情
         *
         * @param request GetServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceResponse
         */
        public async Task<GetServiceResponse> GetServiceWithOptionsAsync(GetServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 服务详情
         *
         * @param request GetServiceRequest
         * @return GetServiceResponse
         */
        public GetServiceResponse GetService(GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 服务详情
         *
         * @param request GetServiceRequest
         * @return GetServiceResponse
         */
        public async Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询服务组详情
         *
         * @param request GetServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceGroupResponse
         */
        public GetServiceGroupResponse GetServiceGroupWithOptions(GetServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询服务组详情
         *
         * @param request GetServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceGroupResponse
         */
        public async Task<GetServiceGroupResponse> GetServiceGroupWithOptionsAsync(GetServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询服务组详情
         *
         * @param request GetServiceGroupRequest
         * @return GetServiceGroupResponse
         */
        public GetServiceGroupResponse GetServiceGroup(GetServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询服务组详情
         *
         * @param request GetServiceGroupRequest
         * @return GetServiceGroupResponse
         */
        public async Task<GetServiceGroupResponse> GetServiceGroupAsync(GetServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询用户某个服务组的排班
         *
         * @param request GetServiceGroupPersonSchedulingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceGroupPersonSchedulingResponse
         */
        public GetServiceGroupPersonSchedulingResponse GetServiceGroupPersonSchedulingWithOptions(GetServiceGroupPersonSchedulingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceGroupPersonScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/user/getScheduling",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceGroupPersonSchedulingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询用户某个服务组的排班
         *
         * @param request GetServiceGroupPersonSchedulingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceGroupPersonSchedulingResponse
         */
        public async Task<GetServiceGroupPersonSchedulingResponse> GetServiceGroupPersonSchedulingWithOptionsAsync(GetServiceGroupPersonSchedulingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceGroupPersonScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/user/getScheduling",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceGroupPersonSchedulingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户某个服务组的排班
         *
         * @param request GetServiceGroupPersonSchedulingRequest
         * @return GetServiceGroupPersonSchedulingResponse
         */
        public GetServiceGroupPersonSchedulingResponse GetServiceGroupPersonScheduling(GetServiceGroupPersonSchedulingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceGroupPersonSchedulingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户某个服务组的排班
         *
         * @param request GetServiceGroupPersonSchedulingRequest
         * @return GetServiceGroupPersonSchedulingResponse
         */
        public async Task<GetServiceGroupPersonSchedulingResponse> GetServiceGroupPersonSchedulingAsync(GetServiceGroupPersonSchedulingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceGroupPersonSchedulingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询服务组排班详情
         *
         * @param request GetServiceGroupSchedulingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceGroupSchedulingResponse
         */
        public GetServiceGroupSchedulingResponse GetServiceGroupSchedulingWithOptions(GetServiceGroupSchedulingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceGroupScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceGroupSchedulingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询服务组排班详情
         *
         * @param request GetServiceGroupSchedulingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceGroupSchedulingResponse
         */
        public async Task<GetServiceGroupSchedulingResponse> GetServiceGroupSchedulingWithOptionsAsync(GetServiceGroupSchedulingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceGroupScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceGroupSchedulingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询服务组排班详情
         *
         * @param request GetServiceGroupSchedulingRequest
         * @return GetServiceGroupSchedulingResponse
         */
        public GetServiceGroupSchedulingResponse GetServiceGroupScheduling(GetServiceGroupSchedulingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceGroupSchedulingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询服务组排班详情
         *
         * @param request GetServiceGroupSchedulingRequest
         * @return GetServiceGroupSchedulingResponse
         */
        public async Task<GetServiceGroupSchedulingResponse> GetServiceGroupSchedulingAsync(GetServiceGroupSchedulingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceGroupSchedulingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 预览服务组排班
         *
         * @param request GetServiceGroupSchedulingPreviewRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceGroupSchedulingPreviewResponse
         */
        public GetServiceGroupSchedulingPreviewResponse GetServiceGroupSchedulingPreviewWithOptions(GetServiceGroupSchedulingPreviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastScheduling))
            {
                body["fastScheduling"] = request.FastScheduling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FineScheduling))
            {
                body["fineScheduling"] = request.FineScheduling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulingWay))
            {
                body["schedulingWay"] = request.SchedulingWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceGroupSchedulingPreview",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/preview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceGroupSchedulingPreviewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 预览服务组排班
         *
         * @param request GetServiceGroupSchedulingPreviewRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceGroupSchedulingPreviewResponse
         */
        public async Task<GetServiceGroupSchedulingPreviewResponse> GetServiceGroupSchedulingPreviewWithOptionsAsync(GetServiceGroupSchedulingPreviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastScheduling))
            {
                body["fastScheduling"] = request.FastScheduling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FineScheduling))
            {
                body["fineScheduling"] = request.FineScheduling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulingWay))
            {
                body["schedulingWay"] = request.SchedulingWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceGroupSchedulingPreview",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/preview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceGroupSchedulingPreviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 预览服务组排班
         *
         * @param request GetServiceGroupSchedulingPreviewRequest
         * @return GetServiceGroupSchedulingPreviewResponse
         */
        public GetServiceGroupSchedulingPreviewResponse GetServiceGroupSchedulingPreview(GetServiceGroupSchedulingPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceGroupSchedulingPreviewWithOptions(request, headers, runtime);
        }

        /**
         * @summary 预览服务组排班
         *
         * @param request GetServiceGroupSchedulingPreviewRequest
         * @return GetServiceGroupSchedulingPreviewResponse
         */
        public async Task<GetServiceGroupSchedulingPreviewResponse> GetServiceGroupSchedulingPreviewAsync(GetServiceGroupSchedulingPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceGroupSchedulingPreviewWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询指定人员的服务组排班
         *
         * @param request GetServiceGroupSpecialPersonSchedulingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceGroupSpecialPersonSchedulingResponse
         */
        public GetServiceGroupSpecialPersonSchedulingResponse GetServiceGroupSpecialPersonSchedulingWithOptions(GetServiceGroupSpecialPersonSchedulingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceGroupSpecialPersonScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/getUserScheduling",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceGroupSpecialPersonSchedulingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询指定人员的服务组排班
         *
         * @param request GetServiceGroupSpecialPersonSchedulingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceGroupSpecialPersonSchedulingResponse
         */
        public async Task<GetServiceGroupSpecialPersonSchedulingResponse> GetServiceGroupSpecialPersonSchedulingWithOptionsAsync(GetServiceGroupSpecialPersonSchedulingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceGroupSpecialPersonScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/getUserScheduling",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceGroupSpecialPersonSchedulingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询指定人员的服务组排班
         *
         * @param request GetServiceGroupSpecialPersonSchedulingRequest
         * @return GetServiceGroupSpecialPersonSchedulingResponse
         */
        public GetServiceGroupSpecialPersonSchedulingResponse GetServiceGroupSpecialPersonScheduling(GetServiceGroupSpecialPersonSchedulingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceGroupSpecialPersonSchedulingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询指定人员的服务组排班
         *
         * @param request GetServiceGroupSpecialPersonSchedulingRequest
         * @return GetServiceGroupSpecialPersonSchedulingResponse
         */
        public async Task<GetServiceGroupSpecialPersonSchedulingResponse> GetServiceGroupSpecialPersonSchedulingAsync(GetServiceGroupSpecialPersonSchedulingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceGroupSpecialPersonSchedulingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 相似事件统计信息
         *
         * @param request GetSimilarIncidentStatisticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSimilarIncidentStatisticsResponse
         */
        public GetSimilarIncidentStatisticsResponse GetSimilarIncidentStatisticsWithOptions(GetSimilarIncidentStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                body["createTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Events))
            {
                body["events"] = request.Events;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentTitle))
            {
                body["incidentTitle"] = request.IncidentTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSimilarIncidentStatistics",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/similarIncident/statistics",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimilarIncidentStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 相似事件统计信息
         *
         * @param request GetSimilarIncidentStatisticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSimilarIncidentStatisticsResponse
         */
        public async Task<GetSimilarIncidentStatisticsResponse> GetSimilarIncidentStatisticsWithOptionsAsync(GetSimilarIncidentStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                body["createTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Events))
            {
                body["events"] = request.Events;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentTitle))
            {
                body["incidentTitle"] = request.IncidentTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSimilarIncidentStatistics",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/similarIncident/statistics",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimilarIncidentStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 相似事件统计信息
         *
         * @param request GetSimilarIncidentStatisticsRequest
         * @return GetSimilarIncidentStatisticsResponse
         */
        public GetSimilarIncidentStatisticsResponse GetSimilarIncidentStatistics(GetSimilarIncidentStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSimilarIncidentStatisticsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 相似事件统计信息
         *
         * @param request GetSimilarIncidentStatisticsRequest
         * @return GetSimilarIncidentStatisticsResponse
         */
        public async Task<GetSimilarIncidentStatisticsResponse> GetSimilarIncidentStatisticsAsync(GetSimilarIncidentStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSimilarIncidentStatisticsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通知订阅详情
         *
         * @param request GetSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubscriptionResponse
         */
        public GetSubscriptionResponse GetSubscriptionWithOptions(GetSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotFilterScopeObjectDeleted))
            {
                body["notFilterScopeObjectDeleted"] = request.NotFilterScopeObjectDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubscription",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 通知订阅详情
         *
         * @param request GetSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubscriptionResponse
         */
        public async Task<GetSubscriptionResponse> GetSubscriptionWithOptionsAsync(GetSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotFilterScopeObjectDeleted))
            {
                body["notFilterScopeObjectDeleted"] = request.NotFilterScopeObjectDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubscription",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 通知订阅详情
         *
         * @param request GetSubscriptionRequest
         * @return GetSubscriptionResponse
         */
        public GetSubscriptionResponse GetSubscription(GetSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSubscriptionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通知订阅详情
         *
         * @param request GetSubscriptionRequest
         * @return GetSubscriptionResponse
         */
        public async Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSubscriptionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 云钉协同移动应用详情
         *
         * @param request GetTenantApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTenantApplicationResponse
         */
        public GetTenantApplicationResponse GetTenantApplicationWithOptions(GetTenantApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTenantApplication",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/mobileApp/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTenantApplicationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 云钉协同移动应用详情
         *
         * @param request GetTenantApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTenantApplicationResponse
         */
        public async Task<GetTenantApplicationResponse> GetTenantApplicationWithOptionsAsync(GetTenantApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTenantApplication",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/mobileApp/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTenantApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 云钉协同移动应用详情
         *
         * @param request GetTenantApplicationRequest
         * @return GetTenantApplicationResponse
         */
        public GetTenantApplicationResponse GetTenantApplication(GetTenantApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTenantApplicationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 云钉协同移动应用详情
         *
         * @param request GetTenantApplicationRequest
         * @return GetTenantApplicationResponse
         */
        public async Task<GetTenantApplicationResponse> GetTenantApplicationAsync(GetTenantApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTenantApplicationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询租户开通运维事件中心的状态
         *
         * @param request GetTenantStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTenantStatusResponse
         */
        public GetTenantStatusResponse GetTenantStatusWithOptions(GetTenantStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantRamId))
            {
                body["tenantRamId"] = request.TenantRamId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTenantStatus",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/tenant/getTenantStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTenantStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询租户开通运维事件中心的状态
         *
         * @param request GetTenantStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTenantStatusResponse
         */
        public async Task<GetTenantStatusResponse> GetTenantStatusWithOptionsAsync(GetTenantStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantRamId))
            {
                body["tenantRamId"] = request.TenantRamId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTenantStatus",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/tenant/getTenantStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTenantStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询租户开通运维事件中心的状态
         *
         * @param request GetTenantStatusRequest
         * @return GetTenantStatusResponse
         */
        public GetTenantStatusResponse GetTenantStatus(GetTenantStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTenantStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询租户开通运维事件中心的状态
         *
         * @param request GetTenantStatusRequest
         * @return GetTenantStatusResponse
         */
        public async Task<GetTenantStatusResponse> GetTenantStatusAsync(GetTenantStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTenantStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取用户详情
         *
         * @param request GetUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public GetUserResponse GetUserWithOptions(GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/getUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用户详情
         *
         * @param request GetUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/getUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户详情
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户详情
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询用户新手引导状态
         *
         * @param request GetUserGuideStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserGuideStatusResponse
         */
        public GetUserGuideStatusResponse GetUserGuideStatusWithOptions(GetUserGuideStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserGuideStatus",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/guide/status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserGuideStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询用户新手引导状态
         *
         * @param request GetUserGuideStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserGuideStatusResponse
         */
        public async Task<GetUserGuideStatusResponse> GetUserGuideStatusWithOptionsAsync(GetUserGuideStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserGuideStatus",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/guide/status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserGuideStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户新手引导状态
         *
         * @param request GetUserGuideStatusRequest
         * @return GetUserGuideStatusResponse
         */
        public GetUserGuideStatusResponse GetUserGuideStatus(GetUserGuideStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserGuideStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户新手引导状态
         *
         * @param request GetUserGuideStatusRequest
         * @return GetUserGuideStatusResponse
         */
        public async Task<GetUserGuideStatusResponse> GetUserGuideStatusAsync(GetUserGuideStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserGuideStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 报警列表查询
         *
         * @param request ListAlertsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAlertsResponse
         */
        public ListAlertsResponse ListAlertsWithOptions(ListAlertsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertLevel))
            {
                body["alertLevel"] = request.AlertLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertName))
            {
                body["alertName"] = request.AlertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSourceName))
            {
                body["alertSourceName"] = request.AlertSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceId))
            {
                body["monitorSourceId"] = request.MonitorSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlerts",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/alerts/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 报警列表查询
         *
         * @param request ListAlertsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAlertsResponse
         */
        public async Task<ListAlertsResponse> ListAlertsWithOptionsAsync(ListAlertsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertLevel))
            {
                body["alertLevel"] = request.AlertLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertName))
            {
                body["alertName"] = request.AlertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSourceName))
            {
                body["alertSourceName"] = request.AlertSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceId))
            {
                body["monitorSourceId"] = request.MonitorSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlerts",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/alerts/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 报警列表查询
         *
         * @param request ListAlertsRequest
         * @return ListAlertsResponse
         */
        public ListAlertsResponse ListAlerts(ListAlertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAlertsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 报警列表查询
         *
         * @param request ListAlertsRequest
         * @return ListAlertsResponse
         */
        public async Task<ListAlertsResponse> ListAlertsAsync(ListAlertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAlertsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 监控关联规则列表
         *
         * @param request ListByMonitorSourceIdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListByMonitorSourceIdResponse
         */
        public ListByMonitorSourceIdResponse ListByMonitorSourceIdWithOptions(ListByMonitorSourceIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceId))
            {
                body["monitorSourceId"] = request.MonitorSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListByMonitorSourceId",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/listByMonitorSourceId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListByMonitorSourceIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 监控关联规则列表
         *
         * @param request ListByMonitorSourceIdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListByMonitorSourceIdResponse
         */
        public async Task<ListByMonitorSourceIdResponse> ListByMonitorSourceIdWithOptionsAsync(ListByMonitorSourceIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceId))
            {
                body["monitorSourceId"] = request.MonitorSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListByMonitorSourceId",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/listByMonitorSourceId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListByMonitorSourceIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 监控关联规则列表
         *
         * @param request ListByMonitorSourceIdRequest
         * @return ListByMonitorSourceIdResponse
         */
        public ListByMonitorSourceIdResponse ListByMonitorSourceId(ListByMonitorSourceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListByMonitorSourceIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 监控关联规则列表
         *
         * @param request ListByMonitorSourceIdRequest
         * @return ListByMonitorSourceIdResponse
         */
        public async Task<ListByMonitorSourceIdResponse> ListByMonitorSourceIdAsync(ListByMonitorSourceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListByMonitorSourceIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 统计图表数据-个人
         *
         * @param request ListChartDataForServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListChartDataForServiceGroupResponse
         */
        public ListChartDataForServiceGroupResponse ListChartDataForServiceGroupWithOptions(ListChartDataForServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChartDataForServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/statistics/chartDataForServiceGroup/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChartDataForServiceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 统计图表数据-个人
         *
         * @param request ListChartDataForServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListChartDataForServiceGroupResponse
         */
        public async Task<ListChartDataForServiceGroupResponse> ListChartDataForServiceGroupWithOptionsAsync(ListChartDataForServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChartDataForServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/statistics/chartDataForServiceGroup/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChartDataForServiceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 统计图表数据-个人
         *
         * @param request ListChartDataForServiceGroupRequest
         * @return ListChartDataForServiceGroupResponse
         */
        public ListChartDataForServiceGroupResponse ListChartDataForServiceGroup(ListChartDataForServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListChartDataForServiceGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 统计图表数据-个人
         *
         * @param request ListChartDataForServiceGroupRequest
         * @return ListChartDataForServiceGroupResponse
         */
        public async Task<ListChartDataForServiceGroupResponse> ListChartDataForServiceGroupAsync(ListChartDataForServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListChartDataForServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 统计图表数据-个人
         *
         * @param request ListChartDataForUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListChartDataForUserResponse
         */
        public ListChartDataForUserResponse ListChartDataForUserWithOptions(ListChartDataForUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChartDataForUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/statistics/chartDataForUser/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChartDataForUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 统计图表数据-个人
         *
         * @param request ListChartDataForUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListChartDataForUserResponse
         */
        public async Task<ListChartDataForUserResponse> ListChartDataForUserWithOptionsAsync(ListChartDataForUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChartDataForUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/statistics/chartDataForUser/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChartDataForUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 统计图表数据-个人
         *
         * @param request ListChartDataForUserRequest
         * @return ListChartDataForUserResponse
         */
        public ListChartDataForUserResponse ListChartDataForUser(ListChartDataForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListChartDataForUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 统计图表数据-个人
         *
         * @param request ListChartDataForUserRequest
         * @return ListChartDataForUserResponse
         */
        public async Task<ListChartDataForUserResponse> ListChartDataForUserAsync(ListChartDataForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListChartDataForUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 全局码表配置
         *
         * @param request ListConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConfigsResponse
         */
        public ListConfigsResponse ListConfigsWithOptions(ListConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigs",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/config/all",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 全局码表配置
         *
         * @param request ListConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConfigsResponse
         */
        public async Task<ListConfigsResponse> ListConfigsWithOptionsAsync(ListConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigs",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/config/all",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 全局码表配置
         *
         * @param request ListConfigsRequest
         * @return ListConfigsResponse
         */
        public ListConfigsResponse ListConfigs(ListConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConfigsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 全局码表配置
         *
         * @param request ListConfigsRequest
         * @return ListConfigsResponse
         */
        public async Task<ListConfigsResponse> ListConfigsAsync(ListConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConfigsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询服务组事件统计报表
         *
         * @param request ListDataReportForServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataReportForServiceGroupResponse
         */
        public ListDataReportForServiceGroupResponse ListDataReportForServiceGroupWithOptions(ListDataReportForServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupName))
            {
                body["serviceGroupName"] = request.ServiceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataReportForServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/statistics/listDataReportForServiceGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataReportForServiceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询服务组事件统计报表
         *
         * @param request ListDataReportForServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataReportForServiceGroupResponse
         */
        public async Task<ListDataReportForServiceGroupResponse> ListDataReportForServiceGroupWithOptionsAsync(ListDataReportForServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupName))
            {
                body["serviceGroupName"] = request.ServiceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataReportForServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/statistics/listDataReportForServiceGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataReportForServiceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询服务组事件统计报表
         *
         * @param request ListDataReportForServiceGroupRequest
         * @return ListDataReportForServiceGroupResponse
         */
        public ListDataReportForServiceGroupResponse ListDataReportForServiceGroup(ListDataReportForServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataReportForServiceGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询服务组事件统计报表
         *
         * @param request ListDataReportForServiceGroupRequest
         * @return ListDataReportForServiceGroupResponse
         */
        public async Task<ListDataReportForServiceGroupResponse> ListDataReportForServiceGroupAsync(ListDataReportForServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataReportForServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询用户事件统计报表
         *
         * @param request ListDataReportForUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataReportForUserResponse
         */
        public ListDataReportForUserResponse ListDataReportForUserWithOptions(ListDataReportForUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataReportForUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/statistics/listDataReportForUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataReportForUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询用户事件统计报表
         *
         * @param request ListDataReportForUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataReportForUserResponse
         */
        public async Task<ListDataReportForUserResponse> ListDataReportForUserWithOptionsAsync(ListDataReportForUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataReportForUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/statistics/listDataReportForUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataReportForUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户事件统计报表
         *
         * @param request ListDataReportForUserRequest
         * @return ListDataReportForUserResponse
         */
        public ListDataReportForUserResponse ListDataReportForUser(ListDataReportForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataReportForUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户事件统计报表
         *
         * @param request ListDataReportForUserRequest
         * @return ListDataReportForUserResponse
         */
        public async Task<ListDataReportForUserResponse> ListDataReportForUserAsync(ListDataReportForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataReportForUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 字典列表
         *
         * @param request ListDictionariesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDictionariesResponse
         */
        public ListDictionariesResponse ListDictionariesWithOptions(ListDictionariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDictionaries",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/dict/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDictionariesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 字典列表
         *
         * @param request ListDictionariesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDictionariesResponse
         */
        public async Task<ListDictionariesResponse> ListDictionariesWithOptionsAsync(ListDictionariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDictionaries",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/dict/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDictionariesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 字典列表
         *
         * @param request ListDictionariesRequest
         * @return ListDictionariesResponse
         */
        public ListDictionariesResponse ListDictionaries(ListDictionariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDictionariesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 字典列表
         *
         * @param request ListDictionariesRequest
         * @return ListDictionariesResponse
         */
        public async Task<ListDictionariesResponse> ListDictionariesAsync(ListDictionariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDictionariesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取已选中的服务对象
         *
         * @param request ListEscalationPlanServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEscalationPlanServicesResponse
         */
        public ListEscalationPlanServicesResponse ListEscalationPlanServicesWithOptions(ListEscalationPlanServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEscalationPlanServices",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEscalationPlanServicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取已选中的服务对象
         *
         * @param request ListEscalationPlanServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEscalationPlanServicesResponse
         */
        public async Task<ListEscalationPlanServicesResponse> ListEscalationPlanServicesWithOptionsAsync(ListEscalationPlanServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEscalationPlanServices",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEscalationPlanServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取已选中的服务对象
         *
         * @param request ListEscalationPlanServicesRequest
         * @return ListEscalationPlanServicesResponse
         */
        public ListEscalationPlanServicesResponse ListEscalationPlanServices(ListEscalationPlanServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEscalationPlanServicesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取已选中的服务对象
         *
         * @param request ListEscalationPlanServicesRequest
         * @return ListEscalationPlanServicesResponse
         */
        public async Task<ListEscalationPlanServicesResponse> ListEscalationPlanServicesAsync(ListEscalationPlanServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEscalationPlanServicesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 升级计划列表添加服务删除字段
         *
         * @param request ListEscalationPlansRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEscalationPlansResponse
         */
        public ListEscalationPlansResponse ListEscalationPlansWithOptions(ListEscalationPlansRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanName))
            {
                body["escalationPlanName"] = request.EscalationPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGlobal))
            {
                body["isGlobal"] = request.IsGlobal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEscalationPlans",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEscalationPlansResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 升级计划列表添加服务删除字段
         *
         * @param request ListEscalationPlansRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEscalationPlansResponse
         */
        public async Task<ListEscalationPlansResponse> ListEscalationPlansWithOptionsAsync(ListEscalationPlansRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanName))
            {
                body["escalationPlanName"] = request.EscalationPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGlobal))
            {
                body["isGlobal"] = request.IsGlobal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEscalationPlans",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEscalationPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 升级计划列表添加服务删除字段
         *
         * @param request ListEscalationPlansRequest
         * @return ListEscalationPlansResponse
         */
        public ListEscalationPlansResponse ListEscalationPlans(ListEscalationPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEscalationPlansWithOptions(request, headers, runtime);
        }

        /**
         * @summary 升级计划列表添加服务删除字段
         *
         * @param request ListEscalationPlansRequest
         * @return ListEscalationPlansResponse
         */
        public async Task<ListEscalationPlansResponse> ListEscalationPlansAsync(ListEscalationPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEscalationPlansWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据推送对象查询升级策略
         *
         * @param request ListEscalationPlansByNoticeObjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEscalationPlansByNoticeObjectResponse
         */
        public ListEscalationPlansByNoticeObjectResponse ListEscalationPlansByNoticeObjectWithOptions(ListEscalationPlansByNoticeObjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeObjectId))
            {
                body["noticeObjectId"] = request.NoticeObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeObjectType))
            {
                body["noticeObjectType"] = request.NoticeObjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEscalationPlansByNoticeObject",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/listByNoticeObject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEscalationPlansByNoticeObjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据推送对象查询升级策略
         *
         * @param request ListEscalationPlansByNoticeObjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEscalationPlansByNoticeObjectResponse
         */
        public async Task<ListEscalationPlansByNoticeObjectResponse> ListEscalationPlansByNoticeObjectWithOptionsAsync(ListEscalationPlansByNoticeObjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeObjectId))
            {
                body["noticeObjectId"] = request.NoticeObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeObjectType))
            {
                body["noticeObjectType"] = request.NoticeObjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEscalationPlansByNoticeObject",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/listByNoticeObject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEscalationPlansByNoticeObjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据推送对象查询升级策略
         *
         * @param request ListEscalationPlansByNoticeObjectRequest
         * @return ListEscalationPlansByNoticeObjectResponse
         */
        public ListEscalationPlansByNoticeObjectResponse ListEscalationPlansByNoticeObject(ListEscalationPlansByNoticeObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEscalationPlansByNoticeObjectWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据推送对象查询升级策略
         *
         * @param request ListEscalationPlansByNoticeObjectRequest
         * @return ListEscalationPlansByNoticeObjectResponse
         */
        public async Task<ListEscalationPlansByNoticeObjectResponse> ListEscalationPlansByNoticeObjectAsync(ListEscalationPlansByNoticeObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEscalationPlansByNoticeObjectWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 事件详情升级策略
         *
         * @param request ListIncidentDetailEscalationPlansRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIncidentDetailEscalationPlansResponse
         */
        public ListIncidentDetailEscalationPlansResponse ListIncidentDetailEscalationPlansWithOptions(ListIncidentDetailEscalationPlansRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIncidentDetailEscalationPlans",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/detail/escalation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIncidentDetailEscalationPlansResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 事件详情升级策略
         *
         * @param request ListIncidentDetailEscalationPlansRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIncidentDetailEscalationPlansResponse
         */
        public async Task<ListIncidentDetailEscalationPlansResponse> ListIncidentDetailEscalationPlansWithOptionsAsync(ListIncidentDetailEscalationPlansRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIncidentDetailEscalationPlans",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/detail/escalation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIncidentDetailEscalationPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 事件详情升级策略
         *
         * @param request ListIncidentDetailEscalationPlansRequest
         * @return ListIncidentDetailEscalationPlansResponse
         */
        public ListIncidentDetailEscalationPlansResponse ListIncidentDetailEscalationPlans(ListIncidentDetailEscalationPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIncidentDetailEscalationPlansWithOptions(request, headers, runtime);
        }

        /**
         * @summary 事件详情升级策略
         *
         * @param request ListIncidentDetailEscalationPlansRequest
         * @return ListIncidentDetailEscalationPlansResponse
         */
        public async Task<ListIncidentDetailEscalationPlansResponse> ListIncidentDetailEscalationPlansAsync(ListIncidentDetailEscalationPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIncidentDetailEscalationPlansWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询事件详情动态
         *
         * @param request ListIncidentDetailTimelinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIncidentDetailTimelinesResponse
         */
        public ListIncidentDetailTimelinesResponse ListIncidentDetailTimelinesWithOptions(ListIncidentDetailTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdSort))
            {
                body["idSort"] = request.IdSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIncidentDetailTimelines",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/detail/timeline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIncidentDetailTimelinesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询事件详情动态
         *
         * @param request ListIncidentDetailTimelinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIncidentDetailTimelinesResponse
         */
        public async Task<ListIncidentDetailTimelinesResponse> ListIncidentDetailTimelinesWithOptionsAsync(ListIncidentDetailTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdSort))
            {
                body["idSort"] = request.IdSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIncidentDetailTimelines",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/detail/timeline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIncidentDetailTimelinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询事件详情动态
         *
         * @param request ListIncidentDetailTimelinesRequest
         * @return ListIncidentDetailTimelinesResponse
         */
        public ListIncidentDetailTimelinesResponse ListIncidentDetailTimelines(ListIncidentDetailTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIncidentDetailTimelinesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询事件详情动态
         *
         * @param request ListIncidentDetailTimelinesRequest
         * @return ListIncidentDetailTimelinesResponse
         */
        public async Task<ListIncidentDetailTimelinesResponse> ListIncidentDetailTimelinesAsync(ListIncidentDetailTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIncidentDetailTimelinesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询事件小计
         *
         * @param request ListIncidentSubtotalsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIncidentSubtotalsResponse
         */
        public ListIncidentSubtotalsResponse ListIncidentSubtotalsWithOptions(ListIncidentSubtotalsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIncidentSubtotals",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/list/subtotal",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIncidentSubtotalsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询事件小计
         *
         * @param request ListIncidentSubtotalsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIncidentSubtotalsResponse
         */
        public async Task<ListIncidentSubtotalsResponse> ListIncidentSubtotalsWithOptionsAsync(ListIncidentSubtotalsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIncidentSubtotals",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/list/subtotal",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIncidentSubtotalsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询事件小计
         *
         * @param request ListIncidentSubtotalsRequest
         * @return ListIncidentSubtotalsResponse
         */
        public ListIncidentSubtotalsResponse ListIncidentSubtotals(ListIncidentSubtotalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIncidentSubtotalsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询事件小计
         *
         * @param request ListIncidentSubtotalsRequest
         * @return ListIncidentSubtotalsResponse
         */
        public async Task<ListIncidentSubtotalsResponse> ListIncidentSubtotalsAsync(ListIncidentSubtotalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIncidentSubtotalsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 事件动态
         *
         * @param request ListIncidentTimelinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIncidentTimelinesResponse
         */
        public ListIncidentTimelinesResponse ListIncidentTimelinesWithOptions(ListIncidentTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIncidentTimelines",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/timeline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIncidentTimelinesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 事件动态
         *
         * @param request ListIncidentTimelinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIncidentTimelinesResponse
         */
        public async Task<ListIncidentTimelinesResponse> ListIncidentTimelinesWithOptionsAsync(ListIncidentTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIncidentTimelines",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/timeline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIncidentTimelinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 事件动态
         *
         * @param request ListIncidentTimelinesRequest
         * @return ListIncidentTimelinesResponse
         */
        public ListIncidentTimelinesResponse ListIncidentTimelines(ListIncidentTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIncidentTimelinesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 事件动态
         *
         * @param request ListIncidentTimelinesRequest
         * @return ListIncidentTimelinesResponse
         */
        public async Task<ListIncidentTimelinesResponse> ListIncidentTimelinesAsync(ListIncidentTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIncidentTimelinesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取事件列表
         *
         * @param request ListIncidentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIncidentsResponse
         */
        public ListIncidentsResponse ListIncidentsWithOptions(ListIncidentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                body["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                body["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentStatus))
            {
                body["incidentStatus"] = request.IncidentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Me))
            {
                body["me"] = request.Me;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationServiceId))
            {
                body["relationServiceId"] = request.RelationServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIncidents",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIncidentsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取事件列表
         *
         * @param request ListIncidentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIncidentsResponse
         */
        public async Task<ListIncidentsResponse> ListIncidentsWithOptionsAsync(ListIncidentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                body["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                body["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentStatus))
            {
                body["incidentStatus"] = request.IncidentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Me))
            {
                body["me"] = request.Me;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationServiceId))
            {
                body["relationServiceId"] = request.RelationServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIncidents",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIncidentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取事件列表
         *
         * @param request ListIncidentsRequest
         * @return ListIncidentsResponse
         */
        public ListIncidentsResponse ListIncidents(ListIncidentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIncidentsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取事件列表
         *
         * @param request ListIncidentsRequest
         * @return ListIncidentsResponse
         */
        public async Task<ListIncidentsResponse> ListIncidentsAsync(ListIncidentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIncidentsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取集成配置动态
         *
         * @param request ListIntegrationConfigTimelinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIntegrationConfigTimelinesResponse
         */
        public ListIntegrationConfigTimelinesResponse ListIntegrationConfigTimelinesWithOptions(ListIntegrationConfigTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationConfigTimelines",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/timeline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationConfigTimelinesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取集成配置动态
         *
         * @param request ListIntegrationConfigTimelinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIntegrationConfigTimelinesResponse
         */
        public async Task<ListIntegrationConfigTimelinesResponse> ListIntegrationConfigTimelinesWithOptionsAsync(ListIntegrationConfigTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationConfigTimelines",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/timeline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationConfigTimelinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取集成配置动态
         *
         * @param request ListIntegrationConfigTimelinesRequest
         * @return ListIntegrationConfigTimelinesResponse
         */
        public ListIntegrationConfigTimelinesResponse ListIntegrationConfigTimelines(ListIntegrationConfigTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIntegrationConfigTimelinesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取集成配置动态
         *
         * @param request ListIntegrationConfigTimelinesRequest
         * @return ListIntegrationConfigTimelinesResponse
         */
        public async Task<ListIntegrationConfigTimelinesResponse> ListIntegrationConfigTimelinesAsync(ListIntegrationConfigTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIntegrationConfigTimelinesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取集成配置列表
         *
         * @param request ListIntegrationConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIntegrationConfigsResponse
         */
        public ListIntegrationConfigsResponse ListIntegrationConfigsWithOptions(ListIntegrationConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceName))
            {
                body["monitorSourceName"] = request.MonitorSourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationConfigs",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取集成配置列表
         *
         * @param request ListIntegrationConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIntegrationConfigsResponse
         */
        public async Task<ListIntegrationConfigsResponse> ListIntegrationConfigsWithOptionsAsync(ListIntegrationConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceName))
            {
                body["monitorSourceName"] = request.MonitorSourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationConfigs",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取集成配置列表
         *
         * @param request ListIntegrationConfigsRequest
         * @return ListIntegrationConfigsResponse
         */
        public ListIntegrationConfigsResponse ListIntegrationConfigs(ListIntegrationConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIntegrationConfigsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取集成配置列表
         *
         * @param request ListIntegrationConfigsRequest
         * @return ListIntegrationConfigsResponse
         */
        public async Task<ListIntegrationConfigsResponse> ListIntegrationConfigsAsync(ListIntegrationConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIntegrationConfigsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary ListMonitorSources
         *
         * @param request ListMonitorSourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMonitorSourcesResponse
         */
        public ListMonitorSourcesResponse ListMonitorSourcesWithOptions(ListMonitorSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMonitorSources",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/monitorSource/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMonitorSourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary ListMonitorSources
         *
         * @param request ListMonitorSourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMonitorSourcesResponse
         */
        public async Task<ListMonitorSourcesResponse> ListMonitorSourcesWithOptionsAsync(ListMonitorSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMonitorSources",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/monitorSource/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMonitorSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary ListMonitorSources
         *
         * @param request ListMonitorSourcesRequest
         * @return ListMonitorSourcesResponse
         */
        public ListMonitorSourcesResponse ListMonitorSources(ListMonitorSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMonitorSourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary ListMonitorSources
         *
         * @param request ListMonitorSourcesRequest
         * @return ListMonitorSourcesResponse
         */
        public async Task<ListMonitorSourcesResponse> ListMonitorSourcesAsync(ListMonitorSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMonitorSourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 故障详情动态
         *
         * @param request ListProblemDetailOperationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProblemDetailOperationsResponse
         */
        public ListProblemDetailOperationsResponse ListProblemDetailOperationsWithOptions(ListProblemDetailOperationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeSort))
            {
                body["createTimeSort"] = request.CreateTimeSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProblemDetailOperations",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/detail/operations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProblemDetailOperationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 故障详情动态
         *
         * @param request ListProblemDetailOperationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProblemDetailOperationsResponse
         */
        public async Task<ListProblemDetailOperationsResponse> ListProblemDetailOperationsWithOptionsAsync(ListProblemDetailOperationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeSort))
            {
                body["createTimeSort"] = request.CreateTimeSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProblemDetailOperations",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/detail/operations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProblemDetailOperationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 故障详情动态
         *
         * @param request ListProblemDetailOperationsRequest
         * @return ListProblemDetailOperationsResponse
         */
        public ListProblemDetailOperationsResponse ListProblemDetailOperations(ListProblemDetailOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProblemDetailOperationsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 故障详情动态
         *
         * @param request ListProblemDetailOperationsRequest
         * @return ListProblemDetailOperationsResponse
         */
        public async Task<ListProblemDetailOperationsResponse> ListProblemDetailOperationsAsync(ListProblemDetailOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProblemDetailOperationsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询故障7天内动态
         *
         * @param request ListProblemOperationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProblemOperationsResponse
         */
        public ListProblemOperationsResponse ListProblemOperationsWithOptions(ListProblemOperationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProblemOperations",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/operations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProblemOperationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询故障7天内动态
         *
         * @param request ListProblemOperationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProblemOperationsResponse
         */
        public async Task<ListProblemOperationsResponse> ListProblemOperationsWithOptionsAsync(ListProblemOperationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProblemOperations",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/operations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProblemOperationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询故障7天内动态
         *
         * @param request ListProblemOperationsRequest
         * @return ListProblemOperationsResponse
         */
        public ListProblemOperationsResponse ListProblemOperations(ListProblemOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProblemOperationsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询故障7天内动态
         *
         * @param request ListProblemOperationsRequest
         * @return ListProblemOperationsResponse
         */
        public async Task<ListProblemOperationsResponse> ListProblemOperationsAsync(ListProblemOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProblemOperationsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询故障小计
         *
         * @param request ListProblemSubtotalsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProblemSubtotalsResponse
         */
        public ListProblemSubtotalsResponse ListProblemSubtotalsWithOptions(ListProblemSubtotalsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProblemSubtotals",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/list/subtotal",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProblemSubtotalsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询故障小计
         *
         * @param request ListProblemSubtotalsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProblemSubtotalsResponse
         */
        public async Task<ListProblemSubtotalsResponse> ListProblemSubtotalsWithOptionsAsync(ListProblemSubtotalsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProblemSubtotals",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/list/subtotal",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProblemSubtotalsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询故障小计
         *
         * @param request ListProblemSubtotalsRequest
         * @return ListProblemSubtotalsResponse
         */
        public ListProblemSubtotalsResponse ListProblemSubtotals(ListProblemSubtotalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProblemSubtotalsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询故障小计
         *
         * @param request ListProblemSubtotalsRequest
         * @return ListProblemSubtotalsResponse
         */
        public async Task<ListProblemSubtotalsResponse> ListProblemSubtotalsAsync(ListProblemSubtotalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProblemSubtotalsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询故障操作时间线列表
         *
         * @param request ListProblemTimeLinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProblemTimeLinesResponse
         */
        public ListProblemTimeLinesResponse ListProblemTimeLinesWithOptions(ListProblemTimeLinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProblemTimeLines",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/detail/timeLines",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProblemTimeLinesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询故障操作时间线列表
         *
         * @param request ListProblemTimeLinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProblemTimeLinesResponse
         */
        public async Task<ListProblemTimeLinesResponse> ListProblemTimeLinesWithOptionsAsync(ListProblemTimeLinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProblemTimeLines",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/detail/timeLines",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProblemTimeLinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询故障操作时间线列表
         *
         * @param request ListProblemTimeLinesRequest
         * @return ListProblemTimeLinesResponse
         */
        public ListProblemTimeLinesResponse ListProblemTimeLines(ListProblemTimeLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProblemTimeLinesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询故障操作时间线列表
         *
         * @param request ListProblemTimeLinesRequest
         * @return ListProblemTimeLinesResponse
         */
        public async Task<ListProblemTimeLinesResponse> ListProblemTimeLinesAsync(ListProblemTimeLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProblemTimeLinesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 故障列表查询接口
         *
         * @param request ListProblemsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProblemsResponse
         */
        public ListProblemsResponse ListProblemsWithOptions(ListProblemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AffectServiceId))
            {
                body["affectServiceId"] = request.AffectServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryEndTime))
            {
                body["discoveryEndTime"] = request.DiscoveryEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryStartTime))
            {
                body["discoveryStartTime"] = request.DiscoveryStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainHandlerId))
            {
                body["mainHandlerId"] = request.MainHandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevel))
            {
                body["problemLevel"] = request.ProblemLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemStatus))
            {
                body["problemStatus"] = request.ProblemStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeaterId))
            {
                body["repeaterId"] = request.RepeaterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreEndTime))
            {
                body["restoreEndTime"] = request.RestoreEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreStartTime))
            {
                body["restoreStartTime"] = request.RestoreStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProblems",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/listProblems",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProblemsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 故障列表查询接口
         *
         * @param request ListProblemsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProblemsResponse
         */
        public async Task<ListProblemsResponse> ListProblemsWithOptionsAsync(ListProblemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AffectServiceId))
            {
                body["affectServiceId"] = request.AffectServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryEndTime))
            {
                body["discoveryEndTime"] = request.DiscoveryEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryStartTime))
            {
                body["discoveryStartTime"] = request.DiscoveryStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainHandlerId))
            {
                body["mainHandlerId"] = request.MainHandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevel))
            {
                body["problemLevel"] = request.ProblemLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemStatus))
            {
                body["problemStatus"] = request.ProblemStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeaterId))
            {
                body["repeaterId"] = request.RepeaterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreEndTime))
            {
                body["restoreEndTime"] = request.RestoreEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreStartTime))
            {
                body["restoreStartTime"] = request.RestoreStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProblems",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/listProblems",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProblemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 故障列表查询接口
         *
         * @param request ListProblemsRequest
         * @return ListProblemsResponse
         */
        public ListProblemsResponse ListProblems(ListProblemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProblemsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 故障列表查询接口
         *
         * @param request ListProblemsRequest
         * @return ListProblemsResponse
         */
        public async Task<ListProblemsResponse> ListProblemsAsync(ListProblemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProblemsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询流转规则列表
         *
         * @param request ListRouteRulesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRouteRulesResponse
         */
        public ListRouteRulesResponse ListRouteRulesWithOptions(ListRouteRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotFilterRouteRuleDeleted))
            {
                body["notFilterRouteRuleDeleted"] = request.NotFilterRouteRuleDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["routeType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRouteRules",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRouteRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询流转规则列表
         *
         * @param request ListRouteRulesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRouteRulesResponse
         */
        public async Task<ListRouteRulesResponse> ListRouteRulesWithOptionsAsync(ListRouteRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotFilterRouteRuleDeleted))
            {
                body["notFilterRouteRuleDeleted"] = request.NotFilterRouteRuleDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["routeType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRouteRules",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRouteRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询流转规则列表
         *
         * @param request ListRouteRulesRequest
         * @return ListRouteRulesResponse
         */
        public ListRouteRulesResponse ListRouteRules(ListRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRouteRulesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询流转规则列表
         *
         * @param request ListRouteRulesRequest
         * @return ListRouteRulesResponse
         */
        public async Task<ListRouteRulesResponse> ListRouteRulesAsync(ListRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRouteRulesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取指定分配对象的流转规则
         *
         * @param request ListRouteRulesByAssignWhoIdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRouteRulesByAssignWhoIdResponse
         */
        public ListRouteRulesByAssignWhoIdResponse ListRouteRulesByAssignWhoIdWithOptions(ListRouteRulesByAssignWhoIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignWhoId))
            {
                body["assignWhoId"] = request.AssignWhoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignWhoType))
            {
                body["assignWhoType"] = request.AssignWhoType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRouteRulesByAssignWhoId",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/listByAssignWhoId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRouteRulesByAssignWhoIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定分配对象的流转规则
         *
         * @param request ListRouteRulesByAssignWhoIdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRouteRulesByAssignWhoIdResponse
         */
        public async Task<ListRouteRulesByAssignWhoIdResponse> ListRouteRulesByAssignWhoIdWithOptionsAsync(ListRouteRulesByAssignWhoIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignWhoId))
            {
                body["assignWhoId"] = request.AssignWhoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignWhoType))
            {
                body["assignWhoType"] = request.AssignWhoType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRouteRulesByAssignWhoId",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/listByAssignWhoId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRouteRulesByAssignWhoIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定分配对象的流转规则
         *
         * @param request ListRouteRulesByAssignWhoIdRequest
         * @return ListRouteRulesByAssignWhoIdResponse
         */
        public ListRouteRulesByAssignWhoIdResponse ListRouteRulesByAssignWhoId(ListRouteRulesByAssignWhoIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRouteRulesByAssignWhoIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取指定分配对象的流转规则
         *
         * @param request ListRouteRulesByAssignWhoIdRequest
         * @return ListRouteRulesByAssignWhoIdResponse
         */
        public async Task<ListRouteRulesByAssignWhoIdResponse> ListRouteRulesByAssignWhoIdAsync(ListRouteRulesByAssignWhoIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRouteRulesByAssignWhoIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据服务id查询流转规则
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRouteRulesByServiceResponse
         */
        public ListRouteRulesByServiceResponse ListRouteRulesByServiceWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRouteRulesByService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/listByService",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRouteRulesByServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据服务id查询流转规则
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRouteRulesByServiceResponse
         */
        public async Task<ListRouteRulesByServiceResponse> ListRouteRulesByServiceWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRouteRulesByService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/listByService",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRouteRulesByServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据服务id查询流转规则
         *
         * @return ListRouteRulesByServiceResponse
         */
        public ListRouteRulesByServiceResponse ListRouteRulesByService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRouteRulesByServiceWithOptions(headers, runtime);
        }

        /**
         * @summary 根据服务id查询流转规则
         *
         * @return ListRouteRulesByServiceResponse
         */
        public async Task<ListRouteRulesByServiceResponse> ListRouteRulesByServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRouteRulesByServiceWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询服务组监控源模版列表
         *
         * @param request ListServiceGroupMonitorSourceTemplatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceGroupMonitorSourceTemplatesResponse
         */
        public ListServiceGroupMonitorSourceTemplatesResponse ListServiceGroupMonitorSourceTemplatesWithOptions(ListServiceGroupMonitorSourceTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceGroupMonitorSourceTemplates",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/listServiceGroupMonitorSourceTemplates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceGroupMonitorSourceTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询服务组监控源模版列表
         *
         * @param request ListServiceGroupMonitorSourceTemplatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceGroupMonitorSourceTemplatesResponse
         */
        public async Task<ListServiceGroupMonitorSourceTemplatesResponse> ListServiceGroupMonitorSourceTemplatesWithOptionsAsync(ListServiceGroupMonitorSourceTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceGroupMonitorSourceTemplates",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/listServiceGroupMonitorSourceTemplates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceGroupMonitorSourceTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询服务组监控源模版列表
         *
         * @param request ListServiceGroupMonitorSourceTemplatesRequest
         * @return ListServiceGroupMonitorSourceTemplatesResponse
         */
        public ListServiceGroupMonitorSourceTemplatesResponse ListServiceGroupMonitorSourceTemplates(ListServiceGroupMonitorSourceTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceGroupMonitorSourceTemplatesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询服务组监控源模版列表
         *
         * @param request ListServiceGroupMonitorSourceTemplatesRequest
         * @return ListServiceGroupMonitorSourceTemplatesResponse
         */
        public async Task<ListServiceGroupMonitorSourceTemplatesResponse> ListServiceGroupMonitorSourceTemplatesAsync(ListServiceGroupMonitorSourceTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceGroupMonitorSourceTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询服务组列表
         *
         * @param request ListServiceGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceGroupsResponse
         */
        public ListServiceGroupsResponse ListServiceGroupsWithOptions(ListServiceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsScheduled))
            {
                body["isScheduled"] = request.IsScheduled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByScheduleStatus))
            {
                body["orderByScheduleStatus"] = request.OrderByScheduleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryName))
            {
                body["queryName"] = request.QueryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceGroups",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询服务组列表
         *
         * @param request ListServiceGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceGroupsResponse
         */
        public async Task<ListServiceGroupsResponse> ListServiceGroupsWithOptionsAsync(ListServiceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsScheduled))
            {
                body["isScheduled"] = request.IsScheduled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByScheduleStatus))
            {
                body["orderByScheduleStatus"] = request.OrderByScheduleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryName))
            {
                body["queryName"] = request.QueryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceGroups",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询服务组列表
         *
         * @param request ListServiceGroupsRequest
         * @return ListServiceGroupsResponse
         */
        public ListServiceGroupsResponse ListServiceGroups(ListServiceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询服务组列表
         *
         * @param request ListServiceGroupsRequest
         * @return ListServiceGroupsResponse
         */
        public async Task<ListServiceGroupsResponse> ListServiceGroupsAsync(ListServiceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据成员id查服务组
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceGroupsByUserIdResponse
         */
        public ListServiceGroupsByUserIdResponse ListServiceGroupsByUserIdWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceGroupsByUserId",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/listByUserId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceGroupsByUserIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据成员id查服务组
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceGroupsByUserIdResponse
         */
        public async Task<ListServiceGroupsByUserIdResponse> ListServiceGroupsByUserIdWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceGroupsByUserId",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/listByUserId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceGroupsByUserIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据成员id查服务组
         *
         * @return ListServiceGroupsByUserIdResponse
         */
        public ListServiceGroupsByUserIdResponse ListServiceGroupsByUserId()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceGroupsByUserIdWithOptions(headers, runtime);
        }

        /**
         * @summary 根据成员id查服务组
         *
         * @return ListServiceGroupsByUserIdResponse
         */
        public async Task<ListServiceGroupsByUserIdResponse> ListServiceGroupsByUserIdAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceGroupsByUserIdWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询服务组列表
         *
         * @param request ListServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServicesResponse
         */
        public ListServicesResponse ListServicesWithOptions(ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询服务组列表
         *
         * @param request ListServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServicesResponse
         */
        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询服务组列表
         *
         * @param request ListServicesRequest
         * @return ListServicesResponse
         */
        public ListServicesResponse ListServices(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServicesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询服务组列表
         *
         * @param request ListServicesRequest
         * @return ListServicesResponse
         */
        public async Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServicesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 原始告警列表查询
         *
         * @param request ListSourceEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSourceEventsResponse
         */
        public ListSourceEventsResponse ListSourceEventsWithOptions(ListSourceEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRowKey))
            {
                body["startRowKey"] = request.StartRowKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopRowKey))
            {
                body["stopRowKey"] = request.StopRowKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSourceEvents",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/events/listOriginalEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSourceEventsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 原始告警列表查询
         *
         * @param request ListSourceEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSourceEventsResponse
         */
        public async Task<ListSourceEventsResponse> ListSourceEventsWithOptionsAsync(ListSourceEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRowKey))
            {
                body["startRowKey"] = request.StartRowKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopRowKey))
            {
                body["stopRowKey"] = request.StopRowKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSourceEvents",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/events/listOriginalEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSourceEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 原始告警列表查询
         *
         * @param request ListSourceEventsRequest
         * @return ListSourceEventsResponse
         */
        public ListSourceEventsResponse ListSourceEvents(ListSourceEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSourceEventsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 原始告警列表查询
         *
         * @param request ListSourceEventsRequest
         * @return ListSourceEventsResponse
         */
        public async Task<ListSourceEventsResponse> ListSourceEventsAsync(ListSourceEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSourceEventsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询监控员最近10次告警
         *
         * @param request ListSourceEventsForMonitorSourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSourceEventsForMonitorSourceResponse
         */
        public ListSourceEventsForMonitorSourceResponse ListSourceEventsForMonitorSourceWithOptions(ListSourceEventsForMonitorSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceId))
            {
                body["monitorSourceId"] = request.MonitorSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSourceEventsForMonitorSource",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/events/queryLastestEvents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSourceEventsForMonitorSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询监控员最近10次告警
         *
         * @param request ListSourceEventsForMonitorSourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSourceEventsForMonitorSourceResponse
         */
        public async Task<ListSourceEventsForMonitorSourceResponse> ListSourceEventsForMonitorSourceWithOptionsAsync(ListSourceEventsForMonitorSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceId))
            {
                body["monitorSourceId"] = request.MonitorSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSourceEventsForMonitorSource",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/events/queryLastestEvents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSourceEventsForMonitorSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询监控员最近10次告警
         *
         * @param request ListSourceEventsForMonitorSourceRequest
         * @return ListSourceEventsForMonitorSourceResponse
         */
        public ListSourceEventsForMonitorSourceResponse ListSourceEventsForMonitorSource(ListSourceEventsForMonitorSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSourceEventsForMonitorSourceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询监控员最近10次告警
         *
         * @param request ListSourceEventsForMonitorSourceRequest
         * @return ListSourceEventsForMonitorSourceResponse
         */
        public async Task<ListSourceEventsForMonitorSourceResponse> ListSourceEventsForMonitorSourceAsync(ListSourceEventsForMonitorSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSourceEventsForMonitorSourceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 订阅通知服务组查询
         *
         * @param request ListSubscriptionServiceGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubscriptionServiceGroupsResponse
         */
        public ListSubscriptionServiceGroupsResponse ListSubscriptionServiceGroupsWithOptions(ListSubscriptionServiceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceIds))
            {
                body["serviceIds"] = request.ServiceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubscriptionServiceGroups",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/serviceGroup/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubscriptionServiceGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 订阅通知服务组查询
         *
         * @param request ListSubscriptionServiceGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubscriptionServiceGroupsResponse
         */
        public async Task<ListSubscriptionServiceGroupsResponse> ListSubscriptionServiceGroupsWithOptionsAsync(ListSubscriptionServiceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceIds))
            {
                body["serviceIds"] = request.ServiceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubscriptionServiceGroups",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/serviceGroup/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubscriptionServiceGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 订阅通知服务组查询
         *
         * @param request ListSubscriptionServiceGroupsRequest
         * @return ListSubscriptionServiceGroupsResponse
         */
        public ListSubscriptionServiceGroupsResponse ListSubscriptionServiceGroups(ListSubscriptionServiceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSubscriptionServiceGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 订阅通知服务组查询
         *
         * @param request ListSubscriptionServiceGroupsRequest
         * @return ListSubscriptionServiceGroupsResponse
         */
        public async Task<ListSubscriptionServiceGroupsResponse> ListSubscriptionServiceGroupsAsync(ListSubscriptionServiceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSubscriptionServiceGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通知订阅列表
         *
         * @param request ListSubscriptionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubscriptionsResponse
         */
        public ListSubscriptionsResponse ListSubscriptionsWithOptions(ListSubscriptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotFilterScopeObjectDeleted))
            {
                body["notFilterScopeObjectDeleted"] = request.NotFilterScopeObjectDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObject))
            {
                body["notifyObject"] = request.NotifyObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectType))
            {
                body["notifyObjectType"] = request.NotifyObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeObject))
            {
                body["scopeObject"] = request.ScopeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionTitle))
            {
                body["subscriptionTitle"] = request.SubscriptionTitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubscriptions",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubscriptionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 通知订阅列表
         *
         * @param request ListSubscriptionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubscriptionsResponse
         */
        public async Task<ListSubscriptionsResponse> ListSubscriptionsWithOptionsAsync(ListSubscriptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotFilterScopeObjectDeleted))
            {
                body["notFilterScopeObjectDeleted"] = request.NotFilterScopeObjectDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObject))
            {
                body["notifyObject"] = request.NotifyObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectType))
            {
                body["notifyObjectType"] = request.NotifyObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeObject))
            {
                body["scopeObject"] = request.ScopeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionTitle))
            {
                body["subscriptionTitle"] = request.SubscriptionTitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubscriptions",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubscriptionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 通知订阅列表
         *
         * @param request ListSubscriptionsRequest
         * @return ListSubscriptionsResponse
         */
        public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSubscriptionsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通知订阅列表
         *
         * @param request ListSubscriptionsRequest
         * @return ListSubscriptionsResponse
         */
        public async Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSubscriptionsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询原始告警趋势
         *
         * @param request ListTrendForSourceEventRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrendForSourceEventResponse
         */
        public ListTrendForSourceEventResponse ListTrendForSourceEventWithOptions(ListTrendForSourceEventRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeUnit))
            {
                body["timeUnit"] = request.TimeUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrendForSourceEvent",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/events/querySourceEventTrend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrendForSourceEventResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询原始告警趋势
         *
         * @param request ListTrendForSourceEventRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrendForSourceEventResponse
         */
        public async Task<ListTrendForSourceEventResponse> ListTrendForSourceEventWithOptionsAsync(ListTrendForSourceEventRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeUnit))
            {
                body["timeUnit"] = request.TimeUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrendForSourceEvent",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/events/querySourceEventTrend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrendForSourceEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询原始告警趋势
         *
         * @param request ListTrendForSourceEventRequest
         * @return ListTrendForSourceEventResponse
         */
        public ListTrendForSourceEventResponse ListTrendForSourceEvent(ListTrendForSourceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTrendForSourceEventWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询原始告警趋势
         *
         * @param request ListTrendForSourceEventRequest
         * @return ListTrendForSourceEventResponse
         */
        public async Task<ListTrendForSourceEventResponse> ListTrendForSourceEventAsync(ListTrendForSourceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTrendForSourceEventWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 用户预览
         *
         * @param request ListUserSerivceGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserSerivceGroupsResponse
         */
        public ListUserSerivceGroupsResponse ListUserSerivceGroupsWithOptions(ListUserSerivceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserSerivceGroups",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/preview/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserSerivceGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 用户预览
         *
         * @param request ListUserSerivceGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserSerivceGroupsResponse
         */
        public async Task<ListUserSerivceGroupsResponse> ListUserSerivceGroupsWithOptionsAsync(ListUserSerivceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserSerivceGroups",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/preview/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserSerivceGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 用户预览
         *
         * @param request ListUserSerivceGroupsRequest
         * @return ListUserSerivceGroupsResponse
         */
        public ListUserSerivceGroupsResponse ListUserSerivceGroups(ListUserSerivceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserSerivceGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 用户预览
         *
         * @param request ListUserSerivceGroupsRequest
         * @return ListUserSerivceGroupsResponse
         */
        public async Task<ListUserSerivceGroupsResponse> ListUserSerivceGroupsAsync(ListUserSerivceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserSerivceGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 人员列表
         *
         * @param request ListUsersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamId))
            {
                body["ramId"] = request.RamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynergyChannel))
            {
                body["synergyChannel"] = request.SynergyChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 人员列表
         *
         * @param request ListUsersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamId))
            {
                body["ramId"] = request.RamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynergyChannel))
            {
                body["synergyChannel"] = request.SynergyChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 人员列表
         *
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUsersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 人员列表
         *
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUsersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 监控数据接入API
         *
         * @param request PushMonitorRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushMonitorResponse
         */
        public PushMonitorResponse PushMonitorWithOptions(string apiKey, PushMonitorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMonitor",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/api/monitor/push/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKey),
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 监控数据接入API
         *
         * @param request PushMonitorRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushMonitorResponse
         */
        public async Task<PushMonitorResponse> PushMonitorWithOptionsAsync(string apiKey, PushMonitorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMonitor",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/api/monitor/push/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKey),
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 监控数据接入API
         *
         * @param request PushMonitorRequest
         * @return PushMonitorResponse
         */
        public PushMonitorResponse PushMonitor(string apiKey, PushMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushMonitorWithOptions(apiKey, request, headers, runtime);
        }

        /**
         * @summary 监控数据接入API
         *
         * @param request PushMonitorRequest
         * @return PushMonitorResponse
         */
        public async Task<PushMonitorResponse> PushMonitorAsync(string apiKey, PushMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushMonitorWithOptionsAsync(apiKey, request, headers, runtime);
        }

        /**
         * @summary 故障恢复
         *
         * @param request RecoverProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecoverProblemResponse
         */
        public RecoverProblemResponse RecoverProblemWithOptions(RecoverProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryTime))
            {
                body["recoveryTime"] = request.RecoveryTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoverProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/recovery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoverProblemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 故障恢复
         *
         * @param request RecoverProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecoverProblemResponse
         */
        public async Task<RecoverProblemResponse> RecoverProblemWithOptionsAsync(RecoverProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryTime))
            {
                body["recoveryTime"] = request.RecoveryTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoverProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/recovery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoverProblemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 故障恢复
         *
         * @param request RecoverProblemRequest
         * @return RecoverProblemResponse
         */
        public RecoverProblemResponse RecoverProblem(RecoverProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecoverProblemWithOptions(request, headers, runtime);
        }

        /**
         * @summary 故障恢复
         *
         * @param request RecoverProblemRequest
         * @return RecoverProblemResponse
         */
        public async Task<RecoverProblemResponse> RecoverProblemAsync(RecoverProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecoverProblemWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 刷新集成配置key
         *
         * @param request RefreshIntegrationConfigKeyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshIntegrationConfigKeyResponse
         */
        public RefreshIntegrationConfigKeyResponse RefreshIntegrationConfigKeyWithOptions(RefreshIntegrationConfigKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshIntegrationConfigKey",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/refreshKey",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshIntegrationConfigKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 刷新集成配置key
         *
         * @param request RefreshIntegrationConfigKeyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshIntegrationConfigKeyResponse
         */
        public async Task<RefreshIntegrationConfigKeyResponse> RefreshIntegrationConfigKeyWithOptionsAsync(RefreshIntegrationConfigKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshIntegrationConfigKey",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/refreshKey",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshIntegrationConfigKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 刷新集成配置key
         *
         * @param request RefreshIntegrationConfigKeyRequest
         * @return RefreshIntegrationConfigKeyResponse
         */
        public RefreshIntegrationConfigKeyResponse RefreshIntegrationConfigKey(RefreshIntegrationConfigKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RefreshIntegrationConfigKeyWithOptions(request, headers, runtime);
        }

        /**
         * @summary 刷新集成配置key
         *
         * @param request RefreshIntegrationConfigKeyRequest
         * @return RefreshIntegrationConfigKeyResponse
         */
        public async Task<RefreshIntegrationConfigKeyResponse> RefreshIntegrationConfigKeyAsync(RefreshIntegrationConfigKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RefreshIntegrationConfigKeyWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 解除集成配置
         *
         * @param request RemoveIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveIntegrationConfigResponse
         */
        public RemoveIntegrationConfigResponse RemoveIntegrationConfigWithOptions(RemoveIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveIntegrationConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 解除集成配置
         *
         * @param request RemoveIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveIntegrationConfigResponse
         */
        public async Task<RemoveIntegrationConfigResponse> RemoveIntegrationConfigWithOptionsAsync(RemoveIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveIntegrationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 解除集成配置
         *
         * @param request RemoveIntegrationConfigRequest
         * @return RemoveIntegrationConfigResponse
         */
        public RemoveIntegrationConfigResponse RemoveIntegrationConfig(RemoveIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveIntegrationConfigWithOptions(request, headers, runtime);
        }

        /**
         * @summary 解除集成配置
         *
         * @param request RemoveIntegrationConfigRequest
         * @return RemoveIntegrationConfigResponse
         */
        public async Task<RemoveIntegrationConfigResponse> RemoveIntegrationConfigAsync(RemoveIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除故障协同组
         *
         * @param request RemoveProblemServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveProblemServiceGroupResponse
         */
        public RemoveProblemServiceGroupResponse RemoveProblemServiceGroupWithOptions(RemoveProblemServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveProblemServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/removeServiceGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveProblemServiceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除故障协同组
         *
         * @param request RemoveProblemServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveProblemServiceGroupResponse
         */
        public async Task<RemoveProblemServiceGroupResponse> RemoveProblemServiceGroupWithOptionsAsync(RemoveProblemServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveProblemServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/removeServiceGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveProblemServiceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除故障协同组
         *
         * @param request RemoveProblemServiceGroupRequest
         * @return RemoveProblemServiceGroupResponse
         */
        public RemoveProblemServiceGroupResponse RemoveProblemServiceGroup(RemoveProblemServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveProblemServiceGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除故障协同组
         *
         * @param request RemoveProblemServiceGroupRequest
         * @return RemoveProblemServiceGroupResponse
         */
        public async Task<RemoveProblemServiceGroupResponse> RemoveProblemServiceGroupAsync(RemoveProblemServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveProblemServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 故障复盘
         *
         * @param request ReplayProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReplayProblemResponse
         */
        public ReplayProblemResponse ReplayProblemWithOptions(ReplayProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplayDutyUserId))
            {
                body["replayDutyUserId"] = request.ReplayDutyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplayProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/replay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplayProblemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 故障复盘
         *
         * @param request ReplayProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReplayProblemResponse
         */
        public async Task<ReplayProblemResponse> ReplayProblemWithOptionsAsync(ReplayProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplayDutyUserId))
            {
                body["replayDutyUserId"] = request.ReplayDutyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplayProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/replay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplayProblemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 故障复盘
         *
         * @param request ReplayProblemRequest
         * @return ReplayProblemResponse
         */
        public ReplayProblemResponse ReplayProblem(ReplayProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReplayProblemWithOptions(request, headers, runtime);
        }

        /**
         * @summary 故障复盘
         *
         * @param request ReplayProblemRequest
         * @return ReplayProblemResponse
         */
        public async Task<ReplayProblemResponse> ReplayProblemAsync(ReplayProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReplayProblemWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 事件响应
         *
         * @param request RespondIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RespondIncidentResponse
         */
        public RespondIncidentResponse RespondIncidentWithOptions(RespondIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentIds))
            {
                body["incidentIds"] = request.IncidentIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RespondIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/response",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RespondIncidentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 事件响应
         *
         * @param request RespondIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RespondIncidentResponse
         */
        public async Task<RespondIncidentResponse> RespondIncidentWithOptionsAsync(RespondIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentIds))
            {
                body["incidentIds"] = request.IncidentIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RespondIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/response",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RespondIncidentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 事件响应
         *
         * @param request RespondIncidentRequest
         * @return RespondIncidentResponse
         */
        public RespondIncidentResponse RespondIncident(RespondIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RespondIncidentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 事件响应
         *
         * @param request RespondIncidentRequest
         * @return RespondIncidentResponse
         */
        public async Task<RespondIncidentResponse> RespondIncidentAsync(RespondIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RespondIncidentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 故障撤销恢复
         *
         * @param request RevokeProblemRecoveryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeProblemRecoveryResponse
         */
        public RevokeProblemRecoveryResponse RevokeProblemRecoveryWithOptions(RevokeProblemRecoveryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeProblemRecovery",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeProblemRecoveryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 故障撤销恢复
         *
         * @param request RevokeProblemRecoveryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeProblemRecoveryResponse
         */
        public async Task<RevokeProblemRecoveryResponse> RevokeProblemRecoveryWithOptionsAsync(RevokeProblemRecoveryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeProblemRecovery",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeProblemRecoveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 故障撤销恢复
         *
         * @param request RevokeProblemRecoveryRequest
         * @return RevokeProblemRecoveryResponse
         */
        public RevokeProblemRecoveryResponse RevokeProblemRecovery(RevokeProblemRecoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RevokeProblemRecoveryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 故障撤销恢复
         *
         * @param request RevokeProblemRecoveryRequest
         * @return RevokeProblemRecoveryResponse
         */
        public async Task<RevokeProblemRecoveryResponse> RevokeProblemRecoveryAsync(RevokeProblemRecoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RevokeProblemRecoveryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 解绑用户
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindUserResponse
         */
        public UnbindUserResponse UnbindUserWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/unbind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 解绑用户
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindUserResponse
         */
        public async Task<UnbindUserResponse> UnbindUserWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/unbind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 解绑用户
         *
         * @return UnbindUserResponse
         */
        public UnbindUserResponse UnbindUser()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnbindUserWithOptions(headers, runtime);
        }

        /**
         * @summary 解绑用户
         *
         * @return UnbindUserResponse
         */
        public async Task<UnbindUserResponse> UnbindUserAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnbindUserWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 更新升级计划
         *
         * @param request UpdateEscalationPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEscalationPlanResponse
         */
        public UpdateEscalationPlanResponse UpdateEscalationPlanWithOptions(UpdateEscalationPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanDescription))
            {
                body["escalationPlanDescription"] = request.EscalationPlanDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanName))
            {
                body["escalationPlanName"] = request.EscalationPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanRules))
            {
                body["escalationPlanRules"] = request.EscalationPlanRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanScopeObjects))
            {
                body["escalationPlanScopeObjects"] = request.EscalationPlanScopeObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGlobal))
            {
                body["isGlobal"] = request.IsGlobal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEscalationPlan",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEscalationPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新升级计划
         *
         * @param request UpdateEscalationPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEscalationPlanResponse
         */
        public async Task<UpdateEscalationPlanResponse> UpdateEscalationPlanWithOptionsAsync(UpdateEscalationPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanDescription))
            {
                body["escalationPlanDescription"] = request.EscalationPlanDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanName))
            {
                body["escalationPlanName"] = request.EscalationPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanRules))
            {
                body["escalationPlanRules"] = request.EscalationPlanRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanScopeObjects))
            {
                body["escalationPlanScopeObjects"] = request.EscalationPlanScopeObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGlobal))
            {
                body["isGlobal"] = request.IsGlobal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEscalationPlan",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/escalationPlan/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEscalationPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新升级计划
         *
         * @param request UpdateEscalationPlanRequest
         * @return UpdateEscalationPlanResponse
         */
        public UpdateEscalationPlanResponse UpdateEscalationPlan(UpdateEscalationPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEscalationPlanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新升级计划
         *
         * @param request UpdateEscalationPlanRequest
         * @return UpdateEscalationPlanResponse
         */
        public async Task<UpdateEscalationPlanResponse> UpdateEscalationPlanAsync(UpdateEscalationPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEscalationPlanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新事件详情
         *
         * @param request UpdateIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIncidentResponse
         */
        public UpdateIncidentResponse UpdateIncidentWithOptions(UpdateIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentTitle))
            {
                body["incidentTitle"] = request.IncidentTitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIncidentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新事件详情
         *
         * @param request UpdateIncidentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIncidentResponse
         */
        public async Task<UpdateIncidentResponse> UpdateIncidentWithOptionsAsync(UpdateIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentTitle))
            {
                body["incidentTitle"] = request.IncidentTitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIncident",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/incident/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIncidentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新事件详情
         *
         * @param request UpdateIncidentRequest
         * @return UpdateIncidentResponse
         */
        public UpdateIncidentResponse UpdateIncident(UpdateIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIncidentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新事件详情
         *
         * @param request UpdateIncidentRequest
         * @return UpdateIncidentResponse
         */
        public async Task<UpdateIncidentResponse> UpdateIncidentAsync(UpdateIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIncidentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新集成配置
         *
         * @param request UpdateIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIntegrationConfigResponse
         */
        public UpdateIntegrationConfigResponse UpdateIntegrationConfigWithOptions(UpdateIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIntegrationConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新集成配置
         *
         * @param request UpdateIntegrationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIntegrationConfigResponse
         */
        public async Task<UpdateIntegrationConfigResponse> UpdateIntegrationConfigWithOptionsAsync(UpdateIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIntegrationConfig",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/integrationConfig/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIntegrationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新集成配置
         *
         * @param request UpdateIntegrationConfigRequest
         * @return UpdateIntegrationConfigResponse
         */
        public UpdateIntegrationConfigResponse UpdateIntegrationConfig(UpdateIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIntegrationConfigWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新集成配置
         *
         * @param request UpdateIntegrationConfigRequest
         * @return UpdateIntegrationConfigResponse
         */
        public async Task<UpdateIntegrationConfigResponse> UpdateIntegrationConfigAsync(UpdateIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新故障
         *
         * @param request UpdateProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProblemResponse
         */
        public UpdateProblemResponse UpdateProblemWithOptions(UpdateProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Feedback))
            {
                body["feedback"] = request.Feedback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainHandlerId))
            {
                body["mainHandlerId"] = request.MainHandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreliminaryReason))
            {
                body["preliminaryReason"] = request.PreliminaryReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemName))
            {
                body["problemName"] = request.ProblemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressSummary))
            {
                body["progressSummary"] = request.ProgressSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressSummaryRichTextId))
            {
                body["progressSummaryRichTextId"] = request.ProgressSummaryRichTextId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProblemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新故障
         *
         * @param request UpdateProblemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProblemResponse
         */
        public async Task<UpdateProblemResponse> UpdateProblemWithOptionsAsync(UpdateProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Feedback))
            {
                body["feedback"] = request.Feedback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainHandlerId))
            {
                body["mainHandlerId"] = request.MainHandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreliminaryReason))
            {
                body["preliminaryReason"] = request.PreliminaryReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemName))
            {
                body["problemName"] = request.ProblemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressSummary))
            {
                body["progressSummary"] = request.ProgressSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressSummaryRichTextId))
            {
                body["progressSummaryRichTextId"] = request.ProgressSummaryRichTextId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProblem",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProblemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新故障
         *
         * @param request UpdateProblemRequest
         * @return UpdateProblemResponse
         */
        public UpdateProblemResponse UpdateProblem(UpdateProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProblemWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新故障
         *
         * @param request UpdateProblemRequest
         * @return UpdateProblemResponse
         */
        public async Task<UpdateProblemResponse> UpdateProblemAsync(UpdateProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProblemWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新故障影响服务
         *
         * @param request UpdateProblemEffectionServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProblemEffectionServiceResponse
         */
        public UpdateProblemEffectionServiceResponse UpdateProblemEffectionServiceWithOptions(UpdateProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectionServiceId))
            {
                body["effectionServiceId"] = request.EffectionServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicUrl))
            {
                body["picUrl"] = request.PicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProblemEffectionService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/effectionService/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProblemEffectionServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新故障影响服务
         *
         * @param request UpdateProblemEffectionServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProblemEffectionServiceResponse
         */
        public async Task<UpdateProblemEffectionServiceResponse> UpdateProblemEffectionServiceWithOptionsAsync(UpdateProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectionServiceId))
            {
                body["effectionServiceId"] = request.EffectionServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicUrl))
            {
                body["picUrl"] = request.PicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProblemEffectionService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/effectionService/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProblemEffectionServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新故障影响服务
         *
         * @param request UpdateProblemEffectionServiceRequest
         * @return UpdateProblemEffectionServiceResponse
         */
        public UpdateProblemEffectionServiceResponse UpdateProblemEffectionService(UpdateProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProblemEffectionServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新故障影响服务
         *
         * @param request UpdateProblemEffectionServiceRequest
         * @return UpdateProblemEffectionServiceResponse
         */
        public async Task<UpdateProblemEffectionServiceResponse> UpdateProblemEffectionServiceAsync(UpdateProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProblemEffectionServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 改进分析更新
         *
         * @param request UpdateProblemImprovementRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProblemImprovementResponse
         */
        public UpdateProblemImprovementResponse UpdateProblemImprovementWithOptions(UpdateProblemImprovementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomProblemReason))
            {
                body["customProblemReason"] = request.CustomProblemReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoverSource))
            {
                body["discoverSource"] = request.DiscoverSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DutyDepartmentId))
            {
                body["dutyDepartmentId"] = request.DutyDepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DutyDepartmentName))
            {
                body["dutyDepartmentName"] = request.DutyDepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DutyUserId))
            {
                body["dutyUserId"] = request.DutyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InjectionMode))
            {
                body["injectionMode"] = request.InjectionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceName))
            {
                body["monitorSourceName"] = request.MonitorSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemReason))
            {
                body["problemReason"] = request.ProblemReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentActivity))
            {
                body["recentActivity"] = request.RecentActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMode))
            {
                body["recoveryMode"] = request.RecoveryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationChanges))
            {
                body["relationChanges"] = request.RelationChanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplayDutyUserId))
            {
                body["replayDutyUserId"] = request.ReplayDutyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserReport))
            {
                body["userReport"] = request.UserReport;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProblemImprovement",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/improvement/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProblemImprovementResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 改进分析更新
         *
         * @param request UpdateProblemImprovementRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProblemImprovementResponse
         */
        public async Task<UpdateProblemImprovementResponse> UpdateProblemImprovementWithOptionsAsync(UpdateProblemImprovementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomProblemReason))
            {
                body["customProblemReason"] = request.CustomProblemReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoverSource))
            {
                body["discoverSource"] = request.DiscoverSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DutyDepartmentId))
            {
                body["dutyDepartmentId"] = request.DutyDepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DutyDepartmentName))
            {
                body["dutyDepartmentName"] = request.DutyDepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DutyUserId))
            {
                body["dutyUserId"] = request.DutyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InjectionMode))
            {
                body["injectionMode"] = request.InjectionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceName))
            {
                body["monitorSourceName"] = request.MonitorSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemReason))
            {
                body["problemReason"] = request.ProblemReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentActivity))
            {
                body["recentActivity"] = request.RecentActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMode))
            {
                body["recoveryMode"] = request.RecoveryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationChanges))
            {
                body["relationChanges"] = request.RelationChanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplayDutyUserId))
            {
                body["replayDutyUserId"] = request.ReplayDutyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserReport))
            {
                body["userReport"] = request.UserReport;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProblemImprovement",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/improvement/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProblemImprovementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 改进分析更新
         *
         * @param request UpdateProblemImprovementRequest
         * @return UpdateProblemImprovementResponse
         */
        public UpdateProblemImprovementResponse UpdateProblemImprovement(UpdateProblemImprovementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProblemImprovementWithOptions(request, headers, runtime);
        }

        /**
         * @summary 改进分析更新
         *
         * @param request UpdateProblemImprovementRequest
         * @return UpdateProblemImprovementResponse
         */
        public async Task<UpdateProblemImprovementResponse> UpdateProblemImprovementAsync(UpdateProblemImprovementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProblemImprovementWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 改进措施更新
         *
         * @param request UpdateProblemMeasureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProblemMeasureResponse
         */
        public UpdateProblemMeasureResponse UpdateProblemMeasureWithOptions(UpdateProblemMeasureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStandard))
            {
                body["checkStandard"] = request.CheckStandard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUserId))
            {
                body["checkUserId"] = request.CheckUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectorId))
            {
                body["directorId"] = request.DirectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeasureId))
            {
                body["measureId"] = request.MeasureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanFinishTime))
            {
                body["planFinishTime"] = request.PlanFinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StalkerId))
            {
                body["stalkerId"] = request.StalkerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProblemMeasure",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/improvement/measure/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProblemMeasureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 改进措施更新
         *
         * @param request UpdateProblemMeasureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProblemMeasureResponse
         */
        public async Task<UpdateProblemMeasureResponse> UpdateProblemMeasureWithOptionsAsync(UpdateProblemMeasureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStandard))
            {
                body["checkStandard"] = request.CheckStandard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUserId))
            {
                body["checkUserId"] = request.CheckUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectorId))
            {
                body["directorId"] = request.DirectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeasureId))
            {
                body["measureId"] = request.MeasureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanFinishTime))
            {
                body["planFinishTime"] = request.PlanFinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StalkerId))
            {
                body["stalkerId"] = request.StalkerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProblemMeasure",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/improvement/measure/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProblemMeasureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 改进措施更新
         *
         * @param request UpdateProblemMeasureRequest
         * @return UpdateProblemMeasureResponse
         */
        public UpdateProblemMeasureResponse UpdateProblemMeasure(UpdateProblemMeasureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProblemMeasureWithOptions(request, headers, runtime);
        }

        /**
         * @summary 改进措施更新
         *
         * @param request UpdateProblemMeasureRequest
         * @return UpdateProblemMeasureResponse
         */
        public async Task<UpdateProblemMeasureResponse> UpdateProblemMeasureAsync(UpdateProblemMeasureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProblemMeasureWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新故障通知
         *
         * @param request UpdateProblemNoticeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProblemNoticeResponse
         */
        public UpdateProblemNoticeResponse UpdateProblemNoticeWithOptions(UpdateProblemNoticeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProblemNotice",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProblemNoticeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新故障通知
         *
         * @param request UpdateProblemNoticeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProblemNoticeResponse
         */
        public async Task<UpdateProblemNoticeResponse> UpdateProblemNoticeWithOptionsAsync(UpdateProblemNoticeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProblemNotice",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProblemNoticeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新故障通知
         *
         * @param request UpdateProblemNoticeRequest
         * @return UpdateProblemNoticeResponse
         */
        public UpdateProblemNoticeResponse UpdateProblemNotice(UpdateProblemNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProblemNoticeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新故障通知
         *
         * @param request UpdateProblemNoticeRequest
         * @return UpdateProblemNoticeResponse
         */
        public async Task<UpdateProblemNoticeResponse> UpdateProblemNoticeAsync(UpdateProblemNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProblemNoticeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新故障时间线节点
         *
         * @param request UpdateProblemTimelineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProblemTimelineResponse
         */
        public UpdateProblemTimelineResponse UpdateProblemTimelineWithOptions(UpdateProblemTimelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyNode))
            {
                body["keyNode"] = request.KeyNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemTimelineId))
            {
                body["problemTimelineId"] = request.ProblemTimelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                body["time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProblemTimeline",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/timeline/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProblemTimelineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新故障时间线节点
         *
         * @param request UpdateProblemTimelineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProblemTimelineResponse
         */
        public async Task<UpdateProblemTimelineResponse> UpdateProblemTimelineWithOptionsAsync(UpdateProblemTimelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyNode))
            {
                body["keyNode"] = request.KeyNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemTimelineId))
            {
                body["problemTimelineId"] = request.ProblemTimelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                body["time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProblemTimeline",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/problem/process/timeline/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProblemTimelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新故障时间线节点
         *
         * @param request UpdateProblemTimelineRequest
         * @return UpdateProblemTimelineResponse
         */
        public UpdateProblemTimelineResponse UpdateProblemTimeline(UpdateProblemTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProblemTimelineWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新故障时间线节点
         *
         * @param request UpdateProblemTimelineRequest
         * @return UpdateProblemTimelineResponse
         */
        public async Task<UpdateProblemTimelineResponse> UpdateProblemTimelineAsync(UpdateProblemTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProblemTimelineWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新富文本
         *
         * @param request UpdateRichTextRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRichTextResponse
         */
        public UpdateRichTextResponse UpdateRichTextWithOptions(UpdateRichTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichText))
            {
                body["richText"] = request.RichText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichTextId))
            {
                body["richTextId"] = request.RichTextId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRichText",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/rich/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRichTextResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新富文本
         *
         * @param request UpdateRichTextRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRichTextResponse
         */
        public async Task<UpdateRichTextResponse> UpdateRichTextWithOptionsAsync(UpdateRichTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichText))
            {
                body["richText"] = request.RichText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RichTextId))
            {
                body["richTextId"] = request.RichTextId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRichText",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/rich/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRichTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新富文本
         *
         * @param request UpdateRichTextRequest
         * @return UpdateRichTextResponse
         */
        public UpdateRichTextResponse UpdateRichText(UpdateRichTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRichTextWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新富文本
         *
         * @param request UpdateRichTextRequest
         * @return UpdateRichTextResponse
         */
        public async Task<UpdateRichTextResponse> UpdateRichTextAsync(UpdateRichTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRichTextWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新流转规则
         *
         * @param request UpdateRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRouteRuleResponse
         */
        public UpdateRouteRuleResponse UpdateRouteRuleWithOptions(UpdateRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectId))
            {
                body["assignObjectId"] = request.AssignObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectType))
            {
                body["assignObjectType"] = request.AssignObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildRuleRelation))
            {
                body["childRuleRelation"] = request.ChildRuleRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConvergenceFields))
            {
                body["convergenceFields"] = request.ConvergenceFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConvergenceType))
            {
                body["convergenceType"] = request.ConvergenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverageProblemLevels))
            {
                body["coverageProblemLevels"] = request.CoverageProblemLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effection))
            {
                body["effection"] = request.Effection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchCount))
            {
                body["matchCount"] = request.MatchCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyChannels))
            {
                body["notifyChannels"] = request.NotifyChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemEffectionServices))
            {
                body["problemEffectionServices"] = request.ProblemEffectionServices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevelGroup))
            {
                body["problemLevelGroup"] = request.ProblemLevelGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteChildRules))
            {
                body["routeChildRules"] = request.RouteChildRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["routeType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindow))
            {
                body["timeWindow"] = request.TimeWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindowUnit))
            {
                body["timeWindowUnit"] = request.TimeWindowUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/edit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRouteRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新流转规则
         *
         * @param request UpdateRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRouteRuleResponse
         */
        public async Task<UpdateRouteRuleResponse> UpdateRouteRuleWithOptionsAsync(UpdateRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectId))
            {
                body["assignObjectId"] = request.AssignObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectType))
            {
                body["assignObjectType"] = request.AssignObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildRuleRelation))
            {
                body["childRuleRelation"] = request.ChildRuleRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConvergenceFields))
            {
                body["convergenceFields"] = request.ConvergenceFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConvergenceType))
            {
                body["convergenceType"] = request.ConvergenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverageProblemLevels))
            {
                body["coverageProblemLevels"] = request.CoverageProblemLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effection))
            {
                body["effection"] = request.Effection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchCount))
            {
                body["matchCount"] = request.MatchCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyChannels))
            {
                body["notifyChannels"] = request.NotifyChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemEffectionServices))
            {
                body["problemEffectionServices"] = request.ProblemEffectionServices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevelGroup))
            {
                body["problemLevelGroup"] = request.ProblemLevelGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteChildRules))
            {
                body["routeChildRules"] = request.RouteChildRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["routeType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindow))
            {
                body["timeWindow"] = request.TimeWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindowUnit))
            {
                body["timeWindowUnit"] = request.TimeWindowUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/edit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRouteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新流转规则
         *
         * @param request UpdateRouteRuleRequest
         * @return UpdateRouteRuleResponse
         */
        public UpdateRouteRuleResponse UpdateRouteRule(UpdateRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRouteRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新流转规则
         *
         * @param request UpdateRouteRuleRequest
         * @return UpdateRouteRuleResponse
         */
        public async Task<UpdateRouteRuleResponse> UpdateRouteRuleAsync(UpdateRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRouteRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新服务
         *
         * @param request UpdateServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceResponse
         */
        public UpdateServiceResponse UpdateServiceWithOptions(UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                body["serviceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIdList))
            {
                body["serviceGroupIdList"] = request.ServiceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新服务
         *
         * @param request UpdateServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceResponse
         */
        public async Task<UpdateServiceResponse> UpdateServiceWithOptionsAsync(UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EscalationPlanId))
            {
                body["escalationPlanId"] = request.EscalationPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                body["serviceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIdList))
            {
                body["serviceGroupIdList"] = request.ServiceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新服务
         *
         * @param request UpdateServiceRequest
         * @return UpdateServiceResponse
         */
        public UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新服务
         *
         * @param request UpdateServiceRequest
         * @return UpdateServiceResponse
         */
        public async Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新服务组
         *
         * @param request UpdateServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceGroupResponse
         */
        public UpdateServiceGroupResponse UpdateServiceGroupWithOptions(UpdateServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWebhook))
            {
                body["enableWebhook"] = request.EnableWebhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceTemplates))
            {
                body["monitorSourceTemplates"] = request.MonitorSourceTemplates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupDescription))
            {
                body["serviceGroupDescription"] = request.ServiceGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupName))
            {
                body["serviceGroupName"] = request.ServiceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookLink))
            {
                body["webhookLink"] = request.WebhookLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["webhookType"] = request.WebhookType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/modify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新服务组
         *
         * @param request UpdateServiceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceGroupResponse
         */
        public async Task<UpdateServiceGroupResponse> UpdateServiceGroupWithOptionsAsync(UpdateServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWebhook))
            {
                body["enableWebhook"] = request.EnableWebhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceTemplates))
            {
                body["monitorSourceTemplates"] = request.MonitorSourceTemplates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupDescription))
            {
                body["serviceGroupDescription"] = request.ServiceGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupName))
            {
                body["serviceGroupName"] = request.ServiceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookLink))
            {
                body["webhookLink"] = request.WebhookLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["webhookType"] = request.WebhookType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceGroup",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/modify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新服务组
         *
         * @param request UpdateServiceGroupRequest
         * @return UpdateServiceGroupResponse
         */
        public UpdateServiceGroupResponse UpdateServiceGroup(UpdateServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新服务组
         *
         * @param request UpdateServiceGroupRequest
         * @return UpdateServiceGroupResponse
         */
        public async Task<UpdateServiceGroupResponse> UpdateServiceGroupAsync(UpdateServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改服务组排班
         *
         * @param request UpdateServiceGroupSchedulingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceGroupSchedulingResponse
         */
        public UpdateServiceGroupSchedulingResponse UpdateServiceGroupSchedulingWithOptions(UpdateServiceGroupSchedulingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastScheduling))
            {
                body["fastScheduling"] = request.FastScheduling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FineScheduling))
            {
                body["fineScheduling"] = request.FineScheduling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulingWay))
            {
                body["schedulingWay"] = request.SchedulingWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceGroupScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceGroupSchedulingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改服务组排班
         *
         * @param request UpdateServiceGroupSchedulingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceGroupSchedulingResponse
         */
        public async Task<UpdateServiceGroupSchedulingResponse> UpdateServiceGroupSchedulingWithOptionsAsync(UpdateServiceGroupSchedulingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastScheduling))
            {
                body["fastScheduling"] = request.FastScheduling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FineScheduling))
            {
                body["fineScheduling"] = request.FineScheduling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulingWay))
            {
                body["schedulingWay"] = request.SchedulingWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceGroupScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceGroupSchedulingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改服务组排班
         *
         * @param request UpdateServiceGroupSchedulingRequest
         * @return UpdateServiceGroupSchedulingResponse
         */
        public UpdateServiceGroupSchedulingResponse UpdateServiceGroupScheduling(UpdateServiceGroupSchedulingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceGroupSchedulingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改服务组排班
         *
         * @param request UpdateServiceGroupSchedulingRequest
         * @return UpdateServiceGroupSchedulingResponse
         */
        public async Task<UpdateServiceGroupSchedulingResponse> UpdateServiceGroupSchedulingAsync(UpdateServiceGroupSchedulingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceGroupSchedulingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改指定日期的服务组排班
         *
         * @param request UpdateServiceGroupSpecialDaySchedulingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceGroupSpecialDaySchedulingResponse
         */
        public UpdateServiceGroupSpecialDaySchedulingResponse UpdateServiceGroupSpecialDaySchedulingWithOptions(UpdateServiceGroupSpecialDaySchedulingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulingDate))
            {
                body["schedulingDate"] = request.SchedulingDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulingSpecialDays))
            {
                body["schedulingSpecialDays"] = request.SchedulingSpecialDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceGroupSpecialDayScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/updateSpecialDayScheduling",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceGroupSpecialDaySchedulingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改指定日期的服务组排班
         *
         * @param request UpdateServiceGroupSpecialDaySchedulingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceGroupSpecialDaySchedulingResponse
         */
        public async Task<UpdateServiceGroupSpecialDaySchedulingResponse> UpdateServiceGroupSpecialDaySchedulingWithOptionsAsync(UpdateServiceGroupSpecialDaySchedulingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulingDate))
            {
                body["schedulingDate"] = request.SchedulingDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulingSpecialDays))
            {
                body["schedulingSpecialDays"] = request.SchedulingSpecialDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceGroupSpecialDayScheduling",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/services/group/scheduling/updateSpecialDayScheduling",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceGroupSpecialDaySchedulingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改指定日期的服务组排班
         *
         * @param request UpdateServiceGroupSpecialDaySchedulingRequest
         * @return UpdateServiceGroupSpecialDaySchedulingResponse
         */
        public UpdateServiceGroupSpecialDaySchedulingResponse UpdateServiceGroupSpecialDayScheduling(UpdateServiceGroupSpecialDaySchedulingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceGroupSpecialDaySchedulingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改指定日期的服务组排班
         *
         * @param request UpdateServiceGroupSpecialDaySchedulingRequest
         * @return UpdateServiceGroupSpecialDaySchedulingResponse
         */
        public async Task<UpdateServiceGroupSpecialDaySchedulingResponse> UpdateServiceGroupSpecialDaySchedulingAsync(UpdateServiceGroupSpecialDaySchedulingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceGroupSpecialDaySchedulingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新通知订阅
         *
         * @param request UpdateSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSubscriptionResponse
         */
        public UpdateSubscriptionResponse UpdateSubscriptionWithOptions(UpdateSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredType))
            {
                body["expiredType"] = request.ExpiredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectList))
            {
                body["notifyObjectList"] = request.NotifyObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectType))
            {
                body["notifyObjectType"] = request.NotifyObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStrategyList))
            {
                body["notifyStrategyList"] = request.NotifyStrategyList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeObjectList))
            {
                body["scopeObjectList"] = request.ScopeObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionTitle))
            {
                body["subscriptionTitle"] = request.SubscriptionTitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSubscription",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新通知订阅
         *
         * @param request UpdateSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSubscriptionResponse
         */
        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionWithOptionsAsync(UpdateSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredType))
            {
                body["expiredType"] = request.ExpiredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectList))
            {
                body["notifyObjectList"] = request.NotifyObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectType))
            {
                body["notifyObjectType"] = request.NotifyObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStrategyList))
            {
                body["notifyStrategyList"] = request.NotifyStrategyList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeObjectList))
            {
                body["scopeObjectList"] = request.ScopeObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionTitle))
            {
                body["subscriptionTitle"] = request.SubscriptionTitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSubscription",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/notify/subscription/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新通知订阅
         *
         * @param request UpdateSubscriptionRequest
         * @return UpdateSubscriptionResponse
         */
        public UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSubscriptionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新通知订阅
         *
         * @param request UpdateSubscriptionRequest
         * @return UpdateSubscriptionResponse
         */
        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSubscriptionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新用户
         *
         * @param request UpdateUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamId))
            {
                body["ramId"] = request.RamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIdList))
            {
                body["roleIdList"] = request.RoleIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新用户
         *
         * @param request UpdateUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamId))
            {
                body["ramId"] = request.RamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIdList))
            {
                body["roleIdList"] = request.RoleIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新用户
         *
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新用户
         *
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新用户新手引导状态
         *
         * @param request UpdateUserGuideStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserGuideStatusResponse
         */
        public UpdateUserGuideStatusResponse UpdateUserGuideStatusWithOptions(UpdateUserGuideStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuideAction))
            {
                body["guideAction"] = request.GuideAction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserGuideStatus",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/update/guide/status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserGuideStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新用户新手引导状态
         *
         * @param request UpdateUserGuideStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserGuideStatusResponse
         */
        public async Task<UpdateUserGuideStatusResponse> UpdateUserGuideStatusWithOptionsAsync(UpdateUserGuideStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuideAction))
            {
                body["guideAction"] = request.GuideAction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserGuideStatus",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/user/update/guide/status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserGuideStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新用户新手引导状态
         *
         * @param request UpdateUserGuideStatusRequest
         * @return UpdateUserGuideStatusResponse
         */
        public UpdateUserGuideStatusResponse UpdateUserGuideStatus(UpdateUserGuideStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateUserGuideStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新用户新手引导状态
         *
         * @param request UpdateUserGuideStatusRequest
         * @return UpdateUserGuideStatusResponse
         */
        public async Task<UpdateUserGuideStatusResponse> UpdateUserGuideStatusAsync(UpdateUserGuideStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateUserGuideStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 验证流转规则
         *
         * @param request VerifyRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyRouteRuleResponse
         */
        public VerifyRouteRuleResponse VerifyRouteRuleWithOptions(VerifyRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestSourceEvents))
            {
                body["testSourceEvents"] = request.TestSourceEvents;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/verify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyRouteRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 验证流转规则
         *
         * @param request VerifyRouteRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyRouteRuleResponse
         */
        public async Task<VerifyRouteRuleResponse> VerifyRouteRuleWithOptionsAsync(VerifyRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestSourceEvents))
            {
                body["testSourceEvents"] = request.TestSourceEvents;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyRouteRule",
                Version = "2021-04-13",
                Protocol = "HTTPS",
                Pathname = "/routeRule/verify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyRouteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 验证流转规则
         *
         * @param request VerifyRouteRuleRequest
         * @return VerifyRouteRuleResponse
         */
        public VerifyRouteRuleResponse VerifyRouteRule(VerifyRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VerifyRouteRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 验证流转规则
         *
         * @param request VerifyRouteRuleRequest
         * @return VerifyRouteRuleResponse
         */
        public async Task<VerifyRouteRuleResponse> VerifyRouteRuleAsync(VerifyRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VerifyRouteRuleWithOptionsAsync(request, headers, runtime);
        }

    }
}
