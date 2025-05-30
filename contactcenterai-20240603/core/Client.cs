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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语音文件分析任务极速版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeAudioSyncRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeAudioSyncResponse
        /// </returns>
        public AnalyzeAudioSyncResponse AnalyzeAudioSyncWithOptions(string workspaceId, string appId, AnalyzeAudioSyncRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryTags))
            {
                body["categoryTags"] = request.CategoryTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                body["modelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormatType))
            {
                body["responseFormatType"] = request.ResponseFormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultTypes))
            {
                body["resultTypes"] = request.ResultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInspection))
            {
                body["serviceInspection"] = request.ServiceInspection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transcription))
            {
                body["transcription"] = request.Transcription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnalyzeAudioSync",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/analyzeAudioSync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalyzeAudioSyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语音文件分析任务极速版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeAudioSyncRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeAudioSyncResponse
        /// </returns>
        public async Task<AnalyzeAudioSyncResponse> AnalyzeAudioSyncWithOptionsAsync(string workspaceId, string appId, AnalyzeAudioSyncRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryTags))
            {
                body["categoryTags"] = request.CategoryTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                body["modelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormatType))
            {
                body["responseFormatType"] = request.ResponseFormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultTypes))
            {
                body["resultTypes"] = request.ResultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInspection))
            {
                body["serviceInspection"] = request.ServiceInspection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transcription))
            {
                body["transcription"] = request.Transcription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnalyzeAudioSync",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/analyzeAudioSync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalyzeAudioSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语音文件分析任务极速版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeAudioSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeAudioSyncResponse
        /// </returns>
        public AnalyzeAudioSyncResponse AnalyzeAudioSync(string workspaceId, string appId, AnalyzeAudioSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AnalyzeAudioSyncWithOptions(workspaceId, appId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语音文件分析任务极速版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeAudioSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeAudioSyncResponse
        /// </returns>
        public async Task<AnalyzeAudioSyncResponse> AnalyzeAudioSyncAsync(string workspaceId, string appId, AnalyzeAudioSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AnalyzeAudioSyncWithOptionsAsync(workspaceId, appId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据类型调用大模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeConversationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeConversationResponse
        /// </returns>
        public AnalyzeConversationResponse AnalyzeConversationWithOptions(string workspaceId, string appId, AnalyzeConversationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryTags))
            {
                body["categoryTags"] = request.CategoryTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormatType))
            {
                body["responseFormatType"] = request.ResponseFormatType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCallerUid))
            {
                body["sourceCallerUid"] = request.SourceCallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeConstraintList))
            {
                body["timeConstraintList"] = request.TimeConstraintList;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据类型调用大模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeConversationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeConversationResponse
        /// </returns>
        public async Task<AnalyzeConversationResponse> AnalyzeConversationWithOptionsAsync(string workspaceId, string appId, AnalyzeConversationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryTags))
            {
                body["categoryTags"] = request.CategoryTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormatType))
            {
                body["responseFormatType"] = request.ResponseFormatType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCallerUid))
            {
                body["sourceCallerUid"] = request.SourceCallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeConstraintList))
            {
                body["timeConstraintList"] = request.TimeConstraintList;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据类型调用大模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeConversationResponse
        /// </returns>
        public AnalyzeConversationResponse AnalyzeConversation(string workspaceId, string appId, AnalyzeConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AnalyzeConversationWithOptions(workspaceId, appId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据类型调用大模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeConversationResponse
        /// </returns>
        public async Task<AnalyzeConversationResponse> AnalyzeConversationAsync(string workspaceId, string appId, AnalyzeConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AnalyzeConversationWithOptionsAsync(workspaceId, appId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeImageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeImageResponse
        /// </returns>
        public AnalyzeImageResponse AnalyzeImageWithOptions(string workspaceId, string appId, AnalyzeImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrls))
            {
                body["imageUrls"] = request.ImageUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormatType))
            {
                body["responseFormatType"] = request.ResponseFormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultTypes))
            {
                body["resultTypes"] = request.ResultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnalyzeImage",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/analyzeImage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalyzeImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeImageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeImageResponse
        /// </returns>
        public async Task<AnalyzeImageResponse> AnalyzeImageWithOptionsAsync(string workspaceId, string appId, AnalyzeImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrls))
            {
                body["imageUrls"] = request.ImageUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormatType))
            {
                body["responseFormatType"] = request.ResponseFormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultTypes))
            {
                body["resultTypes"] = request.ResultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnalyzeImage",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/analyzeImage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalyzeImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeImageRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeImageResponse
        /// </returns>
        public AnalyzeImageResponse AnalyzeImage(string workspaceId, string appId, AnalyzeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AnalyzeImageWithOptions(workspaceId, appId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeImageRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeImageResponse
        /// </returns>
        public async Task<AnalyzeImageResponse> AnalyzeImageAsync(string workspaceId, string appId, AnalyzeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AnalyzeImageWithOptionsAsync(workspaceId, appId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音文件调用llm任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public CreateTaskResponse CreateTaskWithOptions(string workspaceId, string appId, CreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallBackUrl))
            {
                body["callBackUrl"] = request.CallBackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryTags))
            {
                body["categoryTags"] = request.CategoryTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormatType))
            {
                body["responseFormatType"] = request.ResponseFormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultTypes))
            {
                body["resultTypes"] = request.ResultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInspection))
            {
                body["serviceInspection"] = request.ServiceInspection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transcription))
            {
                body["transcription"] = request.Transcription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTask",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/createTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音文件调用llm任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public async Task<CreateTaskResponse> CreateTaskWithOptionsAsync(string workspaceId, string appId, CreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallBackUrl))
            {
                body["callBackUrl"] = request.CallBackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryTags))
            {
                body["categoryTags"] = request.CategoryTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormatType))
            {
                body["responseFormatType"] = request.ResponseFormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultTypes))
            {
                body["resultTypes"] = request.ResultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInspection))
            {
                body["serviceInspection"] = request.ServiceInspection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transcription))
            {
                body["transcription"] = request.Transcription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTask",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ccai/app/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/createTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音文件调用llm任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public CreateTaskResponse CreateTask(string workspaceId, string appId, CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTaskWithOptions(workspaceId, appId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音文件调用llm任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public async Task<CreateTaskResponse> CreateTaskAsync(string workspaceId, string appId, CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTaskWithOptionsAsync(workspaceId, appId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVocabRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVocabResponse
        /// </returns>
        public CreateVocabResponse CreateVocabWithOptions(CreateVocabRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioModelCode))
            {
                body["audioModelCode"] = request.AudioModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordWeightList))
            {
                body["wordWeightList"] = request.WordWeightList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVocab",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/vocab/createVocab",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVocabResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVocabRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVocabResponse
        /// </returns>
        public async Task<CreateVocabResponse> CreateVocabWithOptionsAsync(CreateVocabRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioModelCode))
            {
                body["audioModelCode"] = request.AudioModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordWeightList))
            {
                body["wordWeightList"] = request.WordWeightList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVocab",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/vocab/createVocab",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVocabResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVocabResponse
        /// </returns>
        public CreateVocabResponse CreateVocab(CreateVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateVocabWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVocabResponse
        /// </returns>
        public async Task<CreateVocabResponse> CreateVocabAsync(CreateVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateVocabWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删删除热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVocabRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVocabResponse
        /// </returns>
        public DeleteVocabResponse DeleteVocabWithOptions(DeleteVocabRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VocabularyId))
            {
                body["vocabularyId"] = request.VocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVocab",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/vocab/deleteVocab",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVocabResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删删除热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVocabRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVocabResponse
        /// </returns>
        public async Task<DeleteVocabResponse> DeleteVocabWithOptionsAsync(DeleteVocabRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VocabularyId))
            {
                body["vocabularyId"] = request.VocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVocab",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/vocab/deleteVocab",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVocabResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删删除热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVocabResponse
        /// </returns>
        public DeleteVocabResponse DeleteVocab(DeleteVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteVocabWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删删除热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVocabResponse
        /// </returns>
        public async Task<DeleteVocabResponse> DeleteVocabAsync(DeleteVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteVocabWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语音文件调用大模型获取结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResultResponse
        /// </returns>
        public GetTaskResultResponse GetTaskResultWithOptions(GetTaskResultRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTaskResultShrinkRequest request = new GetTaskResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequiredFieldList))
            {
                request.RequiredFieldListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequiredFieldList, "requiredFieldList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequiredFieldListShrink))
            {
                query["requiredFieldList"] = request.RequiredFieldListShrink;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语音文件调用大模型获取结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResultResponse
        /// </returns>
        public async Task<GetTaskResultResponse> GetTaskResultWithOptionsAsync(GetTaskResultRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTaskResultShrinkRequest request = new GetTaskResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequiredFieldList))
            {
                request.RequiredFieldListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequiredFieldList, "requiredFieldList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequiredFieldListShrink))
            {
                query["requiredFieldList"] = request.RequiredFieldListShrink;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语音文件调用大模型获取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResultResponse
        /// </returns>
        public GetTaskResultResponse GetTaskResult(GetTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语音文件调用大模型获取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResultResponse
        /// </returns>
        public async Task<GetTaskResultResponse> GetTaskResultAsync(GetTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVocabRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVocabResponse
        /// </returns>
        public GetVocabResponse GetVocabWithOptions(GetVocabRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VocabularyId))
            {
                body["vocabularyId"] = request.VocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVocab",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/vocab/getVocab",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVocabResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVocabRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVocabResponse
        /// </returns>
        public async Task<GetVocabResponse> GetVocabWithOptionsAsync(GetVocabRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VocabularyId))
            {
                body["vocabularyId"] = request.VocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVocab",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/vocab/getVocab",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVocabResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVocabResponse
        /// </returns>
        public GetVocabResponse GetVocab(GetVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetVocabWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVocabResponse
        /// </returns>
        public async Task<GetVocabResponse> GetVocabAsync(GetVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetVocabWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热词列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVocabRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVocabResponse
        /// </returns>
        public ListVocabResponse ListVocabWithOptions(ListVocabRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVocab",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/vocab/listVocab",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVocabResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热词列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVocabRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVocabResponse
        /// </returns>
        public async Task<ListVocabResponse> ListVocabWithOptionsAsync(ListVocabRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVocab",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/vocab/listVocab",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVocabResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热词列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVocabResponse
        /// </returns>
        public ListVocabResponse ListVocab(ListVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVocabWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热词列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVocabResponse
        /// </returns>
        public async Task<ListVocabResponse> ListVocabAsync(ListVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVocabWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CCAI服务面API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCompletionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCompletionResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormatType))
            {
                body["responseFormatType"] = request.ResponseFormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CCAI服务面API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCompletionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCompletionResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormatType))
            {
                body["responseFormatType"] = request.ResponseFormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CCAI服务面API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCompletionRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCompletionResponse
        /// </returns>
        public RunCompletionResponse RunCompletion(string workspaceId, string appId, RunCompletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunCompletionWithOptions(workspaceId, appId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CCAI服务面API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCompletionRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCompletionResponse
        /// </returns>
        public async Task<RunCompletionResponse> RunCompletionAsync(string workspaceId, string appId, RunCompletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunCompletionWithOptionsAsync(workspaceId, appId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CCAI服务面API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCompletionMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCompletionMessageResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormatType))
            {
                body["responseFormatType"] = request.ResponseFormatType;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CCAI服务面API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCompletionMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCompletionMessageResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormatType))
            {
                body["responseFormatType"] = request.ResponseFormatType;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CCAI服务面API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCompletionMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCompletionMessageResponse
        /// </returns>
        public RunCompletionMessageResponse RunCompletionMessage(string workspaceId, string appId, RunCompletionMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunCompletionMessageWithOptions(workspaceId, appId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CCAI服务面API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCompletionMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCompletionMessageResponse
        /// </returns>
        public async Task<RunCompletionMessageResponse> RunCompletionMessageAsync(string workspaceId, string appId, RunCompletionMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunCompletionMessageWithOptionsAsync(workspaceId, appId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVocabRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVocabResponse
        /// </returns>
        public UpdateVocabResponse UpdateVocabWithOptions(UpdateVocabRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VocabularyId))
            {
                body["vocabularyId"] = request.VocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordWeightList))
            {
                body["wordWeightList"] = request.WordWeightList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVocab",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/vocab/updateVocab",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVocabResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVocabRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVocabResponse
        /// </returns>
        public async Task<UpdateVocabResponse> UpdateVocabWithOptionsAsync(UpdateVocabRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VocabularyId))
            {
                body["vocabularyId"] = request.VocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordWeightList))
            {
                body["wordWeightList"] = request.WordWeightList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVocab",
                Version = "2024-06-03",
                Protocol = "HTTPS",
                Pathname = "/vocab/updateVocab",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVocabResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVocabResponse
        /// </returns>
        public UpdateVocabResponse UpdateVocab(UpdateVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateVocabWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改热词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVocabResponse
        /// </returns>
        public async Task<UpdateVocabResponse> UpdateVocabAsync(UpdateVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateVocabWithOptionsAsync(request, headers, runtime);
        }

    }
}
