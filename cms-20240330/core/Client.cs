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
        /// <para>添加记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMemoriesResponse
        /// </returns>
        public AddMemoriesResponse AddMemoriesWithOptions(string workspace, string memoryStoreName, AddMemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncMode))
            {
                body["asyncMode"] = request.AsyncMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomInstructions))
            {
                body["customInstructions"] = request.CustomInstructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Infer))
            {
                body["infer"] = request.Infer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["runId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                body["timestamp"] = request.Timestamp;
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
                Action = "AddMemories",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMemoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMemoriesResponse
        /// </returns>
        public async Task<AddMemoriesResponse> AddMemoriesWithOptionsAsync(string workspace, string memoryStoreName, AddMemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncMode))
            {
                body["asyncMode"] = request.AsyncMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomInstructions))
            {
                body["customInstructions"] = request.CustomInstructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Infer))
            {
                body["infer"] = request.Infer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["runId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                body["timestamp"] = request.Timestamp;
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
                Action = "AddMemories",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMemoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMemoriesResponse
        /// </returns>
        public AddMemoriesResponse AddMemories(string workspace, string memoryStoreName, AddMemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddMemoriesWithOptions(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMemoriesResponse
        /// </returns>
        public async Task<AddMemoriesResponse> AddMemoriesAsync(string workspace, string memoryStoreName, AddMemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddMemoriesWithOptionsAsync(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改资源所属资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/resourcegroup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改资源所属资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/resourcegroup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改资源所属资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ChangeResourceGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改资源所属资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ChangeResourceGroupWithOptionsAsync(request, headers, runtime);
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
        /// <para>创建Webhook</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlertWebhookRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAlertWebhookResponse
        /// </returns>
        public CreateAlertWebhookResponse CreateAlertWebhookWithOptions(CreateAlertWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Headers))
            {
                body["headers"] = request.Headers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookId))
            {
                body["webhookId"] = request.WebhookId;
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
                Action = "CreateAlertWebhook",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/webhook",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlertWebhookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Webhook</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlertWebhookRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAlertWebhookResponse
        /// </returns>
        public async Task<CreateAlertWebhookResponse> CreateAlertWebhookWithOptionsAsync(CreateAlertWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Headers))
            {
                body["headers"] = request.Headers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookId))
            {
                body["webhookId"] = request.WebhookId;
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
                Action = "CreateAlertWebhook",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/webhook",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlertWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Webhook</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlertWebhookRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAlertWebhookResponse
        /// </returns>
        public CreateAlertWebhookResponse CreateAlertWebhook(CreateAlertWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAlertWebhookWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Webhook</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlertWebhookRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAlertWebhookResponse
        /// </returns>
        public async Task<CreateAlertWebhookResponse> CreateAlertWebhookAsync(CreateAlertWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAlertWebhookWithOptionsAsync(request, headers, runtime);
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
        /// <para>创建数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public CreateDatasetResponse CreateDatasetWithOptions(string workspace, CreateDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["datasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["schema"] = request.Schema;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataset",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/dataset",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public async Task<CreateDatasetResponse> CreateDatasetWithOptionsAsync(string workspace, CreateDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["datasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["schema"] = request.Schema;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataset",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/dataset",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public CreateDatasetResponse CreateDataset(string workspace, CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatasetWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public async Task<CreateDatasetResponse> CreateDatasetAsync(string workspace, CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatasetWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeliveryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeliveryTaskResponse
        /// </returns>
        public CreateDeliveryTaskResponse CreateDeliveryTaskWithOptions(CreateDeliveryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalLabels))
            {
                body["externalLabels"] = request.ExternalLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelFilters))
            {
                body["labelFilters"] = request.LabelFilters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelFiltersType))
            {
                body["labelFiltersType"] = request.LabelFiltersType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkList))
            {
                body["sinkList"] = request.SinkList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeliveryTask",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/delivery-tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliveryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeliveryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeliveryTaskResponse
        /// </returns>
        public async Task<CreateDeliveryTaskResponse> CreateDeliveryTaskWithOptionsAsync(CreateDeliveryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalLabels))
            {
                body["externalLabels"] = request.ExternalLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelFilters))
            {
                body["labelFilters"] = request.LabelFilters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelFiltersType))
            {
                body["labelFiltersType"] = request.LabelFiltersType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkList))
            {
                body["sinkList"] = request.SinkList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeliveryTask",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/delivery-tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliveryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeliveryTaskResponse
        /// </returns>
        public CreateDeliveryTaskResponse CreateDeliveryTask(CreateDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDeliveryTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeliveryTaskResponse
        /// </returns>
        public async Task<CreateDeliveryTaskResponse> CreateDeliveryTaskAsync(CreateDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDeliveryTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create storage related to EntityStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEntityStoreRequest
        /// </param>
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
        public CreateEntityStoreResponse CreateEntityStoreWithOptions(string workspaceName, CreateEntityStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// CreateEntityStoreRequest
        /// </param>
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
        public async Task<CreateEntityStoreResponse> CreateEntityStoreWithOptionsAsync(string workspaceName, CreateEntityStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// CreateEntityStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEntityStoreResponse
        /// </returns>
        public CreateEntityStoreResponse CreateEntityStore(string workspaceName, CreateEntityStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEntityStoreWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create storage related to EntityStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEntityStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEntityStoreResponse
        /// </returns>
        public async Task<CreateEntityStoreResponse> CreateEntityStoreAsync(string workspaceName, CreateEntityStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEntityStoreWithOptionsAsync(workspaceName, request, headers, runtime);
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
        /// <para>创建记忆库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryStoreResponse
        /// </returns>
        public CreateMemoryStoreResponse CreateMemoryStoreWithOptions(string workspace, CreateMemoryStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomExtractionStrategies))
            {
                body["customExtractionStrategies"] = request.CustomExtractionStrategies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractionStrategies))
            {
                body["extractionStrategies"] = request.ExtractionStrategies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryStoreName))
            {
                body["memoryStoreName"] = request.MemoryStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortTermTtl))
            {
                body["shortTermTtl"] = request.ShortTermTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceSourceConfig))
            {
                body["traceSourceConfig"] = request.TraceSourceConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemoryStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建记忆库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryStoreResponse
        /// </returns>
        public async Task<CreateMemoryStoreResponse> CreateMemoryStoreWithOptionsAsync(string workspace, CreateMemoryStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomExtractionStrategies))
            {
                body["customExtractionStrategies"] = request.CustomExtractionStrategies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractionStrategies))
            {
                body["extractionStrategies"] = request.ExtractionStrategies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryStoreName))
            {
                body["memoryStoreName"] = request.MemoryStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortTermTtl))
            {
                body["shortTermTtl"] = request.ShortTermTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceSourceConfig))
            {
                body["traceSourceConfig"] = request.TraceSourceConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemoryStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建记忆库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryStoreResponse
        /// </returns>
        public CreateMemoryStoreResponse CreateMemoryStore(string workspace, CreateMemoryStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMemoryStoreWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建记忆库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryStoreResponse
        /// </returns>
        public async Task<CreateMemoryStoreResponse> CreateMemoryStoreAsync(string workspace, CreateMemoryStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMemoryStoreWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePipelineResponse
        /// </returns>
        public CreatePipelineResponse CreatePipelineWithOptions(string workspace, CreatePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutePolicy))
            {
                body["executePolicy"] = request.ExecutePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pipeline))
            {
                body["pipeline"] = request.Pipeline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                body["pipelineName"] = request.PipelineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sink))
            {
                body["sink"] = request.Sink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipeline",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/pipeline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePipelineResponse
        /// </returns>
        public async Task<CreatePipelineResponse> CreatePipelineWithOptionsAsync(string workspace, CreatePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutePolicy))
            {
                body["executePolicy"] = request.ExecutePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pipeline))
            {
                body["pipeline"] = request.Pipeline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                body["pipelineName"] = request.PipelineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sink))
            {
                body["sink"] = request.Sink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipeline",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/pipeline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePipelineResponse
        /// </returns>
        public CreatePipelineResponse CreatePipeline(string workspace, CreatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePipelineWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePipelineResponse
        /// </returns>
        public async Task<CreatePipelineResponse> CreatePipelineAsync(string workspace, CreatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePipelineWithOptionsAsync(workspace, request, headers, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
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
        /// <para>创建应用可观测实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceObservabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceObservabilityResponse
        /// </returns>
        public CreateServiceObservabilityResponse CreateServiceObservabilityWithOptions(string workspace, string type, CreateServiceObservabilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceObservability",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service-observability/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceObservabilityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用可观测实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceObservabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceObservabilityResponse
        /// </returns>
        public async Task<CreateServiceObservabilityResponse> CreateServiceObservabilityWithOptionsAsync(string workspace, string type, CreateServiceObservabilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceObservability",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service-observability/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceObservabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用可观测实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceObservabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceObservabilityResponse
        /// </returns>
        public CreateServiceObservabilityResponse CreateServiceObservability(string workspace, string type, CreateServiceObservabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceObservabilityWithOptions(workspace, type, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用可观测实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceObservabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceObservabilityResponse
        /// </returns>
        public async Task<CreateServiceObservabilityResponse> CreateServiceObservabilityAsync(string workspace, string type, CreateServiceObservabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceObservabilityWithOptionsAsync(workspace, type, request, headers, runtime);
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
        /// <param name="request">
        /// DeleteAggTaskGroupRequest
        /// </param>
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
        public DeleteAggTaskGroupResponse DeleteAggTaskGroupWithOptions(string instanceId, string groupId, DeleteAggTaskGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeleteAggTaskGroupRequest
        /// </param>
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
        public async Task<DeleteAggTaskGroupResponse> DeleteAggTaskGroupWithOptionsAsync(string instanceId, string groupId, DeleteAggTaskGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeleteAggTaskGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAggTaskGroupResponse
        /// </returns>
        public DeleteAggTaskGroupResponse DeleteAggTaskGroup(string instanceId, string groupId, DeleteAggTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAggTaskGroupWithOptions(instanceId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Aggregation Task Group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAggTaskGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAggTaskGroupResponse
        /// </returns>
        public async Task<DeleteAggTaskGroupResponse> DeleteAggTaskGroupAsync(string instanceId, string groupId, DeleteAggTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAggTaskGroupWithOptionsAsync(instanceId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Webhook</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAlertWebhooksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlertWebhooksResponse
        /// </returns>
        public DeleteAlertWebhooksResponse DeleteAlertWebhooksWithOptions(DeleteAlertWebhooksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAlertWebhooksShrinkRequest request = new DeleteAlertWebhooksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WebhookIds))
            {
                request.WebhookIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WebhookIds, "webhookIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookIdsShrink))
            {
                query["webhookIds"] = request.WebhookIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlertWebhooks",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/webhooks",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlertWebhooksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Webhook</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAlertWebhooksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlertWebhooksResponse
        /// </returns>
        public async Task<DeleteAlertWebhooksResponse> DeleteAlertWebhooksWithOptionsAsync(DeleteAlertWebhooksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAlertWebhooksShrinkRequest request = new DeleteAlertWebhooksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WebhookIds))
            {
                request.WebhookIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WebhookIds, "webhookIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookIdsShrink))
            {
                query["webhookIds"] = request.WebhookIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlertWebhooks",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/webhooks",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlertWebhooksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Webhook</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAlertWebhooksRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlertWebhooksResponse
        /// </returns>
        public DeleteAlertWebhooksResponse DeleteAlertWebhooks(DeleteAlertWebhooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAlertWebhooksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Webhook</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAlertWebhooksRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlertWebhooksResponse
        /// </returns>
        public async Task<DeleteAlertWebhooksResponse> DeleteAlertWebhooksAsync(DeleteAlertWebhooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAlertWebhooksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务链路</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizTraceRequest
        /// </param>
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
        public DeleteBizTraceResponse DeleteBizTraceWithOptions(string bizTraceId, DeleteBizTraceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeleteBizTraceRequest
        /// </param>
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
        public async Task<DeleteBizTraceResponse> DeleteBizTraceWithOptionsAsync(string bizTraceId, DeleteBizTraceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeleteBizTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizTraceResponse
        /// </returns>
        public DeleteBizTraceResponse DeleteBizTrace(string bizTraceId, DeleteBizTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBizTraceWithOptions(bizTraceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务链路</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizTraceResponse
        /// </returns>
        public async Task<DeleteBizTraceResponse> DeleteBizTraceAsync(string bizTraceId, DeleteBizTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBizTraceWithOptionsAsync(bizTraceId, request, headers, runtime);
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
        /// <para>删除数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public DeleteDatasetResponse DeleteDatasetWithOptions(string workspace, string datasetName, DeleteDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataset",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public async Task<DeleteDatasetResponse> DeleteDatasetWithOptionsAsync(string workspace, string datasetName, DeleteDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataset",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public DeleteDatasetResponse DeleteDataset(string workspace, string datasetName, DeleteDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDatasetWithOptions(workspace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public async Task<DeleteDatasetResponse> DeleteDatasetAsync(string workspace, string datasetName, DeleteDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDatasetWithOptionsAsync(workspace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDeliveryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeliveryTaskResponse
        /// </returns>
        public DeleteDeliveryTaskResponse DeleteDeliveryTaskWithOptions(string taskId, DeleteDeliveryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeliveryTask",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/delivery-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeliveryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDeliveryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeliveryTaskResponse
        /// </returns>
        public async Task<DeleteDeliveryTaskResponse> DeleteDeliveryTaskWithOptionsAsync(string taskId, DeleteDeliveryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeliveryTask",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/delivery-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeliveryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeliveryTaskResponse
        /// </returns>
        public DeleteDeliveryTaskResponse DeleteDeliveryTask(string taskId, DeleteDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDeliveryTaskWithOptions(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeliveryTaskResponse
        /// </returns>
        public async Task<DeleteDeliveryTaskResponse> DeleteDeliveryTaskAsync(string taskId, DeleteDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDeliveryTaskWithOptionsAsync(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete EntityStore related storage</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEntityStoreRequest
        /// </param>
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
        public DeleteEntityStoreResponse DeleteEntityStoreWithOptions(string workspaceName, DeleteEntityStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeleteEntityStoreRequest
        /// </param>
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
        public async Task<DeleteEntityStoreResponse> DeleteEntityStoreWithOptionsAsync(string workspaceName, DeleteEntityStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeleteEntityStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityStoreResponse
        /// </returns>
        public DeleteEntityStoreResponse DeleteEntityStore(string workspaceName, DeleteEntityStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEntityStoreWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete EntityStore related storage</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEntityStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityStoreResponse
        /// </returns>
        public async Task<DeleteEntityStoreResponse> DeleteEntityStoreAsync(string workspaceName, DeleteEntityStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEntityStoreWithOptionsAsync(workspaceName, request, headers, runtime);
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
        /// <para>批量删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoriesResponse
        /// </returns>
        public DeleteMemoriesResponse DeleteMemoriesWithOptions(string workspace, string memoryStoreName, DeleteMemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["runId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemories",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoriesResponse
        /// </returns>
        public async Task<DeleteMemoriesResponse> DeleteMemoriesWithOptionsAsync(string workspace, string memoryStoreName, DeleteMemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["runId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemories",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoriesResponse
        /// </returns>
        public DeleteMemoriesResponse DeleteMemories(string workspace, string memoryStoreName, DeleteMemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMemoriesWithOptions(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoriesResponse
        /// </returns>
        public async Task<DeleteMemoriesResponse> DeleteMemoriesAsync(string workspace, string memoryStoreName, DeleteMemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMemoriesWithOptionsAsync(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryResponse
        /// </returns>
        public DeleteMemoryResponse DeleteMemoryWithOptions(string workspace, string memoryStoreName, string memoryId, DeleteMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemory",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryResponse
        /// </returns>
        public async Task<DeleteMemoryResponse> DeleteMemoryWithOptionsAsync(string workspace, string memoryStoreName, string memoryId, DeleteMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemory",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryResponse
        /// </returns>
        public DeleteMemoryResponse DeleteMemory(string workspace, string memoryStoreName, string memoryId, DeleteMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMemoryWithOptions(workspace, memoryStoreName, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryResponse
        /// </returns>
        public async Task<DeleteMemoryResponse> DeleteMemoryAsync(string workspace, string memoryStoreName, string memoryId, DeleteMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMemoryWithOptionsAsync(workspace, memoryStoreName, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryStoreResponse
        /// </returns>
        public DeleteMemoryStoreResponse DeleteMemoryStoreWithOptions(string workspace, string memoryStoreName, DeleteMemoryStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemoryStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryStoreResponse
        /// </returns>
        public async Task<DeleteMemoryStoreResponse> DeleteMemoryStoreWithOptionsAsync(string workspace, string memoryStoreName, DeleteMemoryStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemoryStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryStoreResponse
        /// </returns>
        public DeleteMemoryStoreResponse DeleteMemoryStore(string workspace, string memoryStoreName, DeleteMemoryStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMemoryStoreWithOptions(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryStoreResponse
        /// </returns>
        public async Task<DeleteMemoryStoreResponse> DeleteMemoryStoreAsync(string workspace, string memoryStoreName, DeleteMemoryStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMemoryStoreWithOptionsAsync(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePipelineResponse
        /// </returns>
        public DeletePipelineResponse DeletePipelineWithOptions(string workspace, string pipelineName, DeletePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipeline",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePipelineResponse
        /// </returns>
        public async Task<DeletePipelineResponse> DeletePipelineWithOptionsAsync(string workspace, string pipelineName, DeletePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipeline",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePipelineResponse
        /// </returns>
        public DeletePipelineResponse DeletePipeline(string workspace, string pipelineName, DeletePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePipelineWithOptions(workspace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePipelineResponse
        /// </returns>
        public async Task<DeletePipelineResponse> DeletePipelineAsync(string workspace, string pipelineName, DeletePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePipelineWithOptionsAsync(workspace, pipelineName, request, headers, runtime);
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
        /// <param name="request">
        /// DeletePrometheusInstanceRequest
        /// </param>
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
        public DeletePrometheusInstanceResponse DeletePrometheusInstanceWithOptions(string prometheusInstanceId, DeletePrometheusInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeletePrometheusInstanceRequest
        /// </param>
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
        public async Task<DeletePrometheusInstanceResponse> DeletePrometheusInstanceWithOptionsAsync(string prometheusInstanceId, DeletePrometheusInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeletePrometheusInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrometheusInstanceResponse
        /// </returns>
        public DeletePrometheusInstanceResponse DeletePrometheusInstance(string prometheusInstanceId, DeletePrometheusInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePrometheusInstanceWithOptions(prometheusInstanceId, request, headers, runtime);
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
        /// <param name="request">
        /// DeletePrometheusInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrometheusInstanceResponse
        /// </returns>
        public async Task<DeletePrometheusInstanceResponse> DeletePrometheusInstanceAsync(string prometheusInstanceId, DeletePrometheusInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePrometheusInstanceWithOptionsAsync(prometheusInstanceId, request, headers, runtime);
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
        /// <param name="request">
        /// DeletePrometheusViewRequest
        /// </param>
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
        public DeletePrometheusViewResponse DeletePrometheusViewWithOptions(string prometheusViewId, DeletePrometheusViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeletePrometheusViewRequest
        /// </param>
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
        public async Task<DeletePrometheusViewResponse> DeletePrometheusViewWithOptionsAsync(string prometheusViewId, DeletePrometheusViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeletePrometheusViewRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrometheusViewResponse
        /// </returns>
        public DeletePrometheusViewResponse DeletePrometheusView(string prometheusViewId, DeletePrometheusViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePrometheusViewWithOptions(prometheusViewId, request, headers, runtime);
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
        /// <param name="request">
        /// DeletePrometheusViewRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrometheusViewResponse
        /// </returns>
        public async Task<DeletePrometheusViewResponse> DeletePrometheusViewAsync(string prometheusViewId, DeletePrometheusViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePrometheusViewWithOptionsAsync(prometheusViewId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 Prometheus 虚拟实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrometheusVirtualInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrometheusVirtualInstanceResponse
        /// </returns>
        public DeletePrometheusVirtualInstanceResponse DeletePrometheusVirtualInstanceWithOptions(string prometheusInstanceId, DeletePrometheusVirtualInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrometheusVirtualInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/virtual-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusInstanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrometheusVirtualInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 Prometheus 虚拟实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrometheusVirtualInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrometheusVirtualInstanceResponse
        /// </returns>
        public async Task<DeletePrometheusVirtualInstanceResponse> DeletePrometheusVirtualInstanceWithOptionsAsync(string prometheusInstanceId, DeletePrometheusVirtualInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrometheusVirtualInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/virtual-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(prometheusInstanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrometheusVirtualInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 Prometheus 虚拟实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrometheusVirtualInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrometheusVirtualInstanceResponse
        /// </returns>
        public DeletePrometheusVirtualInstanceResponse DeletePrometheusVirtualInstance(string prometheusInstanceId, DeletePrometheusVirtualInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePrometheusVirtualInstanceWithOptions(prometheusInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 Prometheus 虚拟实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrometheusVirtualInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrometheusVirtualInstanceResponse
        /// </returns>
        public async Task<DeletePrometheusVirtualInstanceResponse> DeletePrometheusVirtualInstanceAsync(string prometheusInstanceId, DeletePrometheusVirtualInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePrometheusVirtualInstanceWithOptionsAsync(prometheusInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteServiceRequest
        /// </param>
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
        public DeleteServiceResponse DeleteServiceWithOptions(string workspace, string serviceId, DeleteServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeleteServiceRequest
        /// </param>
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
        public async Task<DeleteServiceResponse> DeleteServiceWithOptionsAsync(string workspace, string serviceId, DeleteServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeleteServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public DeleteServiceResponse DeleteService(string workspace, string serviceId, DeleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceWithOptions(workspace, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public async Task<DeleteServiceResponse> DeleteServiceAsync(string workspace, string serviceId, DeleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceWithOptionsAsync(workspace, serviceId, request, headers, runtime);
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
        /// <param name="request">
        /// DeleteUmodelRequest
        /// </param>
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
        public DeleteUmodelResponse DeleteUmodelWithOptions(string workspace, DeleteUmodelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeleteUmodelRequest
        /// </param>
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
        public async Task<DeleteUmodelResponse> DeleteUmodelWithOptionsAsync(string workspace, DeleteUmodelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeleteUmodelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelResponse
        /// </returns>
        public DeleteUmodelResponse DeleteUmodel(string workspace, DeleteUmodelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUmodelWithOptions(workspace, request, headers, runtime);
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
        /// <param name="request">
        /// DeleteUmodelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelResponse
        /// </returns>
        public async Task<DeleteUmodelResponse> DeleteUmodelAsync(string workspace, DeleteUmodelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUmodelWithOptionsAsync(workspace, request, headers, runtime);
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
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
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
        public DeleteWorkspaceResponse DeleteWorkspaceWithOptions(string workspaceName, DeleteWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
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
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceWithOptionsAsync(string workspaceName, DeleteWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspace(string workspaceName, DeleteWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWorkspaceWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Workspace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(string workspaceName, DeleteWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWorkspaceWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询元数据meta</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeMetricMetaListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricMetaListResponse
        /// </returns>
        public DescribeMetricMetaListResponse DescribeMetricMetaListWithOptions(DescribeMetricMetaListRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeMetricMetaListShrinkRequest request = new DescribeMetricMetaListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "labels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["labels"] = request.LabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaFormat))
            {
                query["metaFormat"] = request.MetaFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["metricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricMetaList",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/describe-metric-meta-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricMetaListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询元数据meta</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeMetricMetaListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricMetaListResponse
        /// </returns>
        public async Task<DescribeMetricMetaListResponse> DescribeMetricMetaListWithOptionsAsync(DescribeMetricMetaListRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeMetricMetaListShrinkRequest request = new DescribeMetricMetaListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "labels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["labels"] = request.LabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaFormat))
            {
                query["metaFormat"] = request.MetaFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["metricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricMetaList",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/describe-metric-meta-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricMetaListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询元数据meta</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetricMetaListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricMetaListResponse
        /// </returns>
        public DescribeMetricMetaListResponse DescribeMetricMetaList(DescribeMetricMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeMetricMetaListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询元数据meta</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetricMetaListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricMetaListResponse
        /// </returns>
        public async Task<DescribeMetricMetaListResponse> DescribeMetricMetaListAsync(DescribeMetricMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeMetricMetaListWithOptionsAsync(request, headers, runtime);
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
        /// <para>执行查询语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteQueryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteQueryResponse
        /// </returns>
        public ExecuteQueryResponse ExecuteQueryWithOptions(string workspace, string datasetName, ExecuteQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
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
                Action = "ExecuteQuery",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName) + "/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteQueryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行查询语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteQueryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteQueryResponse
        /// </returns>
        public async Task<ExecuteQueryResponse> ExecuteQueryWithOptionsAsync(string workspace, string datasetName, ExecuteQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
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
                Action = "ExecuteQuery",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName) + "/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行查询语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteQueryResponse
        /// </returns>
        public ExecuteQueryResponse ExecuteQuery(string workspace, string datasetName, ExecuteQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteQueryWithOptions(workspace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行查询语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteQueryResponse
        /// </returns>
        public async Task<ExecuteQueryResponse> ExecuteQueryAsync(string workspace, string datasetName, ExecuteQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteQueryWithOptionsAsync(workspace, datasetName, request, headers, runtime);
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
        /// <param name="request">
        /// GetAddonReleaseRequest
        /// </param>
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
        public GetAddonReleaseResponse GetAddonReleaseWithOptions(string releaseName, string policyId, GetAddonReleaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetAddonReleaseRequest
        /// </param>
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
        public async Task<GetAddonReleaseResponse> GetAddonReleaseWithOptionsAsync(string releaseName, string policyId, GetAddonReleaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetAddonReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAddonReleaseResponse
        /// </returns>
        public GetAddonReleaseResponse GetAddonRelease(string releaseName, string policyId, GetAddonReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAddonReleaseWithOptions(releaseName, policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check addon release (view connection status)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAddonReleaseResponse
        /// </returns>
        public async Task<GetAddonReleaseResponse> GetAddonReleaseAsync(string releaseName, string policyId, GetAddonReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAddonReleaseWithOptionsAsync(releaseName, policyId, request, headers, runtime);
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
        /// <param name="request">
        /// GetAggTaskGroupRequest
        /// </param>
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
        public GetAggTaskGroupResponse GetAggTaskGroupWithOptions(string instanceId, string groupId, GetAggTaskGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetAggTaskGroupRequest
        /// </param>
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
        public async Task<GetAggTaskGroupResponse> GetAggTaskGroupWithOptionsAsync(string instanceId, string groupId, GetAggTaskGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetAggTaskGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAggTaskGroupResponse
        /// </returns>
        public GetAggTaskGroupResponse GetAggTaskGroup(string instanceId, string groupId, GetAggTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAggTaskGroupWithOptions(instanceId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes the aggregation task group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAggTaskGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAggTaskGroupResponse
        /// </returns>
        public async Task<GetAggTaskGroupResponse> GetAggTaskGroupAsync(string instanceId, string groupId, GetAggTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAggTaskGroupWithOptionsAsync(instanceId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务链路</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizTraceRequest
        /// </param>
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
        public GetBizTraceResponse GetBizTraceWithOptions(string bizTraceId, GetBizTraceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetBizTraceRequest
        /// </param>
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
        public async Task<GetBizTraceResponse> GetBizTraceWithOptionsAsync(string bizTraceId, GetBizTraceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetBizTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBizTraceResponse
        /// </returns>
        public GetBizTraceResponse GetBizTrace(string bizTraceId, GetBizTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBizTraceWithOptions(bizTraceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务链路</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBizTraceResponse
        /// </returns>
        public async Task<GetBizTraceResponse> GetBizTraceAsync(string bizTraceId, GetBizTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBizTraceWithOptionsAsync(bizTraceId, request, headers, runtime);
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
        /// <para>查询数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public GetDatasetResponse GetDatasetWithOptions(string workspace, string datasetName, GetDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataset",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public async Task<GetDatasetResponse> GetDatasetWithOptionsAsync(string workspace, string datasetName, GetDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataset",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public GetDatasetResponse GetDataset(string workspace, string datasetName, GetDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatasetWithOptions(workspace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public async Task<GetDatasetResponse> GetDatasetAsync(string workspace, string datasetName, GetDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatasetWithOptionsAsync(workspace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据投递任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeliveryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeliveryTaskResponse
        /// </returns>
        public GetDeliveryTaskResponse GetDeliveryTaskWithOptions(string taskId, GetDeliveryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeliveryTask",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/delivery-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeliveryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据投递任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeliveryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeliveryTaskResponse
        /// </returns>
        public async Task<GetDeliveryTaskResponse> GetDeliveryTaskWithOptionsAsync(string taskId, GetDeliveryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeliveryTask",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/delivery-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeliveryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据投递任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeliveryTaskResponse
        /// </returns>
        public GetDeliveryTaskResponse GetDeliveryTask(string taskId, GetDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDeliveryTaskWithOptions(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据投递任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeliveryTaskResponse
        /// </returns>
        public async Task<GetDeliveryTaskResponse> GetDeliveryTaskAsync(string taskId, GetDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDeliveryTaskWithOptionsAsync(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get EntityStore related storage information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityStoreRequest
        /// </param>
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
        public GetEntityStoreResponse GetEntityStoreWithOptions(string workspaceName, GetEntityStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetEntityStoreRequest
        /// </param>
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
        public async Task<GetEntityStoreResponse> GetEntityStoreWithOptionsAsync(string workspaceName, GetEntityStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetEntityStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreResponse
        /// </returns>
        public GetEntityStoreResponse GetEntityStore(string workspaceName, GetEntityStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEntityStoreWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get EntityStore related storage information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreResponse
        /// </returns>
        public async Task<GetEntityStoreResponse> GetEntityStoreAsync(string workspaceName, GetEntityStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEntityStoreWithOptionsAsync(workspaceName, request, headers, runtime);
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
        /// <param name="request">
        /// GetIntegrationPolicyRequest
        /// </param>
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
        public GetIntegrationPolicyResponse GetIntegrationPolicyWithOptions(string policyId, GetIntegrationPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetIntegrationPolicyRequest
        /// </param>
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
        public async Task<GetIntegrationPolicyResponse> GetIntegrationPolicyWithOptionsAsync(string policyId, GetIntegrationPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetIntegrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIntegrationPolicyResponse
        /// </returns>
        public GetIntegrationPolicyResponse GetIntegrationPolicy(string policyId, GetIntegrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIntegrationPolicyWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of access center policies</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntegrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIntegrationPolicyResponse
        /// </returns>
        public async Task<GetIntegrationPolicyResponse> GetIntegrationPolicyAsync(string policyId, GetIntegrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIntegrationPolicyWithOptionsAsync(policyId, request, headers, runtime);
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
        /// <para>查询全部记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoriesResponse
        /// </returns>
        public GetMemoriesResponse GetMemoriesWithOptions(string workspace, string memoryStoreName, GetMemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["runId"] = request.RunId;
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
                Action = "GetMemories",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询全部记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoriesResponse
        /// </returns>
        public async Task<GetMemoriesResponse> GetMemoriesWithOptionsAsync(string workspace, string memoryStoreName, GetMemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["runId"] = request.RunId;
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
                Action = "GetMemories",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询全部记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoriesResponse
        /// </returns>
        public GetMemoriesResponse GetMemories(string workspace, string memoryStoreName, GetMemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoriesWithOptions(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询全部记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoriesResponse
        /// </returns>
        public async Task<GetMemoriesResponse> GetMemoriesAsync(string workspace, string memoryStoreName, GetMemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoriesWithOptionsAsync(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryResponse
        /// </returns>
        public GetMemoryResponse GetMemoryWithOptions(string workspace, string memoryStoreName, string memoryId, GetMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemory",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryResponse
        /// </returns>
        public async Task<GetMemoryResponse> GetMemoryWithOptionsAsync(string workspace, string memoryStoreName, string memoryId, GetMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemory",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryResponse
        /// </returns>
        public GetMemoryResponse GetMemory(string workspace, string memoryStoreName, string memoryId, GetMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoryWithOptions(workspace, memoryStoreName, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryResponse
        /// </returns>
        public async Task<GetMemoryResponse> GetMemoryAsync(string workspace, string memoryStoreName, string memoryId, GetMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoryWithOptionsAsync(workspace, memoryStoreName, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryHistoryResponse
        /// </returns>
        public GetMemoryHistoryResponse GetMemoryHistoryWithOptions(string workspace, string memoryStoreName, string memoryId, GetMemoryHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryHistory",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/history",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryHistoryResponse
        /// </returns>
        public async Task<GetMemoryHistoryResponse> GetMemoryHistoryWithOptionsAsync(string workspace, string memoryStoreName, string memoryId, GetMemoryHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryHistory",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/history",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryHistoryResponse
        /// </returns>
        public GetMemoryHistoryResponse GetMemoryHistory(string workspace, string memoryStoreName, string memoryId, GetMemoryHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoryHistoryWithOptions(workspace, memoryStoreName, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryHistoryResponse
        /// </returns>
        public async Task<GetMemoryHistoryResponse> GetMemoryHistoryAsync(string workspace, string memoryStoreName, string memoryId, GetMemoryHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoryHistoryWithOptionsAsync(workspace, memoryStoreName, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryStoreResponse
        /// </returns>
        public GetMemoryStoreResponse GetMemoryStoreWithOptions(string workspace, string memoryStoreName, GetMemoryStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryStoreResponse
        /// </returns>
        public async Task<GetMemoryStoreResponse> GetMemoryStoreWithOptionsAsync(string workspace, string memoryStoreName, GetMemoryStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryStoreResponse
        /// </returns>
        public GetMemoryStoreResponse GetMemoryStore(string workspace, string memoryStoreName, GetMemoryStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoryStoreWithOptions(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryStoreResponse
        /// </returns>
        public async Task<GetMemoryStoreResponse> GetMemoryStoreAsync(string workspace, string memoryStoreName, GetMemoryStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoryStoreWithOptionsAsync(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineResponse
        /// </returns>
        public GetPipelineResponse GetPipelineWithOptions(string workspace, string pipelineName, GetPipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineResponse
        /// </returns>
        public async Task<GetPipelineResponse> GetPipelineWithOptionsAsync(string workspace, string pipelineName, GetPipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineResponse
        /// </returns>
        public GetPipelineResponse GetPipeline(string workspace, string pipelineName, GetPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineWithOptions(workspace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineResponse
        /// </returns>
        public async Task<GetPipelineResponse> GetPipelineAsync(string workspace, string pipelineName, GetPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineWithOptionsAsync(workspace, pipelineName, request, headers, runtime);
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
        /// <param name="request">
        /// GetServiceRequest
        /// </param>
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
        public GetServiceResponse GetServiceWithOptions(string workspace, string serviceId, GetServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetServiceRequest
        /// </param>
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
        public async Task<GetServiceResponse> GetServiceWithOptionsAsync(string workspace, string serviceId, GetServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceResponse
        /// </returns>
        public GetServiceResponse GetService(string workspace, string serviceId, GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceWithOptions(workspace, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceResponse
        /// </returns>
        public async Task<GetServiceResponse> GetServiceAsync(string workspace, string serviceId, GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceWithOptionsAsync(workspace, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Application Observability Instance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetServiceObservabilityRequest
        /// </param>
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
        public GetServiceObservabilityResponse GetServiceObservabilityWithOptions(string workspace, string type, GetServiceObservabilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetServiceObservabilityRequest
        /// </param>
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
        public async Task<GetServiceObservabilityResponse> GetServiceObservabilityWithOptionsAsync(string workspace, string type, GetServiceObservabilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetServiceObservabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceObservabilityResponse
        /// </returns>
        public GetServiceObservabilityResponse GetServiceObservability(string workspace, string type, GetServiceObservabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceObservabilityWithOptions(workspace, type, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Application Observability Instance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetServiceObservabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceObservabilityResponse
        /// </returns>
        public async Task<GetServiceObservabilityResponse> GetServiceObservabilityAsync(string workspace, string type, GetServiceObservabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceObservabilityWithOptionsAsync(workspace, type, request, headers, runtime);
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
        /// <param name="request">
        /// GetUmodelRequest
        /// </param>
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
        public GetUmodelResponse GetUmodelWithOptions(string workspace, GetUmodelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetUmodelRequest
        /// </param>
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
        public async Task<GetUmodelResponse> GetUmodelWithOptionsAsync(string workspace, GetUmodelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetUmodelRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelResponse
        /// </returns>
        public GetUmodelResponse GetUmodel(string workspace, GetUmodelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUmodelWithOptions(workspace, request, headers, runtime);
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
        /// <param name="request">
        /// GetUmodelRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelResponse
        /// </returns>
        public async Task<GetUmodelResponse> GetUmodelAsync(string workspace, GetUmodelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUmodelWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUmodelCommonSchemaRefRequest
        /// </param>
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
        public GetUmodelCommonSchemaRefResponse GetUmodelCommonSchemaRefWithOptions(string workspace, GetUmodelCommonSchemaRefRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetUmodelCommonSchemaRefRequest
        /// </param>
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
        public async Task<GetUmodelCommonSchemaRefResponse> GetUmodelCommonSchemaRefWithOptionsAsync(string workspace, GetUmodelCommonSchemaRefRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetUmodelCommonSchemaRefRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelCommonSchemaRefResponse
        /// </returns>
        public GetUmodelCommonSchemaRefResponse GetUmodelCommonSchemaRef(string workspace, GetUmodelCommonSchemaRefRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUmodelCommonSchemaRefWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUmodelCommonSchemaRefRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelCommonSchemaRefResponse
        /// </returns>
        public async Task<GetUmodelCommonSchemaRefResponse> GetUmodelCommonSchemaRefAsync(string workspace, GetUmodelCommonSchemaRefRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUmodelCommonSchemaRefWithOptionsAsync(workspace, request, headers, runtime);
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
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
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
        public GetWorkspaceResponse GetWorkspaceWithOptions(string workspaceName, GetWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
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
        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(string workspaceName, GetWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspace(string workspaceName, GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkspaceWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Workspace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(string workspaceName, GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkspaceWithOptionsAsync(workspaceName, request, headers, runtime);
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
        /// <para>查询机器人</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlertRobotsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertRobotsResponse
        /// </returns>
        public ListAlertRobotsResponse ListAlertRobotsWithOptions(ListAlertRobotsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlertRobotsShrinkRequest request = new ListAlertRobotsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RobotIds))
            {
                request.RobotIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RobotIds, "robotIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Types))
            {
                request.TypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Types, "types", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotIdsShrink))
            {
                query["robotIds"] = request.RobotIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypesShrink))
            {
                query["types"] = request.TypesShrink;
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
                Action = "ListAlertRobots",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/robots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertRobotsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询机器人</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlertRobotsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertRobotsResponse
        /// </returns>
        public async Task<ListAlertRobotsResponse> ListAlertRobotsWithOptionsAsync(ListAlertRobotsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlertRobotsShrinkRequest request = new ListAlertRobotsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RobotIds))
            {
                request.RobotIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RobotIds, "robotIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Types))
            {
                request.TypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Types, "types", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotIdsShrink))
            {
                query["robotIds"] = request.RobotIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypesShrink))
            {
                query["types"] = request.TypesShrink;
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
                Action = "ListAlertRobots",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/robots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertRobotsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertRobotsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertRobotsResponse
        /// </returns>
        public ListAlertRobotsResponse ListAlertRobots(ListAlertRobotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAlertRobotsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertRobotsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertRobotsResponse
        /// </returns>
        public async Task<ListAlertRobotsResponse> ListAlertRobotsAsync(ListAlertRobotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAlertRobotsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Webhook</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlertWebhooksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertWebhooksResponse
        /// </returns>
        public ListAlertWebhooksResponse ListAlertWebhooksWithOptions(ListAlertWebhooksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlertWebhooksShrinkRequest request = new ListAlertWebhooksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WebhookIds))
            {
                request.WebhookIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WebhookIds, "webhookIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookIdsShrink))
            {
                query["webhookIds"] = request.WebhookIdsShrink;
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
                Action = "ListAlertWebhooks",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/webhooks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertWebhooksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Webhook</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlertWebhooksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertWebhooksResponse
        /// </returns>
        public async Task<ListAlertWebhooksResponse> ListAlertWebhooksWithOptionsAsync(ListAlertWebhooksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlertWebhooksShrinkRequest request = new ListAlertWebhooksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WebhookIds))
            {
                request.WebhookIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WebhookIds, "webhookIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookIdsShrink))
            {
                query["webhookIds"] = request.WebhookIdsShrink;
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
                Action = "ListAlertWebhooks",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/webhooks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertWebhooksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Webhook</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertWebhooksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertWebhooksResponse
        /// </returns>
        public ListAlertWebhooksResponse ListAlertWebhooks(ListAlertWebhooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAlertWebhooksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Webhook</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertWebhooksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertWebhooksResponse
        /// </returns>
        public async Task<ListAlertWebhooksResponse> ListAlertWebhooksAsync(ListAlertWebhooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAlertWebhooksWithOptionsAsync(request, headers, runtime);
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
        /// <para>查询联系人组</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListContactGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContactGroupsResponse
        /// </returns>
        public ListContactGroupsResponse ListContactGroupsWithOptions(ListContactGroupsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListContactGroupsShrinkRequest request = new ListContactGroupsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactGroupIds))
            {
                request.ContactGroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactGroupIds, "contactGroupIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupIdsShrink))
            {
                query["contactGroupIds"] = request.ContactGroupIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListContactGroups",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/contactGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人组</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListContactGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContactGroupsResponse
        /// </returns>
        public async Task<ListContactGroupsResponse> ListContactGroupsWithOptionsAsync(ListContactGroupsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListContactGroupsShrinkRequest request = new ListContactGroupsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactGroupIds))
            {
                request.ContactGroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactGroupIds, "contactGroupIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupIdsShrink))
            {
                query["contactGroupIds"] = request.ContactGroupIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListContactGroups",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/contactGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContactGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContactGroupsResponse
        /// </returns>
        public ListContactGroupsResponse ListContactGroups(ListContactGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListContactGroupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContactGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContactGroupsResponse
        /// </returns>
        public async Task<ListContactGroupsResponse> ListContactGroupsAsync(ListContactGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListContactGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListContactsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContactsResponse
        /// </returns>
        public ListContactsResponse ListContactsWithOptions(ListContactsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListContactsShrinkRequest request = new ListContactsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactIds))
            {
                request.ContactIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactIds, "contactIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactIdsShrink))
            {
                query["contactIds"] = request.ContactIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryUngroupedContacts))
            {
                query["queryUngroupedContacts"] = request.QueryUngroupedContacts;
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
                Action = "ListContacts",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/contact",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListContactsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContactsResponse
        /// </returns>
        public async Task<ListContactsResponse> ListContactsWithOptionsAsync(ListContactsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListContactsShrinkRequest request = new ListContactsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactIds))
            {
                request.ContactIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactIds, "contactIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactIdsShrink))
            {
                query["contactIds"] = request.ContactIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryUngroupedContacts))
            {
                query["queryUngroupedContacts"] = request.QueryUngroupedContacts;
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
                Action = "ListContacts",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/contact",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContactsResponse
        /// </returns>
        public ListContactsResponse ListContacts(ListContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListContactsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContactsResponse
        /// </returns>
        public async Task<ListContactsResponse> ListContactsAsync(ListContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListContactsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public ListDatasetsResponse ListDatasetsWithOptions(string workspace, ListDatasetsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["datasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasets",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/dataset",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public async Task<ListDatasetsResponse> ListDatasetsWithOptionsAsync(string workspace, ListDatasetsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["datasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasets",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/dataset",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public ListDatasetsResponse ListDatasets(string workspace, ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatasetsWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public async Task<ListDatasetsResponse> ListDatasetsAsync(string workspace, ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatasetsWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据投递任务列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDeliveryTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeliveryTasksResponse
        /// </returns>
        public ListDeliveryTasksResponse ListDeliveryTasksWithOptions(ListDeliveryTasksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDeliveryTasksShrinkRequest request = new ListDeliveryTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                query["keyWords"] = request.KeyWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeliveryTasks",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/delivery-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeliveryTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据投递任务列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDeliveryTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeliveryTasksResponse
        /// </returns>
        public async Task<ListDeliveryTasksResponse> ListDeliveryTasksWithOptionsAsync(ListDeliveryTasksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDeliveryTasksShrinkRequest request = new ListDeliveryTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                query["keyWords"] = request.KeyWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeliveryTasks",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/delivery-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeliveryTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据投递任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeliveryTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeliveryTasksResponse
        /// </returns>
        public ListDeliveryTasksResponse ListDeliveryTasks(ListDeliveryTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDeliveryTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据投递任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeliveryTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeliveryTasksResponse
        /// </returns>
        public async Task<ListDeliveryTasksResponse> ListDeliveryTasksAsync(ListDeliveryTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDeliveryTasksWithOptionsAsync(request, headers, runtime);
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
        /// <param name="request">
        /// ListIntegrationPolicyAddonsRequest
        /// </param>
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
        public ListIntegrationPolicyAddonsResponse ListIntegrationPolicyAddonsWithOptions(string policyId, ListIntegrationPolicyAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// ListIntegrationPolicyAddonsRequest
        /// </param>
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
        public async Task<ListIntegrationPolicyAddonsResponse> ListIntegrationPolicyAddonsWithOptionsAsync(string policyId, ListIntegrationPolicyAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
        /// <param name="request">
        /// ListIntegrationPolicyAddonsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyAddonsResponse
        /// </returns>
        public ListIntegrationPolicyAddonsResponse ListIntegrationPolicyAddons(string policyId, ListIntegrationPolicyAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIntegrationPolicyAddonsWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>策略addon列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntegrationPolicyAddonsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntegrationPolicyAddonsResponse
        /// </returns>
        public async Task<ListIntegrationPolicyAddonsResponse> ListIntegrationPolicyAddonsAsync(string policyId, ListIntegrationPolicyAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIntegrationPolicyAddonsWithOptionsAsync(policyId, request, headers, runtime);
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
        /// <para>查询记忆库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemoryStoresRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemoryStoresResponse
        /// </returns>
        public ListMemoryStoresResponse ListMemoryStoresWithOptions(string workspace, ListMemoryStoresRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryStoreName))
            {
                query["memoryStoreName"] = request.MemoryStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMemoryStores",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemoryStoresResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemoryStoresRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemoryStoresResponse
        /// </returns>
        public async Task<ListMemoryStoresResponse> ListMemoryStoresWithOptionsAsync(string workspace, ListMemoryStoresRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryStoreName))
            {
                query["memoryStoreName"] = request.MemoryStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMemoryStores",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemoryStoresResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemoryStoresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemoryStoresResponse
        /// </returns>
        public ListMemoryStoresResponse ListMemoryStores(string workspace, ListMemoryStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMemoryStoresWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemoryStoresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemoryStoresResponse
        /// </returns>
        public async Task<ListMemoryStoresResponse> ListMemoryStoresAsync(string workspace, ListMemoryStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMemoryStoresWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelinesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPipelinesResponse
        /// </returns>
        public ListPipelinesResponse ListPipelinesWithOptions(string workspace, ListPipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                query["pipelineName"] = request.PipelineName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelines",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/pipeline",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelinesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelinesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPipelinesResponse
        /// </returns>
        public async Task<ListPipelinesResponse> ListPipelinesWithOptionsAsync(string workspace, ListPipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                query["pipelineName"] = request.PipelineName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelines",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/pipeline",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelinesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPipelinesResponse
        /// </returns>
        public ListPipelinesResponse ListPipelines(string workspace, ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelinesWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelinesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPipelinesResponse
        /// </returns>
        public async Task<ListPipelinesResponse> ListPipelinesAsync(string workspace, ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelinesWithOptionsAsync(workspace, request, headers, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
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
        /// <param name="tmpReq">
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
        public ListServicesResponse ListServicesWithOptions(string workspace, ListServicesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListServicesShrinkRequest request = new ListServicesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
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
        /// <param name="tmpReq">
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
        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(string workspace, ListServicesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListServicesShrinkRequest request = new ListServicesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
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
        /// <para>查标签接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查标签接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
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
        /// <para>管理告警规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ManageAlertRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ManageAlertRulesResponse
        /// </returns>
        public ManageAlertRulesResponse ManageAlertRulesWithOptions(ManageAlertRulesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ManageAlertRulesShrinkRequest request = new ManageAlertRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManageAlertRules",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/manageAlertRules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManageAlertRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管理告警规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ManageAlertRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ManageAlertRulesResponse
        /// </returns>
        public async Task<ManageAlertRulesResponse> ManageAlertRulesWithOptionsAsync(ManageAlertRulesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ManageAlertRulesShrinkRequest request = new ManageAlertRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManageAlertRules",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/manageAlertRules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManageAlertRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管理告警规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManageAlertRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ManageAlertRulesResponse
        /// </returns>
        public ManageAlertRulesResponse ManageAlertRules(ManageAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ManageAlertRulesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管理告警规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManageAlertRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ManageAlertRulesResponse
        /// </returns>
        public async Task<ManageAlertRulesResponse> ManageAlertRulesAsync(ManageAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ManageAlertRulesWithOptionsAsync(request, headers, runtime);
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
        /// <para>查询告警规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryAlertRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAlertRulesResponse
        /// </returns>
        public QueryAlertRulesResponse QueryAlertRulesWithOptions(QueryAlertRulesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryAlertRulesShrinkRequest request = new QueryAlertRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAlertRules",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/queryAlertRules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAlertRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询告警规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryAlertRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAlertRulesResponse
        /// </returns>
        public async Task<QueryAlertRulesResponse> QueryAlertRulesWithOptionsAsync(QueryAlertRulesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryAlertRulesShrinkRequest request = new QueryAlertRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAlertRules",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/queryAlertRules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAlertRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询告警规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAlertRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAlertRulesResponse
        /// </returns>
        public QueryAlertRulesResponse QueryAlertRules(QueryAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryAlertRulesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询告警规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAlertRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAlertRulesResponse
        /// </returns>
        public async Task<QueryAlertRulesResponse> QueryAlertRulesAsync(QueryAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryAlertRulesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchMemoriesResponse
        /// </returns>
        public SearchMemoriesResponse SearchMemoriesWithOptions(string workspace, string memoryStoreName, SearchMemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rerank))
            {
                body["rerank"] = request.Rerank;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrievalOption))
            {
                body["retrievalOption"] = request.RetrievalOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["runId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                body["searchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                body["threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
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
                Action = "SearchMemories",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMemoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchMemoriesResponse
        /// </returns>
        public async Task<SearchMemoriesResponse> SearchMemoriesWithOptionsAsync(string workspace, string memoryStoreName, SearchMemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rerank))
            {
                body["rerank"] = request.Rerank;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrievalOption))
            {
                body["retrievalOption"] = request.RetrievalOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["runId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                body["searchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                body["threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
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
                Action = "SearchMemories",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMemoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchMemoriesResponse
        /// </returns>
        public SearchMemoriesResponse SearchMemories(string workspace, string memoryStoreName, SearchMemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchMemoriesWithOptions(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchMemoriesResponse
        /// </returns>
        public async Task<SearchMemoriesResponse> SearchMemoriesAsync(string workspace, string memoryStoreName, SearchMemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchMemoriesWithOptionsAsync(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删标签接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKey))
            {
                request.TagKeyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKey, "tagKey", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyShrink))
            {
                query["tagKey"] = request.TagKeyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删标签接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKey))
            {
                request.TagKeyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKey, "tagKey", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyShrink))
            {
                query["tagKey"] = request.TagKeyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
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
        /// <para>修改已存在的告警 Webhook 通知配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlertWebhookRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertWebhookResponse
        /// </returns>
        public UpdateAlertWebhookResponse UpdateAlertWebhookWithOptions(string webhookId, UpdateAlertWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Headers))
            {
                body["headers"] = request.Headers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlertWebhook",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/webhook/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(webhookId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlertWebhookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改已存在的告警 Webhook 通知配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlertWebhookRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertWebhookResponse
        /// </returns>
        public async Task<UpdateAlertWebhookResponse> UpdateAlertWebhookWithOptionsAsync(string webhookId, UpdateAlertWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Headers))
            {
                body["headers"] = request.Headers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlertWebhook",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/webhook/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(webhookId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlertWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改已存在的告警 Webhook 通知配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlertWebhookRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertWebhookResponse
        /// </returns>
        public UpdateAlertWebhookResponse UpdateAlertWebhook(string webhookId, UpdateAlertWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAlertWebhookWithOptions(webhookId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改已存在的告警 Webhook 通知配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlertWebhookRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertWebhookResponse
        /// </returns>
        public async Task<UpdateAlertWebhookResponse> UpdateAlertWebhookAsync(string webhookId, UpdateAlertWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAlertWebhookWithOptionsAsync(webhookId, request, headers, runtime);
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
        /// <para>更新数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public UpdateDatasetResponse UpdateDatasetWithOptions(string workspace, string datasetName, UpdateDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateDataset",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public async Task<UpdateDatasetResponse> UpdateDatasetWithOptionsAsync(string workspace, string datasetName, UpdateDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateDataset",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public UpdateDatasetResponse UpdateDataset(string workspace, string datasetName, UpdateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDatasetWithOptions(workspace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public async Task<UpdateDatasetResponse> UpdateDatasetAsync(string workspace, string datasetName, UpdateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDatasetWithOptionsAsync(workspace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeliveryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeliveryTaskResponse
        /// </returns>
        public UpdateDeliveryTaskResponse UpdateDeliveryTaskWithOptions(string taskId, UpdateDeliveryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalLabels))
            {
                body["externalLabels"] = request.ExternalLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelFilters))
            {
                body["labelFilters"] = request.LabelFilters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelFiltersType))
            {
                body["labelFiltersType"] = request.LabelFiltersType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkList))
            {
                body["sinkList"] = request.SinkList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeliveryTask",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/delivery-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeliveryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeliveryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeliveryTaskResponse
        /// </returns>
        public async Task<UpdateDeliveryTaskResponse> UpdateDeliveryTaskWithOptionsAsync(string taskId, UpdateDeliveryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalLabels))
            {
                body["externalLabels"] = request.ExternalLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelFilters))
            {
                body["labelFilters"] = request.LabelFilters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelFiltersType))
            {
                body["labelFiltersType"] = request.LabelFiltersType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkList))
            {
                body["sinkList"] = request.SinkList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeliveryTask",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/delivery-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeliveryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeliveryTaskResponse
        /// </returns>
        public UpdateDeliveryTaskResponse UpdateDeliveryTask(string taskId, UpdateDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDeliveryTaskWithOptions(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeliveryTaskResponse
        /// </returns>
        public async Task<UpdateDeliveryTaskResponse> UpdateDeliveryTaskAsync(string taskId, UpdateDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDeliveryTaskWithOptionsAsync(taskId, request, headers, runtime);
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
        /// <para>修改记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryResponse
        /// </returns>
        public UpdateMemoryResponse UpdateMemoryWithOptions(string workspace, string memoryStoreName, string memoryId, UpdateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemory",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryResponse
        /// </returns>
        public async Task<UpdateMemoryResponse> UpdateMemoryWithOptionsAsync(string workspace, string memoryStoreName, string memoryId, UpdateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemory",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName) + "/memory/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryResponse
        /// </returns>
        public UpdateMemoryResponse UpdateMemory(string workspace, string memoryStoreName, string memoryId, UpdateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMemoryWithOptions(workspace, memoryStoreName, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryResponse
        /// </returns>
        public async Task<UpdateMemoryResponse> UpdateMemoryAsync(string workspace, string memoryStoreName, string memoryId, UpdateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMemoryWithOptionsAsync(workspace, memoryStoreName, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改记忆库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryStoreResponse
        /// </returns>
        public UpdateMemoryStoreResponse UpdateMemoryStoreWithOptions(string workspace, string memoryStoreName, UpdateMemoryStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomExtractionStrategies))
            {
                body["customExtractionStrategies"] = request.CustomExtractionStrategies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractionStrategies))
            {
                body["extractionStrategies"] = request.ExtractionStrategies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortTermTtl))
            {
                body["shortTermTtl"] = request.ShortTermTtl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemoryStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改记忆库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryStoreResponse
        /// </returns>
        public async Task<UpdateMemoryStoreResponse> UpdateMemoryStoreWithOptionsAsync(string workspace, string memoryStoreName, UpdateMemoryStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomExtractionStrategies))
            {
                body["customExtractionStrategies"] = request.CustomExtractionStrategies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractionStrategies))
            {
                body["extractionStrategies"] = request.ExtractionStrategies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortTermTtl))
            {
                body["shortTermTtl"] = request.ShortTermTtl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemoryStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/memorystore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryStoreName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改记忆库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryStoreResponse
        /// </returns>
        public UpdateMemoryStoreResponse UpdateMemoryStore(string workspace, string memoryStoreName, UpdateMemoryStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMemoryStoreWithOptions(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改记忆库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryStoreResponse
        /// </returns>
        public async Task<UpdateMemoryStoreResponse> UpdateMemoryStoreAsync(string workspace, string memoryStoreName, UpdateMemoryStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMemoryStoreWithOptionsAsync(workspace, memoryStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改已存在的告警通知策略</para>
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
        /// <para>修改已存在的告警通知策略</para>
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
        /// <para>修改已存在的告警通知策略</para>
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
        /// <para>修改已存在的告警通知策略</para>
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
        /// <para>更新流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePipelineResponse
        /// </returns>
        public UpdatePipelineResponse UpdatePipelineWithOptions(string workspace, string pipelineName, UpdatePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutePolicy))
            {
                body["executePolicy"] = request.ExecutePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pipeline))
            {
                body["pipeline"] = request.Pipeline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sink))
            {
                body["sink"] = request.Sink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePipeline",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePipelineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePipelineResponse
        /// </returns>
        public async Task<UpdatePipelineResponse> UpdatePipelineWithOptionsAsync(string workspace, string pipelineName, UpdatePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutePolicy))
            {
                body["executePolicy"] = request.ExecutePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pipeline))
            {
                body["pipeline"] = request.Pipeline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sink))
            {
                body["sink"] = request.Sink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePipeline",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePipelineResponse
        /// </returns>
        public UpdatePipelineResponse UpdatePipeline(string workspace, string pipelineName, UpdatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePipelineWithOptions(workspace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePipelineResponse
        /// </returns>
        public async Task<UpdatePipelineResponse> UpdatePipelineAsync(string workspace, string pipelineName, UpdatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePipelineWithOptionsAsync(workspace, pipelineName, request, headers, runtime);
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
        /// <para>更新一个已存在的订阅配置</para>
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
        /// <para>更新一个已存在的订阅配置</para>
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
        /// <para>更新一个已存在的订阅配置</para>
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
        /// <para>更新一个已存在的订阅配置</para>
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
