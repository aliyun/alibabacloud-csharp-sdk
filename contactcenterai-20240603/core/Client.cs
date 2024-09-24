// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ContactCenterAI20240603.Models;

namespace AlibabaCloud.SDK.ContactCenterAI20240603
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("contactcenterai", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 根据类型调用大模型
         *
         * @param request AnalyzeConversationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AnalyzeConversationResponse
         */
        public AnalyzeConversationResponse AnalyzeConversationWithOptions(string workspaceId, string appId, AnalyzeConversationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryTags))
            {
                body["categoryTags"] = request.CategoryTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dialogue))
            {
                body["dialogue"] = request.Dialogue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Examples))
            {
                body["examples"] = request.Examples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                body["modelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultTypes))
            {
                body["resultTypes"] = request.ResultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                body["sceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInspection))
            {
                body["serviceInspection"] = request.ServiceInspection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProfiles))
            {
                body["userProfiles"] = request.UserProfiles;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnalyzeConversation",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/analyze_conversation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalyzeConversationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据类型调用大模型
         *
         * @param request AnalyzeConversationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AnalyzeConversationResponse
         */
        public async Task<AnalyzeConversationResponse> AnalyzeConversationWithOptionsAsync(string workspaceId, string appId, AnalyzeConversationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryTags))
            {
                body["categoryTags"] = request.CategoryTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dialogue))
            {
                body["dialogue"] = request.Dialogue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Examples))
            {
                body["examples"] = request.Examples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                body["modelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultTypes))
            {
                body["resultTypes"] = request.ResultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                body["sceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInspection))
            {
                body["serviceInspection"] = request.ServiceInspection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProfiles))
            {
                body["userProfiles"] = request.UserProfiles;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnalyzeConversation",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/analyze_conversation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalyzeConversationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据类型调用大模型
         *
         * @param request AnalyzeConversationRequest
         * @return AnalyzeConversationResponse
         */
        public AnalyzeConversationResponse AnalyzeConversation(string workspaceId, string appId, AnalyzeConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AnalyzeConversationWithOptions(workspaceId, appId, request, headers, runtime);
        }

        /**
         * @summary 根据类型调用大模型
         *
         * @param request AnalyzeConversationRequest
         * @return AnalyzeConversationResponse
         */
        public async Task<AnalyzeConversationResponse> AnalyzeConversationAsync(string workspaceId, string appId, AnalyzeConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AnalyzeConversationWithOptionsAsync(workspaceId, appId, request, headers, runtime);
        }

        /**
         * @summary 创建语音文件调用llm任务
         *
         * @param request CreateConversationAnalysisTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConversationAnalysisTaskResponse
         */
        public CreateConversationAnalysisTaskResponse CreateConversationAnalysisTaskWithOptions(string workspaceId, string appId, CreateConversationAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSplit))
            {
                body["autoSplit"] = request.AutoSplit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientChannel))
            {
                body["clientChannel"] = request.ClientChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Examples))
            {
                body["examples"] = request.Examples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                body["modelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultTypes))
            {
                body["resultTypes"] = request.ResultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                body["sceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceChannel))
            {
                body["serviceChannel"] = request.ServiceChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceChannelKeywords))
            {
                body["serviceChannelKeywords"] = request.ServiceChannelKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInspection))
            {
                body["serviceInspection"] = request.ServiceInspection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceFileUrl))
            {
                body["voiceFileUrl"] = request.VoiceFileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConversationAnalysisTask",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/createConversationAnalysisTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConversationAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建语音文件调用llm任务
         *
         * @param request CreateConversationAnalysisTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConversationAnalysisTaskResponse
         */
        public async Task<CreateConversationAnalysisTaskResponse> CreateConversationAnalysisTaskWithOptionsAsync(string workspaceId, string appId, CreateConversationAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSplit))
            {
                body["autoSplit"] = request.AutoSplit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientChannel))
            {
                body["clientChannel"] = request.ClientChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Examples))
            {
                body["examples"] = request.Examples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                body["modelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultTypes))
            {
                body["resultTypes"] = request.ResultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                body["sceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceChannel))
            {
                body["serviceChannel"] = request.ServiceChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceChannelKeywords))
            {
                body["serviceChannelKeywords"] = request.ServiceChannelKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInspection))
            {
                body["serviceInspection"] = request.ServiceInspection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceFileUrl))
            {
                body["voiceFileUrl"] = request.VoiceFileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConversationAnalysisTask",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/createConversationAnalysisTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConversationAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建语音文件调用llm任务
         *
         * @param request CreateConversationAnalysisTaskRequest
         * @return CreateConversationAnalysisTaskResponse
         */
        public CreateConversationAnalysisTaskResponse CreateConversationAnalysisTask(string workspaceId, string appId, CreateConversationAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConversationAnalysisTaskWithOptions(workspaceId, appId, request, headers, runtime);
        }

        /**
         * @summary 创建语音文件调用llm任务
         *
         * @param request CreateConversationAnalysisTaskRequest
         * @return CreateConversationAnalysisTaskResponse
         */
        public async Task<CreateConversationAnalysisTaskResponse> CreateConversationAnalysisTaskAsync(string workspaceId, string appId, CreateConversationAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConversationAnalysisTaskWithOptionsAsync(workspaceId, appId, request, headers, runtime);
        }

        /**
         * @summary 语音文件调用大模型获取结果
         *
         * @param request GetTaskResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskResultResponse
         */
        public GetTaskResultResponse GetTaskResultWithOptions(GetTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskResult",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/ccai/app/getTaskResult",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 语音文件调用大模型获取结果
         *
         * @param request GetTaskResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskResultResponse
         */
        public async Task<GetTaskResultResponse> GetTaskResultWithOptionsAsync(GetTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskResult",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/ccai/app/getTaskResult",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 语音文件调用大模型获取结果
         *
         * @param request GetTaskResultRequest
         * @return GetTaskResultResponse
         */
        public GetTaskResultResponse GetTaskResult(GetTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskResultWithOptions(request, headers, runtime);
        }

        /**
         * @summary 语音文件调用大模型获取结果
         *
         * @param request GetTaskResultRequest
         * @return GetTaskResultResponse
         */
        public async Task<GetTaskResultResponse> GetTaskResultAsync(GetTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskResultWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary CCAI服务面API
         *
         * @param request RunCompletionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunCompletionResponse
         */
        public RunCompletionResponse RunCompletionWithOptions(string workspaceId, string appId, RunCompletionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dialogue))
            {
                body["Dialogue"] = request.Dialogue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                body["ModelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInspection))
            {
                body["ServiceInspection"] = request.ServiceInspection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["Stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["TemplateIds"] = request.TemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCompletion",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/completion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCompletionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary CCAI服务面API
         *
         * @param request RunCompletionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunCompletionResponse
         */
        public async Task<RunCompletionResponse> RunCompletionWithOptionsAsync(string workspaceId, string appId, RunCompletionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dialogue))
            {
                body["Dialogue"] = request.Dialogue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                body["ModelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInspection))
            {
                body["ServiceInspection"] = request.ServiceInspection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["Stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["TemplateIds"] = request.TemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCompletion",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/completion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCompletionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary CCAI服务面API
         *
         * @param request RunCompletionRequest
         * @return RunCompletionResponse
         */
        public RunCompletionResponse RunCompletion(string workspaceId, string appId, RunCompletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunCompletionWithOptions(workspaceId, appId, request, headers, runtime);
        }

        /**
         * @summary CCAI服务面API
         *
         * @param request RunCompletionRequest
         * @return RunCompletionResponse
         */
        public async Task<RunCompletionResponse> RunCompletionAsync(string workspaceId, string appId, RunCompletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunCompletionWithOptionsAsync(workspaceId, appId, request, headers, runtime);
        }

        /**
         * @summary CCAI服务面API
         *
         * @param request RunCompletionMessageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunCompletionMessageResponse
         */
        public RunCompletionMessageResponse RunCompletionMessageWithOptions(string workspaceId, string appId, RunCompletionMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["Messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                body["ModelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["Stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCompletionMessage",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/completion_message",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCompletionMessageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary CCAI服务面API
         *
         * @param request RunCompletionMessageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunCompletionMessageResponse
         */
        public async Task<RunCompletionMessageResponse> RunCompletionMessageWithOptionsAsync(string workspaceId, string appId, RunCompletionMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["Messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                body["ModelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["Stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCompletionMessage",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/completion_message",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCompletionMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary CCAI服务面API
         *
         * @param request RunCompletionMessageRequest
         * @return RunCompletionMessageResponse
         */
        public RunCompletionMessageResponse RunCompletionMessage(string workspaceId, string appId, RunCompletionMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunCompletionMessageWithOptions(workspaceId, appId, request, headers, runtime);
        }

        /**
         * @summary CCAI服务面API
         *
         * @param request RunCompletionMessageRequest
         * @return RunCompletionMessageResponse
         */
        public async Task<RunCompletionMessageResponse> RunCompletionMessageAsync(string workspaceId, string appId, RunCompletionMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunCompletionMessageWithOptionsAsync(workspaceId, appId, request, headers, runtime);
        }

    }
}
