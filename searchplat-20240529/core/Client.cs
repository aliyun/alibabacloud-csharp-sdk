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
        /// <para>存储 Memory 内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryResponse
        /// </returns>
        public CreateMemoryResponse CreateMemoryWithOptions(string workspaceName, string serviceId, CreateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enhancements))
            {
                body["enhancements"] = request.Enhancements;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["run_id"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemory",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/memories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>存储 Memory 内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryResponse
        /// </returns>
        public async Task<CreateMemoryResponse> CreateMemoryWithOptionsAsync(string workspaceName, string serviceId, CreateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enhancements))
            {
                body["enhancements"] = request.Enhancements;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["run_id"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemory",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/memories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>存储 Memory 内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryResponse
        /// </returns>
        public CreateMemoryResponse CreateMemory(string workspaceName, string serviceId, CreateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMemoryWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>存储 Memory 内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryResponse
        /// </returns>
        public async Task<CreateMemoryResponse> CreateMemoryAsync(string workspaceName, string serviceId, CreateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMemoryWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传skill</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemorySkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemorySkillResponse
        /// </returns>
        public CreateMemorySkillResponse CreateMemorySkillWithOptions(string workspaceName, string serviceId, CreateMemorySkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZipBase64))
            {
                body["zip_base64"] = request.ZipBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemorySkill",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/skills",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemorySkillResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传skill</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemorySkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemorySkillResponse
        /// </returns>
        public async Task<CreateMemorySkillResponse> CreateMemorySkillWithOptionsAsync(string workspaceName, string serviceId, CreateMemorySkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZipBase64))
            {
                body["zip_base64"] = request.ZipBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemorySkill",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/skills",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemorySkillResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传skill</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemorySkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemorySkillResponse
        /// </returns>
        public CreateMemorySkillResponse CreateMemorySkill(string workspaceName, string serviceId, CreateMemorySkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMemorySkillWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传skill</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemorySkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemorySkillResponse
        /// </returns>
        public async Task<CreateMemorySkillResponse> CreateMemorySkillAsync(string workspaceName, string serviceId, CreateMemorySkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMemorySkillWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频切割异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoSegmentationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoSegmentationTaskResponse
        /// </returns>
        public CreateVideoSegmentationTaskResponse CreateVideoSegmentationTaskWithOptions(string workspaceName, string serviceId, CreateVideoSegmentationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateVideoSegmentationTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/video-segmentation/" + serviceId + "/async",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoSegmentationTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频切割异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoSegmentationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoSegmentationTaskResponse
        /// </returns>
        public async Task<CreateVideoSegmentationTaskResponse> CreateVideoSegmentationTaskWithOptionsAsync(string workspaceName, string serviceId, CreateVideoSegmentationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateVideoSegmentationTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/video-segmentation/" + serviceId + "/async",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoSegmentationTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频切割异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoSegmentationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoSegmentationTaskResponse
        /// </returns>
        public CreateVideoSegmentationTaskResponse CreateVideoSegmentationTask(string workspaceName, string serviceId, CreateVideoSegmentationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateVideoSegmentationTaskWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频切割异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoSegmentationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoSegmentationTaskResponse
        /// </returns>
        public async Task<CreateVideoSegmentationTaskResponse> CreateVideoSegmentationTaskAsync(string workspaceName, string serviceId, CreateVideoSegmentationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateVideoSegmentationTaskWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
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
        /// <para>创建视频总结异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoSummarizationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoSummarizationTaskResponse
        /// </returns>
        public CreateVideoSummarizationTaskResponse CreateVideoSummarizationTaskWithOptions(string workspaceName, string serviceId, CreateVideoSummarizationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateVideoSummarizationTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/video-summarization/" + serviceId + "/async",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoSummarizationTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频总结异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoSummarizationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoSummarizationTaskResponse
        /// </returns>
        public async Task<CreateVideoSummarizationTaskResponse> CreateVideoSummarizationTaskWithOptionsAsync(string workspaceName, string serviceId, CreateVideoSummarizationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateVideoSummarizationTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/video-summarization/" + serviceId + "/async",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoSummarizationTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频总结异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoSummarizationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoSummarizationTaskResponse
        /// </returns>
        public CreateVideoSummarizationTaskResponse CreateVideoSummarizationTask(string workspaceName, string serviceId, CreateVideoSummarizationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateVideoSummarizationTaskWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频总结异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoSummarizationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoSummarizationTaskResponse
        /// </returns>
        public async Task<CreateVideoSummarizationTaskResponse> CreateVideoSummarizationTaskAsync(string workspaceName, string serviceId, CreateVideoSummarizationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateVideoSummarizationTaskWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一条 Memory</para>
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
        public DeleteMemoryResponse DeleteMemoryWithOptions(string workspaceName, string serviceId, string memoryId, DeleteMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemory",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/memories/" + memoryId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一条 Memory</para>
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
        public async Task<DeleteMemoryResponse> DeleteMemoryWithOptionsAsync(string workspaceName, string serviceId, string memoryId, DeleteMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemory",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/memories/" + memoryId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一条 Memory</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryResponse
        /// </returns>
        public DeleteMemoryResponse DeleteMemory(string workspaceName, string serviceId, string memoryId, DeleteMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMemoryWithOptions(workspaceName, serviceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一条 Memory</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryResponse
        /// </returns>
        public async Task<DeleteMemoryResponse> DeleteMemoryAsync(string workspaceName, string serviceId, string memoryId, DeleteMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMemoryWithOptionsAsync(workspaceName, serviceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除skill</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemorySkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemorySkillResponse
        /// </returns>
        public DeleteMemorySkillResponse DeleteMemorySkillWithOptions(string workspaceName, string serviceId, string skillId, DeleteMemorySkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemorySkill",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/skills/" + skillId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemorySkillResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除skill</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemorySkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemorySkillResponse
        /// </returns>
        public async Task<DeleteMemorySkillResponse> DeleteMemorySkillWithOptionsAsync(string workspaceName, string serviceId, string skillId, DeleteMemorySkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemorySkill",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/skills/" + skillId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemorySkillResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除skill</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemorySkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemorySkillResponse
        /// </returns>
        public DeleteMemorySkillResponse DeleteMemorySkill(string workspaceName, string serviceId, string skillId, DeleteMemorySkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMemorySkillWithOptions(workspaceName, serviceId, skillId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除skill</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemorySkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemorySkillResponse
        /// </returns>
        public async Task<DeleteMemorySkillResponse> DeleteMemorySkillAsync(string workspaceName, string serviceId, string skillId, DeleteMemorySkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMemorySkillWithOptionsAsync(workspaceName, serviceId, skillId, request, headers, runtime);
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
        /// <para>图片主体检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageObjectDetectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageObjectDetectionResponse
        /// </returns>
        public GetImageObjectDetectionResponse GetImageObjectDetectionWithOptions(string workspaceName, string serviceId, GetImageObjectDetectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                body["image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageObjectDetection",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/image-object-detection/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageObjectDetectionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片主体检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageObjectDetectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageObjectDetectionResponse
        /// </returns>
        public async Task<GetImageObjectDetectionResponse> GetImageObjectDetectionWithOptionsAsync(string workspaceName, string serviceId, GetImageObjectDetectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                body["image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageObjectDetection",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/image-object-detection/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageObjectDetectionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片主体检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageObjectDetectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageObjectDetectionResponse
        /// </returns>
        public GetImageObjectDetectionResponse GetImageObjectDetection(string workspaceName, string serviceId, GetImageObjectDetectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetImageObjectDetectionWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片主体检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageObjectDetectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageObjectDetectionResponse
        /// </returns>
        public async Task<GetImageObjectDetectionResponse> GetImageObjectDetectionAsync(string workspaceName, string serviceId, GetImageObjectDetectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetImageObjectDetectionWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看memory详情</para>
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
        public GetMemoryResponse GetMemoryWithOptions(string workspaceName, string serviceId, string memoryId, GetMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemory",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/memories/" + memoryId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看memory详情</para>
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
        public async Task<GetMemoryResponse> GetMemoryWithOptionsAsync(string workspaceName, string serviceId, string memoryId, GetMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemory",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/memories/" + memoryId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看memory详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryResponse
        /// </returns>
        public GetMemoryResponse GetMemory(string workspaceName, string serviceId, string memoryId, GetMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoryWithOptions(workspaceName, serviceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看memory详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryResponse
        /// </returns>
        public async Task<GetMemoryResponse> GetMemoryAsync(string workspaceName, string serviceId, string memoryId, GetMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoryWithOptionsAsync(workspaceName, serviceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查 Memory 服务健康状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryHealthRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryHealthResponse
        /// </returns>
        public GetMemoryHealthResponse GetMemoryHealthWithOptions(string workspaceName, string serviceId, GetMemoryHealthRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryHealth",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/health",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryHealthResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查 Memory 服务健康状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryHealthRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryHealthResponse
        /// </returns>
        public async Task<GetMemoryHealthResponse> GetMemoryHealthWithOptionsAsync(string workspaceName, string serviceId, GetMemoryHealthRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryHealth",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/health",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryHealthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查 Memory 服务健康状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryHealthRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryHealthResponse
        /// </returns>
        public GetMemoryHealthResponse GetMemoryHealth(string workspaceName, string serviceId, GetMemoryHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoryHealthWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查 Memory 服务健康状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryHealthRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryHealthResponse
        /// </returns>
        public async Task<GetMemoryHealthResponse> GetMemoryHealthAsync(string workspaceName, string serviceId, GetMemoryHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoryHealthWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看skill详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemorySkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemorySkillResponse
        /// </returns>
        public GetMemorySkillResponse GetMemorySkillWithOptions(string workspaceName, string serviceId, string skillId, GetMemorySkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemorySkill",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/skills/" + skillId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemorySkillResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看skill详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemorySkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemorySkillResponse
        /// </returns>
        public async Task<GetMemorySkillResponse> GetMemorySkillWithOptionsAsync(string workspaceName, string serviceId, string skillId, GetMemorySkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemorySkill",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/skills/" + skillId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemorySkillResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看skill详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemorySkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemorySkillResponse
        /// </returns>
        public GetMemorySkillResponse GetMemorySkill(string workspaceName, string serviceId, string skillId, GetMemorySkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemorySkillWithOptions(workspaceName, serviceId, skillId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看skill详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemorySkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemorySkillResponse
        /// </returns>
        public async Task<GetMemorySkillResponse> GetMemorySkillAsync(string workspaceName, string serviceId, string skillId, GetMemorySkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemorySkillWithOptionsAsync(workspaceName, serviceId, skillId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询memory异步任务的处理状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryTaskResponse
        /// </returns>
        public GetMemoryTaskResponse GetMemoryTaskWithOptions(string workspaceName, string serviceId, string taskId, GetMemoryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询memory异步任务的处理状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryTaskResponse
        /// </returns>
        public async Task<GetMemoryTaskResponse> GetMemoryTaskWithOptionsAsync(string workspaceName, string serviceId, string taskId, GetMemoryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryTask",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询memory异步任务的处理状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryTaskResponse
        /// </returns>
        public GetMemoryTaskResponse GetMemoryTask(string workspaceName, string serviceId, string taskId, GetMemoryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoryTaskWithOptions(workspaceName, serviceId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询memory异步任务的处理状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryTaskResponse
        /// </returns>
        public async Task<GetMemoryTaskResponse> GetMemoryTaskAsync(string workspaceName, string serviceId, string taskId, GetMemoryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoryTaskWithOptionsAsync(workspaceName, serviceId, taskId, request, headers, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
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
        /// <para>多模态 Reranker</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiModalRerankerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMultiModalRerankerResponse
        /// </returns>
        public GetMultiModalRerankerResponse GetMultiModalRerankerWithOptions(string workspaceName, string serviceId, GetMultiModalRerankerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Docs))
            {
                body["docs"] = request.Docs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
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
                Action = "GetMultiModalReranker",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/multi-modal-reranker/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMultiModalRerankerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多模态 Reranker</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiModalRerankerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMultiModalRerankerResponse
        /// </returns>
        public async Task<GetMultiModalRerankerResponse> GetMultiModalRerankerWithOptionsAsync(string workspaceName, string serviceId, GetMultiModalRerankerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Docs))
            {
                body["docs"] = request.Docs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
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
                Action = "GetMultiModalReranker",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/multi-modal-reranker/" + serviceId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMultiModalRerankerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多模态 Reranker</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiModalRerankerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMultiModalRerankerResponse
        /// </returns>
        public GetMultiModalRerankerResponse GetMultiModalReranker(string workspaceName, string serviceId, GetMultiModalRerankerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMultiModalRerankerWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多模态 Reranker</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiModalRerankerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMultiModalRerankerResponse
        /// </returns>
        public async Task<GetMultiModalRerankerResponse> GetMultiModalRerankerAsync(string workspaceName, string serviceId, GetMultiModalRerankerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMultiModalRerankerWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
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
        /// <para>获取视频切割异步任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoSegmentationTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoSegmentationTaskStatusResponse
        /// </returns>
        public GetVideoSegmentationTaskStatusResponse GetVideoSegmentationTaskStatusWithOptions(string workspaceName, string serviceId, GetVideoSegmentationTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetVideoSegmentationTaskStatus",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/video-segmentation/" + serviceId + "/async/task-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoSegmentationTaskStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频切割异步任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoSegmentationTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoSegmentationTaskStatusResponse
        /// </returns>
        public async Task<GetVideoSegmentationTaskStatusResponse> GetVideoSegmentationTaskStatusWithOptionsAsync(string workspaceName, string serviceId, GetVideoSegmentationTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetVideoSegmentationTaskStatus",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/video-segmentation/" + serviceId + "/async/task-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoSegmentationTaskStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频切割异步任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoSegmentationTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoSegmentationTaskStatusResponse
        /// </returns>
        public GetVideoSegmentationTaskStatusResponse GetVideoSegmentationTaskStatus(string workspaceName, string serviceId, GetVideoSegmentationTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetVideoSegmentationTaskStatusWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频切割异步任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoSegmentationTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoSegmentationTaskStatusResponse
        /// </returns>
        public async Task<GetVideoSegmentationTaskStatusResponse> GetVideoSegmentationTaskStatusAsync(string workspaceName, string serviceId, GetVideoSegmentationTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetVideoSegmentationTaskStatusWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
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
        /// <para>获取视频总结异步任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoSummarizationTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoSummarizationTaskStatusResponse
        /// </returns>
        public GetVideoSummarizationTaskStatusResponse GetVideoSummarizationTaskStatusWithOptions(string workspaceName, string serviceId, GetVideoSummarizationTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetVideoSummarizationTaskStatus",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/video-summarization/" + serviceId + "/async/task-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoSummarizationTaskStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频总结异步任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoSummarizationTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoSummarizationTaskStatusResponse
        /// </returns>
        public async Task<GetVideoSummarizationTaskStatusResponse> GetVideoSummarizationTaskStatusWithOptionsAsync(string workspaceName, string serviceId, GetVideoSummarizationTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetVideoSummarizationTaskStatus",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/video-summarization/" + serviceId + "/async/task-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoSummarizationTaskStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频总结异步任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoSummarizationTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoSummarizationTaskStatusResponse
        /// </returns>
        public GetVideoSummarizationTaskStatusResponse GetVideoSummarizationTaskStatus(string workspaceName, string serviceId, GetVideoSummarizationTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetVideoSummarizationTaskStatusWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频总结异步任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoSummarizationTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoSummarizationTaskStatusResponse
        /// </returns>
        public async Task<GetVideoSummarizationTaskStatusResponse> GetVideoSummarizationTaskStatusAsync(string workspaceName, string serviceId, GetVideoSummarizationTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetVideoSummarizationTaskStatusWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据查询条件搜索 Memory</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchMemoryResponse
        /// </returns>
        public SearchMemoryResponse SearchMemoryWithOptions(string workspaceName, string serviceId, SearchMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enhancements))
            {
                body["enhancements"] = request.Enhancements;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["run_id"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMemory",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMemoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据查询条件搜索 Memory</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchMemoryResponse
        /// </returns>
        public async Task<SearchMemoryResponse> SearchMemoryWithOptionsAsync(string workspaceName, string serviceId, SearchMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enhancements))
            {
                body["enhancements"] = request.Enhancements;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["run_id"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMemory",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMemoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据查询条件搜索 Memory</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchMemoryResponse
        /// </returns>
        public SearchMemoryResponse SearchMemory(string workspaceName, string serviceId, SearchMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchMemoryWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据查询条件搜索 Memory</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchMemoryResponse
        /// </returns>
        public async Task<SearchMemoryResponse> SearchMemoryAsync(string workspaceName, string serviceId, SearchMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchMemoryWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Memory</para>
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
        public UpdateMemoryResponse UpdateMemoryWithOptions(string workspaceName, string serviceId, string memoryId, UpdateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["memory"] = request.Memory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemory",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/memories/" + memoryId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Memory</para>
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
        public async Task<UpdateMemoryResponse> UpdateMemoryWithOptionsAsync(string workspaceName, string serviceId, string memoryId, UpdateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["memory"] = request.Memory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemory",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/memories/" + memoryId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Memory</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryResponse
        /// </returns>
        public UpdateMemoryResponse UpdateMemory(string workspaceName, string serviceId, string memoryId, UpdateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMemoryWithOptions(workspaceName, serviceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Memory</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryResponse
        /// </returns>
        public async Task<UpdateMemoryResponse> UpdateMemoryAsync(string workspaceName, string serviceId, string memoryId, UpdateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMemoryWithOptionsAsync(workspaceName, serviceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Skill</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemorySkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemorySkillResponse
        /// </returns>
        public UpdateMemorySkillResponse UpdateMemorySkillWithOptions(string workspaceName, string serviceId, string skillId, UpdateMemorySkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemorySkill",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/skills/" + skillId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemorySkillResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Skill</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemorySkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemorySkillResponse
        /// </returns>
        public async Task<UpdateMemorySkillResponse> UpdateMemorySkillWithOptionsAsync(string workspaceName, string serviceId, string skillId, UpdateMemorySkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemorySkill",
                Version = "2024-05-29",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/memory/" + serviceId + "/skills/" + skillId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemorySkillResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Skill</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemorySkillRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemorySkillResponse
        /// </returns>
        public UpdateMemorySkillResponse UpdateMemorySkill(string workspaceName, string serviceId, string skillId, UpdateMemorySkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMemorySkillWithOptions(workspaceName, serviceId, skillId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Skill</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemorySkillRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemorySkillResponse
        /// </returns>
        public async Task<UpdateMemorySkillResponse> UpdateMemorySkillAsync(string workspaceName, string serviceId, string skillId, UpdateMemorySkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMemorySkillWithOptionsAsync(workspaceName, serviceId, skillId, request, headers, runtime);
        }

    }
}
