// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OutboundBot20191226.Models;

namespace AlibabaCloud.SDK.OutboundBot20191226
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("outboundbot", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignJobsResponse
        /// </returns>
        public AssignJobsResponse AssignJobsWithOptions(AssignJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsynchrony))
            {
                query["IsAsynchrony"] = request.IsAsynchrony;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobDataParsingTaskId))
            {
                query["JobDataParsingTaskId"] = request.JobDataParsingTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobsJson))
            {
                query["JobsJson"] = request.JobsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RosterType))
            {
                query["RosterType"] = request.RosterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                query["StrategyJson"] = request.StrategyJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignJobsResponse
        /// </returns>
        public async Task<AssignJobsResponse> AssignJobsWithOptionsAsync(AssignJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsynchrony))
            {
                query["IsAsynchrony"] = request.IsAsynchrony;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobDataParsingTaskId))
            {
                query["JobDataParsingTaskId"] = request.JobDataParsingTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobsJson))
            {
                query["JobsJson"] = request.JobsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RosterType))
            {
                query["RosterType"] = request.RosterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                query["StrategyJson"] = request.StrategyJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignJobsResponse
        /// </returns>
        public AssignJobsResponse AssignJobs(AssignJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignJobsResponse
        /// </returns>
        public async Task<AssignJobsResponse> AssignJobsAsync(AssignJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步创建外呼任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AssignJobsAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignJobsAsyncResponse
        /// </returns>
        public AssignJobsAsyncResponse AssignJobsAsyncWithOptions(AssignJobsAsyncRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AssignJobsAsyncShrinkRequest request = new AssignJobsAsyncShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CallingNumber))
            {
                request.CallingNumberShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CallingNumber, "CallingNumber", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobsJson))
            {
                request.JobsJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobsJson, "JobsJson", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumberShrink))
            {
                body["CallingNumber"] = request.CallingNumberShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                body["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobsJsonShrink))
            {
                body["JobsJson"] = request.JobsJsonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                body["StrategyJson"] = request.StrategyJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignJobsAsync",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignJobsAsyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步创建外呼任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AssignJobsAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignJobsAsyncResponse
        /// </returns>
        public async Task<AssignJobsAsyncResponse> AssignJobsAsyncWithOptionsAsync(AssignJobsAsyncRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AssignJobsAsyncShrinkRequest request = new AssignJobsAsyncShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CallingNumber))
            {
                request.CallingNumberShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CallingNumber, "CallingNumber", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobsJson))
            {
                request.JobsJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobsJson, "JobsJson", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumberShrink))
            {
                body["CallingNumber"] = request.CallingNumberShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                body["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobsJsonShrink))
            {
                body["JobsJson"] = request.JobsJsonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                body["StrategyJson"] = request.StrategyJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignJobsAsync",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignJobsAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步创建外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignJobsAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignJobsAsyncResponse
        /// </returns>
        public AssignJobsAsyncResponse AssignJobsAsync(AssignJobsAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignJobsAsyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步创建外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignJobsAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignJobsAsyncResponse
        /// </returns>
        public async Task<AssignJobsAsyncResponse> AssignJobsAsyncAsync(AssignJobsAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignJobsAsyncWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CancelJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelJobsResponse
        /// </returns>
        public CancelJobsResponse CancelJobsWithOptions(CancelJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobReferenceId))
            {
                query["JobReferenceId"] = request.JobReferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CancelJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelJobsResponse
        /// </returns>
        public async Task<CancelJobsResponse> CancelJobsWithOptionsAsync(CancelJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobReferenceId))
            {
                query["JobReferenceId"] = request.JobReferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CancelJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelJobsResponse
        /// </returns>
        public CancelJobsResponse CancelJobs(CancelJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelJobsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CancelJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelJobsResponse
        /// </returns>
        public async Task<CancelJobsResponse> CancelJobsAsync(CancelJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelJobsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

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
            return ChangeResourceGroupWithOptions(request, runtime);
        }

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
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateAgentProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentProfileResponse
        /// </returns>
        public CreateAgentProfileResponse CreateAgentProfileWithOptions(CreateAgentProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProfileTemplateId))
            {
                body["AgentProfileTemplateId"] = request.AgentProfileTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIp))
            {
                body["AppIp"] = request.AppIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaqCategoryIds))
            {
                body["FaqCategoryIds"] = request.FaqCategoryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstructionJson))
            {
                body["InstructionJson"] = request.InstructionJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsJson))
            {
                body["LabelsJson"] = request.LabelsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfig))
            {
                body["ModelConfig"] = request.ModelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptJson))
            {
                body["PromptJson"] = request.PromptJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["Scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                body["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VariablesJson))
            {
                body["VariablesJson"] = request.VariablesJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentProfile",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentProfileResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateAgentProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentProfileResponse
        /// </returns>
        public async Task<CreateAgentProfileResponse> CreateAgentProfileWithOptionsAsync(CreateAgentProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProfileTemplateId))
            {
                body["AgentProfileTemplateId"] = request.AgentProfileTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIp))
            {
                body["AppIp"] = request.AppIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaqCategoryIds))
            {
                body["FaqCategoryIds"] = request.FaqCategoryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstructionJson))
            {
                body["InstructionJson"] = request.InstructionJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsJson))
            {
                body["LabelsJson"] = request.LabelsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfig))
            {
                body["ModelConfig"] = request.ModelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptJson))
            {
                body["PromptJson"] = request.PromptJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["Scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                body["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VariablesJson))
            {
                body["VariablesJson"] = request.VariablesJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentProfile",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateAgentProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentProfileResponse
        /// </returns>
        public CreateAgentProfileResponse CreateAgentProfile(CreateAgentProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAgentProfileWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateAgentProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentProfileResponse
        /// </returns>
        public async Task<CreateAgentProfileResponse> CreateAgentProfileAsync(CreateAgentProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAgentProfileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建标注任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAnnotationMissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAnnotationMissionResponse
        /// </returns>
        public CreateAnnotationMissionResponse CreateAnnotationMissionWithOptions(CreateAnnotationMissionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAnnotationMissionShrinkRequest request = new CreateAnnotationMissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AnnotationMissionDebugDataSourceList))
            {
                request.AnnotationMissionDebugDataSourceListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AnnotationMissionDebugDataSourceList, "AnnotationMissionDebugDataSourceList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionDataSourceType))
            {
                query["AnnotationMissionDataSourceType"] = request.AnnotationMissionDataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionDebugDataSourceListShrink))
            {
                query["AnnotationMissionDebugDataSourceList"] = request.AnnotationMissionDebugDataSourceListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionDebugDataSourceListJsonString))
            {
                query["AnnotationMissionDebugDataSourceListJsonString"] = request.AnnotationMissionDebugDataSourceListJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionName))
            {
                query["AnnotationMissionName"] = request.AnnotationMissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                query["ChatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationTimeEndFilter))
            {
                query["ConversationTimeEndFilter"] = request.ConversationTimeEndFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationTimeStartFilter))
            {
                query["ConversationTimeStartFilter"] = request.ConversationTimeStartFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeOtherSession))
            {
                query["ExcludeOtherSession"] = request.ExcludeOtherSession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Finished))
            {
                query["Finished"] = request.Finished;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingCount))
            {
                query["SamplingCount"] = request.SamplingCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingRate))
            {
                query["SamplingRate"] = request.SamplingRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingType))
            {
                query["SamplingType"] = request.SamplingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionEndReasonFilterList))
            {
                query["SessionEndReasonFilterList"] = request.SessionEndReasonFilterList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionEndReasonFilterListJsonString))
            {
                query["SessionEndReasonFilterListJsonString"] = request.SessionEndReasonFilterListJsonString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAnnotationMission",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAnnotationMissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建标注任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAnnotationMissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAnnotationMissionResponse
        /// </returns>
        public async Task<CreateAnnotationMissionResponse> CreateAnnotationMissionWithOptionsAsync(CreateAnnotationMissionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAnnotationMissionShrinkRequest request = new CreateAnnotationMissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AnnotationMissionDebugDataSourceList))
            {
                request.AnnotationMissionDebugDataSourceListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AnnotationMissionDebugDataSourceList, "AnnotationMissionDebugDataSourceList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionDataSourceType))
            {
                query["AnnotationMissionDataSourceType"] = request.AnnotationMissionDataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionDebugDataSourceListShrink))
            {
                query["AnnotationMissionDebugDataSourceList"] = request.AnnotationMissionDebugDataSourceListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionDebugDataSourceListJsonString))
            {
                query["AnnotationMissionDebugDataSourceListJsonString"] = request.AnnotationMissionDebugDataSourceListJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionName))
            {
                query["AnnotationMissionName"] = request.AnnotationMissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                query["ChatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationTimeEndFilter))
            {
                query["ConversationTimeEndFilter"] = request.ConversationTimeEndFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationTimeStartFilter))
            {
                query["ConversationTimeStartFilter"] = request.ConversationTimeStartFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeOtherSession))
            {
                query["ExcludeOtherSession"] = request.ExcludeOtherSession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Finished))
            {
                query["Finished"] = request.Finished;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingCount))
            {
                query["SamplingCount"] = request.SamplingCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingRate))
            {
                query["SamplingRate"] = request.SamplingRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingType))
            {
                query["SamplingType"] = request.SamplingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionEndReasonFilterList))
            {
                query["SessionEndReasonFilterList"] = request.SessionEndReasonFilterList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionEndReasonFilterListJsonString))
            {
                query["SessionEndReasonFilterListJsonString"] = request.SessionEndReasonFilterListJsonString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAnnotationMission",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAnnotationMissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建标注任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAnnotationMissionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAnnotationMissionResponse
        /// </returns>
        public CreateAnnotationMissionResponse CreateAnnotationMission(CreateAnnotationMissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAnnotationMissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建标注任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAnnotationMissionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAnnotationMissionResponse
        /// </returns>
        public async Task<CreateAnnotationMissionResponse> CreateAnnotationMissionAsync(CreateAnnotationMissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAnnotationMissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBatchJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBatchJobsResponse
        /// </returns>
        public CreateBatchJobsResponse CreateBatchJobsWithOptions(CreateBatchJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchJobDescription))
            {
                query["BatchJobDescription"] = request.BatchJobDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchJobName))
            {
                query["BatchJobName"] = request.BatchJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobFilePath))
            {
                query["JobFilePath"] = request.JobFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                query["StrategyJson"] = request.StrategyJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Submitted))
            {
                query["Submitted"] = request.Submitted;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBatchJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBatchJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBatchJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBatchJobsResponse
        /// </returns>
        public async Task<CreateBatchJobsResponse> CreateBatchJobsWithOptionsAsync(CreateBatchJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchJobDescription))
            {
                query["BatchJobDescription"] = request.BatchJobDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchJobName))
            {
                query["BatchJobName"] = request.BatchJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobFilePath))
            {
                query["JobFilePath"] = request.JobFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                query["StrategyJson"] = request.StrategyJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Submitted))
            {
                query["Submitted"] = request.Submitted;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBatchJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBatchJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBatchJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBatchJobsResponse
        /// </returns>
        public CreateBatchJobsResponse CreateBatchJobs(CreateBatchJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBatchJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBatchJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBatchJobsResponse
        /// </returns>
        public async Task<CreateBatchJobsResponse> CreateBatchJobsAsync(CreateBatchJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBatchJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBatchRepeatJob</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBatchRepeatJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBatchRepeatJobResponse
        /// </returns>
        public CreateBatchRepeatJobResponse CreateBatchRepeatJobWithOptions(CreateBatchRepeatJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterStatus))
            {
                query["FilterStatus"] = request.FilterStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsExtras))
            {
                query["FlashSmsExtras"] = request.FlashSmsExtras;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinConcurrency))
            {
                query["MinConcurrency"] = request.MinConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallCallingNumber))
            {
                query["RecallCallingNumber"] = request.RecallCallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallStrategyJson))
            {
                query["RecallStrategyJson"] = request.RecallStrategyJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingingDuration))
            {
                query["RingingDuration"] = request.RingingDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceGroupId))
            {
                query["SourceGroupId"] = request.SourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                query["StrategyJson"] = request.StrategyJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBatchRepeatJob",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBatchRepeatJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBatchRepeatJob</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBatchRepeatJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBatchRepeatJobResponse
        /// </returns>
        public async Task<CreateBatchRepeatJobResponse> CreateBatchRepeatJobWithOptionsAsync(CreateBatchRepeatJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterStatus))
            {
                query["FilterStatus"] = request.FilterStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsExtras))
            {
                query["FlashSmsExtras"] = request.FlashSmsExtras;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinConcurrency))
            {
                query["MinConcurrency"] = request.MinConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallCallingNumber))
            {
                query["RecallCallingNumber"] = request.RecallCallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallStrategyJson))
            {
                query["RecallStrategyJson"] = request.RecallStrategyJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingingDuration))
            {
                query["RingingDuration"] = request.RingingDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceGroupId))
            {
                query["SourceGroupId"] = request.SourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                query["StrategyJson"] = request.StrategyJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBatchRepeatJob",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBatchRepeatJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBatchRepeatJob</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBatchRepeatJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBatchRepeatJobResponse
        /// </returns>
        public CreateBatchRepeatJobResponse CreateBatchRepeatJob(CreateBatchRepeatJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBatchRepeatJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBatchRepeatJob</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBatchRepeatJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBatchRepeatJobResponse
        /// </returns>
        public async Task<CreateBatchRepeatJobResponse> CreateBatchRepeatJobAsync(CreateBatchRepeatJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBatchRepeatJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBeebotIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBeebotIntentResponse
        /// </returns>
        public CreateBeebotIntentResponse CreateBeebotIntentWithOptions(CreateBeebotIntentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBeebotIntentShrinkRequest request = new CreateBeebotIntentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IntentDefinition))
            {
                request.IntentDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IntentDefinition, "IntentDefinition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentDefinitionShrink))
            {
                query["IntentDefinition"] = request.IntentDefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBeebotIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBeebotIntentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBeebotIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBeebotIntentResponse
        /// </returns>
        public async Task<CreateBeebotIntentResponse> CreateBeebotIntentWithOptionsAsync(CreateBeebotIntentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBeebotIntentShrinkRequest request = new CreateBeebotIntentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IntentDefinition))
            {
                request.IntentDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IntentDefinition, "IntentDefinition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentDefinitionShrink))
            {
                query["IntentDefinition"] = request.IntentDefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBeebotIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBeebotIntentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBeebotIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBeebotIntentResponse
        /// </returns>
        public CreateBeebotIntentResponse CreateBeebotIntent(CreateBeebotIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBeebotIntentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBeebotIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBeebotIntentResponse
        /// </returns>
        public async Task<CreateBeebotIntentResponse> CreateBeebotIntentAsync(CreateBeebotIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBeebotIntentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBeebotIntentLgfRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBeebotIntentLgfResponse
        /// </returns>
        public CreateBeebotIntentLgfResponse CreateBeebotIntentLgfWithOptions(CreateBeebotIntentLgfRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBeebotIntentLgfShrinkRequest request = new CreateBeebotIntentLgfShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LgfDefinition))
            {
                request.LgfDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LgfDefinition, "LgfDefinition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LgfDefinitionShrink))
            {
                query["LgfDefinition"] = request.LgfDefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBeebotIntentLgf",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBeebotIntentLgfResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBeebotIntentLgfRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBeebotIntentLgfResponse
        /// </returns>
        public async Task<CreateBeebotIntentLgfResponse> CreateBeebotIntentLgfWithOptionsAsync(CreateBeebotIntentLgfRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBeebotIntentLgfShrinkRequest request = new CreateBeebotIntentLgfShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LgfDefinition))
            {
                request.LgfDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LgfDefinition, "LgfDefinition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LgfDefinitionShrink))
            {
                query["LgfDefinition"] = request.LgfDefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBeebotIntentLgf",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBeebotIntentLgfResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBeebotIntentLgfRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBeebotIntentLgfResponse
        /// </returns>
        public CreateBeebotIntentLgfResponse CreateBeebotIntentLgf(CreateBeebotIntentLgfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBeebotIntentLgfWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBeebotIntentLgfRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBeebotIntentLgfResponse
        /// </returns>
        public async Task<CreateBeebotIntentLgfResponse> CreateBeebotIntentLgfAsync(CreateBeebotIntentLgfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBeebotIntentLgfWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBeebotIntentUserSayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBeebotIntentUserSayResponse
        /// </returns>
        public CreateBeebotIntentUserSayResponse CreateBeebotIntentUserSayWithOptions(CreateBeebotIntentUserSayRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBeebotIntentUserSayShrinkRequest request = new CreateBeebotIntentUserSayShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserSayDefinition))
            {
                request.UserSayDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserSayDefinition, "UserSayDefinition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSayDefinitionShrink))
            {
                query["UserSayDefinition"] = request.UserSayDefinitionShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBeebotIntentUserSay",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBeebotIntentUserSayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBeebotIntentUserSayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBeebotIntentUserSayResponse
        /// </returns>
        public async Task<CreateBeebotIntentUserSayResponse> CreateBeebotIntentUserSayWithOptionsAsync(CreateBeebotIntentUserSayRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBeebotIntentUserSayShrinkRequest request = new CreateBeebotIntentUserSayShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserSayDefinition))
            {
                request.UserSayDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserSayDefinition, "UserSayDefinition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSayDefinitionShrink))
            {
                query["UserSayDefinition"] = request.UserSayDefinitionShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBeebotIntentUserSay",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBeebotIntentUserSayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBeebotIntentUserSayRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBeebotIntentUserSayResponse
        /// </returns>
        public CreateBeebotIntentUserSayResponse CreateBeebotIntentUserSay(CreateBeebotIntentUserSayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBeebotIntentUserSayWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBeebotIntentUserSayRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBeebotIntentUserSayResponse
        /// </returns>
        public async Task<CreateBeebotIntentUserSayResponse> CreateBeebotIntentUserSayAsync(CreateBeebotIntentUserSayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBeebotIntentUserSayWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateDialogueFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDialogueFlowResponse
        /// </returns>
        public CreateDialogueFlowResponse CreateDialogueFlowWithOptions(CreateDialogueFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueFlowType))
            {
                query["DialogueFlowType"] = request.DialogueFlowType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueName))
            {
                query["DialogueName"] = request.DialogueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDialogueFlow",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDialogueFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateDialogueFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDialogueFlowResponse
        /// </returns>
        public async Task<CreateDialogueFlowResponse> CreateDialogueFlowWithOptionsAsync(CreateDialogueFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueFlowType))
            {
                query["DialogueFlowType"] = request.DialogueFlowType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueName))
            {
                query["DialogueName"] = request.DialogueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDialogueFlow",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDialogueFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateDialogueFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDialogueFlowResponse
        /// </returns>
        public CreateDialogueFlowResponse CreateDialogueFlow(CreateDialogueFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDialogueFlowWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateDialogueFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDialogueFlowResponse
        /// </returns>
        public async Task<CreateDialogueFlowResponse> CreateDialogueFlowAsync(CreateDialogueFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDialogueFlowWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDownloadUrlResponse
        /// </returns>
        public CreateDownloadUrlResponse CreateDownloadUrlWithOptions(CreateDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDownloadUrl",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDownloadUrlResponse
        /// </returns>
        public async Task<CreateDownloadUrlResponse> CreateDownloadUrlWithOptionsAsync(CreateDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDownloadUrl",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateDownloadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDownloadUrlResponse
        /// </returns>
        public CreateDownloadUrlResponse CreateDownloadUrl(CreateDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDownloadUrlWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateDownloadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDownloadUrlResponse
        /// </returns>
        public async Task<CreateDownloadUrlResponse> CreateDownloadUrlAsync(CreateDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDownloadUrlWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateGlobalQuestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGlobalQuestionResponse
        /// </returns>
        public CreateGlobalQuestionResponse CreateGlobalQuestionWithOptions(CreateGlobalQuestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Answers))
            {
                query["Answers"] = request.Answers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionName))
            {
                query["GlobalQuestionName"] = request.GlobalQuestionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionType))
            {
                query["GlobalQuestionType"] = request.GlobalQuestionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Questions))
            {
                query["Questions"] = request.Questions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGlobalQuestion",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGlobalQuestionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateGlobalQuestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGlobalQuestionResponse
        /// </returns>
        public async Task<CreateGlobalQuestionResponse> CreateGlobalQuestionWithOptionsAsync(CreateGlobalQuestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Answers))
            {
                query["Answers"] = request.Answers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionName))
            {
                query["GlobalQuestionName"] = request.GlobalQuestionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionType))
            {
                query["GlobalQuestionType"] = request.GlobalQuestionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Questions))
            {
                query["Questions"] = request.Questions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGlobalQuestion",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGlobalQuestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateGlobalQuestionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGlobalQuestionResponse
        /// </returns>
        public CreateGlobalQuestionResponse CreateGlobalQuestion(CreateGlobalQuestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGlobalQuestionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateGlobalQuestionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGlobalQuestionResponse
        /// </returns>
        public async Task<CreateGlobalQuestionResponse> CreateGlobalQuestionAsync(CreateGlobalQuestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGlobalQuestionWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceDescription))
            {
                query["InstanceDescription"] = request.InstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrentConversation))
            {
                query["MaxConcurrentConversation"] = request.MaxConcurrentConversation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluServiceType))
            {
                query["NluServiceType"] = request.NluServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceDescription))
            {
                query["InstanceDescription"] = request.InstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrentConversation))
            {
                query["MaxConcurrentConversation"] = request.MaxConcurrentConversation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluServiceType))
            {
                query["NluServiceType"] = request.NluServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例绑定号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceBindNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceBindNumberResponse
        /// </returns>
        public CreateInstanceBindNumberResponse CreateInstanceBindNumberWithOptions(CreateInstanceBindNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceBindNumber",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceBindNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例绑定号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceBindNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceBindNumberResponse
        /// </returns>
        public async Task<CreateInstanceBindNumberResponse> CreateInstanceBindNumberWithOptionsAsync(CreateInstanceBindNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceBindNumber",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceBindNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例绑定号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceBindNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceBindNumberResponse
        /// </returns>
        public CreateInstanceBindNumberResponse CreateInstanceBindNumber(CreateInstanceBindNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceBindNumberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例绑定号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceBindNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceBindNumberResponse
        /// </returns>
        public async Task<CreateInstanceBindNumberResponse> CreateInstanceBindNumberAsync(CreateInstanceBindNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceBindNumberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIntentResponse
        /// </returns>
        public CreateIntentResponse CreateIntentWithOptions(CreateIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentDescription))
            {
                query["IntentDescription"] = request.IntentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentName))
            {
                query["IntentName"] = request.IntentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterances))
            {
                query["Utterances"] = request.Utterances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIntentResponse
        /// </returns>
        public async Task<CreateIntentResponse> CreateIntentWithOptionsAsync(CreateIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentDescription))
            {
                query["IntentDescription"] = request.IntentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentName))
            {
                query["IntentName"] = request.IntentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterances))
            {
                query["Utterances"] = request.Utterances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIntentResponse
        /// </returns>
        public CreateIntentResponse CreateIntent(CreateIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIntentWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIntentResponse
        /// </returns>
        public async Task<CreateIntentResponse> CreateIntentAsync(CreateIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIntentWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateJobDataParsingTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobDataParsingTaskResponse
        /// </returns>
        public CreateJobDataParsingTaskResponse CreateJobDataParsingTaskWithOptions(CreateJobDataParsingTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobFilePath))
            {
                query["JobFilePath"] = request.JobFilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJobDataParsingTask",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobDataParsingTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateJobDataParsingTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobDataParsingTaskResponse
        /// </returns>
        public async Task<CreateJobDataParsingTaskResponse> CreateJobDataParsingTaskWithOptionsAsync(CreateJobDataParsingTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobFilePath))
            {
                query["JobFilePath"] = request.JobFilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJobDataParsingTask",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobDataParsingTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateJobDataParsingTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobDataParsingTaskResponse
        /// </returns>
        public CreateJobDataParsingTaskResponse CreateJobDataParsingTask(CreateJobDataParsingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobDataParsingTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateJobDataParsingTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobDataParsingTaskResponse
        /// </returns>
        public async Task<CreateJobDataParsingTaskResponse> CreateJobDataParsingTaskAsync(CreateJobDataParsingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobDataParsingTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobGroupResponse
        /// </returns>
        public CreateJobGroupResponse CreateJobGroupWithOptions(CreateJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsExtras))
            {
                query["FlashSmsExtras"] = request.FlashSmsExtras;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupDescription))
            {
                query["JobGroupDescription"] = request.JobGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupName))
            {
                query["JobGroupName"] = request.JobGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinConcurrency))
            {
                query["MinConcurrency"] = request.MinConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallCallingNumber))
            {
                query["RecallCallingNumber"] = request.RecallCallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallStrategyJson))
            {
                query["RecallStrategyJson"] = request.RecallStrategyJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingingDuration))
            {
                query["RingingDuration"] = request.RingingDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                query["StrategyJson"] = request.StrategyJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJobGroup",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobGroupResponse
        /// </returns>
        public async Task<CreateJobGroupResponse> CreateJobGroupWithOptionsAsync(CreateJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsExtras))
            {
                query["FlashSmsExtras"] = request.FlashSmsExtras;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupDescription))
            {
                query["JobGroupDescription"] = request.JobGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupName))
            {
                query["JobGroupName"] = request.JobGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinConcurrency))
            {
                query["MinConcurrency"] = request.MinConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallCallingNumber))
            {
                query["RecallCallingNumber"] = request.RecallCallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallStrategyJson))
            {
                query["RecallStrategyJson"] = request.RecallStrategyJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingingDuration))
            {
                query["RingingDuration"] = request.RingingDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                query["StrategyJson"] = request.StrategyJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJobGroup",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobGroupResponse
        /// </returns>
        public CreateJobGroupResponse CreateJobGroup(CreateJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobGroupResponse
        /// </returns>
        public async Task<CreateJobGroupResponse> CreateJobGroupAsync(CreateJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务组到处任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobGroupExportTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobGroupExportTaskResponse
        /// </returns>
        public CreateJobGroupExportTaskResponse CreateJobGroupExportTaskWithOptions(CreateJobGroupExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJobGroupExportTask",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobGroupExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务组到处任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobGroupExportTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobGroupExportTaskResponse
        /// </returns>
        public async Task<CreateJobGroupExportTaskResponse> CreateJobGroupExportTaskWithOptionsAsync(CreateJobGroupExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJobGroupExportTask",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobGroupExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务组到处任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobGroupExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobGroupExportTaskResponse
        /// </returns>
        public CreateJobGroupExportTaskResponse CreateJobGroupExportTask(CreateJobGroupExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobGroupExportTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务组到处任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobGroupExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobGroupExportTaskResponse
        /// </returns>
        public async Task<CreateJobGroupExportTaskResponse> CreateJobGroupExportTaskAsync(CreateJobGroupExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobGroupExportTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptResponse
        /// </returns>
        public CreateScriptResponse CreateScriptWithOptions(CreateScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentLlm))
            {
                query["AgentLlm"] = request.AgentLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrConfig))
            {
                query["AsrConfig"] = request.AsrConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                query["ChatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmotionEnable))
            {
                query["EmotionEnable"] = request.EmotionEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["Industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LongWaitEnable))
            {
                query["LongWaitEnable"] = request.LongWaitEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniPlaybackEnable))
            {
                query["MiniPlaybackEnable"] = request.MiniPlaybackEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewBargeInEnable))
            {
                query["NewBargeInEnable"] = request.NewBargeInEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluAccessType))
            {
                query["NluAccessType"] = request.NluAccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluEngine))
            {
                query["NluEngine"] = request.NluEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptContent))
            {
                query["ScriptContent"] = request.ScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptDescription))
            {
                query["ScriptDescription"] = request.ScriptDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptName))
            {
                query["ScriptName"] = request.ScriptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptNluProfileJsonString))
            {
                query["ScriptNluProfileJsonString"] = request.ScriptNluProfileJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptWaveform))
            {
                query["ScriptWaveform"] = request.ScriptWaveform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsConfig))
            {
                query["TtsConfig"] = request.TtsConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptResponse
        /// </returns>
        public async Task<CreateScriptResponse> CreateScriptWithOptionsAsync(CreateScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentLlm))
            {
                query["AgentLlm"] = request.AgentLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrConfig))
            {
                query["AsrConfig"] = request.AsrConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                query["ChatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmotionEnable))
            {
                query["EmotionEnable"] = request.EmotionEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["Industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LongWaitEnable))
            {
                query["LongWaitEnable"] = request.LongWaitEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniPlaybackEnable))
            {
                query["MiniPlaybackEnable"] = request.MiniPlaybackEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewBargeInEnable))
            {
                query["NewBargeInEnable"] = request.NewBargeInEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluAccessType))
            {
                query["NluAccessType"] = request.NluAccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluEngine))
            {
                query["NluEngine"] = request.NluEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptContent))
            {
                query["ScriptContent"] = request.ScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptDescription))
            {
                query["ScriptDescription"] = request.ScriptDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptName))
            {
                query["ScriptName"] = request.ScriptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptNluProfileJsonString))
            {
                query["ScriptNluProfileJsonString"] = request.ScriptNluProfileJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptWaveform))
            {
                query["ScriptWaveform"] = request.ScriptWaveform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsConfig))
            {
                query["TtsConfig"] = request.TtsConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptResponse
        /// </returns>
        public CreateScriptResponse CreateScript(CreateScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScriptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptResponse
        /// </returns>
        public async Task<CreateScriptResponse> CreateScriptAsync(CreateScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScriptWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateScriptWaveformRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptWaveformResponse
        /// </returns>
        public CreateScriptWaveformResponse CreateScriptWaveformWithOptions(CreateScriptWaveformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptContent))
            {
                query["ScriptContent"] = request.ScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScriptWaveform",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScriptWaveformResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateScriptWaveformRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptWaveformResponse
        /// </returns>
        public async Task<CreateScriptWaveformResponse> CreateScriptWaveformWithOptionsAsync(CreateScriptWaveformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptContent))
            {
                query["ScriptContent"] = request.ScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScriptWaveform",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScriptWaveformResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateScriptWaveformRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptWaveformResponse
        /// </returns>
        public CreateScriptWaveformResponse CreateScriptWaveform(CreateScriptWaveformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScriptWaveformWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateScriptWaveformRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptWaveformResponse
        /// </returns>
        public async Task<CreateScriptWaveformResponse> CreateScriptWaveformAsync(CreateScriptWaveformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScriptWaveformWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTagResponse
        /// </returns>
        public CreateTagResponse CreateTagWithOptions(CreateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagGroup))
            {
                query["TagGroup"] = request.TagGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTag",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTagResponse
        /// </returns>
        public async Task<CreateTagResponse> CreateTagWithOptionsAsync(CreateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagGroup))
            {
                query["TagGroup"] = request.TagGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTag",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateTagRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTagResponse
        /// </returns>
        public CreateTagResponse CreateTag(CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTagWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateTagRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTagResponse
        /// </returns>
        public async Task<CreateTagResponse> CreateTagAsync(CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外呼历史导出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskExportTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskExportTaskResponse
        /// </returns>
        public CreateTaskExportTaskResponse CreateTaskExportTaskWithOptions(CreateTaskExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTaskExportTask",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外呼历史导出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskExportTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskExportTaskResponse
        /// </returns>
        public async Task<CreateTaskExportTaskResponse> CreateTaskExportTaskWithOptionsAsync(CreateTaskExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTaskExportTask",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外呼历史导出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskExportTaskResponse
        /// </returns>
        public CreateTaskExportTaskResponse CreateTaskExportTask(CreateTaskExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTaskExportTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外呼历史导出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskExportTaskResponse
        /// </returns>
        public async Task<CreateTaskExportTaskResponse> CreateTaskExportTaskAsync(CreateTaskExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTaskExportTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// DeleteAgentProfilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentProfilesResponse
        /// </returns>
        public DeleteAgentProfilesResponse DeleteAgentProfilesWithOptions(DeleteAgentProfilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAgentProfilesShrinkRequest request = new DeleteAgentProfilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentProfileIds))
            {
                request.AgentProfileIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentProfileIds, "AgentProfileIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProfileIdsShrink))
            {
                body["AgentProfileIds"] = request.AgentProfileIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIp))
            {
                body["AppIp"] = request.AppIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentProfiles",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentProfilesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// DeleteAgentProfilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentProfilesResponse
        /// </returns>
        public async Task<DeleteAgentProfilesResponse> DeleteAgentProfilesWithOptionsAsync(DeleteAgentProfilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAgentProfilesShrinkRequest request = new DeleteAgentProfilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentProfileIds))
            {
                request.AgentProfileIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentProfileIds, "AgentProfileIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProfileIdsShrink))
            {
                body["AgentProfileIds"] = request.AgentProfileIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIp))
            {
                body["AppIp"] = request.AppIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentProfiles",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentProfilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteAgentProfilesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentProfilesResponse
        /// </returns>
        public DeleteAgentProfilesResponse DeleteAgentProfiles(DeleteAgentProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAgentProfilesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteAgentProfilesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentProfilesResponse
        /// </returns>
        public async Task<DeleteAgentProfilesResponse> DeleteAgentProfilesAsync(DeleteAgentProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAgentProfilesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清空归属地号码库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAllNumberDistrictInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAllNumberDistrictInfoResponse
        /// </returns>
        public DeleteAllNumberDistrictInfoResponse DeleteAllNumberDistrictInfoWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAllNumberDistrictInfo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAllNumberDistrictInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清空归属地号码库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAllNumberDistrictInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAllNumberDistrictInfoResponse
        /// </returns>
        public async Task<DeleteAllNumberDistrictInfoResponse> DeleteAllNumberDistrictInfoWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAllNumberDistrictInfo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAllNumberDistrictInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清空归属地号码库</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAllNumberDistrictInfoResponse
        /// </returns>
        public DeleteAllNumberDistrictInfoResponse DeleteAllNumberDistrictInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAllNumberDistrictInfoWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清空归属地号码库</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAllNumberDistrictInfoResponse
        /// </returns>
        public async Task<DeleteAllNumberDistrictInfoResponse> DeleteAllNumberDistrictInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAllNumberDistrictInfoWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBeebotIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBeebotIntentResponse
        /// </returns>
        public DeleteBeebotIntentResponse DeleteBeebotIntentWithOptions(DeleteBeebotIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBeebotIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBeebotIntentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBeebotIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBeebotIntentResponse
        /// </returns>
        public async Task<DeleteBeebotIntentResponse> DeleteBeebotIntentWithOptionsAsync(DeleteBeebotIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBeebotIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBeebotIntentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBeebotIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBeebotIntentResponse
        /// </returns>
        public DeleteBeebotIntentResponse DeleteBeebotIntent(DeleteBeebotIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBeebotIntentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBeebotIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBeebotIntentResponse
        /// </returns>
        public async Task<DeleteBeebotIntentResponse> DeleteBeebotIntentAsync(DeleteBeebotIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBeebotIntentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBeebotIntentLgfRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBeebotIntentLgfResponse
        /// </returns>
        public DeleteBeebotIntentLgfResponse DeleteBeebotIntentLgfWithOptions(DeleteBeebotIntentLgfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LgfId))
            {
                query["LgfId"] = request.LgfId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBeebotIntentLgf",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBeebotIntentLgfResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBeebotIntentLgfRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBeebotIntentLgfResponse
        /// </returns>
        public async Task<DeleteBeebotIntentLgfResponse> DeleteBeebotIntentLgfWithOptionsAsync(DeleteBeebotIntentLgfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LgfId))
            {
                query["LgfId"] = request.LgfId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBeebotIntentLgf",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBeebotIntentLgfResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBeebotIntentLgfRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBeebotIntentLgfResponse
        /// </returns>
        public DeleteBeebotIntentLgfResponse DeleteBeebotIntentLgf(DeleteBeebotIntentLgfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBeebotIntentLgfWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBeebotIntentLgfRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBeebotIntentLgfResponse
        /// </returns>
        public async Task<DeleteBeebotIntentLgfResponse> DeleteBeebotIntentLgfAsync(DeleteBeebotIntentLgfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBeebotIntentLgfWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBeebotIntentUserSayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBeebotIntentUserSayResponse
        /// </returns>
        public DeleteBeebotIntentUserSayResponse DeleteBeebotIntentUserSayWithOptions(DeleteBeebotIntentUserSayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSayId))
            {
                query["UserSayId"] = request.UserSayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBeebotIntentUserSay",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBeebotIntentUserSayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBeebotIntentUserSayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBeebotIntentUserSayResponse
        /// </returns>
        public async Task<DeleteBeebotIntentUserSayResponse> DeleteBeebotIntentUserSayWithOptionsAsync(DeleteBeebotIntentUserSayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSayId))
            {
                query["UserSayId"] = request.UserSayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBeebotIntentUserSay",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBeebotIntentUserSayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBeebotIntentUserSayRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBeebotIntentUserSayResponse
        /// </returns>
        public DeleteBeebotIntentUserSayResponse DeleteBeebotIntentUserSay(DeleteBeebotIntentUserSayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBeebotIntentUserSayWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBeebotIntentUserSayRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBeebotIntentUserSayResponse
        /// </returns>
        public async Task<DeleteBeebotIntentUserSayResponse> DeleteBeebotIntentUserSayAsync(DeleteBeebotIntentUserSayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBeebotIntentUserSayWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteContactBlockListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactBlockListResponse
        /// </returns>
        public DeleteContactBlockListResponse DeleteContactBlockListWithOptions(DeleteContactBlockListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactBlockListId))
            {
                query["ContactBlockListId"] = request.ContactBlockListId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["Operator"] = request.Operator;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContactBlockList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactBlockListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteContactBlockListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactBlockListResponse
        /// </returns>
        public async Task<DeleteContactBlockListResponse> DeleteContactBlockListWithOptionsAsync(DeleteContactBlockListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactBlockListId))
            {
                query["ContactBlockListId"] = request.ContactBlockListId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["Operator"] = request.Operator;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContactBlockList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactBlockListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteContactBlockListRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactBlockListResponse
        /// </returns>
        public DeleteContactBlockListResponse DeleteContactBlockList(DeleteContactBlockListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContactBlockListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteContactBlockListRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactBlockListResponse
        /// </returns>
        public async Task<DeleteContactBlockListResponse> DeleteContactBlockListAsync(DeleteContactBlockListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContactBlockListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteContactWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactWhiteListResponse
        /// </returns>
        public DeleteContactWhiteListResponse DeleteContactWhiteListWithOptions(DeleteContactWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactWhiteListId))
            {
                query["ContactWhiteListId"] = request.ContactWhiteListId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["Operator"] = request.Operator;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContactWhiteList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteContactWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactWhiteListResponse
        /// </returns>
        public async Task<DeleteContactWhiteListResponse> DeleteContactWhiteListWithOptionsAsync(DeleteContactWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactWhiteListId))
            {
                query["ContactWhiteListId"] = request.ContactWhiteListId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["Operator"] = request.Operator;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContactWhiteList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteContactWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactWhiteListResponse
        /// </returns>
        public DeleteContactWhiteListResponse DeleteContactWhiteList(DeleteContactWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContactWhiteListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteContactWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactWhiteListResponse
        /// </returns>
        public async Task<DeleteContactWhiteListResponse> DeleteContactWhiteListAsync(DeleteContactWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContactWhiteListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteDialogueFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDialogueFlowResponse
        /// </returns>
        public DeleteDialogueFlowResponse DeleteDialogueFlowWithOptions(DeleteDialogueFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueFlowId))
            {
                query["DialogueFlowId"] = request.DialogueFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDialogueFlow",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDialogueFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteDialogueFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDialogueFlowResponse
        /// </returns>
        public async Task<DeleteDialogueFlowResponse> DeleteDialogueFlowWithOptionsAsync(DeleteDialogueFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueFlowId))
            {
                query["DialogueFlowId"] = request.DialogueFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDialogueFlow",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDialogueFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteDialogueFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDialogueFlowResponse
        /// </returns>
        public DeleteDialogueFlowResponse DeleteDialogueFlow(DeleteDialogueFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDialogueFlowWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteDialogueFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDialogueFlowResponse
        /// </returns>
        public async Task<DeleteDialogueFlowResponse> DeleteDialogueFlowAsync(DeleteDialogueFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDialogueFlowWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteGlobalQuestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGlobalQuestionResponse
        /// </returns>
        public DeleteGlobalQuestionResponse DeleteGlobalQuestionWithOptions(DeleteGlobalQuestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionId))
            {
                query["GlobalQuestionId"] = request.GlobalQuestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGlobalQuestion",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGlobalQuestionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteGlobalQuestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGlobalQuestionResponse
        /// </returns>
        public async Task<DeleteGlobalQuestionResponse> DeleteGlobalQuestionWithOptionsAsync(DeleteGlobalQuestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionId))
            {
                query["GlobalQuestionId"] = request.GlobalQuestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGlobalQuestion",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGlobalQuestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteGlobalQuestionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGlobalQuestionResponse
        /// </returns>
        public DeleteGlobalQuestionResponse DeleteGlobalQuestion(DeleteGlobalQuestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGlobalQuestionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteGlobalQuestionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGlobalQuestionResponse
        /// </returns>
        public async Task<DeleteGlobalQuestionResponse> DeleteGlobalQuestionAsync(DeleteGlobalQuestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGlobalQuestionWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIntentResponse
        /// </returns>
        public DeleteIntentResponse DeleteIntentWithOptions(DeleteIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIntentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIntentResponse
        /// </returns>
        public async Task<DeleteIntentResponse> DeleteIntentWithOptionsAsync(DeleteIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIntentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIntentResponse
        /// </returns>
        public DeleteIntentResponse DeleteIntent(DeleteIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIntentWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIntentResponse
        /// </returns>
        public async Task<DeleteIntentResponse> DeleteIntentAsync(DeleteIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIntentWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteJobGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobGroupResponse
        /// </returns>
        public DeleteJobGroupResponse DeleteJobGroupWithOptions(DeleteJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJobGroup",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteJobGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobGroupResponse
        /// </returns>
        public async Task<DeleteJobGroupResponse> DeleteJobGroupWithOptionsAsync(DeleteJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJobGroup",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteJobGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobGroupResponse
        /// </returns>
        public DeleteJobGroupResponse DeleteJobGroup(DeleteJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteJobGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobGroupResponse
        /// </returns>
        public async Task<DeleteJobGroupResponse> DeleteJobGroupAsync(DeleteJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteOutboundCallNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOutboundCallNumberResponse
        /// </returns>
        public DeleteOutboundCallNumberResponse DeleteOutboundCallNumberWithOptions(DeleteOutboundCallNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundCallNumberId))
            {
                query["OutboundCallNumberId"] = request.OutboundCallNumberId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOutboundCallNumber",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOutboundCallNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteOutboundCallNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOutboundCallNumberResponse
        /// </returns>
        public async Task<DeleteOutboundCallNumberResponse> DeleteOutboundCallNumberWithOptionsAsync(DeleteOutboundCallNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundCallNumberId))
            {
                query["OutboundCallNumberId"] = request.OutboundCallNumberId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOutboundCallNumber",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOutboundCallNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteOutboundCallNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOutboundCallNumberResponse
        /// </returns>
        public DeleteOutboundCallNumberResponse DeleteOutboundCallNumber(DeleteOutboundCallNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOutboundCallNumberWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteOutboundCallNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOutboundCallNumberResponse
        /// </returns>
        public async Task<DeleteOutboundCallNumberResponse> DeleteOutboundCallNumberAsync(DeleteOutboundCallNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOutboundCallNumberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptResponse
        /// </returns>
        public DeleteScriptResponse DeleteScriptWithOptions(DeleteScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptResponse
        /// </returns>
        public async Task<DeleteScriptResponse> DeleteScriptWithOptionsAsync(DeleteScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptResponse
        /// </returns>
        public DeleteScriptResponse DeleteScript(DeleteScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScriptWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptResponse
        /// </returns>
        public async Task<DeleteScriptResponse> DeleteScriptAsync(DeleteScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScriptWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteScriptRecordingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptRecordingResponse
        /// </returns>
        public DeleteScriptRecordingResponse DeleteScriptRecordingWithOptions(DeleteScriptRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UuidsJson))
            {
                query["UuidsJson"] = request.UuidsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScriptRecording",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScriptRecordingResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteScriptRecordingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptRecordingResponse
        /// </returns>
        public async Task<DeleteScriptRecordingResponse> DeleteScriptRecordingWithOptionsAsync(DeleteScriptRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UuidsJson))
            {
                query["UuidsJson"] = request.UuidsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScriptRecording",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScriptRecordingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteScriptRecordingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptRecordingResponse
        /// </returns>
        public DeleteScriptRecordingResponse DeleteScriptRecording(DeleteScriptRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScriptRecordingWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteScriptRecordingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptRecordingResponse
        /// </returns>
        public async Task<DeleteScriptRecordingResponse> DeleteScriptRecordingAsync(DeleteScriptRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScriptRecordingWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteScriptWaveformRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptWaveformResponse
        /// </returns>
        public DeleteScriptWaveformResponse DeleteScriptWaveformWithOptions(DeleteScriptWaveformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptWaveformId))
            {
                query["ScriptWaveformId"] = request.ScriptWaveformId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScriptWaveform",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScriptWaveformResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteScriptWaveformRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptWaveformResponse
        /// </returns>
        public async Task<DeleteScriptWaveformResponse> DeleteScriptWaveformWithOptionsAsync(DeleteScriptWaveformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptWaveformId))
            {
                query["ScriptWaveformId"] = request.ScriptWaveformId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScriptWaveform",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScriptWaveformResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteScriptWaveformRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptWaveformResponse
        /// </returns>
        public DeleteScriptWaveformResponse DeleteScriptWaveform(DeleteScriptWaveformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScriptWaveformWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteScriptWaveformRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptWaveformResponse
        /// </returns>
        public async Task<DeleteScriptWaveformResponse> DeleteScriptWaveformAsync(DeleteScriptWaveformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScriptWaveformWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeBeebotIntent</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBeebotIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBeebotIntentResponse
        /// </returns>
        public DescribeBeebotIntentResponse DescribeBeebotIntentWithOptions(DescribeBeebotIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBeebotIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBeebotIntentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeBeebotIntent</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBeebotIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBeebotIntentResponse
        /// </returns>
        public async Task<DescribeBeebotIntentResponse> DescribeBeebotIntentWithOptionsAsync(DescribeBeebotIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBeebotIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBeebotIntentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeBeebotIntent</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBeebotIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBeebotIntentResponse
        /// </returns>
        public DescribeBeebotIntentResponse DescribeBeebotIntent(DescribeBeebotIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBeebotIntentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeBeebotIntent</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBeebotIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBeebotIntentResponse
        /// </returns>
        public async Task<DescribeBeebotIntentResponse> DescribeBeebotIntentAsync(DescribeBeebotIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBeebotIntentWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeDialogueNodeStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDialogueNodeStatisticsResponse
        /// </returns>
        public DescribeDialogueNodeStatisticsResponse DescribeDialogueNodeStatisticsWithOptions(DescribeDialogueNodeStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDialogueNodeStatistics",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDialogueNodeStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeDialogueNodeStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDialogueNodeStatisticsResponse
        /// </returns>
        public async Task<DescribeDialogueNodeStatisticsResponse> DescribeDialogueNodeStatisticsWithOptionsAsync(DescribeDialogueNodeStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDialogueNodeStatistics",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDialogueNodeStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeDialogueNodeStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDialogueNodeStatisticsResponse
        /// </returns>
        public DescribeDialogueNodeStatisticsResponse DescribeDialogueNodeStatistics(DescribeDialogueNodeStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDialogueNodeStatisticsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeDialogueNodeStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDialogueNodeStatisticsResponse
        /// </returns>
        public async Task<DescribeDialogueNodeStatisticsResponse> DescribeDialogueNodeStatisticsAsync(DescribeDialogueNodeStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDialogueNodeStatisticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeDsReports</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDsReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDsReportsResponse
        /// </returns>
        public DescribeDsReportsResponse DescribeDsReportsWithOptions(DescribeDsReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDsReports",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDsReportsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeDsReports</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDsReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDsReportsResponse
        /// </returns>
        public async Task<DescribeDsReportsResponse> DescribeDsReportsWithOptionsAsync(DescribeDsReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDsReports",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDsReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeDsReports</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDsReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDsReportsResponse
        /// </returns>
        public DescribeDsReportsResponse DescribeDsReports(DescribeDsReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDsReportsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeDsReports</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDsReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDsReportsResponse
        /// </returns>
        public async Task<DescribeDsReportsResponse> DescribeDsReportsAsync(DescribeDsReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDsReportsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeGlobalQuestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGlobalQuestionResponse
        /// </returns>
        public DescribeGlobalQuestionResponse DescribeGlobalQuestionWithOptions(DescribeGlobalQuestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionId))
            {
                query["GlobalQuestionId"] = request.GlobalQuestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGlobalQuestion",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGlobalQuestionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeGlobalQuestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGlobalQuestionResponse
        /// </returns>
        public async Task<DescribeGlobalQuestionResponse> DescribeGlobalQuestionWithOptionsAsync(DescribeGlobalQuestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionId))
            {
                query["GlobalQuestionId"] = request.GlobalQuestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGlobalQuestion",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGlobalQuestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeGlobalQuestionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeGlobalQuestionResponse
        /// </returns>
        public DescribeGlobalQuestionResponse DescribeGlobalQuestion(DescribeGlobalQuestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGlobalQuestionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeGlobalQuestionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeGlobalQuestionResponse
        /// </returns>
        public async Task<DescribeGlobalQuestionResponse> DescribeGlobalQuestionAsync(DescribeGlobalQuestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGlobalQuestionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务组数据统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeGroupExecutingInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGroupExecutingInfoResponse
        /// </returns>
        public DescribeGroupExecutingInfoResponse DescribeGroupExecutingInfoWithOptions(DescribeGroupExecutingInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGroupExecutingInfo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGroupExecutingInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务组数据统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeGroupExecutingInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGroupExecutingInfoResponse
        /// </returns>
        public async Task<DescribeGroupExecutingInfoResponse> DescribeGroupExecutingInfoWithOptionsAsync(DescribeGroupExecutingInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGroupExecutingInfo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGroupExecutingInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务组数据统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeGroupExecutingInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeGroupExecutingInfoResponse
        /// </returns>
        public DescribeGroupExecutingInfoResponse DescribeGroupExecutingInfo(DescribeGroupExecutingInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupExecutingInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务组数据统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeGroupExecutingInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeGroupExecutingInfoResponse
        /// </returns>
        public async Task<DescribeGroupExecutingInfoResponse> DescribeGroupExecutingInfoAsync(DescribeGroupExecutingInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupExecutingInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public DescribeInstanceResponse DescribeInstanceWithOptions(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIntentResponse
        /// </returns>
        public DescribeIntentResponse DescribeIntentWithOptions(DescribeIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIntentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIntentResponse
        /// </returns>
        public async Task<DescribeIntentResponse> DescribeIntentWithOptionsAsync(DescribeIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIntentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIntentResponse
        /// </returns>
        public DescribeIntentResponse DescribeIntent(DescribeIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIntentWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIntentResponse
        /// </returns>
        public async Task<DescribeIntentResponse> DescribeIntentAsync(DescribeIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIntentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeIntentStatistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIntentStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIntentStatisticsResponse
        /// </returns>
        public DescribeIntentStatisticsResponse DescribeIntentStatisticsWithOptions(DescribeIntentStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIntentStatistics",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIntentStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeIntentStatistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIntentStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIntentStatisticsResponse
        /// </returns>
        public async Task<DescribeIntentStatisticsResponse> DescribeIntentStatisticsWithOptionsAsync(DescribeIntentStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIntentStatistics",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIntentStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeIntentStatistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIntentStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIntentStatisticsResponse
        /// </returns>
        public DescribeIntentStatisticsResponse DescribeIntentStatistics(DescribeIntentStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIntentStatisticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeIntentStatistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIntentStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIntentStatisticsResponse
        /// </returns>
        public async Task<DescribeIntentStatisticsResponse> DescribeIntentStatisticsAsync(DescribeIntentStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIntentStatisticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取job信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobResponse
        /// </returns>
        public DescribeJobResponse DescribeJobWithOptions(DescribeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithScript))
            {
                query["WithScript"] = request.WithScript;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJob",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取job信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobResponse
        /// </returns>
        public async Task<DescribeJobResponse> DescribeJobWithOptionsAsync(DescribeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithScript))
            {
                query["WithScript"] = request.WithScript;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJob",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取job信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobResponse
        /// </returns>
        public DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取job信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobResponse
        /// </returns>
        public async Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeJobDataParsingTaskProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobDataParsingTaskProgressResponse
        /// </returns>
        public DescribeJobDataParsingTaskProgressResponse DescribeJobDataParsingTaskProgressWithOptions(DescribeJobDataParsingTaskProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobDataParsingTaskId))
            {
                query["JobDataParsingTaskId"] = request.JobDataParsingTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobDataParsingTaskProgress",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobDataParsingTaskProgressResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeJobDataParsingTaskProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobDataParsingTaskProgressResponse
        /// </returns>
        public async Task<DescribeJobDataParsingTaskProgressResponse> DescribeJobDataParsingTaskProgressWithOptionsAsync(DescribeJobDataParsingTaskProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobDataParsingTaskId))
            {
                query["JobDataParsingTaskId"] = request.JobDataParsingTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobDataParsingTaskProgress",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobDataParsingTaskProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeJobDataParsingTaskProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobDataParsingTaskProgressResponse
        /// </returns>
        public DescribeJobDataParsingTaskProgressResponse DescribeJobDataParsingTaskProgress(DescribeJobDataParsingTaskProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobDataParsingTaskProgressWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeJobDataParsingTaskProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobDataParsingTaskProgressResponse
        /// </returns>
        public async Task<DescribeJobDataParsingTaskProgressResponse> DescribeJobDataParsingTaskProgressAsync(DescribeJobDataParsingTaskProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobDataParsingTaskProgressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeJobGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobGroupResponse
        /// </returns>
        public DescribeJobGroupResponse DescribeJobGroupWithOptions(DescribeJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BriefTypes))
            {
                query["BriefTypes"] = request.BriefTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobGroup",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeJobGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobGroupResponse
        /// </returns>
        public async Task<DescribeJobGroupResponse> DescribeJobGroupWithOptionsAsync(DescribeJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BriefTypes))
            {
                query["BriefTypes"] = request.BriefTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobGroup",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeJobGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobGroupResponse
        /// </returns>
        public DescribeJobGroupResponse DescribeJobGroup(DescribeJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeJobGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobGroupResponse
        /// </returns>
        public async Task<DescribeJobGroupResponse> DescribeJobGroupAsync(DescribeJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeJobGroupExportTaskProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobGroupExportTaskProgressResponse
        /// </returns>
        public DescribeJobGroupExportTaskProgressResponse DescribeJobGroupExportTaskProgressWithOptions(DescribeJobGroupExportTaskProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobGroupExportTaskProgress",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobGroupExportTaskProgressResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeJobGroupExportTaskProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobGroupExportTaskProgressResponse
        /// </returns>
        public async Task<DescribeJobGroupExportTaskProgressResponse> DescribeJobGroupExportTaskProgressWithOptionsAsync(DescribeJobGroupExportTaskProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobGroupExportTaskProgress",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobGroupExportTaskProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeJobGroupExportTaskProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobGroupExportTaskProgressResponse
        /// </returns>
        public DescribeJobGroupExportTaskProgressResponse DescribeJobGroupExportTaskProgress(DescribeJobGroupExportTaskProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobGroupExportTaskProgressWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeJobGroupExportTaskProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobGroupExportTaskProgressResponse
        /// </returns>
        public async Task<DescribeJobGroupExportTaskProgressResponse> DescribeJobGroupExportTaskProgressAsync(DescribeJobGroupExportTaskProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobGroupExportTaskProgressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScriptResponse
        /// </returns>
        public DescribeScriptResponse DescribeScriptWithOptions(DescribeScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScriptResponse
        /// </returns>
        public async Task<DescribeScriptResponse> DescribeScriptWithOptionsAsync(DescribeScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScriptResponse
        /// </returns>
        public DescribeScriptResponse DescribeScript(DescribeScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScriptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScriptResponse
        /// </returns>
        public async Task<DescribeScriptResponse> DescribeScriptAsync(DescribeScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScriptWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeScriptVoiceConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScriptVoiceConfigResponse
        /// </returns>
        public DescribeScriptVoiceConfigResponse DescribeScriptVoiceConfigWithOptions(DescribeScriptVoiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptVoiceConfigId))
            {
                query["ScriptVoiceConfigId"] = request.ScriptVoiceConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScriptVoiceConfig",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScriptVoiceConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeScriptVoiceConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScriptVoiceConfigResponse
        /// </returns>
        public async Task<DescribeScriptVoiceConfigResponse> DescribeScriptVoiceConfigWithOptionsAsync(DescribeScriptVoiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptVoiceConfigId))
            {
                query["ScriptVoiceConfigId"] = request.ScriptVoiceConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScriptVoiceConfig",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScriptVoiceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeScriptVoiceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScriptVoiceConfigResponse
        /// </returns>
        public DescribeScriptVoiceConfigResponse DescribeScriptVoiceConfig(DescribeScriptVoiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScriptVoiceConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeScriptVoiceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScriptVoiceConfigResponse
        /// </returns>
        public async Task<DescribeScriptVoiceConfigResponse> DescribeScriptVoiceConfigAsync(DescribeScriptVoiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScriptVoiceConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeTTSConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTTSConfigResponse
        /// </returns>
        public DescribeTTSConfigResponse DescribeTTSConfigWithOptions(DescribeTTSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTTSConfig",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTTSConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeTTSConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTTSConfigResponse
        /// </returns>
        public async Task<DescribeTTSConfigResponse> DescribeTTSConfigWithOptionsAsync(DescribeTTSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTTSConfig",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTTSConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeTTSConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTTSConfigResponse
        /// </returns>
        public DescribeTTSConfigResponse DescribeTTSConfig(DescribeTTSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTTSConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeTTSConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTTSConfigResponse
        /// </returns>
        public async Task<DescribeTTSConfigResponse> DescribeTTSConfigAsync(DescribeTTSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTTSConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeTTSDemoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTTSDemoResponse
        /// </returns>
        public DescribeTTSDemoResponse DescribeTTSDemoWithOptions(DescribeTTSDemoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliCustomizedVoice))
            {
                query["AliCustomizedVoice"] = request.AliCustomizedVoice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlsServiceType))
            {
                query["NlsServiceType"] = request.NlsServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PitchRate))
            {
                query["PitchRate"] = request.PitchRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                query["SecretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeechRate))
            {
                query["SpeechRate"] = request.SpeechRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voice))
            {
                query["Voice"] = request.Voice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTTSDemo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTTSDemoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeTTSDemoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTTSDemoResponse
        /// </returns>
        public async Task<DescribeTTSDemoResponse> DescribeTTSDemoWithOptionsAsync(DescribeTTSDemoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliCustomizedVoice))
            {
                query["AliCustomizedVoice"] = request.AliCustomizedVoice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlsServiceType))
            {
                query["NlsServiceType"] = request.NlsServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PitchRate))
            {
                query["PitchRate"] = request.PitchRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                query["SecretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeechRate))
            {
                query["SpeechRate"] = request.SpeechRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voice))
            {
                query["Voice"] = request.Voice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTTSDemo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTTSDemoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeTTSDemoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTTSDemoResponse
        /// </returns>
        public DescribeTTSDemoResponse DescribeTTSDemo(DescribeTTSDemoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTTSDemoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeTTSDemoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTTSDemoResponse
        /// </returns>
        public async Task<DescribeTTSDemoResponse> DescribeTTSDemoAsync(DescribeTTSDemoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTTSDemoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeTagHitsSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTagHitsSummaryResponse
        /// </returns>
        public DescribeTagHitsSummaryResponse DescribeTagHitsSummaryWithOptions(DescribeTagHitsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTagHitsSummary",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagHitsSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeTagHitsSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTagHitsSummaryResponse
        /// </returns>
        public async Task<DescribeTagHitsSummaryResponse> DescribeTagHitsSummaryWithOptionsAsync(DescribeTagHitsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTagHitsSummary",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagHitsSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeTagHitsSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTagHitsSummaryResponse
        /// </returns>
        public DescribeTagHitsSummaryResponse DescribeTagHitsSummary(DescribeTagHitsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagHitsSummaryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeTagHitsSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTagHitsSummaryResponse
        /// </returns>
        public async Task<DescribeTagHitsSummaryResponse> DescribeTagHitsSummaryAsync(DescribeTagHitsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagHitsSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码绑定实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTenantBindNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTenantBindNumberResponse
        /// </returns>
        public DescribeTenantBindNumberResponse DescribeTenantBindNumberWithOptions(DescribeTenantBindNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantBindNumber",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantBindNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码绑定实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTenantBindNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTenantBindNumberResponse
        /// </returns>
        public async Task<DescribeTenantBindNumberResponse> DescribeTenantBindNumberWithOptionsAsync(DescribeTenantBindNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantBindNumber",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantBindNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码绑定实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTenantBindNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTenantBindNumberResponse
        /// </returns>
        public DescribeTenantBindNumberResponse DescribeTenantBindNumber(DescribeTenantBindNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTenantBindNumberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码绑定实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTenantBindNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTenantBindNumberResponse
        /// </returns>
        public async Task<DescribeTenantBindNumberResponse> DescribeTenantBindNumberAsync(DescribeTenantBindNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTenantBindNumberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DialogueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DialogueResponse
        /// </returns>
        public DialogueResponse DialogueWithOptions(DialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionKey))
            {
                query["ActionKey"] = request.ActionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionParams))
            {
                query["ActionParams"] = request.ActionParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallType))
            {
                query["CallType"] = request.CallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterance))
            {
                query["Utterance"] = request.Utterance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Dialogue",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DialogueResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DialogueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DialogueResponse
        /// </returns>
        public async Task<DialogueResponse> DialogueWithOptionsAsync(DialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionKey))
            {
                query["ActionKey"] = request.ActionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionParams))
            {
                query["ActionParams"] = request.ActionParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallType))
            {
                query["CallType"] = request.CallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterance))
            {
                query["Utterance"] = request.Utterance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Dialogue",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DialogueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DialogueRequest
        /// </param>
        /// 
        /// <returns>
        /// DialogueResponse
        /// </returns>
        public DialogueResponse Dialogue(DialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DialogueWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DialogueRequest
        /// </param>
        /// 
        /// <returns>
        /// DialogueResponse
        /// </returns>
        public async Task<DialogueResponse> DialogueAsync(DialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DialogueWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DownloadRecording</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DownloadRecordingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DownloadRecordingResponse
        /// </returns>
        public DownloadRecordingResponse DownloadRecordingWithOptions(DownloadRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedVoiceSliceRecording))
            {
                query["NeedVoiceSliceRecording"] = request.NeedVoiceSliceRecording;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadRecording",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadRecordingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DownloadRecording</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DownloadRecordingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DownloadRecordingResponse
        /// </returns>
        public async Task<DownloadRecordingResponse> DownloadRecordingWithOptionsAsync(DownloadRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedVoiceSliceRecording))
            {
                query["NeedVoiceSliceRecording"] = request.NeedVoiceSliceRecording;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadRecording",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadRecordingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DownloadRecording</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DownloadRecordingRequest
        /// </param>
        /// 
        /// <returns>
        /// DownloadRecordingResponse
        /// </returns>
        public DownloadRecordingResponse DownloadRecording(DownloadRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadRecordingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DownloadRecording</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DownloadRecordingRequest
        /// </param>
        /// 
        /// <returns>
        /// DownloadRecordingResponse
        /// </returns>
        public async Task<DownloadRecordingResponse> DownloadRecordingAsync(DownloadRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadRecordingWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DownloadScriptRecordingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DownloadScriptRecordingResponse
        /// </returns>
        public DownloadScriptRecordingResponse DownloadScriptRecordingWithOptions(DownloadScriptRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadScriptRecording",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadScriptRecordingResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DownloadScriptRecordingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DownloadScriptRecordingResponse
        /// </returns>
        public async Task<DownloadScriptRecordingResponse> DownloadScriptRecordingWithOptionsAsync(DownloadScriptRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadScriptRecording",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadScriptRecordingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DownloadScriptRecordingRequest
        /// </param>
        /// 
        /// <returns>
        /// DownloadScriptRecordingResponse
        /// </returns>
        public DownloadScriptRecordingResponse DownloadScriptRecording(DownloadScriptRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadScriptRecordingWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DownloadScriptRecordingRequest
        /// </param>
        /// 
        /// <returns>
        /// DownloadScriptRecordingResponse
        /// </returns>
        public async Task<DownloadScriptRecordingResponse> DownloadScriptRecordingAsync(DownloadScriptRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadScriptRecordingWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DuplicateScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DuplicateScriptResponse
        /// </returns>
        public DuplicateScriptResponse DuplicateScriptWithOptions(DuplicateScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceScriptId))
            {
                query["SourceScriptId"] = request.SourceScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DuplicateScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DuplicateScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DuplicateScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DuplicateScriptResponse
        /// </returns>
        public async Task<DuplicateScriptResponse> DuplicateScriptWithOptionsAsync(DuplicateScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceScriptId))
            {
                query["SourceScriptId"] = request.SourceScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DuplicateScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DuplicateScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DuplicateScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// DuplicateScriptResponse
        /// </returns>
        public DuplicateScriptResponse DuplicateScript(DuplicateScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DuplicateScriptWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DuplicateScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// DuplicateScriptResponse
        /// </returns>
        public async Task<DuplicateScriptResponse> DuplicateScriptAsync(DuplicateScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DuplicateScriptWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ExportScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportScriptResponse
        /// </returns>
        public ExportScriptResponse ExportScriptWithOptions(ExportScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ExportScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportScriptResponse
        /// </returns>
        public async Task<ExportScriptResponse> ExportScriptWithOptionsAsync(ExportScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ExportScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportScriptResponse
        /// </returns>
        public ExportScriptResponse ExportScript(ExportScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportScriptWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ExportScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportScriptResponse
        /// </returns>
        public async Task<ExportScriptResponse> ExportScriptAsync(ExportScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportScriptWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GenerateUploadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadUrlResponse
        /// </returns>
        public GenerateUploadUrlResponse GenerateUploadUrlWithOptions(GenerateUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUploadUrl",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GenerateUploadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadUrlResponse
        /// </returns>
        public async Task<GenerateUploadUrlResponse> GenerateUploadUrlWithOptionsAsync(GenerateUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUploadUrl",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GenerateUploadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadUrlResponse
        /// </returns>
        public GenerateUploadUrlResponse GenerateUploadUrl(GenerateUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateUploadUrlWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GenerateUploadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadUrlResponse
        /// </returns>
        public async Task<GenerateUploadUrlResponse> GenerateUploadUrlAsync(GenerateUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateUploadUrlWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAfterAnswerDelayPlaybackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAfterAnswerDelayPlaybackResponse
        /// </returns>
        public GetAfterAnswerDelayPlaybackResponse GetAfterAnswerDelayPlaybackWithOptions(GetAfterAnswerDelayPlaybackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAfterAnswerDelayPlayback",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAfterAnswerDelayPlaybackResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAfterAnswerDelayPlaybackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAfterAnswerDelayPlaybackResponse
        /// </returns>
        public async Task<GetAfterAnswerDelayPlaybackResponse> GetAfterAnswerDelayPlaybackWithOptionsAsync(GetAfterAnswerDelayPlaybackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAfterAnswerDelayPlayback",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAfterAnswerDelayPlaybackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAfterAnswerDelayPlaybackRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAfterAnswerDelayPlaybackResponse
        /// </returns>
        public GetAfterAnswerDelayPlaybackResponse GetAfterAnswerDelayPlayback(GetAfterAnswerDelayPlaybackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAfterAnswerDelayPlaybackWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAfterAnswerDelayPlaybackRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAfterAnswerDelayPlaybackResponse
        /// </returns>
        public async Task<GetAfterAnswerDelayPlaybackResponse> GetAfterAnswerDelayPlaybackAsync(GetAfterAnswerDelayPlaybackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAfterAnswerDelayPlaybackWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAgentProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentProfileResponse
        /// </returns>
        public GetAgentProfileResponse GetAgentProfileWithOptions(GetAgentProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProfileId))
            {
                body["AgentProfileId"] = request.AgentProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIp))
            {
                body["AppIp"] = request.AppIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentProfile",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentProfileResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgentProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentProfileResponse
        /// </returns>
        public async Task<GetAgentProfileResponse> GetAgentProfileWithOptionsAsync(GetAgentProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProfileId))
            {
                body["AgentProfileId"] = request.AgentProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIp))
            {
                body["AppIp"] = request.AppIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentProfile",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgentProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentProfileResponse
        /// </returns>
        public GetAgentProfileResponse GetAgentProfile(GetAgentProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentProfileWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAgentProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentProfileResponse
        /// </returns>
        public async Task<GetAgentProfileResponse> GetAgentProfileAsync(GetAgentProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentProfileWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAgentProfileTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentProfileTemplateResponse
        /// </returns>
        public GetAgentProfileTemplateResponse GetAgentProfileTemplateWithOptions(GetAgentProfileTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProfileTemplateId))
            {
                body["AgentProfileTemplateId"] = request.AgentProfileTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIp))
            {
                body["AppIp"] = request.AppIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentProfileTemplate",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentProfileTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgentProfileTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentProfileTemplateResponse
        /// </returns>
        public async Task<GetAgentProfileTemplateResponse> GetAgentProfileTemplateWithOptionsAsync(GetAgentProfileTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProfileTemplateId))
            {
                body["AgentProfileTemplateId"] = request.AgentProfileTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIp))
            {
                body["AppIp"] = request.AppIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentProfileTemplate",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentProfileTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgentProfileTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentProfileTemplateResponse
        /// </returns>
        public GetAgentProfileTemplateResponse GetAgentProfileTemplate(GetAgentProfileTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentProfileTemplateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAgentProfileTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentProfileTemplateResponse
        /// </returns>
        public async Task<GetAgentProfileTemplateResponse> GetAgentProfileTemplateAsync(GetAgentProfileTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentProfileTemplateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAnnotationMissionSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAnnotationMissionSummaryResponse
        /// </returns>
        public GetAnnotationMissionSummaryResponse GetAnnotationMissionSummaryWithOptions(GetAnnotationMissionSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionId))
            {
                query["AnnotationMissionId"] = request.AnnotationMissionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAnnotationMissionSummary",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAnnotationMissionSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAnnotationMissionSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAnnotationMissionSummaryResponse
        /// </returns>
        public async Task<GetAnnotationMissionSummaryResponse> GetAnnotationMissionSummaryWithOptionsAsync(GetAnnotationMissionSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionId))
            {
                query["AnnotationMissionId"] = request.AnnotationMissionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAnnotationMissionSummary",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAnnotationMissionSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAnnotationMissionSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAnnotationMissionSummaryResponse
        /// </returns>
        public GetAnnotationMissionSummaryResponse GetAnnotationMissionSummary(GetAnnotationMissionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAnnotationMissionSummaryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAnnotationMissionSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAnnotationMissionSummaryResponse
        /// </returns>
        public async Task<GetAnnotationMissionSummaryResponse> GetAnnotationMissionSummaryAsync(GetAnnotationMissionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAnnotationMissionSummaryWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAnnotationMissionTagInfoListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAnnotationMissionTagInfoListResponse
        /// </returns>
        public GetAnnotationMissionTagInfoListResponse GetAnnotationMissionTagInfoListWithOptions(GetAnnotationMissionTagInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
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
                Action = "GetAnnotationMissionTagInfoList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAnnotationMissionTagInfoListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAnnotationMissionTagInfoListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAnnotationMissionTagInfoListResponse
        /// </returns>
        public async Task<GetAnnotationMissionTagInfoListResponse> GetAnnotationMissionTagInfoListWithOptionsAsync(GetAnnotationMissionTagInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
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
                Action = "GetAnnotationMissionTagInfoList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAnnotationMissionTagInfoListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAnnotationMissionTagInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAnnotationMissionTagInfoListResponse
        /// </returns>
        public GetAnnotationMissionTagInfoListResponse GetAnnotationMissionTagInfoList(GetAnnotationMissionTagInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAnnotationMissionTagInfoListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAnnotationMissionTagInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAnnotationMissionTagInfoListResponse
        /// </returns>
        public async Task<GetAnnotationMissionTagInfoListResponse> GetAnnotationMissionTagInfoListAsync(GetAnnotationMissionTagInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAnnotationMissionTagInfoListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAsrServerInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsrServerInfoResponse
        /// </returns>
        public GetAsrServerInfoResponse GetAsrServerInfoWithOptions(GetAsrServerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsrServerInfo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsrServerInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAsrServerInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsrServerInfoResponse
        /// </returns>
        public async Task<GetAsrServerInfoResponse> GetAsrServerInfoWithOptionsAsync(GetAsrServerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsrServerInfo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsrServerInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAsrServerInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsrServerInfoResponse
        /// </returns>
        public GetAsrServerInfoResponse GetAsrServerInfo(GetAsrServerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsrServerInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAsrServerInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsrServerInfoResponse
        /// </returns>
        public async Task<GetAsrServerInfoResponse> GetAsrServerInfoAsync(GetAsrServerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsrServerInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步外呼任务上传结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAssignJobsAsyncResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAssignJobsAsyncResultResponse
        /// </returns>
        public GetAssignJobsAsyncResultResponse GetAssignJobsAsyncResultWithOptions(GetAssignJobsAsyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncTaskId))
            {
                query["AsyncTaskId"] = request.AsyncTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAssignJobsAsyncResult",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAssignJobsAsyncResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步外呼任务上传结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAssignJobsAsyncResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAssignJobsAsyncResultResponse
        /// </returns>
        public async Task<GetAssignJobsAsyncResultResponse> GetAssignJobsAsyncResultWithOptionsAsync(GetAssignJobsAsyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncTaskId))
            {
                query["AsyncTaskId"] = request.AsyncTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAssignJobsAsyncResult",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAssignJobsAsyncResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步外呼任务上传结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAssignJobsAsyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAssignJobsAsyncResultResponse
        /// </returns>
        public GetAssignJobsAsyncResultResponse GetAssignJobsAsyncResult(GetAssignJobsAsyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAssignJobsAsyncResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步外呼任务上传结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAssignJobsAsyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAssignJobsAsyncResultResponse
        /// </returns>
        public async Task<GetAssignJobsAsyncResultResponse> GetAssignJobsAsyncResultAsync(GetAssignJobsAsyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAssignJobsAsyncResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBaseStrategyPeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBaseStrategyPeriodResponse
        /// </returns>
        public GetBaseStrategyPeriodResponse GetBaseStrategyPeriodWithOptions(GetBaseStrategyPeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBaseStrategyPeriod",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBaseStrategyPeriodResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBaseStrategyPeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBaseStrategyPeriodResponse
        /// </returns>
        public async Task<GetBaseStrategyPeriodResponse> GetBaseStrategyPeriodWithOptionsAsync(GetBaseStrategyPeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBaseStrategyPeriod",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBaseStrategyPeriodResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBaseStrategyPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBaseStrategyPeriodResponse
        /// </returns>
        public GetBaseStrategyPeriodResponse GetBaseStrategyPeriod(GetBaseStrategyPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBaseStrategyPeriodWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBaseStrategyPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBaseStrategyPeriodResponse
        /// </returns>
        public async Task<GetBaseStrategyPeriodResponse> GetBaseStrategyPeriodAsync(GetBaseStrategyPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBaseStrategyPeriodWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetConcurrentConversationQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConcurrentConversationQuotaResponse
        /// </returns>
        public GetConcurrentConversationQuotaResponse GetConcurrentConversationQuotaWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConcurrentConversationQuota",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConcurrentConversationQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetConcurrentConversationQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConcurrentConversationQuotaResponse
        /// </returns>
        public async Task<GetConcurrentConversationQuotaResponse> GetConcurrentConversationQuotaWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConcurrentConversationQuota",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConcurrentConversationQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// GetConcurrentConversationQuotaResponse
        /// </returns>
        public GetConcurrentConversationQuotaResponse GetConcurrentConversationQuota()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConcurrentConversationQuotaWithOptions(runtime);
        }

        /// <returns>
        /// GetConcurrentConversationQuotaResponse
        /// </returns>
        public async Task<GetConcurrentConversationQuotaResponse> GetConcurrentConversationQuotaAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConcurrentConversationQuotaWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetContactBlockList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContactBlockListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContactBlockListResponse
        /// </returns>
        public GetContactBlockListResponse GetContactBlockListWithOptions(GetContactBlockListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountTotalRow))
            {
                query["CountTotalRow"] = request.CountTotalRow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetContactBlockList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContactBlockListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetContactBlockList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContactBlockListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContactBlockListResponse
        /// </returns>
        public async Task<GetContactBlockListResponse> GetContactBlockListWithOptionsAsync(GetContactBlockListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountTotalRow))
            {
                query["CountTotalRow"] = request.CountTotalRow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetContactBlockList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContactBlockListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetContactBlockList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContactBlockListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContactBlockListResponse
        /// </returns>
        public GetContactBlockListResponse GetContactBlockList(GetContactBlockListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContactBlockListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetContactBlockList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContactBlockListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContactBlockListResponse
        /// </returns>
        public async Task<GetContactBlockListResponse> GetContactBlockListAsync(GetContactBlockListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContactBlockListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetContactWhiteList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContactWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContactWhiteListResponse
        /// </returns>
        public GetContactWhiteListResponse GetContactWhiteListWithOptions(GetContactWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountTotalRow))
            {
                query["CountTotalRow"] = request.CountTotalRow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetContactWhiteList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContactWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetContactWhiteList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContactWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContactWhiteListResponse
        /// </returns>
        public async Task<GetContactWhiteListResponse> GetContactWhiteListWithOptionsAsync(GetContactWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountTotalRow))
            {
                query["CountTotalRow"] = request.CountTotalRow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetContactWhiteList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContactWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetContactWhiteList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContactWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContactWhiteListResponse
        /// </returns>
        public GetContactWhiteListResponse GetContactWhiteList(GetContactWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContactWhiteListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetContactWhiteList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContactWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContactWhiteListResponse
        /// </returns>
        public async Task<GetContactWhiteListResponse> GetContactWhiteListAsync(GetContactWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContactWhiteListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetCurrentConcurrencyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentConcurrencyResponse
        /// </returns>
        public GetCurrentConcurrencyResponse GetCurrentConcurrencyWithOptions(GetCurrentConcurrencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCurrentConcurrency",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCurrentConcurrencyResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetCurrentConcurrencyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentConcurrencyResponse
        /// </returns>
        public async Task<GetCurrentConcurrencyResponse> GetCurrentConcurrencyWithOptionsAsync(GetCurrentConcurrencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCurrentConcurrency",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCurrentConcurrencyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetCurrentConcurrencyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentConcurrencyResponse
        /// </returns>
        public GetCurrentConcurrencyResponse GetCurrentConcurrency(GetCurrentConcurrencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCurrentConcurrencyWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetCurrentConcurrencyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentConcurrencyResponse
        /// </returns>
        public async Task<GetCurrentConcurrencyResponse> GetCurrentConcurrencyAsync(GetCurrentConcurrencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCurrentConcurrencyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetEmptyNumberNoMoreCallsInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmptyNumberNoMoreCallsInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEmptyNumberNoMoreCallsInfoResponse
        /// </returns>
        public GetEmptyNumberNoMoreCallsInfoResponse GetEmptyNumberNoMoreCallsInfoWithOptions(GetEmptyNumberNoMoreCallsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmptyNumberNoMoreCallsInfo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmptyNumberNoMoreCallsInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetEmptyNumberNoMoreCallsInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmptyNumberNoMoreCallsInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEmptyNumberNoMoreCallsInfoResponse
        /// </returns>
        public async Task<GetEmptyNumberNoMoreCallsInfoResponse> GetEmptyNumberNoMoreCallsInfoWithOptionsAsync(GetEmptyNumberNoMoreCallsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmptyNumberNoMoreCallsInfo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmptyNumberNoMoreCallsInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetEmptyNumberNoMoreCallsInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmptyNumberNoMoreCallsInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEmptyNumberNoMoreCallsInfoResponse
        /// </returns>
        public GetEmptyNumberNoMoreCallsInfoResponse GetEmptyNumberNoMoreCallsInfo(GetEmptyNumberNoMoreCallsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEmptyNumberNoMoreCallsInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetEmptyNumberNoMoreCallsInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmptyNumberNoMoreCallsInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEmptyNumberNoMoreCallsInfoResponse
        /// </returns>
        public async Task<GetEmptyNumberNoMoreCallsInfoResponse> GetEmptyNumberNoMoreCallsInfoAsync(GetEmptyNumberNoMoreCallsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEmptyNumberNoMoreCallsInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobDataUploadParamsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobDataUploadParamsResponse
        /// </returns>
        public GetJobDataUploadParamsResponse GetJobDataUploadParamsWithOptions(GetJobDataUploadParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusiType))
            {
                query["BusiType"] = request.BusiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobDataUploadParams",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobDataUploadParamsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobDataUploadParamsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobDataUploadParamsResponse
        /// </returns>
        public async Task<GetJobDataUploadParamsResponse> GetJobDataUploadParamsWithOptionsAsync(GetJobDataUploadParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusiType))
            {
                query["BusiType"] = request.BusiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobDataUploadParams",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobDataUploadParamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobDataUploadParamsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobDataUploadParamsResponse
        /// </returns>
        public GetJobDataUploadParamsResponse GetJobDataUploadParams(GetJobDataUploadParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobDataUploadParamsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobDataUploadParamsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobDataUploadParamsResponse
        /// </returns>
        public async Task<GetJobDataUploadParamsResponse> GetJobDataUploadParamsAsync(GetJobDataUploadParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobDataUploadParamsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMaxAttemptsPerDay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMaxAttemptsPerDayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMaxAttemptsPerDayResponse
        /// </returns>
        public GetMaxAttemptsPerDayResponse GetMaxAttemptsPerDayWithOptions(GetMaxAttemptsPerDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMaxAttemptsPerDay",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMaxAttemptsPerDayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMaxAttemptsPerDay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMaxAttemptsPerDayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMaxAttemptsPerDayResponse
        /// </returns>
        public async Task<GetMaxAttemptsPerDayResponse> GetMaxAttemptsPerDayWithOptionsAsync(GetMaxAttemptsPerDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMaxAttemptsPerDay",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMaxAttemptsPerDayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMaxAttemptsPerDay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMaxAttemptsPerDayRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMaxAttemptsPerDayResponse
        /// </returns>
        public GetMaxAttemptsPerDayResponse GetMaxAttemptsPerDay(GetMaxAttemptsPerDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMaxAttemptsPerDayWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMaxAttemptsPerDay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMaxAttemptsPerDayRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMaxAttemptsPerDayResponse
        /// </returns>
        public async Task<GetMaxAttemptsPerDayResponse> GetMaxAttemptsPerDayAsync(GetMaxAttemptsPerDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMaxAttemptsPerDayWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取号码库模板下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNumberDistrictInfoTemplateDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNumberDistrictInfoTemplateDownloadUrlResponse
        /// </returns>
        public GetNumberDistrictInfoTemplateDownloadUrlResponse GetNumberDistrictInfoTemplateDownloadUrlWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNumberDistrictInfoTemplateDownloadUrl",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNumberDistrictInfoTemplateDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取号码库模板下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNumberDistrictInfoTemplateDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNumberDistrictInfoTemplateDownloadUrlResponse
        /// </returns>
        public async Task<GetNumberDistrictInfoTemplateDownloadUrlResponse> GetNumberDistrictInfoTemplateDownloadUrlWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNumberDistrictInfoTemplateDownloadUrl",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNumberDistrictInfoTemplateDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取号码库模板下载链接</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetNumberDistrictInfoTemplateDownloadUrlResponse
        /// </returns>
        public GetNumberDistrictInfoTemplateDownloadUrlResponse GetNumberDistrictInfoTemplateDownloadUrl()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNumberDistrictInfoTemplateDownloadUrlWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取号码库模板下载链接</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetNumberDistrictInfoTemplateDownloadUrlResponse
        /// </returns>
        public async Task<GetNumberDistrictInfoTemplateDownloadUrlResponse> GetNumberDistrictInfoTemplateDownloadUrlAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNumberDistrictInfoTemplateDownloadUrlWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetRealtimeConcurrencyReport</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealtimeConcurrencyReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRealtimeConcurrencyReportResponse
        /// </returns>
        public GetRealtimeConcurrencyReportResponse GetRealtimeConcurrencyReportWithOptions(GetRealtimeConcurrencyReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRealtimeConcurrencyReport",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealtimeConcurrencyReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetRealtimeConcurrencyReport</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealtimeConcurrencyReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRealtimeConcurrencyReportResponse
        /// </returns>
        public async Task<GetRealtimeConcurrencyReportResponse> GetRealtimeConcurrencyReportWithOptionsAsync(GetRealtimeConcurrencyReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRealtimeConcurrencyReport",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealtimeConcurrencyReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetRealtimeConcurrencyReport</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealtimeConcurrencyReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRealtimeConcurrencyReportResponse
        /// </returns>
        public GetRealtimeConcurrencyReportResponse GetRealtimeConcurrencyReport(GetRealtimeConcurrencyReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRealtimeConcurrencyReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetRealtimeConcurrencyReport</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealtimeConcurrencyReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRealtimeConcurrencyReportResponse
        /// </returns>
        public async Task<GetRealtimeConcurrencyReportResponse> GetRealtimeConcurrencyReportAsync(GetRealtimeConcurrencyReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRealtimeConcurrencyReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetSummaryInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSummaryInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSummaryInfoResponse
        /// </returns>
        public GetSummaryInfoResponse GetSummaryInfoWithOptions(GetSummaryInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSummaryInfo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSummaryInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetSummaryInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSummaryInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSummaryInfoResponse
        /// </returns>
        public async Task<GetSummaryInfoResponse> GetSummaryInfoWithOptionsAsync(GetSummaryInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSummaryInfo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSummaryInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetSummaryInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSummaryInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSummaryInfoResponse
        /// </returns>
        public GetSummaryInfoResponse GetSummaryInfo(GetSummaryInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSummaryInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetSummaryInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSummaryInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSummaryInfoResponse
        /// </returns>
        public async Task<GetSummaryInfoResponse> GetSummaryInfoAsync(GetSummaryInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSummaryInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据TaskId获取Task信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskByUuidRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskByUuidResponse
        /// </returns>
        public GetTaskByUuidResponse GetTaskByUuidWithOptions(GetTaskByUuidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskByUuid",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskByUuidResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据TaskId获取Task信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskByUuidRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskByUuidResponse
        /// </returns>
        public async Task<GetTaskByUuidResponse> GetTaskByUuidWithOptionsAsync(GetTaskByUuidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskByUuid",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskByUuidResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据TaskId获取Task信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskByUuidRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskByUuidResponse
        /// </returns>
        public GetTaskByUuidResponse GetTaskByUuid(GetTaskByUuidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskByUuidWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据TaskId获取Task信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskByUuidRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskByUuidResponse
        /// </returns>
        public async Task<GetTaskByUuidResponse> GetTaskByUuidAsync(GetTaskByUuidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskByUuidWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetVersion</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVersionResponse
        /// </returns>
        public GetVersionResponse GetVersionWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVersion",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetVersion</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVersionResponse
        /// </returns>
        public async Task<GetVersionResponse> GetVersionWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVersion",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetVersion</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetVersionResponse
        /// </returns>
        public GetVersionResponse GetVersion()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVersionWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetVersion</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetVersionResponse
        /// </returns>
        public async Task<GetVersionResponse> GetVersionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVersionWithOptionsAsync(runtime);
        }

        /// <param name="request">
        /// ImportScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportScriptResponse
        /// </returns>
        public ImportScriptResponse ImportScriptWithOptions(ImportScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluEngine))
            {
                query["NluEngine"] = request.NluEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureUrl))
            {
                query["SignatureUrl"] = request.SignatureUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ImportScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportScriptResponse
        /// </returns>
        public async Task<ImportScriptResponse> ImportScriptWithOptionsAsync(ImportScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluEngine))
            {
                query["NluEngine"] = request.NluEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureUrl))
            {
                query["SignatureUrl"] = request.SignatureUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ImportScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportScriptResponse
        /// </returns>
        public ImportScriptResponse ImportScript(ImportScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportScriptWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ImportScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportScriptResponse
        /// </returns>
        public async Task<ImportScriptResponse> ImportScriptAsync(ImportScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportScriptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>InflightTaskTimeout</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InflightTaskTimeoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InflightTaskTimeoutResponse
        /// </returns>
        public InflightTaskTimeoutResponse InflightTaskTimeoutWithOptions(InflightTaskTimeoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InflightTaskTimeout",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InflightTaskTimeoutResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>InflightTaskTimeout</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InflightTaskTimeoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InflightTaskTimeoutResponse
        /// </returns>
        public async Task<InflightTaskTimeoutResponse> InflightTaskTimeoutWithOptionsAsync(InflightTaskTimeoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InflightTaskTimeout",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InflightTaskTimeoutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>InflightTaskTimeout</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InflightTaskTimeoutRequest
        /// </param>
        /// 
        /// <returns>
        /// InflightTaskTimeoutResponse
        /// </returns>
        public InflightTaskTimeoutResponse InflightTaskTimeout(InflightTaskTimeoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InflightTaskTimeoutWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>InflightTaskTimeout</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InflightTaskTimeoutRequest
        /// </param>
        /// 
        /// <returns>
        /// InflightTaskTimeoutResponse
        /// </returns>
        public async Task<InflightTaskTimeoutResponse> InflightTaskTimeoutAsync(InflightTaskTimeoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InflightTaskTimeoutWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAgentProfilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentProfilesResponse
        /// </returns>
        public ListAgentProfilesResponse ListAgentProfilesWithOptions(ListAgentProfilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIp))
            {
                body["AppIp"] = request.AppIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                body["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentProfiles",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentProfilesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAgentProfilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentProfilesResponse
        /// </returns>
        public async Task<ListAgentProfilesResponse> ListAgentProfilesWithOptionsAsync(ListAgentProfilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIp))
            {
                body["AppIp"] = request.AppIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                body["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentProfiles",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentProfilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAgentProfilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentProfilesResponse
        /// </returns>
        public ListAgentProfilesResponse ListAgentProfiles(ListAgentProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAgentProfilesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAgentProfilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentProfilesResponse
        /// </returns>
        public async Task<ListAgentProfilesResponse> ListAgentProfilesAsync(ListAgentProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAgentProfilesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>租户绑定号码列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllTenantBindNumberBindingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllTenantBindNumberBindingResponse
        /// </returns>
        public ListAllTenantBindNumberBindingResponse ListAllTenantBindNumberBindingWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllTenantBindNumberBinding",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllTenantBindNumberBindingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>租户绑定号码列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllTenantBindNumberBindingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllTenantBindNumberBindingResponse
        /// </returns>
        public async Task<ListAllTenantBindNumberBindingResponse> ListAllTenantBindNumberBindingWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllTenantBindNumberBinding",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllTenantBindNumberBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>租户绑定号码列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListAllTenantBindNumberBindingResponse
        /// </returns>
        public ListAllTenantBindNumberBindingResponse ListAllTenantBindNumberBinding()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllTenantBindNumberBindingWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>租户绑定号码列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListAllTenantBindNumberBindingResponse
        /// </returns>
        public async Task<ListAllTenantBindNumberBindingResponse> ListAllTenantBindNumberBindingAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllTenantBindNumberBindingWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>标注中心</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnnotationMissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnnotationMissionResponse
        /// </returns>
        public ListAnnotationMissionResponse ListAnnotationMissionWithOptions(ListAnnotationMissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionId))
            {
                query["AnnotationMissionId"] = request.AnnotationMissionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionName))
            {
                query["AnnotationMissionName"] = request.AnnotationMissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationStatusListFilter))
            {
                query["AnnotationStatusListFilter"] = request.AnnotationStatusListFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationStatusListStringFilter))
            {
                query["AnnotationStatusListStringFilter"] = request.AnnotationStatusListStringFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEndFilter))
            {
                query["CreateTimeEndFilter"] = request.CreateTimeEndFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStartFilter))
            {
                query["CreateTimeStartFilter"] = request.CreateTimeStartFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
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
                Action = "ListAnnotationMission",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnnotationMissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>标注中心</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnnotationMissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnnotationMissionResponse
        /// </returns>
        public async Task<ListAnnotationMissionResponse> ListAnnotationMissionWithOptionsAsync(ListAnnotationMissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionId))
            {
                query["AnnotationMissionId"] = request.AnnotationMissionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionName))
            {
                query["AnnotationMissionName"] = request.AnnotationMissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationStatusListFilter))
            {
                query["AnnotationStatusListFilter"] = request.AnnotationStatusListFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationStatusListStringFilter))
            {
                query["AnnotationStatusListStringFilter"] = request.AnnotationStatusListStringFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEndFilter))
            {
                query["CreateTimeEndFilter"] = request.CreateTimeEndFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStartFilter))
            {
                query["CreateTimeStartFilter"] = request.CreateTimeStartFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
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
                Action = "ListAnnotationMission",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnnotationMissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>标注中心</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnnotationMissionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnnotationMissionResponse
        /// </returns>
        public ListAnnotationMissionResponse ListAnnotationMission(ListAnnotationMissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAnnotationMissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>标注中心</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnnotationMissionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnnotationMissionResponse
        /// </returns>
        public async Task<ListAnnotationMissionResponse> ListAnnotationMissionAsync(ListAnnotationMissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAnnotationMissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListAnnotationMissionSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnnotationMissionSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnnotationMissionSessionResponse
        /// </returns>
        public ListAnnotationMissionSessionResponse ListAnnotationMissionSessionWithOptions(ListAnnotationMissionSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionId))
            {
                query["AnnotationMissionId"] = request.AnnotationMissionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionSessionId))
            {
                query["AnnotationMissionSessionId"] = request.AnnotationMissionSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeStatusListJsonString))
            {
                query["IncludeStatusListJsonString"] = request.IncludeStatusListJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
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
                Action = "ListAnnotationMissionSession",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnnotationMissionSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListAnnotationMissionSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnnotationMissionSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnnotationMissionSessionResponse
        /// </returns>
        public async Task<ListAnnotationMissionSessionResponse> ListAnnotationMissionSessionWithOptionsAsync(ListAnnotationMissionSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionId))
            {
                query["AnnotationMissionId"] = request.AnnotationMissionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionSessionId))
            {
                query["AnnotationMissionSessionId"] = request.AnnotationMissionSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeStatusListJsonString))
            {
                query["IncludeStatusListJsonString"] = request.IncludeStatusListJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
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
                Action = "ListAnnotationMissionSession",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnnotationMissionSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListAnnotationMissionSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnnotationMissionSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnnotationMissionSessionResponse
        /// </returns>
        public ListAnnotationMissionSessionResponse ListAnnotationMissionSession(ListAnnotationMissionSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAnnotationMissionSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListAnnotationMissionSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnnotationMissionSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnnotationMissionSessionResponse
        /// </returns>
        public async Task<ListAnnotationMissionSessionResponse> ListAnnotationMissionSessionAsync(ListAnnotationMissionSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAnnotationMissionSessionWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListApiPluginsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiPluginsResponse
        /// </returns>
        public ListApiPluginsResponse ListApiPluginsWithOptions(ListApiPluginsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UuidsJson))
            {
                query["UuidsJson"] = request.UuidsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiPlugins",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiPluginsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListApiPluginsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiPluginsResponse
        /// </returns>
        public async Task<ListApiPluginsResponse> ListApiPluginsWithOptionsAsync(ListApiPluginsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UuidsJson))
            {
                query["UuidsJson"] = request.UuidsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiPlugins",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiPluginsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListApiPluginsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiPluginsResponse
        /// </returns>
        public ListApiPluginsResponse ListApiPlugins(ListApiPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApiPluginsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListApiPluginsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiPluginsResponse
        /// </returns>
        public async Task<ListApiPluginsResponse> ListApiPluginsAsync(ListApiPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApiPluginsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBeebotIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBeebotIntentResponse
        /// </returns>
        public ListBeebotIntentResponse ListBeebotIntentWithOptions(ListBeebotIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentName))
            {
                query["IntentName"] = request.IntentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBeebotIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBeebotIntentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBeebotIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBeebotIntentResponse
        /// </returns>
        public async Task<ListBeebotIntentResponse> ListBeebotIntentWithOptionsAsync(ListBeebotIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentName))
            {
                query["IntentName"] = request.IntentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBeebotIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBeebotIntentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBeebotIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBeebotIntentResponse
        /// </returns>
        public ListBeebotIntentResponse ListBeebotIntent(ListBeebotIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBeebotIntentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBeebotIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBeebotIntentResponse
        /// </returns>
        public async Task<ListBeebotIntentResponse> ListBeebotIntentAsync(ListBeebotIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBeebotIntentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBeebotIntentLgfRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBeebotIntentLgfResponse
        /// </returns>
        public ListBeebotIntentLgfResponse ListBeebotIntentLgfWithOptions(ListBeebotIntentLgfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LgfText))
            {
                query["LgfText"] = request.LgfText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBeebotIntentLgf",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBeebotIntentLgfResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBeebotIntentLgfRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBeebotIntentLgfResponse
        /// </returns>
        public async Task<ListBeebotIntentLgfResponse> ListBeebotIntentLgfWithOptionsAsync(ListBeebotIntentLgfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LgfText))
            {
                query["LgfText"] = request.LgfText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBeebotIntentLgf",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBeebotIntentLgfResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBeebotIntentLgfRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBeebotIntentLgfResponse
        /// </returns>
        public ListBeebotIntentLgfResponse ListBeebotIntentLgf(ListBeebotIntentLgfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBeebotIntentLgfWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBeebotIntentLgfRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBeebotIntentLgfResponse
        /// </returns>
        public async Task<ListBeebotIntentLgfResponse> ListBeebotIntentLgfAsync(ListBeebotIntentLgfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBeebotIntentLgfWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBeebotIntentUserSayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBeebotIntentUserSayResponse
        /// </returns>
        public ListBeebotIntentUserSayResponse ListBeebotIntentUserSayWithOptions(ListBeebotIntentUserSayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBeebotIntentUserSay",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBeebotIntentUserSayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBeebotIntentUserSayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBeebotIntentUserSayResponse
        /// </returns>
        public async Task<ListBeebotIntentUserSayResponse> ListBeebotIntentUserSayWithOptionsAsync(ListBeebotIntentUserSayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBeebotIntentUserSay",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBeebotIntentUserSayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBeebotIntentUserSayRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBeebotIntentUserSayResponse
        /// </returns>
        public ListBeebotIntentUserSayResponse ListBeebotIntentUserSay(ListBeebotIntentUserSayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBeebotIntentUserSayWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBeebotIntentUserSayRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBeebotIntentUserSayResponse
        /// </returns>
        public async Task<ListBeebotIntentUserSayResponse> ListBeebotIntentUserSayAsync(ListBeebotIntentUserSayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBeebotIntentUserSayWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListChatbotInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChatbotInstancesResponse
        /// </returns>
        public ListChatbotInstancesResponse ListChatbotInstancesWithOptions(ListChatbotInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
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
                Action = "ListChatbotInstances",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatbotInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListChatbotInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChatbotInstancesResponse
        /// </returns>
        public async Task<ListChatbotInstancesResponse> ListChatbotInstancesWithOptionsAsync(ListChatbotInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
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
                Action = "ListChatbotInstances",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatbotInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListChatbotInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChatbotInstancesResponse
        /// </returns>
        public ListChatbotInstancesResponse ListChatbotInstances(ListChatbotInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChatbotInstancesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListChatbotInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChatbotInstancesResponse
        /// </returns>
        public async Task<ListChatbotInstancesResponse> ListChatbotInstancesAsync(ListChatbotInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChatbotInstancesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListDialogueFlowsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDialogueFlowsResponse
        /// </returns>
        public ListDialogueFlowsResponse ListDialogueFlowsWithOptions(ListDialogueFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDialogueFlows",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDialogueFlowsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDialogueFlowsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDialogueFlowsResponse
        /// </returns>
        public async Task<ListDialogueFlowsResponse> ListDialogueFlowsWithOptionsAsync(ListDialogueFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDialogueFlows",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDialogueFlowsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDialogueFlowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDialogueFlowsResponse
        /// </returns>
        public ListDialogueFlowsResponse ListDialogueFlows(ListDialogueFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDialogueFlowsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListDialogueFlowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDialogueFlowsResponse
        /// </returns>
        public async Task<ListDialogueFlowsResponse> ListDialogueFlowsAsync(ListDialogueFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDialogueFlowsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListDownloadTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDownloadTasksResponse
        /// </returns>
        public ListDownloadTasksResponse ListDownloadTasksWithOptions(ListDownloadTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDownloadTasks",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDownloadTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDownloadTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDownloadTasksResponse
        /// </returns>
        public async Task<ListDownloadTasksResponse> ListDownloadTasksWithOptionsAsync(ListDownloadTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDownloadTasks",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDownloadTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDownloadTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDownloadTasksResponse
        /// </returns>
        public ListDownloadTasksResponse ListDownloadTasks(ListDownloadTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDownloadTasksWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListDownloadTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDownloadTasksResponse
        /// </returns>
        public async Task<ListDownloadTasksResponse> ListDownloadTasksAsync(ListDownloadTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDownloadTasksWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListFlashSmsTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsTemplatesResponse
        /// </returns>
        public ListFlashSmsTemplatesResponse ListFlashSmsTemplatesWithOptions(ListFlashSmsTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlashSmsTemplates",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlashSmsTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListFlashSmsTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsTemplatesResponse
        /// </returns>
        public async Task<ListFlashSmsTemplatesResponse> ListFlashSmsTemplatesWithOptionsAsync(ListFlashSmsTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlashSmsTemplates",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlashSmsTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListFlashSmsTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsTemplatesResponse
        /// </returns>
        public ListFlashSmsTemplatesResponse ListFlashSmsTemplates(ListFlashSmsTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlashSmsTemplatesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListFlashSmsTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsTemplatesResponse
        /// </returns>
        public async Task<ListFlashSmsTemplatesResponse> ListFlashSmsTemplatesAsync(ListFlashSmsTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlashSmsTemplatesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListGlobalQuestionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGlobalQuestionsResponse
        /// </returns>
        public ListGlobalQuestionsResponse ListGlobalQuestionsWithOptions(ListGlobalQuestionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGlobalQuestions",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGlobalQuestionsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListGlobalQuestionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGlobalQuestionsResponse
        /// </returns>
        public async Task<ListGlobalQuestionsResponse> ListGlobalQuestionsWithOptionsAsync(ListGlobalQuestionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGlobalQuestions",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGlobalQuestionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListGlobalQuestionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGlobalQuestionsResponse
        /// </returns>
        public ListGlobalQuestionsResponse ListGlobalQuestions(ListGlobalQuestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGlobalQuestionsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListGlobalQuestionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGlobalQuestionsResponse
        /// </returns>
        public async Task<ListGlobalQuestionsResponse> ListGlobalQuestionsAsync(ListGlobalQuestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGlobalQuestionsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>意图列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntentionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntentionsResponse
        /// </returns>
        public ListIntentionsResponse ListIntentionsWithOptions(ListIntentionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionDataSourceType))
            {
                query["AnnotationMissionDataSourceType"] = request.AnnotationMissionDataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotId))
            {
                query["BotId"] = request.BotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNick))
            {
                query["UserNick"] = request.UserNick;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntentions",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntentionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>意图列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntentionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntentionsResponse
        /// </returns>
        public async Task<ListIntentionsResponse> ListIntentionsWithOptionsAsync(ListIntentionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionDataSourceType))
            {
                query["AnnotationMissionDataSourceType"] = request.AnnotationMissionDataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotId))
            {
                query["BotId"] = request.BotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNick))
            {
                query["UserNick"] = request.UserNick;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntentions",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntentionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>意图列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntentionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntentionsResponse
        /// </returns>
        public ListIntentionsResponse ListIntentions(ListIntentionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIntentionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>意图列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntentionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntentionsResponse
        /// </returns>
        public async Task<ListIntentionsResponse> ListIntentionsAsync(ListIntentionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIntentionsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListIntentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntentsResponse
        /// </returns>
        public ListIntentsResponse ListIntentsWithOptions(ListIntentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntents",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntentsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListIntentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntentsResponse
        /// </returns>
        public async Task<ListIntentsResponse> ListIntentsWithOptionsAsync(ListIntentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntents",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListIntentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntentsResponse
        /// </returns>
        public ListIntentsResponse ListIntents(ListIntentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIntentsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListIntentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntentsResponse
        /// </returns>
        public async Task<ListIntentsResponse> ListIntentsAsync(ListIntentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIntentsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListJobGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobGroupsResponse
        /// </returns>
        public ListJobGroupsResponse ListJobGroupsWithOptions(ListJobGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncQuery))
            {
                query["AsyncQuery"] = request.AsyncQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupStatusFilter))
            {
                query["JobGroupStatusFilter"] = request.JobGroupStatusFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyMinConcurrencyEnabled))
            {
                query["OnlyMinConcurrencyEnabled"] = request.OnlyMinConcurrencyEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchText))
            {
                query["SearchText"] = request.SearchText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobGroups",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListJobGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobGroupsResponse
        /// </returns>
        public async Task<ListJobGroupsResponse> ListJobGroupsWithOptionsAsync(ListJobGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncQuery))
            {
                query["AsyncQuery"] = request.AsyncQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupStatusFilter))
            {
                query["JobGroupStatusFilter"] = request.JobGroupStatusFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyMinConcurrencyEnabled))
            {
                query["OnlyMinConcurrencyEnabled"] = request.OnlyMinConcurrencyEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchText))
            {
                query["SearchText"] = request.SearchText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobGroups",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListJobGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobGroupsResponse
        /// </returns>
        public ListJobGroupsResponse ListJobGroups(ListJobGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobGroupsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListJobGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobGroupsResponse
        /// </returns>
        public async Task<ListJobGroupsResponse> ListJobGroupsAsync(ListJobGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobGroupsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListJobGroupsAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobGroupsAsyncResponse
        /// </returns>
        public ListJobGroupsAsyncResponse ListJobGroupsAsyncWithOptions(ListJobGroupsAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobGroupsAsync",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobGroupsAsyncResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListJobGroupsAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobGroupsAsyncResponse
        /// </returns>
        public async Task<ListJobGroupsAsyncResponse> ListJobGroupsAsyncWithOptionsAsync(ListJobGroupsAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobGroupsAsync",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobGroupsAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListJobGroupsAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobGroupsAsyncResponse
        /// </returns>
        public ListJobGroupsAsyncResponse ListJobGroupsAsync(ListJobGroupsAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobGroupsAsyncWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListJobGroupsAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobGroupsAsyncResponse
        /// </returns>
        public async Task<ListJobGroupsAsyncResponse> ListJobGroupsAsyncAsync(ListJobGroupsAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobGroupsAsyncWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListJobs</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobsWithOptions(ListJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListJobs</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(ListJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListJobs</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListJobs</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListJobsByGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsByGroupResponse
        /// </returns>
        public ListJobsByGroupResponse ListJobsByGroupWithOptions(ListJobsByGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobFailureReason))
            {
                query["JobFailureReason"] = request.JobFailureReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatus))
            {
                query["JobStatus"] = request.JobStatus;
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
                Action = "ListJobsByGroup",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsByGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListJobsByGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsByGroupResponse
        /// </returns>
        public async Task<ListJobsByGroupResponse> ListJobsByGroupWithOptionsAsync(ListJobsByGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobFailureReason))
            {
                query["JobFailureReason"] = request.JobFailureReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatus))
            {
                query["JobStatus"] = request.JobStatus;
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
                Action = "ListJobsByGroup",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsByGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListJobsByGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsByGroupResponse
        /// </returns>
        public ListJobsByGroupResponse ListJobsByGroup(ListJobsByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobsByGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListJobsByGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsByGroupResponse
        /// </returns>
        public async Task<ListJobsByGroupResponse> ListJobsByGroupAsync(ListJobsByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobsByGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListOutboundCallNumbersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOutboundCallNumbersResponse
        /// </returns>
        public ListOutboundCallNumbersResponse ListOutboundCallNumbersWithOptions(ListOutboundCallNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListOutboundCallNumbers",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOutboundCallNumbersResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListOutboundCallNumbersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOutboundCallNumbersResponse
        /// </returns>
        public async Task<ListOutboundCallNumbersResponse> ListOutboundCallNumbersWithOptionsAsync(ListOutboundCallNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListOutboundCallNumbers",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOutboundCallNumbersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListOutboundCallNumbersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOutboundCallNumbersResponse
        /// </returns>
        public ListOutboundCallNumbersResponse ListOutboundCallNumbers(ListOutboundCallNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOutboundCallNumbersWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListOutboundCallNumbersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOutboundCallNumbersResponse
        /// </returns>
        public async Task<ListOutboundCallNumbersResponse> ListOutboundCallNumbersAsync(ListOutboundCallNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOutboundCallNumbersWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListResourceTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTagsResponse
        /// </returns>
        public ListResourceTagsResponse ListResourceTagsWithOptions(ListResourceTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListResourceTags",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListResourceTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTagsResponse
        /// </returns>
        public async Task<ListResourceTagsResponse> ListResourceTagsWithOptionsAsync(ListResourceTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListResourceTags",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListResourceTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTagsResponse
        /// </returns>
        public ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceTagsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListResourceTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTagsResponse
        /// </returns>
        public async Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceTagsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListScriptPublishHistoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptPublishHistoriesResponse
        /// </returns>
        public ListScriptPublishHistoriesResponse ListScriptPublishHistoriesWithOptions(ListScriptPublishHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScriptPublishHistories",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptPublishHistoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListScriptPublishHistoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptPublishHistoriesResponse
        /// </returns>
        public async Task<ListScriptPublishHistoriesResponse> ListScriptPublishHistoriesWithOptionsAsync(ListScriptPublishHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScriptPublishHistories",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptPublishHistoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListScriptPublishHistoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptPublishHistoriesResponse
        /// </returns>
        public ListScriptPublishHistoriesResponse ListScriptPublishHistories(ListScriptPublishHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScriptPublishHistoriesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListScriptPublishHistoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptPublishHistoriesResponse
        /// </returns>
        public async Task<ListScriptPublishHistoriesResponse> ListScriptPublishHistoriesAsync(ListScriptPublishHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScriptPublishHistoriesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListScriptRecordingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptRecordingResponse
        /// </returns>
        public ListScriptRecordingResponse ListScriptRecordingWithOptions(ListScriptRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefIdsJson))
            {
                query["RefIdsJson"] = request.RefIdsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatesJson))
            {
                query["StatesJson"] = request.StatesJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UuidsJson))
            {
                query["UuidsJson"] = request.UuidsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScriptRecording",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptRecordingResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListScriptRecordingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptRecordingResponse
        /// </returns>
        public async Task<ListScriptRecordingResponse> ListScriptRecordingWithOptionsAsync(ListScriptRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefIdsJson))
            {
                query["RefIdsJson"] = request.RefIdsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatesJson))
            {
                query["StatesJson"] = request.StatesJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UuidsJson))
            {
                query["UuidsJson"] = request.UuidsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScriptRecording",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptRecordingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListScriptRecordingRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptRecordingResponse
        /// </returns>
        public ListScriptRecordingResponse ListScriptRecording(ListScriptRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScriptRecordingWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListScriptRecordingRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptRecordingResponse
        /// </returns>
        public async Task<ListScriptRecordingResponse> ListScriptRecordingAsync(ListScriptRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScriptRecordingWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListScriptVoiceConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptVoiceConfigsResponse
        /// </returns>
        public ListScriptVoiceConfigsResponse ListScriptVoiceConfigsWithOptions(ListScriptVoiceConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScriptVoiceConfigs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptVoiceConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListScriptVoiceConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptVoiceConfigsResponse
        /// </returns>
        public async Task<ListScriptVoiceConfigsResponse> ListScriptVoiceConfigsWithOptionsAsync(ListScriptVoiceConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScriptVoiceConfigs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptVoiceConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListScriptVoiceConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptVoiceConfigsResponse
        /// </returns>
        public ListScriptVoiceConfigsResponse ListScriptVoiceConfigs(ListScriptVoiceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScriptVoiceConfigsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListScriptVoiceConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptVoiceConfigsResponse
        /// </returns>
        public async Task<ListScriptVoiceConfigsResponse> ListScriptVoiceConfigsAsync(ListScriptVoiceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScriptVoiceConfigsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptsResponse
        /// </returns>
        public ListScriptsResponse ListScriptsWithOptions(ListScriptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluEngine))
            {
                query["NluEngine"] = request.NluEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptName))
            {
                query["ScriptName"] = request.ScriptName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScripts",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptsResponse
        /// </returns>
        public async Task<ListScriptsResponse> ListScriptsWithOptionsAsync(ListScriptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluEngine))
            {
                query["NluEngine"] = request.NluEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptName))
            {
                query["ScriptName"] = request.ScriptName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScripts",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptsResponse
        /// </returns>
        public ListScriptsResponse ListScripts(ListScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScriptsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptsResponse
        /// </returns>
        public async Task<ListScriptsResponse> ListScriptsAsync(ListScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScriptsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2019-12-26",
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

        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2019-12-26",
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
            return ListTagResourcesWithOptions(request, runtime);
        }

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
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagsResponse
        /// </returns>
        public ListTagsResponse ListTagsWithOptions(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTags",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagsResponse
        /// </returns>
        public async Task<ListTagsResponse> ListTagsWithOptionsAsync(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTags",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagsResponse
        /// </returns>
        public ListTagsResponse ListTags(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagsResponse
        /// </returns>
        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagsWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// ModifyAgentProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAgentProfileResponse
        /// </returns>
        public ModifyAgentProfileResponse ModifyAgentProfileWithOptions(ModifyAgentProfileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAgentProfileShrinkRequest request = new ModifyAgentProfileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FaqCategoryIds))
            {
                request.FaqCategoryIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FaqCategoryIds, "FaqCategoryIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProfileId))
            {
                body["AgentProfileId"] = request.AgentProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiPluginJson))
            {
                body["ApiPluginJson"] = request.ApiPluginJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaqCategoryIdsShrink))
            {
                body["FaqCategoryIds"] = request.FaqCategoryIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstructionJson))
            {
                body["InstructionJson"] = request.InstructionJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsJson))
            {
                body["LabelsJson"] = request.LabelsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfig))
            {
                body["ModelConfig"] = request.ModelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptJson))
            {
                body["PromptJson"] = request.PromptJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["Scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VariablesJson))
            {
                body["VariablesJson"] = request.VariablesJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAgentProfile",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAgentProfileResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// ModifyAgentProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAgentProfileResponse
        /// </returns>
        public async Task<ModifyAgentProfileResponse> ModifyAgentProfileWithOptionsAsync(ModifyAgentProfileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAgentProfileShrinkRequest request = new ModifyAgentProfileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FaqCategoryIds))
            {
                request.FaqCategoryIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FaqCategoryIds, "FaqCategoryIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProfileId))
            {
                body["AgentProfileId"] = request.AgentProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiPluginJson))
            {
                body["ApiPluginJson"] = request.ApiPluginJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaqCategoryIdsShrink))
            {
                body["FaqCategoryIds"] = request.FaqCategoryIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstructionJson))
            {
                body["InstructionJson"] = request.InstructionJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsJson))
            {
                body["LabelsJson"] = request.LabelsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfig))
            {
                body["ModelConfig"] = request.ModelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptJson))
            {
                body["PromptJson"] = request.PromptJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["Scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VariablesJson))
            {
                body["VariablesJson"] = request.VariablesJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAgentProfile",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAgentProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyAgentProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAgentProfileResponse
        /// </returns>
        public ModifyAgentProfileResponse ModifyAgentProfile(ModifyAgentProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAgentProfileWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyAgentProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAgentProfileResponse
        /// </returns>
        public async Task<ModifyAgentProfileResponse> ModifyAgentProfileAsync(ModifyAgentProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAgentProfileWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyAnnotationMissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAnnotationMissionResponse
        /// </returns>
        public ModifyAnnotationMissionResponse ModifyAnnotationMissionWithOptions(ModifyAnnotationMissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionId))
            {
                query["AnnotationMissionId"] = request.AnnotationMissionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionName))
            {
                query["AnnotationMissionName"] = request.AnnotationMissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationStatus))
            {
                query["AnnotationStatus"] = request.AnnotationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delete))
            {
                query["Delete"] = request.Delete;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAnnotationMission",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAnnotationMissionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyAnnotationMissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAnnotationMissionResponse
        /// </returns>
        public async Task<ModifyAnnotationMissionResponse> ModifyAnnotationMissionWithOptionsAsync(ModifyAnnotationMissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionId))
            {
                query["AnnotationMissionId"] = request.AnnotationMissionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionName))
            {
                query["AnnotationMissionName"] = request.AnnotationMissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationStatus))
            {
                query["AnnotationStatus"] = request.AnnotationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delete))
            {
                query["Delete"] = request.Delete;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAnnotationMission",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAnnotationMissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyAnnotationMissionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAnnotationMissionResponse
        /// </returns>
        public ModifyAnnotationMissionResponse ModifyAnnotationMission(ModifyAnnotationMissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAnnotationMissionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyAnnotationMissionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAnnotationMissionResponse
        /// </returns>
        public async Task<ModifyAnnotationMissionResponse> ModifyAnnotationMissionAsync(ModifyAnnotationMissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAnnotationMissionWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyBatchJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBatchJobsResponse
        /// </returns>
        public ModifyBatchJobsResponse ModifyBatchJobsWithOptions(ModifyBatchJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchJobName))
            {
                query["BatchJobName"] = request.BatchJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobFilePath))
            {
                query["JobFilePath"] = request.JobFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                query["StrategyJson"] = request.StrategyJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Submitted))
            {
                query["Submitted"] = request.Submitted;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBatchJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBatchJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyBatchJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBatchJobsResponse
        /// </returns>
        public async Task<ModifyBatchJobsResponse> ModifyBatchJobsWithOptionsAsync(ModifyBatchJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchJobName))
            {
                query["BatchJobName"] = request.BatchJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobFilePath))
            {
                query["JobFilePath"] = request.JobFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                query["StrategyJson"] = request.StrategyJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Submitted))
            {
                query["Submitted"] = request.Submitted;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBatchJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBatchJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyBatchJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBatchJobsResponse
        /// </returns>
        public ModifyBatchJobsResponse ModifyBatchJobs(ModifyBatchJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBatchJobsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyBatchJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBatchJobsResponse
        /// </returns>
        public async Task<ModifyBatchJobsResponse> ModifyBatchJobsAsync(ModifyBatchJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBatchJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyBeebotIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBeebotIntentResponse
        /// </returns>
        public ModifyBeebotIntentResponse ModifyBeebotIntentWithOptions(ModifyBeebotIntentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyBeebotIntentShrinkRequest request = new ModifyBeebotIntentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IntentDefinition))
            {
                request.IntentDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IntentDefinition, "IntentDefinition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentDefinitionShrink))
            {
                query["IntentDefinition"] = request.IntentDefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBeebotIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBeebotIntentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyBeebotIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBeebotIntentResponse
        /// </returns>
        public async Task<ModifyBeebotIntentResponse> ModifyBeebotIntentWithOptionsAsync(ModifyBeebotIntentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyBeebotIntentShrinkRequest request = new ModifyBeebotIntentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IntentDefinition))
            {
                request.IntentDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IntentDefinition, "IntentDefinition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentDefinitionShrink))
            {
                query["IntentDefinition"] = request.IntentDefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBeebotIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBeebotIntentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBeebotIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBeebotIntentResponse
        /// </returns>
        public ModifyBeebotIntentResponse ModifyBeebotIntent(ModifyBeebotIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBeebotIntentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyBeebotIntent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBeebotIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBeebotIntentResponse
        /// </returns>
        public async Task<ModifyBeebotIntentResponse> ModifyBeebotIntentAsync(ModifyBeebotIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBeebotIntentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyBeebotIntentLgfRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBeebotIntentLgfResponse
        /// </returns>
        public ModifyBeebotIntentLgfResponse ModifyBeebotIntentLgfWithOptions(ModifyBeebotIntentLgfRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyBeebotIntentLgfShrinkRequest request = new ModifyBeebotIntentLgfShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LgfDefinition))
            {
                request.LgfDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LgfDefinition, "LgfDefinition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LgfDefinitionShrink))
            {
                query["LgfDefinition"] = request.LgfDefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LgfId))
            {
                query["LgfId"] = request.LgfId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBeebotIntentLgf",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBeebotIntentLgfResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyBeebotIntentLgfRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBeebotIntentLgfResponse
        /// </returns>
        public async Task<ModifyBeebotIntentLgfResponse> ModifyBeebotIntentLgfWithOptionsAsync(ModifyBeebotIntentLgfRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyBeebotIntentLgfShrinkRequest request = new ModifyBeebotIntentLgfShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LgfDefinition))
            {
                request.LgfDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LgfDefinition, "LgfDefinition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LgfDefinitionShrink))
            {
                query["LgfDefinition"] = request.LgfDefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LgfId))
            {
                query["LgfId"] = request.LgfId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBeebotIntentLgf",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBeebotIntentLgfResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBeebotIntentLgfRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBeebotIntentLgfResponse
        /// </returns>
        public ModifyBeebotIntentLgfResponse ModifyBeebotIntentLgf(ModifyBeebotIntentLgfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBeebotIntentLgfWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyBeebotIntentLgf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBeebotIntentLgfRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBeebotIntentLgfResponse
        /// </returns>
        public async Task<ModifyBeebotIntentLgfResponse> ModifyBeebotIntentLgfAsync(ModifyBeebotIntentLgfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBeebotIntentLgfWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyBeebotIntentUserSayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBeebotIntentUserSayResponse
        /// </returns>
        public ModifyBeebotIntentUserSayResponse ModifyBeebotIntentUserSayWithOptions(ModifyBeebotIntentUserSayRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyBeebotIntentUserSayShrinkRequest request = new ModifyBeebotIntentUserSayShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserSayDefinition))
            {
                request.UserSayDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserSayDefinition, "UserSayDefinition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSayDefinitionShrink))
            {
                query["UserSayDefinition"] = request.UserSayDefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSayId))
            {
                query["UserSayId"] = request.UserSayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBeebotIntentUserSay",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBeebotIntentUserSayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyBeebotIntentUserSayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBeebotIntentUserSayResponse
        /// </returns>
        public async Task<ModifyBeebotIntentUserSayResponse> ModifyBeebotIntentUserSayWithOptionsAsync(ModifyBeebotIntentUserSayRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyBeebotIntentUserSayShrinkRequest request = new ModifyBeebotIntentUserSayShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserSayDefinition))
            {
                request.UserSayDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserSayDefinition, "UserSayDefinition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSayDefinitionShrink))
            {
                query["UserSayDefinition"] = request.UserSayDefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSayId))
            {
                query["UserSayId"] = request.UserSayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBeebotIntentUserSay",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBeebotIntentUserSayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBeebotIntentUserSayRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBeebotIntentUserSayResponse
        /// </returns>
        public ModifyBeebotIntentUserSayResponse ModifyBeebotIntentUserSay(ModifyBeebotIntentUserSayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBeebotIntentUserSayWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyBeebotIntentUserSay</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBeebotIntentUserSayRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBeebotIntentUserSayResponse
        /// </returns>
        public async Task<ModifyBeebotIntentUserSayResponse> ModifyBeebotIntentUserSayAsync(ModifyBeebotIntentUserSayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBeebotIntentUserSayWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyDialogueFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDialogueFlowResponse
        /// </returns>
        public ModifyDialogueFlowResponse ModifyDialogueFlowWithOptions(ModifyDialogueFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueFlowDefinition))
            {
                query["DialogueFlowDefinition"] = request.DialogueFlowDefinition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueFlowId))
            {
                query["DialogueFlowId"] = request.DialogueFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDrafted))
            {
                query["IsDrafted"] = request.IsDrafted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDialogueFlow",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDialogueFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyDialogueFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDialogueFlowResponse
        /// </returns>
        public async Task<ModifyDialogueFlowResponse> ModifyDialogueFlowWithOptionsAsync(ModifyDialogueFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueFlowDefinition))
            {
                query["DialogueFlowDefinition"] = request.DialogueFlowDefinition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueFlowId))
            {
                query["DialogueFlowId"] = request.DialogueFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDrafted))
            {
                query["IsDrafted"] = request.IsDrafted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDialogueFlow",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDialogueFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyDialogueFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDialogueFlowResponse
        /// </returns>
        public ModifyDialogueFlowResponse ModifyDialogueFlow(ModifyDialogueFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDialogueFlowWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyDialogueFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDialogueFlowResponse
        /// </returns>
        public async Task<ModifyDialogueFlowResponse> ModifyDialogueFlowAsync(ModifyDialogueFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDialogueFlowWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyEmptyNumberNoMoreCallsInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyEmptyNumberNoMoreCallsInfoResponse
        /// </returns>
        public ModifyEmptyNumberNoMoreCallsInfoResponse ModifyEmptyNumberNoMoreCallsInfoWithOptions(ModifyEmptyNumberNoMoreCallsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmptyNumberNoMoreCalls))
            {
                query["EmptyNumberNoMoreCalls"] = request.EmptyNumberNoMoreCalls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyEmptyNumberNoMoreCallsInfo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyEmptyNumberNoMoreCallsInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyEmptyNumberNoMoreCallsInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyEmptyNumberNoMoreCallsInfoResponse
        /// </returns>
        public async Task<ModifyEmptyNumberNoMoreCallsInfoResponse> ModifyEmptyNumberNoMoreCallsInfoWithOptionsAsync(ModifyEmptyNumberNoMoreCallsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmptyNumberNoMoreCalls))
            {
                query["EmptyNumberNoMoreCalls"] = request.EmptyNumberNoMoreCalls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyEmptyNumberNoMoreCallsInfo",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyEmptyNumberNoMoreCallsInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyEmptyNumberNoMoreCallsInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyEmptyNumberNoMoreCallsInfoResponse
        /// </returns>
        public ModifyEmptyNumberNoMoreCallsInfoResponse ModifyEmptyNumberNoMoreCallsInfo(ModifyEmptyNumberNoMoreCallsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEmptyNumberNoMoreCallsInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyEmptyNumberNoMoreCallsInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyEmptyNumberNoMoreCallsInfoResponse
        /// </returns>
        public async Task<ModifyEmptyNumberNoMoreCallsInfoResponse> ModifyEmptyNumberNoMoreCallsInfoAsync(ModifyEmptyNumberNoMoreCallsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEmptyNumberNoMoreCallsInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyGlobalQuestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyGlobalQuestionResponse
        /// </returns>
        public ModifyGlobalQuestionResponse ModifyGlobalQuestionWithOptions(ModifyGlobalQuestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Answers))
            {
                query["Answers"] = request.Answers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionId))
            {
                query["GlobalQuestionId"] = request.GlobalQuestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionName))
            {
                query["GlobalQuestionName"] = request.GlobalQuestionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionType))
            {
                query["GlobalQuestionType"] = request.GlobalQuestionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Questions))
            {
                query["Questions"] = request.Questions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGlobalQuestion",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGlobalQuestionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyGlobalQuestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyGlobalQuestionResponse
        /// </returns>
        public async Task<ModifyGlobalQuestionResponse> ModifyGlobalQuestionWithOptionsAsync(ModifyGlobalQuestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Answers))
            {
                query["Answers"] = request.Answers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionId))
            {
                query["GlobalQuestionId"] = request.GlobalQuestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionName))
            {
                query["GlobalQuestionName"] = request.GlobalQuestionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalQuestionType))
            {
                query["GlobalQuestionType"] = request.GlobalQuestionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Questions))
            {
                query["Questions"] = request.Questions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGlobalQuestion",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGlobalQuestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyGlobalQuestionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyGlobalQuestionResponse
        /// </returns>
        public ModifyGlobalQuestionResponse ModifyGlobalQuestion(ModifyGlobalQuestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGlobalQuestionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyGlobalQuestionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyGlobalQuestionResponse
        /// </returns>
        public async Task<ModifyGlobalQuestionResponse> ModifyGlobalQuestionAsync(ModifyGlobalQuestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGlobalQuestionWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceResponse
        /// </returns>
        public ModifyInstanceResponse ModifyInstanceWithOptions(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceDescription))
            {
                query["InstanceDescription"] = request.InstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrentConversation))
            {
                query["MaxConcurrentConversation"] = request.MaxConcurrentConversation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstance",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceResponse
        /// </returns>
        public async Task<ModifyInstanceResponse> ModifyInstanceWithOptionsAsync(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceDescription))
            {
                query["InstanceDescription"] = request.InstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrentConversation))
            {
                query["MaxConcurrentConversation"] = request.MaxConcurrentConversation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstance",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceResponse
        /// </returns>
        public ModifyInstanceResponse ModifyInstance(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceResponse
        /// </returns>
        public async Task<ModifyInstanceResponse> ModifyInstanceAsync(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyIntentResponse
        /// </returns>
        public ModifyIntentResponse ModifyIntentWithOptions(ModifyIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentDescription))
            {
                query["IntentDescription"] = request.IntentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentName))
            {
                query["IntentName"] = request.IntentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterances))
            {
                query["Utterances"] = request.Utterances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIntentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyIntentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyIntentResponse
        /// </returns>
        public async Task<ModifyIntentResponse> ModifyIntentWithOptionsAsync(ModifyIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentDescription))
            {
                query["IntentDescription"] = request.IntentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentId))
            {
                query["IntentId"] = request.IntentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentName))
            {
                query["IntentName"] = request.IntentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterances))
            {
                query["Utterances"] = request.Utterances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIntent",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIntentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyIntentResponse
        /// </returns>
        public ModifyIntentResponse ModifyIntent(ModifyIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIntentWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyIntentRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyIntentResponse
        /// </returns>
        public async Task<ModifyIntentResponse> ModifyIntentAsync(ModifyIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIntentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改任务组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyJobGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyJobGroupResponse
        /// </returns>
        public ModifyJobGroupResponse ModifyJobGroupWithOptions(ModifyJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsExtras))
            {
                query["FlashSmsExtras"] = request.FlashSmsExtras;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupStatus))
            {
                query["JobGroupStatus"] = request.JobGroupStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinConcurrency))
            {
                query["MinConcurrency"] = request.MinConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallCallingNumber))
            {
                query["RecallCallingNumber"] = request.RecallCallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallStrategyJson))
            {
                query["RecallStrategyJson"] = request.RecallStrategyJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingingDuration))
            {
                query["RingingDuration"] = request.RingingDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                query["StrategyJson"] = request.StrategyJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyJobGroup",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyJobGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改任务组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyJobGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyJobGroupResponse
        /// </returns>
        public async Task<ModifyJobGroupResponse> ModifyJobGroupWithOptionsAsync(ModifyJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsExtras))
            {
                query["FlashSmsExtras"] = request.FlashSmsExtras;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupStatus))
            {
                query["JobGroupStatus"] = request.JobGroupStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinConcurrency))
            {
                query["MinConcurrency"] = request.MinConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallCallingNumber))
            {
                query["RecallCallingNumber"] = request.RecallCallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallStrategyJson))
            {
                query["RecallStrategyJson"] = request.RecallStrategyJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingingDuration))
            {
                query["RingingDuration"] = request.RingingDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyJson))
            {
                query["StrategyJson"] = request.StrategyJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyJobGroup",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyJobGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改任务组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyJobGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyJobGroupResponse
        /// </returns>
        public ModifyJobGroupResponse ModifyJobGroup(ModifyJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyJobGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改任务组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyJobGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyJobGroupResponse
        /// </returns>
        public async Task<ModifyJobGroupResponse> ModifyJobGroupAsync(ModifyJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyJobGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyOutboundCallNumber</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyOutboundCallNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyOutboundCallNumberResponse
        /// </returns>
        public ModifyOutboundCallNumberResponse ModifyOutboundCallNumberWithOptions(ModifyOutboundCallNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundCallNumberId))
            {
                query["OutboundCallNumberId"] = request.OutboundCallNumberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RateLimitCount))
            {
                query["RateLimitCount"] = request.RateLimitCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RateLimitPeriod))
            {
                query["RateLimitPeriod"] = request.RateLimitPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyOutboundCallNumber",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOutboundCallNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyOutboundCallNumber</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyOutboundCallNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyOutboundCallNumberResponse
        /// </returns>
        public async Task<ModifyOutboundCallNumberResponse> ModifyOutboundCallNumberWithOptionsAsync(ModifyOutboundCallNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundCallNumberId))
            {
                query["OutboundCallNumberId"] = request.OutboundCallNumberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RateLimitCount))
            {
                query["RateLimitCount"] = request.RateLimitCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RateLimitPeriod))
            {
                query["RateLimitPeriod"] = request.RateLimitPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyOutboundCallNumber",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOutboundCallNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyOutboundCallNumber</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyOutboundCallNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyOutboundCallNumberResponse
        /// </returns>
        public ModifyOutboundCallNumberResponse ModifyOutboundCallNumber(ModifyOutboundCallNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyOutboundCallNumberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyOutboundCallNumber</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyOutboundCallNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyOutboundCallNumberResponse
        /// </returns>
        public async Task<ModifyOutboundCallNumberResponse> ModifyOutboundCallNumberAsync(ModifyOutboundCallNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyOutboundCallNumberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyScriptResponse
        /// </returns>
        public ModifyScriptResponse ModifyScriptWithOptions(ModifyScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentLlm))
            {
                query["AgentLlm"] = request.AgentLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrConfig))
            {
                query["AsrConfig"] = request.AsrConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatConfig))
            {
                query["ChatConfig"] = request.ChatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                query["ChatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmotionEnable))
            {
                query["EmotionEnable"] = request.EmotionEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["Industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelConfig))
            {
                query["LabelConfig"] = request.LabelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LongWaitEnable))
            {
                query["LongWaitEnable"] = request.LongWaitEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniPlaybackConfigListJsonString))
            {
                query["MiniPlaybackConfigListJsonString"] = request.MiniPlaybackConfigListJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniPlaybackEnable))
            {
                query["MiniPlaybackEnable"] = request.MiniPlaybackEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewBargeInEnable))
            {
                query["NewBargeInEnable"] = request.NewBargeInEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlsConfig))
            {
                query["NlsConfig"] = request.NlsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluAccessType))
            {
                query["NluAccessType"] = request.NluAccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluEngine))
            {
                query["NluEngine"] = request.NluEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptContent))
            {
                query["ScriptContent"] = request.ScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptDescription))
            {
                query["ScriptDescription"] = request.ScriptDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptName))
            {
                query["ScriptName"] = request.ScriptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptWaveform))
            {
                query["ScriptWaveform"] = request.ScriptWaveform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsConfig))
            {
                query["TtsConfig"] = request.TtsConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyScriptResponse
        /// </returns>
        public async Task<ModifyScriptResponse> ModifyScriptWithOptionsAsync(ModifyScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentLlm))
            {
                query["AgentLlm"] = request.AgentLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrConfig))
            {
                query["AsrConfig"] = request.AsrConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatConfig))
            {
                query["ChatConfig"] = request.ChatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                query["ChatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmotionEnable))
            {
                query["EmotionEnable"] = request.EmotionEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["Industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelConfig))
            {
                query["LabelConfig"] = request.LabelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LongWaitEnable))
            {
                query["LongWaitEnable"] = request.LongWaitEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniPlaybackConfigListJsonString))
            {
                query["MiniPlaybackConfigListJsonString"] = request.MiniPlaybackConfigListJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniPlaybackEnable))
            {
                query["MiniPlaybackEnable"] = request.MiniPlaybackEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewBargeInEnable))
            {
                query["NewBargeInEnable"] = request.NewBargeInEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlsConfig))
            {
                query["NlsConfig"] = request.NlsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluAccessType))
            {
                query["NluAccessType"] = request.NluAccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluEngine))
            {
                query["NluEngine"] = request.NluEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptContent))
            {
                query["ScriptContent"] = request.ScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptDescription))
            {
                query["ScriptDescription"] = request.ScriptDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptName))
            {
                query["ScriptName"] = request.ScriptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptWaveform))
            {
                query["ScriptWaveform"] = request.ScriptWaveform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsConfig))
            {
                query["TtsConfig"] = request.TtsConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyScriptResponse
        /// </returns>
        public ModifyScriptResponse ModifyScript(ModifyScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScriptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyScriptResponse
        /// </returns>
        public async Task<ModifyScriptResponse> ModifyScriptAsync(ModifyScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScriptWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyScriptVoiceConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyScriptVoiceConfigResponse
        /// </returns>
        public ModifyScriptVoiceConfigResponse ModifyScriptVoiceConfigWithOptions(ModifyScriptVoiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptVoiceConfigId))
            {
                query["ScriptVoiceConfigId"] = request.ScriptVoiceConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptWaveformRelation))
            {
                query["ScriptWaveformRelation"] = request.ScriptWaveformRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScriptVoiceConfig",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScriptVoiceConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyScriptVoiceConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyScriptVoiceConfigResponse
        /// </returns>
        public async Task<ModifyScriptVoiceConfigResponse> ModifyScriptVoiceConfigWithOptionsAsync(ModifyScriptVoiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptVoiceConfigId))
            {
                query["ScriptVoiceConfigId"] = request.ScriptVoiceConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptWaveformRelation))
            {
                query["ScriptWaveformRelation"] = request.ScriptWaveformRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScriptVoiceConfig",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScriptVoiceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyScriptVoiceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyScriptVoiceConfigResponse
        /// </returns>
        public ModifyScriptVoiceConfigResponse ModifyScriptVoiceConfig(ModifyScriptVoiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScriptVoiceConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyScriptVoiceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyScriptVoiceConfigResponse
        /// </returns>
        public async Task<ModifyScriptVoiceConfigResponse> ModifyScriptVoiceConfigAsync(ModifyScriptVoiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScriptVoiceConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyTTSConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTTSConfigResponse
        /// </returns>
        public ModifyTTSConfigResponse ModifyTTSConfigWithOptions(ModifyTTSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlsServiceType))
            {
                query["NlsServiceType"] = request.NlsServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PitchRate))
            {
                query["PitchRate"] = request.PitchRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeechRate))
            {
                query["SpeechRate"] = request.SpeechRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voice))
            {
                query["Voice"] = request.Voice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTTSConfig",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTTSConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyTTSConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTTSConfigResponse
        /// </returns>
        public async Task<ModifyTTSConfigResponse> ModifyTTSConfigWithOptionsAsync(ModifyTTSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlsServiceType))
            {
                query["NlsServiceType"] = request.NlsServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PitchRate))
            {
                query["PitchRate"] = request.PitchRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeechRate))
            {
                query["SpeechRate"] = request.SpeechRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voice))
            {
                query["Voice"] = request.Voice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTTSConfig",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTTSConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyTTSConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTTSConfigResponse
        /// </returns>
        public ModifyTTSConfigResponse ModifyTTSConfig(ModifyTTSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTTSConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyTTSConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTTSConfigResponse
        /// </returns>
        public async Task<ModifyTTSConfigResponse> ModifyTTSConfigAsync(ModifyTTSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTTSConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyTagGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTagGroupsResponse
        /// </returns>
        public ModifyTagGroupsResponse ModifyTagGroupsWithOptions(ModifyTagGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagGroups))
            {
                query["TagGroups"] = request.TagGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTagGroups",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTagGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyTagGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTagGroupsResponse
        /// </returns>
        public async Task<ModifyTagGroupsResponse> ModifyTagGroupsWithOptionsAsync(ModifyTagGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagGroups))
            {
                query["TagGroups"] = request.TagGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTagGroups",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTagGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyTagGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTagGroupsResponse
        /// </returns>
        public ModifyTagGroupsResponse ModifyTagGroups(ModifyTagGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTagGroupsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyTagGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTagGroupsResponse
        /// </returns>
        public async Task<ModifyTagGroupsResponse> ModifyTagGroupsAsync(ModifyTagGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTagGroupsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// PublishScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishScriptResponse
        /// </returns>
        public PublishScriptResponse PublishScriptWithOptions(PublishScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// PublishScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishScriptResponse
        /// </returns>
        public async Task<PublishScriptResponse> PublishScriptWithOptionsAsync(PublishScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// PublishScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishScriptResponse
        /// </returns>
        public PublishScriptResponse PublishScript(PublishScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishScriptWithOptions(request, runtime);
        }

        /// <param name="request">
        /// PublishScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishScriptResponse
        /// </returns>
        public async Task<PublishScriptResponse> PublishScriptAsync(PublishScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishScriptWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// PublishScriptForDebugRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishScriptForDebugResponse
        /// </returns>
        public PublishScriptForDebugResponse PublishScriptForDebugWithOptions(PublishScriptForDebugRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishScriptForDebug",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishScriptForDebugResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// PublishScriptForDebugRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishScriptForDebugResponse
        /// </returns>
        public async Task<PublishScriptForDebugResponse> PublishScriptForDebugWithOptionsAsync(PublishScriptForDebugRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishScriptForDebug",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishScriptForDebugResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// PublishScriptForDebugRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishScriptForDebugResponse
        /// </returns>
        public PublishScriptForDebugResponse PublishScriptForDebug(PublishScriptForDebugRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishScriptForDebugWithOptions(request, runtime);
        }

        /// <param name="request">
        /// PublishScriptForDebugRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishScriptForDebugResponse
        /// </returns>
        public async Task<PublishScriptForDebugResponse> PublishScriptForDebugAsync(PublishScriptForDebugRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishScriptForDebugWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>QueryJobs</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryJobsResponse
        /// </returns>
        public QueryJobsResponse QueryJobsWithOptions(QueryJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeAlignment))
            {
                query["TimeAlignment"] = request.TimeAlignment;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>QueryJobs</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryJobsResponse
        /// </returns>
        public async Task<QueryJobsResponse> QueryJobsWithOptionsAsync(QueryJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeAlignment))
            {
                query["TimeAlignment"] = request.TimeAlignment;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>QueryJobs</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryJobsResponse
        /// </returns>
        public QueryJobsResponse QueryJobs(QueryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>QueryJobs</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryJobsResponse
        /// </returns>
        public async Task<QueryJobsResponse> QueryJobsAsync(QueryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取外呼任务结果信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryJobsWithResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryJobsWithResultResponse
        /// </returns>
        public QueryJobsWithResultResponse QueryJobsWithResultWithOptions(QueryJobsWithResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndActualTimeFilter))
            {
                query["EndActualTimeFilter"] = request.EndActualTimeFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasAnsweredFilter))
            {
                query["HasAnsweredFilter"] = request.HasAnsweredFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasHangUpByRejectionFilter))
            {
                query["HasHangUpByRejectionFilter"] = request.HasHangUpByRejectionFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasReachedEndOfFlowFilter))
            {
                query["HasReachedEndOfFlowFilter"] = request.HasReachedEndOfFlowFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobFailureReasonsFilter))
            {
                query["JobFailureReasonsFilter"] = request.JobFailureReasonsFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatusFilter))
            {
                query["JobStatusFilter"] = request.JobStatusFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsJson))
            {
                query["LabelsJson"] = request.LabelsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryText))
            {
                query["QueryText"] = request.QueryText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartActualTimeFilter))
            {
                query["StartActualTimeFilter"] = request.StartActualTimeFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatusFilter))
            {
                query["TaskStatusFilter"] = request.TaskStatusFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryJobsWithResult",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobsWithResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取外呼任务结果信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryJobsWithResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryJobsWithResultResponse
        /// </returns>
        public async Task<QueryJobsWithResultResponse> QueryJobsWithResultWithOptionsAsync(QueryJobsWithResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndActualTimeFilter))
            {
                query["EndActualTimeFilter"] = request.EndActualTimeFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasAnsweredFilter))
            {
                query["HasAnsweredFilter"] = request.HasAnsweredFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasHangUpByRejectionFilter))
            {
                query["HasHangUpByRejectionFilter"] = request.HasHangUpByRejectionFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasReachedEndOfFlowFilter))
            {
                query["HasReachedEndOfFlowFilter"] = request.HasReachedEndOfFlowFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobFailureReasonsFilter))
            {
                query["JobFailureReasonsFilter"] = request.JobFailureReasonsFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatusFilter))
            {
                query["JobStatusFilter"] = request.JobStatusFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsJson))
            {
                query["LabelsJson"] = request.LabelsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryText))
            {
                query["QueryText"] = request.QueryText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartActualTimeFilter))
            {
                query["StartActualTimeFilter"] = request.StartActualTimeFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatusFilter))
            {
                query["TaskStatusFilter"] = request.TaskStatusFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryJobsWithResult",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobsWithResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取外呼任务结果信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryJobsWithResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryJobsWithResultResponse
        /// </returns>
        public QueryJobsWithResultResponse QueryJobsWithResult(QueryJobsWithResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryJobsWithResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取外呼任务结果信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryJobsWithResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryJobsWithResultResponse
        /// </returns>
        public async Task<QueryJobsWithResultResponse> QueryJobsWithResultAsync(QueryJobsWithResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryJobsWithResultWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryScriptWaveformsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScriptWaveformsResponse
        /// </returns>
        public QueryScriptWaveformsResponse QueryScriptWaveformsWithOptions(QueryScriptWaveformsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptContent))
            {
                query["ScriptContent"] = request.ScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryScriptWaveforms",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScriptWaveformsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryScriptWaveformsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScriptWaveformsResponse
        /// </returns>
        public async Task<QueryScriptWaveformsResponse> QueryScriptWaveformsWithOptionsAsync(QueryScriptWaveformsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptContent))
            {
                query["ScriptContent"] = request.ScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryScriptWaveforms",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScriptWaveformsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryScriptWaveformsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScriptWaveformsResponse
        /// </returns>
        public QueryScriptWaveformsResponse QueryScriptWaveforms(QueryScriptWaveformsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryScriptWaveformsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryScriptWaveformsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScriptWaveformsResponse
        /// </returns>
        public async Task<QueryScriptWaveformsResponse> QueryScriptWaveformsAsync(QueryScriptWaveformsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryScriptWaveformsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryScriptsByStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScriptsByStatusResponse
        /// </returns>
        public QueryScriptsByStatusResponse QueryScriptsByStatusWithOptions(QueryScriptsByStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryScriptsByStatus",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScriptsByStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryScriptsByStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScriptsByStatusResponse
        /// </returns>
        public async Task<QueryScriptsByStatusResponse> QueryScriptsByStatusWithOptionsAsync(QueryScriptsByStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryScriptsByStatus",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScriptsByStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryScriptsByStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScriptsByStatusResponse
        /// </returns>
        public QueryScriptsByStatusResponse QueryScriptsByStatus(QueryScriptsByStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryScriptsByStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryScriptsByStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScriptsByStatusResponse
        /// </returns>
        public async Task<QueryScriptsByStatusResponse> QueryScriptsByStatusAsync(QueryScriptsByStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryScriptsByStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RecordFailureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecordFailureResponse
        /// </returns>
        public RecordFailureResponse RecordFailureWithOptions(RecordFailureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActualTime))
            {
                query["ActualTime"] = request.ActualTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispositionCode))
            {
                query["DispositionCode"] = request.DispositionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExceptionCodes))
            {
                query["ExceptionCodes"] = request.ExceptionCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordFailure",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordFailureResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RecordFailureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecordFailureResponse
        /// </returns>
        public async Task<RecordFailureResponse> RecordFailureWithOptionsAsync(RecordFailureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActualTime))
            {
                query["ActualTime"] = request.ActualTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispositionCode))
            {
                query["DispositionCode"] = request.DispositionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExceptionCodes))
            {
                query["ExceptionCodes"] = request.ExceptionCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordFailure",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordFailureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RecordFailureRequest
        /// </param>
        /// 
        /// <returns>
        /// RecordFailureResponse
        /// </returns>
        public RecordFailureResponse RecordFailure(RecordFailureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecordFailureWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RecordFailureRequest
        /// </param>
        /// 
        /// <returns>
        /// RecordFailureResponse
        /// </returns>
        public async Task<RecordFailureResponse> RecordFailureAsync(RecordFailureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecordFailureWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ResumeJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeJobsResponse
        /// </returns>
        public ResumeJobsResponse ResumeJobsWithOptions(ResumeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobReferenceId))
            {
                query["JobReferenceId"] = request.JobReferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ResumeJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeJobsResponse
        /// </returns>
        public async Task<ResumeJobsResponse> ResumeJobsWithOptionsAsync(ResumeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobReferenceId))
            {
                query["JobReferenceId"] = request.JobReferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ResumeJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeJobsResponse
        /// </returns>
        public ResumeJobsResponse ResumeJobs(ResumeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeJobsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ResumeJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeJobsResponse
        /// </returns>
        public async Task<ResumeJobsResponse> ResumeJobsAsync(ResumeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeJobsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RollbackScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackScriptResponse
        /// </returns>
        public RollbackScriptResponse RollbackScriptWithOptions(RollbackScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollbackVersion))
            {
                query["RollbackVersion"] = request.RollbackVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RollbackScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackScriptResponse
        /// </returns>
        public async Task<RollbackScriptResponse> RollbackScriptWithOptionsAsync(RollbackScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollbackVersion))
            {
                query["RollbackVersion"] = request.RollbackVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackScript",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RollbackScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackScriptResponse
        /// </returns>
        public RollbackScriptResponse RollbackScript(RollbackScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackScriptWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RollbackScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackScriptResponse
        /// </returns>
        public async Task<RollbackScriptResponse> RollbackScriptAsync(RollbackScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackScriptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存接听后延迟播报时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAfterAnswerDelayPlaybackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAfterAnswerDelayPlaybackResponse
        /// </returns>
        public SaveAfterAnswerDelayPlaybackResponse SaveAfterAnswerDelayPlaybackWithOptions(SaveAfterAnswerDelayPlaybackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AfterAnswerDelayPlayback))
            {
                query["AfterAnswerDelayPlayback"] = request.AfterAnswerDelayPlayback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveAfterAnswerDelayPlayback",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAfterAnswerDelayPlaybackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存接听后延迟播报时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAfterAnswerDelayPlaybackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAfterAnswerDelayPlaybackResponse
        /// </returns>
        public async Task<SaveAfterAnswerDelayPlaybackResponse> SaveAfterAnswerDelayPlaybackWithOptionsAsync(SaveAfterAnswerDelayPlaybackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AfterAnswerDelayPlayback))
            {
                query["AfterAnswerDelayPlayback"] = request.AfterAnswerDelayPlayback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveAfterAnswerDelayPlayback",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAfterAnswerDelayPlaybackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存接听后延迟播报时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAfterAnswerDelayPlaybackRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAfterAnswerDelayPlaybackResponse
        /// </returns>
        public SaveAfterAnswerDelayPlaybackResponse SaveAfterAnswerDelayPlayback(SaveAfterAnswerDelayPlaybackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveAfterAnswerDelayPlaybackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存接听后延迟播报时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAfterAnswerDelayPlaybackRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAfterAnswerDelayPlaybackResponse
        /// </returns>
        public async Task<SaveAfterAnswerDelayPlaybackResponse> SaveAfterAnswerDelayPlaybackAsync(SaveAfterAnswerDelayPlaybackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveAfterAnswerDelayPlaybackWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveAnnotationMissionSessionListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAnnotationMissionSessionListResponse
        /// </returns>
        public SaveAnnotationMissionSessionListResponse SaveAnnotationMissionSessionListWithOptions(SaveAnnotationMissionSessionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionDataSourceType))
            {
                query["AnnotationMissionDataSourceType"] = request.AnnotationMissionDataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionSessionList))
            {
                query["AnnotationMissionSessionList"] = request.AnnotationMissionSessionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionSessionListJsonString))
            {
                query["AnnotationMissionSessionListJsonString"] = request.AnnotationMissionSessionListJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNick))
            {
                query["UserNick"] = request.UserNick;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveAnnotationMissionSessionList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAnnotationMissionSessionListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveAnnotationMissionSessionListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAnnotationMissionSessionListResponse
        /// </returns>
        public async Task<SaveAnnotationMissionSessionListResponse> SaveAnnotationMissionSessionListWithOptionsAsync(SaveAnnotationMissionSessionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionDataSourceType))
            {
                query["AnnotationMissionDataSourceType"] = request.AnnotationMissionDataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionSessionList))
            {
                query["AnnotationMissionSessionList"] = request.AnnotationMissionSessionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionSessionListJsonString))
            {
                query["AnnotationMissionSessionListJsonString"] = request.AnnotationMissionSessionListJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNick))
            {
                query["UserNick"] = request.UserNick;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveAnnotationMissionSessionList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAnnotationMissionSessionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveAnnotationMissionSessionListRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAnnotationMissionSessionListResponse
        /// </returns>
        public SaveAnnotationMissionSessionListResponse SaveAnnotationMissionSessionList(SaveAnnotationMissionSessionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveAnnotationMissionSessionListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveAnnotationMissionSessionListRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAnnotationMissionSessionListResponse
        /// </returns>
        public async Task<SaveAnnotationMissionSessionListResponse> SaveAnnotationMissionSessionListAsync(SaveAnnotationMissionSessionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveAnnotationMissionSessionListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveAnnotationMissionTagInfoListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAnnotationMissionTagInfoListResponse
        /// </returns>
        public SaveAnnotationMissionTagInfoListResponse SaveAnnotationMissionTagInfoListWithOptions(SaveAnnotationMissionTagInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionTagInfoList))
            {
                query["AnnotationMissionTagInfoList"] = request.AnnotationMissionTagInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionTagInfoListJsonString))
            {
                query["AnnotationMissionTagInfoListJsonString"] = request.AnnotationMissionTagInfoListJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reset))
            {
                query["Reset"] = request.Reset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveAnnotationMissionTagInfoList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAnnotationMissionTagInfoListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveAnnotationMissionTagInfoListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAnnotationMissionTagInfoListResponse
        /// </returns>
        public async Task<SaveAnnotationMissionTagInfoListResponse> SaveAnnotationMissionTagInfoListWithOptionsAsync(SaveAnnotationMissionTagInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionTagInfoList))
            {
                query["AnnotationMissionTagInfoList"] = request.AnnotationMissionTagInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationMissionTagInfoListJsonString))
            {
                query["AnnotationMissionTagInfoListJsonString"] = request.AnnotationMissionTagInfoListJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reset))
            {
                query["Reset"] = request.Reset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveAnnotationMissionTagInfoList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAnnotationMissionTagInfoListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveAnnotationMissionTagInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAnnotationMissionTagInfoListResponse
        /// </returns>
        public SaveAnnotationMissionTagInfoListResponse SaveAnnotationMissionTagInfoList(SaveAnnotationMissionTagInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveAnnotationMissionTagInfoListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveAnnotationMissionTagInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAnnotationMissionTagInfoListResponse
        /// </returns>
        public async Task<SaveAnnotationMissionTagInfoListResponse> SaveAnnotationMissionTagInfoListAsync(SaveAnnotationMissionTagInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveAnnotationMissionTagInfoListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑基础策略有效时间窗口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBaseStrategyPeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBaseStrategyPeriodResponse
        /// </returns>
        public SaveBaseStrategyPeriodResponse SaveBaseStrategyPeriodWithOptions(SaveBaseStrategyPeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyWeekdays))
            {
                query["OnlyWeekdays"] = request.OnlyWeekdays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyWorkdays))
            {
                query["OnlyWorkdays"] = request.OnlyWorkdays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingTime))
            {
                query["WorkingTime"] = request.WorkingTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingTimeFramesJson))
            {
                query["WorkingTimeFramesJson"] = request.WorkingTimeFramesJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBaseStrategyPeriod",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBaseStrategyPeriodResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑基础策略有效时间窗口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBaseStrategyPeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBaseStrategyPeriodResponse
        /// </returns>
        public async Task<SaveBaseStrategyPeriodResponse> SaveBaseStrategyPeriodWithOptionsAsync(SaveBaseStrategyPeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyWeekdays))
            {
                query["OnlyWeekdays"] = request.OnlyWeekdays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyWorkdays))
            {
                query["OnlyWorkdays"] = request.OnlyWorkdays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingTime))
            {
                query["WorkingTime"] = request.WorkingTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingTimeFramesJson))
            {
                query["WorkingTimeFramesJson"] = request.WorkingTimeFramesJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBaseStrategyPeriod",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBaseStrategyPeriodResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑基础策略有效时间窗口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBaseStrategyPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBaseStrategyPeriodResponse
        /// </returns>
        public SaveBaseStrategyPeriodResponse SaveBaseStrategyPeriod(SaveBaseStrategyPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBaseStrategyPeriodWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑基础策略有效时间窗口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBaseStrategyPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBaseStrategyPeriodResponse
        /// </returns>
        public async Task<SaveBaseStrategyPeriodResponse> SaveBaseStrategyPeriodAsync(SaveBaseStrategyPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBaseStrategyPeriodWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存外呼黑名单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactBlockListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveContactBlockListResponse
        /// </returns>
        public SaveContactBlockListResponse SaveContactBlockListWithOptions(SaveContactBlockListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactBlockListList))
            {
                query["ContactBlockListList"] = request.ContactBlockListList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactBlockListsJson))
            {
                query["ContactBlockListsJson"] = request.ContactBlockListsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveContactBlockList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveContactBlockListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存外呼黑名单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactBlockListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveContactBlockListResponse
        /// </returns>
        public async Task<SaveContactBlockListResponse> SaveContactBlockListWithOptionsAsync(SaveContactBlockListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactBlockListList))
            {
                query["ContactBlockListList"] = request.ContactBlockListList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactBlockListsJson))
            {
                query["ContactBlockListsJson"] = request.ContactBlockListsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveContactBlockList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveContactBlockListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存外呼黑名单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactBlockListRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveContactBlockListResponse
        /// </returns>
        public SaveContactBlockListResponse SaveContactBlockList(SaveContactBlockListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveContactBlockListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存外呼黑名单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactBlockListRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveContactBlockListResponse
        /// </returns>
        public async Task<SaveContactBlockListResponse> SaveContactBlockListAsync(SaveContactBlockListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveContactBlockListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存外呼白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveContactWhiteListResponse
        /// </returns>
        public SaveContactWhiteListResponse SaveContactWhiteListWithOptions(SaveContactWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactWhiteListList))
            {
                query["ContactWhiteListList"] = request.ContactWhiteListList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactWhiteListsJson))
            {
                query["ContactWhiteListsJson"] = request.ContactWhiteListsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveContactWhiteList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveContactWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存外呼白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveContactWhiteListResponse
        /// </returns>
        public async Task<SaveContactWhiteListResponse> SaveContactWhiteListWithOptionsAsync(SaveContactWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactWhiteListList))
            {
                query["ContactWhiteListList"] = request.ContactWhiteListList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactWhiteListsJson))
            {
                query["ContactWhiteListsJson"] = request.ContactWhiteListsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveContactWhiteList",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveContactWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存外呼白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveContactWhiteListResponse
        /// </returns>
        public SaveContactWhiteListResponse SaveContactWhiteList(SaveContactWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveContactWhiteListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存外呼白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveContactWhiteListResponse
        /// </returns>
        public async Task<SaveContactWhiteListResponse> SaveContactWhiteListAsync(SaveContactWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveContactWhiteListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveEffectiveDaysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveEffectiveDaysResponse
        /// </returns>
        public SaveEffectiveDaysResponse SaveEffectiveDaysWithOptions(SaveEffectiveDaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDays))
            {
                query["EffectiveDays"] = request.EffectiveDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveEffectiveDays",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveEffectiveDaysResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveEffectiveDaysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveEffectiveDaysResponse
        /// </returns>
        public async Task<SaveEffectiveDaysResponse> SaveEffectiveDaysWithOptionsAsync(SaveEffectiveDaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDays))
            {
                query["EffectiveDays"] = request.EffectiveDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveEffectiveDays",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveEffectiveDaysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveEffectiveDaysRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveEffectiveDaysResponse
        /// </returns>
        public SaveEffectiveDaysResponse SaveEffectiveDays(SaveEffectiveDaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveEffectiveDaysWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveEffectiveDaysRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveEffectiveDaysResponse
        /// </returns>
        public async Task<SaveEffectiveDaysResponse> SaveEffectiveDaysAsync(SaveEffectiveDaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveEffectiveDaysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存每日最大外呼量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveMaxAttemptsPerDayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveMaxAttemptsPerDayResponse
        /// </returns>
        public SaveMaxAttemptsPerDayResponse SaveMaxAttemptsPerDayWithOptions(SaveMaxAttemptsPerDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttemptsPerDay))
            {
                query["MaxAttemptsPerDay"] = request.MaxAttemptsPerDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveMaxAttemptsPerDay",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveMaxAttemptsPerDayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存每日最大外呼量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveMaxAttemptsPerDayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveMaxAttemptsPerDayResponse
        /// </returns>
        public async Task<SaveMaxAttemptsPerDayResponse> SaveMaxAttemptsPerDayWithOptionsAsync(SaveMaxAttemptsPerDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttemptsPerDay))
            {
                query["MaxAttemptsPerDay"] = request.MaxAttemptsPerDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyLevel))
            {
                query["StrategyLevel"] = request.StrategyLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveMaxAttemptsPerDay",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveMaxAttemptsPerDayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存每日最大外呼量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveMaxAttemptsPerDayRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveMaxAttemptsPerDayResponse
        /// </returns>
        public SaveMaxAttemptsPerDayResponse SaveMaxAttemptsPerDay(SaveMaxAttemptsPerDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveMaxAttemptsPerDayWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存每日最大外呼量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveMaxAttemptsPerDayRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveMaxAttemptsPerDayResponse
        /// </returns>
        public async Task<SaveMaxAttemptsPerDayResponse> SaveMaxAttemptsPerDayAsync(SaveMaxAttemptsPerDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveMaxAttemptsPerDayWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外呼历史查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchTaskResponse
        /// </returns>
        public SearchTaskResponse SearchTaskWithOptions(SearchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchTask",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外呼历史查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchTaskResponse
        /// </returns>
        public async Task<SearchTaskResponse> SearchTaskWithOptionsAsync(SearchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchTask",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外呼历史查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchTaskResponse
        /// </returns>
        public SearchTaskResponse SearchTask(SearchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外呼历史查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchTaskResponse
        /// </returns>
        public async Task<SearchTaskResponse> SearchTaskAsync(SearchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启一个任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartJobResponse
        /// </returns>
        public StartJobResponse StartJobWithOptions(StartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobJson))
            {
                query["JobJson"] = request.JobJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJob",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启一个任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartJobResponse
        /// </returns>
        public async Task<StartJobResponse> StartJobWithOptionsAsync(StartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobJson))
            {
                query["JobJson"] = request.JobJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJob",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启一个任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StartJobResponse
        /// </returns>
        public StartJobResponse StartJob(StartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启一个任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StartJobResponse
        /// </returns>
        public async Task<StartJobResponse> StartJobAsync(StartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartJobWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SubmitBatchJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitBatchJobsResponse
        /// </returns>
        public SubmitBatchJobsResponse SubmitBatchJobsWithOptions(SubmitBatchJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitBatchJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitBatchJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitBatchJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitBatchJobsResponse
        /// </returns>
        public async Task<SubmitBatchJobsResponse> SubmitBatchJobsWithOptionsAsync(SubmitBatchJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitBatchJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitBatchJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitBatchJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitBatchJobsResponse
        /// </returns>
        public SubmitBatchJobsResponse SubmitBatchJobs(SubmitBatchJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitBatchJobsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SubmitBatchJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitBatchJobsResponse
        /// </returns>
        public async Task<SubmitBatchJobsResponse> SubmitBatchJobsAsync(SubmitBatchJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitBatchJobsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SubmitRecordingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitRecordingResponse
        /// </returns>
        public SubmitRecordingResponse SubmitRecordingWithOptions(SubmitRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergedRecording))
            {
                query["MergedRecording"] = request.MergedRecording;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRecording))
            {
                query["ResourceRecording"] = request.ResourceRecording;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitRecording",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitRecordingResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitRecordingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitRecordingResponse
        /// </returns>
        public async Task<SubmitRecordingResponse> SubmitRecordingWithOptionsAsync(SubmitRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergedRecording))
            {
                query["MergedRecording"] = request.MergedRecording;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRecording))
            {
                query["ResourceRecording"] = request.ResourceRecording;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitRecording",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitRecordingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitRecordingRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitRecordingResponse
        /// </returns>
        public SubmitRecordingResponse SubmitRecording(SubmitRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitRecordingWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SubmitRecordingRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitRecordingResponse
        /// </returns>
        public async Task<SubmitRecordingResponse> SubmitRecordingAsync(SubmitRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitRecordingWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SubmitScriptReviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitScriptReviewResponse
        /// </returns>
        public SubmitScriptReviewResponse SubmitScriptReviewWithOptions(SubmitScriptReviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitScriptReview",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitScriptReviewResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitScriptReviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitScriptReviewResponse
        /// </returns>
        public async Task<SubmitScriptReviewResponse> SubmitScriptReviewWithOptionsAsync(SubmitScriptReviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitScriptReview",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitScriptReviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitScriptReviewRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitScriptReviewResponse
        /// </returns>
        public SubmitScriptReviewResponse SubmitScriptReview(SubmitScriptReviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitScriptReviewWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SubmitScriptReviewRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitScriptReviewResponse
        /// </returns>
        public async Task<SubmitScriptReviewResponse> SubmitScriptReviewAsync(SubmitScriptReviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitScriptReviewWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>止呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendCallResponse
        /// </returns>
        public SuspendCallResponse SuspendCallWithOptions(SuspendCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumbers))
            {
                query["CalledNumbers"] = request.CalledNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendCall",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendCallResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>止呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendCallResponse
        /// </returns>
        public async Task<SuspendCallResponse> SuspendCallWithOptionsAsync(SuspendCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumbers))
            {
                query["CalledNumbers"] = request.CalledNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendCall",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>止呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendCallRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendCallResponse
        /// </returns>
        public SuspendCallResponse SuspendCall(SuspendCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendCallWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>止呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendCallRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendCallResponse
        /// </returns>
        public async Task<SuspendCallResponse> SuspendCallAsync(SuspendCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendCallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SuspendCallWithFile</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendCallWithFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendCallWithFileResponse
        /// </returns>
        public SuspendCallWithFileResponse SuspendCallWithFileWithOptions(SuspendCallWithFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendCallWithFile",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendCallWithFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SuspendCallWithFile</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendCallWithFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendCallWithFileResponse
        /// </returns>
        public async Task<SuspendCallWithFileResponse> SuspendCallWithFileWithOptionsAsync(SuspendCallWithFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendCallWithFile",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendCallWithFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SuspendCallWithFile</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendCallWithFileRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendCallWithFileResponse
        /// </returns>
        public SuspendCallWithFileResponse SuspendCallWithFile(SuspendCallWithFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendCallWithFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SuspendCallWithFile</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendCallWithFileRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendCallWithFileResponse
        /// </returns>
        public async Task<SuspendCallWithFileResponse> SuspendCallWithFileAsync(SuspendCallWithFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendCallWithFileWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SuspendJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendJobsResponse
        /// </returns>
        public SuspendJobsResponse SuspendJobsWithOptions(SuspendJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobReferenceId))
            {
                query["JobReferenceId"] = request.JobReferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SuspendJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendJobsResponse
        /// </returns>
        public async Task<SuspendJobsResponse> SuspendJobsWithOptionsAsync(SuspendJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobGroupId))
            {
                query["JobGroupId"] = request.JobGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobReferenceId))
            {
                query["JobReferenceId"] = request.JobReferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioId))
            {
                query["ScenarioId"] = request.ScenarioId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendJobs",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SuspendJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendJobsResponse
        /// </returns>
        public SuspendJobsResponse SuspendJobs(SuspendJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendJobsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SuspendJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendJobsResponse
        /// </returns>
        public async Task<SuspendJobsResponse> SuspendJobsAsync(SuspendJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2019-12-26",
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

        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2019-12-26",
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

        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </description>
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
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </description>
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
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>TaskPreparing</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskPreparingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaskPreparingResponse
        /// </returns>
        public TaskPreparingResponse TaskPreparingWithOptions(TaskPreparingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskPreparing",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskPreparingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>TaskPreparing</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskPreparingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaskPreparingResponse
        /// </returns>
        public async Task<TaskPreparingResponse> TaskPreparingWithOptionsAsync(TaskPreparingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskPreparing",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskPreparingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>TaskPreparing</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskPreparingRequest
        /// </param>
        /// 
        /// <returns>
        /// TaskPreparingResponse
        /// </returns>
        public TaskPreparingResponse TaskPreparing(TaskPreparingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaskPreparingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>TaskPreparing</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskPreparingRequest
        /// </param>
        /// 
        /// <returns>
        /// TaskPreparingResponse
        /// </returns>
        public async Task<TaskPreparingResponse> TaskPreparingAsync(TaskPreparingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaskPreparingWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// TerminateCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateCallResponse
        /// </returns>
        public TerminateCallResponse TerminateCallWithOptions(TerminateCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TerminateCall",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateCallResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// TerminateCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateCallResponse
        /// </returns>
        public async Task<TerminateCallResponse> TerminateCallWithOptionsAsync(TerminateCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TerminateCall",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// TerminateCallRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateCallResponse
        /// </returns>
        public TerminateCallResponse TerminateCall(TerminateCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TerminateCallWithOptions(request, runtime);
        }

        /// <param name="request">
        /// TerminateCallRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateCallResponse
        /// </returns>
        public async Task<TerminateCallResponse> TerminateCallAsync(TerminateCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TerminateCallWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2019-12-26",
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

        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2019-12-26",
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
            return UntagResourcesWithOptions(request, runtime);
        }

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
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UploadScriptRecordingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadScriptRecordingResponse
        /// </returns>
        public UploadScriptRecordingResponse UploadScriptRecordingWithOptions(UploadScriptRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadScriptRecording",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadScriptRecordingResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadScriptRecordingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadScriptRecordingResponse
        /// </returns>
        public async Task<UploadScriptRecordingResponse> UploadScriptRecordingWithOptionsAsync(UploadScriptRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadScriptRecording",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadScriptRecordingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadScriptRecordingRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadScriptRecordingResponse
        /// </returns>
        public UploadScriptRecordingResponse UploadScriptRecording(UploadScriptRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadScriptRecordingWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UploadScriptRecordingRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadScriptRecordingResponse
        /// </returns>
        public async Task<UploadScriptRecordingResponse> UploadScriptRecordingAsync(UploadScriptRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadScriptRecordingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>WithdrawScriptReview</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// WithdrawScriptReviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WithdrawScriptReviewResponse
        /// </returns>
        public WithdrawScriptReviewResponse WithdrawScriptReviewWithOptions(WithdrawScriptReviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WithdrawScriptReview",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WithdrawScriptReviewResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>WithdrawScriptReview</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// WithdrawScriptReviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WithdrawScriptReviewResponse
        /// </returns>
        public async Task<WithdrawScriptReviewResponse> WithdrawScriptReviewWithOptionsAsync(WithdrawScriptReviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                query["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WithdrawScriptReview",
                Version = "2019-12-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WithdrawScriptReviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>WithdrawScriptReview</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// WithdrawScriptReviewRequest
        /// </param>
        /// 
        /// <returns>
        /// WithdrawScriptReviewResponse
        /// </returns>
        public WithdrawScriptReviewResponse WithdrawScriptReview(WithdrawScriptReviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WithdrawScriptReviewWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>WithdrawScriptReview</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// WithdrawScriptReviewRequest
        /// </param>
        /// 
        /// <returns>
        /// WithdrawScriptReviewResponse
        /// </returns>
        public async Task<WithdrawScriptReviewResponse> WithdrawScriptReviewAsync(WithdrawScriptReviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WithdrawScriptReviewWithOptionsAsync(request, runtime);
        }

    }
}
