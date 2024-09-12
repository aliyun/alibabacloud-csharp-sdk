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
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
        }


        /**
         * @summary 创建文档解析异步提取任务
         *
         * @param request CreateDocumentAnalyzeTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDocumentAnalyzeTaskResponse
         */
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

        /**
         * @summary 创建文档解析异步提取任务
         *
         * @param request CreateDocumentAnalyzeTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDocumentAnalyzeTaskResponse
         */
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

        /**
         * @summary 创建文档解析异步提取任务
         *
         * @param request CreateDocumentAnalyzeTaskRequest
         * @return CreateDocumentAnalyzeTaskResponse
         */
        public CreateDocumentAnalyzeTaskResponse CreateDocumentAnalyzeTask(string workspaceName, string serviceId, CreateDocumentAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDocumentAnalyzeTaskWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 创建文档解析异步提取任务
         *
         * @param request CreateDocumentAnalyzeTaskRequest
         * @return CreateDocumentAnalyzeTaskResponse
         */
        public async Task<CreateDocumentAnalyzeTaskResponse> CreateDocumentAnalyzeTaskAsync(string workspaceName, string serviceId, CreateDocumentAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDocumentAnalyzeTaskWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 创建图片解析异步提取任务
         *
         * @param request CreateImageAnalyzeTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateImageAnalyzeTaskResponse
         */
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

        /**
         * @summary 创建图片解析异步提取任务
         *
         * @param request CreateImageAnalyzeTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateImageAnalyzeTaskResponse
         */
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

        /**
         * @summary 创建图片解析异步提取任务
         *
         * @param request CreateImageAnalyzeTaskRequest
         * @return CreateImageAnalyzeTaskResponse
         */
        public CreateImageAnalyzeTaskResponse CreateImageAnalyzeTask(string workspaceName, string serviceId, CreateImageAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateImageAnalyzeTaskWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 创建图片解析异步提取任务
         *
         * @param request CreateImageAnalyzeTaskRequest
         * @return CreateImageAnalyzeTaskResponse
         */
        public async Task<CreateImageAnalyzeTaskResponse> CreateImageAnalyzeTaskAsync(string workspaceName, string serviceId, CreateImageAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateImageAnalyzeTaskWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 获取文档解析异步提取任务状态
         *
         * @param request GetDocumentAnalyzeTaskStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentAnalyzeTaskStatusResponse
         */
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

        /**
         * @summary 获取文档解析异步提取任务状态
         *
         * @param request GetDocumentAnalyzeTaskStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentAnalyzeTaskStatusResponse
         */
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

        /**
         * @summary 获取文档解析异步提取任务状态
         *
         * @param request GetDocumentAnalyzeTaskStatusRequest
         * @return GetDocumentAnalyzeTaskStatusResponse
         */
        public GetDocumentAnalyzeTaskStatusResponse GetDocumentAnalyzeTaskStatus(string workspaceName, string serviceId, GetDocumentAnalyzeTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentAnalyzeTaskStatusWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 获取文档解析异步提取任务状态
         *
         * @param request GetDocumentAnalyzeTaskStatusRequest
         * @return GetDocumentAnalyzeTaskStatusResponse
         */
        public async Task<GetDocumentAnalyzeTaskStatusResponse> GetDocumentAnalyzeTaskStatusAsync(string workspaceName, string serviceId, GetDocumentAnalyzeTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentAnalyzeTaskStatusWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 文档相关性打分
         *
         * @param request GetDocumentRankRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentRankResponse
         */
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

        /**
         * @summary 文档相关性打分
         *
         * @param request GetDocumentRankRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentRankResponse
         */
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

        /**
         * @summary 文档相关性打分
         *
         * @param request GetDocumentRankRequest
         * @return GetDocumentRankResponse
         */
        public GetDocumentRankResponse GetDocumentRank(string workspaceName, string serviceId, GetDocumentRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentRankWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 文档相关性打分
         *
         * @param request GetDocumentRankRequest
         * @return GetDocumentRankResponse
         */
        public async Task<GetDocumentRankResponse> GetDocumentRankAsync(string workspaceName, string serviceId, GetDocumentRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentRankWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 文档切片
         *
         * @param request GetDocumentSplitRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentSplitResponse
         */
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

        /**
         * @summary 文档切片
         *
         * @param request GetDocumentSplitRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentSplitResponse
         */
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

        /**
         * @summary 文档切片
         *
         * @param request GetDocumentSplitRequest
         * @return GetDocumentSplitResponse
         */
        public GetDocumentSplitResponse GetDocumentSplit(string workspaceName, string serviceId, GetDocumentSplitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentSplitWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 文档切片
         *
         * @param request GetDocumentSplitRequest
         * @return GetDocumentSplitResponse
         */
        public async Task<GetDocumentSplitResponse> GetDocumentSplitAsync(string workspaceName, string serviceId, GetDocumentSplitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentSplitWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 获取图片解析异步提取任务状态
         *
         * @param request GetImageAnalyzeTaskStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetImageAnalyzeTaskStatusResponse
         */
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

        /**
         * @summary 获取图片解析异步提取任务状态
         *
         * @param request GetImageAnalyzeTaskStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetImageAnalyzeTaskStatusResponse
         */
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

        /**
         * @summary 获取图片解析异步提取任务状态
         *
         * @param request GetImageAnalyzeTaskStatusRequest
         * @return GetImageAnalyzeTaskStatusResponse
         */
        public GetImageAnalyzeTaskStatusResponse GetImageAnalyzeTaskStatus(string workspaceName, string serviceId, GetImageAnalyzeTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetImageAnalyzeTaskStatusWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 获取图片解析异步提取任务状态
         *
         * @param request GetImageAnalyzeTaskStatusRequest
         * @return GetImageAnalyzeTaskStatusResponse
         */
        public async Task<GetImageAnalyzeTaskStatusResponse> GetImageAnalyzeTaskStatusAsync(string workspaceName, string serviceId, GetImageAnalyzeTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetImageAnalyzeTaskStatusWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 获取query分析结果
         *
         * @param request GetQueryAnalysisRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQueryAnalysisResponse
         */
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

        /**
         * @summary 获取query分析结果
         *
         * @param request GetQueryAnalysisRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQueryAnalysisResponse
         */
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

        /**
         * @summary 获取query分析结果
         *
         * @param request GetQueryAnalysisRequest
         * @return GetQueryAnalysisResponse
         */
        public GetQueryAnalysisResponse GetQueryAnalysis(string workspaceName, string serviceId, GetQueryAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQueryAnalysisWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 获取query分析结果
         *
         * @param request GetQueryAnalysisRequest
         * @return GetQueryAnalysisResponse
         */
        public async Task<GetQueryAnalysisResponse> GetQueryAnalysisAsync(string workspaceName, string serviceId, GetQueryAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQueryAnalysisWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 文本向量化
         *
         * @param request GetTextEmbeddingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextEmbeddingResponse
         */
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

        /**
         * @summary 文本向量化
         *
         * @param request GetTextEmbeddingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextEmbeddingResponse
         */
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

        /**
         * @summary 文本向量化
         *
         * @param request GetTextEmbeddingRequest
         * @return GetTextEmbeddingResponse
         */
        public GetTextEmbeddingResponse GetTextEmbedding(string workspaceName, string serviceId, GetTextEmbeddingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextEmbeddingWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 文本向量化
         *
         * @param request GetTextEmbeddingRequest
         * @return GetTextEmbeddingResponse
         */
        public async Task<GetTextEmbeddingResponse> GetTextEmbeddingAsync(string workspaceName, string serviceId, GetTextEmbeddingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextEmbeddingWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 大模型问答
         *
         * @param request GetTextGenerationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextGenerationResponse
         */
        public GetTextGenerationResponse GetTextGenerationWithOptions(string workspaceName, string serviceId, GetTextGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsiLevel))
            {
                body["csi_level"] = request.CsiLevel;
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

        /**
         * @summary 大模型问答
         *
         * @param request GetTextGenerationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextGenerationResponse
         */
        public async Task<GetTextGenerationResponse> GetTextGenerationWithOptionsAsync(string workspaceName, string serviceId, GetTextGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsiLevel))
            {
                body["csi_level"] = request.CsiLevel;
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

        /**
         * @summary 大模型问答
         *
         * @param request GetTextGenerationRequest
         * @return GetTextGenerationResponse
         */
        public GetTextGenerationResponse GetTextGeneration(string workspaceName, string serviceId, GetTextGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextGenerationWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 大模型问答
         *
         * @param request GetTextGenerationRequest
         * @return GetTextGenerationResponse
         */
        public async Task<GetTextGenerationResponse> GetTextGenerationAsync(string workspaceName, string serviceId, GetTextGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextGenerationWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 文本稀疏向量化
         *
         * @param request GetTextSparseEmbeddingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextSparseEmbeddingResponse
         */
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

        /**
         * @summary 文本稀疏向量化
         *
         * @param request GetTextSparseEmbeddingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextSparseEmbeddingResponse
         */
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

        /**
         * @summary 文本稀疏向量化
         *
         * @param request GetTextSparseEmbeddingRequest
         * @return GetTextSparseEmbeddingResponse
         */
        public GetTextSparseEmbeddingResponse GetTextSparseEmbedding(string workspaceName, string serviceId, GetTextSparseEmbeddingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextSparseEmbeddingWithOptions(workspaceName, serviceId, request, headers, runtime);
        }

        /**
         * @summary 文本稀疏向量化
         *
         * @param request GetTextSparseEmbeddingRequest
         * @return GetTextSparseEmbeddingResponse
         */
        public async Task<GetTextSparseEmbeddingResponse> GetTextSparseEmbeddingAsync(string workspaceName, string serviceId, GetTextSparseEmbeddingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextSparseEmbeddingWithOptionsAsync(workspaceName, serviceId, request, headers, runtime);
        }

    }
}
