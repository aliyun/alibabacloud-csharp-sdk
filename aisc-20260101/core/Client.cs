// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AISC20260101.Models;

namespace AlibabaCloud.SDK.AISC20260101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-zhangjiakou", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-wulanchabu", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-shanghai", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-qingdao", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-nanjing", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-huhehaote", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-hangzhou", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-guangzhou", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-beijing", "aisc.cn-shanghai.aliyuncs.com"},
                {"ap-southeast-7", "aisc.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-6", "aisc.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "aisc.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-1", "aisc.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-2", "aisc.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-1", "aisc.ap-southeast-1.aliyuncs.com"},
                {"eu-central-1", "aisc.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "aisc.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "aisc.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "aisc.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "aisc.ap-southeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-hangzhou-finance", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-heyuan-acdr-1", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-shanghai-finance-1", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "aisc.cn-shanghai.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("aisc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Initiates batch detection for user-defined skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSkillFileCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillFileCheckResponse
        /// </returns>
        public CreateSkillFileCheckResponse CreateSkillFileCheckWithOptions(CreateSkillFileCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                query["Files"] = request.Files;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkillFileCheck",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillFileCheckResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates batch detection for user-defined skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSkillFileCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillFileCheckResponse
        /// </returns>
        public async Task<CreateSkillFileCheckResponse> CreateSkillFileCheckWithOptionsAsync(CreateSkillFileCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                query["Files"] = request.Files;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkillFileCheck",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillFileCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates batch detection for user-defined skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSkillFileCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillFileCheckResponse
        /// </returns>
        public CreateSkillFileCheckResponse CreateSkillFileCheck(CreateSkillFileCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSkillFileCheckWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates batch detection for user-defined skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSkillFileCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillFileCheckResponse
        /// </returns>
        public async Task<CreateSkillFileCheckResponse> CreateSkillFileCheckAsync(CreateSkillFileCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSkillFileCheckWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of agent risk events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAIAgentEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAIAgentEventResponse
        /// </returns>
        public ListAIAgentEventResponse ListAIAgentEventWithOptions(ListAIAgentEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetName))
            {
                query["AssetName"] = request.AssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetType))
            {
                query["AssetType"] = request.AssetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfraInstanceId))
            {
                query["InfraInstanceId"] = request.InfraInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfraName))
            {
                query["InfraName"] = request.InfraName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfraRegionId))
            {
                query["InfraRegionId"] = request.InfraRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskName))
            {
                query["RiskName"] = request.RiskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                query["Vendor"] = request.Vendor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAIAgentEvent",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAIAgentEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of agent risk events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAIAgentEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAIAgentEventResponse
        /// </returns>
        public async Task<ListAIAgentEventResponse> ListAIAgentEventWithOptionsAsync(ListAIAgentEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetName))
            {
                query["AssetName"] = request.AssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetType))
            {
                query["AssetType"] = request.AssetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfraInstanceId))
            {
                query["InfraInstanceId"] = request.InfraInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfraName))
            {
                query["InfraName"] = request.InfraName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfraRegionId))
            {
                query["InfraRegionId"] = request.InfraRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskName))
            {
                query["RiskName"] = request.RiskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                query["Vendor"] = request.Vendor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAIAgentEvent",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAIAgentEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of agent risk events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAIAgentEventRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAIAgentEventResponse
        /// </returns>
        public ListAIAgentEventResponse ListAIAgentEvent(ListAIAgentEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAIAgentEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of agent risk events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAIAgentEventRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAIAgentEventResponse
        /// </returns>
        public async Task<ListAIAgentEventResponse> ListAIAgentEventAsync(ListAIAgentEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAIAgentEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get subtask information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubTasksResponse
        /// </returns>
        public ListSubTasksResponse ListSubTasksWithOptions(ListSubTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootTaskId))
            {
                query["RootTaskId"] = request.RootTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubTasks",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get subtask information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubTasksResponse
        /// </returns>
        public async Task<ListSubTasksResponse> ListSubTasksWithOptionsAsync(ListSubTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootTaskId))
            {
                query["RootTaskId"] = request.RootTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubTasks",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get subtask information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubTasksResponse
        /// </returns>
        public ListSubTasksResponse ListSubTasks(ListSubTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSubTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get subtask information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubTasksResponse
        /// </returns>
        public async Task<ListSubTasksResponse> ListSubTasksAsync(ListSubTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSubTasksWithOptionsAsync(request, runtime);
        }

    }
}
