// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Searchplat20240529.Models;

namespace AlibabaCloud.SDK.Searchplat20240529
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "Searchplat";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音转录异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAudioAsrTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAudioAsrTaskResponse
        /// </returns>
        public CreateAudioAsrTaskResponse CreateAudioAsrTaskWithOptions(string workspaceName, string serviceId, CreateAudioAsrTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAudioAsrTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/audio-asr/" + serviceId + "/async",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAudioAsrTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音转录异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAudioAsrTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAudioAsrTaskResponse
        /// </returns>
        public async Task<CreateAudioAsrTaskResponse> CreateAudioAsrTaskWithOptionsAsync(string workspaceName, string serviceId, CreateAudioAsrTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAudioAsrTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/audio-asr/" + serviceId + "/async",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAudioAsrTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音转录异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAudioAsrTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAudioAsrTaskResponse
        /// </returns>
        public CreateAudioAsrTaskResponse CreateAudioAsrTask(string workspaceName, string serviceId, CreateAudioAsrTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAudioAsrTaskWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音转录异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAudioAsrTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAudioAsrTaskResponse
        /// </returns>
        public async Task<CreateAudioAsrTaskResponse> CreateAudioAsrTaskAsync(string workspaceName, string serviceId, CreateAudioAsrTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAudioAsrTaskWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文档解析异步提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDocumentAnalyzeTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDocumentAnalyzeTaskResponse
        /// </returns>
        public CreateDocumentAnalyzeTaskResponse CreateDocumentAnalyzeTaskWithOptions(string workspaceName, string serviceId, CreateDocumentAnalyzeTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Document))
            {
                body["document"] = request.Document;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                body["strategy"] = request.Strategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDocumentAnalyzeTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/document-analyze/" + serviceId + "/async",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDocumentAnalyzeTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文档解析异步提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDocumentAnalyzeTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDocumentAnalyzeTaskResponse
        /// </returns>
        public async Task<CreateDocumentAnalyzeTaskResponse> CreateDocumentAnalyzeTaskWithOptionsAsync(string workspaceName, string serviceId, CreateDocumentAnalyzeTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Document))
            {
                body["document"] = request.Document;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                body["strategy"] = request.Strategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDocumentAnalyzeTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/document-analyze/" + serviceId + "/async",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDocumentAnalyzeTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文档解析异步提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDocumentAnalyzeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDocumentAnalyzeTaskResponse
        /// </returns>
        public CreateDocumentAnalyzeTaskResponse CreateDocumentAnalyzeTask(string workspaceName, string serviceId, CreateDocumentAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDocumentAnalyzeTaskWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文档解析异步提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDocumentAnalyzeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDocumentAnalyzeTaskResponse
        /// </returns>
        public async Task<CreateDocumentAnalyzeTaskResponse> CreateDocumentAnalyzeTaskAsync(string workspaceName, string serviceId, CreateDocumentAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDocumentAnalyzeTaskWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建图片解析异步提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageAnalyzeTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageAnalyzeTaskResponse
        /// </returns>
        public CreateImageAnalyzeTaskResponse CreateImageAnalyzeTaskWithOptions(string workspaceName, string serviceId, CreateImageAnalyzeTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Document))
            {
                body["document"] = request.Document;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageAnalyzeTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/image-analyze/" + serviceId + "/async",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageAnalyzeTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建图片解析异步提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageAnalyzeTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageAnalyzeTaskResponse
        /// </returns>
        public async Task<CreateImageAnalyzeTaskResponse> CreateImageAnalyzeTaskWithOptionsAsync(string workspaceName, string serviceId, CreateImageAnalyzeTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Document))
            {
                body["document"] = request.Document;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageAnalyzeTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/image-analyze/" + serviceId + "/async",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageAnalyzeTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建图片解析异步提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageAnalyzeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageAnalyzeTaskResponse
        /// </returns>
        public CreateImageAnalyzeTaskResponse CreateImageAnalyzeTask(string workspaceName, string serviceId, CreateImageAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateImageAnalyzeTaskWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建图片解析异步提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageAnalyzeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageAnalyzeTaskResponse
        /// </returns>
        public async Task<CreateImageAnalyzeTaskResponse> CreateImageAnalyzeTaskAsync(string workspaceName, string serviceId, CreateImageAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateImageAnalyzeTaskWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音转录异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoSnapshotTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoSnapshotTaskResponse
        /// </returns>
        public CreateVideoSnapshotTaskResponse CreateVideoSnapshotTaskWithOptions(string workspaceName, string serviceId, CreateVideoSnapshotTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoSnapshotTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/video-snapshot/" + serviceId + "/async",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoSnapshotTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音转录异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoSnapshotTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoSnapshotTaskResponse
        /// </returns>
        public async Task<CreateVideoSnapshotTaskResponse> CreateVideoSnapshotTaskWithOptionsAsync(string workspaceName, string serviceId, CreateVideoSnapshotTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoSnapshotTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/video-snapshot/" + serviceId + "/async",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoSnapshotTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音转录异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoSnapshotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoSnapshotTaskResponse
        /// </returns>
        public CreateVideoSnapshotTaskResponse CreateVideoSnapshotTask(string workspaceName, string serviceId, CreateVideoSnapshotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateVideoSnapshotTaskWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音转录异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoSnapshotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoSnapshotTaskResponse
        /// </returns>
        public async Task<CreateVideoSnapshotTaskResponse> CreateVideoSnapshotTaskAsync(string workspaceName, string serviceId, CreateVideoSnapshotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateVideoSnapshotTaskWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频截帧异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAudioAsrTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAudioAsrTaskStatusResponse
        /// </returns>
        public GetAudioAsrTaskStatusResponse GetAudioAsrTaskStatusWithOptions(string workspaceName, string serviceId, GetAudioAsrTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAudioAsrTaskStatus",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/audio-asr/" + serviceId + "/async/task-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAudioAsrTaskStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频截帧异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAudioAsrTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAudioAsrTaskStatusResponse
        /// </returns>
        public async Task<GetAudioAsrTaskStatusResponse> GetAudioAsrTaskStatusWithOptionsAsync(string workspaceName, string serviceId, GetAudioAsrTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAudioAsrTaskStatus",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/audio-asr/" + serviceId + "/async/task-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAudioAsrTaskStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频截帧异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAudioAsrTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAudioAsrTaskStatusResponse
        /// </returns>
        public GetAudioAsrTaskStatusResponse GetAudioAsrTaskStatus(string workspaceName, string serviceId, GetAudioAsrTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAudioAsrTaskStatusWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频截帧异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAudioAsrTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAudioAsrTaskStatusResponse
        /// </returns>
        public async Task<GetAudioAsrTaskStatusResponse> GetAudioAsrTaskStatusAsync(string workspaceName, string serviceId, GetAudioAsrTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAudioAsrTaskStatusWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档解析异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentAnalyzeTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentAnalyzeTaskStatusResponse
        /// </returns>
        public GetDocumentAnalyzeTaskStatusResponse GetDocumentAnalyzeTaskStatusWithOptions(string workspaceName, string serviceId, GetDocumentAnalyzeTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentAnalyzeTaskStatus",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/document-analyze/" + serviceId + "/async/task-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentAnalyzeTaskStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档解析异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentAnalyzeTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentAnalyzeTaskStatusResponse
        /// </returns>
        public async Task<GetDocumentAnalyzeTaskStatusResponse> GetDocumentAnalyzeTaskStatusWithOptionsAsync(string workspaceName, string serviceId, GetDocumentAnalyzeTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentAnalyzeTaskStatus",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/document-analyze/" + serviceId + "/async/task-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentAnalyzeTaskStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档解析异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentAnalyzeTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentAnalyzeTaskStatusResponse
        /// </returns>
        public GetDocumentAnalyzeTaskStatusResponse GetDocumentAnalyzeTaskStatus(string workspaceName, string serviceId, GetDocumentAnalyzeTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentAnalyzeTaskStatusWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档解析异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentAnalyzeTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentAnalyzeTaskStatusResponse
        /// </returns>
        public async Task<GetDocumentAnalyzeTaskStatusResponse> GetDocumentAnalyzeTaskStatusAsync(string workspaceName, string serviceId, GetDocumentAnalyzeTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentAnalyzeTaskStatusWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档相关性打分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentRankRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentRankResponse
        /// </returns>
        public GetDocumentRankResponse GetDocumentRankWithOptions(string workspaceName, string serviceId, GetDocumentRankRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Docs))
            {
                body["docs"] = request.Docs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentRank",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/ranker/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentRankResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档相关性打分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentRankRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentRankResponse
        /// </returns>
        public async Task<GetDocumentRankResponse> GetDocumentRankWithOptionsAsync(string workspaceName, string serviceId, GetDocumentRankRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Docs))
            {
                body["docs"] = request.Docs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentRank",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/ranker/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentRankResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档相关性打分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentRankRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentRankResponse
        /// </returns>
        public GetDocumentRankResponse GetDocumentRank(string workspaceName, string serviceId, GetDocumentRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentRankWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档相关性打分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentRankRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentRankResponse
        /// </returns>
        public async Task<GetDocumentRankResponse> GetDocumentRankAsync(string workspaceName, string serviceId, GetDocumentRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentRankWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档切片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentSplitRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentSplitResponse
        /// </returns>
        public GetDocumentSplitResponse GetDocumentSplitWithOptions(string workspaceName, string serviceId, GetDocumentSplitRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Document))
            {
                body["document"] = request.Document;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                body["strategy"] = request.Strategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentSplit",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/document-split/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentSplitResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档切片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentSplitRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentSplitResponse
        /// </returns>
        public async Task<GetDocumentSplitResponse> GetDocumentSplitWithOptionsAsync(string workspaceName, string serviceId, GetDocumentSplitRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Document))
            {
                body["document"] = request.Document;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                body["strategy"] = request.Strategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentSplit",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/document-split/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentSplitResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档切片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentSplitRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentSplitResponse
        /// </returns>
        public GetDocumentSplitResponse GetDocumentSplit(string workspaceName, string serviceId, GetDocumentSplitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentSplitWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档切片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentSplitRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentSplitResponse
        /// </returns>
        public async Task<GetDocumentSplitResponse> GetDocumentSplitAsync(string workspaceName, string serviceId, GetDocumentSplitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentSplitWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向量微调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmbeddingTuningRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEmbeddingTuningResponse
        /// </returns>
        public GetEmbeddingTuningResponse GetEmbeddingTuningWithOptions(string workspaceName, string serviceId, GetEmbeddingTuningRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmbeddingTuning",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/embedding-tuning/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmbeddingTuningResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向量微调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmbeddingTuningRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEmbeddingTuningResponse
        /// </returns>
        public async Task<GetEmbeddingTuningResponse> GetEmbeddingTuningWithOptionsAsync(string workspaceName, string serviceId, GetEmbeddingTuningRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmbeddingTuning",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/embedding-tuning/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmbeddingTuningResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向量微调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmbeddingTuningRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEmbeddingTuningResponse
        /// </returns>
        public GetEmbeddingTuningResponse GetEmbeddingTuning(string workspaceName, string serviceId, GetEmbeddingTuningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEmbeddingTuningWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向量微调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmbeddingTuningRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEmbeddingTuningResponse
        /// </returns>
        public async Task<GetEmbeddingTuningResponse> GetEmbeddingTuningAsync(string workspaceName, string serviceId, GetEmbeddingTuningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEmbeddingTuningWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图片解析异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageAnalyzeTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageAnalyzeTaskStatusResponse
        /// </returns>
        public GetImageAnalyzeTaskStatusResponse GetImageAnalyzeTaskStatusWithOptions(string workspaceName, string serviceId, GetImageAnalyzeTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageAnalyzeTaskStatus",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/image-analyze/" + serviceId + "/async/task-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageAnalyzeTaskStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图片解析异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageAnalyzeTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageAnalyzeTaskStatusResponse
        /// </returns>
        public async Task<GetImageAnalyzeTaskStatusResponse> GetImageAnalyzeTaskStatusWithOptionsAsync(string workspaceName, string serviceId, GetImageAnalyzeTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageAnalyzeTaskStatus",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/image-analyze/" + serviceId + "/async/task-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageAnalyzeTaskStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图片解析异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageAnalyzeTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageAnalyzeTaskStatusResponse
        /// </returns>
        public GetImageAnalyzeTaskStatusResponse GetImageAnalyzeTaskStatus(string workspaceName, string serviceId, GetImageAnalyzeTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetImageAnalyzeTaskStatusWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图片解析异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageAnalyzeTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageAnalyzeTaskStatusResponse
        /// </returns>
        public async Task<GetImageAnalyzeTaskStatusResponse> GetImageAnalyzeTaskStatusAsync(string workspaceName, string serviceId, GetImageAnalyzeTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetImageAnalyzeTaskStatusWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多模态向量化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiModalEmbeddingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMultiModalEmbeddingResponse
        /// </returns>
        public GetMultiModalEmbeddingResponse GetMultiModalEmbeddingWithOptions(string workspaceName, string serviceId, GetMultiModalEmbeddingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMultiModalEmbedding",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/multi-modal-embedding/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMultiModalEmbeddingResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多模态向量化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiModalEmbeddingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMultiModalEmbeddingResponse
        /// </returns>
        public async Task<GetMultiModalEmbeddingResponse> GetMultiModalEmbeddingWithOptionsAsync(string workspaceName, string serviceId, GetMultiModalEmbeddingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMultiModalEmbedding",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/multi-modal-embedding/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMultiModalEmbeddingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多模态向量化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiModalEmbeddingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMultiModalEmbeddingResponse
        /// </returns>
        public GetMultiModalEmbeddingResponse GetMultiModalEmbedding(string workspaceName, string serviceId, GetMultiModalEmbeddingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMultiModalEmbeddingWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多模态向量化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiModalEmbeddingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMultiModalEmbeddingResponse
        /// </returns>
        public async Task<GetMultiModalEmbeddingResponse> GetMultiModalEmbeddingAsync(string workspaceName, string serviceId, GetMultiModalEmbeddingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMultiModalEmbeddingWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取推理结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPredictionRequest
        /// </param>
        /// <param name="headers">
        /// GetPredictionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPredictionResponse
        /// </returns>
        public GetPredictionResponse GetPredictionWithOptions(string deploymentId, GetPredictionRequest request, GetPredictionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Token))
            {
                realHeaders["Token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Token);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrediction",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/deployments/" + deploymentId + "/predict",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetPredictionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取推理结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPredictionRequest
        /// </param>
        /// <param name="headers">
        /// GetPredictionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPredictionResponse
        /// </returns>
        public async Task<GetPredictionResponse> GetPredictionWithOptionsAsync(string deploymentId, GetPredictionRequest request, GetPredictionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Token))
            {
                realHeaders["Token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Token);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrediction",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/deployments/" + deploymentId + "/predict",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetPredictionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取推理结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPredictionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPredictionResponse
        /// </returns>
        public GetPredictionResponse GetPrediction(string deploymentId, GetPredictionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPredictionHeaders headers = new GetPredictionHeaders();
            return GetPredictionWithOptions(deploymentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取推理结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPredictionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPredictionResponse
        /// </returns>
        public async Task<GetPredictionResponse> GetPredictionAsync(string deploymentId, GetPredictionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPredictionHeaders headers = new GetPredictionHeaders();
            return await GetPredictionWithOptionsAsync(deploymentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取query分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueryAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryAnalysisResponse
        /// </returns>
        public GetQueryAnalysisResponse GetQueryAnalysisWithOptions(string workspaceName, string serviceId, GetQueryAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Functions))
            {
                body["functions"] = request.Functions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.History))
            {
                body["history"] = request.History;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryAnalysis",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/query-analyze/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryAnalysisResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取query分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueryAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryAnalysisResponse
        /// </returns>
        public async Task<GetQueryAnalysisResponse> GetQueryAnalysisWithOptionsAsync(string workspaceName, string serviceId, GetQueryAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Functions))
            {
                body["functions"] = request.Functions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.History))
            {
                body["history"] = request.History;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryAnalysis",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/query-analyze/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryAnalysisResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取query分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueryAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryAnalysisResponse
        /// </returns>
        public GetQueryAnalysisResponse GetQueryAnalysis(string workspaceName, string serviceId, GetQueryAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQueryAnalysisWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取query分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueryAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryAnalysisResponse
        /// </returns>
        public async Task<GetQueryAnalysisResponse> GetQueryAnalysisAsync(string workspaceName, string serviceId, GetQueryAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQueryAnalysisWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本向量化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextEmbeddingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTextEmbeddingResponse
        /// </returns>
        public GetTextEmbeddingResponse GetTextEmbeddingWithOptions(string workspaceName, string serviceId, GetTextEmbeddingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputType))
            {
                body["input_type"] = request.InputType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextEmbedding",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/text-embedding/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextEmbeddingResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本向量化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextEmbeddingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTextEmbeddingResponse
        /// </returns>
        public async Task<GetTextEmbeddingResponse> GetTextEmbeddingWithOptionsAsync(string workspaceName, string serviceId, GetTextEmbeddingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputType))
            {
                body["input_type"] = request.InputType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextEmbedding",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/text-embedding/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextEmbeddingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本向量化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextEmbeddingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTextEmbeddingResponse
        /// </returns>
        public GetTextEmbeddingResponse GetTextEmbedding(string workspaceName, string serviceId, GetTextEmbeddingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextEmbeddingWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本向量化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextEmbeddingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTextEmbeddingResponse
        /// </returns>
        public async Task<GetTextEmbeddingResponse> GetTextEmbeddingAsync(string workspaceName, string serviceId, GetTextEmbeddingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextEmbeddingWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>大模型问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTextGenerationResponse
        /// </returns>
        public GetTextGenerationResponse GetTextGenerationWithOptions(string workspaceName, string serviceId, GetTextGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsiLevel))
            {
                body["csi_level"] = request.CsiLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSearch))
            {
                body["enable_search"] = request.EnableSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
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
                Action = "GetTextGeneration",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/text-generation/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextGenerationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>大模型问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTextGenerationResponse
        /// </returns>
        public async Task<GetTextGenerationResponse> GetTextGenerationWithOptionsAsync(string workspaceName, string serviceId, GetTextGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsiLevel))
            {
                body["csi_level"] = request.CsiLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSearch))
            {
                body["enable_search"] = request.EnableSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
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
                Action = "GetTextGeneration",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/text-generation/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextGenerationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>大模型问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTextGenerationResponse
        /// </returns>
        public GetTextGenerationResponse GetTextGeneration(string workspaceName, string serviceId, GetTextGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextGenerationWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>大模型问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTextGenerationResponse
        /// </returns>
        public async Task<GetTextGenerationResponse> GetTextGenerationAsync(string workspaceName, string serviceId, GetTextGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextGenerationWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本稀疏向量化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextSparseEmbeddingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTextSparseEmbeddingResponse
        /// </returns>
        public GetTextSparseEmbeddingResponse GetTextSparseEmbeddingWithOptions(string workspaceName, string serviceId, GetTextSparseEmbeddingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputType))
            {
                body["input_type"] = request.InputType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnToken))
            {
                body["return_token"] = request.ReturnToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextSparseEmbedding",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/text-sparse-embedding/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextSparseEmbeddingResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本稀疏向量化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextSparseEmbeddingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTextSparseEmbeddingResponse
        /// </returns>
        public async Task<GetTextSparseEmbeddingResponse> GetTextSparseEmbeddingWithOptionsAsync(string workspaceName, string serviceId, GetTextSparseEmbeddingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputType))
            {
                body["input_type"] = request.InputType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnToken))
            {
                body["return_token"] = request.ReturnToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextSparseEmbedding",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/text-sparse-embedding/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextSparseEmbeddingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本稀疏向量化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextSparseEmbeddingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTextSparseEmbeddingResponse
        /// </returns>
        public GetTextSparseEmbeddingResponse GetTextSparseEmbedding(string workspaceName, string serviceId, GetTextSparseEmbeddingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextSparseEmbeddingWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本稀疏向量化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextSparseEmbeddingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTextSparseEmbeddingResponse
        /// </returns>
        public async Task<GetTextSparseEmbeddingResponse> GetTextSparseEmbeddingAsync(string workspaceName, string serviceId, GetTextSparseEmbeddingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextSparseEmbeddingWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频截帧异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoSnapshotTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoSnapshotTaskStatusResponse
        /// </returns>
        public GetVideoSnapshotTaskStatusResponse GetVideoSnapshotTaskStatusWithOptions(string workspaceName, string serviceId, GetVideoSnapshotTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoSnapshotTaskStatus",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/video-snapshot/" + serviceId + "/async/task-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoSnapshotTaskStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频截帧异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoSnapshotTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoSnapshotTaskStatusResponse
        /// </returns>
        public async Task<GetVideoSnapshotTaskStatusResponse> GetVideoSnapshotTaskStatusWithOptionsAsync(string workspaceName, string serviceId, GetVideoSnapshotTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoSnapshotTaskStatus",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/video-snapshot/" + serviceId + "/async/task-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoSnapshotTaskStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频截帧异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoSnapshotTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoSnapshotTaskStatusResponse
        /// </returns>
        public GetVideoSnapshotTaskStatusResponse GetVideoSnapshotTaskStatus(string workspaceName, string serviceId, GetVideoSnapshotTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetVideoSnapshotTaskStatusWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频截帧异步提取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoSnapshotTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoSnapshotTaskStatusResponse
        /// </returns>
        public async Task<GetVideoSnapshotTaskStatusResponse> GetVideoSnapshotTaskStatusAsync(string workspaceName, string serviceId, GetVideoSnapshotTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetVideoSnapshotTaskStatusWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>联网搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWebSearchResponse
        /// </returns>
        public GetWebSearchResponse GetWebSearchWithOptions(string workspaceName, string serviceId, GetWebSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["content_type"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.History))
            {
                body["history"] = request.History;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryRewrite))
            {
                body["query_rewrite"] = request.QueryRewrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["top_k"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Way))
            {
                body["way"] = request.Way;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebSearch",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/web-search/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebSearchResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>联网搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWebSearchResponse
        /// </returns>
        public async Task<GetWebSearchResponse> GetWebSearchWithOptionsAsync(string workspaceName, string serviceId, GetWebSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["content_type"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.History))
            {
                body["history"] = request.History;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryRewrite))
            {
                body["query_rewrite"] = request.QueryRewrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["top_k"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Way))
            {
                body["way"] = request.Way;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebSearch",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/web-search/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebSearchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>联网搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWebSearchResponse
        /// </returns>
        public GetWebSearchResponse GetWebSearch(string workspaceName, string serviceId, GetWebSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWebSearchWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>联网搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWebSearchResponse
        /// </returns>
        public async Task<GetWebSearchResponse> GetWebSearchAsync(string workspaceName, string serviceId, GetWebSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWebSearchWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

    }
}
