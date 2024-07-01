// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Quotas20200510.Models;

namespace AlibabaCloud.SDK.Quotas20200510
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("quotas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary The value of the quota dimension.
         * The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
         * > This parameter is required if you set the ProductCode parameter to ecs, ecs-spec, actiontrail, or ess.
         *
         * @description The ID of the alert.
         *
         * @param request CreateQuotaAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQuotaAlarmResponse
         */
        public CreateQuotaAlarmResponse CreateQuotaAlarmWithOptions(CreateQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmName))
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaDimensions))
            {
                body["QuotaDimensions"] = request.QuotaDimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                body["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThresholdPercent))
            {
                body["ThresholdPercent"] = request.ThresholdPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThresholdType))
            {
                body["ThresholdType"] = request.ThresholdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebHook))
            {
                body["WebHook"] = request.WebHook;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuotaAlarm",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaAlarmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The value of the quota dimension.
         * The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
         * > This parameter is required if you set the ProductCode parameter to ecs, ecs-spec, actiontrail, or ess.
         *
         * @description The ID of the alert.
         *
         * @param request CreateQuotaAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQuotaAlarmResponse
         */
        public async Task<CreateQuotaAlarmResponse> CreateQuotaAlarmWithOptionsAsync(CreateQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmName))
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaDimensions))
            {
                body["QuotaDimensions"] = request.QuotaDimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                body["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThresholdPercent))
            {
                body["ThresholdPercent"] = request.ThresholdPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThresholdType))
            {
                body["ThresholdType"] = request.ThresholdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebHook))
            {
                body["WebHook"] = request.WebHook;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuotaAlarm",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The value of the quota dimension.
         * The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
         * > This parameter is required if you set the ProductCode parameter to ecs, ecs-spec, actiontrail, or ess.
         *
         * @description The ID of the alert.
         *
         * @param request CreateQuotaAlarmRequest
         * @return CreateQuotaAlarmResponse
         */
        public CreateQuotaAlarmResponse CreateQuotaAlarm(CreateQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQuotaAlarmWithOptions(request, runtime);
        }

        /**
         * @summary The value of the quota dimension.
         * The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
         * > This parameter is required if you set the ProductCode parameter to ecs, ecs-spec, actiontrail, or ess.
         *
         * @description The ID of the alert.
         *
         * @param request CreateQuotaAlarmRequest
         * @return CreateQuotaAlarmResponse
         */
        public async Task<CreateQuotaAlarmResponse> CreateQuotaAlarmAsync(CreateQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQuotaAlarmWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Submits an application to increase a quota.
         *
         * @description In this example, the operation is called to submit an application to increase the value of a quota whose ID is `q_security-groups` and whose name is Maximum Number of Security Groups. The quota belongs to Elastic Compute Service (ECS). The expected value of the quota is `804`, the application reason is `Scale Out`, and the ID of the region to which the quota belongs is `cn-hangzhou`.
         *
         * @param request CreateQuotaApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQuotaApplicationResponse
         */
        public CreateQuotaApplicationResponse CreateQuotaApplicationWithOptions(CreateQuotaApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditMode))
            {
                body["AuditMode"] = request.AuditMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesireValue))
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvLanguage))
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeType))
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuotaApplication",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaApplicationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Submits an application to increase a quota.
         *
         * @description In this example, the operation is called to submit an application to increase the value of a quota whose ID is `q_security-groups` and whose name is Maximum Number of Security Groups. The quota belongs to Elastic Compute Service (ECS). The expected value of the quota is `804`, the application reason is `Scale Out`, and the ID of the region to which the quota belongs is `cn-hangzhou`.
         *
         * @param request CreateQuotaApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQuotaApplicationResponse
         */
        public async Task<CreateQuotaApplicationResponse> CreateQuotaApplicationWithOptionsAsync(CreateQuotaApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditMode))
            {
                body["AuditMode"] = request.AuditMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesireValue))
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvLanguage))
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeType))
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuotaApplication",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Submits an application to increase a quota.
         *
         * @description In this example, the operation is called to submit an application to increase the value of a quota whose ID is `q_security-groups` and whose name is Maximum Number of Security Groups. The quota belongs to Elastic Compute Service (ECS). The expected value of the quota is `804`, the application reason is `Scale Out`, and the ID of the region to which the quota belongs is `cn-hangzhou`.
         *
         * @param request CreateQuotaApplicationRequest
         * @return CreateQuotaApplicationResponse
         */
        public CreateQuotaApplicationResponse CreateQuotaApplication(CreateQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQuotaApplicationWithOptions(request, runtime);
        }

        /**
         * @summary Submits an application to increase a quota.
         *
         * @description In this example, the operation is called to submit an application to increase the value of a quota whose ID is `q_security-groups` and whose name is Maximum Number of Security Groups. The quota belongs to Elastic Compute Service (ECS). The expected value of the quota is `804`, the application reason is `Scale Out`, and the ID of the region to which the quota belongs is `cn-hangzhou`.
         *
         * @param request CreateQuotaApplicationRequest
         * @return CreateQuotaApplicationResponse
         */
        public async Task<CreateQuotaApplicationResponse> CreateQuotaApplicationAsync(CreateQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQuotaApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Submits a quota increase application. After you add a quota item to a quota template, the system automatically submits quota applications only for new members in the resource directory. The quota values for existing members remain unchanged. If you want to increase the quota values of existing members, you can submit a quota application for the members by applying quota templates to the members.
         *
         * @description ### [](#)QPS limit
         * You can add a maximum of 10 quota items to a quota template at a time.
         *
         * @param request CreateQuotaApplicationsForTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQuotaApplicationsForTemplateResponse
         */
        public CreateQuotaApplicationsForTemplateResponse CreateQuotaApplicationsForTemplateWithOptions(CreateQuotaApplicationsForTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUids))
            {
                body["AliyunUids"] = request.AliyunUids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesireValue))
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvLanguage))
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeType))
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuotaApplicationsForTemplate",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaApplicationsForTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Submits a quota increase application. After you add a quota item to a quota template, the system automatically submits quota applications only for new members in the resource directory. The quota values for existing members remain unchanged. If you want to increase the quota values of existing members, you can submit a quota application for the members by applying quota templates to the members.
         *
         * @description ### [](#)QPS limit
         * You can add a maximum of 10 quota items to a quota template at a time.
         *
         * @param request CreateQuotaApplicationsForTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQuotaApplicationsForTemplateResponse
         */
        public async Task<CreateQuotaApplicationsForTemplateResponse> CreateQuotaApplicationsForTemplateWithOptionsAsync(CreateQuotaApplicationsForTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUids))
            {
                body["AliyunUids"] = request.AliyunUids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesireValue))
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvLanguage))
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeType))
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuotaApplicationsForTemplate",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaApplicationsForTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Submits a quota increase application. After you add a quota item to a quota template, the system automatically submits quota applications only for new members in the resource directory. The quota values for existing members remain unchanged. If you want to increase the quota values of existing members, you can submit a quota application for the members by applying quota templates to the members.
         *
         * @description ### [](#)QPS limit
         * You can add a maximum of 10 quota items to a quota template at a time.
         *
         * @param request CreateQuotaApplicationsForTemplateRequest
         * @return CreateQuotaApplicationsForTemplateResponse
         */
        public CreateQuotaApplicationsForTemplateResponse CreateQuotaApplicationsForTemplate(CreateQuotaApplicationsForTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQuotaApplicationsForTemplateWithOptions(request, runtime);
        }

        /**
         * @summary Submits a quota increase application. After you add a quota item to a quota template, the system automatically submits quota applications only for new members in the resource directory. The quota values for existing members remain unchanged. If you want to increase the quota values of existing members, you can submit a quota application for the members by applying quota templates to the members.
         *
         * @description ### [](#)QPS limit
         * You can add a maximum of 10 quota items to a quota template at a time.
         *
         * @param request CreateQuotaApplicationsForTemplateRequest
         * @return CreateQuotaApplicationsForTemplateResponse
         */
        public async Task<CreateQuotaApplicationsForTemplateResponse> CreateQuotaApplicationsForTemplateAsync(CreateQuotaApplicationsForTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQuotaApplicationsForTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a quota template by using the management account of a resource directory. After you create a quota template, if a member is added to the resource directory, the quota template automatically submits a quota increase request for the member. The quota values for existing members remain unchanged. You can use a quota template to apply for increases on multiple quotas at the same time. This automated approach improves the efficiency of quota management across your organization.
         *
         * @description ### [](#)Prerequisites
         * You must set the `ServiceStatus` parameter to `1`. This ensures that the quota template is enabled.
         * You can call the [GetQuotaTemplateServiceStatus](https://help.aliyun.com/document_detail/450407.html) operation to query the status of a quota template. If the `ServiceStatus` parameter is set to `0` or `-1`, you must call the [ModifyQuotaTemplateServiceStatus](https://help.aliyun.com/document_detail/450406.html) operation to set the ServiceStatus parameter to `1`.
         *
         * @param request CreateTemplateQuotaItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTemplateQuotaItemResponse
         */
        public CreateTemplateQuotaItemResponse CreateTemplateQuotaItemWithOptions(CreateTemplateQuotaItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesireValue))
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvLanguage))
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeType))
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplateQuotaItem",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateQuotaItemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a quota template by using the management account of a resource directory. After you create a quota template, if a member is added to the resource directory, the quota template automatically submits a quota increase request for the member. The quota values for existing members remain unchanged. You can use a quota template to apply for increases on multiple quotas at the same time. This automated approach improves the efficiency of quota management across your organization.
         *
         * @description ### [](#)Prerequisites
         * You must set the `ServiceStatus` parameter to `1`. This ensures that the quota template is enabled.
         * You can call the [GetQuotaTemplateServiceStatus](https://help.aliyun.com/document_detail/450407.html) operation to query the status of a quota template. If the `ServiceStatus` parameter is set to `0` or `-1`, you must call the [ModifyQuotaTemplateServiceStatus](https://help.aliyun.com/document_detail/450406.html) operation to set the ServiceStatus parameter to `1`.
         *
         * @param request CreateTemplateQuotaItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTemplateQuotaItemResponse
         */
        public async Task<CreateTemplateQuotaItemResponse> CreateTemplateQuotaItemWithOptionsAsync(CreateTemplateQuotaItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesireValue))
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvLanguage))
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeType))
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplateQuotaItem",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateQuotaItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a quota template by using the management account of a resource directory. After you create a quota template, if a member is added to the resource directory, the quota template automatically submits a quota increase request for the member. The quota values for existing members remain unchanged. You can use a quota template to apply for increases on multiple quotas at the same time. This automated approach improves the efficiency of quota management across your organization.
         *
         * @description ### [](#)Prerequisites
         * You must set the `ServiceStatus` parameter to `1`. This ensures that the quota template is enabled.
         * You can call the [GetQuotaTemplateServiceStatus](https://help.aliyun.com/document_detail/450407.html) operation to query the status of a quota template. If the `ServiceStatus` parameter is set to `0` or `-1`, you must call the [ModifyQuotaTemplateServiceStatus](https://help.aliyun.com/document_detail/450406.html) operation to set the ServiceStatus parameter to `1`.
         *
         * @param request CreateTemplateQuotaItemRequest
         * @return CreateTemplateQuotaItemResponse
         */
        public CreateTemplateQuotaItemResponse CreateTemplateQuotaItem(CreateTemplateQuotaItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateQuotaItemWithOptions(request, runtime);
        }

        /**
         * @summary Creates a quota template by using the management account of a resource directory. After you create a quota template, if a member is added to the resource directory, the quota template automatically submits a quota increase request for the member. The quota values for existing members remain unchanged. You can use a quota template to apply for increases on multiple quotas at the same time. This automated approach improves the efficiency of quota management across your organization.
         *
         * @description ### [](#)Prerequisites
         * You must set the `ServiceStatus` parameter to `1`. This ensures that the quota template is enabled.
         * You can call the [GetQuotaTemplateServiceStatus](https://help.aliyun.com/document_detail/450407.html) operation to query the status of a quota template. If the `ServiceStatus` parameter is set to `0` or `-1`, you must call the [ModifyQuotaTemplateServiceStatus](https://help.aliyun.com/document_detail/450406.html) operation to set the ServiceStatus parameter to `1`.
         *
         * @param request CreateTemplateQuotaItemRequest
         * @return CreateTemplateQuotaItemResponse
         */
        public async Task<CreateTemplateQuotaItemResponse> CreateTemplateQuotaItemAsync(CreateTemplateQuotaItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateQuotaItemWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a quota alert.
         *
         * @description In this example, the operation is called to delete a quota alert whose ID is `6b512ab7-da3a-4142-b529-2b2a9294****`.
         *
         * @param request DeleteQuotaAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteQuotaAlarmResponse
         */
        public DeleteQuotaAlarmResponse DeleteQuotaAlarmWithOptions(DeleteQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmId))
            {
                body["AlarmId"] = request.AlarmId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQuotaAlarm",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQuotaAlarmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a quota alert.
         *
         * @description In this example, the operation is called to delete a quota alert whose ID is `6b512ab7-da3a-4142-b529-2b2a9294****`.
         *
         * @param request DeleteQuotaAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteQuotaAlarmResponse
         */
        public async Task<DeleteQuotaAlarmResponse> DeleteQuotaAlarmWithOptionsAsync(DeleteQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmId))
            {
                body["AlarmId"] = request.AlarmId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQuotaAlarm",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQuotaAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a quota alert.
         *
         * @description In this example, the operation is called to delete a quota alert whose ID is `6b512ab7-da3a-4142-b529-2b2a9294****`.
         *
         * @param request DeleteQuotaAlarmRequest
         * @return DeleteQuotaAlarmResponse
         */
        public DeleteQuotaAlarmResponse DeleteQuotaAlarm(DeleteQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQuotaAlarmWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a quota alert.
         *
         * @description In this example, the operation is called to delete a quota alert whose ID is `6b512ab7-da3a-4142-b529-2b2a9294****`.
         *
         * @param request DeleteQuotaAlarmRequest
         * @return DeleteQuotaAlarmResponse
         */
        public async Task<DeleteQuotaAlarmResponse> DeleteQuotaAlarmAsync(DeleteQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQuotaAlarmWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a quota template by using the management account of a resource directory. After you delete a quota template, if a member is added to the resource directory, the quota template no longer automatically submits a quota increase request for the member.
         *
         * @param request DeleteTemplateQuotaItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTemplateQuotaItemResponse
         */
        public DeleteTemplateQuotaItemResponse DeleteTemplateQuotaItemWithOptions(DeleteTemplateQuotaItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplateQuotaItem",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateQuotaItemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a quota template by using the management account of a resource directory. After you delete a quota template, if a member is added to the resource directory, the quota template no longer automatically submits a quota increase request for the member.
         *
         * @param request DeleteTemplateQuotaItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTemplateQuotaItemResponse
         */
        public async Task<DeleteTemplateQuotaItemResponse> DeleteTemplateQuotaItemWithOptionsAsync(DeleteTemplateQuotaItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplateQuotaItem",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateQuotaItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a quota template by using the management account of a resource directory. After you delete a quota template, if a member is added to the resource directory, the quota template no longer automatically submits a quota increase request for the member.
         *
         * @param request DeleteTemplateQuotaItemRequest
         * @return DeleteTemplateQuotaItemResponse
         */
        public DeleteTemplateQuotaItemResponse DeleteTemplateQuotaItem(DeleteTemplateQuotaItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateQuotaItemWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a quota template by using the management account of a resource directory. After you delete a quota template, if a member is added to the resource directory, the quota template no longer automatically submits a quota increase request for the member.
         *
         * @param request DeleteTemplateQuotaItemRequest
         * @return DeleteTemplateQuotaItemResponse
         */
        public async Task<DeleteTemplateQuotaItemResponse> DeleteTemplateQuotaItemAsync(DeleteTemplateQuotaItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateQuotaItemWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of the specified quota.
         *
         * @description In this example, the operation is called to query the details of a quota whose ID is `q_security-groups` and whose name is Maximum Number of Security Groups. This quota belongs to Elastic Compute Service (ECS). The query result shows the details of the quota. The details include the name, ID, description, quota value, used quota, unit, and dimension of the quota. In this example, the quota name is `Maximum Number of Security Groups`. The quota ID is `q_security-groups`. The description is `The maximum number of security groups that can be created for the current account`. The quota value is `801`. The used quota is `26`. The quota unit is `Number of security groups`. The quota dimension is `{"regionId":"cn-hangzhou"}`.
         *
         * @param request GetProductQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProductQuotaResponse
         */
        public GetProductQuotaResponse GetProductQuotaWithOptions(GetProductQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductQuota",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of the specified quota.
         *
         * @description In this example, the operation is called to query the details of a quota whose ID is `q_security-groups` and whose name is Maximum Number of Security Groups. This quota belongs to Elastic Compute Service (ECS). The query result shows the details of the quota. The details include the name, ID, description, quota value, used quota, unit, and dimension of the quota. In this example, the quota name is `Maximum Number of Security Groups`. The quota ID is `q_security-groups`. The description is `The maximum number of security groups that can be created for the current account`. The quota value is `801`. The used quota is `26`. The quota unit is `Number of security groups`. The quota dimension is `{"regionId":"cn-hangzhou"}`.
         *
         * @param request GetProductQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProductQuotaResponse
         */
        public async Task<GetProductQuotaResponse> GetProductQuotaWithOptionsAsync(GetProductQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductQuota",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of the specified quota.
         *
         * @description In this example, the operation is called to query the details of a quota whose ID is `q_security-groups` and whose name is Maximum Number of Security Groups. This quota belongs to Elastic Compute Service (ECS). The query result shows the details of the quota. The details include the name, ID, description, quota value, used quota, unit, and dimension of the quota. In this example, the quota name is `Maximum Number of Security Groups`. The quota ID is `q_security-groups`. The description is `The maximum number of security groups that can be created for the current account`. The quota value is `801`. The used quota is `26`. The quota unit is `Number of security groups`. The quota dimension is `{"regionId":"cn-hangzhou"}`.
         *
         * @param request GetProductQuotaRequest
         * @return GetProductQuotaResponse
         */
        public GetProductQuotaResponse GetProductQuota(GetProductQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProductQuotaWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of the specified quota.
         *
         * @description In this example, the operation is called to query the details of a quota whose ID is `q_security-groups` and whose name is Maximum Number of Security Groups. This quota belongs to Elastic Compute Service (ECS). The query result shows the details of the quota. The details include the name, ID, description, quota value, used quota, unit, and dimension of the quota. In this example, the quota name is `Maximum Number of Security Groups`. The quota ID is `q_security-groups`. The description is `The maximum number of security groups that can be created for the current account`. The quota value is `801`. The used quota is `26`. The quota unit is `Number of security groups`. The quota dimension is `{"regionId":"cn-hangzhou"}`.
         *
         * @param request GetProductQuotaRequest
         * @return GetProductQuotaResponse
         */
        public async Task<GetProductQuotaResponse> GetProductQuotaAsync(GetProductQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProductQuotaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a quota dimension that is supported by an Alibaba Cloud service.
         *
         * @description In this example, the operation is called to query the details of a quota dimension whose key is `regionId`. The quota dimension belongs to Elastic Compute Service (ECS) Quotas by Instance Type whose service code is ecs-spec. The following query results are returned:
         * *   The values of the quota dimension include `cn-shenzhen`, `cn-beijing`, and `cn-hangzhou`.
         * *   The name of the quota dimension is `region`.
         *
         * @param request GetProductQuotaDimensionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProductQuotaDimensionResponse
         */
        public GetProductQuotaDimensionResponse GetProductQuotaDimensionWithOptions(GetProductQuotaDimensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DependentDimensions))
            {
                body["DependentDimensions"] = request.DependentDimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DimensionKey))
            {
                body["DimensionKey"] = request.DimensionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductQuotaDimension",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductQuotaDimensionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a quota dimension that is supported by an Alibaba Cloud service.
         *
         * @description In this example, the operation is called to query the details of a quota dimension whose key is `regionId`. The quota dimension belongs to Elastic Compute Service (ECS) Quotas by Instance Type whose service code is ecs-spec. The following query results are returned:
         * *   The values of the quota dimension include `cn-shenzhen`, `cn-beijing`, and `cn-hangzhou`.
         * *   The name of the quota dimension is `region`.
         *
         * @param request GetProductQuotaDimensionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProductQuotaDimensionResponse
         */
        public async Task<GetProductQuotaDimensionResponse> GetProductQuotaDimensionWithOptionsAsync(GetProductQuotaDimensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DependentDimensions))
            {
                body["DependentDimensions"] = request.DependentDimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DimensionKey))
            {
                body["DimensionKey"] = request.DimensionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductQuotaDimension",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductQuotaDimensionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a quota dimension that is supported by an Alibaba Cloud service.
         *
         * @description In this example, the operation is called to query the details of a quota dimension whose key is `regionId`. The quota dimension belongs to Elastic Compute Service (ECS) Quotas by Instance Type whose service code is ecs-spec. The following query results are returned:
         * *   The values of the quota dimension include `cn-shenzhen`, `cn-beijing`, and `cn-hangzhou`.
         * *   The name of the quota dimension is `region`.
         *
         * @param request GetProductQuotaDimensionRequest
         * @return GetProductQuotaDimensionResponse
         */
        public GetProductQuotaDimensionResponse GetProductQuotaDimension(GetProductQuotaDimensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProductQuotaDimensionWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a quota dimension that is supported by an Alibaba Cloud service.
         *
         * @description In this example, the operation is called to query the details of a quota dimension whose key is `regionId`. The quota dimension belongs to Elastic Compute Service (ECS) Quotas by Instance Type whose service code is ecs-spec. The following query results are returned:
         * *   The values of the quota dimension include `cn-shenzhen`, `cn-beijing`, and `cn-hangzhou`.
         * *   The name of the quota dimension is `region`.
         *
         * @param request GetProductQuotaDimensionRequest
         * @return GetProductQuotaDimensionResponse
         */
        public async Task<GetProductQuotaDimensionResponse> GetProductQuotaDimensionAsync(GetProductQuotaDimensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProductQuotaDimensionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary In this example, the operation is called to query the details of a quota alert. The details of the alert are returned. The query results include the alert ID, alert name, alert contact, and time when the quota alert was created.
         *
         * @description In this example, the operation is called to query the details of a quota alert whose ID is `78d7e436-4b25-4897-84b5-d7b656bb****`. The details of the alert are returned. The query result includes the alert ID, alert name, alert contact, and the time when the quota alert was created.
         *
         * @param request GetQuotaAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaAlarmResponse
         */
        public GetQuotaAlarmResponse GetQuotaAlarmWithOptions(GetQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmId))
            {
                body["AlarmId"] = request.AlarmId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaAlarm",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaAlarmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary In this example, the operation is called to query the details of a quota alert. The details of the alert are returned. The query results include the alert ID, alert name, alert contact, and time when the quota alert was created.
         *
         * @description In this example, the operation is called to query the details of a quota alert whose ID is `78d7e436-4b25-4897-84b5-d7b656bb****`. The details of the alert are returned. The query result includes the alert ID, alert name, alert contact, and the time when the quota alert was created.
         *
         * @param request GetQuotaAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaAlarmResponse
         */
        public async Task<GetQuotaAlarmResponse> GetQuotaAlarmWithOptionsAsync(GetQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmId))
            {
                body["AlarmId"] = request.AlarmId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaAlarm",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary In this example, the operation is called to query the details of a quota alert. The details of the alert are returned. The query results include the alert ID, alert name, alert contact, and time when the quota alert was created.
         *
         * @description In this example, the operation is called to query the details of a quota alert whose ID is `78d7e436-4b25-4897-84b5-d7b656bb****`. The details of the alert are returned. The query result includes the alert ID, alert name, alert contact, and the time when the quota alert was created.
         *
         * @param request GetQuotaAlarmRequest
         * @return GetQuotaAlarmResponse
         */
        public GetQuotaAlarmResponse GetQuotaAlarm(GetQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaAlarmWithOptions(request, runtime);
        }

        /**
         * @summary In this example, the operation is called to query the details of a quota alert. The details of the alert are returned. The query results include the alert ID, alert name, alert contact, and time when the quota alert was created.
         *
         * @description In this example, the operation is called to query the details of a quota alert whose ID is `78d7e436-4b25-4897-84b5-d7b656bb****`. The details of the alert are returned. The query result includes the alert ID, alert name, alert contact, and the time when the quota alert was created.
         *
         * @param request GetQuotaAlarmRequest
         * @return GetQuotaAlarmResponse
         */
        public async Task<GetQuotaAlarmResponse> GetQuotaAlarmAsync(GetQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaAlarmWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details about a specified application that is submitted to increase a quota.
         *
         * @description In this example, the operation is called to query the details about an application whose ID is `d314d6ae-867d-484c-9009-3d421a80****`. The query result shows the details about the application. The details include the application ID, application time, expected quota value, and application result.
         *
         * @param request GetQuotaApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaApplicationResponse
         */
        public GetQuotaApplicationResponse GetQuotaApplicationWithOptions(GetQuotaApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaApplication",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaApplicationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a specified application that is submitted to increase a quota.
         *
         * @description In this example, the operation is called to query the details about an application whose ID is `d314d6ae-867d-484c-9009-3d421a80****`. The query result shows the details about the application. The details include the application ID, application time, expected quota value, and application result.
         *
         * @param request GetQuotaApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaApplicationResponse
         */
        public async Task<GetQuotaApplicationResponse> GetQuotaApplicationWithOptionsAsync(GetQuotaApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaApplication",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a specified application that is submitted to increase a quota.
         *
         * @description In this example, the operation is called to query the details about an application whose ID is `d314d6ae-867d-484c-9009-3d421a80****`. The query result shows the details about the application. The details include the application ID, application time, expected quota value, and application result.
         *
         * @param request GetQuotaApplicationRequest
         * @return GetQuotaApplicationResponse
         */
        public GetQuotaApplicationResponse GetQuotaApplication(GetQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaApplicationWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details about a specified application that is submitted to increase a quota.
         *
         * @description In this example, the operation is called to query the details about an application whose ID is `d314d6ae-867d-484c-9009-3d421a80****`. The query result shows the details about the application. The details include the application ID, application time, expected quota value, and application result.
         *
         * @param request GetQuotaApplicationRequest
         * @return GetQuotaApplicationResponse
         */
        public async Task<GetQuotaApplicationResponse> GetQuotaApplicationAsync(GetQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about quota application approval, such as the average amount of time required for approval, whether approval reminders are supported, and the interval between two consecutive approval reminders.
         *
         * @description ### [](#)Prerequisites
         * Make sure that you have created an application for quota increase. For more information, see [CreateQuotaApplication](https://help.aliyun.com/document_detail/440566.html).
         *
         * @param request GetQuotaApplicationApprovalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaApplicationApprovalResponse
         */
        public GetQuotaApplicationApprovalResponse GetQuotaApplicationApprovalWithOptions(GetQuotaApplicationApprovalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaApplicationApproval",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaApplicationApprovalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about quota application approval, such as the average amount of time required for approval, whether approval reminders are supported, and the interval between two consecutive approval reminders.
         *
         * @description ### [](#)Prerequisites
         * Make sure that you have created an application for quota increase. For more information, see [CreateQuotaApplication](https://help.aliyun.com/document_detail/440566.html).
         *
         * @param request GetQuotaApplicationApprovalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaApplicationApprovalResponse
         */
        public async Task<GetQuotaApplicationApprovalResponse> GetQuotaApplicationApprovalWithOptionsAsync(GetQuotaApplicationApprovalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaApplicationApproval",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaApplicationApprovalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about quota application approval, such as the average amount of time required for approval, whether approval reminders are supported, and the interval between two consecutive approval reminders.
         *
         * @description ### [](#)Prerequisites
         * Make sure that you have created an application for quota increase. For more information, see [CreateQuotaApplication](https://help.aliyun.com/document_detail/440566.html).
         *
         * @param request GetQuotaApplicationApprovalRequest
         * @return GetQuotaApplicationApprovalResponse
         */
        public GetQuotaApplicationApprovalResponse GetQuotaApplicationApproval(GetQuotaApplicationApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaApplicationApprovalWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about quota application approval, such as the average amount of time required for approval, whether approval reminders are supported, and the interval between two consecutive approval reminders.
         *
         * @description ### [](#)Prerequisites
         * Make sure that you have created an application for quota increase. For more information, see [CreateQuotaApplication](https://help.aliyun.com/document_detail/440566.html).
         *
         * @param request GetQuotaApplicationApprovalRequest
         * @return GetQuotaApplicationApprovalResponse
         */
        public async Task<GetQuotaApplicationApprovalResponse> GetQuotaApplicationApprovalAsync(GetQuotaApplicationApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaApplicationApprovalWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the status of a quota template.
         *
         * @param request GetQuotaTemplateServiceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaTemplateServiceStatusResponse
         */
        public GetQuotaTemplateServiceStatusResponse GetQuotaTemplateServiceStatusWithOptions(GetQuotaTemplateServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDirectoryId))
            {
                body["ResourceDirectoryId"] = request.ResourceDirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaTemplateServiceStatus",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaTemplateServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the status of a quota template.
         *
         * @param request GetQuotaTemplateServiceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaTemplateServiceStatusResponse
         */
        public async Task<GetQuotaTemplateServiceStatusResponse> GetQuotaTemplateServiceStatusWithOptionsAsync(GetQuotaTemplateServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDirectoryId))
            {
                body["ResourceDirectoryId"] = request.ResourceDirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaTemplateServiceStatus",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaTemplateServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the status of a quota template.
         *
         * @param request GetQuotaTemplateServiceStatusRequest
         * @return GetQuotaTemplateServiceStatusResponse
         */
        public GetQuotaTemplateServiceStatusResponse GetQuotaTemplateServiceStatus(GetQuotaTemplateServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaTemplateServiceStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the status of a quota template.
         *
         * @param request GetQuotaTemplateServiceStatusRequest
         * @return GetQuotaTemplateServiceStatusResponse
         */
        public async Task<GetQuotaTemplateServiceStatusResponse> GetQuotaTemplateServiceStatusAsync(GetQuotaTemplateServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaTemplateServiceStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the alert records.
         *
         * @param request ListAlarmHistoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAlarmHistoriesResponse
         */
        public ListAlarmHistoriesResponse ListAlarmHistoriesWithOptions(ListAlarmHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmId))
            {
                body["AlarmId"] = request.AlarmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlarmHistories",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlarmHistoriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the alert records.
         *
         * @param request ListAlarmHistoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAlarmHistoriesResponse
         */
        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesWithOptionsAsync(ListAlarmHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmId))
            {
                body["AlarmId"] = request.AlarmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlarmHistories",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlarmHistoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the alert records.
         *
         * @param request ListAlarmHistoriesRequest
         * @return ListAlarmHistoriesResponse
         */
        public ListAlarmHistoriesResponse ListAlarmHistories(ListAlarmHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlarmHistoriesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the alert records.
         *
         * @param request ListAlarmHistoriesRequest
         * @return ListAlarmHistoriesResponse
         */
        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesAsync(ListAlarmHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlarmHistoriesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the quotas on which a specified quota depends.
         *
         * @description In this example, the operation is called to query the quotas on which a Container Service for Kubernetes (ACK) quota whose ID is `q_i5uzm3` depends. This quota is the maximum number of nodes that can be created in an ACK cluster. The query result indicates that the specified quota depends on the following three quotas:
         * *   An Elastic Compute Service (ECS) quota whose ID is `q_elastic-network-interfaces`. This quota is the maximum number of ENIs (Secondary ENIs) that can be owned by an Alibaba Cloud account. The quota is available in the following regions: `cn-shenzhen`, `cn-beijing`, and `cn-hangzhou`.
         * *   A Server Load Balancer (SLB) quota whose ID is `q_fh20b0`. This quota is the number of servers that can be attached to the backend of an SLB instance.
         * *   An SLB quota whose ID is `q_3mmbsp`. This quota is the number of SLB instances that can be owned by an Alibaba Cloud account.
         *
         * @param request ListDependentQuotasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDependentQuotasResponse
         */
        public ListDependentQuotasResponse ListDependentQuotasWithOptions(ListDependentQuotasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDependentQuotas",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDependentQuotasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the quotas on which a specified quota depends.
         *
         * @description In this example, the operation is called to query the quotas on which a Container Service for Kubernetes (ACK) quota whose ID is `q_i5uzm3` depends. This quota is the maximum number of nodes that can be created in an ACK cluster. The query result indicates that the specified quota depends on the following three quotas:
         * *   An Elastic Compute Service (ECS) quota whose ID is `q_elastic-network-interfaces`. This quota is the maximum number of ENIs (Secondary ENIs) that can be owned by an Alibaba Cloud account. The quota is available in the following regions: `cn-shenzhen`, `cn-beijing`, and `cn-hangzhou`.
         * *   A Server Load Balancer (SLB) quota whose ID is `q_fh20b0`. This quota is the number of servers that can be attached to the backend of an SLB instance.
         * *   An SLB quota whose ID is `q_3mmbsp`. This quota is the number of SLB instances that can be owned by an Alibaba Cloud account.
         *
         * @param request ListDependentQuotasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDependentQuotasResponse
         */
        public async Task<ListDependentQuotasResponse> ListDependentQuotasWithOptionsAsync(ListDependentQuotasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDependentQuotas",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDependentQuotasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the quotas on which a specified quota depends.
         *
         * @description In this example, the operation is called to query the quotas on which a Container Service for Kubernetes (ACK) quota whose ID is `q_i5uzm3` depends. This quota is the maximum number of nodes that can be created in an ACK cluster. The query result indicates that the specified quota depends on the following three quotas:
         * *   An Elastic Compute Service (ECS) quota whose ID is `q_elastic-network-interfaces`. This quota is the maximum number of ENIs (Secondary ENIs) that can be owned by an Alibaba Cloud account. The quota is available in the following regions: `cn-shenzhen`, `cn-beijing`, and `cn-hangzhou`.
         * *   A Server Load Balancer (SLB) quota whose ID is `q_fh20b0`. This quota is the number of servers that can be attached to the backend of an SLB instance.
         * *   An SLB quota whose ID is `q_3mmbsp`. This quota is the number of SLB instances that can be owned by an Alibaba Cloud account.
         *
         * @param request ListDependentQuotasRequest
         * @return ListDependentQuotasResponse
         */
        public ListDependentQuotasResponse ListDependentQuotas(ListDependentQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDependentQuotasWithOptions(request, runtime);
        }

        /**
         * @summary Queries the quotas on which a specified quota depends.
         *
         * @description In this example, the operation is called to query the quotas on which a Container Service for Kubernetes (ACK) quota whose ID is `q_i5uzm3` depends. This quota is the maximum number of nodes that can be created in an ACK cluster. The query result indicates that the specified quota depends on the following three quotas:
         * *   An Elastic Compute Service (ECS) quota whose ID is `q_elastic-network-interfaces`. This quota is the maximum number of ENIs (Secondary ENIs) that can be owned by an Alibaba Cloud account. The quota is available in the following regions: `cn-shenzhen`, `cn-beijing`, and `cn-hangzhou`.
         * *   A Server Load Balancer (SLB) quota whose ID is `q_fh20b0`. This quota is the number of servers that can be attached to the backend of an SLB instance.
         * *   An SLB quota whose ID is `q_3mmbsp`. This quota is the number of SLB instances that can be owned by an Alibaba Cloud account.
         *
         * @param request ListDependentQuotasRequest
         * @return ListDependentQuotasResponse
         */
        public async Task<ListDependentQuotasResponse> ListDependentQuotasAsync(ListDependentQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDependentQuotasWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the dimension groups of an Alibaba Cloud service.
         *
         * @description This topic provides an example on how to call the ListProductDimensionGroups operation to query the dimension groups of Object Storage Service (OSS). In this example, a dimension group is returned. The group name is `OSS_Group`, the group code is `oss_wf1ngqmd7q`, and the group key is `chargeType`.
         *
         * @param request ListProductDimensionGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductDimensionGroupsResponse
         */
        public ListProductDimensionGroupsResponse ListProductDimensionGroupsWithOptions(ListProductDimensionGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductDimensionGroups",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductDimensionGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the dimension groups of an Alibaba Cloud service.
         *
         * @description This topic provides an example on how to call the ListProductDimensionGroups operation to query the dimension groups of Object Storage Service (OSS). In this example, a dimension group is returned. The group name is `OSS_Group`, the group code is `oss_wf1ngqmd7q`, and the group key is `chargeType`.
         *
         * @param request ListProductDimensionGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductDimensionGroupsResponse
         */
        public async Task<ListProductDimensionGroupsResponse> ListProductDimensionGroupsWithOptionsAsync(ListProductDimensionGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductDimensionGroups",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductDimensionGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the dimension groups of an Alibaba Cloud service.
         *
         * @description This topic provides an example on how to call the ListProductDimensionGroups operation to query the dimension groups of Object Storage Service (OSS). In this example, a dimension group is returned. The group name is `OSS_Group`, the group code is `oss_wf1ngqmd7q`, and the group key is `chargeType`.
         *
         * @param request ListProductDimensionGroupsRequest
         * @return ListProductDimensionGroupsResponse
         */
        public ListProductDimensionGroupsResponse ListProductDimensionGroups(ListProductDimensionGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductDimensionGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the dimension groups of an Alibaba Cloud service.
         *
         * @description This topic provides an example on how to call the ListProductDimensionGroups operation to query the dimension groups of Object Storage Service (OSS). In this example, a dimension group is returned. The group name is `OSS_Group`, the group code is `oss_wf1ngqmd7q`, and the group key is `chargeType`.
         *
         * @param request ListProductDimensionGroupsRequest
         * @return ListProductDimensionGroupsResponse
         */
        public async Task<ListProductDimensionGroupsResponse> ListProductDimensionGroupsAsync(ListProductDimensionGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductDimensionGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the quota dimensions that are supported by the specified Alibaba Cloud service.
         *
         * @description In this example, the operation is called to query the quota dimensions that are supported by Elastic Compute Service (ECS). The query results show all the quota dimensions that are supported by ECS.
         *
         * @param request ListProductQuotaDimensionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductQuotaDimensionsResponse
         */
        public ListProductQuotaDimensionsResponse ListProductQuotaDimensionsWithOptions(ListProductQuotaDimensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductQuotaDimensions",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductQuotaDimensionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the quota dimensions that are supported by the specified Alibaba Cloud service.
         *
         * @description In this example, the operation is called to query the quota dimensions that are supported by Elastic Compute Service (ECS). The query results show all the quota dimensions that are supported by ECS.
         *
         * @param request ListProductQuotaDimensionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductQuotaDimensionsResponse
         */
        public async Task<ListProductQuotaDimensionsResponse> ListProductQuotaDimensionsWithOptionsAsync(ListProductQuotaDimensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductQuotaDimensions",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductQuotaDimensionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the quota dimensions that are supported by the specified Alibaba Cloud service.
         *
         * @description In this example, the operation is called to query the quota dimensions that are supported by Elastic Compute Service (ECS). The query results show all the quota dimensions that are supported by ECS.
         *
         * @param request ListProductQuotaDimensionsRequest
         * @return ListProductQuotaDimensionsResponse
         */
        public ListProductQuotaDimensionsResponse ListProductQuotaDimensions(ListProductQuotaDimensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductQuotaDimensionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the quota dimensions that are supported by the specified Alibaba Cloud service.
         *
         * @description In this example, the operation is called to query the quota dimensions that are supported by Elastic Compute Service (ECS). The query results show all the quota dimensions that are supported by ECS.
         *
         * @param request ListProductQuotaDimensionsRequest
         * @return ListProductQuotaDimensionsResponse
         */
        public async Task<ListProductQuotaDimensionsResponse> ListProductQuotaDimensionsAsync(ListProductQuotaDimensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductQuotaDimensionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the quotas of a specific Alibaba Cloud service.
         *
         * @description In this example, the operation is called to query the quotas whose instance type is `ecs.g5.2xlarge`. The quotas belong to Elastic Compute Service (ECS) Quotas by Instance Type. The query result includes the name, ID, unit, dimensions, and cycle of each quota.
         *
         * @param request ListProductQuotasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductQuotasResponse
         */
        public ListProductQuotasResponse ListProductQuotasWithOptions(ListProductQuotasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCode))
            {
                body["GroupCode"] = request.GroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                body["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductQuotas",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductQuotasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the quotas of a specific Alibaba Cloud service.
         *
         * @description In this example, the operation is called to query the quotas whose instance type is `ecs.g5.2xlarge`. The quotas belong to Elastic Compute Service (ECS) Quotas by Instance Type. The query result includes the name, ID, unit, dimensions, and cycle of each quota.
         *
         * @param request ListProductQuotasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductQuotasResponse
         */
        public async Task<ListProductQuotasResponse> ListProductQuotasWithOptionsAsync(ListProductQuotasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCode))
            {
                body["GroupCode"] = request.GroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                body["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductQuotas",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductQuotasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the quotas of a specific Alibaba Cloud service.
         *
         * @description In this example, the operation is called to query the quotas whose instance type is `ecs.g5.2xlarge`. The quotas belong to Elastic Compute Service (ECS) Quotas by Instance Type. The query result includes the name, ID, unit, dimensions, and cycle of each quota.
         *
         * @param request ListProductQuotasRequest
         * @return ListProductQuotasResponse
         */
        public ListProductQuotasResponse ListProductQuotas(ListProductQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductQuotasWithOptions(request, runtime);
        }

        /**
         * @summary Queries the quotas of a specific Alibaba Cloud service.
         *
         * @description In this example, the operation is called to query the quotas whose instance type is `ecs.g5.2xlarge`. The quotas belong to Elastic Compute Service (ECS) Quotas by Instance Type. The query result includes the name, ID, unit, dimensions, and cycle of each quota.
         *
         * @param request ListProductQuotasRequest
         * @return ListProductQuotasResponse
         */
        public async Task<ListProductQuotasResponse> ListProductQuotasAsync(ListProductQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductQuotasWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the Alibaba Cloud services that support Quota Center.
         *
         * @description The services in the query result are the same as the services listed in [Alibaba Cloud services that support Quota Center](https://help.aliyun.com/document_detail/182368.html).
         *
         * @param request ListProductsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductsResponse
         */
        public ListProductsResponse ListProductsWithOptions(ListProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProducts",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the Alibaba Cloud services that support Quota Center.
         *
         * @description The services in the query result are the same as the services listed in [Alibaba Cloud services that support Quota Center](https://help.aliyun.com/document_detail/182368.html).
         *
         * @param request ListProductsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductsResponse
         */
        public async Task<ListProductsResponse> ListProductsWithOptionsAsync(ListProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProducts",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the Alibaba Cloud services that support Quota Center.
         *
         * @description The services in the query result are the same as the services listed in [Alibaba Cloud services that support Quota Center](https://help.aliyun.com/document_detail/182368.html).
         *
         * @param request ListProductsRequest
         * @return ListProductsResponse
         */
        public ListProductsResponse ListProducts(ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the Alibaba Cloud services that support Quota Center.
         *
         * @description The services in the query result are the same as the services listed in [Alibaba Cloud services that support Quota Center](https://help.aliyun.com/document_detail/182368.html).
         *
         * @param request ListProductsRequest
         * @return ListProductsResponse
         */
        public async Task<ListProductsResponse> ListProductsAsync(ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries quota alerts.
         *
         * @param request ListQuotaAlarmsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQuotaAlarmsResponse
         */
        public ListQuotaAlarmsResponse ListQuotaAlarmsWithOptions(ListQuotaAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmName))
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaDimensions))
            {
                body["QuotaDimensions"] = request.QuotaDimensions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotaAlarms",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaAlarmsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries quota alerts.
         *
         * @param request ListQuotaAlarmsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQuotaAlarmsResponse
         */
        public async Task<ListQuotaAlarmsResponse> ListQuotaAlarmsWithOptionsAsync(ListQuotaAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmName))
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaDimensions))
            {
                body["QuotaDimensions"] = request.QuotaDimensions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotaAlarms",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaAlarmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries quota alerts.
         *
         * @param request ListQuotaAlarmsRequest
         * @return ListQuotaAlarmsResponse
         */
        public ListQuotaAlarmsResponse ListQuotaAlarms(ListQuotaAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuotaAlarmsWithOptions(request, runtime);
        }

        /**
         * @summary Queries quota alerts.
         *
         * @param request ListQuotaAlarmsRequest
         * @return ListQuotaAlarmsResponse
         */
        public async Task<ListQuotaAlarmsResponse> ListQuotaAlarmsAsync(ListQuotaAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuotaAlarmsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries quota templates by using the management account of a resource directory.
         *
         * @param request ListQuotaApplicationTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQuotaApplicationTemplatesResponse
         */
        public ListQuotaApplicationTemplatesResponse ListQuotaApplicationTemplatesWithOptions(ListQuotaApplicationTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotaApplicationTemplates",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaApplicationTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries quota templates by using the management account of a resource directory.
         *
         * @param request ListQuotaApplicationTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQuotaApplicationTemplatesResponse
         */
        public async Task<ListQuotaApplicationTemplatesResponse> ListQuotaApplicationTemplatesWithOptionsAsync(ListQuotaApplicationTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotaApplicationTemplates",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaApplicationTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries quota templates by using the management account of a resource directory.
         *
         * @param request ListQuotaApplicationTemplatesRequest
         * @return ListQuotaApplicationTemplatesResponse
         */
        public ListQuotaApplicationTemplatesResponse ListQuotaApplicationTemplates(ListQuotaApplicationTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuotaApplicationTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary Queries quota templates by using the management account of a resource directory.
         *
         * @param request ListQuotaApplicationTemplatesRequest
         * @return ListQuotaApplicationTemplatesResponse
         */
        public async Task<ListQuotaApplicationTemplatesResponse> ListQuotaApplicationTemplatesAsync(ListQuotaApplicationTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuotaApplicationTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of an application that is submitted to increase a quota.
         *
         * @description In this example, the operation is called to query the details of an application that is submitted to increase a quota whose ID is `q_i5uzm3` and whose name is Maximum Number of Nodes. This quota belongs to Container Service for Kubernetes (ACK). The query result shows the details of the application. The details include the application ID, application time, requested quota, and application result. In this example, the application ID is `b926571d-cc09-4711-b547-58a615f0****`. The application time is `2021-01-15T09:13:53Z`. The expected quota value is `101`. The application result is `Agree`.
         *
         * @param request ListQuotaApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQuotaApplicationsResponse
         */
        public ListQuotaApplicationsResponse ListQuotaApplicationsWithOptions(ListQuotaApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                body["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
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
                Action = "ListQuotaApplications",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an application that is submitted to increase a quota.
         *
         * @description In this example, the operation is called to query the details of an application that is submitted to increase a quota whose ID is `q_i5uzm3` and whose name is Maximum Number of Nodes. This quota belongs to Container Service for Kubernetes (ACK). The query result shows the details of the application. The details include the application ID, application time, requested quota, and application result. In this example, the application ID is `b926571d-cc09-4711-b547-58a615f0****`. The application time is `2021-01-15T09:13:53Z`. The expected quota value is `101`. The application result is `Agree`.
         *
         * @param request ListQuotaApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQuotaApplicationsResponse
         */
        public async Task<ListQuotaApplicationsResponse> ListQuotaApplicationsWithOptionsAsync(ListQuotaApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                body["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
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
                Action = "ListQuotaApplications",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an application that is submitted to increase a quota.
         *
         * @description In this example, the operation is called to query the details of an application that is submitted to increase a quota whose ID is `q_i5uzm3` and whose name is Maximum Number of Nodes. This quota belongs to Container Service for Kubernetes (ACK). The query result shows the details of the application. The details include the application ID, application time, requested quota, and application result. In this example, the application ID is `b926571d-cc09-4711-b547-58a615f0****`. The application time is `2021-01-15T09:13:53Z`. The expected quota value is `101`. The application result is `Agree`.
         *
         * @param request ListQuotaApplicationsRequest
         * @return ListQuotaApplicationsResponse
         */
        public ListQuotaApplicationsResponse ListQuotaApplications(ListQuotaApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuotaApplicationsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of an application that is submitted to increase a quota.
         *
         * @description In this example, the operation is called to query the details of an application that is submitted to increase a quota whose ID is `q_i5uzm3` and whose name is Maximum Number of Nodes. This quota belongs to Container Service for Kubernetes (ACK). The query result shows the details of the application. The details include the application ID, application time, requested quota, and application result. In this example, the application ID is `b926571d-cc09-4711-b547-58a615f0****`. The application time is `2021-01-15T09:13:53Z`. The expected quota value is `101`. The application result is `Agree`.
         *
         * @param request ListQuotaApplicationsRequest
         * @return ListQuotaApplicationsResponse
         */
        public async Task<ListQuotaApplicationsResponse> ListQuotaApplicationsAsync(ListQuotaApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuotaApplicationsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a quota increase application for member accounts in a resource directory.
         *
         * @param request ListQuotaApplicationsDetailForTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQuotaApplicationsDetailForTemplateResponse
         */
        public ListQuotaApplicationsDetailForTemplateResponse ListQuotaApplicationsDetailForTemplateWithOptions(ListQuotaApplicationsDetailForTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUid))
            {
                body["AliyunUid"] = request.AliyunUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchQuotaApplicationId))
            {
                body["BatchQuotaApplicationId"] = request.BatchQuotaApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
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
                Action = "ListQuotaApplicationsDetailForTemplate",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaApplicationsDetailForTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a quota increase application for member accounts in a resource directory.
         *
         * @param request ListQuotaApplicationsDetailForTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQuotaApplicationsDetailForTemplateResponse
         */
        public async Task<ListQuotaApplicationsDetailForTemplateResponse> ListQuotaApplicationsDetailForTemplateWithOptionsAsync(ListQuotaApplicationsDetailForTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUid))
            {
                body["AliyunUid"] = request.AliyunUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchQuotaApplicationId))
            {
                body["BatchQuotaApplicationId"] = request.BatchQuotaApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
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
                Action = "ListQuotaApplicationsDetailForTemplate",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaApplicationsDetailForTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a quota increase application for member accounts in a resource directory.
         *
         * @param request ListQuotaApplicationsDetailForTemplateRequest
         * @return ListQuotaApplicationsDetailForTemplateResponse
         */
        public ListQuotaApplicationsDetailForTemplateResponse ListQuotaApplicationsDetailForTemplate(ListQuotaApplicationsDetailForTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuotaApplicationsDetailForTemplateWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a quota increase application for member accounts in a resource directory.
         *
         * @param request ListQuotaApplicationsDetailForTemplateRequest
         * @return ListQuotaApplicationsDetailForTemplateResponse
         */
        public async Task<ListQuotaApplicationsDetailForTemplateResponse> ListQuotaApplicationsDetailForTemplateAsync(ListQuotaApplicationsDetailForTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuotaApplicationsDetailForTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the application records of a quota template that is used to apply for quotas for member accounts.
         *
         * @param request ListQuotaApplicationsForTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQuotaApplicationsForTemplateResponse
         */
        public ListQuotaApplicationsForTemplateResponse ListQuotaApplicationsForTemplateWithOptions(ListQuotaApplicationsForTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyEndTime))
            {
                body["ApplyEndTime"] = request.ApplyEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyStartTime))
            {
                body["ApplyStartTime"] = request.ApplyStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchQuotaApplicationId))
            {
                body["BatchQuotaApplicationId"] = request.BatchQuotaApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotaApplicationsForTemplate",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaApplicationsForTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the application records of a quota template that is used to apply for quotas for member accounts.
         *
         * @param request ListQuotaApplicationsForTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQuotaApplicationsForTemplateResponse
         */
        public async Task<ListQuotaApplicationsForTemplateResponse> ListQuotaApplicationsForTemplateWithOptionsAsync(ListQuotaApplicationsForTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyEndTime))
            {
                body["ApplyEndTime"] = request.ApplyEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyStartTime))
            {
                body["ApplyStartTime"] = request.ApplyStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchQuotaApplicationId))
            {
                body["BatchQuotaApplicationId"] = request.BatchQuotaApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotaApplicationsForTemplate",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaApplicationsForTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the application records of a quota template that is used to apply for quotas for member accounts.
         *
         * @param request ListQuotaApplicationsForTemplateRequest
         * @return ListQuotaApplicationsForTemplateResponse
         */
        public ListQuotaApplicationsForTemplateResponse ListQuotaApplicationsForTemplate(ListQuotaApplicationsForTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuotaApplicationsForTemplateWithOptions(request, runtime);
        }

        /**
         * @summary Queries the application records of a quota template that is used to apply for quotas for member accounts.
         *
         * @param request ListQuotaApplicationsForTemplateRequest
         * @return ListQuotaApplicationsForTemplateResponse
         */
        public async Task<ListQuotaApplicationsForTemplateResponse> ListQuotaApplicationsForTemplateAsync(ListQuotaApplicationsForTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuotaApplicationsForTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the status of a quota template. By default, the quota template is not configured. If the management account of a resource directory uses a quota template for the first time, you must enable the quota template.
         *
         * @description ### [](#)Prerequisites
         * A resource directory is enabled. For more information, see [EnableResourceDirectory](https://help.aliyun.com/document_detail/604185.html).
         * ### [](#)Usage notes
         * If the `ServiceStatus` parameter is set to `0` or `-1`, you can call this operation to set the parameter to `1`. Then, you can call the [CreateTemplateQuotaItem](https://help.aliyun.com/document_detail/450615.html) operation to create a quota template.
         *
         * @param request ModifyQuotaTemplateServiceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyQuotaTemplateServiceStatusResponse
         */
        public ModifyQuotaTemplateServiceStatusResponse ModifyQuotaTemplateServiceStatusWithOptions(ModifyQuotaTemplateServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                body["ServiceStatus"] = request.ServiceStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyQuotaTemplateServiceStatus",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyQuotaTemplateServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the status of a quota template. By default, the quota template is not configured. If the management account of a resource directory uses a quota template for the first time, you must enable the quota template.
         *
         * @description ### [](#)Prerequisites
         * A resource directory is enabled. For more information, see [EnableResourceDirectory](https://help.aliyun.com/document_detail/604185.html).
         * ### [](#)Usage notes
         * If the `ServiceStatus` parameter is set to `0` or `-1`, you can call this operation to set the parameter to `1`. Then, you can call the [CreateTemplateQuotaItem](https://help.aliyun.com/document_detail/450615.html) operation to create a quota template.
         *
         * @param request ModifyQuotaTemplateServiceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyQuotaTemplateServiceStatusResponse
         */
        public async Task<ModifyQuotaTemplateServiceStatusResponse> ModifyQuotaTemplateServiceStatusWithOptionsAsync(ModifyQuotaTemplateServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                body["ServiceStatus"] = request.ServiceStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyQuotaTemplateServiceStatus",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyQuotaTemplateServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the status of a quota template. By default, the quota template is not configured. If the management account of a resource directory uses a quota template for the first time, you must enable the quota template.
         *
         * @description ### [](#)Prerequisites
         * A resource directory is enabled. For more information, see [EnableResourceDirectory](https://help.aliyun.com/document_detail/604185.html).
         * ### [](#)Usage notes
         * If the `ServiceStatus` parameter is set to `0` or `-1`, you can call this operation to set the parameter to `1`. Then, you can call the [CreateTemplateQuotaItem](https://help.aliyun.com/document_detail/450615.html) operation to create a quota template.
         *
         * @param request ModifyQuotaTemplateServiceStatusRequest
         * @return ModifyQuotaTemplateServiceStatusResponse
         */
        public ModifyQuotaTemplateServiceStatusResponse ModifyQuotaTemplateServiceStatus(ModifyQuotaTemplateServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyQuotaTemplateServiceStatusWithOptions(request, runtime);
        }

        /**
         * @summary Changes the status of a quota template. By default, the quota template is not configured. If the management account of a resource directory uses a quota template for the first time, you must enable the quota template.
         *
         * @description ### [](#)Prerequisites
         * A resource directory is enabled. For more information, see [EnableResourceDirectory](https://help.aliyun.com/document_detail/604185.html).
         * ### [](#)Usage notes
         * If the `ServiceStatus` parameter is set to `0` or `-1`, you can call this operation to set the parameter to `1`. Then, you can call the [CreateTemplateQuotaItem](https://help.aliyun.com/document_detail/450615.html) operation to create a quota template.
         *
         * @param request ModifyQuotaTemplateServiceStatusRequest
         * @return ModifyQuotaTemplateServiceStatusResponse
         */
        public async Task<ModifyQuotaTemplateServiceStatusResponse> ModifyQuotaTemplateServiceStatusAsync(ModifyQuotaTemplateServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyQuotaTemplateServiceStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The ID of the quota template.
         *
         * @param request ModifyTemplateQuotaItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTemplateQuotaItemResponse
         */
        public ModifyTemplateQuotaItemResponse ModifyTemplateQuotaItemWithOptions(ModifyTemplateQuotaItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                query["QuotaCategory"] = request.QuotaCategory;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesireValue))
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvLanguage))
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeType))
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTemplateQuotaItem",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTemplateQuotaItemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The ID of the quota template.
         *
         * @param request ModifyTemplateQuotaItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTemplateQuotaItemResponse
         */
        public async Task<ModifyTemplateQuotaItemResponse> ModifyTemplateQuotaItemWithOptionsAsync(ModifyTemplateQuotaItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                query["QuotaCategory"] = request.QuotaCategory;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesireValue))
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvLanguage))
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeType))
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaActionCode))
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTemplateQuotaItem",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTemplateQuotaItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The ID of the quota template.
         *
         * @param request ModifyTemplateQuotaItemRequest
         * @return ModifyTemplateQuotaItemResponse
         */
        public ModifyTemplateQuotaItemResponse ModifyTemplateQuotaItem(ModifyTemplateQuotaItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTemplateQuotaItemWithOptions(request, runtime);
        }

        /**
         * @summary The ID of the quota template.
         *
         * @param request ModifyTemplateQuotaItemRequest
         * @return ModifyTemplateQuotaItemResponse
         */
        public async Task<ModifyTemplateQuotaItemResponse> ModifyTemplateQuotaItemAsync(ModifyTemplateQuotaItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTemplateQuotaItemWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Reminds the approver of a quota application to review the application. This operation is applicable to quota applications that support the approval reminding feature.
         *
         * @description >  You can call this operation to enable the approval reminder feature for quota applications that support this feature. To check whether this feature is supported, you can view the value of `SupportReminder` in the GetQuotaApplicationApproval operation. If the value of SupportReminder is `true`, this feature is supported.
         *
         * @param request RemindQuotaApplicationApprovalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemindQuotaApplicationApprovalResponse
         */
        public RemindQuotaApplicationApprovalResponse RemindQuotaApplicationApprovalWithOptions(RemindQuotaApplicationApprovalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemindQuotaApplicationApproval",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemindQuotaApplicationApprovalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Reminds the approver of a quota application to review the application. This operation is applicable to quota applications that support the approval reminding feature.
         *
         * @description >  You can call this operation to enable the approval reminder feature for quota applications that support this feature. To check whether this feature is supported, you can view the value of `SupportReminder` in the GetQuotaApplicationApproval operation. If the value of SupportReminder is `true`, this feature is supported.
         *
         * @param request RemindQuotaApplicationApprovalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemindQuotaApplicationApprovalResponse
         */
        public async Task<RemindQuotaApplicationApprovalResponse> RemindQuotaApplicationApprovalWithOptionsAsync(RemindQuotaApplicationApprovalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemindQuotaApplicationApproval",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemindQuotaApplicationApprovalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Reminds the approver of a quota application to review the application. This operation is applicable to quota applications that support the approval reminding feature.
         *
         * @description >  You can call this operation to enable the approval reminder feature for quota applications that support this feature. To check whether this feature is supported, you can view the value of `SupportReminder` in the GetQuotaApplicationApproval operation. If the value of SupportReminder is `true`, this feature is supported.
         *
         * @param request RemindQuotaApplicationApprovalRequest
         * @return RemindQuotaApplicationApprovalResponse
         */
        public RemindQuotaApplicationApprovalResponse RemindQuotaApplicationApproval(RemindQuotaApplicationApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemindQuotaApplicationApprovalWithOptions(request, runtime);
        }

        /**
         * @summary Reminds the approver of a quota application to review the application. This operation is applicable to quota applications that support the approval reminding feature.
         *
         * @description >  You can call this operation to enable the approval reminder feature for quota applications that support this feature. To check whether this feature is supported, you can view the value of `SupportReminder` in the GetQuotaApplicationApproval operation. If the value of SupportReminder is `true`, this feature is supported.
         *
         * @param request RemindQuotaApplicationApprovalRequest
         * @return RemindQuotaApplicationApprovalResponse
         */
        public async Task<RemindQuotaApplicationApprovalResponse> RemindQuotaApplicationApprovalAsync(RemindQuotaApplicationApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemindQuotaApplicationApprovalWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a quota alert rule.
         *
         * @description In this example, the operation is called to modify the information about a quota alert whose ID is `a2efa7fc-832f-47bb-8054-39e28012****` and whose name is `rules`. The alert threshold is changed from `150` to `160`.
         *
         * @param request UpdateQuotaAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateQuotaAlarmResponse
         */
        public UpdateQuotaAlarmResponse UpdateQuotaAlarmWithOptions(UpdateQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmId))
            {
                body["AlarmId"] = request.AlarmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmName))
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                body["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThresholdPercent))
            {
                body["ThresholdPercent"] = request.ThresholdPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThresholdType))
            {
                body["ThresholdType"] = request.ThresholdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebHook))
            {
                body["WebHook"] = request.WebHook;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuotaAlarm",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaAlarmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a quota alert rule.
         *
         * @description In this example, the operation is called to modify the information about a quota alert whose ID is `a2efa7fc-832f-47bb-8054-39e28012****` and whose name is `rules`. The alert threshold is changed from `150` to `160`.
         *
         * @param request UpdateQuotaAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateQuotaAlarmResponse
         */
        public async Task<UpdateQuotaAlarmResponse> UpdateQuotaAlarmWithOptionsAsync(UpdateQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmId))
            {
                body["AlarmId"] = request.AlarmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmName))
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                body["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThresholdPercent))
            {
                body["ThresholdPercent"] = request.ThresholdPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThresholdType))
            {
                body["ThresholdType"] = request.ThresholdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebHook))
            {
                body["WebHook"] = request.WebHook;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuotaAlarm",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a quota alert rule.
         *
         * @description In this example, the operation is called to modify the information about a quota alert whose ID is `a2efa7fc-832f-47bb-8054-39e28012****` and whose name is `rules`. The alert threshold is changed from `150` to `160`.
         *
         * @param request UpdateQuotaAlarmRequest
         * @return UpdateQuotaAlarmResponse
         */
        public UpdateQuotaAlarmResponse UpdateQuotaAlarm(UpdateQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQuotaAlarmWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a quota alert rule.
         *
         * @description In this example, the operation is called to modify the information about a quota alert whose ID is `a2efa7fc-832f-47bb-8054-39e28012****` and whose name is `rules`. The alert threshold is changed from `150` to `160`.
         *
         * @param request UpdateQuotaAlarmRequest
         * @return UpdateQuotaAlarmResponse
         */
        public async Task<UpdateQuotaAlarmResponse> UpdateQuotaAlarmAsync(UpdateQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQuotaAlarmWithOptionsAsync(request, runtime);
        }

    }
}
