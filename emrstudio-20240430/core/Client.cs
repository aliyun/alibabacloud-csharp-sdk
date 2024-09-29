// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.EmrStudio20240430.Models;

namespace AlibabaCloud.SDK.EmrStudio20240430
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "EmrStudio";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("emrstudio", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkflowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkflowResponse
        /// </returns>
        public CreateWorkflowResponse CreateWorkflowWithOptions(string projectId, CreateWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertGroupId))
            {
                query["alertGroupId"] = request.AlertGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertStrategy))
            {
                query["alertStrategy"] = request.AlertStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpr))
            {
                query["cronExpr"] = request.CronExpr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionType))
            {
                query["executionType"] = request.ExecutionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailureStrategy))
            {
                query["failureStrategy"] = request.FailureStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDirectoryId))
            {
                query["parentDirectoryId"] = request.ParentDirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleEndTime))
            {
                query["scheduleEndTime"] = request.ScheduleEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleStartTime))
            {
                query["scheduleStartTime"] = request.ScheduleStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleState))
            {
                query["scheduleState"] = request.ScheduleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDefinitionJson))
            {
                query["taskDefinitionJson"] = request.TaskDefinitionJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRelationJson))
            {
                query["taskRelationJson"] = request.TaskRelationJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["timeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowInstancePriority))
            {
                query["workflowInstancePriority"] = request.WorkflowInstancePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowParams))
            {
                query["workflowParams"] = request.WorkflowParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDefinitionJsonValue))
            {
                body["taskDefinitionJsonValue"] = request.TaskDefinitionJsonValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRelationJsonValue))
            {
                body["taskRelationJsonValue"] = request.TaskRelationJsonValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkflow",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateWorkflowResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateWorkflowResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkflowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkflowResponse
        /// </returns>
        public async Task<CreateWorkflowResponse> CreateWorkflowWithOptionsAsync(string projectId, CreateWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertGroupId))
            {
                query["alertGroupId"] = request.AlertGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertStrategy))
            {
                query["alertStrategy"] = request.AlertStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpr))
            {
                query["cronExpr"] = request.CronExpr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionType))
            {
                query["executionType"] = request.ExecutionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailureStrategy))
            {
                query["failureStrategy"] = request.FailureStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDirectoryId))
            {
                query["parentDirectoryId"] = request.ParentDirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleEndTime))
            {
                query["scheduleEndTime"] = request.ScheduleEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleStartTime))
            {
                query["scheduleStartTime"] = request.ScheduleStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleState))
            {
                query["scheduleState"] = request.ScheduleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDefinitionJson))
            {
                query["taskDefinitionJson"] = request.TaskDefinitionJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRelationJson))
            {
                query["taskRelationJson"] = request.TaskRelationJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["timeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowInstancePriority))
            {
                query["workflowInstancePriority"] = request.WorkflowInstancePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowParams))
            {
                query["workflowParams"] = request.WorkflowParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDefinitionJsonValue))
            {
                body["taskDefinitionJsonValue"] = request.TaskDefinitionJsonValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRelationJsonValue))
            {
                body["taskRelationJsonValue"] = request.TaskRelationJsonValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkflow",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateWorkflowResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateWorkflowResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkflowRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkflowResponse
        /// </returns>
        public CreateWorkflowResponse CreateWorkflow(string projectId, CreateWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWorkflowWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkflowRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkflowResponse
        /// </returns>
        public async Task<CreateWorkflowResponse> CreateWorkflowAsync(string projectId, CreateWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWorkflowWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkflowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkflowResponse
        /// </returns>
        public DeleteWorkflowResponse DeleteWorkflowWithOptions(string projectId, string workflowId, DeleteWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkflow",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteWorkflowResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteWorkflowResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkflowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkflowResponse
        /// </returns>
        public async Task<DeleteWorkflowResponse> DeleteWorkflowWithOptionsAsync(string projectId, string workflowId, DeleteWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkflow",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteWorkflowResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteWorkflowResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkflowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkflowResponse
        /// </returns>
        public DeleteWorkflowResponse DeleteWorkflow(string projectId, string workflowId, DeleteWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWorkflowWithOptions(projectId, workflowId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkflowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkflowResponse
        /// </returns>
        public async Task<DeleteWorkflowResponse> DeleteWorkflowAsync(string projectId, string workflowId, DeleteWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWorkflowWithOptionsAsync(projectId, workflowId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手动任务定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeManualTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeManualTaskResponse
        /// </returns>
        public DescribeManualTaskResponse DescribeManualTaskWithOptions(string projectId, string manualTaskId, DescribeManualTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeManualTask",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/manualTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(manualTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeManualTaskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeManualTaskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手动任务定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeManualTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeManualTaskResponse
        /// </returns>
        public async Task<DescribeManualTaskResponse> DescribeManualTaskWithOptionsAsync(string projectId, string manualTaskId, DescribeManualTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeManualTask",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/manualTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(manualTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeManualTaskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeManualTaskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手动任务定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeManualTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeManualTaskResponse
        /// </returns>
        public DescribeManualTaskResponse DescribeManualTask(string projectId, string manualTaskId, DescribeManualTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeManualTaskWithOptions(projectId, manualTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手动任务定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeManualTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeManualTaskResponse
        /// </returns>
        public async Task<DescribeManualTaskResponse> DescribeManualTaskAsync(string projectId, string manualTaskId, DescribeManualTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeManualTaskWithOptionsAsync(projectId, manualTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手动任务实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeManualTaskInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeManualTaskInstanceResponse
        /// </returns>
        public DescribeManualTaskInstanceResponse DescribeManualTaskInstanceWithOptions(string manualTaskInstanceId, string projectId, DescribeManualTaskInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeManualTaskInstance",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/manualTaskInstances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(manualTaskInstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeManualTaskInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeManualTaskInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手动任务实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeManualTaskInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeManualTaskInstanceResponse
        /// </returns>
        public async Task<DescribeManualTaskInstanceResponse> DescribeManualTaskInstanceWithOptionsAsync(string manualTaskInstanceId, string projectId, DescribeManualTaskInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeManualTaskInstance",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/manualTaskInstances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(manualTaskInstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeManualTaskInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeManualTaskInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手动任务实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeManualTaskInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeManualTaskInstanceResponse
        /// </returns>
        public DescribeManualTaskInstanceResponse DescribeManualTaskInstance(string manualTaskInstanceId, string projectId, DescribeManualTaskInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeManualTaskInstanceWithOptions(manualTaskInstanceId, projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手动任务实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeManualTaskInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeManualTaskInstanceResponse
        /// </returns>
        public async Task<DescribeManualTaskInstanceResponse> DescribeManualTaskInstanceAsync(string manualTaskInstanceId, string projectId, DescribeManualTaskInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeManualTaskInstanceWithOptionsAsync(manualTaskInstanceId, projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectResponse
        /// </returns>
        public DescribeProjectResponse DescribeProjectWithOptions(string projectId, DescribeProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProject",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeProjectResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeProjectResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectResponse
        /// </returns>
        public async Task<DescribeProjectResponse> DescribeProjectWithOptionsAsync(string projectId, DescribeProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProject",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeProjectResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeProjectResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectResponse
        /// </returns>
        public DescribeProjectResponse DescribeProject(string projectId, DescribeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeProjectWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectResponse
        /// </returns>
        public async Task<DescribeProjectResponse> DescribeProjectAsync(string projectId, DescribeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeProjectWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTaskResponse
        /// </returns>
        public DescribeTaskResponse DescribeTaskWithOptions(string workflowId, string projectId, string taskId, DescribeTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTask",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeTaskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeTaskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTaskResponse
        /// </returns>
        public async Task<DescribeTaskResponse> DescribeTaskWithOptionsAsync(string workflowId, string projectId, string taskId, DescribeTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTask",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeTaskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeTaskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTaskResponse
        /// </returns>
        public DescribeTaskResponse DescribeTask(string workflowId, string projectId, string taskId, DescribeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTaskWithOptions(workflowId, projectId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTaskResponse
        /// </returns>
        public async Task<DescribeTaskResponse> DescribeTaskAsync(string workflowId, string projectId, string taskId, DescribeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTaskWithOptionsAsync(workflowId, projectId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTaskInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTaskInstanceResponse
        /// </returns>
        public DescribeTaskInstanceResponse DescribeTaskInstanceWithOptions(string projectId, string workflowInstanceId, string taskInstanceId, DescribeTaskInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTaskInstance",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowInstanceId) + "/taskInstances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskInstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeTaskInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeTaskInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTaskInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTaskInstanceResponse
        /// </returns>
        public async Task<DescribeTaskInstanceResponse> DescribeTaskInstanceWithOptionsAsync(string projectId, string workflowInstanceId, string taskInstanceId, DescribeTaskInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTaskInstance",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowInstanceId) + "/taskInstances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskInstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeTaskInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeTaskInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTaskInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTaskInstanceResponse
        /// </returns>
        public DescribeTaskInstanceResponse DescribeTaskInstance(string projectId, string workflowInstanceId, string taskInstanceId, DescribeTaskInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTaskInstanceWithOptions(projectId, workflowInstanceId, taskInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTaskInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTaskInstanceResponse
        /// </returns>
        public async Task<DescribeTaskInstanceResponse> DescribeTaskInstanceAsync(string projectId, string workflowInstanceId, string taskInstanceId, DescribeTaskInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTaskInstanceWithOptionsAsync(projectId, workflowInstanceId, taskInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWorkflowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWorkflowResponse
        /// </returns>
        public DescribeWorkflowResponse DescribeWorkflowWithOptions(string projectId, string workflowId, DescribeWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWorkflow",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeWorkflowResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeWorkflowResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWorkflowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWorkflowResponse
        /// </returns>
        public async Task<DescribeWorkflowResponse> DescribeWorkflowWithOptionsAsync(string projectId, string workflowId, DescribeWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWorkflow",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeWorkflowResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeWorkflowResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWorkflowRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWorkflowResponse
        /// </returns>
        public DescribeWorkflowResponse DescribeWorkflow(string projectId, string workflowId, DescribeWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWorkflowWithOptions(projectId, workflowId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWorkflowRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWorkflowResponse
        /// </returns>
        public async Task<DescribeWorkflowResponse> DescribeWorkflowAsync(string projectId, string workflowId, DescribeWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWorkflowWithOptionsAsync(projectId, workflowId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWorkflowInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWorkflowInstanceResponse
        /// </returns>
        public DescribeWorkflowInstanceResponse DescribeWorkflowInstanceWithOptions(string projectId, string workflowInstanceId, DescribeWorkflowInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWorkflowInstance",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflowInstances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowInstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeWorkflowInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeWorkflowInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWorkflowInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWorkflowInstanceResponse
        /// </returns>
        public async Task<DescribeWorkflowInstanceResponse> DescribeWorkflowInstanceWithOptionsAsync(string projectId, string workflowInstanceId, DescribeWorkflowInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWorkflowInstance",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflowInstances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowInstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeWorkflowInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeWorkflowInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWorkflowInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWorkflowInstanceResponse
        /// </returns>
        public DescribeWorkflowInstanceResponse DescribeWorkflowInstance(string projectId, string workflowInstanceId, DescribeWorkflowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWorkflowInstanceWithOptions(projectId, workflowInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWorkflowInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWorkflowInstanceResponse
        /// </returns>
        public async Task<DescribeWorkflowInstanceResponse> DescribeWorkflowInstanceAsync(string projectId, string workflowInstanceId, DescribeWorkflowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWorkflowInstanceWithOptionsAsync(projectId, workflowInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手动任务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManualTaskInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListManualTaskInstancesResponse
        /// </returns>
        public ListManualTaskInstancesResponse ListManualTaskInstancesWithOptions(string projectId, ListManualTaskInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchVal))
            {
                query["searchVal"] = request.SearchVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListManualTaskInstances",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/manualTaskInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListManualTaskInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListManualTaskInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手动任务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManualTaskInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListManualTaskInstancesResponse
        /// </returns>
        public async Task<ListManualTaskInstancesResponse> ListManualTaskInstancesWithOptionsAsync(string projectId, ListManualTaskInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchVal))
            {
                query["searchVal"] = request.SearchVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListManualTaskInstances",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/manualTaskInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListManualTaskInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListManualTaskInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手动任务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManualTaskInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListManualTaskInstancesResponse
        /// </returns>
        public ListManualTaskInstancesResponse ListManualTaskInstances(string projectId, ListManualTaskInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListManualTaskInstancesWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手动任务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManualTaskInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListManualTaskInstancesResponse
        /// </returns>
        public async Task<ListManualTaskInstancesResponse> ListManualTaskInstancesAsync(string projectId, ListManualTaskInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListManualTaskInstancesWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询手动任务定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManualTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListManualTasksResponse
        /// </returns>
        public ListManualTasksResponse ListManualTasksWithOptions(string projectId, ListManualTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchVal))
            {
                query["searchVal"] = request.SearchVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListManualTasks",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/manualTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListManualTasksResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListManualTasksResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询手动任务定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManualTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListManualTasksResponse
        /// </returns>
        public async Task<ListManualTasksResponse> ListManualTasksWithOptionsAsync(string projectId, ListManualTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchVal))
            {
                query["searchVal"] = request.SearchVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListManualTasks",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/manualTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListManualTasksResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListManualTasksResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询手动任务定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManualTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListManualTasksResponse
        /// </returns>
        public ListManualTasksResponse ListManualTasks(string projectId, ListManualTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListManualTasksWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询手动任务定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManualTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListManualTasksResponse
        /// </returns>
        public async Task<ListManualTasksResponse> ListManualTasksAsync(string projectId, ListManualTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListManualTasksWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchVal))
            {
                query["searchVal"] = request.SearchVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListProjectsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListProjectsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchVal))
            {
                query["searchVal"] = request.SearchVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListProjectsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListProjectsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTaskInstancesResponse
        /// </returns>
        public ListTaskInstancesResponse ListTaskInstancesWithOptions(string projectId, ListTaskInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchVal))
            {
                query["searchVal"] = request.SearchVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowInstanceId))
            {
                query["workflowInstanceId"] = request.WorkflowInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTaskInstances",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/taskInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTaskInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTaskInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTaskInstancesResponse
        /// </returns>
        public async Task<ListTaskInstancesResponse> ListTaskInstancesWithOptionsAsync(string projectId, ListTaskInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchVal))
            {
                query["searchVal"] = request.SearchVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowInstanceId))
            {
                query["workflowInstanceId"] = request.WorkflowInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTaskInstances",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/taskInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTaskInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTaskInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTaskInstancesResponse
        /// </returns>
        public ListTaskInstancesResponse ListTaskInstances(string projectId, ListTaskInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTaskInstancesWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTaskInstancesResponse
        /// </returns>
        public async Task<ListTaskInstancesResponse> ListTaskInstancesAsync(string projectId, ListTaskInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTaskInstancesWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public ListTasksResponse ListTasksWithOptions(string projectId, ListTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchVal))
            {
                query["searchVal"] = request.SearchVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                query["workflowId"] = request.WorkflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTasksResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTasksResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public async Task<ListTasksResponse> ListTasksWithOptionsAsync(string projectId, ListTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchVal))
            {
                query["searchVal"] = request.SearchVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                query["workflowId"] = request.WorkflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTasksResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTasksResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public ListTasksResponse ListTasks(string projectId, ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTasksWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public async Task<ListTasksResponse> ListTasksAsync(string projectId, ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTasksWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkflowInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkflowInstancesResponse
        /// </returns>
        public ListWorkflowInstancesResponse ListWorkflowInstancesWithOptions(string projectId, ListWorkflowInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                query["workflowId"] = request.WorkflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkflowInstances",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflowInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListWorkflowInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListWorkflowInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkflowInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkflowInstancesResponse
        /// </returns>
        public async Task<ListWorkflowInstancesResponse> ListWorkflowInstancesWithOptionsAsync(string projectId, ListWorkflowInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                query["workflowId"] = request.WorkflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkflowInstances",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflowInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListWorkflowInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListWorkflowInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkflowInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkflowInstancesResponse
        /// </returns>
        public ListWorkflowInstancesResponse ListWorkflowInstances(string projectId, ListWorkflowInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkflowInstancesWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkflowInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkflowInstancesResponse
        /// </returns>
        public async Task<ListWorkflowInstancesResponse> ListWorkflowInstancesAsync(string projectId, ListWorkflowInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkflowInstancesWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkflowsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkflowsResponse
        /// </returns>
        public ListWorkflowsResponse ListWorkflowsWithOptions(string projectId, ListWorkflowsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchVal))
            {
                query["searchVal"] = request.SearchVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkflows",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListWorkflowsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListWorkflowsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkflowsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkflowsResponse
        /// </returns>
        public async Task<ListWorkflowsResponse> ListWorkflowsWithOptionsAsync(string projectId, ListWorkflowsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchVal))
            {
                query["searchVal"] = request.SearchVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkflows",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListWorkflowsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListWorkflowsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkflowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkflowsResponse
        /// </returns>
        public ListWorkflowsResponse ListWorkflows(string projectId, ListWorkflowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkflowsWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作流列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkflowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkflowsResponse
        /// </returns>
        public async Task<ListWorkflowsResponse> ListWorkflowsAsync(string projectId, ListWorkflowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkflowsWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunWorkflowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunWorkflowResponse
        /// </returns>
        public RunWorkflowResponse RunWorkflowWithOptions(string projectId, RunWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertGroupId))
            {
                query["alertGroupId"] = request.AlertGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertStrategy))
            {
                query["alertStrategy"] = request.AlertStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplementDependentMode))
            {
                query["complementDependentMode"] = request.ComplementDependentMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecType))
            {
                query["execType"] = request.ExecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedParallelismNumber))
            {
                query["expectedParallelismNumber"] = request.ExpectedParallelismNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailureStrategy))
            {
                query["failureStrategy"] = request.FailureStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                query["runMode"] = request.RunMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["scheduleTime"] = request.ScheduleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartParams))
            {
                query["startParams"] = request.StartParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                query["workflowId"] = request.WorkflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowInstancePriority))
            {
                query["workflowInstancePriority"] = request.WorkflowInstancePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunWorkflow",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/executors/run-workflow",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RunWorkflowResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RunWorkflowResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunWorkflowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunWorkflowResponse
        /// </returns>
        public async Task<RunWorkflowResponse> RunWorkflowWithOptionsAsync(string projectId, RunWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertGroupId))
            {
                query["alertGroupId"] = request.AlertGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertStrategy))
            {
                query["alertStrategy"] = request.AlertStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplementDependentMode))
            {
                query["complementDependentMode"] = request.ComplementDependentMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecType))
            {
                query["execType"] = request.ExecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedParallelismNumber))
            {
                query["expectedParallelismNumber"] = request.ExpectedParallelismNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailureStrategy))
            {
                query["failureStrategy"] = request.FailureStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                query["runMode"] = request.RunMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["scheduleTime"] = request.ScheduleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartParams))
            {
                query["startParams"] = request.StartParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                query["workflowId"] = request.WorkflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowInstancePriority))
            {
                query["workflowInstancePriority"] = request.WorkflowInstancePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunWorkflow",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/executors/run-workflow",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RunWorkflowResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RunWorkflowResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunWorkflowRequest
        /// </param>
        /// 
        /// <returns>
        /// RunWorkflowResponse
        /// </returns>
        public RunWorkflowResponse RunWorkflow(string projectId, RunWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunWorkflowWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunWorkflowRequest
        /// </param>
        /// 
        /// <returns>
        /// RunWorkflowResponse
        /// </returns>
        public async Task<RunWorkflowResponse> RunWorkflowAsync(string projectId, RunWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunWorkflowWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkflowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkflowResponse
        /// </returns>
        public UpdateWorkflowResponse UpdateWorkflowWithOptions(string projectId, string workflowId, UpdateWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertGroupId))
            {
                query["alertGroupId"] = request.AlertGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertStrategy))
            {
                query["alertStrategy"] = request.AlertStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpr))
            {
                query["cronExpr"] = request.CronExpr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionType))
            {
                query["executionType"] = request.ExecutionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailureStrategy))
            {
                query["failureStrategy"] = request.FailureStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDirectoryId))
            {
                query["parentDirectoryId"] = request.ParentDirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleEndTime))
            {
                query["scheduleEndTime"] = request.ScheduleEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleStartTime))
            {
                query["scheduleStartTime"] = request.ScheduleStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleState))
            {
                query["scheduleState"] = request.ScheduleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDefinitionJson))
            {
                query["taskDefinitionJson"] = request.TaskDefinitionJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRelationJson))
            {
                query["taskRelationJson"] = request.TaskRelationJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["timeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowInstancePriority))
            {
                query["workflowInstancePriority"] = request.WorkflowInstancePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowParams))
            {
                query["workflowParams"] = request.WorkflowParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDefinitionJsonValue))
            {
                body["taskDefinitionJsonValue"] = request.TaskDefinitionJsonValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRelationJsonValue))
            {
                body["taskRelationJsonValue"] = request.TaskRelationJsonValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkflow",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateWorkflowResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateWorkflowResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkflowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkflowResponse
        /// </returns>
        public async Task<UpdateWorkflowResponse> UpdateWorkflowWithOptionsAsync(string projectId, string workflowId, UpdateWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertGroupId))
            {
                query["alertGroupId"] = request.AlertGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertStrategy))
            {
                query["alertStrategy"] = request.AlertStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpr))
            {
                query["cronExpr"] = request.CronExpr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionType))
            {
                query["executionType"] = request.ExecutionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailureStrategy))
            {
                query["failureStrategy"] = request.FailureStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDirectoryId))
            {
                query["parentDirectoryId"] = request.ParentDirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleEndTime))
            {
                query["scheduleEndTime"] = request.ScheduleEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleStartTime))
            {
                query["scheduleStartTime"] = request.ScheduleStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleState))
            {
                query["scheduleState"] = request.ScheduleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDefinitionJson))
            {
                query["taskDefinitionJson"] = request.TaskDefinitionJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRelationJson))
            {
                query["taskRelationJson"] = request.TaskRelationJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["timeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowInstancePriority))
            {
                query["workflowInstancePriority"] = request.WorkflowInstancePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowParams))
            {
                query["workflowParams"] = request.WorkflowParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDefinitionJsonValue))
            {
                body["taskDefinitionJsonValue"] = request.TaskDefinitionJsonValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRelationJsonValue))
            {
                body["taskRelationJsonValue"] = request.TaskRelationJsonValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkflow",
                Version = "2024-04-30",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/workflows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateWorkflowResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateWorkflowResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkflowRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkflowResponse
        /// </returns>
        public UpdateWorkflowResponse UpdateWorkflow(string projectId, string workflowId, UpdateWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWorkflowWithOptions(projectId, workflowId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新工作流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkflowRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkflowResponse
        /// </returns>
        public async Task<UpdateWorkflowResponse> UpdateWorkflowAsync(string projectId, string workflowId, UpdateWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWorkflowWithOptionsAsync(projectId, workflowId, request, headers, runtime);
        }

    }
}
