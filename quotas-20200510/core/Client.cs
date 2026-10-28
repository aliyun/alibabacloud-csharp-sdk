// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Darabonba.Utils;
using _OpenApiClient = AlibabaCloud.OpenApiClient.Client;
using AlibabaCloud.OpenApiClient.Models;
using AlibabaCloud.OpenApiClient;
using AlibabaCloud.SDK.Quotas20200510.Models;
using Darabonba;

namespace AlibabaCloud.SDK.Quotas20200510
{
    public class Client : _OpenApiClient
    {

        public Client(Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("quotas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!endpoint.IsNull())
            {
                return endpoint;
            }
            if (!endpointMap.IsNull() && !endpointMap.Get(regionId).IsNull())
            {
                return endpointMap.Get(regionId);
            }
            return Utils.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
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
        public CreateQuotaAlarmResponse CreateQuotaAlarmWithOptions(CreateQuotaAlarmRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AlarmName.IsNull())
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!request.OriginalContext.IsNull())
            {
                body["OriginalContext"] = request.OriginalContext;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaDimensions.IsNull())
            {
                body["QuotaDimensions"] = request.QuotaDimensions;
            }
            if (!request.Threshold.IsNull())
            {
                body["Threshold"] = request.Threshold;
            }
            if (!request.ThresholdPercent.IsNull())
            {
                body["ThresholdPercent"] = request.ThresholdPercent;
            }
            if (!request.ThresholdType.IsNull())
            {
                body["ThresholdType"] = request.ThresholdType;
            }
            if (!request.WebHook.IsNull())
            {
                body["WebHook"] = request.WebHook;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<CreateQuotaAlarmResponse>(CallApi(params_, req, runtime));
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
        public async Task<CreateQuotaAlarmResponse> CreateQuotaAlarmWithOptionsAsync(CreateQuotaAlarmRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AlarmName.IsNull())
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!request.OriginalContext.IsNull())
            {
                body["OriginalContext"] = request.OriginalContext;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaDimensions.IsNull())
            {
                body["QuotaDimensions"] = request.QuotaDimensions;
            }
            if (!request.Threshold.IsNull())
            {
                body["Threshold"] = request.Threshold;
            }
            if (!request.ThresholdPercent.IsNull())
            {
                body["ThresholdPercent"] = request.ThresholdPercent;
            }
            if (!request.ThresholdType.IsNull())
            {
                body["ThresholdType"] = request.ThresholdType;
            }
            if (!request.WebHook.IsNull())
            {
                body["WebHook"] = request.WebHook;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<CreateQuotaAlarmResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public CreateQuotaApplicationResponse CreateQuotaApplicationWithOptions(CreateQuotaApplicationRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AuditMode.IsNull())
            {
                body["AuditMode"] = request.AuditMode;
            }
            if (!request.DesireValue.IsNull())
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.EffectiveTime.IsNull())
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!request.EnvLanguage.IsNull())
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!request.ExpireTime.IsNull())
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!request.NoticeType.IsNull())
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!request.Reason.IsNull())
            {
                body["Reason"] = request.Reason;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<CreateQuotaApplicationResponse>(CallApi(params_, req, runtime));
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
        public async Task<CreateQuotaApplicationResponse> CreateQuotaApplicationWithOptionsAsync(CreateQuotaApplicationRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AuditMode.IsNull())
            {
                body["AuditMode"] = request.AuditMode;
            }
            if (!request.DesireValue.IsNull())
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.EffectiveTime.IsNull())
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!request.EnvLanguage.IsNull())
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!request.ExpireTime.IsNull())
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!request.NoticeType.IsNull())
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!request.Reason.IsNull())
            {
                body["Reason"] = request.Reason;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<CreateQuotaApplicationResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public CreateQuotaApplicationsForTemplateResponse CreateQuotaApplicationsForTemplateWithOptions(CreateQuotaApplicationsForTemplateRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AliyunUids.IsNull())
            {
                body["AliyunUids"] = request.AliyunUids;
            }
            if (!request.DesireValue.IsNull())
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.EffectiveTime.IsNull())
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!request.EnvLanguage.IsNull())
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!request.ExpireTime.IsNull())
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!request.NoticeType.IsNull())
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!request.Reason.IsNull())
            {
                body["Reason"] = request.Reason;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<CreateQuotaApplicationsForTemplateResponse>(CallApi(params_, req, runtime));
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
        public async Task<CreateQuotaApplicationsForTemplateResponse> CreateQuotaApplicationsForTemplateWithOptionsAsync(CreateQuotaApplicationsForTemplateRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AliyunUids.IsNull())
            {
                body["AliyunUids"] = request.AliyunUids;
            }
            if (!request.DesireValue.IsNull())
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.EffectiveTime.IsNull())
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!request.EnvLanguage.IsNull())
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!request.ExpireTime.IsNull())
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!request.NoticeType.IsNull())
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!request.Reason.IsNull())
            {
                body["Reason"] = request.Reason;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<CreateQuotaApplicationsForTemplateResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public CreateTemplateQuotaItemResponse CreateTemplateQuotaItemWithOptions(CreateTemplateQuotaItemRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.DesireValue.IsNull())
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.EffectiveTime.IsNull())
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!request.EnvLanguage.IsNull())
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!request.ExpireTime.IsNull())
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!request.NoticeType.IsNull())
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<CreateTemplateQuotaItemResponse>(CallApi(params_, req, runtime));
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
        public async Task<CreateTemplateQuotaItemResponse> CreateTemplateQuotaItemWithOptionsAsync(CreateTemplateQuotaItemRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.DesireValue.IsNull())
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.EffectiveTime.IsNull())
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!request.EnvLanguage.IsNull())
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!request.ExpireTime.IsNull())
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!request.NoticeType.IsNull())
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<CreateTemplateQuotaItemResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public DeleteQuotaAlarmResponse DeleteQuotaAlarmWithOptions(DeleteQuotaAlarmRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AlarmId.IsNull())
            {
                body["AlarmId"] = request.AlarmId;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<DeleteQuotaAlarmResponse>(CallApi(params_, req, runtime));
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
        public async Task<DeleteQuotaAlarmResponse> DeleteQuotaAlarmWithOptionsAsync(DeleteQuotaAlarmRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AlarmId.IsNull())
            {
                body["AlarmId"] = request.AlarmId;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<DeleteQuotaAlarmResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public DeleteTemplateQuotaItemResponse DeleteTemplateQuotaItemWithOptions(DeleteTemplateQuotaItemRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.Id.IsNull())
            {
                body["Id"] = request.Id;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<DeleteTemplateQuotaItemResponse>(CallApi(params_, req, runtime));
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
        public async Task<DeleteTemplateQuotaItemResponse> DeleteTemplateQuotaItemWithOptionsAsync(DeleteTemplateQuotaItemRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.Id.IsNull())
            {
                body["Id"] = request.Id;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<DeleteTemplateQuotaItemResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public GetProductQuotaResponse GetProductQuotaWithOptions(GetProductQuotaRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetProductQuotaResponse>(CallApi(params_, req, runtime));
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
        public async Task<GetProductQuotaResponse> GetProductQuotaWithOptionsAsync(GetProductQuotaRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetProductQuotaResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public GetProductQuotaDimensionResponse GetProductQuotaDimensionWithOptions(GetProductQuotaDimensionRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.DependentDimensions.IsNull())
            {
                body["DependentDimensions"] = request.DependentDimensions;
            }
            if (!request.DimensionKey.IsNull())
            {
                body["DimensionKey"] = request.DimensionKey;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetProductQuotaDimensionResponse>(CallApi(params_, req, runtime));
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
        public async Task<GetProductQuotaDimensionResponse> GetProductQuotaDimensionWithOptionsAsync(GetProductQuotaDimensionRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.DependentDimensions.IsNull())
            {
                body["DependentDimensions"] = request.DependentDimensions;
            }
            if (!request.DimensionKey.IsNull())
            {
                body["DimensionKey"] = request.DimensionKey;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetProductQuotaDimensionResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public GetQuotaAlarmResponse GetQuotaAlarmWithOptions(GetQuotaAlarmRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AlarmId.IsNull())
            {
                body["AlarmId"] = request.AlarmId;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetQuotaAlarmResponse>(CallApi(params_, req, runtime));
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
        public async Task<GetQuotaAlarmResponse> GetQuotaAlarmWithOptionsAsync(GetQuotaAlarmRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AlarmId.IsNull())
            {
                body["AlarmId"] = request.AlarmId;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetQuotaAlarmResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public GetQuotaApplicationResponse GetQuotaApplicationWithOptions(GetQuotaApplicationRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ApplicationId.IsNull())
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetQuotaApplicationResponse>(CallApi(params_, req, runtime));
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
        public async Task<GetQuotaApplicationResponse> GetQuotaApplicationWithOptionsAsync(GetQuotaApplicationRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ApplicationId.IsNull())
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetQuotaApplicationResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public GetQuotaApplicationApprovalResponse GetQuotaApplicationApprovalWithOptions(GetQuotaApplicationApprovalRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ApplicationId.IsNull())
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetQuotaApplicationApprovalResponse>(CallApi(params_, req, runtime));
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
        public async Task<GetQuotaApplicationApprovalResponse> GetQuotaApplicationApprovalWithOptionsAsync(GetQuotaApplicationApprovalRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ApplicationId.IsNull())
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetQuotaApplicationApprovalResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public GetQuotaTemplateServiceStatusResponse GetQuotaTemplateServiceStatusWithOptions(GetQuotaTemplateServiceStatusRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ResourceDirectoryId.IsNull())
            {
                body["ResourceDirectoryId"] = request.ResourceDirectoryId;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetQuotaTemplateServiceStatusResponse>(CallApi(params_, req, runtime));
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
        public async Task<GetQuotaTemplateServiceStatusResponse> GetQuotaTemplateServiceStatusWithOptionsAsync(GetQuotaTemplateServiceStatusRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ResourceDirectoryId.IsNull())
            {
                body["ResourceDirectoryId"] = request.ResourceDirectoryId;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetQuotaTemplateServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
            return await GetQuotaTemplateServiceStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取配额使用率概览</para>
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
        public GetQuotaUtilizationOverviewResponse GetQuotaUtilizationOverviewWithOptions(GetQuotaUtilizationOverviewRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetQuotaUtilizationOverviewResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取配额使用率概览</para>
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
        public async Task<GetQuotaUtilizationOverviewResponse> GetQuotaUtilizationOverviewWithOptionsAsync(GetQuotaUtilizationOverviewRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<GetQuotaUtilizationOverviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取配额使用率概览</para>
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
            return GetQuotaUtilizationOverviewWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取配额使用率概览</para>
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public ListAlarmHistoriesResponse ListAlarmHistoriesWithOptions(ListAlarmHistoriesRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AlarmId.IsNull())
            {
                body["AlarmId"] = request.AlarmId;
            }
            if (!request.EndTime.IsNull())
            {
                body["EndTime"] = request.EndTime;
            }
            if (!request.Keyword.IsNull())
            {
                body["Keyword"] = request.Keyword;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.StartTime.IsNull())
            {
                body["StartTime"] = request.StartTime;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListAlarmHistoriesResponse>(CallApi(params_, req, runtime));
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
        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesWithOptionsAsync(ListAlarmHistoriesRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AlarmId.IsNull())
            {
                body["AlarmId"] = request.AlarmId;
            }
            if (!request.EndTime.IsNull())
            {
                body["EndTime"] = request.EndTime;
            }
            if (!request.Keyword.IsNull())
            {
                body["Keyword"] = request.Keyword;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.StartTime.IsNull())
            {
                body["StartTime"] = request.StartTime;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListAlarmHistoriesResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public ListDependentQuotasResponse ListDependentQuotasWithOptions(ListDependentQuotasRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListDependentQuotasResponse>(CallApi(params_, req, runtime));
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
        public async Task<ListDependentQuotasResponse> ListDependentQuotasWithOptionsAsync(ListDependentQuotasRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListDependentQuotasResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public ListProductDimensionGroupsResponse ListProductDimensionGroupsWithOptions(ListProductDimensionGroupsRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!request.MaxResults.IsNull())
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                query["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                query["ProductCode"] = request.ProductCode;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Query = Utils.Query(query),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListProductDimensionGroupsResponse>(CallApi(params_, req, runtime));
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
        public async Task<ListProductDimensionGroupsResponse> ListProductDimensionGroupsWithOptionsAsync(ListProductDimensionGroupsRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!request.MaxResults.IsNull())
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                query["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                query["ProductCode"] = request.ProductCode;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Query = Utils.Query(query),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListProductDimensionGroupsResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public ListProductQuotaDimensionsResponse ListProductQuotaDimensionsWithOptions(ListProductQuotaDimensionsRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListProductQuotaDimensionsResponse>(CallApi(params_, req, runtime));
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
        public async Task<ListProductQuotaDimensionsResponse> ListProductQuotaDimensionsWithOptionsAsync(ListProductQuotaDimensionsRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListProductQuotaDimensionsResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
            return await ListProductQuotaDimensionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quotas of a specified cloud service.</para>
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
        public ListProductQuotasResponse ListProductQuotasWithOptions(ListProductQuotasRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.GroupCode.IsNull())
            {
                body["GroupCode"] = request.GroupCode;
            }
            if (!request.KeyWord.IsNull())
            {
                body["KeyWord"] = request.KeyWord;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!request.SortField.IsNull())
            {
                body["SortField"] = request.SortField;
            }
            if (!request.SortOrder.IsNull())
            {
                body["SortOrder"] = request.SortOrder;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListProductQuotasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quotas of a specified cloud service.</para>
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
        public async Task<ListProductQuotasResponse> ListProductQuotasWithOptionsAsync(ListProductQuotasRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.GroupCode.IsNull())
            {
                body["GroupCode"] = request.GroupCode;
            }
            if (!request.KeyWord.IsNull())
            {
                body["KeyWord"] = request.KeyWord;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!request.SortField.IsNull())
            {
                body["SortField"] = request.SortField;
            }
            if (!request.SortOrder.IsNull())
            {
                body["SortOrder"] = request.SortOrder;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListProductQuotasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quotas of a specified cloud service.</para>
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
            return ListProductQuotasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quotas of a specified cloud service.</para>
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public ListProductsResponse ListProductsWithOptions(ListProductsRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListProductsResponse>(CallApi(params_, req, runtime));
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
        public async Task<ListProductsResponse> ListProductsWithOptionsAsync(ListProductsRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListProductsResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public ListQuotaAlarmsResponse ListQuotaAlarmsWithOptions(ListQuotaAlarmsRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AlarmName.IsNull())
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaDimensions.IsNull())
            {
                body["QuotaDimensions"] = request.QuotaDimensions;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListQuotaAlarmsResponse>(CallApi(params_, req, runtime));
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
        public async Task<ListQuotaAlarmsResponse> ListQuotaAlarmsWithOptionsAsync(ListQuotaAlarmsRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AlarmName.IsNull())
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaDimensions.IsNull())
            {
                body["QuotaDimensions"] = request.QuotaDimensions;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListQuotaAlarmsResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public ListQuotaApplicationTemplatesResponse ListQuotaApplicationTemplatesWithOptions(ListQuotaApplicationTemplatesRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!request.NextToken.IsNull())
            {
                query["NextToken"] = request.NextToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.Id.IsNull())
            {
                body["Id"] = request.Id;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Query = Utils.Query(query),
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListQuotaApplicationTemplatesResponse>(CallApi(params_, req, runtime));
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
        public async Task<ListQuotaApplicationTemplatesResponse> ListQuotaApplicationTemplatesWithOptionsAsync(ListQuotaApplicationTemplatesRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!request.NextToken.IsNull())
            {
                query["NextToken"] = request.NextToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.Id.IsNull())
            {
                body["Id"] = request.Id;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Query = Utils.Query(query),
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListQuotaApplicationTemplatesResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public ListQuotaApplicationsResponse ListQuotaApplicationsWithOptions(ListQuotaApplicationsRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.KeyWord.IsNull())
            {
                body["KeyWord"] = request.KeyWord;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!request.Status.IsNull())
            {
                body["Status"] = request.Status;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListQuotaApplicationsResponse>(CallApi(params_, req, runtime));
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
        public async Task<ListQuotaApplicationsResponse> ListQuotaApplicationsWithOptionsAsync(ListQuotaApplicationsRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.KeyWord.IsNull())
            {
                body["KeyWord"] = request.KeyWord;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!request.Status.IsNull())
            {
                body["Status"] = request.Status;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListQuotaApplicationsResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
            return await ListQuotaApplicationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of quota increase applications for a member in a resource directory.</para>
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
        public ListQuotaApplicationsDetailForTemplateResponse ListQuotaApplicationsDetailForTemplateWithOptions(ListQuotaApplicationsDetailForTemplateRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AliyunUid.IsNull())
            {
                body["AliyunUid"] = request.AliyunUid;
            }
            if (!request.BatchQuotaApplicationId.IsNull())
            {
                body["BatchQuotaApplicationId"] = request.BatchQuotaApplicationId;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!request.Status.IsNull())
            {
                body["Status"] = request.Status;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListQuotaApplicationsDetailForTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of quota increase applications for a member in a resource directory.</para>
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
        public async Task<ListQuotaApplicationsDetailForTemplateResponse> ListQuotaApplicationsDetailForTemplateWithOptionsAsync(ListQuotaApplicationsDetailForTemplateRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AliyunUid.IsNull())
            {
                body["AliyunUid"] = request.AliyunUid;
            }
            if (!request.BatchQuotaApplicationId.IsNull())
            {
                body["BatchQuotaApplicationId"] = request.BatchQuotaApplicationId;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!request.Status.IsNull())
            {
                body["Status"] = request.Status;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListQuotaApplicationsDetailForTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of quota increase applications for a member in a resource directory.</para>
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
            return ListQuotaApplicationsDetailForTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of quota increase applications for a member in a resource directory.</para>
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public ListQuotaApplicationsForTemplateResponse ListQuotaApplicationsForTemplateWithOptions(ListQuotaApplicationsForTemplateRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ApplyEndTime.IsNull())
            {
                body["ApplyEndTime"] = request.ApplyEndTime;
            }
            if (!request.ApplyStartTime.IsNull())
            {
                body["ApplyStartTime"] = request.ApplyStartTime;
            }
            if (!request.BatchQuotaApplicationId.IsNull())
            {
                body["BatchQuotaApplicationId"] = request.BatchQuotaApplicationId;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListQuotaApplicationsForTemplateResponse>(CallApi(params_, req, runtime));
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
        public async Task<ListQuotaApplicationsForTemplateResponse> ListQuotaApplicationsForTemplateWithOptionsAsync(ListQuotaApplicationsForTemplateRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ApplyEndTime.IsNull())
            {
                body["ApplyEndTime"] = request.ApplyEndTime;
            }
            if (!request.ApplyStartTime.IsNull())
            {
                body["ApplyStartTime"] = request.ApplyStartTime;
            }
            if (!request.BatchQuotaApplicationId.IsNull())
            {
                body["BatchQuotaApplicationId"] = request.BatchQuotaApplicationId;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListQuotaApplicationsForTemplateResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
            return await ListQuotaApplicationsForTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举配额使用率报告</para>
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
        public ListQuotaUtilizationReportResponse ListQuotaUtilizationReportWithOptions(ListQuotaUtilizationReportRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.Adjustable.IsNull())
            {
                body["Adjustable"] = request.Adjustable;
            }
            if (!request.KeyWords.IsNull())
            {
                body["KeyWords"] = request.KeyWords;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!request.QuotaRegionId.IsNull())
            {
                body["QuotaRegionId"] = request.QuotaRegionId;
            }
            if (!request.UtilizationStatuses.IsNull())
            {
                body["UtilizationStatuses"] = request.UtilizationStatuses;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListQuotaUtilizationReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举配额使用率报告</para>
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
        public async Task<ListQuotaUtilizationReportResponse> ListQuotaUtilizationReportWithOptionsAsync(ListQuotaUtilizationReportRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.Adjustable.IsNull())
            {
                body["Adjustable"] = request.Adjustable;
            }
            if (!request.KeyWords.IsNull())
            {
                body["KeyWords"] = request.KeyWords;
            }
            if (!request.MaxResults.IsNull())
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!request.NextToken.IsNull())
            {
                body["NextToken"] = request.NextToken;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaCategory.IsNull())
            {
                body["QuotaCategory"] = request.QuotaCategory;
            }
            if (!request.QuotaRegionId.IsNull())
            {
                body["QuotaRegionId"] = request.QuotaRegionId;
            }
            if (!request.UtilizationStatuses.IsNull())
            {
                body["UtilizationStatuses"] = request.UtilizationStatuses;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ListQuotaUtilizationReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举配额使用率报告</para>
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
            return ListQuotaUtilizationReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举配额使用率报告</para>
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public ModifyQuotaTemplateServiceStatusResponse ModifyQuotaTemplateServiceStatusWithOptions(ModifyQuotaTemplateServiceStatusRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ServiceStatus.IsNull())
            {
                body["ServiceStatus"] = request.ServiceStatus;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ModifyQuotaTemplateServiceStatusResponse>(CallApi(params_, req, runtime));
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
        public async Task<ModifyQuotaTemplateServiceStatusResponse> ModifyQuotaTemplateServiceStatusWithOptionsAsync(ModifyQuotaTemplateServiceStatusRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ServiceStatus.IsNull())
            {
                body["ServiceStatus"] = request.ServiceStatus;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ModifyQuotaTemplateServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public ModifyTemplateQuotaItemResponse ModifyTemplateQuotaItemWithOptions(ModifyTemplateQuotaItemRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!request.QuotaCategory.IsNull())
            {
                query["QuotaCategory"] = request.QuotaCategory;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.DesireValue.IsNull())
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.EffectiveTime.IsNull())
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!request.EnvLanguage.IsNull())
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!request.ExpireTime.IsNull())
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!request.Id.IsNull())
            {
                body["Id"] = request.Id;
            }
            if (!request.NoticeType.IsNull())
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Query = Utils.Query(query),
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ModifyTemplateQuotaItemResponse>(CallApi(params_, req, runtime));
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
        public async Task<ModifyTemplateQuotaItemResponse> ModifyTemplateQuotaItemWithOptionsAsync(ModifyTemplateQuotaItemRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!request.QuotaCategory.IsNull())
            {
                query["QuotaCategory"] = request.QuotaCategory;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.DesireValue.IsNull())
            {
                body["DesireValue"] = request.DesireValue;
            }
            if (!request.Dimensions.IsNull())
            {
                body["Dimensions"] = request.Dimensions;
            }
            if (!request.EffectiveTime.IsNull())
            {
                body["EffectiveTime"] = request.EffectiveTime;
            }
            if (!request.EnvLanguage.IsNull())
            {
                body["EnvLanguage"] = request.EnvLanguage;
            }
            if (!request.ExpireTime.IsNull())
            {
                body["ExpireTime"] = request.ExpireTime;
            }
            if (!request.Id.IsNull())
            {
                body["Id"] = request.Id;
            }
            if (!request.NoticeType.IsNull())
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!request.ProductCode.IsNull())
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!request.QuotaActionCode.IsNull())
            {
                body["QuotaActionCode"] = request.QuotaActionCode;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Query = Utils.Query(query),
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<ModifyTemplateQuotaItemResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public RemindQuotaApplicationApprovalResponse RemindQuotaApplicationApprovalWithOptions(RemindQuotaApplicationApprovalRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ApplicationId.IsNull())
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<RemindQuotaApplicationApprovalResponse>(CallApi(params_, req, runtime));
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
        public async Task<RemindQuotaApplicationApprovalResponse> RemindQuotaApplicationApprovalWithOptionsAsync(RemindQuotaApplicationApprovalRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.ApplicationId.IsNull())
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<RemindQuotaApplicationApprovalResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
            return await RemindQuotaApplicationApprovalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发起配额使用率报告查询</para>
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
        public StartQuotaUtilizationReportResponse StartQuotaUtilizationReportWithOptions(StartQuotaUtilizationReportRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            OpenApiRequest req = new OpenApiRequest();
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<StartQuotaUtilizationReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发起配额使用率报告查询</para>
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
        public async Task<StartQuotaUtilizationReportResponse> StartQuotaUtilizationReportWithOptionsAsync(StartQuotaUtilizationReportRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            OpenApiRequest req = new OpenApiRequest();
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<StartQuotaUtilizationReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发起配额使用率报告查询</para>
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
            return StartQuotaUtilizationReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发起配额使用率报告查询</para>
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
        public UpdateQuotaAlarmResponse UpdateQuotaAlarmWithOptions(UpdateQuotaAlarmRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AlarmId.IsNull())
            {
                body["AlarmId"] = request.AlarmId;
            }
            if (!request.AlarmName.IsNull())
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!request.Threshold.IsNull())
            {
                body["Threshold"] = request.Threshold;
            }
            if (!request.ThresholdPercent.IsNull())
            {
                body["ThresholdPercent"] = request.ThresholdPercent;
            }
            if (!request.ThresholdType.IsNull())
            {
                body["ThresholdType"] = request.ThresholdType;
            }
            if (!request.WebHook.IsNull())
            {
                body["WebHook"] = request.WebHook;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<UpdateQuotaAlarmResponse>(CallApi(params_, req, runtime));
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
        public async Task<UpdateQuotaAlarmResponse> UpdateQuotaAlarmWithOptionsAsync(UpdateQuotaAlarmRequest request, Darabonba.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!request.AlarmId.IsNull())
            {
                body["AlarmId"] = request.AlarmId;
            }
            if (!request.AlarmName.IsNull())
            {
                body["AlarmName"] = request.AlarmName;
            }
            if (!request.Threshold.IsNull())
            {
                body["Threshold"] = request.Threshold;
            }
            if (!request.ThresholdPercent.IsNull())
            {
                body["ThresholdPercent"] = request.ThresholdPercent;
            }
            if (!request.ThresholdType.IsNull())
            {
                body["ThresholdType"] = request.ThresholdType;
            }
            if (!request.WebHook.IsNull())
            {
                body["WebHook"] = request.WebHook;
            }
            OpenApiRequest req = new OpenApiRequest
            {
                Body = Utils.ParseToMap(body),
            };
            Params params_ = new Params
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
            return Darabonba.Model.ToObject<UpdateQuotaAlarmResponse>(await CallApiAsync(params_, req, runtime));
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
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
            Darabonba.Models.RuntimeOptions runtime = new Darabonba.Models.RuntimeOptions();
            return await UpdateQuotaAlarmWithOptionsAsync(request, runtime);
        }

    }
}

