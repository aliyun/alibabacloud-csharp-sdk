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
            this._productId = "quotas";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an alert rule for a quota item.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alerting feature has been upgraded and this API operation will be deprecated. Use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513316.html">PutResourceMetricRules</a> and <a href="https://help.aliyun.com/document_detail/2513302.html">PutMetricRuleTargets</a> to create alert rules for the new version of quota alerting.
        /// For more information about how to use API operations to manage the new version of quota alerting, see <a href="https://help.aliyun.com/document_detail/2863234.html">Manage new quota alerts by using API operations</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQuotaAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaAlarmResponse
        /// </returns>
        public CreateQuotaAlarmResponse CreateQuotaAlarmWithOptions(CreateQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmName))
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalContext))
            {
                body["OriginalContext"] = request.OriginalContext;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an alert rule for a quota item.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alerting feature has been upgraded and this API operation will be deprecated. Use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513316.html">PutResourceMetricRules</a> and <a href="https://help.aliyun.com/document_detail/2513302.html">PutMetricRuleTargets</a> to create alert rules for the new version of quota alerting.
        /// For more information about how to use API operations to manage the new version of quota alerting, see <a href="https://help.aliyun.com/document_detail/2863234.html">Manage new quota alerts by using API operations</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQuotaAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaAlarmResponse
        /// </returns>
        public async Task<CreateQuotaAlarmResponse> CreateQuotaAlarmWithOptionsAsync(CreateQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmName))
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalContext))
            {
                body["OriginalContext"] = request.OriginalContext;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an alert rule for a quota item.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alerting feature has been upgraded and this API operation will be deprecated. Use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513316.html">PutResourceMetricRules</a> and <a href="https://help.aliyun.com/document_detail/2513302.html">PutMetricRuleTargets</a> to create alert rules for the new version of quota alerting.
        /// For more information about how to use API operations to manage the new version of quota alerting, see <a href="https://help.aliyun.com/document_detail/2863234.html">Manage new quota alerts by using API operations</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQuotaAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaAlarmResponse
        /// </returns>
        public CreateQuotaAlarmResponse CreateQuotaAlarm(CreateQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQuotaAlarmWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an alert rule for a quota item.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alerting feature has been upgraded and this API operation will be deprecated. Use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513316.html">PutResourceMetricRules</a> and <a href="https://help.aliyun.com/document_detail/2513302.html">PutMetricRuleTargets</a> to create alert rules for the new version of quota alerting.
        /// For more information about how to use API operations to manage the new version of quota alerting, see <a href="https://help.aliyun.com/document_detail/2863234.html">Manage new quota alerts by using API operations</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQuotaAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaAlarmResponse
        /// </returns>
        public async Task<CreateQuotaAlarmResponse> CreateQuotaAlarmAsync(CreateQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQuotaAlarmWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a quota increase request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After you create a quota increase request, you can call the <a href="https://help.aliyun.com/document_detail/440568.html">ListQuotaApplications</a> operation to view the approval result. If the value of <c>Status</c> is <c>Agree</c>, the request is approved.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQuotaApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaApplicationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a quota increase request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After you create a quota increase request, you can call the <a href="https://help.aliyun.com/document_detail/440568.html">ListQuotaApplications</a> operation to view the approval result. If the value of <c>Status</c> is <c>Agree</c>, the request is approved.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQuotaApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaApplicationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a quota increase request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After you create a quota increase request, you can call the <a href="https://help.aliyun.com/document_detail/440568.html">ListQuotaApplications</a> operation to view the approval result. If the value of <c>Status</c> is <c>Agree</c>, the request is approved.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQuotaApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaApplicationResponse
        /// </returns>
        public CreateQuotaApplicationResponse CreateQuotaApplication(CreateQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQuotaApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a quota increase request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After you create a quota increase request, you can call the <a href="https://help.aliyun.com/document_detail/440568.html">ListQuotaApplications</a> operation to view the approval result. If the value of <c>Status</c> is <c>Agree</c>, the request is approved.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQuotaApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaApplicationResponse
        /// </returns>
        public async Task<CreateQuotaApplicationResponse> CreateQuotaApplicationAsync(CreateQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQuotaApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates batch quota increase applications for members in a resource folder. When you add a quota item to a quota template, only new members in the resource folder autocommit quota increase applications, and existing members remain unchanged. To increase quotas for existing members by using a quota template, you can select the quota template to commit batch quota increase applications for multiple members in the resource folder. Only the administrator account of the resource folder can create batch quota applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Limits</h3>
        /// <para>A single application can include a maximum of 10 quota items.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQuotaApplicationsForTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaApplicationsForTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates batch quota increase applications for members in a resource folder. When you add a quota item to a quota template, only new members in the resource folder autocommit quota increase applications, and existing members remain unchanged. To increase quotas for existing members by using a quota template, you can select the quota template to commit batch quota increase applications for multiple members in the resource folder. Only the administrator account of the resource folder can create batch quota applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Limits</h3>
        /// <para>A single application can include a maximum of 10 quota items.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQuotaApplicationsForTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaApplicationsForTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates batch quota increase applications for members in a resource folder. When you add a quota item to a quota template, only new members in the resource folder autocommit quota increase applications, and existing members remain unchanged. To increase quotas for existing members by using a quota template, you can select the quota template to commit batch quota increase applications for multiple members in the resource folder. Only the administrator account of the resource folder can create batch quota applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Limits</h3>
        /// <para>A single application can include a maximum of 10 quota items.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQuotaApplicationsForTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaApplicationsForTemplateResponse
        /// </returns>
        public CreateQuotaApplicationsForTemplateResponse CreateQuotaApplicationsForTemplate(CreateQuotaApplicationsForTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQuotaApplicationsForTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates batch quota increase applications for members in a resource folder. When you add a quota item to a quota template, only new members in the resource folder autocommit quota increase applications, and existing members remain unchanged. To increase quotas for existing members by using a quota template, you can select the quota template to commit batch quota increase applications for multiple members in the resource folder. Only the administrator account of the resource folder can create batch quota applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Limits</h3>
        /// <para>A single application can include a maximum of 10 quota items.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQuotaApplicationsForTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaApplicationsForTemplateResponse
        /// </returns>
        public async Task<CreateQuotaApplicationsForTemplateResponse> CreateQuotaApplicationsForTemplateAsync(CreateQuotaApplicationsForTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQuotaApplicationsForTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a quota template. After the management account creates a quota template, the template automatically submits quota increase applications for new members added to the resource directory. Existing members remain unaffected. You can use a quota template to apply for increases to multiple quota items at a time, improving the efficiency and automation of quota management across the organization. Only the management account of a resource directory can create a quota template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <para>Make sure that the status of the quota template is enabled (that is, <c>ServiceStatus</c> is <c>1</c>).
        /// Call the <a href="https://help.aliyun.com/document_detail/450407.html">GetQuotaTemplateServiceStatus</a> operation to query the status of the quota template. If the <c>ServiceStatus</c> of the quota template is <c>0</c> (not configured) or <c>-1</c> (disabled), call the <a href="https://help.aliyun.com/document_detail/450406.html">ModifyQuotaTemplateServiceStatus</a> operation to change the status to <c>1</c> (enabled).</para>
        /// <h3>Usage notes</h3>
        /// <para>After you create a quota template, you can call the <a href="https://help.aliyun.com/document_detail/2584864.html">ListQuotaApplicationsForTemplate</a> operation to view the approval result. If <c>Status</c> is displayed as <c>Agree</c>, the application is approved.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateQuotaItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateQuotaItemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a quota template. After the management account creates a quota template, the template automatically submits quota increase applications for new members added to the resource directory. Existing members remain unaffected. You can use a quota template to apply for increases to multiple quota items at a time, improving the efficiency and automation of quota management across the organization. Only the management account of a resource directory can create a quota template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <para>Make sure that the status of the quota template is enabled (that is, <c>ServiceStatus</c> is <c>1</c>).
        /// Call the <a href="https://help.aliyun.com/document_detail/450407.html">GetQuotaTemplateServiceStatus</a> operation to query the status of the quota template. If the <c>ServiceStatus</c> of the quota template is <c>0</c> (not configured) or <c>-1</c> (disabled), call the <a href="https://help.aliyun.com/document_detail/450406.html">ModifyQuotaTemplateServiceStatus</a> operation to change the status to <c>1</c> (enabled).</para>
        /// <h3>Usage notes</h3>
        /// <para>After you create a quota template, you can call the <a href="https://help.aliyun.com/document_detail/2584864.html">ListQuotaApplicationsForTemplate</a> operation to view the approval result. If <c>Status</c> is displayed as <c>Agree</c>, the application is approved.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateQuotaItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateQuotaItemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a quota template. After the management account creates a quota template, the template automatically submits quota increase applications for new members added to the resource directory. Existing members remain unaffected. You can use a quota template to apply for increases to multiple quota items at a time, improving the efficiency and automation of quota management across the organization. Only the management account of a resource directory can create a quota template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <para>Make sure that the status of the quota template is enabled (that is, <c>ServiceStatus</c> is <c>1</c>).
        /// Call the <a href="https://help.aliyun.com/document_detail/450407.html">GetQuotaTemplateServiceStatus</a> operation to query the status of the quota template. If the <c>ServiceStatus</c> of the quota template is <c>0</c> (not configured) or <c>-1</c> (disabled), call the <a href="https://help.aliyun.com/document_detail/450406.html">ModifyQuotaTemplateServiceStatus</a> operation to change the status to <c>1</c> (enabled).</para>
        /// <h3>Usage notes</h3>
        /// <para>After you create a quota template, you can call the <a href="https://help.aliyun.com/document_detail/2584864.html">ListQuotaApplicationsForTemplate</a> operation to view the approval result. If <c>Status</c> is displayed as <c>Agree</c>, the application is approved.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateQuotaItemRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateQuotaItemResponse
        /// </returns>
        public CreateTemplateQuotaItemResponse CreateTemplateQuotaItem(CreateTemplateQuotaItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateQuotaItemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a quota template. After the management account creates a quota template, the template automatically submits quota increase applications for new members added to the resource directory. Existing members remain unaffected. You can use a quota template to apply for increases to multiple quota items at a time, improving the efficiency and automation of quota management across the organization. Only the management account of a resource directory can create a quota template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <para>Make sure that the status of the quota template is enabled (that is, <c>ServiceStatus</c> is <c>1</c>).
        /// Call the <a href="https://help.aliyun.com/document_detail/450407.html">GetQuotaTemplateServiceStatus</a> operation to query the status of the quota template. If the <c>ServiceStatus</c> of the quota template is <c>0</c> (not configured) or <c>-1</c> (disabled), call the <a href="https://help.aliyun.com/document_detail/450406.html">ModifyQuotaTemplateServiceStatus</a> operation to change the status to <c>1</c> (enabled).</para>
        /// <h3>Usage notes</h3>
        /// <para>After you create a quota template, you can call the <a href="https://help.aliyun.com/document_detail/2584864.html">ListQuotaApplicationsForTemplate</a> operation to view the approval result. If <c>Status</c> is displayed as <c>Agree</c>, the application is approved.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateQuotaItemRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateQuotaItemResponse
        /// </returns>
        public async Task<CreateTemplateQuotaItemResponse> CreateTemplateQuotaItemAsync(CreateTemplateQuotaItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateQuotaItemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a quota usage alert.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alerting feature has been upgraded, and this API operation will be deprecated soon. This API operation can only delete legacy quota usage alerts. To delete new-version quota usage alerts, use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513295.html">DeleteMetricRules</a> and <a href="https://help.aliyun.com/document_detail/2513294.html">DeleteMetricRuleTargets</a>.
        /// For more information about managing new-version quota alerts by using API operations, see <a href="https://help.aliyun.com/document_detail/2863234.html">Manage new-version quota alerts by using API operations</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteQuotaAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQuotaAlarmResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a quota usage alert.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alerting feature has been upgraded, and this API operation will be deprecated soon. This API operation can only delete legacy quota usage alerts. To delete new-version quota usage alerts, use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513295.html">DeleteMetricRules</a> and <a href="https://help.aliyun.com/document_detail/2513294.html">DeleteMetricRuleTargets</a>.
        /// For more information about managing new-version quota alerts by using API operations, see <a href="https://help.aliyun.com/document_detail/2863234.html">Manage new-version quota alerts by using API operations</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteQuotaAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQuotaAlarmResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a quota usage alert.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alerting feature has been upgraded, and this API operation will be deprecated soon. This API operation can only delete legacy quota usage alerts. To delete new-version quota usage alerts, use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513295.html">DeleteMetricRules</a> and <a href="https://help.aliyun.com/document_detail/2513294.html">DeleteMetricRuleTargets</a>.
        /// For more information about managing new-version quota alerts by using API operations, see <a href="https://help.aliyun.com/document_detail/2863234.html">Manage new-version quota alerts by using API operations</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteQuotaAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQuotaAlarmResponse
        /// </returns>
        public DeleteQuotaAlarmResponse DeleteQuotaAlarm(DeleteQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQuotaAlarmWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a quota usage alert.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alerting feature has been upgraded, and this API operation will be deprecated soon. This API operation can only delete legacy quota usage alerts. To delete new-version quota usage alerts, use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513295.html">DeleteMetricRules</a> and <a href="https://help.aliyun.com/document_detail/2513294.html">DeleteMetricRuleTargets</a>.
        /// For more information about managing new-version quota alerts by using API operations, see <a href="https://help.aliyun.com/document_detail/2863234.html">Manage new-version quota alerts by using API operations</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteQuotaAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQuotaAlarmResponse
        /// </returns>
        public async Task<DeleteQuotaAlarmResponse> DeleteQuotaAlarmAsync(DeleteQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQuotaAlarmWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a quota template. After the management account deletes a quota template, the template no longer automatically submits quota increase requests for new members added to the resource directory. Only the management account of the resource directory can delete quota templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateQuotaItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateQuotaItemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a quota template. After the management account deletes a quota template, the template no longer automatically submits quota increase requests for new members added to the resource directory. Only the management account of the resource directory can delete quota templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateQuotaItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateQuotaItemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a quota template. After the management account deletes a quota template, the template no longer automatically submits quota increase requests for new members added to the resource directory. Only the management account of the resource directory can delete quota templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateQuotaItemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateQuotaItemResponse
        /// </returns>
        public DeleteTemplateQuotaItemResponse DeleteTemplateQuotaItem(DeleteTemplateQuotaItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateQuotaItemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a quota template. After the management account deletes a quota template, the template no longer automatically submits quota increase requests for new members added to the resource directory. Only the management account of the resource directory can delete quota templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateQuotaItemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateQuotaItemResponse
        /// </returns>
        public async Task<DeleteTemplateQuotaItemResponse> DeleteTemplateQuotaItemAsync(DeleteTemplateQuotaItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateQuotaItemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quota details of a specified cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProductQuotaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quota details of a specified cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProductQuotaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quota details of a specified cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProductQuotaResponse
        /// </returns>
        public GetProductQuotaResponse GetProductQuota(GetProductQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProductQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quota details of a specified cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProductQuotaResponse
        /// </returns>
        public async Task<GetProductQuotaResponse> GetProductQuotaAsync(GetProductQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProductQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the quota dimensions supported by the target cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductQuotaDimensionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProductQuotaDimensionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the quota dimensions supported by the target cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductQuotaDimensionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProductQuotaDimensionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the quota dimensions supported by the target cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductQuotaDimensionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProductQuotaDimensionResponse
        /// </returns>
        public GetProductQuotaDimensionResponse GetProductQuotaDimension(GetProductQuotaDimensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProductQuotaDimensionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the quota dimensions supported by the target cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductQuotaDimensionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProductQuotaDimensionResponse
        /// </returns>
        public async Task<GetProductQuotaDimensionResponse> GetProductQuotaDimensionAsync(GetProductQuotaDimensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProductQuotaDimensionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified quota alert.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alert feature has been upgraded. This API operation will be deprecated soon. This API operation can only query the details of legacy quota usage alerts. To query the details of new-version quota usage alerts, use the CloudMonitor API operation <a href="https://help.aliyun.com/document_detail/2513291.html">DescribeMetricRuleList</a>. For more information about how to use API operations to manage new-version quota alerts, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new-version quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQuotaAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaAlarmResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified quota alert.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alert feature has been upgraded. This API operation will be deprecated soon. This API operation can only query the details of legacy quota usage alerts. To query the details of new-version quota usage alerts, use the CloudMonitor API operation <a href="https://help.aliyun.com/document_detail/2513291.html">DescribeMetricRuleList</a>. For more information about how to use API operations to manage new-version quota alerts, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new-version quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQuotaAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaAlarmResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified quota alert.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alert feature has been upgraded. This API operation will be deprecated soon. This API operation can only query the details of legacy quota usage alerts. To query the details of new-version quota usage alerts, use the CloudMonitor API operation <a href="https://help.aliyun.com/document_detail/2513291.html">DescribeMetricRuleList</a>. For more information about how to use API operations to manage new-version quota alerts, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new-version quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQuotaAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaAlarmResponse
        /// </returns>
        public GetQuotaAlarmResponse GetQuotaAlarm(GetQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaAlarmWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified quota alert.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alert feature has been upgraded. This API operation will be deprecated soon. This API operation can only query the details of legacy quota usage alerts. To query the details of new-version quota usage alerts, use the CloudMonitor API operation <a href="https://help.aliyun.com/document_detail/2513291.html">DescribeMetricRuleList</a>. For more information about how to use API operations to manage new-version quota alerts, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new-version quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQuotaAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaAlarmResponse
        /// </returns>
        public async Task<GetQuotaAlarmResponse> GetQuotaAlarmAsync(GetQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaAlarmWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a quota increase application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaApplicationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a quota increase application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaApplicationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a quota increase application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaApplicationResponse
        /// </returns>
        public GetQuotaApplicationResponse GetQuotaApplication(GetQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a quota increase application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaApplicationResponse
        /// </returns>
        public async Task<GetQuotaApplicationResponse> GetQuotaApplicationAsync(GetQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the approval information of a quota application, including the average approval time, whether approval reminders are supported, and the approval reminder interval.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <para>Make sure that you have created a quota increase application. For more information, see <a href="https://help.aliyun.com/document_detail/440566.html">CreateQuotaApplication</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQuotaApplicationApprovalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaApplicationApprovalResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the approval information of a quota application, including the average approval time, whether approval reminders are supported, and the approval reminder interval.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <para>Make sure that you have created a quota increase application. For more information, see <a href="https://help.aliyun.com/document_detail/440566.html">CreateQuotaApplication</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQuotaApplicationApprovalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaApplicationApprovalResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the approval information of a quota application, including the average approval time, whether approval reminders are supported, and the approval reminder interval.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <para>Make sure that you have created a quota increase application. For more information, see <a href="https://help.aliyun.com/document_detail/440566.html">CreateQuotaApplication</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQuotaApplicationApprovalRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaApplicationApprovalResponse
        /// </returns>
        public GetQuotaApplicationApprovalResponse GetQuotaApplicationApproval(GetQuotaApplicationApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaApplicationApprovalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the approval information of a quota application, including the average approval time, whether approval reminders are supported, and the approval reminder interval.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <para>Make sure that you have created a quota increase application. For more information, see <a href="https://help.aliyun.com/document_detail/440566.html">CreateQuotaApplication</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQuotaApplicationApprovalRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaApplicationApprovalResponse
        /// </returns>
        public async Task<GetQuotaApplicationApprovalResponse> GetQuotaApplicationApprovalAsync(GetQuotaApplicationApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaApplicationApprovalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the quota template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The default status of a quota template is unset (that is, <c>ServiceStatus</c> is <c>0</c>). You can use the features of the quota template only when its status is enabled (that is, <c>ServiceStatus</c> is <c>1</c>).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQuotaTemplateServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaTemplateServiceStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the quota template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The default status of a quota template is unset (that is, <c>ServiceStatus</c> is <c>0</c>). You can use the features of the quota template only when its status is enabled (that is, <c>ServiceStatus</c> is <c>1</c>).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQuotaTemplateServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaTemplateServiceStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the quota template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The default status of a quota template is unset (that is, <c>ServiceStatus</c> is <c>0</c>). You can use the features of the quota template only when its status is enabled (that is, <c>ServiceStatus</c> is <c>1</c>).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQuotaTemplateServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaTemplateServiceStatusResponse
        /// </returns>
        public GetQuotaTemplateServiceStatusResponse GetQuotaTemplateServiceStatus(GetQuotaTemplateServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaTemplateServiceStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the quota template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The default status of a quota template is unset (that is, <c>ServiceStatus</c> is <c>0</c>). You can use the features of the quota template only when its status is enabled (that is, <c>ServiceStatus</c> is <c>1</c>).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQuotaTemplateServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaTemplateServiceStatusResponse
        /// </returns>
        public async Task<GetQuotaTemplateServiceStatusResponse> GetQuotaTemplateServiceStatusAsync(GetQuotaTemplateServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaTemplateServiceStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an overview of quota utilization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaUtilizationOverviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaUtilizationOverviewResponse
        /// </returns>
        public GetQuotaUtilizationOverviewResponse GetQuotaUtilizationOverviewWithOptions(GetQuotaUtilizationOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "GetQuotaUtilizationOverview",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaUtilizationOverviewResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an overview of quota utilization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaUtilizationOverviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaUtilizationOverviewResponse
        /// </returns>
        public async Task<GetQuotaUtilizationOverviewResponse> GetQuotaUtilizationOverviewWithOptionsAsync(GetQuotaUtilizationOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "GetQuotaUtilizationOverview",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaUtilizationOverviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an overview of quota utilization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaUtilizationOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaUtilizationOverviewResponse
        /// </returns>
        public GetQuotaUtilizationOverviewResponse GetQuotaUtilizationOverview(GetQuotaUtilizationOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaUtilizationOverviewWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an overview of quota utilization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaUtilizationOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaUtilizationOverviewResponse
        /// </returns>
        public async Task<GetQuotaUtilizationOverviewResponse> GetQuotaUtilizationOverviewAsync(GetQuotaUtilizationOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaUtilizationOverviewWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history of quota alerts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alert feature has been upgraded and this API operation will be deprecated. This API operation can only query the history of legacy quota usage alerts. To query the history of new quota usage alerts, use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513275.html">DescribeAlertLogCount</a> and <a href="https://help.aliyun.com/document_detail/2513276.html">DescribeAlertLogList</a>. For more information about how to use API operations to manage new quota alerts, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAlarmHistoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlarmHistoriesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history of quota alerts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alert feature has been upgraded and this API operation will be deprecated. This API operation can only query the history of legacy quota usage alerts. To query the history of new quota usage alerts, use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513275.html">DescribeAlertLogCount</a> and <a href="https://help.aliyun.com/document_detail/2513276.html">DescribeAlertLogList</a>. For more information about how to use API operations to manage new quota alerts, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAlarmHistoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlarmHistoriesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history of quota alerts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alert feature has been upgraded and this API operation will be deprecated. This API operation can only query the history of legacy quota usage alerts. To query the history of new quota usage alerts, use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513275.html">DescribeAlertLogCount</a> and <a href="https://help.aliyun.com/document_detail/2513276.html">DescribeAlertLogList</a>. For more information about how to use API operations to manage new quota alerts, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAlarmHistoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlarmHistoriesResponse
        /// </returns>
        public ListAlarmHistoriesResponse ListAlarmHistories(ListAlarmHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlarmHistoriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history of quota alerts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alert feature has been upgraded and this API operation will be deprecated. This API operation can only query the history of legacy quota usage alerts. To query the history of new quota usage alerts, use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513275.html">DescribeAlertLogCount</a> and <a href="https://help.aliyun.com/document_detail/2513276.html">DescribeAlertLogList</a>. For more information about how to use API operations to manage new quota alerts, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAlarmHistoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlarmHistoriesResponse
        /// </returns>
        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesAsync(ListAlarmHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlarmHistoriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of quotas associated with a specific quota. Some quotas are interdependent and should be increased simultaneously.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDependentQuotasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDependentQuotasResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of quotas associated with a specific quota. Some quotas are interdependent and should be increased simultaneously.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDependentQuotasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDependentQuotasResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of quotas associated with a specific quota. Some quotas are interdependent and should be increased simultaneously.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDependentQuotasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDependentQuotasResponse
        /// </returns>
        public ListDependentQuotasResponse ListDependentQuotas(ListDependentQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDependentQuotasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of quotas associated with a specific quota. Some quotas are interdependent and should be increased simultaneously.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDependentQuotasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDependentQuotasResponse
        /// </returns>
        public async Task<ListDependentQuotasResponse> ListDependentQuotasAsync(ListDependentQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDependentQuotasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries the dimension groups of a specified Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductDimensionGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductDimensionGroupsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries the dimension groups of a specified Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductDimensionGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductDimensionGroupsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries the dimension groups of a specified Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductDimensionGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductDimensionGroupsResponse
        /// </returns>
        public ListProductDimensionGroupsResponse ListProductDimensionGroups(ListProductDimensionGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductDimensionGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries the dimension groups of a specified Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductDimensionGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductDimensionGroupsResponse
        /// </returns>
        public async Task<ListProductDimensionGroupsResponse> ListProductDimensionGroupsAsync(ListProductDimensionGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductDimensionGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quota dimensions supported by the specified cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductQuotaDimensionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductQuotaDimensionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quota dimensions supported by the specified cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductQuotaDimensionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductQuotaDimensionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quota dimensions supported by the specified cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductQuotaDimensionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductQuotaDimensionsResponse
        /// </returns>
        public ListProductQuotaDimensionsResponse ListProductQuotaDimensions(ListProductQuotaDimensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductQuotaDimensionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quota dimensions supported by the specified cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductQuotaDimensionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductQuotaDimensionsResponse
        /// </returns>
        public async Task<ListProductQuotaDimensionsResponse> ListProductQuotaDimensionsAsync(ListProductQuotaDimensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductQuotaDimensionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of quotas for a specified cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductQuotasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductQuotasResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of quotas for a specified cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductQuotasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductQuotasResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of quotas for a specified cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductQuotasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductQuotasResponse
        /// </returns>
        public ListProductQuotasResponse ListProductQuotas(ListProductQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductQuotasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of quotas for a specified cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductQuotasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductQuotasResponse
        /// </returns>
        public async Task<ListProductQuotasResponse> ListProductQuotasAsync(ListProductQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductQuotasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of Alibaba Cloud services supported by Quota Center.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The query results are the same as those in <a href="https://help.aliyun.com/document_detail/182368.html">Alibaba Cloud services supported by Quota Center</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of Alibaba Cloud services supported by Quota Center.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The query results are the same as those in <a href="https://help.aliyun.com/document_detail/182368.html">Alibaba Cloud services supported by Quota Center</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of Alibaba Cloud services supported by Quota Center.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The query results are the same as those in <a href="https://help.aliyun.com/document_detail/182368.html">Alibaba Cloud services supported by Quota Center</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
        public ListProductsResponse ListProducts(ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of Alibaba Cloud services supported by Quota Center.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The query results are the same as those in <a href="https://help.aliyun.com/document_detail/182368.html">Alibaba Cloud services supported by Quota Center</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
        public async Task<ListProductsResponse> ListProductsAsync(ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quota usage alerts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alert feature has been upgraded. This API operation is scheduled for deprecation and queries only earlier-version quota usage alerts. To query new-version quota usage alerts, call the CloudMonitor API operation <a href="https://help.aliyun.com/document_detail/2513291.html">DescribeMetricRuleList</a>. For more information about how to manage new-version quota alerts using API operations, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new-version quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListQuotaAlarmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaAlarmsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quota usage alerts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alert feature has been upgraded. This API operation is scheduled for deprecation and queries only earlier-version quota usage alerts. To query new-version quota usage alerts, call the CloudMonitor API operation <a href="https://help.aliyun.com/document_detail/2513291.html">DescribeMetricRuleList</a>. For more information about how to manage new-version quota alerts using API operations, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new-version quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListQuotaAlarmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaAlarmsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quota usage alerts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alert feature has been upgraded. This API operation is scheduled for deprecation and queries only earlier-version quota usage alerts. To query new-version quota usage alerts, call the CloudMonitor API operation <a href="https://help.aliyun.com/document_detail/2513291.html">DescribeMetricRuleList</a>. For more information about how to manage new-version quota alerts using API operations, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new-version quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListQuotaAlarmsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaAlarmsResponse
        /// </returns>
        public ListQuotaAlarmsResponse ListQuotaAlarms(ListQuotaAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuotaAlarmsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quota usage alerts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The quota alert feature has been upgraded. This API operation is scheduled for deprecation and queries only earlier-version quota usage alerts. To query new-version quota usage alerts, call the CloudMonitor API operation <a href="https://help.aliyun.com/document_detail/2513291.html">DescribeMetricRuleList</a>. For more information about how to manage new-version quota alerts using API operations, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new-version quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListQuotaAlarmsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaAlarmsResponse
        /// </returns>
        public async Task<ListQuotaAlarmsResponse> ListQuotaAlarmsAsync(ListQuotaAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuotaAlarmsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quota templates by using the management account of a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationTemplatesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quota templates by using the management account of a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationTemplatesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quota templates by using the management account of a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationTemplatesResponse
        /// </returns>
        public ListQuotaApplicationTemplatesResponse ListQuotaApplicationTemplates(ListQuotaApplicationTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuotaApplicationTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quota templates by using the management account of a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationTemplatesResponse
        /// </returns>
        public async Task<ListQuotaApplicationTemplatesResponse> ListQuotaApplicationTemplatesAsync(ListQuotaApplicationTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuotaApplicationTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of quota increase applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of quota increase applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of quota increase applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationsResponse
        /// </returns>
        public ListQuotaApplicationsResponse ListQuotaApplications(ListQuotaApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuotaApplicationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of quota increase applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationsResponse
        /// </returns>
        public async Task<ListQuotaApplicationsResponse> ListQuotaApplicationsAsync(ListQuotaApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuotaApplicationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of quota increase applications for members in a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationsDetailForTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationsDetailForTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of quota increase applications for members in a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationsDetailForTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationsDetailForTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of quota increase applications for members in a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationsDetailForTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationsDetailForTemplateResponse
        /// </returns>
        public ListQuotaApplicationsDetailForTemplateResponse ListQuotaApplicationsDetailForTemplate(ListQuotaApplicationsDetailForTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuotaApplicationsDetailForTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of quota increase applications for members in a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationsDetailForTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationsDetailForTemplateResponse
        /// </returns>
        public async Task<ListQuotaApplicationsDetailForTemplateResponse> ListQuotaApplicationsDetailForTemplateAsync(ListQuotaApplicationsDetailForTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuotaApplicationsDetailForTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history of batch requests for member quotas submitted using a quota template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationsForTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationsForTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history of batch requests for member quotas submitted using a quota template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationsForTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationsForTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history of batch requests for member quotas submitted using a quota template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationsForTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationsForTemplateResponse
        /// </returns>
        public ListQuotaApplicationsForTemplateResponse ListQuotaApplicationsForTemplate(ListQuotaApplicationsForTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuotaApplicationsForTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history of batch requests for member quotas submitted using a quota template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaApplicationsForTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaApplicationsForTemplateResponse
        /// </returns>
        public async Task<ListQuotaApplicationsForTemplateResponse> ListQuotaApplicationsForTemplateAsync(ListQuotaApplicationsForTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuotaApplicationsForTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists quota utilization reports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaUtilizationReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaUtilizationReportResponse
        /// </returns>
        public ListQuotaUtilizationReportResponse ListQuotaUtilizationReportWithOptions(ListQuotaUtilizationReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adjustable))
            {
                body["Adjustable"] = request.Adjustable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                body["KeyWords"] = request.KeyWords;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaRegionId))
            {
                body["QuotaRegionId"] = request.QuotaRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UtilizationStatuses))
            {
                body["UtilizationStatuses"] = request.UtilizationStatuses;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotaUtilizationReport",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaUtilizationReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists quota utilization reports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaUtilizationReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaUtilizationReportResponse
        /// </returns>
        public async Task<ListQuotaUtilizationReportResponse> ListQuotaUtilizationReportWithOptionsAsync(ListQuotaUtilizationReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adjustable))
            {
                body["Adjustable"] = request.Adjustable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                body["KeyWords"] = request.KeyWords;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaCategory))
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaRegionId))
            {
                body["QuotaRegionId"] = request.QuotaRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UtilizationStatuses))
            {
                body["UtilizationStatuses"] = request.UtilizationStatuses;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotaUtilizationReport",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaUtilizationReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists quota utilization reports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaUtilizationReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaUtilizationReportResponse
        /// </returns>
        public ListQuotaUtilizationReportResponse ListQuotaUtilizationReport(ListQuotaUtilizationReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuotaUtilizationReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists quota utilization reports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotaUtilizationReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotaUtilizationReportResponse
        /// </returns>
        public async Task<ListQuotaUtilizationReportResponse> ListQuotaUtilizationReportAsync(ListQuotaUtilizationReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuotaUtilizationReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the status of a quota template. By default, the quota template is not configured. If the management account of a resource directory uses a quota template for the first time, you must enable the quota template. Only the management account of a resource directory can change the status of quota templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>A resource directory is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/604185.html">EnableResourceDirectory</a>.</para>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para>If the <c>ServiceStatus</c> parameter is set to <c>0</c> or <c>-1</c>, you can call this operation to set the parameter to <c>1</c>. Then, you can call the <a href="https://help.aliyun.com/document_detail/450615.html">CreateTemplateQuotaItem</a> operation to create a quota template.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyQuotaTemplateServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyQuotaTemplateServiceStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the status of a quota template. By default, the quota template is not configured. If the management account of a resource directory uses a quota template for the first time, you must enable the quota template. Only the management account of a resource directory can change the status of quota templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>A resource directory is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/604185.html">EnableResourceDirectory</a>.</para>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para>If the <c>ServiceStatus</c> parameter is set to <c>0</c> or <c>-1</c>, you can call this operation to set the parameter to <c>1</c>. Then, you can call the <a href="https://help.aliyun.com/document_detail/450615.html">CreateTemplateQuotaItem</a> operation to create a quota template.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyQuotaTemplateServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyQuotaTemplateServiceStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the status of a quota template. By default, the quota template is not configured. If the management account of a resource directory uses a quota template for the first time, you must enable the quota template. Only the management account of a resource directory can change the status of quota templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>A resource directory is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/604185.html">EnableResourceDirectory</a>.</para>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para>If the <c>ServiceStatus</c> parameter is set to <c>0</c> or <c>-1</c>, you can call this operation to set the parameter to <c>1</c>. Then, you can call the <a href="https://help.aliyun.com/document_detail/450615.html">CreateTemplateQuotaItem</a> operation to create a quota template.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyQuotaTemplateServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyQuotaTemplateServiceStatusResponse
        /// </returns>
        public ModifyQuotaTemplateServiceStatusResponse ModifyQuotaTemplateServiceStatus(ModifyQuotaTemplateServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyQuotaTemplateServiceStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the status of a quota template. By default, the quota template is not configured. If the management account of a resource directory uses a quota template for the first time, you must enable the quota template. Only the management account of a resource directory can change the status of quota templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>A resource directory is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/604185.html">EnableResourceDirectory</a>.</para>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para>If the <c>ServiceStatus</c> parameter is set to <c>0</c> or <c>-1</c>, you can call this operation to set the parameter to <c>1</c>. Then, you can call the <a href="https://help.aliyun.com/document_detail/450615.html">CreateTemplateQuotaItem</a> operation to create a quota template.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyQuotaTemplateServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyQuotaTemplateServiceStatusResponse
        /// </returns>
        public async Task<ModifyQuotaTemplateServiceStatusResponse> ModifyQuotaTemplateServiceStatusAsync(ModifyQuotaTemplateServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyQuotaTemplateServiceStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Only the administrator account of a resource directory can modify a quota template. Modifications to a quota template apply only to new members that are added to the resource directory and do not affect existing members.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTemplateQuotaItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTemplateQuotaItemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Only the administrator account of a resource directory can modify a quota template. Modifications to a quota template apply only to new members that are added to the resource directory and do not affect existing members.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTemplateQuotaItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTemplateQuotaItemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Only the administrator account of a resource directory can modify a quota template. Modifications to a quota template apply only to new members that are added to the resource directory and do not affect existing members.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTemplateQuotaItemRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTemplateQuotaItemResponse
        /// </returns>
        public ModifyTemplateQuotaItemResponse ModifyTemplateQuotaItem(ModifyTemplateQuotaItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTemplateQuotaItemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Only the administrator account of a resource directory can modify a quota template. Modifications to a quota template apply only to new members that are added to the resource directory and do not affect existing members.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTemplateQuotaItemRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTemplateQuotaItemResponse
        /// </returns>
        public async Task<ModifyTemplateQuotaItemResponse> ModifyTemplateQuotaItemAsync(ModifyTemplateQuotaItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTemplateQuotaItemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a reminder for a quota application that is pending approval.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation applies only to quota applications that support reminders. In the GetQuotaApplicationApproval response, the <c>SupportReminder</c> parameter for these applications is <c>true</c>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RemindQuotaApplicationApprovalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemindQuotaApplicationApprovalResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a reminder for a quota application that is pending approval.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation applies only to quota applications that support reminders. In the GetQuotaApplicationApproval response, the <c>SupportReminder</c> parameter for these applications is <c>true</c>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RemindQuotaApplicationApprovalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemindQuotaApplicationApprovalResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a reminder for a quota application that is pending approval.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation applies only to quota applications that support reminders. In the GetQuotaApplicationApproval response, the <c>SupportReminder</c> parameter for these applications is <c>true</c>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RemindQuotaApplicationApprovalRequest
        /// </param>
        /// 
        /// <returns>
        /// RemindQuotaApplicationApprovalResponse
        /// </returns>
        public RemindQuotaApplicationApprovalResponse RemindQuotaApplicationApproval(RemindQuotaApplicationApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemindQuotaApplicationApprovalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a reminder for a quota application that is pending approval.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation applies only to quota applications that support reminders. In the GetQuotaApplicationApproval response, the <c>SupportReminder</c> parameter for these applications is <c>true</c>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RemindQuotaApplicationApprovalRequest
        /// </param>
        /// 
        /// <returns>
        /// RemindQuotaApplicationApprovalResponse
        /// </returns>
        public async Task<RemindQuotaApplicationApprovalResponse> RemindQuotaApplicationApprovalAsync(RemindQuotaApplicationApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemindQuotaApplicationApprovalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a quota usage report query. This API applies only to general quotas.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartQuotaUtilizationReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartQuotaUtilizationReportResponse
        /// </returns>
        public StartQuotaUtilizationReportResponse StartQuotaUtilizationReportWithOptions(StartQuotaUtilizationReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartQuotaUtilizationReport",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartQuotaUtilizationReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a quota usage report query. This API applies only to general quotas.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartQuotaUtilizationReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartQuotaUtilizationReportResponse
        /// </returns>
        public async Task<StartQuotaUtilizationReportResponse> StartQuotaUtilizationReportWithOptionsAsync(StartQuotaUtilizationReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartQuotaUtilizationReport",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartQuotaUtilizationReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a quota usage report query. This API applies only to general quotas.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartQuotaUtilizationReportRequest
        /// </param>
        /// 
        /// <returns>
        /// StartQuotaUtilizationReportResponse
        /// </returns>
        public StartQuotaUtilizationReportResponse StartQuotaUtilizationReport(StartQuotaUtilizationReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartQuotaUtilizationReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a quota usage report query. This API applies only to general quotas.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartQuotaUtilizationReportRequest
        /// </param>
        /// 
        /// <returns>
        /// StartQuotaUtilizationReportResponse
        /// </returns>
        public async Task<StartQuotaUtilizationReportResponse> StartQuotaUtilizationReportAsync(StartQuotaUtilizationReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartQuotaUtilizationReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies quota alert information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation is deprecated because the quota alert feature has been upgraded. To modify information about new quota usage alerts, use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513316.html">PutResourceMetricRules</a> and <a href="https://help.aliyun.com/document_detail/2513302.html">PutMetricRuleTargets</a>. For more information about using API operations to manage new quota alerts, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateQuotaAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaAlarmResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies quota alert information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation is deprecated because the quota alert feature has been upgraded. To modify information about new quota usage alerts, use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513316.html">PutResourceMetricRules</a> and <a href="https://help.aliyun.com/document_detail/2513302.html">PutMetricRuleTargets</a>. For more information about using API operations to manage new quota alerts, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateQuotaAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaAlarmResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies quota alert information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation is deprecated because the quota alert feature has been upgraded. To modify information about new quota usage alerts, use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513316.html">PutResourceMetricRules</a> and <a href="https://help.aliyun.com/document_detail/2513302.html">PutMetricRuleTargets</a>. For more information about using API operations to manage new quota alerts, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateQuotaAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaAlarmResponse
        /// </returns>
        public UpdateQuotaAlarmResponse UpdateQuotaAlarm(UpdateQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQuotaAlarmWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies quota alert information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation is deprecated because the quota alert feature has been upgraded. To modify information about new quota usage alerts, use the CloudMonitor API operations <a href="https://help.aliyun.com/document_detail/2513316.html">PutResourceMetricRules</a> and <a href="https://help.aliyun.com/document_detail/2513302.html">PutMetricRuleTargets</a>. For more information about using API operations to manage new quota alerts, see <a href="https://help.aliyun.com/document_detail/2863234.html">Use API operations to manage new quota alerts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateQuotaAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaAlarmResponse
        /// </returns>
        public async Task<UpdateQuotaAlarmResponse> UpdateQuotaAlarmAsync(UpdateQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQuotaAlarmWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Withdraws a quota application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WithdrawQuotaApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WithdrawQuotaApplicationResponse
        /// </returns>
        public WithdrawQuotaApplicationResponse WithdrawQuotaApplicationWithOptions(WithdrawQuotaApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                body["ApplicationId"] = request.ApplicationId;
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
                Action = "WithdrawQuotaApplication",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WithdrawQuotaApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Withdraws a quota application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WithdrawQuotaApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WithdrawQuotaApplicationResponse
        /// </returns>
        public async Task<WithdrawQuotaApplicationResponse> WithdrawQuotaApplicationWithOptionsAsync(WithdrawQuotaApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                body["ApplicationId"] = request.ApplicationId;
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
                Action = "WithdrawQuotaApplication",
                Version = "2020-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WithdrawQuotaApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Withdraws a quota application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WithdrawQuotaApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// WithdrawQuotaApplicationResponse
        /// </returns>
        public WithdrawQuotaApplicationResponse WithdrawQuotaApplication(WithdrawQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WithdrawQuotaApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Withdraws a quota application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WithdrawQuotaApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// WithdrawQuotaApplicationResponse
        /// </returns>
        public async Task<WithdrawQuotaApplicationResponse> WithdrawQuotaApplicationAsync(WithdrawQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WithdrawQuotaApplicationWithOptionsAsync(request, runtime);
        }

    }
}
