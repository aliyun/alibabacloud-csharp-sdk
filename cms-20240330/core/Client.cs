// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cms20240330.Models;

namespace AlibabaCloud.SDK.Cms20240330
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cms", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Install the access component, representing a single access attempt</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Used to create a site monitoring task</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAddonReleaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAddonReleaseResponse
        /// </returns>
        public CreateAddonReleaseResponse CreateAddonReleaseWithOptions(string policyId, CreateAddonReleaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                body["addonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                body["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityRules))
            {
                body["entityRules"] = request.EntityRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvType))
            {
                body["envType"] = request.EnvType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentAddonReleaseId))
            {
                body["parentAddonReleaseId"] = request.ParentAddonReleaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseName))
            {
                body["releaseName"] = request.ReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Values))
            {
                body["values"] = request.Values;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAddonRelease",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/addon-releases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAddonReleaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Install the access component, representing a single access attempt</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Used to create a site monitoring task</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAddonReleaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAddonReleaseResponse
        /// </returns>
        public async Task<CreateAddonReleaseResponse> CreateAddonReleaseWithOptionsAsync(string policyId, CreateAddonReleaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                body["addonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                body["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityRules))
            {
                body["entityRules"] = request.EntityRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvType))
            {
                body["envType"] = request.EnvType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentAddonReleaseId))
            {
                body["parentAddonReleaseId"] = request.ParentAddonReleaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseName))
            {
                body["releaseName"] = request.ReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Values))
            {
                body["values"] = request.Values;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAddonRelease",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/addon-releases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAddonReleaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Install the access component, representing a single access attempt</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Used to create a site monitoring task</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAddonReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAddonReleaseResponse
        /// </returns>
        public CreateAddonReleaseResponse CreateAddonRelease(string policyId, CreateAddonReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAddonReleaseWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Install the access component, representing a single access attempt</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Used to create a site monitoring task</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAddonReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAddonReleaseResponse
        /// </returns>
        public async Task<CreateAddonReleaseResponse> CreateAddonReleaseAsync(string policyId, CreateAddonReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAddonReleaseWithOptionsAsync(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Aggregation Task Group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAggTaskGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAggTaskGroupResponse
        /// </returns>
        public CreateAggTaskGroupResponse CreateAggTaskGroupWithOptions(string instanceId, CreateAggTaskGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverrideIfExists))
            {
                query["overrideIfExists"] = request.OverrideIfExists;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggTaskGroupConfig))
            {
                body["aggTaskGroupConfig"] = request.AggTaskGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggTaskGroupConfigType))
            {
                body["aggTaskGroupConfigType"] = request.AggTaskGroupConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggTaskGroupName))
            {
                body["aggTaskGroupName"] = request.AggTaskGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpr))
            {
                body["cronExpr"] = request.CronExpr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delay))
            {
                body["delay"] = request.Delay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                body["fromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRetries))
            {
                body["maxRetries"] = request.MaxRetries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRunTimeInSeconds))
            {
                body["maxRunTimeInSeconds"] = request.MaxRunTimeInSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrecheckString))
            {
                body["precheckString"] = request.PrecheckString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMode))
            {
                body["scheduleMode"] = request.ScheduleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTimeExpr))
            {
                body["scheduleTimeExpr"] = request.ScheduleTimeExpr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPrometheusId))
            {
                body["targetPrometheusId"] = request.TargetPrometheusId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                body["toTime"] = request.ToTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggTaskGroup",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/agg-task-groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggTaskGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Aggregation Task Group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAggTaskGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAggTaskGroupResponse
        /// </returns>
        public async Task<CreateAggTaskGroupResponse> CreateAggTaskGroupWithOptionsAsync(string instanceId, CreateAggTaskGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverrideIfExists))
            {
                query["overrideIfExists"] = request.OverrideIfExists;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggTaskGroupConfig))
            {
                body["aggTaskGroupConfig"] = request.AggTaskGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggTaskGroupConfigType))
            {
                body["aggTaskGroupConfigType"] = request.AggTaskGroupConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggTaskGroupName))
            {
                body["aggTaskGroupName"] = request.AggTaskGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpr))
            {
                body["cronExpr"] = request.CronExpr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delay))
            {
                body["delay"] = request.Delay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                body["fromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRetries))
            {
                body["maxRetries"] = request.MaxRetries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRunTimeInSeconds))
            {
                body["maxRunTimeInSeconds"] = request.MaxRunTimeInSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrecheckString))
            {
                body["precheckString"] = request.PrecheckString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMode))
            {
                body["scheduleMode"] = request.ScheduleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTimeExpr))
            {
                body["scheduleTimeExpr"] = request.ScheduleTimeExpr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPrometheusId))
            {
                body["targetPrometheusId"] = request.TargetPrometheusId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                body["toTime"] = request.ToTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAggTaskGroup",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/agg-task-groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAggTaskGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Aggregation Task Group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAggTaskGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAggTaskGroupResponse
        /// </returns>
        public CreateAggTaskGroupResponse CreateAggTaskGroup(string instanceId, CreateAggTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAggTaskGroupWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Aggregation Task Group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAggTaskGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAggTaskGroupResponse
        /// </returns>
        public async Task<CreateAggTaskGroupResponse> CreateAggTaskGroupAsync(string instanceId, CreateAggTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAggTaskGroupWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务链路</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBizTraceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBizTraceResponse
        /// </returns>
        public CreateBizTraceResponse CreateBizTraceWithOptions(CreateBizTraceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedConfig))
            {
                body["advancedConfig"] = request.AdvancedConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTraceCode))
            {
                body["bizTraceCode"] = request.BizTraceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTraceName))
            {
                body["bizTraceName"] = request.BizTraceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleConfig))
            {
                body["ruleConfig"] = request.RuleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBizTrace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/bizTrace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBizTraceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务链路</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBizTraceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBizTraceResponse
        /// </returns>
        public async Task<CreateBizTraceResponse> CreateBizTraceWithOptionsAsync(CreateBizTraceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedConfig))
            {
                body["advancedConfig"] = request.AdvancedConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTraceCode))
            {
                body["bizTraceCode"] = request.BizTraceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTraceName))
            {
                body["bizTraceName"] = request.BizTraceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleConfig))
            {
                body["ruleConfig"] = request.RuleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBizTrace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/bizTrace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBizTraceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务链路</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBizTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBizTraceResponse
        /// </returns>
        public CreateBizTraceResponse CreateBizTrace(CreateBizTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateBizTraceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务链路</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBizTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBizTraceResponse
        /// </returns>
        public async Task<CreateBizTraceResponse> CreateBizTraceAsync(CreateBizTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateBizTraceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云资源中心</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudResourceResponse
        /// </returns>
        public CreateCloudResourceResponse CreateCloudResourceWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCloudResource",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/cloudresource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCloudResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云资源中心</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudResourceResponse
        /// </returns>
        public async Task<CreateCloudResourceResponse> CreateCloudResourceWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCloudResource",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/cloudresource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCloudResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云资源中心</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateCloudResourceResponse
        /// </returns>
        public CreateCloudResourceResponse CreateCloudResource()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCloudResourceWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云资源中心</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateCloudResourceResponse
        /// </returns>
        public async Task<CreateCloudResourceResponse> CreateCloudResourceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCloudResourceWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create storage related to EntityStore</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEntityStoreResponse
        /// </returns>
        public CreateEntityStoreResponse CreateEntityStoreWithOptions(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEntityStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/entitystore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEntityStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create storage related to EntityStore</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEntityStoreResponse
        /// </returns>
        public async Task<CreateEntityStoreResponse> CreateEntityStoreWithOptionsAsync(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEntityStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/entitystore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEntityStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create storage related to EntityStore</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateEntityStoreResponse
        /// </returns>
        public CreateEntityStoreResponse CreateEntityStore(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEntityStoreWithOptions(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create storage related to EntityStore</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateEntityStoreResponse
        /// </returns>
        public async Task<CreateEntityStoreResponse> CreateEntityStoreAsync(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEntityStoreWithOptionsAsync(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Access Center Policy</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is used to support users in creating event integration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIntegrationPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIntegrationPolicyResponse
        /// </returns>
        public CreateIntegrationPolicyResponse CreateIntegrationPolicyWithOptions(CreateIntegrationPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityGroup))
            {
                body["entityGroup"] = request.EntityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["policyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                body["policyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIntegrationPolicy",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntegrationPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Access Center Policy</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is used to support users in creating event integration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIntegrationPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIntegrationPolicyResponse
        /// </returns>
        public async Task<CreateIntegrationPolicyResponse> CreateIntegrationPolicyWithOptionsAsync(CreateIntegrationPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityGroup))
            {
                body["entityGroup"] = request.EntityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["policyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                body["policyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIntegrationPolicy",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntegrationPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Access Center Policy</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is used to support users in creating event integration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIntegrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIntegrationPolicyResponse
        /// </returns>
        public CreateIntegrationPolicyResponse CreateIntegrationPolicy(CreateIntegrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIntegrationPolicyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Access Center Policy</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is used to support users in creating event integration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIntegrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIntegrationPolicyResponse
        /// </returns>
        public async Task<CreateIntegrationPolicyResponse> CreateIntegrationPolicyAsync(CreateIntegrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIntegrationPolicyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a Prometheus monitoring instance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrometheusInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusInstanceResponse
        /// </returns>
        public CreatePrometheusInstanceResponse CreatePrometheusInstanceWithOptions(CreatePrometheusInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchiveDuration))
            {
                body["archiveDuration"] = request.ArchiveDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeReadPolicy))
            {
                body["authFreeReadPolicy"] = request.AuthFreeReadPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeWritePolicy))
            {
                body["authFreeWritePolicy"] = request.AuthFreeWritePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeRead))
            {
                body["enableAuthFreeRead"] = request.EnableAuthFreeRead;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeWrite))
            {
                body["enableAuthFreeWrite"] = request.EnableAuthFreeWrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthToken))
            {
                body["enableAuthToken"] = request.EnableAuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["paymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstanceName))
            {
                body["prometheusInstanceName"] = request.PrometheusInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageDuration))
            {
                body["storageDuration"] = request.StorageDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrometheusInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrometheusInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a Prometheus monitoring instance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrometheusInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusInstanceResponse
        /// </returns>
        public async Task<CreatePrometheusInstanceResponse> CreatePrometheusInstanceWithOptionsAsync(CreatePrometheusInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchiveDuration))
            {
                body["archiveDuration"] = request.ArchiveDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeReadPolicy))
            {
                body["authFreeReadPolicy"] = request.AuthFreeReadPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeWritePolicy))
            {
                body["authFreeWritePolicy"] = request.AuthFreeWritePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeRead))
            {
                body["enableAuthFreeRead"] = request.EnableAuthFreeRead;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeWrite))
            {
                body["enableAuthFreeWrite"] = request.EnableAuthFreeWrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthToken))
            {
                body["enableAuthToken"] = request.EnableAuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["paymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstanceName))
            {
                body["prometheusInstanceName"] = request.PrometheusInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageDuration))
            {
                body["storageDuration"] = request.StorageDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrometheusInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrometheusInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a Prometheus monitoring instance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrometheusInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusInstanceResponse
        /// </returns>
        public CreatePrometheusInstanceResponse CreatePrometheusInstance(CreatePrometheusInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePrometheusInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a Prometheus monitoring instance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrometheusInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusInstanceResponse
        /// </returns>
        public async Task<CreatePrometheusInstanceResponse> CreatePrometheusInstanceAsync(CreatePrometheusInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePrometheusInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Prometheus View</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Used to create a site monitoring task</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePrometheusViewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusViewResponse
        /// </returns>
        public CreatePrometheusViewResponse CreatePrometheusViewWithOptions(CreatePrometheusViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeReadPolicy))
            {
                body["authFreeReadPolicy"] = request.AuthFreeReadPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeRead))
            {
                body["enableAuthFreeRead"] = request.EnableAuthFreeRead;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthToken))
            {
                body["enableAuthToken"] = request.EnableAuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstances))
            {
                body["prometheusInstances"] = request.PrometheusInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusViewName))
            {
                body["prometheusViewName"] = request.PrometheusViewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrometheusView",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-views",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrometheusViewResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Prometheus View</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Used to create a site monitoring task</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePrometheusViewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusViewResponse
        /// </returns>
        public async Task<CreatePrometheusViewResponse> CreatePrometheusViewWithOptionsAsync(CreatePrometheusViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeReadPolicy))
            {
                body["authFreeReadPolicy"] = request.AuthFreeReadPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeRead))
            {
                body["enableAuthFreeRead"] = request.EnableAuthFreeRead;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthToken))
            {
                body["enableAuthToken"] = request.EnableAuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstances))
            {
                body["prometheusInstances"] = request.PrometheusInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusViewName))
            {
                body["prometheusViewName"] = request.PrometheusViewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrometheusView",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-views",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrometheusViewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Prometheus View</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Used to create a site monitoring task</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePrometheusViewRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusViewResponse
        /// </returns>
        public CreatePrometheusViewResponse CreatePrometheusView(CreatePrometheusViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePrometheusViewWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Prometheus View</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Used to create a site monitoring task</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePrometheusViewRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusViewResponse
        /// </returns>
        public async Task<CreatePrometheusViewResponse> CreatePrometheusViewAsync(CreatePrometheusViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePrometheusViewWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Prometheus Monitoring Instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create a Prometheus monitoring virtual instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePrometheusVirtualInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusVirtualInstanceResponse
        /// </returns>
        public CreatePrometheusVirtualInstanceResponse CreatePrometheusVirtualInstanceWithOptions(CreatePrometheusVirtualInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrometheusVirtualInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/virtual-instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrometheusVirtualInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Prometheus Monitoring Instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create a Prometheus monitoring virtual instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePrometheusVirtualInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusVirtualInstanceResponse
        /// </returns>
        public async Task<CreatePrometheusVirtualInstanceResponse> CreatePrometheusVirtualInstanceWithOptionsAsync(CreatePrometheusVirtualInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrometheusVirtualInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/virtual-instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrometheusVirtualInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Prometheus Monitoring Instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create a Prometheus monitoring virtual instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePrometheusVirtualInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusVirtualInstanceResponse
        /// </returns>
        public CreatePrometheusVirtualInstanceResponse CreatePrometheusVirtualInstance(CreatePrometheusVirtualInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePrometheusVirtualInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Prometheus Monitoring Instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create a Prometheus monitoring virtual instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePrometheusVirtualInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusVirtualInstanceResponse
        /// </returns>
        public async Task<CreatePrometheusVirtualInstanceResponse> CreatePrometheusVirtualInstanceAsync(CreatePrometheusVirtualInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePrometheusVirtualInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public CreateServiceResponse CreateServiceWithOptions(string workspace, CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid))
            {
                body["pid"] = request.Pid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                body["serviceStatus"] = request.ServiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                body["serviceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public async Task<CreateServiceResponse> CreateServiceWithOptionsAsync(string workspace, CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid))
            {
                body["pid"] = request.Pid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                body["serviceStatus"] = request.ServiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                body["serviceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public CreateServiceResponse CreateService(string workspace, CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public async Task<CreateServiceResponse> CreateServiceAsync(string workspace, CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Ticket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        public CreateTicketResponse CreateTicketWithOptions(CreateTicketRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenExpirationTime))
            {
                query["accessTokenExpirationTime"] = request.AccessTokenExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationTime))
            {
                query["expirationTime"] = request.ExpirationTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTicket",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/tickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Ticket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        public async Task<CreateTicketResponse> CreateTicketWithOptionsAsync(CreateTicketRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenExpirationTime))
            {
                query["accessTokenExpirationTime"] = request.AccessTokenExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationTime))
            {
                query["expirationTime"] = request.ExpirationTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTicket",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/tickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Ticket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        public CreateTicketResponse CreateTicket(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTicketWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Ticket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        public async Task<CreateTicketResponse> CreateTicketAsync(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTicketWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Umodel configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create Umodel configuration in the specified workspace</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUmodelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUmodelResponse
        /// </returns>
        public CreateUmodelResponse CreateUmodelWithOptions(string workspace, CreateUmodelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUmodelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Umodel configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create Umodel configuration in the specified workspace</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUmodelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUmodelResponse
        /// </returns>
        public async Task<CreateUmodelResponse> CreateUmodelWithOptionsAsync(string workspace, CreateUmodelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUmodelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Umodel configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create Umodel configuration in the specified workspace</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUmodelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUmodelResponse
        /// </returns>
        public CreateUmodelResponse CreateUmodel(string workspace, CreateUmodelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateUmodelWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Umodel configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create Umodel configuration in the specified workspace</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUmodelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUmodelResponse
        /// </returns>
        public async Task<CreateUmodelResponse> CreateUmodelAsync(string workspace, CreateUmodelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateUmodelWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete addon release information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAddonReleaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAddonReleaseResponse
        /// </returns>
        public DeleteAddonReleaseResponse DeleteAddonReleaseWithOptions(string policyId, DeleteAddonReleaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["addonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseName))
            {
                query["releaseName"] = request.ReleaseName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAddonRelease",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/addon-releases",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAddonReleaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete addon release information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAddonReleaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAddonReleaseResponse
        /// </returns>
        public async Task<DeleteAddonReleaseResponse> DeleteAddonReleaseWithOptionsAsync(string policyId, DeleteAddonReleaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["addonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseName))
            {
                query["releaseName"] = request.ReleaseName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAddonRelease",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/addon-releases",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAddonReleaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete addon release information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAddonReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAddonReleaseResponse
        /// </returns>
        public DeleteAddonReleaseResponse DeleteAddonRelease(string policyId, DeleteAddonReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAddonReleaseWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete addon release information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAddonReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAddonReleaseResponse
        /// </returns>
        public async Task<DeleteAddonReleaseResponse> DeleteAddonReleaseAsync(string policyId, DeleteAddonReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAddonReleaseWithOptionsAsync(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Aggregation Task Group</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAggTaskGroupResponse
        /// </returns>
        public DeleteAggTaskGroupResponse DeleteAggTaskGroupWithOptions(string instanceId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAggTaskGroup",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/agg-task-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAggTaskGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Aggregation Task Group</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAggTaskGroupResponse
        /// </returns>
        public async Task<DeleteAggTaskGroupResponse> DeleteAggTaskGroupWithOptionsAsync(string instanceId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAggTaskGroup",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/agg-task-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAggTaskGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Aggregation Task Group</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAggTaskGroupResponse
        /// </returns>
        public DeleteAggTaskGroupResponse DeleteAggTaskGroup(string instanceId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAggTaskGroupWithOptions(instanceId, groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Aggregation Task Group</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAggTaskGroupResponse
        /// </returns>
        public async Task<DeleteAggTaskGroupResponse> DeleteAggTaskGroupAsync(string instanceId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAggTaskGroupWithOptionsAsync(instanceId, groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务链路</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizTraceResponse
        /// </returns>
        public DeleteBizTraceResponse DeleteBizTraceWithOptions(string bizTraceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBizTrace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/bizTrace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizTraceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBizTraceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务链路</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizTraceResponse
        /// </returns>
        public async Task<DeleteBizTraceResponse> DeleteBizTraceWithOptionsAsync(string bizTraceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBizTrace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/bizTrace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizTraceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBizTraceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务链路</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteBizTraceResponse
        /// </returns>
        public DeleteBizTraceResponse DeleteBizTrace(string bizTraceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBizTraceWithOptions(bizTraceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务链路</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteBizTraceResponse
        /// </returns>
        public async Task<DeleteBizTraceResponse> DeleteBizTraceAsync(string bizTraceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBizTraceWithOptionsAsync(bizTraceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除云资源中心</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloudResourceResponse
        /// </returns>
        public DeleteCloudResourceResponse DeleteCloudResourceWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCloudResource",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/cloudresource",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCloudResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除云资源中心</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloudResourceResponse
        /// </returns>
        public async Task<DeleteCloudResourceResponse> DeleteCloudResourceWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCloudResource",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/cloudresource",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCloudResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除云资源中心</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteCloudResourceResponse
        /// </returns>
        public DeleteCloudResourceResponse DeleteCloudResource()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCloudResourceWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除云资源中心</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteCloudResourceResponse
        /// </returns>
        public async Task<DeleteCloudResourceResponse> DeleteCloudResourceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCloudResourceWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete EntityStore related storage</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityStoreResponse
        /// </returns>
        public DeleteEntityStoreResponse DeleteEntityStoreWithOptions(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEntityStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/entitystore",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEntityStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete EntityStore related storage</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityStoreResponse
        /// </returns>
        public async Task<DeleteEntityStoreResponse> DeleteEntityStoreWithOptionsAsync(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEntityStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/entitystore",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEntityStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete EntityStore related storage</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteEntityStoreResponse
        /// </returns>
        public DeleteEntityStoreResponse DeleteEntityStore(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEntityStoreWithOptions(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete EntityStore related storage</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteEntityStoreResponse
        /// </returns>
        public async Task<DeleteEntityStoreResponse> DeleteEntityStoreAsync(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEntityStoreWithOptionsAsync(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Access Center Policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIntegrationPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIntegrationPolicyResponse
        /// </returns>
        public DeleteIntegrationPolicyResponse DeleteIntegrationPolicyWithOptions(string policyId, DeleteIntegrationPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIntegrationPolicy",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIntegrationPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Access Center Policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIntegrationPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIntegrationPolicyResponse
        /// </returns>
        public async Task<DeleteIntegrationPolicyResponse> DeleteIntegrationPolicyWithOptionsAsync(string policyId, DeleteIntegrationPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIntegrationPolicy",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIntegrationPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Access Center Policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIntegrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIntegrationPolicyResponse
        /// </returns>
        public DeleteIntegrationPolicyResponse DeleteIntegrationPolicy(string policyId, DeleteIntegrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIntegrationPolicyWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Access Center Policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIntegrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIntegrationPolicyResponse
        /// </returns>
        public async Task<DeleteIntegrationPolicyResponse> DeleteIntegrationPolicyAsync(string policyId, DeleteIntegrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIntegrationPolicyWithOptionsAsync(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete prom instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a Prometheus instance.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrometheusInstanceResponse
        /// </returns>
        public DeletePrometheusInstanceResponse DeletePrometheusInstanceWithOptions(string prometheusInstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrometheusInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusInstanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrometheusInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete prom instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a Prometheus instance.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrometheusInstanceResponse
        /// </returns>
        public async Task<DeletePrometheusInstanceResponse> DeletePrometheusInstanceWithOptionsAsync(string prometheusInstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrometheusInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusInstanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrometheusInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete prom instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a Prometheus instance.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeletePrometheusInstanceResponse
        /// </returns>
        public DeletePrometheusInstanceResponse DeletePrometheusInstance(string prometheusInstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePrometheusInstanceWithOptions(prometheusInstanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete prom instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a Prometheus instance.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeletePrometheusInstanceResponse
        /// </returns>
        public async Task<DeletePrometheusInstanceResponse> DeletePrometheusInstanceAsync(string prometheusInstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePrometheusInstanceWithOptionsAsync(prometheusInstanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete prometheus view instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete prometheus view instance.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrometheusViewResponse
        /// </returns>
        public DeletePrometheusViewResponse DeletePrometheusViewWithOptions(string prometheusViewId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrometheusView",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-views/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusViewId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrometheusViewResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete prometheus view instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete prometheus view instance.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrometheusViewResponse
        /// </returns>
        public async Task<DeletePrometheusViewResponse> DeletePrometheusViewWithOptionsAsync(string prometheusViewId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrometheusView",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-views/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusViewId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrometheusViewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete prometheus view instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete prometheus view instance.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeletePrometheusViewResponse
        /// </returns>
        public DeletePrometheusViewResponse DeletePrometheusView(string prometheusViewId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePrometheusViewWithOptions(prometheusViewId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete prometheus view instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete prometheus view instance.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeletePrometheusViewResponse
        /// </returns>
        public async Task<DeletePrometheusViewResponse> DeletePrometheusViewAsync(string prometheusViewId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePrometheusViewWithOptionsAsync(prometheusViewId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Service</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public DeleteServiceResponse DeleteServiceWithOptions(string workspace, string serviceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Service</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public async Task<DeleteServiceResponse> DeleteServiceWithOptionsAsync(string workspace, string serviceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Service</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public DeleteServiceResponse DeleteService(string workspace, string serviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceWithOptions(workspace, serviceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Service</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public async Task<DeleteServiceResponse> DeleteServiceAsync(string workspace, string serviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceWithOptionsAsync(workspace, serviceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Umodel configuration information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the Umodel under the specified workspace</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelResponse
        /// </returns>
        public DeleteUmodelResponse DeleteUmodelWithOptions(string workspace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUmodelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Umodel configuration information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the Umodel under the specified workspace</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelResponse
        /// </returns>
        public async Task<DeleteUmodelResponse> DeleteUmodelWithOptionsAsync(string workspace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUmodelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Umodel configuration information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the Umodel under the specified workspace</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteUmodelResponse
        /// </returns>
        public DeleteUmodelResponse DeleteUmodel(string workspace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUmodelWithOptions(workspace, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Umodel configuration information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the Umodel under the specified workspace</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteUmodelResponse
        /// </returns>
        public async Task<DeleteUmodelResponse> DeleteUmodelAsync(string workspace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUmodelWithOptionsAsync(workspace, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUmodelCommonSchemaRefRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelCommonSchemaRefResponse
        /// </returns>
        public DeleteUmodelCommonSchemaRefResponse DeleteUmodelCommonSchemaRefWithOptions(string workspace, DeleteUmodelCommonSchemaRefRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUmodelCommonSchemaRef",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/common-schema-ref",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUmodelCommonSchemaRefResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUmodelCommonSchemaRefRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelCommonSchemaRefResponse
        /// </returns>
        public async Task<DeleteUmodelCommonSchemaRefResponse> DeleteUmodelCommonSchemaRefWithOptionsAsync(string workspace, DeleteUmodelCommonSchemaRefRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUmodelCommonSchemaRef",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/common-schema-ref",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUmodelCommonSchemaRefResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUmodelCommonSchemaRefRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelCommonSchemaRefResponse
        /// </returns>
        public DeleteUmodelCommonSchemaRefResponse DeleteUmodelCommonSchemaRef(string workspace, DeleteUmodelCommonSchemaRefRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUmodelCommonSchemaRefWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUmodelCommonSchemaRefRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelCommonSchemaRefResponse
        /// </returns>
        public async Task<DeleteUmodelCommonSchemaRefResponse> DeleteUmodelCommonSchemaRefAsync(string workspace, DeleteUmodelCommonSchemaRefRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUmodelCommonSchemaRefWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Umodel Elements</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the Umodel Data under a specified workspace</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteUmodelDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelDataResponse
        /// </returns>
        public DeleteUmodelDataResponse DeleteUmodelDataWithOptions(string workspace, DeleteUmodelDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                query["kind"] = request.Kind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUmodelData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/data",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUmodelDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Umodel Elements</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the Umodel Data under a specified workspace</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteUmodelDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelDataResponse
        /// </returns>
        public async Task<DeleteUmodelDataResponse> DeleteUmodelDataWithOptionsAsync(string workspace, DeleteUmodelDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                query["kind"] = request.Kind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUmodelData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/data",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUmodelDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Umodel Elements</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the Umodel Data under a specified workspace</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteUmodelDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelDataResponse
        /// </returns>
        public DeleteUmodelDataResponse DeleteUmodelData(string workspace, DeleteUmodelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUmodelDataWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Umodel Elements</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the Umodel Data under a specified workspace</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteUmodelDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelDataResponse
        /// </returns>
        public async Task<DeleteUmodelDataResponse> DeleteUmodelDataAsync(string workspace, DeleteUmodelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUmodelDataWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Workspace</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspaceWithOptions(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Workspace</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceWithOptionsAsync(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Workspace</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspace(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWorkspaceWithOptions(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Workspace</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWorkspaceWithOptionsAsync(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询地域信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询地域信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询地域信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询地域信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件详情(Addon)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAddonResponse
        /// </returns>
        public GetAddonResponse GetAddonWithOptions(string addonName, GetAddonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAddon",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/addons/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(addonName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddonResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件详情(Addon)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAddonResponse
        /// </returns>
        public async Task<GetAddonResponse> GetAddonWithOptionsAsync(string addonName, GetAddonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAddon",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/addons/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(addonName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddonResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件详情(Addon)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAddonResponse
        /// </returns>
        public GetAddonResponse GetAddon(string addonName, GetAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAddonWithOptions(addonName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件详情(Addon)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAddonResponse
        /// </returns>
        public async Task<GetAddonResponse> GetAddonAsync(string addonName, GetAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAddonWithOptionsAsync(addonName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件schema详情(Addon)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonCodeTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAddonCodeTemplateResponse
        /// </returns>
        public GetAddonCodeTemplateResponse GetAddonCodeTemplateWithOptions(string addonName, GetAddonCodeTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentType))
            {
                query["environmentType"] = request.EnvironmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAddonCodeTemplate",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/addons/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(addonName) + "/alert-code-template",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddonCodeTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件schema详情(Addon)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonCodeTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAddonCodeTemplateResponse
        /// </returns>
        public async Task<GetAddonCodeTemplateResponse> GetAddonCodeTemplateWithOptionsAsync(string addonName, GetAddonCodeTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentType))
            {
                query["environmentType"] = request.EnvironmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAddonCodeTemplate",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/addons/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(addonName) + "/alert-code-template",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddonCodeTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件schema详情(Addon)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonCodeTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAddonCodeTemplateResponse
        /// </returns>
        public GetAddonCodeTemplateResponse GetAddonCodeTemplate(string addonName, GetAddonCodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAddonCodeTemplateWithOptions(addonName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件schema详情(Addon)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonCodeTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAddonCodeTemplateResponse
        /// </returns>
        public async Task<GetAddonCodeTemplateResponse> GetAddonCodeTemplateAsync(string addonName, GetAddonCodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAddonCodeTemplateWithOptionsAsync(addonName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check addon release (view connection status)</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAddonReleaseResponse
        /// </returns>
        public GetAddonReleaseResponse GetAddonReleaseWithOptions(string releaseName, string policyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAddonRelease",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/addon-releases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(releaseName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddonReleaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check addon release (view connection status)</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAddonReleaseResponse
        /// </returns>
        public async Task<GetAddonReleaseResponse> GetAddonReleaseWithOptionsAsync(string releaseName, string policyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAddonRelease",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/addon-releases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(releaseName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddonReleaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check addon release (view connection status)</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAddonReleaseResponse
        /// </returns>
        public GetAddonReleaseResponse GetAddonRelease(string releaseName, string policyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAddonReleaseWithOptions(releaseName, policyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check addon release (view connection status)</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAddonReleaseResponse
        /// </returns>
        public async Task<GetAddonReleaseResponse> GetAddonReleaseAsync(string releaseName, string policyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAddonReleaseWithOptionsAsync(releaseName, policyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件schema详情(Addon)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonSchemaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAddonSchemaResponse
        /// </returns>
        public GetAddonSchemaResponse GetAddonSchemaWithOptions(string addonName, GetAddonSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentType))
            {
                query["environmentType"] = request.EnvironmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAddonSchema",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/addons/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(addonName) + "/schema",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddonSchemaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件schema详情(Addon)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonSchemaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAddonSchemaResponse
        /// </returns>
        public async Task<GetAddonSchemaResponse> GetAddonSchemaWithOptionsAsync(string addonName, GetAddonSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentType))
            {
                query["environmentType"] = request.EnvironmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAddonSchema",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/addons/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(addonName) + "/schema",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddonSchemaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件schema详情(Addon)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAddonSchemaResponse
        /// </returns>
        public GetAddonSchemaResponse GetAddonSchema(string addonName, GetAddonSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAddonSchemaWithOptions(addonName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件schema详情(Addon)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAddonSchemaResponse
        /// </returns>
        public async Task<GetAddonSchemaResponse> GetAddonSchemaAsync(string addonName, GetAddonSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAddonSchemaWithOptionsAsync(addonName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes the aggregation task group</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAggTaskGroupResponse
        /// </returns>
        public GetAggTaskGroupResponse GetAggTaskGroupWithOptions(string instanceId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggTaskGroup",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/agg-task-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggTaskGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes the aggregation task group</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAggTaskGroupResponse
        /// </returns>
        public async Task<GetAggTaskGroupResponse> GetAggTaskGroupWithOptionsAsync(string instanceId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAggTaskGroup",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/agg-task-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAggTaskGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes the aggregation task group</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAggTaskGroupResponse
        /// </returns>
        public GetAggTaskGroupResponse GetAggTaskGroup(string instanceId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAggTaskGroupWithOptions(instanceId, groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes the aggregation task group</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAggTaskGroupResponse
        /// </returns>
        public async Task<GetAggTaskGroupResponse> GetAggTaskGroupAsync(string instanceId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAggTaskGroupWithOptionsAsync(instanceId, groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务链路</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBizTraceResponse
        /// </returns>
        public GetBizTraceResponse GetBizTraceWithOptions(string bizTraceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBizTrace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/bizTrace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizTraceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBizTraceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务链路</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBizTraceResponse
        /// </returns>
        public async Task<GetBizTraceResponse> GetBizTraceWithOptionsAsync(string bizTraceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBizTrace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/bizTrace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizTraceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBizTraceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务链路</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetBizTraceResponse
        /// </returns>
        public GetBizTraceResponse GetBizTrace(string bizTraceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBizTraceWithOptions(bizTraceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务链路</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetBizTraceResponse
        /// </returns>
        public async Task<GetBizTraceResponse> GetBizTraceAsync(string bizTraceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBizTraceWithOptionsAsync(bizTraceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源中心</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCloudResourceResponse
        /// </returns>
        public GetCloudResourceResponse GetCloudResourceWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCloudResource",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/cloudresource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCloudResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源中心</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCloudResourceResponse
        /// </returns>
        public async Task<GetCloudResourceResponse> GetCloudResourceWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCloudResource",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/cloudresource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCloudResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源中心</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCloudResourceResponse
        /// </returns>
        public GetCloudResourceResponse GetCloudResource()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCloudResourceWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源中心</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCloudResourceResponse
        /// </returns>
        public async Task<GetCloudResourceResponse> GetCloudResourceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCloudResourceWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源中心数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCloudResourceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCloudResourceDataResponse
        /// </returns>
        public GetCloudResourceDataResponse GetCloudResourceDataWithOptions(GetCloudResourceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCloudResourceData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/cloudresource/data",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCloudResourceDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源中心数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCloudResourceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCloudResourceDataResponse
        /// </returns>
        public async Task<GetCloudResourceDataResponse> GetCloudResourceDataWithOptionsAsync(GetCloudResourceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCloudResourceData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/cloudresource/data",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCloudResourceDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源中心数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCloudResourceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCloudResourceDataResponse
        /// </returns>
        public GetCloudResourceDataResponse GetCloudResourceData(GetCloudResourceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCloudResourceDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源中心数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCloudResourceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCloudResourceDataResponse
        /// </returns>
        public async Task<GetCloudResourceDataResponse> GetCloudResourceDataAsync(GetCloudResourceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCloudResourceDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取云监控开通状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCmsServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCmsServiceResponse
        /// </returns>
        public GetCmsServiceResponse GetCmsServiceWithOptions(GetCmsServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["service"] = request.Service;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCmsService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/cmsservice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCmsServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取云监控开通状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCmsServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCmsServiceResponse
        /// </returns>
        public async Task<GetCmsServiceResponse> GetCmsServiceWithOptionsAsync(GetCmsServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["service"] = request.Service;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCmsService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/cmsservice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCmsServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取云监控开通状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCmsServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCmsServiceResponse
        /// </returns>
        public GetCmsServiceResponse GetCmsService(GetCmsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCmsServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取云监控开通状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCmsServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCmsServiceResponse
        /// </returns>
        public async Task<GetCmsServiceResponse> GetCmsServiceAsync(GetCmsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCmsServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get EntityStore related storage information</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreResponse
        /// </returns>
        public GetEntityStoreResponse GetEntityStoreWithOptions(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEntityStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/entitystore",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEntityStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get EntityStore related storage information</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreResponse
        /// </returns>
        public async Task<GetEntityStoreResponse> GetEntityStoreWithOptionsAsync(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEntityStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/entitystore",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEntityStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get EntityStore related storage information</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEntityStoreResponse
        /// </returns>
        public GetEntityStoreResponse GetEntityStore(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEntityStoreWithOptions(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get EntityStore related storage information</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEntityStoreResponse
        /// </returns>
        public async Task<GetEntityStoreResponse> GetEntityStoreAsync(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEntityStoreWithOptionsAsync(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the entity and relationship data under a specified Workspace, returning the entity data within a certain time range (the returned result is transmitted after compression).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityStoreDataRequest
        /// </param>
        /// <param name="headers">
        /// GetEntityStoreDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreDataResponse
        /// </returns>
        public GetEntityStoreDataResponse GetEntityStoreDataWithOptions(string workspace, GetEntityStoreDataRequest request, GetEntityStoreDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["to"] = request.To;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AcceptEncoding))
            {
                realHeaders["acceptEncoding"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AcceptEncoding);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEntityStoreData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/entitiesAndRelations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEntityStoreDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the entity and relationship data under a specified Workspace, returning the entity data within a certain time range (the returned result is transmitted after compression).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityStoreDataRequest
        /// </param>
        /// <param name="headers">
        /// GetEntityStoreDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreDataResponse
        /// </returns>
        public async Task<GetEntityStoreDataResponse> GetEntityStoreDataWithOptionsAsync(string workspace, GetEntityStoreDataRequest request, GetEntityStoreDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["to"] = request.To;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AcceptEncoding))
            {
                realHeaders["acceptEncoding"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AcceptEncoding);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEntityStoreData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/entitiesAndRelations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEntityStoreDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the entity and relationship data under a specified Workspace, returning the entity data within a certain time range (the returned result is transmitted after compression).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityStoreDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreDataResponse
        /// </returns>
        public GetEntityStoreDataResponse GetEntityStoreData(string workspace, GetEntityStoreDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEntityStoreDataHeaders headers = new GetEntityStoreDataHeaders();
            return GetEntityStoreDataWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the entity and relationship data under a specified Workspace, returning the entity data within a certain time range (the returned result is transmitted after compression).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityStoreDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreDataResponse
        /// </returns>
        public async Task<GetEntityStoreDataResponse> GetEntityStoreDataAsync(string workspace, GetEntityStoreDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEntityStoreDataHeaders headers = new GetEntityStoreDataHeaders();
            return await GetEntityStoreDataWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of access center policies</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIntegrationPolicyResponse
        /// </returns>
        public GetIntegrationPolicyResponse GetIntegrationPolicyWithOptions(string policyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntegrationPolicy",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntegrationPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of access center policies</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIntegrationPolicyResponse
        /// </returns>
        public async Task<GetIntegrationPolicyResponse> GetIntegrationPolicyWithOptionsAsync(string policyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntegrationPolicy",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntegrationPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of access center policies</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIntegrationPolicyResponse
        /// </returns>
        public GetIntegrationPolicyResponse GetIntegrationPolicy(string policyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIntegrationPolicyWithOptions(policyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of access center policies</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIntegrationPolicyResponse
        /// </returns>
        public async Task<GetIntegrationPolicyResponse> GetIntegrationPolicyAsync(string policyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIntegrationPolicyWithOptionsAsync(policyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询接入中心在CS的版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntegrationVersionForCSRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIntegrationVersionForCSResponse
        /// </returns>
        public GetIntegrationVersionForCSResponse GetIntegrationVersionForCSWithOptions(GetIntegrationVersionForCSRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["clusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["clusterType"] = request.ClusterType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntegrationVersionForCS",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-version/cs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntegrationVersionForCSResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询接入中心在CS的版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntegrationVersionForCSRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIntegrationVersionForCSResponse
        /// </returns>
        public async Task<GetIntegrationVersionForCSResponse> GetIntegrationVersionForCSWithOptionsAsync(GetIntegrationVersionForCSRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["clusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["clusterType"] = request.ClusterType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntegrationVersionForCS",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-version/cs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntegrationVersionForCSResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询接入中心在CS的版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntegrationVersionForCSRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIntegrationVersionForCSResponse
        /// </returns>
        public GetIntegrationVersionForCSResponse GetIntegrationVersionForCS(GetIntegrationVersionForCSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIntegrationVersionForCSWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询接入中心在CS的版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntegrationVersionForCSRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIntegrationVersionForCSResponse
        /// </returns>
        public async Task<GetIntegrationVersionForCSResponse> GetIntegrationVersionForCSAsync(GetIntegrationVersionForCSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIntegrationVersionForCSWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the instance in a specified environment</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve details of a Prometheus instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPrometheusInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrometheusInstanceResponse
        /// </returns>
        public GetPrometheusInstanceResponse GetPrometheusInstanceWithOptions(string prometheusInstanceId, GetPrometheusInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrometheusInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusInstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrometheusInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the instance in a specified environment</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve details of a Prometheus instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPrometheusInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrometheusInstanceResponse
        /// </returns>
        public async Task<GetPrometheusInstanceResponse> GetPrometheusInstanceWithOptionsAsync(string prometheusInstanceId, GetPrometheusInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrometheusInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusInstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrometheusInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the instance in a specified environment</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve details of a Prometheus instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPrometheusInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrometheusInstanceResponse
        /// </returns>
        public GetPrometheusInstanceResponse GetPrometheusInstance(string prometheusInstanceId, GetPrometheusInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPrometheusInstanceWithOptions(prometheusInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the instance in a specified environment</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve details of a Prometheus instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPrometheusInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrometheusInstanceResponse
        /// </returns>
        public async Task<GetPrometheusInstanceResponse> GetPrometheusInstanceAsync(string prometheusInstanceId, GetPrometheusInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPrometheusInstanceWithOptionsAsync(prometheusInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定环境实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrometheusUserSettingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrometheusUserSettingResponse
        /// </returns>
        public GetPrometheusUserSettingResponse GetPrometheusUserSettingWithOptions(GetPrometheusUserSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrometheusUserSetting",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-user-setting",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrometheusUserSettingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定环境实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrometheusUserSettingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrometheusUserSettingResponse
        /// </returns>
        public async Task<GetPrometheusUserSettingResponse> GetPrometheusUserSettingWithOptionsAsync(GetPrometheusUserSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrometheusUserSetting",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-user-setting",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrometheusUserSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定环境实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrometheusUserSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrometheusUserSettingResponse
        /// </returns>
        public GetPrometheusUserSettingResponse GetPrometheusUserSetting(GetPrometheusUserSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPrometheusUserSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定环境实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrometheusUserSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrometheusUserSettingResponse
        /// </returns>
        public async Task<GetPrometheusUserSettingResponse> GetPrometheusUserSettingAsync(GetPrometheusUserSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPrometheusUserSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a specified Prometheus view instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query a specified Prometheus view instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPrometheusViewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrometheusViewResponse
        /// </returns>
        public GetPrometheusViewResponse GetPrometheusViewWithOptions(string prometheusViewId, GetPrometheusViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrometheusView",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-views/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusViewId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrometheusViewResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a specified Prometheus view instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query a specified Prometheus view instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPrometheusViewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrometheusViewResponse
        /// </returns>
        public async Task<GetPrometheusViewResponse> GetPrometheusViewWithOptionsAsync(string prometheusViewId, GetPrometheusViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrometheusView",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-views/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusViewId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrometheusViewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a specified Prometheus view instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query a specified Prometheus view instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPrometheusViewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrometheusViewResponse
        /// </returns>
        public GetPrometheusViewResponse GetPrometheusView(string prometheusViewId, GetPrometheusViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPrometheusViewWithOptions(prometheusViewId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a specified Prometheus view instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query a specified Prometheus view instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPrometheusViewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrometheusViewResponse
        /// </returns>
        public async Task<GetPrometheusViewResponse> GetPrometheusViewAsync(string prometheusViewId, GetPrometheusViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPrometheusViewWithOptionsAsync(prometheusViewId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Service</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceResponse
        /// </returns>
        public GetServiceResponse GetServiceWithOptions(string workspace, string serviceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Service</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceResponse
        /// </returns>
        public async Task<GetServiceResponse> GetServiceWithOptionsAsync(string workspace, string serviceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Service</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceResponse
        /// </returns>
        public GetServiceResponse GetService(string workspace, string serviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceWithOptions(workspace, serviceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Service</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceResponse
        /// </returns>
        public async Task<GetServiceResponse> GetServiceAsync(string workspace, string serviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceWithOptionsAsync(workspace, serviceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Application Observability Instance</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceObservabilityResponse
        /// </returns>
        public GetServiceObservabilityResponse GetServiceObservabilityWithOptions(string workspace, string type, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceObservability",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service-observability/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceObservabilityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Application Observability Instance</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceObservabilityResponse
        /// </returns>
        public async Task<GetServiceObservabilityResponse> GetServiceObservabilityWithOptionsAsync(string workspace, string type, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceObservability",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service-observability/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceObservabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Application Observability Instance</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceObservabilityResponse
        /// </returns>
        public GetServiceObservabilityResponse GetServiceObservability(string workspace, string type)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceObservabilityWithOptions(workspace, type, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Application Observability Instance</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceObservabilityResponse
        /// </returns>
        public async Task<GetServiceObservabilityResponse> GetServiceObservabilityAsync(string workspace, string type)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceObservabilityWithOptionsAsync(workspace, type, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Umodel configuration information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Get Umodel configuration information</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelResponse
        /// </returns>
        public GetUmodelResponse GetUmodelWithOptions(string workspace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUmodelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Umodel configuration information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Get Umodel configuration information</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelResponse
        /// </returns>
        public async Task<GetUmodelResponse> GetUmodelWithOptionsAsync(string workspace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUmodelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Umodel configuration information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Get Umodel configuration information</para>
        /// </description>
        /// 
        /// <returns>
        /// GetUmodelResponse
        /// </returns>
        public GetUmodelResponse GetUmodel(string workspace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUmodelWithOptions(workspace, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Umodel configuration information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Get Umodel configuration information</para>
        /// </description>
        /// 
        /// <returns>
        /// GetUmodelResponse
        /// </returns>
        public async Task<GetUmodelResponse> GetUmodelAsync(string workspace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUmodelWithOptionsAsync(workspace, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelCommonSchemaRefResponse
        /// </returns>
        public GetUmodelCommonSchemaRefResponse GetUmodelCommonSchemaRefWithOptions(string workspace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUmodelCommonSchemaRef",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/common-schema-ref",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUmodelCommonSchemaRefResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelCommonSchemaRefResponse
        /// </returns>
        public async Task<GetUmodelCommonSchemaRefResponse> GetUmodelCommonSchemaRefWithOptionsAsync(string workspace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUmodelCommonSchemaRef",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/common-schema-ref",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUmodelCommonSchemaRefResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Umodel配置信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUmodelCommonSchemaRefResponse
        /// </returns>
        public GetUmodelCommonSchemaRefResponse GetUmodelCommonSchemaRef(string workspace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUmodelCommonSchemaRefWithOptions(workspace, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Umodel配置信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUmodelCommonSchemaRefResponse
        /// </returns>
        public async Task<GetUmodelCommonSchemaRefResponse> GetUmodelCommonSchemaRefAsync(string workspace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUmodelCommonSchemaRefWithOptionsAsync(workspace, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve associated Umodel graph data</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Find Umodel</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUmodelDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelDataResponse
        /// </returns>
        public GetUmodelDataResponse GetUmodelDataWithOptions(string workspace, GetUmodelDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["method"] = request.Method;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUmodelData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/graph",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUmodelDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve associated Umodel graph data</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Find Umodel</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUmodelDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelDataResponse
        /// </returns>
        public async Task<GetUmodelDataResponse> GetUmodelDataWithOptionsAsync(string workspace, GetUmodelDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["method"] = request.Method;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUmodelData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/graph",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUmodelDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve associated Umodel graph data</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Find Umodel</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUmodelDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelDataResponse
        /// </returns>
        public GetUmodelDataResponse GetUmodelData(string workspace, GetUmodelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUmodelDataWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve associated Umodel graph data</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Find Umodel</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUmodelDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelDataResponse
        /// </returns>
        public async Task<GetUmodelDataResponse> GetUmodelDataAsync(string workspace, GetUmodelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUmodelDataWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Workspace</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspaceWithOptions(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Workspace</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Workspace</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspace(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkspaceWithOptions(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Workspace</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkspaceWithOptionsAsync(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List of addon releases</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the list of access configurations</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAddonReleasesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAddonReleasesResponse
        /// </returns>
        public ListAddonReleasesResponse ListAddonReleasesWithOptions(string policyId, ListAddonReleasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["addonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentAddonReleaseId))
            {
                query["parentAddonReleaseId"] = request.ParentAddonReleaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddonReleases",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/addon-releases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddonReleasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List of addon releases</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the list of access configurations</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAddonReleasesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAddonReleasesResponse
        /// </returns>
        public async Task<ListAddonReleasesResponse> ListAddonReleasesWithOptionsAsync(string policyId, ListAddonReleasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["addonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentAddonReleaseId))
            {
                query["parentAddonReleaseId"] = request.ParentAddonReleaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddonReleases",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/addon-releases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddonReleasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List of addon releases</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the list of access configurations</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAddonReleasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAddonReleasesResponse
        /// </returns>
        public ListAddonReleasesResponse ListAddonReleases(string policyId, ListAddonReleasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAddonReleasesWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List of addon releases</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the list of access configurations</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAddonReleasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAddonReleasesResponse
        /// </returns>
        public async Task<ListAddonReleasesResponse> ListAddonReleasesAsync(string policyId, ListAddonReleasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAddonReleasesWithOptionsAsync(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新版接入中心产品列表(分组)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddonsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAddonsResponse
        /// </returns>
        public ListAddonsResponse ListAddonsWithOptions(ListAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regexp))
            {
                query["regexp"] = request.Regexp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["search"] = request.Search;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddons",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/addons",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddonsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新版接入中心产品列表(分组)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddonsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAddonsResponse
        /// </returns>
        public async Task<ListAddonsResponse> ListAddonsWithOptionsAsync(ListAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regexp))
            {
                query["regexp"] = request.Regexp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["search"] = request.Search;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddons",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/addons",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddonsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新版接入中心产品列表(分组)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddonsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAddonsResponse
        /// </returns>
        public ListAddonsResponse ListAddons(ListAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAddonsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新版接入中心产品列表(分组)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddonsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAddonsResponse
        /// </returns>
        public async Task<ListAddonsResponse> ListAddonsAsync(ListAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAddonsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Aggregation Task Groups</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAggTaskGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAggTaskGroupsResponse
        /// </returns>
        public ListAggTaskGroupsResponse ListAggTaskGroupsWithOptions(string instanceId, ListAggTaskGroupsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAggTaskGroupsShrinkRequest request = new ListAggTaskGroupsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterAggTaskGroupIds))
            {
                query["filterAggTaskGroupIds"] = request.FilterAggTaskGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterAggTaskGroupNames))
            {
                query["filterAggTaskGroupNames"] = request.FilterAggTaskGroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPrometheusId))
            {
                query["targetPrometheusId"] = request.TargetPrometheusId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggTaskGroups",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/agg-task-groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggTaskGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Aggregation Task Groups</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAggTaskGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAggTaskGroupsResponse
        /// </returns>
        public async Task<ListAggTaskGroupsResponse> ListAggTaskGroupsWithOptionsAsync(string instanceId, ListAggTaskGroupsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAggTaskGroupsShrinkRequest request = new ListAggTaskGroupsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterAggTaskGroupIds))
            {
                query["filterAggTaskGroupIds"] = request.FilterAggTaskGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterAggTaskGroupNames))
            {
                query["filterAggTaskGroupNames"] = request.FilterAggTaskGroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPrometheusId))
            {
                query["targetPrometheusId"] = request.TargetPrometheusId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAggTaskGroups",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/agg-task-groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAggTaskGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Aggregation Task Groups</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAggTaskGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAggTaskGroupsResponse
        /// </returns>
        public ListAggTaskGroupsResponse ListAggTaskGroups(string instanceId, ListAggTaskGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAggTaskGroupsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Aggregation Task Groups</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAggTaskGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAggTaskGroupsResponse
        /// </returns>
        public async Task<ListAggTaskGroupsResponse> ListAggTaskGroupsAsync(string instanceId, ListAggTaskGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAggTaskGroupsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Alert Actions</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlertActionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertActionsResponse
        /// </returns>
        public ListAlertActionsResponse ListAlertActionsWithOptions(ListAlertActionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlertActionsShrinkRequest request = new ListAlertActionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlertActionIds))
            {
                request.AlertActionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlertActionIds, "alertActionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertActionIdsShrink))
            {
                query["alertActionIds"] = request.AlertActionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertActionName))
            {
                query["alertActionName"] = request.AlertActionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlertActions",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/alertActions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertActionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Alert Actions</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlertActionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertActionsResponse
        /// </returns>
        public async Task<ListAlertActionsResponse> ListAlertActionsWithOptionsAsync(ListAlertActionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlertActionsShrinkRequest request = new ListAlertActionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlertActionIds))
            {
                request.AlertActionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlertActionIds, "alertActionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertActionIdsShrink))
            {
                query["alertActionIds"] = request.AlertActionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertActionName))
            {
                query["alertActionName"] = request.AlertActionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlertActions",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/alertActions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertActionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Alert Actions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertActionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertActionsResponse
        /// </returns>
        public ListAlertActionsResponse ListAlertActions(ListAlertActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAlertActionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Alert Actions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertActionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertActionsResponse
        /// </returns>
        public async Task<ListAlertActionsResponse> ListAlertActionsAsync(ListAlertActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAlertActionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>业务链路列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBizTracesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBizTracesResponse
        /// </returns>
        public ListBizTracesResponse ListBizTracesWithOptions(ListBizTracesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBizTraces",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/bizTraces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBizTracesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>业务链路列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBizTracesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBizTracesResponse
        /// </returns>
        public async Task<ListBizTracesResponse> ListBizTracesWithOptionsAsync(ListBizTracesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBizTraces",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/bizTraces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBizTracesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>业务链路列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBizTracesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBizTracesResponse
        /// </returns>
        public ListBizTracesResponse ListBizTraces(ListBizTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListBizTracesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>业务链路列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBizTracesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBizTracesResponse
        /// </returns>
        public async Task<ListBizTracesResponse> ListBizTracesAsync(ListBizTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListBizTracesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Access Center Policy List Information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query integration list</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListIntegrationPoliciesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPoliciesResponse
        /// </returns>
        public ListIntegrationPoliciesResponse ListIntegrationPoliciesWithOptions(ListIntegrationPoliciesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListIntegrationPoliciesShrinkRequest request = new ListIntegrationPoliciesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["addonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindResourceId))
            {
                query["bindResourceId"] = request.BindResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityGroupIds))
            {
                query["entityGroupIds"] = request.EntityGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterRegionIds))
            {
                query["filterRegionIds"] = request.FilterRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["policyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["policyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["policyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstanceId))
            {
                query["prometheusInstanceId"] = request.PrometheusInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicies",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Access Center Policy List Information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query integration list</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListIntegrationPoliciesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPoliciesResponse
        /// </returns>
        public async Task<ListIntegrationPoliciesResponse> ListIntegrationPoliciesWithOptionsAsync(ListIntegrationPoliciesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListIntegrationPoliciesShrinkRequest request = new ListIntegrationPoliciesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["addonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindResourceId))
            {
                query["bindResourceId"] = request.BindResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityGroupIds))
            {
                query["entityGroupIds"] = request.EntityGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterRegionIds))
            {
                query["filterRegionIds"] = request.FilterRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["policyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["policyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["policyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstanceId))
            {
                query["prometheusInstanceId"] = request.PrometheusInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicies",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Access Center Policy List Information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query integration list</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPoliciesResponse
        /// </returns>
        public ListIntegrationPoliciesResponse ListIntegrationPolicies(ListIntegrationPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIntegrationPoliciesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Access Center Policy List Information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query integration list</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPoliciesResponse
        /// </returns>
        public async Task<ListIntegrationPoliciesResponse> ListIntegrationPoliciesAsync(ListIntegrationPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIntegrationPoliciesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>策略addon列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyAddonsResponse
        /// </returns>
        public ListIntegrationPolicyAddonsResponse ListIntegrationPolicyAddonsWithOptions(string policyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyAddons",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/addons",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyAddonsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>策略addon列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyAddonsResponse
        /// </returns>
        public async Task<ListIntegrationPolicyAddonsResponse> ListIntegrationPolicyAddonsWithOptionsAsync(string policyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyAddons",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/addons",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyAddonsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>策略addon列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListIntegrationPolicyAddonsResponse
        /// </returns>
        public ListIntegrationPolicyAddonsResponse ListIntegrationPolicyAddons(string policyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIntegrationPolicyAddonsWithOptions(policyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>策略addon列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListIntegrationPolicyAddonsResponse
        /// </returns>
        public async Task<ListIntegrationPolicyAddonsResponse> ListIntegrationPolicyAddonsAsync(string policyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIntegrationPolicyAddonsWithOptionsAsync(policyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接入中心策略的存储要求信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyCollectorsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyCollectorsResponse
        /// </returns>
        public ListIntegrationPolicyCollectorsResponse ListIntegrationPolicyCollectorsWithOptions(string policyId, ListIntegrationPolicyCollectorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonReleaseName))
            {
                query["addonReleaseName"] = request.AddonReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectorType))
            {
                query["collectorType"] = request.CollectorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyCollectors",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/collectors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyCollectorsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接入中心策略的存储要求信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyCollectorsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyCollectorsResponse
        /// </returns>
        public async Task<ListIntegrationPolicyCollectorsResponse> ListIntegrationPolicyCollectorsWithOptionsAsync(string policyId, ListIntegrationPolicyCollectorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonReleaseName))
            {
                query["addonReleaseName"] = request.AddonReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectorType))
            {
                query["collectorType"] = request.CollectorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyCollectors",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/collectors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyCollectorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接入中心策略的存储要求信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyCollectorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyCollectorsResponse
        /// </returns>
        public ListIntegrationPolicyCollectorsResponse ListIntegrationPolicyCollectors(string policyId, ListIntegrationPolicyCollectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIntegrationPolicyCollectorsWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接入中心策略的存储要求信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyCollectorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyCollectorsResponse
        /// </returns>
        public async Task<ListIntegrationPolicyCollectorsResponse> ListIntegrationPolicyCollectorsAsync(string policyId, ListIntegrationPolicyCollectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIntegrationPolicyCollectorsWithOptionsAsync(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get storage requirement information for the access center policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyCustomScrapeJobRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyCustomScrapeJobRulesResponse
        /// </returns>
        public ListIntegrationPolicyCustomScrapeJobRulesResponse ListIntegrationPolicyCustomScrapeJobRulesWithOptions(string policyId, ListIntegrationPolicyCustomScrapeJobRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonReleaseName))
            {
                query["addonReleaseName"] = request.AddonReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptYaml))
            {
                query["encryptYaml"] = request.EncryptYaml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyCustomScrapeJobRules",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/custom-scrape-job-rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyCustomScrapeJobRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get storage requirement information for the access center policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyCustomScrapeJobRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyCustomScrapeJobRulesResponse
        /// </returns>
        public async Task<ListIntegrationPolicyCustomScrapeJobRulesResponse> ListIntegrationPolicyCustomScrapeJobRulesWithOptionsAsync(string policyId, ListIntegrationPolicyCustomScrapeJobRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonReleaseName))
            {
                query["addonReleaseName"] = request.AddonReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptYaml))
            {
                query["encryptYaml"] = request.EncryptYaml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyCustomScrapeJobRules",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/custom-scrape-job-rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyCustomScrapeJobRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get storage requirement information for the access center policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyCustomScrapeJobRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyCustomScrapeJobRulesResponse
        /// </returns>
        public ListIntegrationPolicyCustomScrapeJobRulesResponse ListIntegrationPolicyCustomScrapeJobRules(string policyId, ListIntegrationPolicyCustomScrapeJobRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIntegrationPolicyCustomScrapeJobRulesWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get storage requirement information for the access center policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyCustomScrapeJobRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyCustomScrapeJobRulesResponse
        /// </returns>
        public async Task<ListIntegrationPolicyCustomScrapeJobRulesResponse> ListIntegrationPolicyCustomScrapeJobRulesAsync(string policyId, ListIntegrationPolicyCustomScrapeJobRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIntegrationPolicyCustomScrapeJobRulesWithOptionsAsync(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Policy Dashboard List</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This article provides an example of querying the alarm template list. The result shows that there are 2 alarm templates in the list, which are <c>ECS_Template1</c> and <c>ECS_Template2</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyDashboardsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyDashboardsResponse
        /// </returns>
        public ListIntegrationPolicyDashboardsResponse ListIntegrationPolicyDashboardsWithOptions(string policyId, ListIntegrationPolicyDashboardsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["addonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyDashboards",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/dashboards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyDashboardsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Policy Dashboard List</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This article provides an example of querying the alarm template list. The result shows that there are 2 alarm templates in the list, which are <c>ECS_Template1</c> and <c>ECS_Template2</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyDashboardsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyDashboardsResponse
        /// </returns>
        public async Task<ListIntegrationPolicyDashboardsResponse> ListIntegrationPolicyDashboardsWithOptionsAsync(string policyId, ListIntegrationPolicyDashboardsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["addonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyDashboards",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/dashboards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyDashboardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Policy Dashboard List</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This article provides an example of querying the alarm template list. The result shows that there are 2 alarm templates in the list, which are <c>ECS_Template1</c> and <c>ECS_Template2</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyDashboardsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyDashboardsResponse
        /// </returns>
        public ListIntegrationPolicyDashboardsResponse ListIntegrationPolicyDashboards(string policyId, ListIntegrationPolicyDashboardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIntegrationPolicyDashboardsWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Policy Dashboard List</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This article provides an example of querying the alarm template list. The result shows that there are 2 alarm templates in the list, which are <c>ECS_Template1</c> and <c>ECS_Template2</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyDashboardsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyDashboardsResponse
        /// </returns>
        public async Task<ListIntegrationPolicyDashboardsResponse> ListIntegrationPolicyDashboardsAsync(string policyId, ListIntegrationPolicyDashboardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIntegrationPolicyDashboardsWithOptionsAsync(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get PodMonitor Resources of Access Center Policy</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This article provides an example to query the alarm template list. The result shows that there are 2 alarm templates in the alarm template list, which are <c>ECS_Template1</c> and <c>ECS_Template2</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyPodMonitorsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyPodMonitorsResponse
        /// </returns>
        public ListIntegrationPolicyPodMonitorsResponse ListIntegrationPolicyPodMonitorsWithOptions(string policyId, ListIntegrationPolicyPodMonitorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonReleaseName))
            {
                query["addonReleaseName"] = request.AddonReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptYaml))
            {
                query["encryptYaml"] = request.EncryptYaml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyPodMonitors",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/pod-monitors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyPodMonitorsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get PodMonitor Resources of Access Center Policy</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This article provides an example to query the alarm template list. The result shows that there are 2 alarm templates in the alarm template list, which are <c>ECS_Template1</c> and <c>ECS_Template2</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyPodMonitorsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyPodMonitorsResponse
        /// </returns>
        public async Task<ListIntegrationPolicyPodMonitorsResponse> ListIntegrationPolicyPodMonitorsWithOptionsAsync(string policyId, ListIntegrationPolicyPodMonitorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonReleaseName))
            {
                query["addonReleaseName"] = request.AddonReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptYaml))
            {
                query["encryptYaml"] = request.EncryptYaml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyPodMonitors",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/pod-monitors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyPodMonitorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get PodMonitor Resources of Access Center Policy</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This article provides an example to query the alarm template list. The result shows that there are 2 alarm templates in the alarm template list, which are <c>ECS_Template1</c> and <c>ECS_Template2</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyPodMonitorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyPodMonitorsResponse
        /// </returns>
        public ListIntegrationPolicyPodMonitorsResponse ListIntegrationPolicyPodMonitors(string policyId, ListIntegrationPolicyPodMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIntegrationPolicyPodMonitorsWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get PodMonitor Resources of Access Center Policy</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This article provides an example to query the alarm template list. The result shows that there are 2 alarm templates in the alarm template list, which are <c>ECS_Template1</c> and <c>ECS_Template2</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyPodMonitorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyPodMonitorsResponse
        /// </returns>
        public async Task<ListIntegrationPolicyPodMonitorsResponse> ListIntegrationPolicyPodMonitorsAsync(string policyId, ListIntegrationPolicyPodMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIntegrationPolicyPodMonitorsWithOptionsAsync(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接入中心策略的存储要求信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyServiceMonitorsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyServiceMonitorsResponse
        /// </returns>
        public ListIntegrationPolicyServiceMonitorsResponse ListIntegrationPolicyServiceMonitorsWithOptions(string policyId, ListIntegrationPolicyServiceMonitorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonReleaseName))
            {
                query["addonReleaseName"] = request.AddonReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptYaml))
            {
                query["encryptYaml"] = request.EncryptYaml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyServiceMonitors",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/service-monitors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyServiceMonitorsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接入中心策略的存储要求信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyServiceMonitorsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyServiceMonitorsResponse
        /// </returns>
        public async Task<ListIntegrationPolicyServiceMonitorsResponse> ListIntegrationPolicyServiceMonitorsWithOptionsAsync(string policyId, ListIntegrationPolicyServiceMonitorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonReleaseName))
            {
                query["addonReleaseName"] = request.AddonReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptYaml))
            {
                query["encryptYaml"] = request.EncryptYaml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyServiceMonitors",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/service-monitors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyServiceMonitorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接入中心策略的存储要求信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyServiceMonitorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyServiceMonitorsResponse
        /// </returns>
        public ListIntegrationPolicyServiceMonitorsResponse ListIntegrationPolicyServiceMonitors(string policyId, ListIntegrationPolicyServiceMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIntegrationPolicyServiceMonitorsWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接入中心策略的存储要求信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyServiceMonitorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyServiceMonitorsResponse
        /// </returns>
        public async Task<ListIntegrationPolicyServiceMonitorsResponse> ListIntegrationPolicyServiceMonitorsAsync(string policyId, ListIntegrationPolicyServiceMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIntegrationPolicyServiceMonitorsWithOptionsAsync(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Storage Requirements Information for Access Center Policy</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During the effective period of the policy, all alarms within the application group will no longer send notifications.</para>
        /// <para>This article provides an example of creating a pause alarm notification policy <c>PauseNotify</c> for the application group <c>7301****</c>. This application group will pause alarms from <c>1622949300000</c> to <c>1623208500000</c> (Beijing Time <c>2021-06-06 11:15:00</c> to <c>2021-06-09 11:15:00</c>).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyStorageRequirementsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyStorageRequirementsResponse
        /// </returns>
        public ListIntegrationPolicyStorageRequirementsResponse ListIntegrationPolicyStorageRequirementsWithOptions(string policyId, ListIntegrationPolicyStorageRequirementsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["addonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonReleaseName))
            {
                query["addonReleaseName"] = request.AddonReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["storageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyStorageRequirements",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/storage-requirements",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyStorageRequirementsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Storage Requirements Information for Access Center Policy</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During the effective period of the policy, all alarms within the application group will no longer send notifications.</para>
        /// <para>This article provides an example of creating a pause alarm notification policy <c>PauseNotify</c> for the application group <c>7301****</c>. This application group will pause alarms from <c>1622949300000</c> to <c>1623208500000</c> (Beijing Time <c>2021-06-06 11:15:00</c> to <c>2021-06-09 11:15:00</c>).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyStorageRequirementsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyStorageRequirementsResponse
        /// </returns>
        public async Task<ListIntegrationPolicyStorageRequirementsResponse> ListIntegrationPolicyStorageRequirementsWithOptionsAsync(string policyId, ListIntegrationPolicyStorageRequirementsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["addonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonReleaseName))
            {
                query["addonReleaseName"] = request.AddonReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["storageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntegrationPolicyStorageRequirements",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/storage-requirements",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntegrationPolicyStorageRequirementsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Storage Requirements Information for Access Center Policy</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During the effective period of the policy, all alarms within the application group will no longer send notifications.</para>
        /// <para>This article provides an example of creating a pause alarm notification policy <c>PauseNotify</c> for the application group <c>7301****</c>. This application group will pause alarms from <c>1622949300000</c> to <c>1623208500000</c> (Beijing Time <c>2021-06-06 11:15:00</c> to <c>2021-06-09 11:15:00</c>).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyStorageRequirementsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyStorageRequirementsResponse
        /// </returns>
        public ListIntegrationPolicyStorageRequirementsResponse ListIntegrationPolicyStorageRequirements(string policyId, ListIntegrationPolicyStorageRequirementsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIntegrationPolicyStorageRequirementsWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Storage Requirements Information for Access Center Policy</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During the effective period of the policy, all alarms within the application group will no longer send notifications.</para>
        /// <para>This article provides an example of creating a pause alarm notification policy <c>PauseNotify</c> for the application group <c>7301****</c>. This application group will pause alarms from <c>1622949300000</c> to <c>1623208500000</c> (Beijing Time <c>2021-06-06 11:15:00</c> to <c>2021-06-09 11:15:00</c>).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyStorageRequirementsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyStorageRequirementsResponse
        /// </returns>
        public async Task<ListIntegrationPolicyStorageRequirementsResponse> ListIntegrationPolicyStorageRequirementsAsync(string policyId, ListIntegrationPolicyStorageRequirementsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIntegrationPolicyStorageRequirementsWithOptionsAsync(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Prometheus Instance Dashboard List</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Get the list of Prometheus instance dashboards.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPrometheusDashboardsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusDashboardsResponse
        /// </returns>
        public ListPrometheusDashboardsResponse ListPrometheusDashboardsWithOptions(string prometheusInstanceId, ListPrometheusDashboardsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrometheusDashboards",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusInstanceId) + "/dashboards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrometheusDashboardsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Prometheus Instance Dashboard List</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Get the list of Prometheus instance dashboards.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPrometheusDashboardsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusDashboardsResponse
        /// </returns>
        public async Task<ListPrometheusDashboardsResponse> ListPrometheusDashboardsWithOptionsAsync(string prometheusInstanceId, ListPrometheusDashboardsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["aliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrometheusDashboards",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusInstanceId) + "/dashboards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrometheusDashboardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Prometheus Instance Dashboard List</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Get the list of Prometheus instance dashboards.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPrometheusDashboardsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusDashboardsResponse
        /// </returns>
        public ListPrometheusDashboardsResponse ListPrometheusDashboards(string prometheusInstanceId, ListPrometheusDashboardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPrometheusDashboardsWithOptions(prometheusInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Prometheus Instance Dashboard List</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Get the list of Prometheus instance dashboards.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPrometheusDashboardsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusDashboardsResponse
        /// </returns>
        public async Task<ListPrometheusDashboardsResponse> ListPrometheusDashboardsAsync(string prometheusInstanceId, ListPrometheusDashboardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPrometheusDashboardsWithOptionsAsync(prometheusInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the list of Prometheus instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Get the list of Prometheus instances.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListPrometheusInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusInstancesResponse
        /// </returns>
        public ListPrometheusInstancesResponse ListPrometheusInstancesWithOptions(ListPrometheusInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPrometheusInstancesShrinkRequest request = new ListPrometheusInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterRegionIds))
            {
                query["filterRegionIds"] = request.FilterRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstanceIds))
            {
                query["prometheusInstanceIds"] = request.PrometheusInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstanceName))
            {
                query["prometheusInstanceName"] = request.PrometheusInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrometheusInstances",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrometheusInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the list of Prometheus instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Get the list of Prometheus instances.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListPrometheusInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusInstancesResponse
        /// </returns>
        public async Task<ListPrometheusInstancesResponse> ListPrometheusInstancesWithOptionsAsync(ListPrometheusInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPrometheusInstancesShrinkRequest request = new ListPrometheusInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterRegionIds))
            {
                query["filterRegionIds"] = request.FilterRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstanceIds))
            {
                query["prometheusInstanceIds"] = request.PrometheusInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstanceName))
            {
                query["prometheusInstanceName"] = request.PrometheusInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrometheusInstances",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrometheusInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the list of Prometheus instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Get the list of Prometheus instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPrometheusInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusInstancesResponse
        /// </returns>
        public ListPrometheusInstancesResponse ListPrometheusInstances(ListPrometheusInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPrometheusInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the list of Prometheus instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Get the list of Prometheus instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPrometheusInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusInstancesResponse
        /// </returns>
        public async Task<ListPrometheusInstancesResponse> ListPrometheusInstancesAsync(ListPrometheusInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPrometheusInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve a list of Prometheus view instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve a list of Prometheus view instance information.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListPrometheusViewsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusViewsResponse
        /// </returns>
        public ListPrometheusViewsResponse ListPrometheusViewsWithOptions(ListPrometheusViewsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPrometheusViewsShrinkRequest request = new ListPrometheusViewsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterRegionIds))
            {
                query["filterRegionIds"] = request.FilterRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusViewIds))
            {
                query["prometheusViewIds"] = request.PrometheusViewIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusViewName))
            {
                query["prometheusViewName"] = request.PrometheusViewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrometheusViews",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-views",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrometheusViewsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve a list of Prometheus view instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve a list of Prometheus view instance information.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListPrometheusViewsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusViewsResponse
        /// </returns>
        public async Task<ListPrometheusViewsResponse> ListPrometheusViewsWithOptionsAsync(ListPrometheusViewsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPrometheusViewsShrinkRequest request = new ListPrometheusViewsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterRegionIds))
            {
                query["filterRegionIds"] = request.FilterRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusViewIds))
            {
                query["prometheusViewIds"] = request.PrometheusViewIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusViewName))
            {
                query["prometheusViewName"] = request.PrometheusViewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrometheusViews",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-views",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrometheusViewsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve a list of Prometheus view instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve a list of Prometheus view instance information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPrometheusViewsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusViewsResponse
        /// </returns>
        public ListPrometheusViewsResponse ListPrometheusViews(ListPrometheusViewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPrometheusViewsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve a list of Prometheus view instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve a list of Prometheus view instance information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPrometheusViewsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusViewsResponse
        /// </returns>
        public async Task<ListPrometheusViewsResponse> ListPrometheusViewsAsync(ListPrometheusViewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPrometheusViewsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Prometheus Virtual Instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Used for creating a site monitoring task</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPrometheusVirtualInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusVirtualInstancesResponse
        /// </returns>
        public ListPrometheusVirtualInstancesResponse ListPrometheusVirtualInstancesWithOptions(ListPrometheusVirtualInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrometheusVirtualInstances",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/virtual-instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrometheusVirtualInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Prometheus Virtual Instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Used for creating a site monitoring task</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPrometheusVirtualInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusVirtualInstancesResponse
        /// </returns>
        public async Task<ListPrometheusVirtualInstancesResponse> ListPrometheusVirtualInstancesWithOptionsAsync(ListPrometheusVirtualInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrometheusVirtualInstances",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/virtual-instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrometheusVirtualInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Prometheus Virtual Instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Used for creating a site monitoring task</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPrometheusVirtualInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusVirtualInstancesResponse
        /// </returns>
        public ListPrometheusVirtualInstancesResponse ListPrometheusVirtualInstances(ListPrometheusVirtualInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPrometheusVirtualInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Prometheus Virtual Instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Used for creating a site monitoring task</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPrometheusVirtualInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrometheusVirtualInstancesResponse
        /// </returns>
        public async Task<ListPrometheusVirtualInstancesResponse> ListPrometheusVirtualInstancesAsync(ListPrometheusVirtualInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPrometheusVirtualInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Resource Services</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public ListServicesResponse ListServicesWithOptions(string workspace, ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Resource Services</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(string workspace, ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Resource Services</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public ListServicesResponse ListServices(string workspace, ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServicesWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Resource Services</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public async Task<ListServicesResponse> ListServicesAsync(string workspace, ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServicesWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Workspace List</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspacesWithOptions(ListWorkspacesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkspacesShrinkRequest request = new ListWorkspacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WorkspaceNameList))
            {
                request.WorkspaceNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WorkspaceNameList, "workspaceNameList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["workspaceName"] = request.WorkspaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceNameListShrink))
            {
                query["workspaceNameList"] = request.WorkspaceNameListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Workspace List</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesWithOptionsAsync(ListWorkspacesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkspacesShrinkRequest request = new ListWorkspacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WorkspaceNameList))
            {
                request.WorkspaceNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WorkspaceNameList, "workspaceNameList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["workspaceName"] = request.WorkspaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceNameListShrink))
            {
                query["workspaceNameList"] = request.WorkspaceNameListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Workspace List</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkspacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Workspace List</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Workspace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutWorkspaceResponse
        /// </returns>
        public PutWorkspaceResponse PutWorkspaceWithOptions(string workspaceName, PutWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                body["slsProject"] = request.SlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutWorkspace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Workspace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutWorkspaceResponse
        /// </returns>
        public async Task<PutWorkspaceResponse> PutWorkspaceWithOptionsAsync(string workspaceName, PutWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                body["slsProject"] = request.SlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutWorkspace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Workspace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// PutWorkspaceResponse
        /// </returns>
        public PutWorkspaceResponse PutWorkspace(string workspaceName, PutWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutWorkspaceWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Workspace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// PutWorkspaceResponse
        /// </returns>
        public async Task<PutWorkspaceResponse> PutWorkspaceAsync(string workspaceName, PutWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutWorkspaceWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrade Access Component</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAddonReleaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAddonReleaseResponse
        /// </returns>
        public UpdateAddonReleaseResponse UpdateAddonReleaseWithOptions(string releaseName, string policyId, UpdateAddonReleaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonVersion))
            {
                body["addonVersion"] = request.AddonVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityRules))
            {
                body["entityRules"] = request.EntityRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Values))
            {
                body["values"] = request.Values;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAddonRelease",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/addon-releases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(releaseName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAddonReleaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrade Access Component</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAddonReleaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAddonReleaseResponse
        /// </returns>
        public async Task<UpdateAddonReleaseResponse> UpdateAddonReleaseWithOptionsAsync(string releaseName, string policyId, UpdateAddonReleaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonVersion))
            {
                body["addonVersion"] = request.AddonVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityRules))
            {
                body["entityRules"] = request.EntityRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Values))
            {
                body["values"] = request.Values;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAddonRelease",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId) + "/addon-releases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(releaseName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAddonReleaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrade Access Component</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAddonReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAddonReleaseResponse
        /// </returns>
        public UpdateAddonReleaseResponse UpdateAddonRelease(string releaseName, string policyId, UpdateAddonReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAddonReleaseWithOptions(releaseName, policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrade Access Component</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAddonReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAddonReleaseResponse
        /// </returns>
        public async Task<UpdateAddonReleaseResponse> UpdateAddonReleaseAsync(string releaseName, string policyId, UpdateAddonReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAddonReleaseWithOptionsAsync(releaseName, policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Apply Aggregation Task Group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAggTaskGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAggTaskGroupResponse
        /// </returns>
        public UpdateAggTaskGroupResponse UpdateAggTaskGroupWithOptions(string instanceId, string groupId, UpdateAggTaskGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggTaskGroupConfig))
            {
                body["aggTaskGroupConfig"] = request.AggTaskGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggTaskGroupConfigType))
            {
                body["aggTaskGroupConfigType"] = request.AggTaskGroupConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggTaskGroupName))
            {
                body["aggTaskGroupName"] = request.AggTaskGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpr))
            {
                body["cronExpr"] = request.CronExpr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delay))
            {
                body["delay"] = request.Delay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                body["fromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRetries))
            {
                body["maxRetries"] = request.MaxRetries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRunTimeInSeconds))
            {
                body["maxRunTimeInSeconds"] = request.MaxRunTimeInSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrecheckString))
            {
                body["precheckString"] = request.PrecheckString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMode))
            {
                body["scheduleMode"] = request.ScheduleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTimeExpr))
            {
                body["scheduleTimeExpr"] = request.ScheduleTimeExpr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPrometheusId))
            {
                body["targetPrometheusId"] = request.TargetPrometheusId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                body["toTime"] = request.ToTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAggTaskGroup",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/agg-task-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggTaskGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Apply Aggregation Task Group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAggTaskGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAggTaskGroupResponse
        /// </returns>
        public async Task<UpdateAggTaskGroupResponse> UpdateAggTaskGroupWithOptionsAsync(string instanceId, string groupId, UpdateAggTaskGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggTaskGroupConfig))
            {
                body["aggTaskGroupConfig"] = request.AggTaskGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggTaskGroupConfigType))
            {
                body["aggTaskGroupConfigType"] = request.AggTaskGroupConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggTaskGroupName))
            {
                body["aggTaskGroupName"] = request.AggTaskGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpr))
            {
                body["cronExpr"] = request.CronExpr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delay))
            {
                body["delay"] = request.Delay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                body["fromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRetries))
            {
                body["maxRetries"] = request.MaxRetries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRunTimeInSeconds))
            {
                body["maxRunTimeInSeconds"] = request.MaxRunTimeInSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrecheckString))
            {
                body["precheckString"] = request.PrecheckString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMode))
            {
                body["scheduleMode"] = request.ScheduleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTimeExpr))
            {
                body["scheduleTimeExpr"] = request.ScheduleTimeExpr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPrometheusId))
            {
                body["targetPrometheusId"] = request.TargetPrometheusId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                body["toTime"] = request.ToTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAggTaskGroup",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/agg-task-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggTaskGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Apply Aggregation Task Group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAggTaskGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAggTaskGroupResponse
        /// </returns>
        public UpdateAggTaskGroupResponse UpdateAggTaskGroup(string instanceId, string groupId, UpdateAggTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAggTaskGroupWithOptions(instanceId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Apply Aggregation Task Group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAggTaskGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAggTaskGroupResponse
        /// </returns>
        public async Task<UpdateAggTaskGroupResponse> UpdateAggTaskGroupAsync(string instanceId, string groupId, UpdateAggTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAggTaskGroupWithOptionsAsync(instanceId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Aggregation Task Group Status</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAggTaskGroupStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAggTaskGroupStatusResponse
        /// </returns>
        public UpdateAggTaskGroupStatusResponse UpdateAggTaskGroupStatusWithOptions(string instanceId, string groupId, UpdateAggTaskGroupStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "UpdateAggTaskGroupStatus",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/agg-task-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggTaskGroupStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Aggregation Task Group Status</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAggTaskGroupStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAggTaskGroupStatusResponse
        /// </returns>
        public async Task<UpdateAggTaskGroupStatusResponse> UpdateAggTaskGroupStatusWithOptionsAsync(string instanceId, string groupId, UpdateAggTaskGroupStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "UpdateAggTaskGroupStatus",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/agg-task-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAggTaskGroupStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Aggregation Task Group Status</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAggTaskGroupStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAggTaskGroupStatusResponse
        /// </returns>
        public UpdateAggTaskGroupStatusResponse UpdateAggTaskGroupStatus(string instanceId, string groupId, UpdateAggTaskGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAggTaskGroupStatusWithOptions(instanceId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Aggregation Task Group Status</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAggTaskGroupStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAggTaskGroupStatusResponse
        /// </returns>
        public async Task<UpdateAggTaskGroupStatusResponse> UpdateAggTaskGroupStatusAsync(string instanceId, string groupId, UpdateAggTaskGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAggTaskGroupStatusWithOptionsAsync(instanceId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改业务链路</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBizTraceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizTraceResponse
        /// </returns>
        public UpdateBizTraceResponse UpdateBizTraceWithOptions(string bizTraceId, UpdateBizTraceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedConfig))
            {
                body["advancedConfig"] = request.AdvancedConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTraceName))
            {
                body["bizTraceName"] = request.BizTraceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleConfig))
            {
                body["ruleConfig"] = request.RuleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBizTrace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/bizTrace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizTraceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBizTraceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改业务链路</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBizTraceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizTraceResponse
        /// </returns>
        public async Task<UpdateBizTraceResponse> UpdateBizTraceWithOptionsAsync(string bizTraceId, UpdateBizTraceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedConfig))
            {
                body["advancedConfig"] = request.AdvancedConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTraceName))
            {
                body["bizTraceName"] = request.BizTraceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleConfig))
            {
                body["ruleConfig"] = request.RuleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBizTrace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/bizTrace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizTraceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBizTraceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改业务链路</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBizTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizTraceResponse
        /// </returns>
        public UpdateBizTraceResponse UpdateBizTrace(string bizTraceId, UpdateBizTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateBizTraceWithOptions(bizTraceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改业务链路</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBizTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizTraceResponse
        /// </returns>
        public async Task<UpdateBizTraceResponse> UpdateBizTraceAsync(string bizTraceId, UpdateBizTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateBizTraceWithOptionsAsync(bizTraceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the specified policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIntegrationPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIntegrationPolicyResponse
        /// </returns>
        public UpdateIntegrationPolicyResponse UpdateIntegrationPolicyWithOptions(string integrationPolicyId, UpdateIntegrationPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeePackage))
            {
                body["feePackage"] = request.FeePackage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["policyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIntegrationPolicy",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(integrationPolicyId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIntegrationPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the specified policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIntegrationPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIntegrationPolicyResponse
        /// </returns>
        public async Task<UpdateIntegrationPolicyResponse> UpdateIntegrationPolicyWithOptionsAsync(string integrationPolicyId, UpdateIntegrationPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeePackage))
            {
                body["feePackage"] = request.FeePackage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["policyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIntegrationPolicy",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/integration-policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(integrationPolicyId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIntegrationPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the specified policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIntegrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIntegrationPolicyResponse
        /// </returns>
        public UpdateIntegrationPolicyResponse UpdateIntegrationPolicy(string integrationPolicyId, UpdateIntegrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIntegrationPolicyWithOptions(integrationPolicyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the specified policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIntegrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIntegrationPolicyResponse
        /// </returns>
        public async Task<UpdateIntegrationPolicyResponse> UpdateIntegrationPolicyAsync(string integrationPolicyId, UpdateIntegrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIntegrationPolicyWithOptionsAsync(integrationPolicyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新通知策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNotifyStrategyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNotifyStrategyResponse
        /// </returns>
        public UpdateNotifyStrategyResponse UpdateNotifyStrategyWithOptions(string notifyStrategyId, UpdateNotifyStrategyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNotifyStrategy",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/notifyStrategies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(notifyStrategyId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNotifyStrategyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新通知策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNotifyStrategyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNotifyStrategyResponse
        /// </returns>
        public async Task<UpdateNotifyStrategyResponse> UpdateNotifyStrategyWithOptionsAsync(string notifyStrategyId, UpdateNotifyStrategyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNotifyStrategy",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/notifyStrategies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(notifyStrategyId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNotifyStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新通知策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNotifyStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNotifyStrategyResponse
        /// </returns>
        public UpdateNotifyStrategyResponse UpdateNotifyStrategy(string notifyStrategyId, UpdateNotifyStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateNotifyStrategyWithOptions(notifyStrategyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新通知策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNotifyStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNotifyStrategyResponse
        /// </returns>
        public async Task<UpdateNotifyStrategyResponse> UpdateNotifyStrategyAsync(string notifyStrategyId, UpdateNotifyStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateNotifyStrategyWithOptionsAsync(notifyStrategyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Prometheus instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update Prometheus instance information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePrometheusInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrometheusInstanceResponse
        /// </returns>
        public UpdatePrometheusInstanceResponse UpdatePrometheusInstanceWithOptions(string prometheusInstanceId, UpdatePrometheusInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchiveDuration))
            {
                body["archiveDuration"] = request.ArchiveDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeReadPolicy))
            {
                body["authFreeReadPolicy"] = request.AuthFreeReadPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeWritePolicy))
            {
                body["authFreeWritePolicy"] = request.AuthFreeWritePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeRead))
            {
                body["enableAuthFreeRead"] = request.EnableAuthFreeRead;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeWrite))
            {
                body["enableAuthFreeWrite"] = request.EnableAuthFreeWrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthToken))
            {
                body["enableAuthToken"] = request.EnableAuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["paymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstanceName))
            {
                body["prometheusInstanceName"] = request.PrometheusInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageDuration))
            {
                body["storageDuration"] = request.StorageDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePrometheusInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusInstanceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrometheusInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Prometheus instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update Prometheus instance information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePrometheusInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrometheusInstanceResponse
        /// </returns>
        public async Task<UpdatePrometheusInstanceResponse> UpdatePrometheusInstanceWithOptionsAsync(string prometheusInstanceId, UpdatePrometheusInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchiveDuration))
            {
                body["archiveDuration"] = request.ArchiveDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeReadPolicy))
            {
                body["authFreeReadPolicy"] = request.AuthFreeReadPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeWritePolicy))
            {
                body["authFreeWritePolicy"] = request.AuthFreeWritePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeRead))
            {
                body["enableAuthFreeRead"] = request.EnableAuthFreeRead;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeWrite))
            {
                body["enableAuthFreeWrite"] = request.EnableAuthFreeWrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthToken))
            {
                body["enableAuthToken"] = request.EnableAuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["paymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstanceName))
            {
                body["prometheusInstanceName"] = request.PrometheusInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageDuration))
            {
                body["storageDuration"] = request.StorageDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePrometheusInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusInstanceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrometheusInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Prometheus instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update Prometheus instance information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePrometheusInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrometheusInstanceResponse
        /// </returns>
        public UpdatePrometheusInstanceResponse UpdatePrometheusInstance(string prometheusInstanceId, UpdatePrometheusInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePrometheusInstanceWithOptions(prometheusInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Prometheus instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update Prometheus instance information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePrometheusInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrometheusInstanceResponse
        /// </returns>
        public async Task<UpdatePrometheusInstanceResponse> UpdatePrometheusInstanceAsync(string prometheusInstanceId, UpdatePrometheusInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePrometheusInstanceWithOptionsAsync(prometheusInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Prom实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrometheusUserSettingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrometheusUserSettingResponse
        /// </returns>
        public UpdatePrometheusUserSettingResponse UpdatePrometheusUserSettingWithOptions(string settingKey, UpdatePrometheusUserSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingValue))
            {
                query["settingValue"] = request.SettingValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePrometheusUserSetting",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-user-setting/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(settingKey),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrometheusUserSettingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Prom实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrometheusUserSettingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrometheusUserSettingResponse
        /// </returns>
        public async Task<UpdatePrometheusUserSettingResponse> UpdatePrometheusUserSettingWithOptionsAsync(string settingKey, UpdatePrometheusUserSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingValue))
            {
                query["settingValue"] = request.SettingValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePrometheusUserSetting",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-user-setting/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(settingKey),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrometheusUserSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Prom实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrometheusUserSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrometheusUserSettingResponse
        /// </returns>
        public UpdatePrometheusUserSettingResponse UpdatePrometheusUserSetting(string settingKey, UpdatePrometheusUserSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePrometheusUserSettingWithOptions(settingKey, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Prom实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrometheusUserSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrometheusUserSettingResponse
        /// </returns>
        public async Task<UpdatePrometheusUserSettingResponse> UpdatePrometheusUserSettingAsync(string settingKey, UpdatePrometheusUserSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePrometheusUserSettingWithOptionsAsync(settingKey, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Prometheus view instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update Prometheus view instance information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePrometheusViewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrometheusViewResponse
        /// </returns>
        public UpdatePrometheusViewResponse UpdatePrometheusViewWithOptions(string prometheusViewId, UpdatePrometheusViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeReadPolicy))
            {
                body["authFreeReadPolicy"] = request.AuthFreeReadPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeRead))
            {
                body["enableAuthFreeRead"] = request.EnableAuthFreeRead;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthToken))
            {
                body["enableAuthToken"] = request.EnableAuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstances))
            {
                body["prometheusInstances"] = request.PrometheusInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusViewName))
            {
                body["prometheusViewName"] = request.PrometheusViewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePrometheusView",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-views/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusViewId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrometheusViewResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Prometheus view instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update Prometheus view instance information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePrometheusViewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrometheusViewResponse
        /// </returns>
        public async Task<UpdatePrometheusViewResponse> UpdatePrometheusViewWithOptionsAsync(string prometheusViewId, UpdatePrometheusViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeReadPolicy))
            {
                body["authFreeReadPolicy"] = request.AuthFreeReadPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeRead))
            {
                body["enableAuthFreeRead"] = request.EnableAuthFreeRead;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthToken))
            {
                body["enableAuthToken"] = request.EnableAuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstances))
            {
                body["prometheusInstances"] = request.PrometheusInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusViewName))
            {
                body["prometheusViewName"] = request.PrometheusViewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePrometheusView",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-views/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusViewId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrometheusViewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Prometheus view instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update Prometheus view instance information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePrometheusViewRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrometheusViewResponse
        /// </returns>
        public UpdatePrometheusViewResponse UpdatePrometheusView(string prometheusViewId, UpdatePrometheusViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePrometheusViewWithOptions(prometheusViewId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Prometheus view instance information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update Prometheus view instance information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePrometheusViewRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrometheusViewResponse
        /// </returns>
        public async Task<UpdatePrometheusViewResponse> UpdatePrometheusViewAsync(string prometheusViewId, UpdatePrometheusViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePrometheusViewWithOptionsAsync(prometheusViewId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public UpdateServiceResponse UpdateServiceWithOptions(string workspace, string serviceId, UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                body["serviceStatus"] = request.ServiceStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public async Task<UpdateServiceResponse> UpdateServiceWithOptionsAsync(string workspace, string serviceId, UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                body["serviceStatus"] = request.ServiceStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public UpdateServiceResponse UpdateService(string workspace, string serviceId, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceWithOptions(workspace, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public async Task<UpdateServiceResponse> UpdateServiceAsync(string workspace, string serviceId, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceWithOptionsAsync(workspace, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubscriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscriptionResponse
        /// </returns>
        public UpdateSubscriptionResponse UpdateSubscriptionWithOptions(string subscriptionId, UpdateSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSubscription",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/subscriptions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(subscriptionId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubscriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscriptionResponse
        /// </returns>
        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionWithOptionsAsync(string subscriptionId, UpdateSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSubscription",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/subscriptions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(subscriptionId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscriptionResponse
        /// </returns>
        public UpdateSubscriptionResponse UpdateSubscription(string subscriptionId, UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSubscriptionWithOptions(subscriptionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscriptionResponse
        /// </returns>
        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(string subscriptionId, UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSubscriptionWithOptionsAsync(subscriptionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Umodel configuration information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update Umodel configuration information</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUmodelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUmodelResponse
        /// </returns>
        public UpdateUmodelResponse UpdateUmodelWithOptions(string workspace, UpdateUmodelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUmodelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Umodel configuration information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update Umodel configuration information</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUmodelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUmodelResponse
        /// </returns>
        public async Task<UpdateUmodelResponse> UpdateUmodelWithOptionsAsync(string workspace, UpdateUmodelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUmodelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Umodel configuration information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update Umodel configuration information</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUmodelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUmodelResponse
        /// </returns>
        public UpdateUmodelResponse UpdateUmodel(string workspace, UpdateUmodelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateUmodelWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Umodel configuration information</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update Umodel configuration information</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUmodelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUmodelResponse
        /// </returns>
        public async Task<UpdateUmodelResponse> UpdateUmodelAsync(string workspace, UpdateUmodelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateUmodelWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertUmodelCommonSchemaRefRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpsertUmodelCommonSchemaRefResponse
        /// </returns>
        public UpsertUmodelCommonSchemaRefResponse UpsertUmodelCommonSchemaRefWithOptions(string workspace, UpsertUmodelCommonSchemaRefRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpsertUmodelCommonSchemaRef",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/common-schema-ref",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpsertUmodelCommonSchemaRefResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertUmodelCommonSchemaRefRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpsertUmodelCommonSchemaRefResponse
        /// </returns>
        public async Task<UpsertUmodelCommonSchemaRefResponse> UpsertUmodelCommonSchemaRefWithOptionsAsync(string workspace, UpsertUmodelCommonSchemaRefRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpsertUmodelCommonSchemaRef",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/common-schema-ref",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpsertUmodelCommonSchemaRefResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertUmodelCommonSchemaRefRequest
        /// </param>
        /// 
        /// <returns>
        /// UpsertUmodelCommonSchemaRefResponse
        /// </returns>
        public UpsertUmodelCommonSchemaRefResponse UpsertUmodelCommonSchemaRef(string workspace, UpsertUmodelCommonSchemaRefRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpsertUmodelCommonSchemaRefWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertUmodelCommonSchemaRefRequest
        /// </param>
        /// 
        /// <returns>
        /// UpsertUmodelCommonSchemaRefResponse
        /// </returns>
        public async Task<UpsertUmodelCommonSchemaRefResponse> UpsertUmodelCommonSchemaRefAsync(string workspace, UpsertUmodelCommonSchemaRefRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpsertUmodelCommonSchemaRefWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Write Umodel Elements</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertUmodelDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpsertUmodelDataResponse
        /// </returns>
        public UpsertUmodelDataResponse UpsertUmodelDataWithOptions(string workspace, UpsertUmodelDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["method"] = request.Method;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Elements))
            {
                body["elements"] = request.Elements;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpsertUmodelData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/data",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpsertUmodelDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Write Umodel Elements</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertUmodelDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpsertUmodelDataResponse
        /// </returns>
        public async Task<UpsertUmodelDataResponse> UpsertUmodelDataWithOptionsAsync(string workspace, UpsertUmodelDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["method"] = request.Method;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Elements))
            {
                body["elements"] = request.Elements;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpsertUmodelData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/data",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpsertUmodelDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Write Umodel Elements</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertUmodelDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UpsertUmodelDataResponse
        /// </returns>
        public UpsertUmodelDataResponse UpsertUmodelData(string workspace, UpsertUmodelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpsertUmodelDataWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Write Umodel Elements</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertUmodelDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UpsertUmodelDataResponse
        /// </returns>
        public async Task<UpsertUmodelDataResponse> UpsertUmodelDataAsync(string workspace, UpsertUmodelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpsertUmodelDataWithOptionsAsync(workspace, request, headers, runtime);
        }

    }
}
